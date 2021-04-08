using System.Collections.Generic;

#nullable disable

namespace KP.DataBase.Models
{
    public partial class Car : ICharacteristics
    {
        public Car()
        {
            Contracts = new HashSet<Contract>();
        }

        public string Vin { get; set; }
        public int Idmodel { get; set; }
        public int IdbodyCar { get; set; }
        public int Idcolor { get; set; }
        public string GovNumber { get; set; }
        public double Tcoeff { get; set; }
        public int Trunk { get; set; }
        public int Seats { get; set; }
        public bool AutoTrans { get; set; }
        public int Power { get; set; }
        public bool Petrol { get; set; }
        public bool Freedom { get; set; }
        public string PathImg { get; set; }

        public virtual BodyCar IdbodyCarNavigation { get; set; }
        public virtual Color IdcolorNavigation { get; set; }
        public virtual Model IdmodelNavigation { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }

        public string GetCharacteristics()
        {
            DataBase db = new DataBase();

            Model model = db.Models.Find(Idmodel);
            Color color = db.Colors.Find(Idcolor);
            BodyCar bodycar = db.BodyCars.Find(IdbodyCar);

            return $"VIN:{Vin} Model:{model.Manufacturer} {model.Name} BodyCar: {bodycar.Name}(Closed: {bodycar.Closed}) " +
                $"GovNumber:{GovNumber} Tcoeff:{Tcoeff} Trunk:{Trunk} Seats:{Seats} AutoTrans:{AutoTrans} Power:{Power} " +
                $"Petrol:{Petrol} Freedom:{Freedom} PathImg:{PathImg}";
        }

        public Car changeFreedom()
        {
            Freedom = !Freedom;

            return this;
        }
    }
}
