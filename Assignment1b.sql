Create Database ASPNET;
use ASPNET;
CREATE TABLE Persons(
  PersonID			INTEGER AUTO_INCREMENT NOT NULL PRIMARY KEY
  ,FirstName        VARCHAR(30)
  ,LastName         VARCHAR(30)
  ,PhoneNumber   	VARCHAR(20)
  ,EmailAddress 	VARCHAR(60)
  ,StreetAddress    VARCHAR(60)
  ,City             VARCHAR(20)
  ,Province    		VARCHAR(20)
  ,Country   		VARCHAR(20)
  ,PostalCode     	VARCHAR(20)  
);
INSERT INTO Persons(FirstName, LastName, PhoneNumber, EmailAddress, StreetAddress, City, Province, Country, PostalCode) VALUES(
'John','Jmith','1-111-111-1111','JohnJmith@gmail.com','123 Jmith St.','Jmithtown','Jmithland','Jmithtonia','JM14H0');
INSERT INTO Persons(FirstName, LastName, PhoneNumber, EmailAddress, StreetAddress, City, Province, Country, PostalCode) VALUES(
'Wohn','Wmith','1-111-111-1112','WohnWmith@gmail.com','123 Wmith St.','Wmithtown','Wmithland','Wmithtonia','WM14H0');
INSERT INTO Persons(FirstName, LastName, PhoneNumber, EmailAddress, StreetAddress, City, Province, Country, PostalCode) VALUES(
'Aohn','Amith','1-111-111-1113','AohnAmith@gmail.com','123 Amith St.','Amithtown','Amithland','Amithtonia','AM14H0');
INSERT INTO Persons(FirstName, LastName, PhoneNumber, EmailAddress, StreetAddress, City, Province, Country, PostalCode) VALUES(
'Sohn','Smith','1-111-111-1114','SohnSmith@gmail.com','123 Smith St.','Smithtown','Smithland','Smithtonia','SM14H0');
INSERT INTO Persons(FirstName, LastName, PhoneNumber, EmailAddress, StreetAddress, City, Province, Country, PostalCode) VALUES(
'Dohn','Dmith','1-111-111-1115','DohnDmith@gmail.com','123 Dmith St.','Dmithtown','Dmithland','Dmithtonia','DM14H0');


CREATE TABLE RoomStyles(
  StyleID			INTEGER AUTO_INCREMENT NOT NULL PRIMARY KEY
  ,RoomType        	varchar(20)
  ,RoomDescription varchar(256)
);

insert into RoomStyles(RoomType , RoomDescription) VALUES('Bedroom','One bed, 40 inch TV, One couch');
insert into RoomStyles(RoomType , RoomDescription) VALUES('Bedroom','One bed, 48 inch TV, One couch');
insert into RoomStyles(RoomType , RoomDescription) VALUES('Bedroom','Two bed, 60 inch TV, One couch');

insert into RoomStyles(RoomType , RoomDescription) VALUES('Bathroom','One Toilet, One Shower & Large Bath, Ornate Sink');
insert into RoomStyles(RoomType , RoomDescription) VALUES('Bathroom','One Toilet, One Shower & Bath, Double Sink');
insert into RoomStyles(RoomType , RoomDescription) VALUES('Bathroom','One Toilet, One Shower, Sink');

insert into RoomStyles(RoomType , RoomDescription) VALUES('Kitchen','Stovetop with oven, Microwave, Coffeemaker, Refrigerator');
insert into RoomStyles(RoomType , RoomDescription) VALUES('Kitchen','Microwave, Coffeemaker, Refrigerator');
insert into RoomStyles(RoomType , RoomDescription) VALUES('Kitchen','Microwave');

CREATE TABLE Rooms( 
    RoomID INT NOT NULL AUTO_INCREMENT, 
    RoomFloor INT,
    RoomAccessible bool,
    BedroomStyle INT,    
    BathroomStyle int,
    KitchenStyle int,
    PRIMARY KEY (RoomID),
    CONSTRAINT fk1 FOREIGN KEY (BedroomStyle) REFERENCES RoomStyles(StyleID)
    ,CONSTRAINT fk2 FOREIGN KEY (BathroomStyle) REFERENCES RoomStyles(StyleID)
    ,CONSTRAINT fk3 FOREIGN KEY (KitchenStyle) REFERENCES RoomStyles(StyleID)
);

insert into Rooms(RoomFloor ,RoomAccessible ,BedroomStyle, BathroomStyle, KitchenStyle) VALUES(1, TRUE, 1, 4, 7);
insert into Rooms(RoomFloor ,RoomAccessible ,BedroomStyle, BathroomStyle, KitchenStyle) VALUES(1, TRUE, 2, 5, 8);
insert into Rooms(RoomFloor ,RoomAccessible ,BedroomStyle, BathroomStyle, KitchenStyle) VALUES(1, TRUE, 3, 6, 9);
insert into Rooms(RoomFloor ,RoomAccessible ,BedroomStyle, BathroomStyle, KitchenStyle) VALUES(1, TRUE, 1, 4, 7);
insert into Rooms(RoomFloor ,RoomAccessible ,BedroomStyle, BathroomStyle, KitchenStyle) VALUES(1, TRUE, 2, 5, 8);

Create Table Reservations(
	ReservationID INTEGER AUTO_INCREMENT NOT NULL PRIMARY KEY
    ,RoomID int
    ,PersonID int
    ,foreign key (PersonID) references Persons(PersonID)
    ,FOREIGN KEY (RoomID) references Rooms(RoomID)
    ,StartDate date
    ,EndDate date
);

insert into Reservations(RoomID, PersonID, StartDate, EndDate) VALUES(1,5,STR_TO_DATE('1-01-2012', '%d-%m-%Y'),STR_TO_DATE('8-01-2012', '%d-%m-%Y'));
insert into Reservations(RoomID, PersonID, StartDate, EndDate) VALUES(2,4,STR_TO_DATE('1-01-2012', '%d-%m-%Y'),STR_TO_DATE('8-01-2012', '%d-%m-%Y'));
insert into Reservations(RoomID, PersonID, StartDate, EndDate) VALUES(3,3,STR_TO_DATE('1-01-2012', '%d-%m-%Y'),STR_TO_DATE('8-01-2012', '%d-%m-%Y'));
insert into Reservations(RoomID, PersonID, StartDate, EndDate) VALUES(4,2,STR_TO_DATE('1-01-2012', '%d-%m-%Y'),STR_TO_DATE('8-01-2012', '%d-%m-%Y'));
insert into Reservations(RoomID, PersonID, StartDate, EndDate) VALUES(5,1,STR_TO_DATE('1-01-2012', '%d-%m-%Y'),STR_TO_DATE('8-01-2012', '%d-%m-%Y'));

Select * from persons;
Select * from reservations;
Select * from rooms;
Select * from roomstyles; 
