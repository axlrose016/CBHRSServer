using AXLSmartRepository.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Persistence
{
    public class PlutoContext : DbContext
    {
        public PlutoContext(DbContextOptions<PlutoContext> opts) : base(opts) { }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<PersonDetail> PersonDetails { get; set; }
        public virtual DbSet<PersonTraining> PersonTrainings { get; set; }
        public virtual DbSet<PersonFamily> PersonFamilies { get; set; }
        public virtual DbSet<PersonEducation> PersonEducations { get; set; }
        public virtual DbSet<PersonEligibility> PersonEligibilities { get; set; }
        public virtual DbSet<PersonWorkExperience> PersonWorkExperiences { get; set; }
        public virtual DbSet<lib_region> Lib_Regions { get; set; }
        public virtual DbSet<lib_province> Lib_Provinces { get; set; }
        public virtual DbSet<lib_city> Lib_Cities { get; set; }
        public virtual DbSet<lib_brgy> Lib_Barangays { get; set; }
        public virtual DbSet<lib_user_level> Lib_User_Levels { get; set; }
        public virtual DbSet<lib_civil_status> Lib_Civil_Statuses { get; set; }
        public virtual DbSet<lib_citizenship> Lib_Citizenships { get; set; }
        public virtual DbSet<lib_blood_type> Lib_Blood_Types { get; set; }
        public virtual DbSet<JobRequisition> JobRequisitions { get; set; }
        public virtual DbSet<lib_department> Lib_Departments { get; set; }
        public virtual DbSet<lib_request_type> Lib_Request_Types { get; set; }
        public virtual DbSet<lib_job_category> Lib_Job_Categories { get; set; }
        public virtual DbSet<lib_occupational_group_code> Lib_Occupational_Group_Codes { get; set; }
        public virtual DbSet<lib_occupational_service_code> Lib_Occupational_Service_Codes { get; set; }
        public virtual DbSet<JobClassification> JobClassifications { get; set; }
        public virtual DbSet<WorkplaceAppicationPlan> WorkplaceAppicationPlans { get; set; }
        public virtual DbSet<ApplicationPlanAndAccomplishment> ApplicationPlanAndAccomplishments { get; set; }
        public virtual DbSet<lib_core_competency> Lib_Core_Competencies { get; set; }
        public virtual DbSet<lib_competency_category> Lib_Competency_Categories { get; set; }
        public virtual DbSet<LDNADetails> LDNADetails { get; set; }
        public virtual DbSet<LDNAResults> LDNAResults { get; set; }
        public virtual DbSet<ClearanceDetail> Clearances { get; set; }
        public virtual DbSet<PES11Detail> PES11s { get; set; }
        public virtual DbSet<BudgetUtilizationDetail> BudgetUtilizationDetails { get; set; }
        public virtual DbSet<OrganizationalGoalDetail> OrganizationalGoalDetails { get; set; }
        public virtual DbSet<HRStaffingPlanDetail> HRStaffingPlanDetails { get; set; }
        public virtual DbSet<ComplaintDetail> ComplaintDetails { get; set; }
        public virtual DbSet<AppointmentDetail> AppointmentDetails { get; set; }
        public virtual DbSet<PerformanceRateDetails> PerformanceRateDetails { get; set; }

        //SQL QUERIES
        public virtual DbSet<PersonList_vw> PersonList_vws { get; set; }
        public virtual DbSet<UserList_vw> UserList_vws { get; set; }
        public virtual DbSet<JobRequisitionList_vw> JobRequisitionList_vws { get; set; }
        public virtual DbSet<WorkplaceApplicationPlan_vw> WorkplaceApplicationPlan_vws { get; set; }
        public virtual DbSet<LDNAConsolidated_sp> LDNAConsolidated_Sps { get; set; }
        public virtual DbSet<ClearanceList_vw> ClearanceList_vws { get; set; }
        public virtual DbSet<PES11List_vw> PES11List_vws { get; set; }
        public virtual DbSet<BudgetUtilizationList_vw> BudgetUtilizationList_vw { get; set; }
        public virtual DbSet<OrganizationalGoalList_vw> OrganizationalGoalList_vws { get; set; }
        public virtual DbSet<HRStaffingPlanList_vw> HRStaffingPlanList_vws { get; set; }
        public virtual DbSet<ComplaintList_vw> ComplaintList_vws { get; set; }
        public virtual DbSet<AppointmentList_vw> AppointmentList_vws { get; set; }
        public virtual DbSet<PerformanceRateResult_vw> PerformanceRateResult_vws { get; set; }
        public virtual DbSet<LDNAList_vw> LDNAList_vws { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<PersonWorkExperience>().Property(x => x.monthlySalary).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<JobRequisition>().Property(x => x.salary).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<PES11Detail>().Property(x => x.grandTotal).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<PES11Detail>().Property(x => x.avgPoint).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<PES11List_vw>().Property(x => x.grandTotal).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<PES11List_vw>().Property(x => x.avgPoint).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<PersonList_vw>().HasNoKey().ToView("PersonList_vw");
            modelBuilder.Entity<UserList_vw>().HasNoKey().ToView("UserList_vw");
            modelBuilder.Entity<JobRequisitionList_vw>().HasNoKey().ToView("JobRequisitionList_vw");
            modelBuilder.Entity<WorkplaceApplicationPlan_vw>().HasNoKey().ToView("WorkplaceApplicationPlan_vw");
            modelBuilder.Entity<LDNAConsolidated_sp>().HasNoKey().ToView("LDNAResult_sp");
            modelBuilder.Entity<ClearanceList_vw>().HasNoKey().ToView("ClearanceList_vw");
            modelBuilder.Entity<PES11List_vw>().HasNoKey().ToView("PES11List_vw");
            modelBuilder.Entity<BudgetUtilizationList_vw>().HasNoKey().ToView("BudgetUtilizationList_vw");
            modelBuilder.Entity<OrganizationalGoalList_vw>().HasNoKey().ToView("OrganizationalGoalList_vw");
            modelBuilder.Entity<HRStaffingPlanList_vw>().HasNoKey().ToView("HRStaffingPlanList_vw");
            modelBuilder.Entity<ComplaintList_vw>().HasNoKey().ToView("ComplaintList_vw");
            modelBuilder.Entity<AppointmentList_vw>().HasNoKey().ToView("AppointmentList_vw");
            modelBuilder.Entity<PerformanceRateResult_vw>().HasNoKey().ToView("PerformanceRateResult_vw");
            modelBuilder.Entity<LDNAList_vw>().HasNoKey().ToView("LDNAList_vw");
            modelBuilder.Entity<BudgetUtilizationDetail>().Property(x => x.totalBudgetJO).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<BudgetUtilizationDetail>().Property(x => x.totalBudgetPlantil).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<BudgetUtilizationDetail>().Property(x => x.amountSpentQ1JO).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<BudgetUtilizationDetail>().Property(x => x.amountSpentQ1Plantil).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<BudgetUtilizationDetail>().Property(x => x.amountSpentQ2JO).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<BudgetUtilizationDetail>().Property(x => x.amountSpentQ2Plantil).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<BudgetUtilizationDetail>().Property(x => x.amountSpentQ3JO).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<BudgetUtilizationDetail>().Property(x => x.amountSpentQ3Plantil).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<BudgetUtilizationDetail>().Property(x => x.amountSpentQ4JO).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<BudgetUtilizationDetail>().Property(x => x.amountSpentQ4Plantil).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<AppointmentDetail>().Property(x => x.finalRating).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<AppointmentDetail>().Property(x => x.wapRating).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<AppointmentDetail>().Property(x => x.performanceEval).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<JobClassification>().Property(f => f.jobClassificationId).ValueGeneratedOnAdd();
            modelBuilder.Entity<PerformanceRateDetails>().Property(x => x.avgPoint).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<PerformanceRateDetails>().Property(x => x.grade).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<PerformanceRateDetails>().Property(x => x.grandTotal).HasColumnType("decimal(18,2)");

        }
    }
}
