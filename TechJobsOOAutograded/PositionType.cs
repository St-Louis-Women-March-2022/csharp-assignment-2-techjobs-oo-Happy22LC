using System;
using TechJobsOOAutograded;

namespace TechJobsOO
{
    public class PositionType : JobField
    {
        //removed code that matches from JobField (e.g. the Id and Value properties and the nextId field are shared).
        public PositionType(string value) : base(value)
        {
        }


        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.

        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            return obj is PositionType type &&
                   Id == type.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        /* public override bool Equals(object obj)
         {
             return obj is PositionType type &&
                    Id == type.Id &&
                    Value == type.Value;
         }

         public override int GetHashCode()
         {
             return HashCode.Combine(Id, Value);
         }*/
    }
}