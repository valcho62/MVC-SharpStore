using System.Collections.Generic;
using System.Linq;
using SimpleMVC.App.Data;
using SimpleMVC.App.ViewModels;

namespace SimpleMVC.App.Services
{
    public class KniveService
    {
        private SharpStoreContex contex;

        public KniveService(SharpStoreContex contex)
        {
            this.contex = contex;
        }

        public IEnumerable<ProductViewModel> GetProducts()
        {
            var knives = this.contex.Knives.ToArray();

            var viewMOdels = new List<ProductViewModel>();
            foreach (var knive in knives)
            {
                viewMOdels.Add(new ProductViewModel()
                {
                    Name = knive.Name,
                    Price = knive.Price,
                    ImageUrl = knive.ImageUrl,
                    Id = knive.Id
                });
            }


            return viewMOdels;
        }

        
    }
}
