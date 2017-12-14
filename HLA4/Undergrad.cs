using System;
using SQLite.Net.Attributes;

namespace HLA4
{
    public class Undergrad
    {
        [PrimaryKey, MaxLength(50), NotNull]
        public string Name
        { get; set; }
        [NotNull, MaxLength(55)]
        public string FBLink
        { get; set; }
        [NotNull, MaxLength(1735)]
        public string Description
        { get; set; }
    }
}
