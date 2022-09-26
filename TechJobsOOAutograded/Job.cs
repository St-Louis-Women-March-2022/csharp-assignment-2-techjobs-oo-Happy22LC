using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class TechJob
    {
        /*
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        // TODO: Generate Equals() and GetHashCode() methods.

        */
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        // TODO: Generate Equals() and GetHashCode() methods.
        public TechJob()
        {
            Id = nextId;
            nextId++;
        }

        // public TechJob(string value) : base(value)
        //{
        //}

        public TechJob(string name, Employer employer,  Location location,  PositionType positionType,  CoreCompetency coreCompetency) : this()
        {
            Name = name;
            EmployerName = employer; //new Employer(employer.ToString());
            EmployerLocation = location; //new Location(location.ToString());
            JobType = positionType; //new PositionType(positionType.ToString());
            JobCoreCompetency = coreCompetency; //new CoreCompetency(coreCompetency.ToString());
        }

        public override bool Equals(object obj)
        {
            return obj is TechJob job &&
                   Id == job.Id &&
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(EmployerName, job.EmployerName) &&
                   EqualityComparer<Location>.Default.Equals(EmployerLocation, job.EmployerLocation) &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType) &&
                   EqualityComparer<CoreCompetency>.Default.Equals(JobCoreCompetency, job.JobCoreCompetency);
        }

        public override int GetHashCode()
        {
            //return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string NaN = "Data Not Available";

            if (Name == null || Name == "")
            {
                Name = NaN;
            }
            else if (EmployerName == null || EmployerName.ToString() == "")
            {
                EmployerName.Value = NaN;
            }
            else if (EmployerLocation == null || EmployerLocation.ToString() == "")
            {
                EmployerLocation.Value = NaN;
            }
            else if (JobType == null || JobType.ToString() == "")
            {
                JobType.Value = NaN;
            }
            else if (JobCoreCompetency == null || JobCoreCompetency.ToString() == "")
            {
                JobCoreCompetency.Value = NaN;
            }

            return "\n" + "ID: " + Id + "\n" +
                    "Name: " + Name + "\n" +
                    "Employer: " + EmployerName.ToString() + "\n" +
                    "Location: " + EmployerLocation.ToString() + "\n" +
                    "Position Type: " + JobType.ToString() + "\n" +
                    "Core Competency: " + JobCoreCompetency.ToString() + "\n";
        }
    }
}