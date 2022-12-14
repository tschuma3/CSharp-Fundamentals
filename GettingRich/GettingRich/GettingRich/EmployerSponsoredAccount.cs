using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRich
{
    class EmployerSponsoredAccount : MutualFund
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="initialDeposit"></param>
        public EmployerSponsoredAccount(float initialDeposit)
            : base(initialDeposit)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds money to the account
        /// </summary>
        /// <param name="amount"></param>
        public new void AddMoney(float amount)
        {
            //Doubles the balance            
            balance += amount * 2;
        }

        /// <summary>
        /// Prints the balance
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Balance: " + balance;
        }

        #endregion
    }
}
