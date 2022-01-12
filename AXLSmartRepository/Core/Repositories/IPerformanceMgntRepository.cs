using AXLSmartRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Repositories
{
    public interface IPerformanceMgntRepository
    {
        Task<BudgetUtilizationDetail> GetBudgetUtilizationById(Guid id);
        List<BudgetUtilizationList_vw> GetBudgetUtilizationListView();
        Task<Guid> UpdateBudgetUtilizationDetailAsync(BudgetUtilizationDetail pMgntDetail);
        Task<OrganizationalGoalDetail> GetOrganizationalGoalById(Guid id);
        List<OrganizationalGoalList_vw> GetOrganizationalGoalListView();
        Task<Guid> UpdateOrganizationalGoalDetailAsync(OrganizationalGoalDetail pMgntDetail);
        Task<HRStaffingPlanDetail> GetHRStaffingById(Guid id);
        List<HRStaffingPlanList_vw> GetHRStaffingListView();
        Task<Guid> UpdateHRStaffingDetailAsync(HRStaffingPlanDetail pMgntDetail);
        Task<ComplaintDetail> GetComplaintDetailById(Guid id);
        List<ComplaintList_vw> GetComplaintDetailListView();
        Task<Guid> UpdateComplaintDetailAsync(ComplaintDetail pMgntDetail);

    }
}
