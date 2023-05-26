using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lab5.Models
{
    public partial class Agreement
    {
        public int Id { get; set; }
        public int? PersonId { get; set; }
        public int? StatusId { get; set; }
        public string? Number { get; set; }

        public DateOnly? DateOpen { get; set; }
        public DateOnly? DateClose { get; set; }

        public virtual Person? Person { get; set; }
        public virtual StatusAgrement? Status { get; set; }
    }
}
