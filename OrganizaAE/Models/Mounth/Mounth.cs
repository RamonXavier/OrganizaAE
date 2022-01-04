using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OrganizaAE.Models.Mounth
{
    public class Mount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public IEnumerable<Payment.Payment> Payments { get; set; }
    }
}
