using System;
using System.Collections.Generic;

namespace K2U2.SQL.Tables;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public int? StockBalance { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
