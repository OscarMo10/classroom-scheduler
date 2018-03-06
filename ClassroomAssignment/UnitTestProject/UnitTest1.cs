using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExcelDataReader;
using System.IO;

namespace UnitTestProject
{
    [TestClass]
    public class ExcelDataReaderTests
    {
        [TestMethod]
        public void ReadTermFromDepartmentDoc()
        {

            // path to "data.csv" in My Documents folder
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "data1.csv");

            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateCsvReader(stream))
                {
                    var dataSet = reader.AsDataSet();
                    var dataTable = dataSet.Tables[0];

                    Assert.AreEqual("Fall 2018", dataTable.Rows[0][0]);
                }
            }
        }
    }
}
