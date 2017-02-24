using System;
using SimpleMVC.App.BindingModels;
using SimpleMVC.App.Data;
using SimpleMVC.App.Enums;
using SimpleMVC.App.Models;

namespace SimpleMVC.App.Services
{
    public class BuyService
    {
        public SharpStoreContex contex { get; set; }

        public BuyService()
        {
            this.contex = new SharpStoreContex();
        }

        public void AddSaleToBase(BuyBindingModel model)
        {
            
            var tempDelivery = (TypeDelivery) Enum.Parse(typeof(TypeDelivery), model.Delivery);
            var saleCur = new Sales()
            {
               Name = model.Name,
               Phone = model.Phone,
               Address = model.Address,
              Delivery = tempDelivery
            };
            this.contex.Sales.Add(saleCur);
            contex.SaveChanges();
        }
    }
}
