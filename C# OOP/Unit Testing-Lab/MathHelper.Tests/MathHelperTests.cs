using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.Tests
{
    public class MathHelperTests
    {
        [Test]
        public void Sum_Should_Sum_Correctly()
        {
            MathsHelper helper = new MathsHelper();

            Assert.AreEqual(10, helper.Sum(5, 5), "typak");
        }
    }
}
