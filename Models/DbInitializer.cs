using System.Data.Entity;

namespace aspnet2.Models
{
    public class DbInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext db)
        {
            db.Materials.Add(new Material { Title = "Шерсть" });
            db.Materials.Add(new Material { Title = "Хлопок" });
            db.Materials.Add(new Material { Title = "Полиэстер" });
            db.Materials.Add(new Material { Title = "Микрофибра" });
            db.Materials.Add(new Material { Title = "Мех" });

            base.Seed(db);
        }
    }
}
