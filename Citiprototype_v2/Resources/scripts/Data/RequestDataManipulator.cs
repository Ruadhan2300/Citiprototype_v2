using System;
using System.Text;
namespace Citiprototype_v2
{
	public class RequestDataManipulator
	{

		public static string encodeData(string p0)
		{
			string str2;
			try
			{
				//byte[] buffer = new byte[p0.Length];
				str2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(p0));
			}
			catch (Exception exception)
			{
				throw new Exception("Error in base64Encode" + exception.Message);
			}
			return str2;
		}

		public static string decodeData(string encodedData)
		{

			byte[] decodedData = Convert.FromBase64String(encodedData);
			string decodedString = Encoding.UTF8.GetString(decodedData);

			return decodedString;
		}
	}
}
