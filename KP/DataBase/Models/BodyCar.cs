using System.Collections.Generic;

#nullable disable

namespace KP.DataBase.Models
{
    public partial class BodyCar : ICharacteristics
    {
        public BodyCar()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public bool Closed { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public string GetCharacteristics()
        {
            return $"ID:{Id} Name:{Name} Closed:{Closed}";
        }
    }
}
