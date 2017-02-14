using System;
using System.Collections.Generic;

namespace Citiprototype_v2
{
	public class TrackingStore
	{
		private static TrackingStore instance;

		public static TrackingStore Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new TrackingStore();
				}
				return instance;
			}
		}

		private Dictionary<string, object> trackingData;

		public void SetTrackingValue(string key, object value)
		{
			trackingData[key] = value;
		}

		public object GetTrackingValue(string key)
		{
			if (trackingData.ContainsKey(key))
			{
				return trackingData[key];
			}
			return null;
		}
	}
}
