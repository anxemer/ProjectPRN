-- Create tables
USE master
DROP DATABASE tattooshop;
-- Bat dau tu day nha
CREATE DATABASE tattooshop;

USE tattooshop;

CREATE TABLE [User] (
    useriId INT identity (1,1) PRIMARY KEY,
    username VARCHAR(255) NOT NULL,
    password varchar(64) NOT NULL,
    email VARCHAR(255),
    address NVARCHAR(255),
    phonenumber VARCHAR(255),
    roleId INT 
);


CREATE TABLE [role] (
	id INT identity (1,1) PRIMARY KEY,
	roleName VARCHAR(255) NOT NULL
)


CREATE TABLE artist (
    staffId INT identity (1,1) PRIMARY KEY,
    namestaff nvarchar(255),
    information NVARCHAR(1000),
    experience NVARCHAR(255),
    image NVARCHAR(255)
);


CREATE TABLE [Order] (
    id INT identity (1,1) PRIMARY KEY,
    price DECIMAL(10, 2) NOT NULL,
    [date] DATE,
    [useriId] INT
);


CREATE TABLE [Category_tattoo] (
    id INT identity (1,1) PRIMARY KEY,
    cateName NVARCHAR(255),
);



CREATE TABLE [tattoo_img]  (
    id INT identity (1,1) PRIMARY KEY,
    image NVARCHAR(255),
    name NVARCHAR(255),
    description NVARCHAR(255),
    price DECIMAL(10, 2) NOT NULL,
    cateId INT,
);
CREATE TABLE Cart (
    CartId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    DateCreated DATETIME NOT NULL,
    FOREIGN KEY (UserId) REFERENCES [User](useriId)
);
CREATE TABLE CartItem (
    CartItemId INT IDENTITY(1,1) PRIMARY KEY,
    CartId INT NOT NULL,
    tattooId INT NOT NULL,
    Quantity INT NOT NULL,
    FOREIGN KEY (CartId) REFERENCES Cart(CartId),
    FOREIGN KEY (tattooId) REFERENCES tattoo_img(id)
);
CREATE TABLE [Order] (
    OrderId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    OrderDate DATETIME NOT NULL,
    TotalAmount DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (UserId) REFERENCES [User](useriId)
);

CREATE TABLE OrderDetail (
    OrderDetailId INT IDENTITY(1,1) PRIMARY KEY,
    OrderId INT NOT NULL,
    tattooId INT NOT NULL,
    Quantity INT NOT NULL,
    Price DECIMAL(18, 2) NOT NULL,
    FOREIGN KEY (OrderId) REFERENCES [Order](OrderId),
    FOREIGN KEY (tattooId) REFERENCES tattoo_img(id)
);








ALTER TABLE [User]
ADD CONSTRAINT FK_User_Role
FOREIGN KEY (roleId) REFERENCES [role](id);


ALTER TABLE [tattoo_img]
ADD CONSTRAINT FK_tattooImg_tattooCategory
FOREIGN KEY (cateId) REFERENCES [category_tattoo](id);

ALTER TABLE [Order_details]
ADD CONSTRAINT FK_orderDetails_order
FOREIGN KEY (orderId) REFERENCES [order](id);

ALTER TABLE [Order_details]
ADD CONSTRAINT FK_orderDetails_tattooImg
FOREIGN KEY (tattooimgId) REFERENCES [tattoo_img](id);

ALTER TABLE [Order_details]
ADD CONSTRAINT FK_orderDetails_staff
FOREIGN KEY (staffId) REFERENCES artist(staffId);


-- Insert data
--Role
INSERT INTO [role]([roleName])
VALUES ('Admin');

INSERT INTO [role]([roleName])
VALUES ('Customer');

INSERT INTO [role]([roleName])
VALUES ('Staff');


--User
INSERT INTO [User]([username],[password],[email],[address],[phonenumber],[roleId])
VALUES ('anxemer',1,'anxemer@gmail.com','Q9','0123456781','1');



INSERT INTO [User]([username],[password],[email],[address],[phonenumber],[roleId])
VALUES ('long',2,'QuocDoanh@gmail.com','Thu Duc','0123456783','2');

INSERT INTO [User]([username],[password],[email],[address],[phonenumber],[roleId])
VALUES ('minhchan',3,'minhchan@gmail.com','Q9','0123456784','3');


--Staff
INSERT INTO artist(namestaff,information,[experience],[image])
VALUES (N'Khương Duy - AIDEN',N'Giải nhất - 1st place Fantasy - Realism Color tại Vietnam Tattoo Convention 2017 ✦ Giải nhất - 1st place Neo - Traditional Color tại Vietnam Tattoo Convention 2017 ✦ Giải nhì - 2nd place Best of the day tại Taiwan Tattoo Convention 2017 ✦ Giải nhì - 2nd place Best Color Big Tattoo tại Taiwan Tattoo Convention 2017 ✦ Giám khảo Vietnam Tattoo Convention 2020 ✦ Giám khảo Saigon Tattoo Expo 2022','20 years','D:\ProjectPRN\Images\Staff\khuongduy.jpg');
INSERT INTO artist(namestaff,information,[experience],[image])
VALUES (N'Bột - POW',N'Nếu bạn là người yêu thích sự nhẹ nhàng tinh tế và cảm giác cực kỳ mềm mại trên da. Bột chính là nghệ sĩ dành cho bạn. Chàng trai nhẹ nhàng nhất Silver Ant với sở trường đi nét cực mảnh cũng như xăm hình màu cực nhỏ đang là món hàng hot được các chị em săn đón bởi tuyệt chiêu xăm hình không đau của mình. Nhẹ nhàng như mây, soft boy của Silver Ant luôn luôn dịu dàng với tất cả mọi người, tất cả mọi sự vật sự việc xung quanh. Và đương nhiên, với khách hàng cũng không phải là ngoại lệ, thậm chí sự dịu dàng đấy còn được nâng lên một tầm mới, không chỉ dịu dàng trong đường kim, mà còn là dịu dàng trong lắng nghe, trong thấu hiểu, trong tiếp thu ý tưởng của khách hàng. Nếu cuộc sống này đối xử quá khắc nghiệt với bạn, vậy thì hãy để Bột chữa lành nó với sự dịu dàng của anh ấy. Bột yêu tất cả mọi người.','5 years','D:\ProjectPRN\Images\Staff\bot.jpg');
INSERT INTO artist(namestaff,information,[experience],[image])
VALUES (N'Uyên - Minnie',N'✦ Giải nhì - 2nd place Best of the day Black & Grey (đen trắng trong ngày) tại Saigon Tattoo Expo 2022','6 years','D:\ProjectPRN\Images\Staff\uyen.jpg');
INSERT INTO artist(namestaff,information,[experience],[image])
VALUES (N'Yến - Jena',N'Một hoạ sĩ trẻ tài năng với thiết kế cá nhân hoá là lợi thế. Đi cùng với tư duy sáng tạo hình ảnh vô cùng ấn tượng, kết hợp với kỹ năng vẽ cũng như xăm tả thực với với độ chi tiết cực cao (khó nhất, chi tiết nhất trong các thể loại). Yến/Jena có thể vẽ ra gần như là mọi thứ bạn đang nghĩ trong đầu (hoặc mới chỉ có ý tưởng) một cách cụ thể và chính xác nhất. Nếu bạn muốn hình xăm hoặc nhân vật của mình độc đến mức không thể tìm thấy ở bất cứ chỗ nào khác, hãy để Jena giúp vẽ lại tâm trí bạn, cô ấy không cần copy ở đâu hết cả','30 years','D:\ProjectPRN\Images\Staff\yen.png');
INSERT INTO artist(namestaff,information,[experience],[image])
VALUES (N'Hoàng Dương - Mike',N'Idol 300k followers trên Tiktok justmike1205 - người ta cứ tưởng rằng chuyên môn chính của Mike là chỉ có tấu hài. Sai lầm rồi, bên cạnh việc là một nhà biên kịch, đạo diễn, diễn viên, nhà sáng tạo nội dung đại tài, anh chàng này xăm cũng rất đỉnh và vẫn đang trên đà phát triển cực mạnh, sở trường của anh ta là tả thực, xăm cả màu cả đen trắng đều uy tín','7 years','D:\ProjectPRN\Images\Staff\duong.jpg');

--Tattoo Category
INSERT INTO Category_tattoo([cateName])
VALUES (N'Minh Họa');

INSERT INTO Category_tattoo([cateName])
VALUES (N'Đồ Họa');

INSERT INTO Category_tattoo([cateName])
VALUES (N'Màu Nhỏ');

INSERT INTO Category_tattoo([cateName])
VALUES (N'Biểu Tượng');

INSERT INTO Category_tattoo([cateName])
VALUES (N'Việt Nam');

INSERT INTO Category_tattoo([cateName])
VALUES (N'Châu Á');

INSERT INTO Category_tattoo([cateName])
VALUES (N'Đen Trắng');

INSERT INTO Category_tattoo([cateName])
VALUES (N'Chữ');

INSERT INTO Category_tattoo([cateName])
VALUES (N'Samurai');

INSERT INTO Category_tattoo([cateName])
VALUES (N'Custom');


--Tattoo img
--MinhHoa
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\TattoDesign\TattooManageApp\Images\Tattoo\MinhHoa\MinhHoa1.jpg',N'girl nón lá',N'hình cô gái với chiếc nón là Việt Nam','200','1');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MinhHoa\MinhHoa2.jpg','pagoda',N'Hình ảnh ngồi chùa giữa cánh đồng','300','1');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MinhHoa\MinhHoa3.jpg',N'cafe ghế nhựa',N'Hình ảnh chiếc ghế đá cùng với ly cafe đặc trưng của cafe vỉa hè Việt Nam','300','1');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MinhHoa\MinhHoa4.jpg',N'Ly nước',N'Hình ảnh ly nước chưa đựng cả 1 đại dương','350','1');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MinhHoa\MinhHoa5.jpg',N'Friends',N'Hình ảnh về những người bạn bè','400','1');

--DoHoa
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\DoHoa\DoHoa1.jpg',N'Cây đàn',N'Hình ảnh cây đàn kèm theo những họa tiết nghệ thuật','500','2');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\DoHoa\DoHoa2.jpg',N'Thần hy lạp',N'Hình ảnh 1 nữ thần hi lạp nào đó','250','2');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\DoHoa\DoHoa3.jpg',N'Cung hoàng đạo',N'Cung bọ cạp trong 12 cung hoàng đạo kèm theo những hình ảnh vũ trụ','550','2');



INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\DoHoa\DoHoa5.jpg',N'Cây vũ trụ',N'Hinh ảnh gì đó','500','2');

--MauNho
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauNho\MauNho1.jpg',N'Đầu lân',N'Hình ảnh đầu được lên màu một cách sặc sỡ','400','3');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauNho\MauNho2.jpg',N'Right hand',N'cánh tay trên cánh tay','500','3');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauNho\MauNho3.jpg','Dragon',N'mẫu xăm rồng xanh mắt vàng','200','3');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauNho\MauNho4.jpg',N'bát mì',N'Hình xăm bát mì siêu ngon','240','3');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauNho\MauNho5.jpg',N'Demon',N'Hình xăm mặt nạ quỷ của Nhật Bản thể hiện sự hung dữ','420','3');

--BieuTuong
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\BieuTuong\BieuTuong1.jpg',N'Cung hoàng đạo',N'Hình xăm cung hoàng đạo virgo','300','4');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\BieuTuong\BieuTuong2.jpg',N'Bông sen',N'Hình xăm biểu tượng bông sen','200','4');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\BieuTuong\BieuTuong3.jpg',N'Nốt nhạc',N'Hình xăm biểu tượng nốt nhạc nhỏ xênh','500','4');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\BieuTuong\BieuTuong4.jpg',N'Biểu Tượng gì đó',N'Bieu Tuong Tattoo4 cho Khách Hàng','100','4');


--VietNam
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\VietNam\VietNam1.jpg',N'Áo dài',N'Hình xăm cô gái với tà áo dài Việt Nam','600','5');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\VietNam\VietNam2.jpg',N'Áo dài 2',N'Hình xăm cô gái với chiếc áo dài và gánh 2 bông sen','400','5');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\VietNam\VietNam3.jpg',N'Nông dân',N'Hình xăm người nông dân Việt Nam','200','5');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\VietNam\VietNam4.jpg',N'Phụ nữ việt Nam',N'Hình xăm người phụ nữ gánh buôn','300','5');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\VietNam\VietNam5.jpg',N'Việt Nam',N'Hình xăm Về Việt Nam','900','5');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\VietNam\VietNam6.jpg',N'Việt Nam',N'Hình xăm Về Việt Nam','1050','5');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\VietNam\VietNam7.jpg',N'Việt Nam',N'Hình xăm Về Việt Nam','2400','5');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\VietNam\VietNam8.jpg',N'Việt Nam',N'Hình xăm Về Việt Nam','5600','5');


--ChauA
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\ChauA\ChauA1.jpg',N'Hổ Châu á',N'Hình xăm hình ảnh chú hổ tượng trưng của châu Á','600','6');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\ChauA\ChauA2.jpg',N'Chau A ',N'Họa tiết Châu Á','100','6');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\ChauA\ChauA3.jpg',N'Cá chép',N'Hình xăm cá chép hóa rồng','700','6');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\ChauA\ChauA4.jpg',N'Cò và Rùa',N'Hình xăm con cò cưỡi trên rùa','6500','6');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\ChauA\ChauA5.jpg',N'asian',N'Hình xăm về Châu Á','6800','6');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\ChauA\ChauA6.jpg',N'asian',N'Hình xăm về Châu Á','1800','6');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\ChauA\ChauA7.jpg',N'asian',N'Hình xăm về Châu Á','2600','6');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\ChauA\ChauA8.jpg',N'asian',N'Hình xăm về Châu Á','5400','6');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\ChauA\ChauA9.jpg',N'asian',N'Hình xăm về Châu Á','900','6');
--DenTrang
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\DenTrang\DenTrang1.jpg','Den Trang Tattoo1',N'Den Trang Tattoo1 cho Khách Hàng','100','7');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\DenTrang\DenTrang2.jpg','Den Trang Tattoo2',N'Den Trang Tattoo2 cho Khách Hàng','100','7');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\DenTrang\DenTrang3.jpg','Den Trang Tattoo3',N'Den Trang Tattoo3 cho Khách Hàng','100','7');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\DenTrang\DenTrang4.jpg','Den Trang Tattoo4',N'Den Trang Tattoo4 cho Khách Hàng','100','7');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\DenTrang\DenTrang5.jpg','Den Trang Tattoo5',N'Den Trang Tattoo5 cho Khách Hàng','100','7');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\DenTrang\DenTrang6.jpg','Den Trang Tattoo5',N'Den Trang Tattoo5 cho Khách Hàng','100','7');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\DenTrang\DenTrang7.jpg','Den Trang Tattoo5',N'Den Trang Tattoo5 cho Khách Hàng','100','7');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\DenTrang\DenTrang8.jpg','Den Trang Tattoo5',N'Den Trang Tattoo5 cho Khách Hàng','100','7');

--Chu
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\Chu\Chu1.jpg','Chu Tattoo1',N'Chu Tattoo1 cho Khách Hàng','100','8');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\Chu\Chu2.jpg','Chu Tattoo2',N'Chu Tattoo2 cho Khách Hàng','100','8');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\Chu\Chu3.jpg','Chu Tattoo3',N'Chu Tattoo3 cho Khách Hàng','100','8');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\Chu\Chu4.jpg','Chu Tattoo4',N'Chu Tattoo4 cho Khách Hàng','100','8');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\Chu\Chu5.jpg','Chu Tattoo5',N'Chu Tattoo5 cho Khách Hàng','100','8');

----MauLon
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauLon\samurai1.jpg','samurai','Hình xăm Samurai','600','9');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauLon\samurai1.jpg','samurai','Hình xăm Samurai','600','9');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauLon\samurai1.jpg','samurai','Hình xăm Samurai','600','9');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauLon\samurai2.jpg','samurai','Hình xăm Samurai','600','9');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauLon\samurai3.jpg','samurai','Hình xăm Samurai','600','9');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauLon\samurai4.jpg','samurai','Hình xăm Samurai','600','9');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauLon\samurai5.jpg','samurai','Hình xăm Samurai','600','9');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauLon\samurai6.jpg','samurai','Hình xăm Samurai','600','9');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauLon\samurai7.jpg','samurai','Hình xăm Samurai','600','9');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauLon\samurai8.jpg','samurai','Hình xăm Samurai','600','9');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauLon\samurai9.jpg','samurai','Hình xăm Samurai','600','9');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\MauLon\samurai10.jpg','samurai','Hình xăm Samurai','600','9');

--Custom
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\Custom\Custom1.jpg',N'Phi hành gia',N'Hình xăm phi hành gia phưu lưu trên vũ trụ','800','10');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\Custom\Custom2.jpg','Mihawk',N'Hình xăm Mihawk 1 thất vũ hải trong anime OnePiece','700','10');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\Custom\Custom3.jpg','Kon',N'Hình xăm Kon trong anime ChainSaw Man','500','10');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\Custom\Custom4.jpg','Sukuna',N'Hình xăm Sukuna trong anime Jujustsu kaisen, một nguyền hồn hơn 1000 tuổi','700','10');

INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\Custom\Custom5.jpg','Custome',N'Hình xăm Anime','600','10');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\Custom\Custom6.jpg','Custome',N'Hình xăm Anime','600','10');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\Custom\Custom7.jpg','Custome',N'Hình xăm Anime','600','10');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\Custom\Custom8.jpg','Custome',N'Hình xăm Anime','600','10');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\Custom\Custom9.jpg','Custome',N'Hình xăm Anime','600','10');
INSERT INTO tattoo_img([image],[name],[description],[price],[cateId])
VALUES ('D:\ProjectPRN\Images\Tattoo\Custom\Custom10.jpg','Custome',N'Hình xăm Anime','600','10');


















-- Unknown
CREATE TABLE [Booking] (
    staffId INT identity (1,1) PRIMARY KEY,
    useriId INT,
    [date] DATE
);




