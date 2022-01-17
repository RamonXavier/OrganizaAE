using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OrganizaAE.Infrastructure;
using OrganizaAE.Models.Mounth;

namespace OrganizaAE.Models.Payment
{
    public class Payment : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Year { get; set; }

        public virtual User.User User { get; set; }

        public virtual Social.Social Social{ get; set; }
        
        public virtual Mounth.Mounth Mounth { get; set; }
    }
}
