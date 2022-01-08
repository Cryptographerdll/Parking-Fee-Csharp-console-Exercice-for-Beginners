using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_Charges_Exercice
{
    /* 
       A parking garage charges a $2.00 minimum fee to park for up to three hours. 
       The garage charges an additional $0.50 per hour for each hour or part thereof in excess of three hours. 
       The maximum charge for any given 24-hour period is $10.00. Assume that no car parks for longer than 24 hours at a time.
       Write an app that calculates and displays the parking charges for each customer who parked in the garage yesterday. 
       You should enter the hours parked for each customer. 
       The app should display the charge for the current customer and should calculate and display the running total of yesterday’s receipts. 
       The app should use method CalculateCharges to determine the charge for each customer. 
   */
    class Customer
    {
        const double MIN_CHARGE = 2.00;
        const double SURCHARGE = 0.5;
        const int BASIC_HOURS = 3;
        const double MAX_CHARGE = 10.0;
        const int MAX_HOURS = 24;
        private double _hours;

        public Customer (double hours)
        {
            this.HOURS = hours;
        }

        public double HOURS
        {
            get
            {
                return _hours;
            }

            set
            {
                value = (value < 0 || value > 24) ? 
                    throw new Exception("Incorrecte value") : this._hours = value;
            }
        }

        public double CalculateCharges()
        {
            /// <summary> 
            #region Comment => 6 is the charge of the first 3 Hours 
            #endregion
            /// </summary>
            /// 
            double TotalCharge;

            if (HOURS <= BASIC_HOURS)
                TotalCharge = HOURS * MIN_CHARGE;

            else
                TotalCharge = ( MIN_CHARGE * BASIC_HOURS) + ((HOURS + BASIC_HOURS) + (MIN_CHARGE * SURCHARGE));

            if (TotalCharge > MAX_CHARGE)
                TotalCharge = 10;

            return TotalCharge;
        }
    }
}
