using Microsoft.VisualStudio.TestTools.UnitTesting;
using WPFMotorTax.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMotorTax.ViewModels.Tests
{
    [TestClass()]
    public class LoginViewModelTests
    {
        [TestMethod()]
        public void LoginViewModelTest()
        {
            LoginViewModel user = new LoginViewModel();
            Assert.AreEqual(true, false);
        }
    }
}