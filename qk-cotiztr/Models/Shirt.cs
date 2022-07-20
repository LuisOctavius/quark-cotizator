using qk_cotiztr.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qk_cotiztr.Models
{
    public class Shirt : Garment
    {
        public Shirt(string name, double price, int stock, QualityType quality, NeckType neckType, SleeveType sleeveType) :
                    base(name, price, stock, quality)
        {
            Neck = neckType;
            Sleeve = sleeveType;
        }

        public NeckType Neck { get; set; }
        public SleeveType Sleeve { get; set; }
        public override GarmentType Type => GarmentType.Camisa;
        public override double Price
        {
            get
            {
                double newPrice = _price;

                if (Sleeve == SleeveType.Short)
                    newPrice -= newPrice * 0.1;

                if (Neck == NeckType.Mandarin)
                    newPrice += newPrice * 0.03;

                if (Quality == QualityType.Premium)
                    newPrice += newPrice * 0.3;

                return newPrice;
            }
        }
    }
}
