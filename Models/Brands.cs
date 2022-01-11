using System;
namespace Select_Option_Relations.Models
{
    public class Brands
    {
        public int Id{ get; set; }

        public string Name { get; set; }

        public int ModelId { get; set; }

        public virtual Modelss Modelss { get; set; }

    }
}
