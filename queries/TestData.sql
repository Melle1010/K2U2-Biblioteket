-- Insert Members
INSERT INTO LibraryMember (FullName)
VALUES 
('Alice Johnson'),
('Bob Smith'),
('Charlie Davis'),
('Diana Prince');

-- Insert Books
INSERT INTO Book (Title, Author)
VALUES 
('The Great Gatsby', 'F. Scott Fitzgerald'),
('1984', 'George Orwell'),
('To Kill a Mockingbird', 'Harper Lee'),
('The Hobbit', 'J.R.R. Tolkien'),
('Brave New World', 'Aldous Huxley');

-- Insert Loans 
INSERT INTO Loan (LoanDate, FkMemberId, FkBookId)
VALUES 
('2023-10-01', 1, 1), -- Alice borrows Gatsby
('2023-10-05', 2, 2), -- Bob borrows 1984
('2023-10-10', 3, 4), -- Charlie borrows The Hobbit
('2023-10-12', 1, 3); -- Alice borrows Mockingbird

-- Insert Returns
INSERT INTO BookReturn (ReturnDate, FkLoanId)
VALUES 
('2023-10-15', 1), -- Alice returns Gatsby
('2023-10-20', 2); -- Bob returns 1984
