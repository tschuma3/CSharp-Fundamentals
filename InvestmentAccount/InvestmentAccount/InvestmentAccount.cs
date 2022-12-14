using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentAccount
{
    /// <summary>
    /// An investment account
    /// </summary>
    public class InvestmentAccount : Updating
    {
        #region Fields

        protected float balance;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="deposit">initial deposit</param>
        public InvestmentAccount(float deposit) :
            base(deposit)
        {
            balance = deposit;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the balance in the account
        /// </summary>
        float Balance
        {
            get { return balance; }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Adds money to the account
        /// </summary>
        /// <param name="amount">amount to add</param>
        public virtual void AddMoney(float amount)
        {
            // validate and update balance
            if (amount >= 0)
            {
                balance += amount;
            }
            else
            {
                Console.WriteLine("You can't add a negative amount!");
            }
        }

        /// <summary>
        /// Updates the balance in the account
        /// </summary>
        public override void UpdateBalance()
        {
            balance += balance * 0.1f;
        }

        #endregion
    }
}
