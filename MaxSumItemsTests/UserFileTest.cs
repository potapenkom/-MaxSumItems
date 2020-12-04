using MaxSumItems;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace MaxSumItemsTests
{
    [TestFixture]
    public class UserFileTest
    {
        [Test]
        public void Method_Should_Return_String_Array()
        {
            string executableLocation = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(executableLocation, "Test.txt");
            string[] expected = { "a, 22",
                                   "1, 2, 5, 16",
                                   "12, 3, 1, 10",
                                   "44, 23, 99, 7",
                                   "Миша, 85"};
            UserFile userFile = new UserFile(path);
            var result = userFile.Content();

            Assert.AreEqual(expected, result);

        }

        [Ignore("Ignore test")]
        public void Test_To_Ignore()
        {

        }
    }
}
