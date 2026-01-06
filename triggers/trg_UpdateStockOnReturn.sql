USE [LibraryDB]
GO

/****** Object:  Trigger [dbo].[trg_UpdateStockOnReturn]    Script Date: 2026-01-06 19:43:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER TRIGGER [dbo].[trg_UpdateStockOnReturn]
ON [dbo].[BookReturn]
AFTER INSERT
AS
BEGIN
    UPDATE Book
    SET StockBalance = StockBalance + 1
    FROM Book B
    JOIN Loan L ON B.BookId = L.FkBookId
    JOIN inserted i ON L.LoanId = i.FkLoanId;
END
GO

ALTER TABLE [dbo].[BookReturn] ENABLE TRIGGER [trg_UpdateStockOnReturn]
GO


