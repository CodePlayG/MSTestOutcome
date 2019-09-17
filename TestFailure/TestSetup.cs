using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace DemoTest
{
    [TestClass]
    public abstract class TestSetup
    {
        public TestContext TestContext { get; set; }
        private const string resultName = "Result.txt";
       // private const string failedTestFile = "FailedTests.txt";
        [ClassInitialize]
        public static void BeforeClass(TestContext testContext)
        {
            
            WriteToFile(resultName, $"===================Test execution started: {DateTime.Now}=============================");
        }

        [TestInitialize]
        public void BeforeTestMethodRun()
        {
            string testToWrite = $"Tets execution Started: {TestContext.TestName}";
            WriteToFile(resultName, testToWrite);
        }
        [TestCleanup]
        public void AfterTestMethodRun()
        {
            if (TestContext.CurrentTestOutcome.Equals(UnitTestOutcome.Failed))
            {
                string testToWrite = $"{TestContext.TestName}: Failed";
                WriteToFile(resultName, testToWrite);
            }
            else
            {
                WriteToFile(resultName, $"{TestContext.TestName} : {TestContext.CurrentTestOutcome}");
            }
        }
        private static void WriteToFile(string fileName, string textToWrite)
        {
            string resultFile = Path.Combine(Environment.CurrentDirectory, $"../../../../../{fileName}");
            using (StreamWriter streamWriter = new StreamWriter(resultFile,true))
            {
                if (!File.Exists(resultFile)) { File.Create(resultFile); }
                streamWriter.WriteLine(textToWrite);
            }
        }
    }
}