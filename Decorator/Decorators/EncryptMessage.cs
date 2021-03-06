namespace Decorator.Decorators
{
    using System;
    using System.Security.Cryptography;
    using System.Text;
    using Decorator.Messages;

    public class EncryptMessage : MessageDecorator
    {
        public EncryptMessage(string user, string password, IMessage message) : base(message)
        {
            this.User = user;
            this.Password = password;
            this.message = message;
        }

        public string User { get; set; }
        public string Password { get; set; }

        //private TextMessage Message;

        //public EncryptMessage(string user, string password, TextMessage message)
        //{
        //    this.User = user;
        //    this.Password = password;
        //    this.Message = message;
        //}



        public TextMessage Encript()
        {
            try
            {
                AesCryptoServiceProvider dataencrypt = new AesCryptoServiceProvider();
                dataencrypt.BlockSize = 128;
                dataencrypt.KeySize = 128;
                dataencrypt.Key = System.Text.Encoding.UTF8.GetBytes(this.Password);
                dataencrypt.IV = System.Text.Encoding.UTF8.GetBytes(this.Password);
                dataencrypt.Padding = PaddingMode.PKCS7;
                dataencrypt.Mode = CipherMode.CBC;
                ICryptoTransform crypto1 = dataencrypt.CreateEncryptor(dataencrypt.Key, dataencrypt.IV);
                byte[] encrypteddata = crypto1.TransformFinalBlock(Encoding.ASCII.GetBytes(this.message.getContent()), 0, this.message.getContent().Length);
                crypto1.Dispose();
                string encryptedValue = Convert.ToBase64String(encrypteddata, 0, encrypteddata.Length);
                message.setContent(encryptedValue);
                return (TextMessage)message;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw new SystemException();
            }
        }
    }
}