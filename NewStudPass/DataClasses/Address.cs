// NewStudPass
// NewStudPass
// Address.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 0:12 22 05 2023

using System.ComponentModel.DataAnnotations;

namespace NewStudPass
{
    public class Address
    {
        public int AddressId { get; set; }
        public string State { get; set; }
        public string Region { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Home { get; set; }
        public string Apartment { get; set; }
        public string PostalCode { get; set; }
        public string Comment { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public Person Person { get; set; }

    }
}