create or replace
PROCEDURE GetReviews(Doc_name in varchar2, C_Reviews out sys_refcursor)
as
begin
open C_Reviews for
select re.commentt
from doctor d, reviews re
where d.user_name= doc_name and d.doctor_id=re.doctor_id;
end;


create or replace PROCEDURE
GetMedicicnePrice
(medicineName in VARCHAR2, Mprice out number)

as 
BEGIN
select price into Mprice
FROM medicine M
where M.medicine_name= medicineName;
end;


insert into medicine(medicine_name, typee, price, description, availabilityy)
values('pandol','drug',25,'drug used for influenza and headachs',10)

insert into medicine(medicine_name, typee, price, description, availabilityy)
values('trimdflow','drug',12,'drug used for influenza and headachs',5)


insert into doctor(Doctor_id,user_name,specialist) values(1,'ahmed','cardiolgy')
insert into doctor(Doctor_id,user_name,specialist) values(2,'samaa','sports medicine')
insert into doctor(Doctor_id,user_name,specialist) values(3,'zyad','dentist')


insert into patient(patient_id, user_name) values(1,'sara')
insert into patient(patient_id, user_name) values(2,'zain')


insert into reviews(doctor_id,patient_id,commentt) values(1,1,'nice doctor helped a lot')
insert into reviews(doctor_id,patient_id,commentt) values(2,2,'i started runining again')
insert into reviews(doctor_id,patient_id,commentt) values(3,2,'he cured me perfectly')


insert into appointments(appointment_id,doctor_id,patient_id,booking_date)values(1,1,1, sysdate)
INSERT INTO appointments (appointment_id, doctor_id,patient_id, booking_date)
VALUES (2, 1,1, TO_TIMESTAMP('2023-04-28 13:53:29','YYYY-MM-DD HH24:MI:SS'));

INSERT INTO appointments (appointment_id, doctor_id,patient_id, booking_date)
VALUES (3, 1,2, TO_TIMESTAMP('2023-05-28 13:53:29','YYYY-MM-DD HH24:MI:SS'));

INSERT INTO appointments (appointment_id, doctor_id,patient_id, booking_date)
VALUES (4, 3,2, TO_TIMESTAMP('2023-06-10 13:53:29','YYYY-MM-DD HH24:MI:SS'));


select booking_date from appointments ap,doctor d where d.user_name=:doc_name and d.doctor_id= ap.doctor_id and booking_date >= Sysdate