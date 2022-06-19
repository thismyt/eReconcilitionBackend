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
    public class EFUserDal : EfEntityRepositoryBase<User, ContextDB>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user, int companyId)
        {
            using (var context = new ContextDB())
            {
                var result = from OperationClaim in context.OperationClaims
                             join UserOperationClaim in context.UserOperationClaims on OperationClaim.Id equals UserOperationClaim.Id
                             where UserOperationClaim.CompanyId == companyId && UserOperationClaim.UserId == user.Id
                             select new OperationClaim
                             {
                                 Id = OperationClaim.Id,
                                 Name = OperationClaim.Name,
                             };
                return result.ToList();
            }
        }
    }
}
