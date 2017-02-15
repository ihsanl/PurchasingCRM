
using PurchasingCRM.Data.Model.ORM.Entity;
using System.Data.Entity;

namespace PurchasingCRM.Data.Model.ORM.Context
{
   public class PurchasingCRMContext : DbContext
    {
        public PurchasingCRMContext():base("PurchasingCRM")
        {

        }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Authorities> Authorities { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<BankBranch> BankBranch { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyBank> CompanyBank { get; set; }
        public virtual DbSet<CompanyFile> CompanyFile { get; set; }
        public virtual DbSet<CompanyPayment> CompanyPayment { get; set; }
        public virtual DbSet<CompanyProduct> CompanyProduct { get; set; }
        public virtual DbSet<CompanyUser> CompanyUser { get; set; }
        public virtual DbSet<ContactStatu> ContactStatu { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<ContractFile> ContractFile { get; set; }
        public virtual DbSet<ContractProduct> ContractProduct { get; set; }
        public virtual DbSet<ContractType> ContractType { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DepartmentBudget> DepartmentBudget { get; set; }
        public virtual DbSet<Form> Form { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<MessageOffer> MessageOffer { get; set; }
        public virtual DbSet<MessageRequest> MessageRequest { get; set; }
        public virtual DbSet<OfferStatu> OfferStatu { get; set; }
        public virtual DbSet<OfferText> OfferText { get; set; }
        public virtual DbSet<OfferTip> OfferTip { get; set; }
        public virtual DbSet<Opportunity> Opportunity { get; set; }
        public virtual DbSet<OpportunityCategory> OpportunityCategory { get; set; }
        public virtual DbSet<OpportunityFile> OpportunityFile { get; set; }
        public virtual DbSet<OpportunityProduct> OpportunityProduct { get; set; }
        public virtual DbSet<OpportunityState> OpportunityState { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<ProductUnit> ProductUnit { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<RequestProduct> RequestProduct { get; set; }
        public virtual DbSet<RequestProductOffer> RequestProductOffer { get; set; }
        public virtual DbSet<RequestState> RequestState { get; set; }
        public virtual DbSet<RequestTransfer> RequestTransfer { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }
        public virtual DbSet<Source> Source { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<StockType> StockType { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserDetail> UserDetail { get; set; }
        public virtual DbSet<Vat> Vat { get; set; }
        public virtual DbSet<WereHouse> WereHouse { get; set; }
        public virtual DbSet<WereHouseTransfer> WereHouseTransfer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>()
                .HasMany(e => e.CompanyBank)
                .WithRequired(e => e.Bank)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Category1)
                .WithOptional(e => e.Category2)
                .HasForeignKey(e => e.ParentID);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Product)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanyBank)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanyPayment)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanyProduct)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanyUser)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.CompanyFile)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Stock)
                .WithRequired(e => e.Company)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompanyProduct>()
                .Property(e => e.TotalNumber)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CompanyProduct>()
                .Property(e => e.SeriNo)
                .IsFixedLength();

            modelBuilder.Entity<CompanyProduct>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContactStatu>()
                .HasMany(e => e.Contract)
                .WithOptional(e => e.ContactStatu)
                .HasForeignKey(e => e.ContractStatuID);

            modelBuilder.Entity<ContractType>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Company)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Province)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.CompanyPayment)
                .WithRequired(e => e.Currency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.DepartmentBudget)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartmentBudget>()
                .Property(e => e.TotalBudget)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OfferStatu>()
                .HasMany(e => e.RequestProductOffer)
                .WithOptional(e => e.OfferStatu)
                .HasForeignKey(e => e.OfferStatusID);

            modelBuilder.Entity<Opportunity>()
                .HasMany(e => e.OpportunityFile)
                .WithRequired(e => e.Opportunity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OpportunityProduct>()
                .Property(e => e.Amount)
                .HasPrecision(18, 4);

            modelBuilder.Entity<OpportunityState>()
                .HasMany(e => e.Opportunity)
                .WithRequired(e => e.OpportunityState)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentMethod>()
                .HasMany(e => e.CompanyPayment)
                .WithRequired(e => e.PaymentMethod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ManufacturerCode)
                .IsFixedLength();

            modelBuilder.Entity<Province>()
                .HasMany(e => e.Company)
                .WithRequired(e => e.Province)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Request>()
                .HasMany(e => e.RequestProduct)
                .WithRequired(e => e.Request)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RequestProduct>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<RequestProductOffer>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<RequestProductOffer>()
                .HasMany(e => e.RequestTransfer)
                .WithRequired(e => e.RequestProductOffer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RequestState>()
                .HasMany(e => e.Request)
                .WithRequired(e => e.RequestState)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RequestTransfer>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Stock>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Stock>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StockType>()
                .HasMany(e => e.Stock)
                .WithRequired(e => e.StockType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.UserDetail)
                .WithRequired(e => e.User);

            modelBuilder.Entity<UserDetail>()
                .HasMany(e => e.Request)
                .WithRequired(e => e.UserDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vat>()
                .HasMany(e => e.Product)
                .WithOptional(e => e.Vat)
                .HasForeignKey(e => e.VatID);

            modelBuilder.Entity<WereHouse>()
                .HasMany(e => e.WereHouseTransfer)
                .WithOptional(e => e.WereHouse)
                .HasForeignKey(e => e.SetStoreID);

            modelBuilder.Entity<WereHouse>()
                .HasMany(e => e.WereHouseTransfer1)
                .WithOptional(e => e.WereHouse1)
                .HasForeignKey(e => e.GetStoreID);
        }
    }
}
