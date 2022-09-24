
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

    }
}
