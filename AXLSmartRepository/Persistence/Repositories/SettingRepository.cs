using AXLSmartRepository.Core.Models;
using AXLSmartRepository.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Persistence.Repositories
{
    public class SettingRepository : ISettingRepository
    {
        private PlutoContext _Context;
        public SettingRepository(PlutoContext _context) { _Context = _context; }
     
        public IEnumerable<JobRequisition> GetAllJobRequisitions()
        {
            return _Context.JobRequisitions.ToList();
        }
    
        public async Task<Guid> UpdateJobRequisition(JobRequisition entity)
        {
            var jobRequisition = _Context.JobRequisitions.AsNoTracking().AsEnumerable().Where(w => w.requisitionId == entity.requisitionId).FirstOrDefault();
            if(jobRequisition != null)
            {
                _Context.JobRequisitions.Update(entity);
            }
            else
            {
                _Context.JobRequisitions.Add(entity);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return entity.requisitionId;
        }

        public async Task<JobRequisition> GetJobRequisitionAsync(Guid id)
        {
            try
            {
                return await _Context.JobRequisitions.Where(w => w.requisitionId == id).FirstOrDefaultAsync();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public IEnumerable<JobRequisition> FindJobRequisition(Expression<Func<JobRequisition, bool>> predicate)
        {
            return _Context.JobRequisitions.Where(predicate);
        }

        public void RemoveJobRequisition(JobRequisition entity)
        {
            _Context.JobRequisitions.Remove(entity);
        }

        public void RemoveJobRequisitionRange(IEnumerable<JobRequisition> entities)
        {
            _Context.JobRequisitions.RemoveRange(entities);
        }

        public List<JobRequisitionList_vw> GetJobRequisitionList_vw()
        {
            return _Context.JobRequisitionList_vws.ToList();
        }

        public async Task<JobClassification> GetJobClassificationAsync(int id)
        {
            try
            {
                return await _Context.JobClassifications.Where(w => w.jobClassificationId == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public IEnumerable<JobClassification> GetAllJobClassifications()
        {
            return _Context.JobClassifications.ToList();
        }

        public IEnumerable<JobClassification> FindJobClassification(Expression<Func<JobClassification, bool>> predicate)
        {
            return _Context.JobClassifications.Where(predicate);
        }

        public async Task<int> UpdateJobClassification(JobClassification entity)
        {
            var jobClassification = _Context.JobClassifications.AsNoTracking().AsEnumerable().Where(w => w.jobClassificationId == entity.jobClassificationId).FirstOrDefault();
            if (jobClassification != null)
            {
                _Context.JobClassifications.Update(entity);
            }
            else
            {
                _Context.JobClassifications.Add(entity);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return entity.jobClassificationId;
        }

        public void RemoveJobClassification(JobClassification entity)
        {
            _Context.JobClassifications.Remove(entity);
        }

        public void RemoveJobClassificationRange(IEnumerable<JobClassification> entities)
        {
            _Context.JobClassifications.RemoveRange(entities);
        }
    }
}
