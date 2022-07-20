using eReconcilition.Core.Utilities.Results.Abstract;
using eReconcilition.Core.Utilities.Security.JWT;
using eReconcilition.Entities.Concreate;
using eReconcilition.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconcilition.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<UserCompanyDto> Register(UserForRegister useForRegister, string password, Company company);
        IDataResult<User> RegisterSecondAccount (UserForRegister useForRegister, string password);

        IDataResult<User> Login(UserForLogin userForLogin);
        IResult UserExists(string email);
        IResult CompanyExists(Company company);
        IDataResult<AccessToken> CreateAccessToken(User user, int companyId);
    }
}
