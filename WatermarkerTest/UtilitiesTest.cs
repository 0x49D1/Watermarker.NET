using NUnit.Framework;
using Watermarker.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace WatermarkerTest
{
    
    
    /// <summary>
    ///This is a test class for UtilitiesTest and is intended
    ///to contain all UtilitiesTest Unit Tests
    ///</summary>
    [TestFixture]
    public class UtilitiesTest
    {
    

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetFilesMD5Hash
        ///</summary>
        [Test]
        public void GetFilesMD5HashTest()
        {
            Utilities target = new Utilities();
            // some file with known CRC (MD5 hash)
            string file = @"D:\My Documents\My Dropbox\Projects\Watermarker\WindowsFormsApplication1\1267383924_image_edit_32.ico"; 
            string expected = "1a94f2a036c177ad7589c3114027c1a0"; 
            string actual;
            actual = target.GetFilesMD5Hash(file);
            Assert.AreEqual(expected, actual.ToLower());
        }
    }
}
