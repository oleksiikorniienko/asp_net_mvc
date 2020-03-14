using System.Data.Entity;

namespace aspnet2.Models
{
    public class MaterialDbInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext db)
        {
            

            base.Seed(db);
        }
    }
}
