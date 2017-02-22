namespace SimpleMVC.App.Data
{
    public class Data
    {
        private static SharpStoreContex contex;

        public static SharpStoreContex Contex => contex ?? (contex = new SharpStoreContex());
    }
}
