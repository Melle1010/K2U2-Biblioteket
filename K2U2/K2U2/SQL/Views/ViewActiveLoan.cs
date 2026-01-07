using System;
using System.Collections.Generic;

namespace K2U2.SQL.Views;

public partial class ViewActiveLoan
{
    public int LoanId { get; set; }

    public string MemberName { get; set; } = null!;

    public string BookTitle { get; set; } = null!;

    public DateTime LoanDate { get; set; }
}
