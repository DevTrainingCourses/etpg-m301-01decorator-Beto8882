using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Messages
{
	public abstract class MessageDecorator : IMessage
	{

		protected IMessage message;

		public MessageDecorator(IMessage message)
		{
			this.message = message;
		}

		public string getContent()
		{
			return this.message.ToString();
		}

		public IMessage proccessMessage()
		{
			throw new NotImplementedException();
		}

		public void setContent(string content)
		{
			throw new NotImplementedException();
		}
	}
}
