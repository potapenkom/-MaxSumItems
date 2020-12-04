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
    public class ResultTest
    {
        [Test]
        public void Method_Should_Show_Result()
        {
            string executableLocation = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(executableLocation, "Test.txt");
            UserFile userFile = new UserFile(path);
            Reader reader = new Reader(userFile);
            List<int> list = new List<int>() { 1, 5 };
            Result actual = new Result(4, list);
            Result expected = reader.Read();
            char separator = ',';
            string str1 = String.Join(separator, expected.RejectedLines);
            string str2 = String.Join(separator, actual.RejectedLines);
            Assert.AreEqual(str1, str1);
        }

        [Ignore("Ignore test")]
        public void Test_To_Ignore()
        {

        }

    }
}
