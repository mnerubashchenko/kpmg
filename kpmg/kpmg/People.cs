using System;
using System.Collections.Generic;

namespace kpmg
{
    public partial class People
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
