using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DtoLayer.Dtos.CustomerAccountProcessDtos
{
    public class SendMoneyForCustomerAccountProcessDto
    {
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
        public int SenderID { get; set; }
       
        /// <summary>
        /// ReceiverID
        /// </summary>
        public int ReceiverID { get; set; }
        /// <summary>
        /// ReceiverAccountNumber
        /// </summary>
        public string ReceiverAccountNumber { get; set; }

    }
}
