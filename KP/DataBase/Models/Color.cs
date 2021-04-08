using System.Collections.Generic;

#nullable disable

namespace KP.DataBase.Models
{
    public partial class Color : ICharacteristics
    {
        public Color()
        {
            Cars = new HashSet<Car>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Metallic { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public string GetCharacteristics()
        {
            return $"ID:{Id} Name:{Name} Metalic:{Metallic} RGB:{Red},{Green},{Blue}";
        }
    }
}
