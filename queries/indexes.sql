-- Creates index for book title
CREATE INDEX IX_Book_Title ON Book(Title);

-- Creates index for book author
CREATE INDEX IX_Book_Author ON Book(Author);

-- Creates index for member foreign key
CREATE INDEX IX_Loan_MemberId ON Loan(FkMemberId);

-- Creates index for book foreign key
CREATE INDEX IX_Loan_BookId ON Loan(FkBookId);

-- Creates index for loan foreign key
CREATE INDEX IX_BookReturn_LoanId ON BookReturn(FkLoanId);
