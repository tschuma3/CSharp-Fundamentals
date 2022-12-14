using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRich
{
    class MutualFund : InvestmentAccount
    {
        #region Fields

        const float ServiceChargePercent = 2.7f;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="interestRate"></param>
        public MutualFund(float interestRate)
            : base(interestRate)
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
            //Takes a service charge out
            amount += amount / ServiceChargePercent;
            balance += amount;
        }

        /// <summary>
        /// Prints the balance
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Balance: " + balance;
        }

        /// <summary>
        /// Updates the balance
        /// </summary>
        public new void UpdateBalance()
        {
            balance += balance * 2.7f;
        }

        #endregion
    }
}
