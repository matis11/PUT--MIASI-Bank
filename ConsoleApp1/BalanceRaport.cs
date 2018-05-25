﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class BalanceRaport: Visitor
    {
        BalanceRaport() {
            sumBalance = 0;
        }
        private float sumBalance = 0;

        public override void visit(BankAccount ba)
        {
            sumBalance += ba.balance;
        }

        public override void visit(Credit credit)
        {
            sumBalance += credit.balance;
        }

        public override void visit(Deposit deposit)
        {
            sumBalance += deposit.balance;
        }

        public float getBalance()
        {
            return sumBalance;
        }

        public void printReport()
        {
            System.Console.WriteLine("Balance Status: ", sumBalance);
        }
    }
}