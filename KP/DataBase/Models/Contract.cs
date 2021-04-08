using System;
using System.Collections.Generic;

#nullable disable

namespace KP.DataBase.Models
{
    public partial class Contract : ICharacteristics
    {
        public Contract()
        {
            CarPickups = new HashSet<CarPickup>();
        }

        public int Id { get; set; }
        public int Idclient { get; set; }
        public string Vinauto { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime? ActualSurrender { get; set; }

        public virtual Client IdclientNavigation { get; set; }
        public virtual Car VinautoNavigation { get; set; }
        public virtual ICollection<CarPickup> CarPickups { get; set; }

        public string GetCharacteristics()
        {
            return $"ID:{Id} Client:{Idclient} VIN:{Vinauto} {Start.ToShortDateString()}-{End.ToShortDateString()}";
        }
    }
}
