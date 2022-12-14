using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRich
{
    /// <summary>
    /// This class is the parent class.
    /// It sets the amount in the account and adds money.
    /// to the account.
    /// </summary>
    class InvestmentAccount
    {
        #region Fields

        protected float balance;

        #endregion

        #region Constructors

        /// <summary>
        /// Sets the balance
        /// </summary>
        /// <param name="initialDeposit"></param>
        public InvestmentAccount(float initialDeposit)
        {
            //Sets the initial balance
            balance = initialDeposit;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets balance for this account
        /// </summary>
        public float Balance
        {
            get { return balance; }
        }

        #endregion

        #region Methods
        
        /// <summary>
        /// Adds money to the account
        /// </summary>
        /// <param name="amount"></param>
        public void AddMoney (float amount)
        {
            //Checks to see if the amount is above 0
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("The amount needs to be higher than 0!");
            }
        }

        /// <summary>
        /// Update balance
        /// </summary>
        public void UpdateBalance()
        {
            
        }

        #endregion

    }
}
