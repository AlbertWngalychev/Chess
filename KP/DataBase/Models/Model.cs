using System.Collections.Generic;

#nullable disable

namespace KP.DataBase.Models
{
    public partial class Model : ICharacteristics
    {
        public Model()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public decimal PriceIn1moth { get; set; }
        public decimal PriceUpto6mth { get; set; }
        public decimal PriceUpto1year { get; set; }
        public decimal PriceFrom1year { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public string GetCharacteristics()
        {
            return $"ID:{Id} Manuf:{Manufacturer} Name:{Name} Class:{Class} Price:{PriceIn1moth},{PriceUpto6mth},{PriceUpto1year},{PriceFrom1year}";
        }
    }
}
