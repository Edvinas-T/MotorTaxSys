using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFMotorTax.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using WPFMotorTax.Models;

namespace WPFMotorTax.Repositories.Tests
{
    [TestClass()]
    public class UserRepositoryTests
    {
        [TestMethod()]
        public void AuthenticateUserTest()
        {
            UserRepository user = new UserRepository();
            Assert.IsTrue(user.AuthenticateUser(new NetworkCredential("151-CK-532", "502124")));


        }

        [TestMethod()]
        public void GetByRegNoTest()
        {


        }

        [TestMethod()]
        public void RemoveTest()
        {
            
        }
    }
}