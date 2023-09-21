// NewStudPass
// NewStudPass
// Person.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 23:48 21 05 2023

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace NewStudPass
{
    [Table("Persons")]
    public class Person
    {
        public int PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string SecondaryPhone { get; set; }
        public string SecondaryEmail { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual ObservableListSource<Address> Addresss { get; set; }
        public virtual ObservableListSource<InternetSource> InternetSources { get; set; }
        public virtual ObservableListSource<Metric> Metrics { get; set; }

        [NotMapped] public string LastNameWithInitials => $"{LastName??" "} {(FirstName??" ")[0]}.{(MiddleName??" ")[0]}.";
        [NotMapped] public string FullName => $"{LastName??" "} {FirstName??" "} {MiddleName??" "}";
        [NotMapped] public int Age 
        {
            get
            {
                if (DateOfBirth == null) 
                {
                    DateOfBirth = DateTime.Now;
                }

                // Save today's date.
                var today = DateTime.Today;

                // Calculate the age.
                var age = today.Year - DateOfBirth.GetValueOrDefault().Year;

                // Go back to the year in which the person was born in case of a leap year
                if (DateOfBirth.Value.Date > today.AddYears(-age)) age--;

                return age;
            }
        }

    }
}