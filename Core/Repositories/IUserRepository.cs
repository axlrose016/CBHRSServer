using AXLSmartRepository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<string> UpdateUserAsync(User user);
        Task<bool> CheckUserRights(Guid user_id, int module_id, int function_id);
        List<UserList_vw> GetUserListView();
        Task<User> GetUserById(Guid id);
    }
}
