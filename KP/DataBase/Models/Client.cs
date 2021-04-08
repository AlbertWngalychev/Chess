using System;
using System.Collections.Generic;

#nullable disable

namespace KP.DataBase.Models
{
    public partial class Client : ICharacteristics
    {
        public Client()
        {
            Contracts = new HashSet<Contract>();
        }
        public int Snpasport { get; set; }
        public string Sname { get; set; }
        public string Name { get; set; }
        public string Lname { get; set; }
        public int DriverLicense { get; set; }
        public DateTime StartTimeDl { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }

        public string GetCharacteristics()
        {
            return $"Snpasport:{Snpasport} FullName:{Sname} {Name} {Lname} DL:{DriverLicense} from {StartTimeDl.ToShortDateString()}";
        }
    }
}
