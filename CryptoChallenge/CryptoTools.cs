using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoChallenge
{
	public class CryptoTools
	{

		public static byte[] HexStringToByteArray(string hexString)
		{
			if (hexString.Length % 2 != 0) return null;

			var b = new byte[hexString.Length / 2];
			for (var i = 0; i < hexString.Length/2; i++)
				b[i] = Convert.ToByte(Convert.ToByte(hexString.Substring(i * 2, 2),16));
			return b;
		}

		public static string ToBase64(byte[] b)
		{
			return Convert.ToBase64String(b);
		}

		public static byte[] XorByteArrays(byte[] b1, byte[] b2)
		{
			if (b1.Length != b2.Length) return null;

			var r = new byte[b1.Length];
			for (var i = 0; i < b1.Length; i++)
			{
				r[i] = (byte)((int)b1[i] ^ (int)b2[i]);
			}
			return r;
		}

		public static string ByteArrayToHexString(byte[] b)
		{
			return BitConverter.ToString(b).Replace("-", "");
		}


		public static string ScoreXor(string hexEncodedString)
		{
			var xorByteArray = CryptoTools.HexStringToByteArray(hexEncodedString);
			var highestScore = 0m;
			var highestScoreText = string.Empty;
			for (var i = 0; i <= 255; i++)
			{
				var resArray = new byte[xorByteArray.Length];
				for (var x = 0; x < resArray.Length; x++)
				{
					resArray[x] = (byte)((int)xorByteArray[x] ^ i);
				}
				var score = CryptoTools.CountPrintables(resArray);
				if (score > highestScore)
				{
					highestScore = score;
					highestScoreText = Encoding.UTF8.GetString(resArray);
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
		public static decimal CountPrintables(byte[] b)
		{
			decimal score = 0;
			foreach (var sb in b)
			{
				if (sb == 32)
					score += 3;
				else if (sb > 127 || sb < 32)
					continue;
				if (sb > 32 && sb <=64)
					score += 1;
				else if (sb >= 65 && sb<=90)
					score += 2;
				else if (sb >= 97 && sb <= 122)
					score += 3;
				else
					score += 1;
			}
			return score;
		}
	}
}
