using System;
using System.Collections.Generic;

namespace K2U2.SQL.Tables;

public partial class BookReturn
{
    public int ReturnId { get; set; }

    public DateTime ReturnDate { get; set; }

    public int FkLoanId { get; set; }

    public virtual Loan FkLoan { get; set; } = null!;
}
