using System;
using System.Collections.Generic;

namespace lab5.Models
{
    public partial class StatusAgrement
    {
        public StatusAgrement()
        {
            Agreements = new HashSet<Agreement>();
        }

        public int Id { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<Agreement> Agreements { get; set; }
    }
}
