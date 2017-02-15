namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Contract")]
    public partial class Contract:BaseEntity
    {
        public Contract()
        {
            ContractFile = new HashSet<ContractFile>();
            ContractProduct = new HashSet<ContractProduct>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string ContractNo { get; set; }

        public int? CompanyID { get; set; }

        public int? CompanyUserID { get; set; }

        public byte? ContractStatuID { get; set; }

        public byte? ContractTypeID { get; set; }

        public string Description { get; set; }

        [StringLength(500)]
        public string PrivateState { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? FinishDate { get; set; }

        public virtual Company Company { get; set; }

        public virtual ContactStatu ContactStatu { get; set; }

        public virtual ContractType ContractType { get; set; }

        public virtual ICollection<ContractFile> ContractFile { get; set; }

        public virtual ICollection<ContractProduct> ContractProduct { get; set; }
    }
}
