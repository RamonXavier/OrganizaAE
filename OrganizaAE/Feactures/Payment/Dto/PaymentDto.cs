using OrganizaAE.Enum;

namespace OrganizaAE.Feactures.Payment.Dto
{
    public class PaymentDto
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdMounth { get; set; }
        public int IdSocial { get; set; }
        public int Year { get; set; }
        public EnumWrapper.StatusPayment Status { get; set; }
    }
}
