namespace OrganizaAE.Infrastructure.Social
{
    public class SocialRepository : Repository<Models.Social.Social>, ISocialRepository
    {
        public SocialRepository(OrganizaAeDbContext dbContext) : base(dbContext)
        {
        }
    }
}
