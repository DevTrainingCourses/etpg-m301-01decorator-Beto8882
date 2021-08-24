namespace Decorator.Decorators
{
    using Decorator.Messages;

    public class SOAPEnvelopMessage : MessageDecorator
    {
        public SOAPEnvelopMessage(IMessage message) : base(message)
        {
            this.message = message;
        }

        //TextMessage message;
        //public SOAPEnvelopMessage(TextMessage message)
        //{
        //    this.message = message;
        //}




        public TextMessage EnvelopMessage()
        {
            string soap = "<soapenv:Envelope xmlns:soapenv="
                    + "\n\"http://schemas.xmlsoap.org/soap/envelope/\" "
                    + "\nxmlns:ser=\"http://service.dishweb.cl.com/\">\n"
                    + "   <soapenv:Header/>\n"
                    + "   <soapenv:Body>\n"
                    + message.getContent()
                    + "\n"
                    + "   </soapenv:Body>\n"
                    + "</soapenv:Envelope>";
            message.setContent(soap);
            return (TextMessage)message;
        }

    }
}
