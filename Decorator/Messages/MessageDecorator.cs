using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Messages
{
	public class MessageDecorator : IMessage
	{

		protected IMessage message;
		public string getContent()
		{
			throw new NotImplementedException();
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
