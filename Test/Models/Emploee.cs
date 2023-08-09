using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Emploee : SharedModel
    {
        #region ctor
        private Emploee()
        {
                
        }
        public Emploee(string name)
        {
            this.Name = name;
        }

        #endregion

        #region prop
        public int ID { get; set; }
        public string Name { get; set; }

        private bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = false;

        #endregion

        #region mehtod - behavior
 
        public Emploee Create(string createBy) {
            this.SharedCreate(createBy);
            return this;
        }

        public Emploee Update(string updateBy) {
            this.SharedUpdate(updateBy);
            return this;
        }
        
        public Emploee Delete(string deleteBy) {
            this.IsDeleted = true;
            this.Update(deleteBy);
            return this;
        }

        public Emploee Activation(string updatedBy)
        {
            this.IsActive = true;
            this.Update(updatedBy);
            return this;
        }

        public Emploee DeActivation(string updatedBy)
        {
            this.IsActive = false;
            this.Update(updatedBy);
            return this;
        }

        public string GetUpdatedBy()
        {
            return this.UpdateBy;
        }

        public string GetUpdatedAt()
        {
            return this.UpdateAt.Value.ToString();
        }
        #endregion
    }
}
