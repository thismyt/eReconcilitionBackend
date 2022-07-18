using eReconcilition.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconcilition.Entities.Concreate
{
    public class OperationClaim:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AddDate { get; set; }
        public bool IsActive { get; set; }
    }
}
