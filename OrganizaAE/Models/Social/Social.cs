using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OrganizaAE.Infrastructure;

namespace OrganizaAE.Models.Social
{
    public class Social : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Payment.Payment> Payments { get; set; }
    }
}
