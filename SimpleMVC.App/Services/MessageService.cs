using System.Collections.Generic;
using SimpleMVC.App.BindingModels;
using SimpleMVC.App.Data;
using SimpleMVC.App.Models;

namespace SimpleMVC.App.Services
{
    public class MessageService
    {
        public SharpStoreContex contex { get; set; }

        public MessageService()
        {
            this.contex = new SharpStoreContex();
        }

        public void AddMessageToBase(MeesageBindingModel bindingMessage)
        {

            var message = new Message()
            {
                Sender = bindingMessage.Sender,
                Subject = bindingMessage.Subject,
                MessageText = bindingMessage.MessageText
            };
            this.contex.Messages.Add(message);
            contex.SaveChanges();
        }
    }
}
