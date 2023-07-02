using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;


namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        /// <summary>
        /// CustomerName
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// CustomerSurname
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// CustomerDistrict
        /// </summary>
        public string District { get; set; }
        /// <summary>
        /// Customer's City
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Customer's ImageUrl
        /// </summary>
        public string ImageUrl { get; set; }
        public List<CustomerAccount> CustomerAccounts { get; set; }




    }
}
