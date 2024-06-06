using Data_Access_Layer;
using Data_Access_Layer.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic_Layer
{
    public class BALAdminUser
    {
        private readonly DALAdminUser _dalAdminUser;

        public BALAdminUser(DALAdminUser dalAdminUser)
        {
            _dalAdminUser = dalAdminUser;
        }

        public async Task<List<UserDetail>> UserDetailAsync()
        {
            try
            {

                var userDetails =  await _dalAdminUser.UserDetailsListAsync();
                
                if (userDetails == null || userDetails.Count == 0)
                {
                    return null;
                }
                return userDetails;
                
            }
            catch(Exception ex)
            {
                throw;
            }
            return null;
        }
    }
}
