using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OrganizaAE.Models.Mounth;

namespace OrganizaAE.Models.Payment
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Year { get; set; }

        public virtual User.User User { get; set; }

        public virtual Social.Social Social{ get; set; }
        
        public virtual Mount Mounth { get; set; }
    }
}
