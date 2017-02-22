using System.Collections.Generic;
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

        public void AddMessageToBase(Message message)
        {
            
            this.contex.Messages.Add(message);
            contex.SaveChanges();
        }
    }
}
