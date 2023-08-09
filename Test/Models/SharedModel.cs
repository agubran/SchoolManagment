using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
    public class SharedModel
    {
        protected bool IsAcive { get; set; } = true;
        protected bool IsDeleted { get; set; } = false;
        protected DateTime CreateAt { get; set; }
        protected string CreateBy { get; set; }

        protected DateTime? UpdateAt { get; set; }
        protected string? UpdateBy { get; set; }

        protected SharedModel SharedCreate(string createBy)
        {
            this.CreateBy = createBy;
            this.CreateAt = DateTime.Now;
            return this;
        }

        protected SharedModel SharedUpdate(string updateBy)
        {
            this.UpdateBy = updateBy;
            this.UpdateAt = DateTime.Now;
            return this;
        }
    }
}
