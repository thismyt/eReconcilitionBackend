using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eReconcilition.Core.Entities;

namespace eReconcilition.Entities.Concreate
{
    public class AccountReconcilitaionDetail : IEntity
    {
        public int Id { get; set; }
        public int AccounReconcilitionId { get; set; }
        public DateTime Date { get; set; }
        public string Descripiton { get; set; }
        public int CurrencyId { get; set; }
        public decimal CurrencyDebit { get; set; }
        public decimal CurrenctCredit { get; set; }
    }
}
