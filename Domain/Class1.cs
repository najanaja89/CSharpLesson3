using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        private int userId;
        private string userName;
        private string userSername;

        public int GetUserId() { return userId; }
        public string GetUserName() { return userName; }
        public string GetUserSername() { return userSername; }
    }
}
