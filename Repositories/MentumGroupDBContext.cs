using Microsoft.EntityFrameworkCore;

namespace CustomerManager.Repositories
{
    public class MentumGroupDBContext: DbContext
    {
        public MentumGroupDBContext()
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // base.OnModelCreating(builder);
            
        }
    }
}
