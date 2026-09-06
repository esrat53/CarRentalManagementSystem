-- Vehicle subtype fields used by the C# Sedan/SUV/Van models.
IF COL_LENGTH('dbo.Vehicles', 'TransmissionType') IS NULL
    ALTER TABLE dbo.Vehicles ADD TransmissionType NVARCHAR(50) NULL;
GO
IF COL_LENGTH('dbo.Vehicles', 'DriveType') IS NULL
    ALTER TABLE dbo.Vehicles ADD DriveType NVARCHAR(50) NULL;
GO
IF COL_LENGTH('dbo.Vehicles', 'CargoVolume') IS NULL
    ALTER TABLE dbo.Vehicles ADD CargoVolume DECIMAL(10,2) NULL;
GO

-- Car Rental Management System - recommended integrity checks
-- Run only after backing up your database. These statements are intended for the existing schema.

-- 1) Prevent duplicate payment records for the same booking.
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = 'UX_Payments_BookingID' AND object_id = OBJECT_ID('dbo.Payments'))
    CREATE UNIQUE INDEX UX_Payments_BookingID ON dbo.Payments(BookingID);
GO

-- 2) Basic booking date validation.
IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE name = 'CK_Bookings_DateRange')
    ALTER TABLE dbo.Bookings ADD CONSTRAINT CK_Bookings_DateRange CHECK (EndDate > StartDate);
GO

-- 3) Prevent zero/negative rental prices.
IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE name = 'CK_Vehicles_PricePerDay')
    ALTER TABLE dbo.Vehicles ADD CONSTRAINT CK_Vehicles_PricePerDay CHECK (PricePerDay > 0);
GO

-- 4) Prevent zero/negative seats.
IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE name = 'CK_Vehicles_Seats')
    ALTER TABLE dbo.Vehicles ADD CONSTRAINT CK_Vehicles_Seats CHECK (Seats > 0);
GO

-- 5) Allowed booking statuses.
IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE name = 'CK_Bookings_Status')
    ALTER TABLE dbo.Bookings ADD CONSTRAINT CK_Bookings_Status CHECK (BookingStatus IN ('Pending','Confirmed','Cancelled'));
GO

-- 6) Allowed payment statuses.
IF NOT EXISTS (SELECT 1 FROM sys.check_constraints WHERE name = 'CK_Payments_Status')
    ALTER TABLE dbo.Payments ADD CONSTRAINT CK_Payments_Status CHECK (PaymentStatus IN ('Paid','Failed','Pending'));
GO

-- IMPORTANT: verify your existing foreign keys before adding duplicates.
-- Recommended relationships:
-- Vehicles.OwnerID -> Users.UserID
-- Bookings.CustomerID -> Users.UserID
-- Bookings.VehicleID -> Vehicles.VehicleID
-- Payments.BookingID -> Bookings.BookingID
