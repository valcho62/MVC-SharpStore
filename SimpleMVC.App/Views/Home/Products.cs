

using System.Collections.Generic;
using System.IO;
using System.Text;
using SimpleMVC.App.MVC.Interfaces;
using SimpleMVC.App.MVC.Interfaces.Generic;
using SimpleMVC.App.ViewModels;

namespace SimpleMVC.App.Views.Home
{
    public class Products :IRenderable<IEnumerable<ProductViewModel>>
    {
        public string Render()
        {
            var template = File.ReadAllText("../../content/products.html");
            var sb = new StringBuilder();
            foreach (var mode in Model)
            {
                sb.AppendLine(mode.ToString());
            }

            return string.Format(template, sb.ToString());
        }

        public IEnumerable<ProductViewModel> Model { get; set; }
    }
}
