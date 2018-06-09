using P.Data.Infrastructure;
using P.Domain.Entities;
using PService.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.Service
{
    public class UserService: Service<User>, IUserService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);


        public UserService()
           : base(ut)
        {
        }
    }
}
