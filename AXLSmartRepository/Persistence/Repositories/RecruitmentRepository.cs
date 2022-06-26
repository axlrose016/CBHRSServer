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
    public class RecruitmentRepository : IRecruitmentRepository
    {
        public RecruitmentRepository(PlutoContext _context) { _Context = _context; }
        private PlutoContext _Context;

        public async Task<AppointmentDetail> GetAppointmetById(Guid id)
        {
            return await _Context.AppointmentDetails.Where(w => w.appointmentId == id).FirstOrDefaultAsync();
        }

        public List<AppointmentList_vw> GetAppointmentListView()
        {
            return  _Context.AppointmentList_vws.ToList();
        }

        public async Task<Guid> UpdateAppointmentDetailAsync(AppointmentDetail appDetail)
        {
            var rec = _Context.AppointmentDetails.AsNoTracking().AsEnumerable().Where(w => w.appointmentId == appDetail.appointmentId).FirstOrDefault();
            if(rec != null)
            {
                _Context.AppointmentDetails.Update(appDetail);
            }
            else
            {
                _Context.AppointmentDetails.Add(appDetail);
            }
            _Context.ChangeTracker.DetectChanges();
            await _Context.SaveChangesAsync();
            return appDetail.appointmentId;
        }
    }
}
