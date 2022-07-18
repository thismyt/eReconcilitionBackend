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
    public class EFCompanyDal : EfEntityRepositoryBase<Company, ContextDB>, ICompanyDal
    {
        public void UserCompanyAdd(int userId, int companyId)
        {
            using (var context = new ContextDB())
            {
                UserCompany userCompany = new UserCompany()
                {
                    UserId = userId,
                    CompanyId = companyId,
                    AddDate = DateTime.Now,
                    IsActive = true
                };
                context.UserCompanies.Add(userCompany); 
               
            }
        }
    }
}
