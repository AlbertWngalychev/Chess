using KP.DataBase.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KP.DataBase
{
    public class Find
    {
        private readonly Models.DataBase db;

        private Find() { }

        public Find(Models.DataBase Db)
        {
            db = Db;
        }

        public Client Client(int id)
        {
            return db.Find<Client>(id);
        }

        public Car Car(string vin)
        {
            return db.Find<Car>(vin);
        }

        public Model Model(int id)
        {
            return db.Find<Model>(id);
        }

        public BodyCar BodyCar(int id)
        {
            return db.Find<BodyCar>(id);
        }

        public Color Color(int id)
        {
            return db.Find<Color>(id);
        }

        public Contract Contract(int id)
        {
            return db.Find<Contract>(id);
        }

        public CarPickup CarPickup(int id)
        {
            return db.Find<CarPickup>(id);
        }
        public DamageType DamageType(int id)
        {
            return db.Find<DamageType>(id);
        }
        public VerDetail VerDetail(int id)
        {
            return db.Find<VerDetail>(id);
        }


        public IList CarPickups(int id)
        {
            var cpu = from c in db.Set<CarPickup>()
                      where c.Id == id
                      select new { c.Id, c.Idcontract, c.FullNameAcceptor, c.VerDetails };
            return cpu.ToList();
        }

        public IList Clients(int id)
        {
            var clients = from c in db.Set<Client>()
                          where c.Snpasport == id
                          select new { c.Snpasport, c.Sname, c.Name, c.Lname, c.DriverLicense, c.StartTimeDl };

            return clients.ToList();
        }

        public IList Contracts(int id)
        {
            var contract = from c in db.Set<Contract>()
                           where c.Id == id
                           select new
                           {
                               c.Id,
                               SNpasport = c.Idclient,
                               c.Vinauto,
                               c.Start,
                               c.End,
                               c.ActualSurrender
                           };
            return contract.ToList();
        }

        public IList Cars(string vin)
        {
            var cars = from c in db.Set<Car>()
                       join bc in db.Set<BodyCar>()
                        on c.IdbodyCar equals bc.Id
                       join m in db.Set<Model>()
                        on c.Idmodel equals m.Id
                       join clr in db.Set<Color>()
                        on c.Idcolor equals clr.Id
                       where c.Vin == vin
                       select new
                       {
                           c.Vin,
                           Model = m.Manufacturer + " " + m.Name,
                           m.Class,
                           BodyCar = bc.Name,
                           bc.Closed,
                           c.GovNumber,
                           c.Tcoeff,
                           c.Trunk,
                           c.Seats,
                           c.AutoTrans,
                           c.Power,
                           c.Petrol,
                           c.Freedom,
                           c.PathImg
                       };
            return cars.ToList();

        }

    }
}