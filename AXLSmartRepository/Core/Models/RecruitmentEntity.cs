using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Models
{
    public class AppointmentDetail
    {
        [Key]
        public virtual Guid appointmentId { get; set; }
        public virtual Guid personId { get; set; }
        public virtual decimal finalRating { get; set; }
        public virtual bool is_renew_contract { get; set; }
        public virtual int changePersonStatus { get; set; }
        public virtual int existingSalaryGrade { get; set; }
        public virtual int proposedSalaryGrade { get; set; }
        public virtual string employeeEmailAdrs { get; set; }
        public virtual decimal wapRating { get; set; }
        public virtual decimal performanceEval { get; set; }
        public virtual bool has_case_offense { get; set; }
    }   

    public class AppointmentList_vw
    {
        public virtual Guid appointmentId { get; set; }
        public virtual string appointeeName { get; set; }
        public virtual decimal finalRating { get; set; }
    }
}
