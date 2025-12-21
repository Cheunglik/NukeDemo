using Xunit;
using NukeDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NukeDemo.Tests
{
    public class StringExtensionTests
    {
        [Fact()]
        public void HasChineseTest()
        {
            var result = true;
            var test = "測試";

            //Xunit.Assert.Fail("This test needs an implementation");
            Assert.Equal(result, test.HasChinese());
        }
    }
}