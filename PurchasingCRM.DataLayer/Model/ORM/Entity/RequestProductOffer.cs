namespace PurchasingCRM.Data.Model.ORM.Entity
{
    
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RequestProductOffer")]
    public partial class RequestProductOffer:BaseEntity
    {
        public RequestProductOffer()
        {
            ContractProduct = new HashSet<ContractProduct>();
            OfferText = new HashSet<OfferText>();
            RequestTransfer = new HashSet<RequestTransfer>();
        }

        public int ID { get; set; }

        public int? RequestProductID { get; set; }

        [StringLength(50)]
        public string OfferNo { get; set; }

        public byte? OfferStatusID { get; set; }

        public byte? OfferTipID { get; set; }

        [StringLength(500)]
        public string OfferSubject { get; set; }

        public int? CompanyID { get; set; }

        public int? CompanyUserID { get; set; }

        public DateTime? OfferDate { get; set; }

        public DateTime? DispatchDate { get; set; }

        public decimal? Price { get; set; }

        public virtual Company Company { get; set; }

        public virtual CompanyUser CompanyUser { get; set; }

        public virtual ICollection<ContractProduct> ContractProduct { get; set; }

        public virtual OfferStatu OfferStatu { get; set; }
        public virtual ICollection<OfferText> OfferText { get; set; }

        public virtual ICollection<RequestTransfer> RequestTransfer { get; set; }
    }
}
