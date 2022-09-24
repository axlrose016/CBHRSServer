using AXLSmartRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Repositories
{
    public interface ISettingRepository 
    {
        Task<JobRequisition> GetJobRequisitionAsync(Guid id);
        IEnumerable<JobRequisition> GetAllJobRequisitions();
        IEnumerable<JobRequisition> FindJobRequisition(Expression<Func<JobRequisition, bool>> predicate);
        Task<Guid> UpdateJobRequisition(JobRequisition entity);
        void RemoveJobRequisition(JobRequisition entity);
        void RemoveJobRequisitionRange(IEnumerable<JobRequisition> entities);
        List<JobRequisitionList_vw> GetJobRequisitionList_vw();
        Task<JobClassification> GetJobClassificationAsync(int id);
        IEnumerable<JobClassification> GetAllJobClassifications();
        IEnumerable<JobClassification> FindJobClassification(Expression<Func<JobClassification, bool>> predicate);
        Task<int> UpdateJobClassification(JobClassification entity);
        void RemoveJobClassification(JobClassification entity);
        void RemoveJobClassificationRange(IEnumerable<JobClassification> entities);
    }
}
