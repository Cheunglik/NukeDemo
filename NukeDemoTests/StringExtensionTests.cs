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

        [Fact()]
        public void ParseToDoubleTest()
        {
            var test = "1/2";
            var result = 0.5;
            Assert.Equal(result, test.ParseToDouble());
            //Xunit.Assert.Fail("This test needs an implementation");
        }
    }
}