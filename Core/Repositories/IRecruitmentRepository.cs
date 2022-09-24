using AXLSmartRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Repositories
{
    public interface IRecruitmentRepository
    {
        Task<AppointmentDetail> GetAppointmetById(Guid id);
        List<AppointmentList_vw> GetAppointmentListView();
        Task<Guid> UpdateAppointmentDetailAsync(AppointmentDetail appDetail);
    }
}
