using System.Collections.Generic;
using Select_Option_Relations.Models;

namespace Select_Option_Relations.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Modelss> Models { get; set; }

        public IEnumerable<Brands> Brands { get; set; }
    }
}
