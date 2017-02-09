using System;
using System.Linq;
using System.Collections.Generic;
namespace Citiprototype_v2
{
	public class TempMessageGenerator
	{
		private List<Message> messages = new List<Message>();

		private static TempMessageGenerator instance;


		public static TempMessageGenerator Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new TempMessageGenerator();
				}
				return instance;
			}

		}

		public List<Message> getMessages()
		{
			return messages;
		}

		public void buildMessages()
		{
			if (messages == null)
			{
				messages = new List<Message>();
			}
			Message newMessage = new Message();
			newMessage.quickMessage(0, "Rowan", "Hello World! 0");
			messages.Add(newMessage);
			newMessage = new Message();
			newMessage.quickMessage(1, "Steve", "Hello World! 1");
			messages.Add(newMessage);
			newMessage = new Message();
			newMessage.quickMessage(2, "Dave", "Hello World! 2");
			messages.Add(newMessage);
			newMessage = new Message();
			newMessage.quickMessage(3, "Craig", "Hello World! 3 ");
			messages.Add(newMessage);
			newMessage = new Message();
			newMessage.quickMessage(4, "Matt", "Hello World! 4");
			messages.Add(newMessage);
		}
	}
}
