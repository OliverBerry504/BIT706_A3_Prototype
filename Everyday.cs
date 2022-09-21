﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BIT706_A3_OliverBerry
{
    public class Everyday : Account
    {   
        // -------- Constructors -------
        public Everyday(Customer customer) : base(customer)
        {
            AccType = "Everyday";
        }
        // ---------- Methods ----------
        // Display account info
        public override string Info()
        {
            return "Acc Info:\nCustomer ID: " + Customer.ID +
                   "\nEveryday ID: " + AccountId +
                   "\nBalance: $" + Math.Round(Balance, 2) + "\n";
        }
        // Trensaction (Deposit)
        public override void Deposit(double amountIn)
        {
            base.Deposit(amountIn);
            LastTransaction = StoreLastDeposit(amountIn, AccType);
        }
        // Transaction (Withdrawal)
        public override void Withdraw(double amountOut)
        {
            if (amountOut > Balance)
            {
                LastTransaction = StoreLastWithdrawal(amountOut, AccType, "Failed", 0);
                throw new FailedWithdrawalException("Failed Withdrawal" + "\n[Acc - " + AccType + "]");
            }
            else
            {
                base.Withdraw(amountOut);
                LastTransaction = StoreLastWithdrawal(amountOut, AccType, "Successful", 0);
            }
        }
    }
}