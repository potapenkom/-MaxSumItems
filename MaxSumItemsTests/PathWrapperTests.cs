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
    public class PathWrapperTests
    {
        [Test]
        public void Method_Should_Check_File_Exists()
        {
            string executableLocation = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().Location);
            string pathA = Path.Combine(executableLocation, "Test.txt");
            string pathB = Path.Combine(executableLocation, "Test.pdf");
            PathWrapper pathWrapperA = new PathWrapper(pathA);
            PathWrapper pathWrapperB = new PathWrapper(pathB);
            pathWrapperA.PathExists();
            pathWrapperA.PathExists();
            Assert.AreEqual(true, pathWrapperA.PathExists());
            Assert.AreEqual(false, pathWrapperB.PathExists());
        }

        [Ignore("Ignore test")]
        public void Test_To_Ignore()
        {

        }

    }
}
