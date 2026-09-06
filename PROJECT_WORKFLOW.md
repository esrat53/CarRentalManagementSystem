# Car Rental Management System – Final Workflow

## Roles
- Customer: browse cars, create bookings, pay for pending bookings, cancel unpaid pending bookings, view booking history.
- Owner: manage only their own cars, review their bookings, confirm paid pending bookings, cancel unpaid pending bookings.
- Admin: manage users, cars, and all bookings.

## Booking lifecycle
1. Customer selects a car and rental dates.
2. A booking is created as `Pending` with the calculated `TotalAmount`.
3. Customer pays the exact database booking amount. Payment becomes `Paid`; the booking remains `Pending`.
4. Owner reviews the paid pending booking and confirms it.
5. Confirmed bookings are treated as completed revenue.
6. Unpaid pending bookings may be cancelled. Paid bookings are not cancelled because this project does not implement refunds.
7. Cancelled bookings remain in the database as history.

## Availability
Date overlap uses the standard rental interval rule:
`existing.StartDate < requested.EndDate AND existing.EndDate > requested.StartDate`

The return date is therefore the checkout date, so a one-day rental is StartDate to StartDate + 1 day.

## Database
The application currently uses:
`(localdb)\\MSSQLLocalDB` / `CarRentalDB`

Before the final demo, make sure the database contains:
- Users
- Vehicles
- Bookings
- Payments

Recommended integrity constraints and indexes are in:
`Database/CarRentalDB_Recommended.sql`

## Important demo note
To demonstrate Owner confirmation, create a new booking, leave it Pending, pay it, then log in as the vehicle owner and confirm the paid pending booking.
