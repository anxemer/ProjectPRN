-- Create tables
USE master
DROP DATABASE tattoomanagement;
-- Bat dau tu day nha
CREATE DATABASE tattoomanagement;

USE tattoomanagement;

CREATE TABLE [User] (
    user_id INT identity (1,1) PRIMARY KEY,
    user_name VARCHAR(255) NOT NULL,
    password BINARY(64) NOT NULL,
    email VARCHAR(255),
    address NVARCHAR(255),
    phone_number VARCHAR(255),
    role_id INT 
);


CREATE TABLE [role] (
	id INT identity (1,1) PRIMARY KEY,
	roleName VARCHAR(255) NOT NULL
)


CREATE TABLE [Staff] (
    staff_id INT identity (1,1) PRIMARY KEY,
    user_id INT UNIQUE, 
    information NVARCHAR(255),
    experience NVARCHAR(255),
    image NVARCHAR(255)
);


CREATE TABLE [Order] (
    id INT identity (1,1) PRIMARY KEY,
    price DECIMAL(10, 2) NOT NULL,
    [date] DATE,
    [user_id] INT
);


CREATE TABLE [Category_tattoo] (
    id INT identity (1,1) PRIMARY KEY,
    cate_name NVARCHAR(255),
);



CREATE TABLE [tattoo_img]  (
    id INT identity (1,1) PRIMARY KEY,
    image NVARCHAR(255),
    name NVARCHAR(255),
    description NVARCHAR(255),
    location_recommended NVARCHAR(255),
    price DECIMAL(10, 2) NOT NULL,
    cate_id INT,
);


CREATE TABLE [Order_details] (
    id INT identity (1,1) PRIMARY KEY,
    unit_price DECIMAL(10, 2) NOT NULL,
    tattoo_img_id INT,
    status VARCHAR(255),
    sub_total INT,
    order_id INT,
	date_booking DATE,
	staff_id INT
);


-- Add ForeignKey Constraint
ALTER TABLE [staff]
ADD CONSTRAINT FK_Staff_User
FOREIGN KEY (user_id) REFERENCES [user](user_id);

ALTER TABLE [User]
ADD CONSTRAINT FK_User_Role
FOREIGN KEY (role_id) REFERENCES [role](id);

ALTER TABLE [order]
ADD CONSTRAINT FK_Order_User
FOREIGN KEY (user_id) REFERENCES [user](user_id);

ALTER TABLE [tattoo_img]
ADD CONSTRAINT FK_tattooImg_tattooCategory
FOREIGN KEY (cate_id) REFERENCES [category_tattoo](id);

ALTER TABLE [Order_details]
ADD CONSTRAINT FK_orderDetails_order
FOREIGN KEY (order_id) REFERENCES [order](id);

ALTER TABLE [Order_details]
ADD CONSTRAINT FK_orderDetails_tattooImg
FOREIGN KEY (tattoo_img_id) REFERENCES [tattoo_img](id);

ALTER TABLE [Order_details]
ADD CONSTRAINT FK_orderDetails_staff
FOREIGN KEY (staff_id) REFERENCES [Staff](staff_id);


-- Insert data
--Role
INSERT INTO [role]([roleName])
VALUES ('Admin');

INSERT INTO [role]([roleName])
VALUES ('Customer');

INSERT INTO [role]([roleName])
VALUES ('Staff');


--User
INSERT INTO [User]([user_name],[password],[email],[address],[phone_number],[role_id])
VALUES ('Duc Long',1,'DucLong@gmail.com','Q9','0123456781','1');

INSERT INTO [User]([user_name],[password],[email],[address],[phone_number],[role_id])
VALUES ('Minh An',2,'MinhAn@gmail.com','Thu Duc','0123456782','2');

INSERT INTO [User]([user_name],[password],[email],[address],[phone_number],[role_id])
VALUES ('Quoc Doanh',3,'QuocDoanh@gmail.com','Thu Duc','0123456783','3');

INSERT INTO [User]([user_name],[password],[email],[address],[phone_number],[role_id])
VALUES ('Minh Hien',4,'MinhHien@gmail.com','Q9','0123456784','3');


--Staff
INSERT INTO [Staff]([user_id],[information],[experience],[image])
VALUES ('3','Professional Tattooer','20 years','E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Staff\download.jpg');

INSERT INTO [Staff]([user_id],[information],[experience],[image])
VALUES ('4','Junior Tattooer','1 years','E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Staff\download.jpg');


--Tattoo Category
INSERT INTO Category_tattoo([cate_name])
VALUES (N'Minh Họa');

INSERT INTO Category_tattoo([cate_name])
VALUES (N'Đồ Họa');

INSERT INTO Category_tattoo([cate_name])
VALUES (N'Màu Nhỏ');

INSERT INTO Category_tattoo([cate_name])
VALUES (N'Biểu Tượng');

INSERT INTO Category_tattoo([cate_name])
VALUES (N'Việt Nam');

INSERT INTO Category_tattoo([cate_name])
VALUES (N'Châu Á');

INSERT INTO Category_tattoo([cate_name])
VALUES (N'Đen Trắng');

INSERT INTO Category_tattoo([cate_name])
VALUES (N'Chữ');

INSERT INTO Category_tattoo([cate_name])
VALUES (N'Màu Lớn');

INSERT INTO Category_tattoo([cate_name])
VALUES (N'Custom');


--Tattoo img
--MinhHoa
INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\MinhHoa\MinhHoa1.jpg','Minh Hoa Tattoo1','Minh Hoa Tattoo1 cho Khách Hàng','Cánh tay','100','1');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\MinhHoa\MinhHoa2.jpg','Minh Hoa Tattoo2','Minh Hoa Tattoo2 cho Khách Hàng','Cánh tay','100','1');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\MinhHoa\MinhHoa3.jpg','Minh Hoa Tattoo3','Minh Hoa Tattoo3 cho Khách Hàng','Cánh tay','100','1');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\MinhHoa\MinhHoa4.jpg','Minh Hoa Tattoo4','Minh Hoa Tattoo4 cho Khách Hàng','Cánh tay','100','1');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\MinhHoa\MinhHoa5.jpg','Minh Hoa Tattoo5','Minh Hoa Tattoo5 cho Khách Hàng','Cánh tay','100','1');

--DoHoa
INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\DoHoa\DoHoa1.jpg','Do Hoa Tattoo1','Do Hoa Tattoo1 cho Khách Hàng','Cánh tay','100','2');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\DoHoa\DoHoa2.jpg','Do Hoa Tattoo2','Do Hoa Tattoo2 cho Khách Hàng','Cánh tay','100','2');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\DoHoa\DoHoa3.jpg','Do Hoa Tattoo3','Do Hoa Tattoo3 cho Khách Hàng','Cánh tay','100','2');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\DoHoa\DoHoa4.jpg','Do Hoa Tattoo4','Do Hoa Tattoo4 cho Khách Hàng','Cánh tay','100','2');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\DoHoa\DoHoa5.jpg','Do Hoa Tattoo5','Do Hoa Tattoo5 cho Khách Hàng','Cánh tay','100','2');

--MauNho
INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\MauNho\MauNho1.jpg','Mau Nho Tattoo1','Mau Nho Tattoo1 cho Khách Hàng','Cánh tay','100','3');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\MauNho\MauNho2.jpg','Mau Nho Tattoo2','Mau Nho Tattoo2 cho Khách Hàng','Cánh tay','100','3');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\MauNho\MauNho3.jpg','Mau Nho Tattoo3','Mau Nho Tattoo3 cho Khách Hàng','Cánh tay','100','3');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\MauNho\MauNho4.jpg','Mau Nho Tattoo4','Mau Nho Tattoo4 cho Khách Hàng','Cánh tay','100','3');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\MauNho\MauNho5.jpg','Mau Nho Tattoo5','Mau Nho Tattoo5 cho Khách Hàng','Cánh tay','100','3');

--BieuTuong
INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\BieuTuong\BieuTuong1.jpg','Bieu Tuong Tattoo1','Bieu Tuong Tattoo1 cho Khách Hàng','Vai','100','4');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\BieuTuong\BieuTuong2.jpg','Bieu Tuong Tattoo2','Bieu Tuong Tattoo2 cho Khách Hàng','Lưng','100','4');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\BieuTuong\BieuTuong3.jpg','Bieu Tuong Tattoo3','Bieu Tuong Tattoo3 cho Khách Hàng','Cánh tay','100','4');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\BieuTuong\BieuTuong4.jpg','Bieu Tuong Tattoo4','Bieu Tuong Tattoo4 cho Khách Hàng','Cánh tay','100','4');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\BieuTuong\BieuTuong5.jpg','Bieu Tuong Tattoo5','Bieu Tuong Tattoo5 cho Khách Hàng','Cánh tay','100','4');

--VietNam
INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\VietNam\VietNam1.jpg','Viet Nam Tattoo1','Viet Nam Tattoo1 cho Khách Hàng','Chân','100','5');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\VietNam\VietNam2.jpg','Viet Nam Tattoo2','Viet Nam Tattoo2 cho Khách Hàng','Cánh tay','100','5');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\VietNam\VietNam3.jpg','Viet Nam Tattoo3','Viet Nam Tattoo3 cho Khách Hàng','Cánh tay','100','5');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\VietNam\VietNam4.jpg','Viet Nam Tattoo4','Viet Nam Tattoo4 cho Khách Hàng','Chân','100','5');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\VietNam\VietNam5.jpg','Viet Nam Tattoo5','Viet Nam Tattoo5 cho Khách Hàng','Cánh tay','100','5');

--ChauA
INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\ChauA\ChauA1.jpg','Chau A Tattoo1','Chau A Tattoo1 cho Khách Hàng','Cánh tay','100','6');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\ChauA\ChauA2.jpg','Chau A Tattoo2','Chau A Tattoo2 cho Khách Hàng','Cánh tay','100','6');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\ChauA\ChauA3.jpg','Chau A Tattoo3','Chau A Tattoo3 cho Khách Hàng','Cánh tay','100','6');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\ChauA\ChauA4.jpg','Chau A Tattoo4','Chau A Tattoo4 cho Khách Hàng','Cánh tay','100','6');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\ChauA\ChauA5.jpg','Chau A Tattoo5','Chau A Tattoo5 cho Khách Hàng','Cánh tay','100','6');

--DenTrang
INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\DenTrang\DenTrang1.jpg','Den Trang Tattoo1','Den Trang Tattoo1 cho Khách Hàng','Cánh tay','100','7');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\DenTrang\DenTrang2.jpg','Den Trang Tattoo2','Den Trang Tattoo2 cho Khách Hàng','Cánh tay','100','7');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\DenTrang\DenTrang3.jpg','Den Trang Tattoo3','Den Trang Tattoo3 cho Khách Hàng','Cánh tay','100','7');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\DenTrang\DenTrang.jpg','Den Trang Tattoo4','Den Trang Tattoo4 cho Khách Hàng','Cánh tay','100','7');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\DenTrang\DenTrang.jpg','Den Trang Tattoo5','Den Trang Tattoo5 cho Khách Hàng','Cánh tay','100','7');

--Chu
INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\Chu\Chu1.jpg','Chu Tattoo1','Chu Tattoo1 cho Khách Hàng','Cánh tay','100','8');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\Chu\Chu2.jpg','Chu Tattoo2','Chu Tattoo2 cho Khách Hàng','Cánh tay','100','8');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\Chu\Chu3.jpg','Chu Tattoo3','Chu Tattoo3 cho Khách Hàng','Cánh tay','100','8');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\Chu\Chu4.jpg','Chu Tattoo4','Chu Tattoo4 cho Khách Hàng','Cánh tay','100','8');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\Chu\Chu5.jpg','Chu Tattoo5','Chu Tattoo5 cho Khách Hàng','Cánh tay','100','8');

--MauLon
INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\MauLon\MauLon1.jpg','Mau Lon Tattoo1','Mau Lon Tattoo1 cho Khách Hàng','Lưng','100','9');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\MauLon\MauLon2.jpg','Mau Lon Tattoo2','Mau Lon Tattoo2 cho Khách Hàng','Lưng','100','9');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\MauLon\MauLon3.jpg','Mau Lon Tattoo3','Mau Lon Tattoo3 cho Khách Hàng','Cánh tay','100','9');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\MauLon\MauLon4.jpg','Mau Lon Tattoo4','Mau Lon Tattoo4 cho Khách Hàng','Cánh tay','100','9');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\MauLon\MauLon5.jpg','Mau Lon Tattoo5','Mau Lon Tattoo5 cho Khách Hàng','Cánh tay','100','9');

--Custom
INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\Custom\Custom1.jpg','Custom Tattoo1','Custom Tattoo1 cho Khách Hàng','Cánh tay','100','10');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\Custom\Custom2.jpg','Custom Tattoo2','Custom Tattoo2 cho Khách Hàng','Cánh tay','100','10');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\Custom\Custom3.jpg','Custom Tattoo3','Custom Tattoo3 cho Khách Hàng','Cánh tay','100','10');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\Custom\Custom4.jpg','Custom Tattoo4','Custom Tattoo4 cho Khách Hàng','Cánh tay','100','10');

INSERT INTO tattoo_img([image],[name],[description],[location_recommended],[price],[cate_id])
VALUES ('E:\FPT\Semester5\PRN211\ProjectPRN\TattoDesign\TattoDesign\Images\Tattoo\Custom\Custom5.jpg','Custom Tattoo5','Custom Tattoo5 cho Khách Hàng','Cánh tay','100','10');


--Order
INSERT INTO [Order]([price],[date],[user_id])
VALUES ('200','9/10/2023','2');

--Order Details
INSERT INTO Order_details([unit_price],[tattoo_img_id],[status],[sub_total],[order_id],[date_booking],[staff_id])
VALUES ('100','1','Not Completed','100','1','9/12/2023','1');
INSERT INTO Order_details([unit_price],[tattoo_img_id],[status],[sub_total],[order_id],[date_booking],[staff_id])
VALUES ('100','2','Not Completed','100','1','10/12/2023','2');
















-- Unknown
CREATE TABLE [Booking] (
    staff_id INT identity (1,1) PRIMARY KEY,
    user_id INT,
    [date] DATE
);

CREATE TABLE [Image] (
    id INT identity (1,1) PRIMARY KEY,
    role_name VARCHAR(255)
);

INSERT INTO Booking (user_id, [date]) 
VALUES (3, '2021-11-01'),
       (7, '2021-12-01'),
       (5, '2021-01-13');

INSERT INTO Category_tattoo (cate_name, description)
VALUES ('abc', 'good');

INSERT INTO Image (role_name)
VALUES ('Voquocdoanh');

INSERT INTO Location_tattoo (location)
VALUES ('TPHCM');

INSERT INTO [Order] (image, price, [date], user_id)
VALUES (0x, 5000.00, '2010-10-10', 1);
