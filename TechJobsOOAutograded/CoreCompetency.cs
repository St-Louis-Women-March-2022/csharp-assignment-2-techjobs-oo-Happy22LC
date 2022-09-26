using System;
using TechJobsOOAutograded;

namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {

        //removed code that matches from JobField (e.g. the Id and Value properties and the nextId field are shared).
        public CoreCompetency(string value) : base(value)
        {
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
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
