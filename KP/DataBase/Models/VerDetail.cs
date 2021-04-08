#nullable disable

namespace KP.DataBase.Models
{
    public partial class VerDetail : ICharacteristics
    {
        public int Id { get; set; }
        public int IdcarPickup { get; set; }
        public int IddamageType { get; set; }

        public virtual CarPickup IdcarPickupNavigation { get; set; }
        public virtual DamageType IddamageTypeNavigation { get; set; }

        public string GetCharacteristics()
        {
            return $"IdcarPickup {IdcarPickup}  IddamageType {IddamageType}";
        }
    }
}
