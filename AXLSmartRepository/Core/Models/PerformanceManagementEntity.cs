using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Models
{
    public class BudgetUtilizationDetail
    {
        [Key]
        public virtual Guid budgetUtilId { get; set; }
        public virtual decimal totalBudgetJO { get; set; }
        public virtual decimal totalBudgetPlantil { get; set; }
        public virtual decimal amountSpentQ1JO { get; set; }
        public virtual decimal amountSpentQ1Plantil { get; set; }
        public virtual decimal amountSpentQ2JO { get; set; }
        public virtual decimal amountSpentQ2Plantil { get; set; }
        public virtual decimal amountSpentQ3JO { get; set; }
        public virtual decimal amountSpentQ3Plantil { get; set; }
        public virtual decimal amountSpentQ4JO { get; set; }
        public virtual decimal amountSpentQ4Plantil { get; set; }
        public virtual bool is_funding_set_aside { get; set; }
        public virtual int with_last_year_proposed_budget { get; set; }
        public virtual int with_additional_proposed_budget { get; set; }
        public virtual string deleted_by { get; set; }
        public virtual DateTime deleted_date { get; set; }
        public virtual bool is_deleted { get; set; }
    }
    public class BudgetUtilizationList_vw
    {
        public Guid budgetUtilId { get; set; }
        public decimal totalBudgetJO { get; set; }
        public decimal totalBudgetPlantil { get; set; }
        public bool is_funding_set_aside { get; set; }
    }
    public class OrganizationalGoalDetail
    {
        [Key]
        public virtual Guid orgGoalId { get; set; }
        public virtual string mandateOfOffice { get; set; }
        public virtual string visionOfOffice { get; set; }
        public virtual string missionOfOffice { get; set; }
        public virtual string stratigicGoalsOfOffice { get; set; }
        public virtual string deleted_by { get; set; }
        public virtual DateTime deleted_date { get; set; }
        public virtual bool is_deleted { get; set; }
    }
    public class OrganizationalGoalList_vw
    {
        public Guid orgGoalId { get; set; }
        public string missionOfOffice { get; set; }
        public string visionOfOffice { get; set; }
    }
    public class HRStaffingPlanDetail
    {
        [Key]
        public virtual Guid hrStaffingId { get; set; }
        public virtual int existingNosPersonnelJO { get; set; }
        public virtual int existingNosPersonnelPlantil { get; set; }
        public virtual int nosFilledPosJO { get; set; }
        public virtual int nosFilledPosPlantil { get; set; }
        public virtual int nosUnfilledPosJO { get; set; }
        public virtual int nosUnfilledPosPlantil { get; set; }
        public virtual int nosProposedPosToChangeJO { get; set; }
        public virtual int nosProposedPosToChangePlantil { get; set; }
        public virtual int proposedNosPersonnelNextYrJO { get; set; }
        public virtual int proposedNosPersonnelNextYrPlantil { get; set; }
        public virtual string deleted_by { get; set; }
        public virtual DateTime deleted_date { get; set; }
        public virtual bool is_deleted { get; set; }
    }
    public class HRStaffingPlanList_vw
    {
        public Guid hrStaffingId { get; set; }
        public int existingNosPersonnelJO { get; set; }
        public int existingNosPersonnelPlantil { get; set; }
    }
    public class ComplaintDetail
    {
        [Key]
        public virtual Guid complaintId { get; set; }
        public virtual int officeId { get; set; }
        public virtual Guid personId { get; set; }
        public virtual int typeOfComplaint { get; set; }
        public virtual string  grievanceDetails { get; set; }
        public virtual Guid complaineeId { get; set; }
        public virtual string emailAddressComplainant { get; set; }
        public virtual string emailAddressSupervisor { get; set; }
        public virtual string deleted_by { get; set; }
        public virtual DateTime deleted_date { get; set; }
        public virtual bool is_deleted { get; set; }
        public virtual string complaintName { get; set; }
        public virtual string complaineeName { get; set; }
        public virtual bool is_guilty { get; set; }
    }
    public class ComplaintList_vw
    {
        public Guid complaintId { get; set; }
        public Guid personId { get; set; }
        public string officeId { get; set; }
        public string complaintName { get; set; }
        public string typeOfComplaint { get; set; }
    }
}
