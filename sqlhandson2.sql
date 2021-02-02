use UniversityManagementSystemDb
--create tables
--Exercise 2.1
create table Student_Info(Reg_Number varchar(20) constraint reg_number primary key,
Student_Name  Varchar(30),
Branch  Varchar(20),
Contact_Number Varchar(20),
Date_of_Birth Date, 
Date_of_Joining Date, 	
Address Varchar(250),
Email_id Varchar(250))

create table Subject_Master(Subject_Code varchar(10) constraint subject_code primary key,
Subject_Name varchar(20), 
Weightage int)

create table Student_Marks(Reg_Number  varchar(20) constraint fk1 foreign key references Student_Info(Reg_Number),
Subject_Code  varchar(10) constraint fk2 foreign key references Subject_Master(Subject_Code),
Semester int,
Marks int)

create table Student_Result(Reg_Number Varchar(20) constraint fk3 foreign key references Student_Info(Reg_Number),
Semester int,
GPA decimal(5,3),
Is_Eligible_Scholarship varchar(3))

--insert records into tables
--Exercise 2.2
insert into Student_Info(Reg_Number,Student_Name,Branch,Contact_Number,Date_of_Birth,Date_of_Joining,Address,Email_id)
values
('MC101301','James','MCA','9714589787','12-jan-1984','08-jul-2010','No 10,South Block,Nivea','james.mca@yahoo.com'),
('BEC111402','Manio','ECE','8912457875','23-feb-1983','25-jun-2011','8/12,Park View,Sieera','manioma@gmail.com'),
('BEEI101204','Mike','EI','8974567897','10-feb-1983','25-aug-2010','Cross villa,NY','mike.james@ymail.com'),
('MB111305','Paulson','MBA','8547986123','13-dec-1984','08-aug-2010','Lake view,NJ','paul.son@rediffmail.com') 

insert into Student_Marks(Reg_Number,Subject_Code,Semester,Marks)
values
('MC101301','EE01DCF',1,75),
('MC101301','EC02MUP',1,65),
('MC101301','MC06DIP',1,70),
('BEC111402','EE01DCF',1,55),
('BEC111402','EC02MUP',1,80),
('BEC111402','MC06DIP',1,60),
('BEEI101204','EE01DCF',1,85),
('BEEI101204','EC02MUP',1,78),
('BEEI101204','MC06DIP',1,80),
('BEEI101204','MB03MAR',2,75),
('BEEI101204','EI05IP',2,65),
('BEEI101204','CPSC02DS',2,75),
('MB111305','EE01DCF',1,65),
('MB111305','EC02MUP',1,68),
('MB111305','MC06DIP',1,63),
('MB111305','MB03MAR',2,85),
('MB111305','EI05IP',2,74),
('MB111305','CPSC02DS',2,62)

insert into Student_Result(Reg_Number,Semester,GPA,Is_Eligible_Scholarship)
values
('MC101301',1,7.5,'Y'),
('BEC111402',1,7.1,'Y'),
('BEEI101204',1,8.3,'Y'),
('BEEI101204',2,6.9,'N'),
('MB111305',1,6.5,'N'),
('MB111305',2,6.8,'N')

--display records
select * from Student_Info
select * from Student_Result
select * from Student_Marks
select * from Subject_Master


 

