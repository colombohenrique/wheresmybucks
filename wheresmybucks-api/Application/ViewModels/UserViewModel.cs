using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class UserViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        public UserViewModel(string userName, string email)
        {
            UserName = userName;
            Email = email;
        }
    }
}
