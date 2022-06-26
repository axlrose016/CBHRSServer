using AXLSmartRepository.Core.Models;
using AXLSmartRepository.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Persistence.Repositories
{
    public class PerformanceMgntRepository : IPerformanceMgntRepository
    {
        public PerformanceMgntRepository(PlutoContext _context) { _Context = _context; }
        private PlutoContext _Context;

        //BUDGET UTILIZATION
        public async Task<BudgetUtilizationDetail> GetBudgetUtilizationById(Guid id)
        {
            return await _Context.BudgetUtilizationDetails.Where(w => w.budgetUtilId == id).FirstOrDefaultAsync();
        }
        public List<BudgetUtilizationList_vw> GetBudgetUtilizationListView()
        {
            return _Context.BudgetUtilizationList_vw.ToList();
        }
        public async Task<Guid> UpdateBudgetUtilizationDetailAsync(BudgetUtilizationDetail pMgntDetail)
        {
            var pes = _Context.BudgetUtilizationDetails.AsNoTracking().AsEnumerable().Where(w => w.budgetUtilId == pMgntDetail.budgetUtilId).FirstOrDefault();
            if (pes != null)
            {
                _Context.BudgetUtilizationDetails.Update(pMgntDetail);
            }
            else
            {
                _Context.BudgetUtilizationDetails.Add(pMgntDetail);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return pMgntDetail.budgetUtilId;
        }

        //ORGANIZATIONAL GOAL
        public async Task<OrganizationalGoalDetail> GetOrganizationalGoalById(Guid id)
        {
            return await _Context.OrganizationalGoalDetails.Where(w => w.orgGoalId == id).FirstOrDefaultAsync();
        }
        public List<OrganizationalGoalList_vw> GetOrganizationalGoalListView()
        {
            return _Context.OrganizationalGoalList_vws.ToList();
        }
        public async Task<Guid> UpdateOrganizationalGoalDetailAsync(OrganizationalGoalDetail pMgntDetail)
        {
            var pMngt = _Context.OrganizationalGoalDetails.AsNoTracking().AsEnumerable().Where(w => w.orgGoalId == pMgntDetail.orgGoalId).FirstOrDefault();
            if (pMngt != null)
            {
                _Context.OrganizationalGoalDetails.Update(pMgntDetail);
            }
            else
            {
                _Context.OrganizationalGoalDetails.Add(pMgntDetail);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return pMgntDetail.orgGoalId;
        }

        //HR STAFFING PLAN
        public async Task<HRStaffingPlanDetail> GetHRStaffingById(Guid id)
        {
            return await _Context.HRStaffingPlanDetails.Where(w => w.hrStaffingId == id).FirstOrDefaultAsync();
        }
        public List<HRStaffingPlanList_vw> GetHRStaffingListView()
        {
            return _Context.HRStaffingPlanList_vws.ToList();
        }
        public async Task<Guid> UpdateHRStaffingDetailAsync(HRStaffingPlanDetail pMgntDetail)
        {
            var pMngt = _Context.HRStaffingPlanDetails.AsNoTracking().AsEnumerable().Where(w => w.hrStaffingId == pMgntDetail.hrStaffingId).FirstOrDefault();
            if (pMngt != null)
            {
                _Context.HRStaffingPlanDetails.Update(pMgntDetail);
            }
            else
            {
                _Context.HRStaffingPlanDetails.Add(pMgntDetail);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return pMgntDetail.hrStaffingId;
        }

        //HR STAFFING PLAN
        public async Task<ComplaintDetail> GetComplaintDetailById(Guid id)
        {
            return await _Context.ComplaintDetails.Where(w => w.complaintId == id).FirstOrDefaultAsync();
        }
        public List<ComplaintList_vw> GetComplaintDetailListView()
        {
            return _Context.ComplaintList_vws.ToList();
        }
        public async Task<Guid> UpdateComplaintDetailAsync(ComplaintDetail pMgntDetail)
        {
            var pMngt = _Context.ComplaintDetails.AsNoTracking().AsEnumerable().Where(w => w.complaintId == pMgntDetail.complaintId).FirstOrDefault();
            if (pMngt != null)
            {
                _Context.ComplaintDetails.Update(pMgntDetail);
                _Context.Entry(pMgntDetail).State = EntityState.Modified;
            }
            else
            {
                _Context.ComplaintDetails.Add(pMgntDetail);
                _Context.Entry(pMgntDetail).State = EntityState.Added;
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return pMgntDetail.complaintId;
        }


    }
}
