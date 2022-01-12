namespace OrganizaAE.Infrastructure.Mounth
{
    public class MounthRepository : Repository<Models.Mounth.Mount>, IMounthRepository
    {
        public MounthRepository(OrganizaAeDbContext dbContext) : base(dbContext)
        {
        }
    }
}
