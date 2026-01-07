using System;
using System.Collections.Generic;

namespace K2U2.SQL.Tables;

public partial class LibraryMember
{
    public int MemberId { get; set; }

    public string FullName { get; set; } = null!;

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
