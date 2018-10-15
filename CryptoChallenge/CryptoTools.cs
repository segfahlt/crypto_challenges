using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoChallenge
{
	public class CryptoTools
	{

		public static byte[] HexStringToByteArray(string hexString)
		{
			if (hexString.Length % 2 != 0) return null;

			var b = new byte[hexString.Length / 2];
			for (var i = 0; i < hexString.Length / 2; i++)
				b[i] = Convert.ToByte(Convert.ToByte(hexString.Substring(i * 2, 2), 16));
			return b;
		}
		public static string ByteArrayToHexString(byte[] b)
		{
			return BitConverter.ToString(b).Replace("-", "");
		}

		public static string ToBase64(byte[] b)
		{
			return Convert.ToBase64String(b);
		}

		public static string HexStringToBase64(string hexString)
		{
			return ToBase64(HexStringToByteArray(hexString));
		}

		public static byte[] Xor(byte[] b1, byte[] b2)
		{
			if (b1.Length != b2.Length) return null;
			var r = new byte[b1.Length];
			for (var i = 0; i < b1.Length; i++)
				r[i] = (byte)(b1[i] ^ b2[i]);
			return r;
		}

		public static byte[] RepeatingCharXor(byte[] key, byte[] target)
		{
			var r = new byte[target.Length];
			var tidx = 0;
			while (tidx < target.Length)
			{
				foreach (var kchar in key)
				{
					r[tidx] = (byte)(kchar ^ target[tidx]);
					if (++tidx >= target.Length) break;
				}
			}
			return r;
		}

		public static byte[] Xor(byte b1, byte[] b2)
		{
			var r = new byte[b2.Length];
			for (var i = 0; i < b2.Length; i++)
				r[i] = (byte)(b1 ^ b2[i]);
			return r;
		}

		public static string FindAndDecode(string hexEncodedString, out int highestScore, out byte encryptionChar)
		{
			var xorByteArray = CryptoTools.HexStringToByteArray(hexEncodedString);
			return FindAndDecode(xorByteArray, out highestScore, out encryptionChar);
		}
		public static string FindAndDecode(byte[] source, out int highestScore, out byte encryptionChar)
		{
			highestScore = 0;
			var highestScoreText = string.Empty;
			encryptionChar = (byte)0;
			for (var i = 0; i <= 255; i++)
			{
				var resArray = Xor((byte)i, source);
				var score = CryptoTools.CountPrintables(resArray);
				if (score > highestScore)
				{
					highestScore = score;
					highestScoreText = Encoding.UTF8.GetString(resArray);
					encryptionChar = (byte)i;
				}
			}
			return highestScoreText;
		}

		//ASCII < 32 = 0
		//ASCII 32 - 64 = 1
		//ASCII 65-90 = 2
		//ASCII 97-122 = 3
		//All Others get 1
		//>128 = 0
		public static int CountPrintables(byte[] b)
		{
			int score = 0;
			foreach (var sb in b)
			{
				if (sb == 32)
					score += 3;
				else if (sb > 127 || sb < 32)
					continue;
				if (sb > 32 && sb <= 64)
					score += 1;
				else if (sb >= 65 && sb <= 90)
					score += 2;
				else if (sb >= 97 && sb <= 122)
					score += 3;
				else
					score += 1;
			}
			return score;
		}

		public static int HammingDistance(string s1, string s2)
		{
			if (s1.Length != s2.Length)
				return 0;
			var hamming = 0;
			return HammingDistance(Encoding.UTF8.GetBytes(s1), Encoding.UTF8.GetBytes(s2));
		}
		public static int HammingDistance(byte[] b1, byte[] b2)
		{
			if (b1.Length != b2.Length)
				return 0;
			var hamming = 0;
			var bas1 = new BitArray(b1);
			var bas2 = new BitArray(b2);
			for (var i = 0; i < bas1.Length; i++)
			{
				if (bas1[i] != bas2[i]) hamming++;
			}
			return hamming;
		}

		public static string BreakRepeatingKeyXor(string encryptedBase64Text)
		{
			var encryptedByteArray = Convert.FromBase64String(encryptedBase64Text);
			return BreakRepeatingKeyXor(encryptedByteArray);
		}

		public static string BreakRepeatingKeyXor(byte[] encryptedByteArray)
		{

			var keySizeHamming = new List<Tuple<int, decimal>>();
			for (var keySize = 2; keySize <= 40; keySize++)
			{
				var firstChunk = encryptedByteArray.Take(keySize).ToArray();
				var secondChunk = encryptedByteArray.Skip(keySize).Take(keySize).ToArray();
				decimal hammingDistance = HammingDistance(firstChunk, secondChunk);
				decimal normalizedHamming = hammingDistance / keySize;
				keySizeHamming.Add(new Tuple<int, decimal>(keySize,normalizedHamming));
			}

			var keySizes = keySizeHamming.OrderBy(f => f.Item2).ToList();

			var keyData = new Dictionary<int,byte[]>();
			var maxPrintableCount = 0;
			byte[] chosenKey = null;

			//Now we'll decode each of them.
			foreach (var keySize in keySizes)
			{
				var key = new byte[keySize.Item1];
				var transposedBytes = TransposeBytes(encryptedByteArray, keySize.Item1);
				var keyPosition = 0;
				foreach (var keyPositionToBreak in transposedBytes)
				{
					var encryptionChar = (byte)0;
					var score = 0;
					FindAndDecode(keyPositionToBreak, out score, out encryptionChar);
					key[keyPosition++] = encryptionChar;
				}
				keyData.Add(keySize.Item1, key);

				//okay, no we need to xor our key with the source and see if it makes any sense.
				var keyStr = Encoding.UTF8.GetString(key);
				var decryptedArr = RepeatingCharXor(key, encryptedByteArray);
				var printableCount = CountPrintables(decryptedArr);
				if (printableCount > maxPrintableCount)
				{
					maxPrintableCount = printableCount;
					chosenKey = key;
				}
			}

			var decrypted = RepeatingCharXor(chosenKey, encryptedByteArray);
			return Encoding.UTF8.GetString(decrypted);
		}

		public static List<byte[]> TransposeBytes(byte[] source, int keySize)
		{
			var r = new List<byte[]>();
			for (var i = 0; i < keySize; i++)
				r.Add(TransposeBytes(source, keySize, i));
			return r;
		}

		public static byte[] TransposeBytes(byte[] source, int keySize, int position)
		{
			var list = new List<byte>();
			for(var i = position; i<source.Length;i+=keySize)
				list.Add(source[i]);
			return list.ToArray();
		}

		public static byte[] DecryptAesEcb(byte[] key, byte[] source)
		{
			var rDel = new RijndaelManaged { KeySize = (key.Length * 8), Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.None};
			var cTransform = rDel.CreateDecryptor();
			byte[] resultArray = cTransform.TransformFinalBlock(source, 0, source.Length);
			return resultArray;
		}
		public static byte[] EncryptAesEcb(byte[] key, byte[] source)
		{
			var iv = new byte[key.Length];
			var rDel = new RijndaelManaged { KeySize = (key.Length * 8), Key = key, Mode = CipherMode.ECB, Padding = PaddingMode.None };
			var cTransform = rDel.CreateEncryptor(key, iv);
			byte[] resultArray = cTransform.TransformFinalBlock(source, 0, source.Length);
			return resultArray;
		}

		public static byte[] PadToMultiple(byte[] source, int multipleOf)
		{
			var leftOver = source.Length % multipleOf;
			if (leftOver > 0) leftOver = multipleOf - leftOver;

			var result = new byte[source.Length + leftOver];
			for (var i = 0; i < source.Length; i++)
				result[i] = source[i];
			for (var i = source.Length; i < result.Length; i++)
				result[i] = (byte) leftOver;
			return result;
		}

		public static byte[] GetChunk(byte[] source, int chunkSize, int chunkNumber)
		{
			return source.Skip(chunkSize * chunkNumber).Take(chunkSize).ToArray();
		}

		public static List<byte[]> Chunkify(byte[] source, int chunkSize)
		{
			var result = new List<byte[]>();
			for (var i = 0; i < source.Length / chunkSize; i++)
				result.Add(GetChunk(source,chunkSize,i));
			return result;
		}
		public static string CbcDecrypt(byte[] key, byte[] iv, byte[] source)
		{
			var chunks = Chunkify(source, key.Length);
			var additionArray = iv;
			var res = new List<string>();
			foreach (var chunk in chunks)
			{
				var decrypted = DecryptAesEcb(key, chunk);
				var step1Array = Xor(additionArray, decrypted);
				res.Add(Encoding.UTF8.GetString(step1Array));
				additionArray = chunk;
			}

			var returnString = string.Join("", res);
			return returnString;
		}


	}
}
