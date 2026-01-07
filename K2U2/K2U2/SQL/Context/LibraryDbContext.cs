using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using K2U2.SQL.Tables;
using K2U2.SQL.Views;

namespace K2U2.SQL.Context;

public partial class LibraryDbContext : DbContext
{
    public LibraryDbContext()
    {
    }

    public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<BookReturn> BookReturns { get; set; }

    public virtual DbSet<LibraryMember> LibraryMembers { get; set; }

    public virtual DbSet<Loan> Loans { get; set; }

    public virtual DbSet<ViewActiveLoan> ViewActiveLoans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=MOLFIE-PC;Initial Catalog=LibraryDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__Book__3DE0C2073BB7C227");

            entity.ToTable("Book");

            entity.HasIndex(e => e.Author, "IX_Book_Author");

            entity.HasIndex(e => e.Title, "IX_Book_Title");

            entity.Property(e => e.Author).HasMaxLength(50);
            entity.Property(e => e.StockBalance).HasDefaultValue(5);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        modelBuilder.Entity<BookReturn>(entity =>
        {
            entity.HasKey(e => e.ReturnId).HasName("PK__BookRetu__F445E9A818DD7E9A");

            entity.ToTable("BookReturn", tb => tb.HasTrigger("trg_UpdateStockOnReturn"));

            entity.HasIndex(e => e.FkLoanId, "IX_BookReturn_LoanId");

            entity.HasOne(d => d.FkLoan).WithMany(p => p.BookReturns)
                .HasForeignKey(d => d.FkLoanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BookReturn_Loan");
        });

        modelBuilder.Entity<LibraryMember>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__LibraryM__0CF04B18330BAC18");

            entity.ToTable("LibraryMember");

            entity.Property(e => e.FullName).HasMaxLength(50);
        });

        modelBuilder.Entity<Loan>(entity =>
        {
            entity.HasKey(e => e.LoanId).HasName("PK__Loan__4F5AD45791378E09");

            entity.ToTable("Loan");

            entity.HasIndex(e => e.FkBookId, "IX_Loan_BookId");

            entity.HasIndex(e => e.FkMemberId, "IX_Loan_MemberId");

            entity.HasOne(d => d.FkBook).WithMany(p => p.Loans)
                .HasForeignKey(d => d.FkBookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Loan_Book");

            entity.HasOne(d => d.FkMember).WithMany(p => p.Loans)
                .HasForeignKey(d => d.FkMemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Loan_Member");
        });

        modelBuilder.Entity<ViewActiveLoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ActiveLoans");

            entity.Property(e => e.BookTitle).HasMaxLength(50);
            entity.Property(e => e.MemberName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
