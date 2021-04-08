using System.Collections.Generic;

#nullable disable

namespace KP.DataBase.Models
{
    public partial class DamageType : ICharacteristics
    {
        public DamageType()
        {
            VerDetails = new HashSet<VerDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Damage { get; set; }
        public decimal FixPrice { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<VerDetail> VerDetails { get; set; }

        public string GetCharacteristics()
        {
            return $"ID:{Id} Name:{Name} Damage:{Damage.ToString()} FixPrice:{FixPrice.ToString()} Comment:{Comment}";
        }
    }
}
