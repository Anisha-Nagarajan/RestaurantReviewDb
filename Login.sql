CREATE TABLE Customer
(
UserName VARCHAR(15) NOT NULL,
Password VARCHAR(15) NOT NULL,
Role VARCHAR(15) NOT NULL 
)
CREATE TABLE HotelOwner
(
UserName VARCHAR(15) NOT NULL,
Password VARCHAR(15) NOT NULL,
Role VARCHAR(15) NOT NULL
)
INSERT INTO Customer VALUES('Akhil','aki123','Customer')
INSERT INTO HotelOwner VALUES('Rajee','rajee123','HotelOwner')

CREATE PROCEDURE InsertCustomer
(
@UserName VARCHAR(15),
@Password VARCHAR(15),
@Role VARCHAR(15) 
)
AS 
BEGIN
INSERT INTO Customer VALUES(@UserName,@Password,@Role)
END

CREATE PROCEDURE InsertHotelOwner
(
@UserName VARCHAR(15),
@Password VARCHAR(15),
@Role VARCHAR(15) 
)
AS
BEGIN
INSERT INTO HotelOwner VALUES(@UserName,@Password,@Role)
END
SELECT * FROM HotelOwner


CREATE TABLE RestaurantDetails
(
Name VARCHAR(25) NOT NULL,
Type VARCHAR(20) NOT NULL,
RegNo NUMERIC(10) UNIQUE NOT NULL,
Owner VARCHAR(20) NOT NULL, 
StreetName VARCHAR(30) NOT NULL,
City VARCHAR(15) NOT NULL,
State VARCHAR(15)  NOT NULL,
Pincode NUMERIC(6) NOT NULL
) 

INSERT INTO RestaurantDetails VALUES
('Taj', 'Veg & Non-Veg',1,'Kaviya','Gandhi street','karur','Tamil Nadu',639004),
('Rasikas', 'Veg',2,'Kavin','Pillaiyar street','coimbatore','Tamil Nadu',623942),
('Shawarama station', 'Veg', 3,'Kayalvizhi','Teachers colony','Madurai','Tamil Nadu',674732),
('Anjappar', 'Non-Veg', 4,'Appu','Anbu Nagar','Salem','Tamil Nadu',636008),
('Saravana Bhavan', 'Veg & Non-Veg', 5,'Subash','Vj street','Erode','Tamil Nadu',657743),
('Barbequeue', 'Non-Veg',6,'Karthika','Velu street','Coimbatore','Tamil Nadu',674543),
('Selvi Mess', 'Non-Veg',7,'Sindhiya','Nivash colony','Namakkal','Tamil Nadu',645453)

CREATE PROCEDURE AddRestaurantDetails
(
@Name VARCHAR(25),
@Type VARCHAR(20),
@RegNo NUMERIC(10),
@Owner VARCHAR(20), 
@StreetName VARCHAR(30),
@City VARCHAR(15),
@State VARCHAR(15),
@Pincode NUMERIC(6)
)
AS 
BEGIN
INSERT INTO RestaurantDetails VALUES(@Name,@Type,@RegNo,@Owner,@StreetName,@City,@State,@Pincode)
END

