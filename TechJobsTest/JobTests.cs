﻿
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;


namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        //[TestInitialize]
        //I need to creat two job object


        [TestMethod]
        public void TestMethod()
        {
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            //Create new job objects
            TechJob job1 = new TechJob();
            TechJob job2 = new TechJob();


            //Test if difference between Ids is 1.
            Assert.AreEqual((job2.Id - job1.Id), 1);
            //Assert.AreEqual(job1.Id, job2.Id);
            Assert.AreNotEqual(job1, job2);


        }

        [TestMethod]

        public void TestJobConstructorSetsAllFields()
        {
            // initialized a new Job object
            TechJob job = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            //Using Assert statements to test that the constructor correctly assigns the value of each field.
            Assert.AreEqual(job.Name, "Product tester");
            Assert.AreEqual(job.EmployerName.ToString(), "ACME");
            Assert.AreEqual(job.EmployerLocation.ToString(), "Desert");
            Assert.AreEqual(job.JobType.ToString(), "Quality control");
            Assert.AreEqual(job.JobCoreCompetency.ToString(), "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            //
            TechJob job1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            TechJob job2 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            //Check
            Assert.AreEqual(job1, job1);
            Assert.AreNotEqual(job1, job2);
        }
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            //Arrange
            TechJob job1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string jobString = job1.ToString();
            char[] jobChar = jobString.ToCharArray();

            //Check
            Assert.AreEqual('\n', jobChar[jobChar.Length - 1]);
            Assert.AreEqual('\n', jobChar[0]);
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {

            //Arrange
            TechJob job1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            String answer = $"\nID: " + job1.Id + "\n" +
                    "Name: " + job1.Name + "\n" +
                    "Employer: " + job1.EmployerName.ToString() + "\n" +
                    "Location: " + job1.EmployerLocation.ToString() + "\n" +
                    "Position Type: " + job1.JobType.ToString() + "\n" +
                    "Core Competency: " + job1.JobCoreCompetency.ToString() + "\n";
            //Check
            Assert.AreEqual(job1.ToString(), answer);
        }

        public void TestToStringHandlesEmptyField()
        {
            //Arrange
            TechJob job1 = new TechJob("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string NaN = "Data not available";


            //Check
            if (job1.Name == null || job1.Name == "")
            {
                job1.Name = NaN;
                Assert.AreEqual(job1.Name, NaN);
            }
            else if (job1.EmployerName == null || job1.EmployerName.ToString() == "")
            {
                job1.EmployerName.Value = NaN;
                Assert.AreEqual(job1.EmployerName.ToString(), NaN);

            }
            else if (job1.EmployerLocation == null || job1.EmployerLocation.ToString() == "")
            {
                job1.EmployerLocation.Value = NaN;
                Assert.AreEqual(job1.EmployerLocation.ToString(), NaN);

            }
            else if (job1.JobType == null || job1.JobType.ToString() == "")
            {
                job1.JobType.Value = NaN;
                Assert.AreEqual(job1.JobType.ToString(), NaN);

            }
            else if (job1.JobCoreCompetency == null || job1.JobCoreCompetency.ToString() == "")
            {
                job1.JobCoreCompetency.Value = NaN;
                Assert.AreEqual(job1.JobCoreCompetency.ToString(), NaN);
            }
            
        }

    }
}
