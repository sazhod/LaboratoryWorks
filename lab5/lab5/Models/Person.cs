using System;
using System.Collections.Generic;

namespace lab5.Models
{
    public partial class Person
    {
        public Person()
        {
            Agreements = new HashSet<Agreement>();
        }

        public int Id { get; set; }
        public string? Inn { get; set; }
        public string? Type { get; set; }
        public string? Shifer { get; set; }
        public DateOnly? Date { get; set; }

        public virtual ICollection<Agreement> Agreements { get; set; }
    }
}
