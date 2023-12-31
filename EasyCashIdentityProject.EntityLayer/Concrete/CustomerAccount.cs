﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccount
    {
        /// <summary>
        /// CustomerAccountID 
        /// </summary>
        public int CustomerAccountID { get; set; }
        /// <summary>
        /// CustomerAccountNumber
        /// </summary>
        public string CustomerAccountNumber { get; set; }
        /// <summary>
        /// CustomerAccountCurrency
        /// </summary>
        public string CustomerAccountCurrency { get; set; }
        /// <summary>
        /// CustomerAccountBalance
        /// </summary>
        public decimal CustomerAccountBalance{ get; set; }
        /// <summary>
        /// BankBranch
        /// </summary>
        public string BankBranch { get; set; }
        /// <summary>
        /// AppUserId
        /// </summary>
        public int AppUserId { get; set; }
        /// <summary>
        /// AppUser
        /// </summary>
        public AppUser AppUser { get; set; }
        /// <summary>
        /// CustomerSender
        /// </summary>
       public List<CustomerAccountProcess> CustomerSender { get; set; }
        /// <summary>
        /// CustomerReceiver
        /// </summary>
       public List<CustomerAccountProcess> CustomerReceiver { get; set; }
    }
}
