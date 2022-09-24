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
        public virtual Guid personId { get; set; }
        public virtual string title { get; set; } 
        public virtual DateTime? dateConduct { get; set; } 
        public virtual string provider { get; set; } 
        public virtual string learningOutcome { get; set; } 
        public virtual string otherIntervention { get; set; }
        public virtual string objectives { get; set; }
        public virtual string output { get; set; }
        public virtual int? milestone { get; set; }
        public virtual string whatNeedsToBeDone { get; set; }
        public virtual DateTime? startDate { get; set; }
        public virtual DateTime? endDate { get; set; }
        public virtual int? targetDays { get; set; }
        public virtual int? mov { get; set; }
        public virtual int? rating { get; set; }
        public virtual int? reasonForNonAccomplishment { get; set; }
        public virtual string otherReason { get; set; }
        public virtual string deleted_by { get; set; }
        public virtual DateTime? deleted_date { get; set; }
        public virtual bool? is_deleted { get; set; }
        public virtual bool? has_intervention_ipcr { get; set; }
        public virtual bool? has_intervention_wfp { get; set; }
        public virtual bool? has_intervention_csp { get; set; }
        public virtual bool? has_intervention_cos { get; set; }
        public virtual bool? has_intervention_idp { get; set; }
        public virtual bool? has_intervention_others { get; set; }
        public virtual string intervention_others { get; set; }
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
    public class LDNAList_vw
    {
        public Guid ldnaId { get; set; }
        public int departmentId { get; set; }
        public string departmentDesc { get; set; }
        //public int coreCompetencyId { get; set; }
        //public string coreCompetencyDesc { get; set; }
        //public int competencyId { get; set; }
        //public string competencyCategoryDesc { get; set; }
        //public int permanent { get; set; }
        //public int contractual { get; set; }
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
    public class PerformanceRateDetails 
    {
        [Key]
        public virtual Guid performanceRateId { get; set; }
        public virtual Guid personId { get; set; }
        public virtual bool? isAnalytical { get; set; }
        public virtual bool? isInitiative { get; set; }
        public virtual bool? isInnovation { get; set; }
        public virtual bool? isJobKnowledge { get; set; }
        public virtual bool? isPlanningOrg { get; set; }
        public virtual bool? isTeamwork { get; set; }
        public virtual bool? isCommunication { get; set; }
        public virtual bool? isBehavioralFactor { get; set; }
        public virtual decimal? grade { get; set; }
        public virtual int? scr_diverseInfo { get; set; }
        public virtual int? scr_researchesData { get; set; }
        public virtual int? scr_usesIntuition { get; set; }
        public virtual int? scr_identifiesData { get; set; }
        public virtual int? scr_designsWorkflows { get; set; }
        public virtual int? scr_volunteersReadily { get; set; }
        public virtual int? scr_undertakeSelfDev { get; set; }
        public virtual int? scr_seekIncResponsibilities { get; set; }
        public virtual int? scr_takeIndActions { get; set; }
        public virtual int? scr_takesAdvantage { get; set; }
        public virtual int? scr_askForHelp { get; set; }
        public virtual int? scr_creativity { get; set; }
        public virtual int? scr_resourceful { get; set; }
        public virtual int? scr_improveWork { get; set; }
        public virtual int? scr_devInnovateIdeas { get; set; }
        public virtual int? scr_competent { get; set; }
        public virtual int? scr_exhibitAbility { get; set; }
        public virtual int? scr_keepsAbreast { get; set; }
        public virtual int? scr_minimalSupervision { get; set; }
        public virtual int? scr_displaysUnderstanding { get; set; }
        public virtual int? scr_usesResources { get; set; }
        public virtual int? scr_plansWorkAct { get; set; }
        public virtual int? scr_usesTimeEff{ get; set; }
        public virtual int? scr_plansForAddResources{ get; set; }
        public virtual int? scr_integratesChanges{ get; set; }
        public virtual int? scr_setsGoals{ get; set; }
        public virtual int? scr_worksOrganizedManner{ get; set; }
        public virtual int? scr_balancesTeam{ get; set; }
        public virtual int? scr_exhibitsObjective{ get; set; }
        public virtual int? scr_welcomesFeedback{ get; set; }
        public virtual int? scr_contribute{ get; set; }
        public virtual int? scr_putsSuccess{ get; set; }
        public virtual int? scr_expressesIdeas{ get; set; }
        public virtual int? scr_writesClearly{ get; set; }
        public virtual int? scr_exhibitsGoodListening{ get; set; }
        public virtual int? scr_keepsOtherAdequate{ get; set; }
        public virtual int? scr_usesAppCom{ get; set; }
        public virtual int? scr_presenDataEff{ get; set; }
        public virtual int? scr_courtesy{ get; set; }
        public virtual int? scr_humanRelations{ get; set; }
        public virtual int? scr_integrity{ get; set; }
        public virtual int? scr_stressTolerance{ get; set; }
        public virtual int? scr_complianceToOffice{ get; set; }
        public virtual int? scr_punctuality{ get; set; }
        public virtual decimal? grandTotal{ get; set; }
        public virtual decimal? avgPoint{ get; set; }
        public virtual string deleted_by { get; set; }
        public virtual DateTime deleted_date { get; set; }
        public virtual bool? is_deleted { get; set; }
    }
    public class PerformanceRateResult_vw
    {
        public Guid performanceRateId { get; set; }
        public Guid personId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public decimal grandTotal { get; set; }
        public decimal avgPoint { get; set; }
    }
}
