using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

public static class DicHelper {


	/// <summary>
	/// Gets the object from dictionary.
	/// </summary>
	/// <returns>The object from dict.</returns>
	/// <param name="key">Key.</param>
	/// <param name="data">Data.</param>
	public static object getObjectFromDict( this Dictionary<string, object> data, string key)
	{
		if (data.ContainsKey(key)){
			return data[key];
		}
		return null;
	}

	/// <summary>
	/// Gets the stringfrom dict.
	/// </summary>
	/// <returns>The stringfrom dict.</returns>
	/// <param name="key">Key.</param>
	/// <param name="data">Data.</param>
	public static string getStringFromDict(this Dictionary<string, object> data, string key)
	{
		if (data.ContainsKey(key)){
			return data[key] as string;
		}
		return null;
	}

	/// <summary>
	/// Gets the intfrom dict.
	/// </summary>
	/// <returns>The intfrom dict.</returns>
	/// <param name="key">Key.</param>
	/// <param name="data">Data.</param>
	public static int getIntFromDict(this Dictionary<string, object> data, string key)
	{
		if (data.ContainsKey(key))
		{
			object dataValue = data[key];
			int output = -1;
			if (int.TryParse(dataValue as string, out output))
			{
				return output;
			}

		}
		return -1;
	}

	/// <summary>
	/// Gets the longfrom dict.
	/// </summary>
	/// <returns>The longfrom dict.</returns>
	/// <param name="key">Key.</param>
	/// <param name="data">Data.</param>
	public static long getLongFromDict(this Dictionary<string, object> data, string key)
	{
		if (data.ContainsKey(key))
		{
			object dataValue = data[key];
			long output = -1;
			if (long.TryParse(dataValue as string, out output))
			{
				return output;
			}

		}
		return -1;
	}

	/// <summary>
	/// Gets the object list from dict.
	/// </summary>
	/// <returns>The object list from dict.</returns>
	/// <param name="key">Key.</param>
	/// <param name="data">Data.</param>
	public static List<object> getObjectListFromDict(string key, Dictionary<string, object> data)
	{
		return null;
	}

	/// <summary>
	/// Gets the string list from dict.
	/// </summary>
	/// <returns>The string list from dict.</returns>
	/// <param name="key">Key.</param>
	/// <param name="data">Data.</param>
	public static List<string> getStringListFromDict(string key, Dictionary<string, object> data)
	{
		return null;
	}

	/// <summary>
	/// Gets the int list from dict.
	/// </summary>
	/// <returns>The int list from dict.</returns>
	/// <param name="key">Key.</param>
	/// <param name="data">Data.</param>
	public static List<int> getIntListFromDict(string key, Dictionary<string, object> data)
	{
		return null;
	}

	/// <summary>
	/// Gets the long list from dict.
	/// </summary>
	/// <returns>The long list from dict.</returns>
	/// <param name="key">Key.</param>
	/// <param name="data">Data.</param>
	public static List<long> getLongListFromDict(string key, Dictionary<string, object> data)
	{
		return null;
	}

}

