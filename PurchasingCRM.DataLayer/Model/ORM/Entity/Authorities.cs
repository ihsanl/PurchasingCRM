namespace PurchasingCRM.Data.Model.ORM.Entity
{

    public partial class Authorities:BaseEntity
    {
        public int ID { get; set; }
        public byte? PositionID { get; set; }

        public int? UserID { get; set; }

        public byte? FormID { get; set; }

        public virtual Form Form { get; set; }

        public virtual Position Position { get; set; }

        public virtual UserDetail UserDetail { get; set; }
    }
}
