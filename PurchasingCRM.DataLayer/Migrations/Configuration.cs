namespace PurchasingCRM.Data.Migrations
{
    using Model.ORM.Entity;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<PurchasingCRM.Data.Model.ORM.Context.PurchasingCRMContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PurchasingCRM.Data.Model.ORM.Context.PurchasingCRMContext context)
        {
           

              context.Position.AddOrUpdate(
                p => p.ID,
                new Position {Name="Sistem Yonetici", IdentityName ="SY",CreateUserID=1},
                new Position {Name="Sat�nAlma Departman", IdentityName ="SA",CreateUserID=1},
                new Position {Name="Talep Departman�", IdentityName ="TD",CreateUserID=1},
                new Position {Name="Standart Kullan�c�", IdentityName ="SK",CreateUserID=1}
              );

        }
    }
}
