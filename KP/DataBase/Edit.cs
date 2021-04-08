using KP.DataBase.Models;

namespace KP.DataBase
{
    public class Edit
    {
        private readonly Models.DataBase db;

        private Edit() { }

        public Edit(Models.DataBase db)
        {
            this.db = db;
        }

        public void Model(int editedIdModel, Model model)
        {
            Model mdl = db.Find<Model>(editedIdModel);

            mdl.Manufacturer = model.Manufacturer;
            mdl.Name = model.Name;
            mdl.Class = model.Class;
            mdl.PriceIn1moth = model.PriceIn1moth;
            mdl.PriceUpto6mth = model.PriceUpto6mth;
            mdl.PriceUpto1year = model.PriceUpto1year;
            mdl.PriceFrom1year = model.PriceFrom1year;

            db.SaveChanges();
        }

        public void Color(int editedIdColor, Color color)
        {
            Color clr = db.Find<Color>(editedIdColor);

            clr.Name = color.Name;
            clr.Metallic = color.Metallic;
            clr.Red = color.Red;
            clr.Green = color.Green;
            clr.Blue = color.Blue;

            db.SaveChanges();
        }

        public void Client(int editedSNpasportClient, Client client)
        {
            Client clnt = db.Find<Client>(editedSNpasportClient);

            clnt.Sname = client.Sname;
            clnt.Name = client.Name;
            clnt.Lname = client.Lname;
            clnt.DriverLicense = client.DriverLicense;
            clnt.StartTimeDl = client.StartTimeDl;

            db.SaveChanges();
        }

        public void Car(string editedVinCar, Car car)
        {
            Car c = db.Find<Car>(editedVinCar);

            c.Trunk = car.Trunk;
            c.Tcoeff = car.Tcoeff;
            c.Seats = car.Seats;
            c.Power = car.Power;
            c.Petrol = car.Petrol;
            c.PathImg = car.PathImg;
            c.Idmodel = car.Idmodel;
            c.Idcolor = car.Idmodel;
            c.IdbodyCar = car.IdbodyCar;
            c.GovNumber = car.GovNumber;
            c.Freedom = car.Freedom;
            c.AutoTrans = car.AutoTrans;

            db.SaveChanges();
        }

        public void BodyCar(int editedIdBodyCar, BodyCar bc)
        {
            BodyCar bodycar = db.Find<BodyCar>(editedIdBodyCar);

            bodycar.Closed = bc.Closed;
            bodycar.Name = bc.Name;

            db.SaveChanges();
        }

        public void Contract(int editedIdContract, Contract newContract)
        {
            Contract c = db.Find<Contract>(editedIdContract);

            c.Idclient = newContract.Idclient;
            c.Vinauto = newContract.Vinauto;
            c.Start = newContract.Start;
            c.End = newContract.End;
            c.ActualSurrender = newContract.ActualSurrender;

            db.SaveChanges();
        }

        public void CarPickup(int id, CarPickup cpu)
        {
            var c = db.Find<CarPickup>(id);
            c.FullNameAcceptor = cpu.FullNameAcceptor;
            c.Idcontract = cpu.Idcontract;
            c.Holding = cpu.Holding;

            db.SaveChanges();
        }

        public void DamageType(int id, DamageType dt)
        {
            var c = db.Find<DamageType>(id);
            c.FixPrice = dt.FixPrice;
            c.Damage = dt.Damage;
            c.Comment = dt.Comment;
            c.Name = dt.Name;

            db.SaveChanges();
        }

    }
}