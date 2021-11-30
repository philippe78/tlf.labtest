using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfl.test
{
    [TestClass]
    public class RetentionTest
    {
        [TestInitialize]
        public void BaseSetUp() { /* ... */ } // Create new account with cases ,activites etc..!


        [TestCleanup]
        public void BaseTearDown() { /* ... */ } // Exception thrown!


        [TestMethod]
        public void TeamTestDeleteWithLegacyHold()
        {
        }
        
        [TestMethod]
        public void TeamTestDeleteWithoutLegacyHold()
        {
        }

        [TestMethod]
        public void TeamTestUpdateRetentionAfterCaseClose()
        {
        }




    }
}
