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
    }
}
