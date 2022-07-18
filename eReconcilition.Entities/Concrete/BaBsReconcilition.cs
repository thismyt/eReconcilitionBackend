﻿using eReconcilition.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconcilition.Entities.Concreate
{
    public class BaBsReconcilition : IEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int CurrencyAccountId { get; set; }
        public string Type { get; set; }
        public int Mount { get; set; }
        public int Year { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public bool IsSendEmail { get; set; }
        public DateTime? SendEmailDate { get; set; }
        public bool? IsEmailRead { get; set; }
        public DateTime? EmailReadDate { get; set; }
        public bool? IsResultSucced { get; set; }
        public DateTime? ResultDate { get; set; }
        public string? ResultNote { get; set; }
    }
}
