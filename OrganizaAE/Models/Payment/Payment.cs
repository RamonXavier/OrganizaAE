using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using OrganizaAE.Models.Mounth;

namespace OrganizaAE.Models.Payment
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Year { get; set; }

        //public int IdUser{ get; set; }
        //public virtual IEnumerable<IdentityUser> User { get; set; }

        public int IdSocial { get; set; }
        public virtual IEnumerable<Social.Social> Social{ get; set; }
    
        public int IdMounth { get; set; }
        public virtual IEnumerable<Mount> Mounth { get; set; }
    }
}
