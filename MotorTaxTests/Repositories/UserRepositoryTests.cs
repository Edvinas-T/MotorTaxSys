using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFMotorTax.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WPFMotorTax.Repositories.Tests
{
    [TestClass()]
    public class UserRepositoryTests
    {
        [TestMethod()]
        public void AuthenticateUserTest()
        {
            String RegNo = "192-WW-341";
            String PIN = "325152";
            
            UserRepository user = new UserRepository();
            Assert.IsTrue(user.AuthenticateUser(new NetworkCredential(RegNo, PIN)));
        }
    }
}