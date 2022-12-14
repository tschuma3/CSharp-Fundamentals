using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRich
{
    /// <summary>
    /// This class is a child class.
    /// It takes care of the savings aspect of an account.
    /// </summary>
    class SavingsAccount : InvestmentAccount
    {
        #region Fields

        float interestRate;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="initialDeposit"></param>
        public SavingsAccount(float initialDeposit, float interestRate)
            : base(initialDeposit)
        {
            this.interestRate = interestRate;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Prints the balance
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Balance: " + balance;
        }

        /// <summary>
        /// Updates balance
        /// </summary>
        public new void UpdateBalance()
        {
            balance += balance * interestRate;
        }

        #endregion
    }
}
