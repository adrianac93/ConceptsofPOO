using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOConcepts4
{
    public abstract class Employee4
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Date4 BirthDate { get; set; }

        public Date4 HiringDate { get; set; }

        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName}, " +
                $"Birth: {BirthDate}, " +
                $"Hiring: {HiringDate}, " +
                $"Is active: {IsActive}";
        }
    }
}