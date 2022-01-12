using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Models
{
    public class WorkplaceAppicationPlan
    {
        [Key]
        public virtual Guid wapId { get; set; }
        public virtual string title { get; set; }
        public virtual string provider { get; set; }
        public virtual DateTime? date_conduct { get; set; }
        public virtual string learningOutcome { get; set; }
        public virtual string alignment { get; set; }
        public virtual PersonDetail PersonDetails { get; set; }
        public virtual DateTime? startDate { get; set; }
        public virtual DateTime? endDate { get; set; }
        public virtual string objective { get; set; }
        public virtual string output { get; set; }
        public virtual ICollection<ApplicationPlanAndAccomplishment> ApplicationPlanAndAccomplishments { get; set; }
    }

    public class WorkplaceApplicationPlan_vw
    {
        public Guid wapId { get; set; }
        public Guid personId { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }
        public string provider { get; set; }
        public DateTime date_conduct { get; set; }
    }

    public class ApplicationPlanAndAccomplishment
    {
        [Key]
        public virtual Guid apaId { get; set; }
        public virtual DateTime? targetDate { get; set; }
        public virtual int milestone { get; set; }
        public virtual string whatNeedsToBeDone { get;set; }
        public virtual string meansOfVerification { get; set; }
        public virtual DateTime? dateAssessed { get; set; }
        public virtual int progress { get; set; }
        public virtual string whatWasDone { get; set; }
        public virtual string whatWasNotDone { get; set; }
        public virtual string ReasonForNonAccomplish { get; set; }
        public virtual string catchUpActivities { get; set; }

    }
    public class LDNADetails
    {
        [Key]
        public virtual Guid ldnaId { get; set; }
        public virtual int departmentId { get; set; }
        public virtual ICollection<LDNAResults> ldnaResults { get; set; }
    }
    public class LDNAResults
    {
        [Key]
        public virtual Guid ldnaResultId { get; set; }
        public virtual int coreCompetencyId { get; set; }
        public virtual int competencyId { get; set; }
        public virtual int permanent { get; set; }
        public virtual int contractual { get; set; }
    }

    public class LDNAConsolidated_sp
    {
        public string CoreCompetency { get; set; }
        public string CompetencyCategory { get; set; }
        public int PMED_Permanent { get; set; }
        public int PMED_Contractual { get; set; }
        public int Regulation_Licensing_and_Enforcement_Division_Permanent { get; set; }
        public int Regulation_Licensing_and_Enforcement_Division_Contractual { get; set; }
        public int District_Provincial_Health_Teams_Permanent { get; set; }
        public int District_Provincial_Health_Teams_Contractual { get; set; }
    }
}
