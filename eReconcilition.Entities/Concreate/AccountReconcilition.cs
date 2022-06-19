﻿using eReconcilition.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconcilition.Entities.Concreate
{
    public class AccountReconcilition:IEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int CurrenctyAccountId { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public int CurrenctId { get; set; }
        public decimal CurrencyDebit { get; set; }
        public decimal CurrencyCredit { get; set; }
        public bool IsSendEmail { get; set; }
        public DateTime? SendEmailDate { get; set; }
        public bool? IsEmailRead { get; set; }
        public DateTime? EmailReadDate { get; set; }
        public bool? IsResultSucced { get; set; }
        public DateTime? ResultDate { get; set; }
        public string? ResultNote { get; set; }
    }
}
