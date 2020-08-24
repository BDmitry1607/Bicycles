using System;
using System.Collections.Generic;
using System.Text;

namespace BicyclesBLL.Views
{
    public class UpdateBicycleView
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public bool Rented { get; set; }
    }
}
