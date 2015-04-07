using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BankService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAccountService
    {
        // TODO: My service operations here

        /// <summary>
        /// Method that will decrease or increase the ballance of the amount depending on the type of the transfer
        /// </summary>
        /// <param name="account"></param>
        /// <param name="amount"></param>
        /// <param name="currency"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        [OperationContract]
        Account ProccesTransfer(Account account,decimal amount,string currency,string type);

        /// <summary>
        /// Method that will return our account but with the ballance and currency converted in the currency that is the second parametar
        /// </summary>
        /// <param name="account"></param>
        /// <param name="currency"></param>
        /// <returns></returns>
        [OperationContract]
        Account Convert(Account account,string currency);

       
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    /// <summary>
    /// Class for out account with two properties Ballance and Currency
    /// </summary>
    [DataContract]
    public class Account
    {
        decimal ballance;
        string currency;
        string note;

        [DataMember]
        public decimal Ballance
        {
            get { return ballance; }
            set { ballance = value; }
        }

        [DataMember]
        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }
        [DataMember]
        public string Note
        {
            get { return note; }
            set { note = value; }
        }
    }
}
