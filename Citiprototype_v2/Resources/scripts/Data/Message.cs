using System;
namespace Citiprototype_v2
{
	public class Message
	{
		public string messageId;
		public string senderId;
		public string senderName;
		public string content;

		public void setMid(string mid)
		{
			messageId = mid;
		}
		public void setSenderId(string sid)
		{
			senderId = sid;
		}
		public void setSenderName(string sender)
		{
			senderName = sender;
		}

		public void quickMessage(int idx, string name, string text)
		{
			messageId = name + "_" + idx;
			senderId = name + "_id";
			senderName = name;
			content = text;

		}

		public void setContent(string text)
		{
			content = text;
		}

		public string MessageId
		{
			get { return messageId; }
		}

		public string SenderId
		{
			get { return senderId; }
		}

		public string SenderName
		{
			get { return senderName; }
		}

		public string Content
		{
			get { return content; }
		}

	}
}
