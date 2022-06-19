using eReconcilition.Core.DataAccess.EntityFramework;
using eReconcilition.DataAccess.Abstract;
using eReconcilition.DataAccess.Concreate.EntityFramework.Context;
using eReconcilition.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconcilition.DataAccess.Concreate.EntityFramework
{
    public class EFAccountReconcilitionDal : EfEntityRepositoryBase<AccountReconcilition, ContextDB>, IAccountReconcilitionDal
    {
    
    }
}
