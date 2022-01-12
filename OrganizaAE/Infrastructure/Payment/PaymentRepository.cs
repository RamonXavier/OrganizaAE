namespace OrganizaAE.Infrastructure.Payment
{
    public class PaymentRepository : Repository<Models.Payment.Payment>, IPaymentRepository
    {
        public PaymentRepository(OrganizaAeDbContext dbContext) : base(dbContext)
        {
        }
    }
}
