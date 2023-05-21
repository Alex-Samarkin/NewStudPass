// NewStudPass
// NewStudPass
// InternetSource.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 2:15 22 05 2023

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewStudPass
{
    [Table("InternetSource")]
    public class InternetSource
    {
        [Key]
        public int InternetSourceId { get; set; }
        public string NameOf { get; set; }
        public string URI { get; set; }
        public string Comment { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public InternetSource()
        {
            
        }

        public Person Person { get; set; }
    }
}