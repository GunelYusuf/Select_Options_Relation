using System;
using System.Collections.Generic;
using Select_Option_Relations.Migrations;

namespace Select_Option_Relations.Models
{
    public class Modelss
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Brand> Brands { get; set; }

    }
}
