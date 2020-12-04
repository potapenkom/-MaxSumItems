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
    public class ReaderTests
    {
        [Test]
        public void Method_Should_Return_Result()
        {
            string executableLocation = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(executableLocation, "Test.txt");
            UserFile userFile = new UserFile(path);
            Reader reader = new Reader(userFile);
            var res = reader.Read();

            Assert.That(res, Is.TypeOf<Result>());

        }

        [Ignore("Ignore test")]
        public void Test_To_Ignore()
        {

        }

    }
}
