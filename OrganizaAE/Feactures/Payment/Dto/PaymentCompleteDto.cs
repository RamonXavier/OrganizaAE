using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrganizaAE.Enum;

namespace OrganizaAE.Feactures.Payment.Dto
{
    public class PaymentCompleteDto
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public EnumWrapper.StatusPayment Status { get; set; }
        public int IdUser { get; set; }
        public string NameUser { get; set; }
        public string Email { get; set; }
        public int IdSocial { get; set; }
        public string NameSocial { get; set; }
        public string NameMounth { get; set; }
        public int NumberMounth { get; set; }
        public int MounthId { get; set; }
    }
}
