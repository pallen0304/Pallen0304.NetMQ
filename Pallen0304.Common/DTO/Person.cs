using FileHelpers;
using System;

namespace Pallen0304.Common
{
    [DelimitedRecord(","), IgnoreFirst()]
    public class Person
    {
        public int Id { get; set; }

        [FieldQuoted()]
        public string FirstName { get; set; }

        [FieldQuoted()]
        public string LastName { get; set; }

        [FieldQuoted()]
        public string City { get; set; }

        [FieldQuoted()]
        public string State { get; set; }

        [FieldQuoted()]
        public string Country { get; set; }
    }
}
