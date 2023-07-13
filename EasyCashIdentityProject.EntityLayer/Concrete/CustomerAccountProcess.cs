using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccountProcess
    {
        /// <summary>
        /// CustomerAccountProcessID
        /// </summary>
        
        public int CustomerAccountProcessID { get; set; }
        /// <summary>
        /// ProcessType
        /// </summary>
        
        public string ProcessType { get; set; }

        /// <summary>
        /// Amount
        /// </summary>
        
        public decimal Amount { get; set; }
        /// <summary>
        /// ProcessDate
        /// </summary>

        public DateTime ProcessDate { get; set; }
        /// <summary>
        /// SenderID
        /// </summary>
        public int? SenderID { get; set; }
        /// <summary>
        /// ReceiverID
        /// </summary>
        public int? ReceiverID { get; set; }
        /// <summary>
        /// SenderCustomer
        /// </summary>
        public CustomerAccount SenderCustomer { get; set; }
        /// <summary>
        /// ReceiverCustomer
        /// </summary>
        public CustomerAccount ReceiverCustomer { get; set; }

    }
}
