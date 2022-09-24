using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Models
{
    public class ClearanceDetail
    {
        [Key]
        public virtual Guid clearanceId { get; set; }
        public virtual DateTime? dateOfApplication {get;set;}
        public virtual bool? isTransfer { get; set; }
        public virtual bool? isRetirement { get; set; }
        public virtual bool? isResignation{ get; set; }
        public virtual bool? isLeave { get; set; }
        public virtual bool? isOther{ get; set; }
        public virtual string specifyOther { get; set; }
        public virtual string effectivityInclusivePeriod { get; set; }
        public virtual string immediateSupervisor { get; set; }
        public virtual string divisionHead { get; set; }
        public virtual bool? withPendingAdminCase { get; set; }
        public virtual bool? withOnGoingInvestigation { get; set; }
        public virtual Guid personId { get; set; }
        public virtual string deleted_by { get; set; }
        public virtual DateTime? deleted_date { get; set; }
        public virtual bool? is_deleted { get; set; }
    }

    public class ClearanceList_vw
    {
        public Guid clearanceId { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfApplication { get; set; }
    }
}
