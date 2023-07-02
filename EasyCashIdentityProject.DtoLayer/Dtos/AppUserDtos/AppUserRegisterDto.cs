using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos
{
    public class AppUserRegisterDto
    {
        /// <summary>
        /// User-Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// User-SurName
        /// </summary>
        public string SurName { get; set; }

        /// <summary>
        /// User-Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// User-UserName
        /// </summary>
        
        public string UserName { get; set; }

        /// <summary>
        /// User-Password
        /// </summary>

        public string Password { get; set; }

        /// <summary>
        /// User-ConfirmPassword
        /// </summary>
        public string ConfirmPassword { get; set; }
    }
}
