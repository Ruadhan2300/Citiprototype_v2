using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Citiprototype_v2
{
	public class FakeApplicationServer
	{
		private static FakeApplicationServer instance;

		public static FakeApplicationServer Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new FakeApplicationServer();
				}
				return instance;
			}
		}

		private void processRequest(IDictionary<string,object> data)
		{
			Dictionary<string, object> dataShort = data as Dictionary<string, object>;
			string dataValue = dataShort.getStringFromDict("data1");
		}

		public void serverReceiver(string encodedData)
		{
			string data = RequestDataManipulator.decodeData(encodedData);
			Dictionary<string,object> deserializedData = JsonConvert.DeserializeObject<Dictionary<string,object>>(data);
			processRequest(deserializedData);
		}

		public string serverDespatcher(string data)
		{
			string encodedData = RequestDataManipulator.encodeData(data);
			AppController.Instance.GetServerData(encodedData);
			return encodedData;
		}


	}
}
