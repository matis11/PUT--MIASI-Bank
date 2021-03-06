﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankAccount: BankProduct
    {
        private string name;
        private Client client;
        private DateTime establishDate;
        private Debet debet = null; // may be sth or not

        public BankAccount(string number, string name, Client client): base(number)
        {
            this.name = name;
            this.establishDate = new DateTime();
            this.debet = null;
            this.client = client;
        }
    }
}
