using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Models
{
    public class PES11Detail
    {
        [Key]
        public virtual Guid pes11Id { get; set; }
        public virtual Guid personId { get; set; }
        public virtual DateTime? deleted_date { get; set; }
        public virtual bool? is_deleted { get; set; }
        public virtual string immediateSupervisor { get; set; }
        public virtual int? immediateSupPosition { get; set; }
        public virtual string reviewPeriod { get; set; }
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
        public virtual int? scr_usesTimeEff { get; set; }
        public virtual int? scr_plansForAddResources { get; set; }
        public virtual int? scr_integratesChanges { get; set; }
        public virtual int? scr_setsGoals { get; set; }
        public virtual int? scr_worksOrganizedManner { get; set; }
        public virtual int? scr_balancesTeam { get; set; }
        public virtual int? scr_exhibitsObjective { get; set; }
        public virtual int? scr_welcomesFeedback { get; set; }
        public virtual int? scr_contribute { get; set; }
        public virtual int? scr_putsSuccess { get; set; }
        public virtual int? scr_expressesIdeas { get; set; }
        public virtual int? scr_writesClearly { get; set; }
        public virtual int? scr_exhibitsGoodListening { get; set; }
        public virtual int? scr_keepsOtherAdequate { get; set; }
        public virtual int? scr_usesAppCom { get; set; }
        public virtual int? scr_presenDataEff { get; set; }
        public virtual int? scr_courtesy { get; set; }
        public virtual int? scr_humanRelations { get; set; }
        public virtual int? scr_integrity { get; set; }
        public virtual int? scr_stressTolerance { get; set; }
        public virtual int? scr_complianceToOffice { get; set; }
        public virtual int? scr_punctuality { get; set; }
        public virtual decimal? grandTotal { get; set; }
        public virtual decimal? avgPoint { get; set; }
    }
    public class PES11List_vw
    {
        public Guid pes11Id { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public decimal grandTotal { get; set; }
        public decimal avgPoint { get; set; }
    }
}
