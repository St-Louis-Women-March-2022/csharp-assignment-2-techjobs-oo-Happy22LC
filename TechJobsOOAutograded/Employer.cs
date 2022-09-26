using System;
using TechJobsOOAutograded;

namespace TechJobsOO
{
    public class Employer : JobField
    {
        //removed code that matches from JobField (e.g. the Id and Value properties and the nextId field are shared).
        public Employer(string value) : base(value)
        {
        }
        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }

    }
}