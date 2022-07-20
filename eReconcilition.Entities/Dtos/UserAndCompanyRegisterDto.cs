using eReconcilition.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconcilition.Entities.Dtos
{
    public class UserAndCompanyRegisterDto
    {
        public UserForRegister UserForRegister { get; set; }
        public Company Company { get; set; }
    }
}
