using SimpleMVC.App.Enums;

namespace SimpleMVC.App.Models
{
   public  class Sales
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public TypeDelivery Delivery { get; set; }
    }
}
