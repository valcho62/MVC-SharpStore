using System.IO;
using SimpleMVC.App.MVC.Interfaces;

namespace SimpleMVC.App.Views.Home
{
    public class Buy : IRenderable
    {
        public string Render()
        {

            return File.ReadAllText("../../content/sales.html");

        }
    }
}
