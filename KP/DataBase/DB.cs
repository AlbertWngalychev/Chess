using KP.DataBase.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KP.DataBase
{
    public static class DB
    {
        private static readonly Models.DataBase db;

        public static readonly Find Find;

        public static readonly Edit Edit;

        static DB()
        {
            db = new Models.DataBase();
            Find = new Find(db);
            Edit = new Edit(db);
        }

        public static List<Client> Clients
        {
            get
            {
                return db.Clients.ToList<Client>();
            }
        }

        public static List<Color> Colors
        {
            get
            {
                return db.Colors.ToList();
            }
        }

        public static List<Model> Models
        {
            get
            {
                return new Models.DataBase().Models.ToList();
            }
        }

        public static List<BodyCar> BodyCars
        {
            get
            {
                return db.BodyCars.ToList();
            }
        }

        public static IList Contracts
        {
            get
            {
                var contract = from c in db.Set<Contract>()
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

        }

        public static IList Cars
        {
            get
            {
                var cars = from c in db.Set<Car>()
                           join bc in db.Set<BodyCar>()
                            on c.IdbodyCar equals bc.Id
                           join m in db.Set<Model>()
                            on c.Idmodel equals m.Id
                           join clr in db.Set<Color>()
                            on c.Idcolor equals clr.Id
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

        public static List<CarPickup> CarPickups
        {
            get
            {
                return db.CarPickups.ToList();
            }
        }

        public static List<VerDetail> VerDetails
        {
            get
            {
                return db.VerDetails.ToList();
            }
        }

        public static List<DamageType> DamageTypes
        {
            get
            {
                return db.DamageTypes.ToList();
            }
        }

        public static void Remove(ICharacteristics characteristics)
        {
            db.Remove(characteristics);
            db.SaveChanges();
        }

        public static void Add(ICharacteristics characteristics)
        {
            db.Add(characteristics);
            db.SaveChanges();
        }

        public static IList FreeCars(int power, AutoTrans autoTrans)
        {
            if (autoTrans == AutoTrans.AllTrans)
            {
                return FreeCars(power);
            }

            var Cars = from c in db.Set<Car>()
                       join bc in db.Set<BodyCar>()
                        on c.IdbodyCar equals bc.Id
                       join m in db.Set<Model>()
                        on c.Idmodel equals m.Id
                       join clr in db.Set<Color>()
                        on c.Idcolor equals clr.Id
                       where c.Power >= power
                                && c.AutoTrans == (autoTrans == AutoTrans.AutoTrans)
                       select new
                       {
                           c.Vin,
                           m.Manufacturer,
                           Model = m.Name,
                           m.Class,
                           c.AutoTrans,
                           Color = clr.Name,
                           BodyCar = bc.Name,
                           bc.Closed,
                           c.Power,
                           c.Petrol
                       };


            return Cars.ToList();
        }

        private static IList FreeCars(int pwr)
        {
            var Cars = from c in db.Set<Car>()
                       join bc in db.Set<BodyCar>()
                        on c.IdbodyCar equals bc.Id
                       join m in db.Set<Model>()
                        on c.Idmodel equals m.Id
                       join clr in db.Set<Color>()
                        on c.Idcolor equals clr.Id
                       where c.Power >= pwr
                       select new
                       {
                           c.Vin,
                           m.Manufacturer,
                           Model = m.Name,
                           m.Class,
                           c.AutoTrans,
                           Color = clr.Name,
                           BodyCar = bc.Name,
                           bc.Closed,
                           c.Power,
                           c.Petrol
                       };


            return Cars.ToList();
        }

        public static IList DamageTypesFromCarPuckUp(CarPickup cpu)
        {
            var lst = from dt in db.Set<DamageType>()
                      join vd in db.Set<VerDetail>()
                      on dt.Id equals vd.IddamageType
                      where cpu.Id == vd.IdcarPickup
                      select new
                      {
                          dt.Id,
                          dt.Name,
                          dt.Damage,
                          dt.FixPrice,
                          dt.Comment
                      };
            return lst.ToList();
        }

        public static CarPickup CreateAndGetCarPickUp(CarPickup cpu)
        {
            db.Add(cpu);
            db.SaveChanges();

            var list = db.CarPickups.ToList();

            foreach (var item in list)
            {
                if (cpu.Idcontract == item.Idcontract
                    && cpu.FullNameAcceptor == item.FullNameAcceptor)
                {
                    return item;
                }
            }

            return null;

        }

        public static void AddDamageType(CarPickup cpu, DamageType dt)
        {
            db.Add(dt);
            db.SaveChanges();

            var list = db.DamageTypes.ToList();
            int iddt = 0;

            foreach (var item in list)
            {
                if (item.Name == dt.Name && item.FixPrice == dt.FixPrice
                    && item.Damage == dt.Damage && item.Comment == dt.Comment)
                {
                    iddt = item.Id;
                    break;
                }
            }

            db.Add(new VerDetail()
            {
                IdcarPickup = cpu.Id,
                IddamageType = iddt
            });
            db.SaveChanges();

        }
    }

}
