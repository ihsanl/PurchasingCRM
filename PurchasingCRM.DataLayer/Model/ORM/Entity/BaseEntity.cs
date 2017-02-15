using System;

namespace PurchasingCRM.Data.Model.ORM.Entity
{
    public  class BaseEntity
    {
  

        private bool _isActive = true; 
        public bool IsActive { get { return _isActive; } set { value = _isActive; } }

        private bool _isDelete = false;
        public bool IsDelete{ get { return _isDelete; } set { value = _isDelete; } }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get { return _createDate; } set { value = _createDate; } }

        public DateTime? DeleteDate { get; set; }
        public int CreateUserID { get; set; }
    }
}
