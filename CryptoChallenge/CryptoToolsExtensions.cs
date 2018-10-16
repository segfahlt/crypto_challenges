using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CryptoChallenge
{
	public static class CryptoToolsExtensions
	{
		public static bool IsHexString(this string hexString)
		{
			//TODO: Reality check: Make sure it looks like a hex string
			var m = Regex.Match(hexString.ToLower(), @"^[a-f\d]+$");
			return m.Success;
		}
		public static byte[] AsHexToByteArray(this string hexString)
		{
			//For each 2 characters, convert them into their equivalent byte value.
			//so 00 = 0
			//FF = 256
			if (hexString.Length % 2 != 0) return null;

			if (!hexString.IsHexString())
			{
				System.Diagnostics.Debug.Print("Not a Hex String");
				return null;
			}

			var b = new byte[hexString.Length / 2];
			for (var i = 0; i < hexString.Length / 2; i++)
				b[i] = Convert.ToByte(Convert.ToByte(hexString.Substring(i * 2, 2), 16));
			return b;

		}

		public static string ToHexString(this byte[] ba)
		{
			return BitConverter.ToString(ba).Replace("-", "");
		}

		public static string ToBase64(this byte[] b)
		{
			return Convert.ToBase64String(b);
		}
		public static string AsHexStringToBase64(this string hexString)
		{
			if (!hexString.IsHexString())
			{
				System.Diagnostics.Debug.Print("Not a Hex String");
				return null;
			}

			return hexString.AsHexToByteArray().ToBase64();
		}

		/// <summary>
		/// Xors the byte with each byte in the target byte array.
		/// </summary>
		/// <param name="src"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public static byte[] Xor(this byte src, byte[] target)
		{
			var r = new byte[target.Length];
			for (var i = 0; i < target.Length; i++)
				r[i] = (byte)(src ^ target[i]);
			return r;
		}
		/// <summary>
		/// Xors the int with each byte in the target byte array.
		/// </summary>
		/// <param name="src"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public static byte[] Xor(this int src, byte[] target)
		{
			var r = new byte[target.Length];
			for (var i = 0; i < target.Length; i++)
				r[i] = (byte)(src ^ target[i]);
			return r;
		}

		/// <summary>
		/// XORs the byte-array by the argument.  Arrays must be of equal length
		/// </summary>
		/// <param name="src"></param>
		/// <param name="apply"></param>
		/// <returns></returns>
		public static byte[] Xor(this byte[] src, byte[] apply)
		{
			if (src.Length != apply.Length)
			{
				System.Diagnostics.Debug.Print("Byte arrays are not of equal length");
				return null;
			}
			var r = new byte[src.Length];
			for (var i = 0; i < src.Length; i++)
				r[i] = (byte)(src[i] ^ apply[i]);
			return r;
		}

		/// <summary>
		/// repeatedly XORS the source byte array to the apply byte array, byte-by-byte.
		/// If apply.length is not a multiple of srce.length, then it will just just part of src to get to apply.length
		/// </summary>
		/// <param name="src"></param>
		/// <param name="apply"></param>
		/// <returns></returns>
		public static byte[] XorRepeat(this byte[] src, byte[] apply)
		{
			var r = new byte[apply.Length];
			var tidx = 0;
			while (tidx < apply.Length)
			{
				foreach (var kchar in src)
				{
					r[tidx] = (byte)(kchar ^ apply[tidx]);
					if (++tidx >= apply.Length) break;
				}
			}
			return r;
		}

	}
}
