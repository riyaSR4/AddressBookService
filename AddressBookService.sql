--UC1
--Create database
Create database AddressBookService;

Use AddressBookService;

--UC2
Create table AddressBook(
id int primary key identity(1,1),
firstName varchar(20),
lastName varchar(20),
address varchar(30), 
city varchar(20),
state varchar(20), 
zip bigint, 
phoneNumber varchar(10),
email varchar(30)
)

--UC3
--Stored Procedure
Create procedure AddContact
(
@firstName varchar(20),
@lastName varchar(20),
@address varchar(30),
@city varchar(20),
@state varchar(20), 
@zip bigint, 
@phoneNumber varchar(10),
@email varchar(30)
)
As
Begin
Insert into AddressBook(firstName,lastName,address,city,state,zip,phoneNumber,email) 
values(@firstName,@lastName,@address,@city,@state,@zip,@phoneNumber,@email)
End

--UC4
Alter procedure UpdateContact
(
@firstName varchar(20),
@lastName varchar(20),
@address varchar(30),
@city varchar(20),
@state varchar(20), 
@zip bigint, 
@phoneNumber varchar(10),
@email varchar(30)
)
As 
Begin
Update AddressBook set firstName=@firstName, lastName=@lastName, address=@address, city=@city, state=@state, zip=@zip,
phoneNumber=@phoneNumber,email=@email 
where firstName=@firstName;
End

--UC5
Alter procedure DeleteContact
(
	@firstName varchar(20)
)
As
Begin
Delete from AddressBook where firstName=@firstName;
End

--UC6
Create Procedure City(
@city varchar(20)
)
As
Begin Select * from AddressBook where city=@city order by firstName 
End

Create Procedure State(
@state varchar(20)
)
As
Begin Select * from AddressBook where state=@state
End

--UC7
Create Procedure SizeByCity
As
Begin Select city, count(*) as count from AddressBook group by city
End

Create Procedure SizeByState
As
Begin Select state, count(*) as count from AddressBook group by state
End

--UC9
Create table Type(
id int primary key identity(1,1),
type varchar(20)
);

Insert into Type values('Family');
Insert into Type values('Friends');
Insert into Type values('Profession');
Insert into Type values('Others');

select * from Type

Alter table AddressBook
Add type varchar(20);

--UC10
Create Procedure CountByType
As
Begin
Select type, count(*) as count from AddressBook group by type 
End

--UC11
Create Procedure AddPersonValues(
@contactId int,
@type int
)
As
Begin
Insert into AddPerson values(@contactId,@type)
End


Select * from AddressBook
Select * from AddPerson

