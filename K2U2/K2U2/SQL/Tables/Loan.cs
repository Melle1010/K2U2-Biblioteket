using System;
using System.Collections.Generic;

namespace K2U2.SQL.Tables;

public partial class Loan
{
    public int LoanId { get; set; }

    public DateTime LoanDate { get; set; }

    public int FkMemberId { get; set; }

    public int FkBookId { get; set; }

    public virtual ICollection<BookReturn> BookReturns { get; set; } = new List<BookReturn>();

    public virtual Book FkBook { get; set; } = null!;

    public virtual LibraryMember FkMember { get; set; } = null!;
}
