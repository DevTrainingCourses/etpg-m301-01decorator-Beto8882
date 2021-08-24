using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Messages
{
	public interface IMessage
	{
		public IMessage proccessMessage();
		public string getContent();
		public void setContent(string content);

	}
}
