using qk_cotiztr.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qk_cotiztr.Models
{
    public abstract class Garment
    {
        protected double _price;
        protected Garment(string name, double price, int stock, QualityType quality)
        {
            Name = name;
            Stock = stock;
            Quality = quality;
            _price = price;
        }

        public string Name { get; set; }
        public virtual double Price {
            get
            {
                return _price;
            }
        }
        public int Stock { get; set; }
        public QualityType Quality { get; set; }
        public virtual GarmentType Type => GarmentType.NotValid;
    }
}
