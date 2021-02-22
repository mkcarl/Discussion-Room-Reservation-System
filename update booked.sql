UPDATE Room SET BookStatus = 'Booked' WHERE TimeSlot > '2021-02-22 07:00' AND TimeSlot <= '2021-02-22 09:00' AND BookStatus = 'Free';
--Update Room Set BookStatus = 'Free'