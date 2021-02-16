--select ReservationID, min(RoomID) as [First Room] from [Reservation-Room] group by ReservationID

--select Reservation.ReservationID as ID, COUNT( [Reservation-Room].ReservationID ) as Hours from Reservation inner join [Reservation-Room] on Reservation.ReservationID = [Reservation-Room].ReservationID group by Reservation.ReservationID 

select Reservation.ReservationID ,  RoomName, Min(TimeSlot) as 'Starting Time', ApprovalStatus, count(*) as Hours from Reservation
inner join 
[Reservation-Room] on Reservation.ReservationID = [Reservation-Room].ReservationID 
inner join 
Room on [Reservation-Room].RoomID = Room.RoomID 
where 
Reservation.ReservationID = 'RV000001'
group by Reservation.ReservationID, RoomName, ApprovalStatus; 
;

-- reservation id, room name, datetime, rooms status, reservation time