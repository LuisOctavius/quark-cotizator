using qk_cotiztr.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qk_cotiztr.Models
{
    public class Pants : Garment
    {
        public Pants(string name, double price, int stock, QualityType quality, PantsType pantsStyle) :
            base(name, price, stock, quality)
        {
            Name = name;
            Style = pantsStyle;
        }

        public PantsType Style { get; set; }
        public override GarmentType Type => GarmentType.Pantalon;
        public override double Price
        {
            get
            {
                double newPrice = _price;

                if (Style == PantsType.Chupin)
                    newPrice -= newPrice * 0.12;

                if (Quality == QualityType.Premium)
                    newPrice += newPrice * 0.3;

                return newPrice;
            }
        }
    }
}
