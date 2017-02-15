namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Company")]
    public partial class Company:BaseEntity
    {
        public Company()
        {
            Appointment = new HashSet<Appointment>();
            CompanyBank = new HashSet<CompanyBank>();
            CompanyPayment = new HashSet<CompanyPayment>();
            CompanyProduct = new HashSet<CompanyProduct>();
            CompanyUser = new HashSet<CompanyUser>();
            Contract = new HashSet<Contract>();
            CompanyFile = new HashSet<CompanyFile>();
            Opportunity = new HashSet<Opportunity>();
            RequestProductOffer = new HashSet<RequestProductOffer>();
            Stock = new HashSet<Stock>();
        }

        public int ID { get; set; }

        public short CountryID { get; set; }

        public int ProvinceID { get; set; }

        [StringLength(150)]
        public string Town { get; set; }

        [StringLength(50)]
        public string CompanyNo { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Adress { get; set; }

        [StringLength(11)]
        public string Phone { get; set; }

        [StringLength(11)]
        public string Fax { get; set; }

        [StringLength(100)]
        public string InvoiceCountry { get; set; }

        [StringLength(100)]
        public string InvoiceProvince { get; set; }

        [StringLength(12)]
        public string TaxNo { get; set; }

        [StringLength(150)]
        public string TaxPlace { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool? Status { get; set; }

        public byte? GroupID { get; set; }

        public byte? SectorID { get; set; }

        public byte? SourceID { get; set; }

        public virtual ICollection<Appointment> Appointment { get; set; }

        public virtual Country Country { get; set; }

        public virtual Group Group { get; set; }

        public virtual Province Province { get; set; }

        public virtual Sector Sector { get; set; }

        public virtual Source Source { get; set; }

        public virtual ICollection<CompanyBank> CompanyBank { get; set; }
        public virtual ICollection<CompanyPayment> CompanyPayment { get; set; }


        public virtual ICollection<CompanyProduct> CompanyProduct { get; set; }

        public virtual ICollection<CompanyUser> CompanyUser { get; set; }

        public virtual ICollection<Contract> Contract { get; set; }

         public virtual ICollection<CompanyFile> CompanyFile { get; set; }

        public virtual ICollection<Opportunity> Opportunity { get; set; }

        public virtual ICollection<RequestProductOffer> RequestProductOffer { get; set; }

        public virtual ICollection<Stock> Stock { get; set; }
    }
}
