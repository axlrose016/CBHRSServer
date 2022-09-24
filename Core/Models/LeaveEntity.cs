using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Models
{
    public class LeaveDetail
    {
        [Key]
        public virtual Guid leaveAppId { get; set; }
        public virtual Guid personId { get; set; }
        public virtual DateTime leave_credit_as_of { get; set; }
        public virtual bool is_recommendation_for_approval { get; set; }
        public virtual bool is_recommendation_for_disapproval { get; set; }
        public virtual string disapproval_due_to { get; set; }
        public virtual int approved_for_days_with_pay { get; set; }
        public virtual int approved_for_days_wo_pay { get; set; }
        public virtual int approved_for_days_others { get; set; }
        public virtual string approved_for_others_details { get; set; }
        public virtual string disapproved_due_to { get; set; }
        public virtual DateTime? created_date { get; set; }
        public virtual string created_by { get; set; }
        public virtual DateTime? deleted_date { get; set; }
        public virtual string deleted_by { get; set; }
        public virtual bool is_deleted { get; set; }
        public virtual int vacation_leave_credit { get; set; }
        public virtual int sick_leave_credit { get; set; }
        public virtual string supervising_officer { get; set; }
        public virtual string authorized_officer { get; set; }
    }

    public class LeaveList_vw
    {
        public virtual Guid leaveAppId { get; set; }
        public virtual Guid personId { get; set; }
        public virtual string employeeName { get; set; }
        public virtual DateTime leave_credit_as_of { get; set; }
        public virtual int approved_for_days_with_pay { get; set; }
        public virtual int approved_for_days_wo_pay { get; set; }
        public virtual int approved_for_days_others { get; set; }
        public virtual string disapproved_due_to { get; set; }
    }
}
