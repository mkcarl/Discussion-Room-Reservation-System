UPDATE  Reservation SET Pax = 8, ApprovalStatus = 'Pending', Comments = 'Still pending' WHERE StudentRegistered = 100001

UPDATE  Room SET BookStatus = 'Booked' WHERE TimeSlot = '2/16/2021 8:00:00 AM'  AND Capacity = '10' AND BookStatus = 'Free'; 
