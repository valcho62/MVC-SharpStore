using System.Text;

namespace SimpleMVC.App.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<div container>");

            sb.AppendLine("<div class=\"card col-lg-4 img-thumbnail\">");
            sb.AppendLine(
                $"<img class=\"card-img-top \" src=\"{this.ImageUrl}\" alt=\"{this.Name}\" width=\"350px\" height=\"250px\">");
            sb.AppendLine("<div class=\"card-block\">");
            sb.AppendLine($"<h4 class=\"card-title\"><b>{this.Name}</b></h4>");
            sb.AppendLine($"<p class=\"card-text\">${this.Price:f2}</p> ");
            sb.AppendLine("<p> <button type = \"button\" class=\"btn btn-primary\">Buy Now</button>");
            sb.AppendLine("</div>");
            sb.AppendLine("</div>");
            sb.AppendLine("</div>");

            return sb.ToString();
        }
    }
}
