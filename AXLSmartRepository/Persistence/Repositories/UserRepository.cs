using AdvanceXtensionLibrary.AXL_Security;
using AXLSmartRepository.Core.Models;
using AXLSmartRepository.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(PlutoContext _context) : base(_context) { }

        public async Task<string> UpdateUserAsync(User user)
        {
            var newUser = new User();
            if (user.userId.ToString() != "00000000-0000-0000-0000-000000000000")
            {
                PlutoContext.Users.Update(user);
                newUser = user;
            }
            else
            {
                var userExist = PlutoContext.Users.AsEnumerable().Where(w => w.userName.ToUpper() == user.userName.ToUpper() && w.is_deleted != true).FirstOrDefault();
                if(userExist != null) { return "00000000-0000-0000-0000-000000000000"; }//Return Default Value of Guid if the username already exist

                string temp_salt = axl_guard.generateSalt(10);
                newUser = new User
                {
                    userId = new Guid(),
                    userName = user.userName,
                    salt = temp_salt,
                    hash_code = axl_guard.HashSHA256(user.password, temp_salt),
                    user_level = 1,
                };
                PlutoContext.Users.Add(newUser);
            }
            await PlutoContext.SaveChangesAsync();
            return newUser.userId.ToString();
        }

        public async Task<bool> CheckUserRights(Guid user_id, int module_id, int function_id)
        {
            //PDS - Module 1
            //PDS List - Module 1 - Function 1
            //PDS Entry - Module 1 - Function 2
            var user = await PlutoContext.Users.Where(w => w.userId == user_id).FirstOrDefaultAsync();
            if(user.user_level == 3 && module_id == 1 && function_id == 1) { return false; }
            return true;
        }

        public List<UserList_vw> GetUserListView()
        {
            return PlutoContext.UserList_vws.ToList();
        }

        public async Task<User> GetUserById(Guid id)
        {
            return await PlutoContext.Users.Where(w => w.userId == id).FirstOrDefaultAsync();
        }

        public PlutoContext PlutoContext
        {
            get { return Context as PlutoContext; }
        }
    }
}
