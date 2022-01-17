namespace OrganizaAE.Infrastructure.Mounth
{
    public class MounthRepository : Repository<Models.Mounth.Mounth>, IMounthRepository
    {
        public MounthRepository(OrganizaAeDbContext dbContext) : base(dbContext)
        {
        }
    }
}
