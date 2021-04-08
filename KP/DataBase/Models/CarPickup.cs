using System;
using System.Collections.Generic;

#nullable disable

namespace KP.DataBase.Models
{
    public partial class CarPickup : ICharacteristics
    {
        public CarPickup()
        {
            VerDetails = new HashSet<VerDetail>();
        }

        public int Id { get; set; }
        public int Idcontract { get; set; }
        public string FullNameAcceptor { get; set; }
        public DateTime? Holding { get; set; }

        public virtual Contract IdcontractNavigation { get; set; }
        public virtual ICollection<VerDetail> VerDetails { get; set; }

        public string GetCharacteristics()
        {
            return $"ID:{Id} IdContract:{Idcontract} FullNameAcceptor:{FullNameAcceptor}";
        }
    }
}
