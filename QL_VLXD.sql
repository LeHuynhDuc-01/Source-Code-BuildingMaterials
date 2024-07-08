USE master
----------------------------------------------------------Tạo database QL_VLXD----------------------------------------------------------
CREATE DATABASE QL_VLXD ON PRIMARY
(
    NAME = QL_VLXD_Primary,
    FILENAME = 'D:\HK5\TH_HQTCSDL\demo-code-phan-mem-hequantri\demo-code-phan-mem-hequantri\database\QL_VLXD_PRIMARY.mdf',
    SIZE = 50MB, -- Kích thước khởi tạo lớn hơn
    MAXSIZE = 100MB, -- Kích thước cao nhất lớn hơn
    FILEGROWTH = 20% -- Tỷ lệ tăng lớn hơn
)
LOG ON
(
    NAME = QL_VLXD_Log,
    FILENAME = 'D:\HK5\TH_HQTCSDL\demo-code-phan-mem-hequantri\demo-code-phan-mem-hequantri\database\L_VLXD_Log.ldf',
    SIZE = 10MB, -- Kích thước khởi tạo lớn hơn
    MAXSIZE = 50MB, -- Kích thước cao nhất lớn hơn
    FILEGROWTH = 30% -- Tỷ lệ tăng lớn hơn
)
GO

USE QL_VLXD
GO
----------------------------------------------------------Tạo bảng Khách Hàng----------------------------------------------------------
CREATE TABLE KHACHHANG
(
	MAKH VARCHAR(10) NOT NULL,
    TENKH NVARCHAR(50),
    DIACHI NVARCHAR(100),
    SDT_KH VARCHAR(15),
    EMAIL_KH NVARCHAR(50)
)
GO
----------------------------------------------------------Tạo bảng Nhân Viên----------------------------------------------------------
CREATE TABLE NHANVIEN
(
	MANV VARCHAR(10) NOT NULL,
	TENNV NVARCHAR(50),
	GIOITINH NVARCHAR(5),
	NGAYSINH DATE,
	DIACHI_NV NVARCHAR(50),
	SDT_NV VARCHAR(15),
	EMAIL_NV NVARCHAR(50),
	HINHANH IMAGE
)
GO
----------------------------------------------------------Tạo bảng Loại Vật Liệu----------------------------------------------------------
CREATE TABLE LOAIVATLIEU
(
MALOAI VARCHAR(10) NOT NULL,
TENLOAI NVARCHAR(50),
MOTA NVARCHAR(100)
)
GO
----------------------------------------------------------Tạo bảng Nhà Cung Cấp----------------------------------------------------------
CREATE TABLE NHACUNGCAP
(
	MANCC VARCHAR(10) NOT NULL,
	TENNCC NVARCHAR(50),
	DIACHI_NCC NVARCHAR(100),
	SDT_NCC VARCHAR(15),
	EMAIL_NCC NVARCHAR(50) UNIQUE
)
GO
----------------------------------------------------------Tạo bảng Vật Liệu----------------------------------------------------------
CREATE TABLE VATLIEU
(
	MAVL VARCHAR(10) NOT NULL,
	MALOAI VARCHAR(10) NOT NULL,
	TENVL NVARCHAR(50),
	HINHANH IMAGE,
	MOTA NVARCHAR(100),
	DONVITINH NVARCHAR(10),
	GIA DECIMAL(18,0),
	NGAYSX DATE,
	HANSD DATE,
	XUATXU NVARCHAR(50),
	SOLUONGCON INT
)
GO
----------------------------------------------------------Tạo bảng Phiếu Nhập Hàng----------------------------------------------------------
CREATE TABLE PHIEUNHAPHANG
(
	MAPN VARCHAR(10) NOT NULL,
	MANCC VARCHAR(10) NOT NULL,
	MANV VARCHAR(10) NOT NULL,
	NGAYNHAP DATE,
	TONGNHAP MONEY
);
GO
----------------------------------------------------------Tạo bảng Chi tiết Phiếu Nhập Hàng----------------------------------------------------------
CREATE TABLE CHITIET_PHIEUNHAPHANG
(
	MAPN VARCHAR(10) NOT NULL,
	MAVL VARCHAR(10) NOT NULL,
	GIANHAP MONEY, 
	SOLUONGNHAP INT,
);
GO
----------------------------------------------------------Tạo bảng Phiếu Thanh Toán----------------------------------------------------------
CREATE TABLE PHIEUTHANHTOAN
(
	MADH VARCHAR(10) NOT NULL,
	MAKH VARCHAR(10) NOT NULL,
	MANV VARCHAR(10) NOT NULL,
	NGAYDAT DATE,
	TRANGTHAI NVARCHAR(50),
	TONGHOADON DECIMAL(18, 0)
	
);
GO
----------------------------------------------------------Tạo bảng Chi tiết Phiếu Thanh Toán----------------------------------------------------------
CREATE TABLE CHITIET_PHIEUTHANHTOAN
(
	MADH VARCHAR(10) NOT NULL,
	MAVL VARCHAR(10) NOT NULL,
	GIA DECIMAL(18, 0),
	SOLUONGBAN INT
)
GO

----------------------------------------------------------Tạo bảng Người Dùng----------------------------------------------------------
CREATE TABLE NGUOIDUNG
(
	USERNAME VARCHAR(20) NOT NULL,
	PASSWORD NVARCHAR(50),
	LOAI INT, --Phân loại tài khoản quản trị
	MANV VARCHAR(10)
)
GO
----------------------------------------------------------Ràng buộc khóa chính, khóa ngoại cho bảng----------------------------------------------------------
----------------------------------------------------------Ràng buộc khóa chính----------------------------------------------------------
ALTER TABLE VATLIEU
ADD CONSTRAINT PK_VL PRIMARY KEY (MAVL)
GO

ALTER TABLE NHACUNGCAP
ADD CONSTRAINT PK_NHACC PRIMARY KEY(MANCC)
GO

ALTER TABLE PHIEUNHAPHANG
ADD CONSTRAINT PK_MAPN PRIMARY KEY (MAPN)
GO

ALTER TABLE CHITIET_PHIEUNHAPHANG
ADD CONSTRAINT PK_CTN PRIMARY KEY (MAPN, MAVL)
GO

ALTER TABLE PHIEUTHANHTOAN
ADD CONSTRAINT PK_PTT PRIMARY KEY (MADH)
GO

ALTER TABLE CHITIET_PHIEUTHANHTOAN
ADD CONSTRAINT PK_CTX PRIMARY KEY (MADH,MAVL)
GO

ALTER TABLE KHACHHANG
ADD CONSTRAINT PK_MAKH PRIMARY KEY (MAKH)
GO

ALTER TABLE NHANVIEN
ADD CONSTRAINT PK_NV PRIMARY KEY (MANV)
GO

ALTER TABLE LOAIVATLIEU
ADD CONSTRAINT PK_LVL PRIMARY KEY (MALOAI)
GO

ALTER TABLE NGUOIDUNG
ADD CONSTRAINT PK_ND PRIMARY KEY (USERNAME)
GO
----------------------------------------------------------Ràng buộc khóa ngoại----------------------------------------------------------
ALTER TABLE VATLIEU
ADD CONSTRAINT FK_VL_MALOAI FOREIGN KEY(MALOAI) REFERENCES LOAIVATLIEU(MALOAI)
GO

ALTER TABLE PHIEUNHAPHANG
ADD CONSTRAINT FK_NHAP_MANCC FOREIGN KEY(MANCC) REFERENCES NHACUNGCAP(MANCC),
CONSTRAINT FK_NHAP_MANV FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
GO

ALTER TABLE CHITIET_PHIEUNHAPHANG
ADD CONSTRAINT FK_MAPN_CTN FOREIGN KEY (MAPN) REFERENCES PHIEUNHAPHANG(MAPN),
CONSTRAINT FK_MAVL_CTN FOREIGN KEY (MAVL) REFERENCES VATLIEU(MAVL)
GO

ALTER TABLE PHIEUTHANHTOAN
ADD CONSTRAINT FK_MAKH FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
CONSTRAINT FK_NV_NHAP FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
GO

ALTER TABLE CHITIET_PHIEUTHANHTOAN
ADD CONSTRAINT FK_MADH_CTX FOREIGN KEY (MADH) REFERENCES PHIEUTHANHTOAN(MADH),
CONSTRAINT FK_MAVL_CTX FOREIGN KEY (MAVL) REFERENCES VATLIEU(MAVL)
GO

ALTER TABLE NGUOIDUNG
ADD CONSTRAINT  FK_ND_NV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV)
GO
----------------------------------------------------------Ràng buộc default----------------------------------------------------------
ALTER TABLE NHANVIEN ADD CONSTRAINT UNI_SDT_NV UNIQUE (SDT_NV)
ALTER TABLE NHANVIEN ADD CONSTRAINT UNI_EMAIL_NV UNIQUE (EMAIL_NV)
GO
ALTER TABLE KHACHHANG
ADD CONSTRAINT DF_DIACHI DEFAULT 'CHƯA XÁC ĐỊNH' FOR DIACHI;
GO

ALTER TABLE VATLIEU
ADD CONSTRAINT CHK_GIAVL CHECK(GIA>0),
CONSTRAINT CHK_SOLUONGCON CHECK (SOLUONGCON >= 0)
GO

ALTER TABLE CHITIET_PHIEUNHAPHANG
ADD CONSTRAINT CHK_GIANHAP CHECK (GIANHAP > 0), 
CONSTRAINT CHK_SOLUONGNHAP CHECK (SOLUONGNHAP > 0)
GO

ALTER TABLE PHIEUTHANHTOAN
ADD CONSTRAINT CHK_TRANGTHAI CHECK (TRANGTHAI IN (N'Đang xử lý', N'Đã giao')) -- Chỉ cho phép hai trạng thái 'Đã thanh toán' hoặc 'Chưa thanh toán' --
GO
ALTER TABLE CHITIET_PHIEUTHANHTOAN
ADD CONSTRAINT SOLUONGBAN CHECK (SOLUONGBAN > 0)

ALTER TABLE NGUOIDUNG
ADD CONSTRAINT CK_LOAI CHECK (LOAI IN (0,1));

ALTER TABLE NGUOIDUNG
ADD CONSTRAINT DF_LOAI DEFAULT 1 FOR LOAI;

----------------------------------------------------------Nhập liệu cho các bảng----------------------------------------------------------
----------------------------------------------------------Loại Vật Liệu----------------------------------------------------------
INSERT INTO LOAIVATLIEU (MALOAI, TENLOAI, MOTA)
VALUES 
    ('LVL01', N'Cát xây dựng', N'Cát sạch, phù hợp cho công việc xây dựng cơ bản.'),
    ('LVL02', N'Đá xây dựng', N'Thường được sử dụng cho việc xây dựng cấu trúc bền vững. '),
    ('LVL03', N'Sỏi xây dựng', N'Phù hợp cho việc làm móng và cơ sở hạ tầng. '),
    ('LVL04', N'Xi măng', N'Được sử dụng trong xây dựng công trình và cấu trúc. '),
    ('LVL05', N'Nhựa xây dựng ', N'Sử dụng cho các ống dẫn nước và vật liệu chống nước. '),
    ('LVL06', N'Thạch cao ', N'Sử dụng để tạo kết cấu tường, trần, trang trí nội thất, và các phụ kiện.'),
    ('LVL07', N'Gạch xây dựng ', N'Sử dụng cho việc xây tường, lát sàn, và trang trí nội thất. '),
    ('LVL08', N'Ngói xây dựng ', N'Sử dụng làm vật liệu lợp mái. '),
    ('LVL09', N'Sắt xây dựng ', N'Dùng cho kết cấu sườn, cột, dầm, và nhiều công trình xây dựng khác.'),
    ('LVL10', N'Thép xây dựng ', N'Sử dụng cho kết cấu sườn và cột. '),
    ('LVL11', N'Nhôm xây dựng ', N'Sử dụng trong xây dựng và trang trí nhờ vào tính nhẹ và chống ăn mòn. '),
    ('LVL12', N'Sơn xây dựng ', N'Bền màu và chống thấm. '),
    ('LVL13', N'Vật liệu điện tử ', N'Sử dụng trong công nghệ và sản xuất các linh kiện điện tử. '),
    ('LVL14', N'Vật liệu cách âm ', N'Giúp giảm tiếng ồn từ môi trường bên ngoài. '),
    ('LVL15', N'Vật liệu chống cháy ', N'Chịu nhiệt và không cháy, thích hợp cho khu vực có nguy cơ cháy cao. '),
    ('LVL16', N'Vật liệu chống thấm ', N'Có khả năng chống thấm nước, phù hợp cho công trình ở vùng ẩm. '),
    ('LVL17', N'Vật liệu trang trí ngoại thất', N'Vật liệu chống thời tiết, thích hợp cho trang trí ngoại thất.'),
    ('LVL18', N'Vật liệu cách nhiệt ', N'Sử dụng để giữ nhiệt độ, cách âm trong xây dựng. '),
    ('LVL19', N'Vật liệu trang trí nội thất', N'Thẩm mỹ, dùng để trang trí không gian nội thất. '),
    ('LVL20', N'Gỗ xây dựng ', N'Thích hợp cho việc làm cửa và nội thất gỗ. '),
	('LVL21', N'Máy móc xây dựng', N'Máy móc chuyên dụng cho công việc xây dựng và đào bới.'),
    ('LVL22', N'Thiết bị vệ sinh ', N'Dùng trong ngành xây dựng để trang bị cho phòng tắm và nhà vệ sinh. '),
    ('LVL23', N'Thiết bị phòng tắm ', N'Đồ dùng và trang trí cho phòng tắm. '),
    ('LVL24', N'Vật liệu xây dựng thông minh', N'Vật liệu tích hợp công nghệ, có khả năng tương tác và kiểm soát.');
----------------------------------------------------------Vật Liệu----------------------------------------------------------
SET DATEFORMAT DMY; 
INSERT INTO VATLIEU(MAVL,MALOAI,TENVL,MOTA,DONVITINH,GIA,NGAYSX,HANSD,XUATXU,SOLUONGCON) --Bảng VATLIEU
VALUES('VL01','LVL01',N'Cát bê tông',N'Sử dụng cùng với cốt liệu tạo thành cát bê tông',N'm3',336363.00 ,'10-01-2023',null,N'Nha Trang',200),
	('VL02','LVL07',N'Gạch không trát 2 lỗ',N'',N'Viên',2900.00 ,'10-11-2023',null,N'Long An',10300),
	('VL03','LVL08',N'Ngói sóng',N'Ngói prime hai sóng tráng men',N'Viên',14800.00 ,'25-09-2023',null,N'Long An',5000),
	('VL04','LVL08',N'Ngói hài cổ',N'chịu lực, chịu nhiệt, chống thấm, bền màu.',N'Viên',8000.00 ,'15-08-2023',null,N'Bình Chánh',6000),
	('VL05','LVL06',N'Trần thạch cao tấm thả',N'Giải pháp toàn diện về trần cho các công trình xây dựng',N'm2',135000.00 ,'23-05-2023','23-05-2033',N'Bình Dương',100),
	('VL06','LVL02',N'Đá hộc',N'Sử dụng để xây móng nhà',N'm3',202000.00 ,'25-04-2022',NULL,N'Biên Hòa',100),
	('VL07','LVL15',N'Ván tiêu âm chống cháy',N'Bắt lửa chậm, ngăn ngừa sự lây lan đám cháy,..',N'm2',120000.00 ,'12-05-2023',null,N'Bình Dương',70),
	('VL08','LVL16',N'Chống thấm Sika Proof Membrane',N'Chất chống thấm màng lỏng có độ đàn hồi cao.',N'Thùng',660000.00 ,'29-03-2023','30-03-2028',N'Long An',30),
	('VL09','LVL16',N'Chống thấm MasterSeal 540',N'Mịn với độ bám dính cao vào hầu hết mọi bề mặt',N'Thùng',580000.00 ,'25-04-2023','25-04-2030',N'Long An',30),
	('VL10','LVL16',N'Chống thấm Sika Lite',N'Trám kín các mao dẫn bê tông, lỗ hổng gạch ',N'Thùng',500000.00 ,'12-03-2023','12-03-2030',N'Long An',30),
	('VL11','LVL09',N'Thép Việt Nhật',N'Có chứng chỉ chất lượng của nhà máy',N'Cây',85900.00 ,'10-04-2023',null,N'Quảng Ninh',250),
	('VL12','LVL12',N'Sơn Lót Maxilite Ngoài Trời 48C',N'Bền màu, láng mịn',N'Thùng',110000.00,'23-05-2023','23-05-2030',N'TP Hồ Chí Minh',75),
	('VL13','LVL12',N'Sơn Lót Maxilite trong nhà',N'Chống rêu mốc, kiềm hóa tốt',N'Thùng',770000.00 ,'23-05-2023','23-05-2030',N'TP Hồ Chí Minh',50),
	('VL14','LVL02',N'Đá mi sàng',N'Phổ biến để làm gạch block, gạch lót sàn...',N'm3',220000.00 ,'25-04-2022',null,N'Biên Hòa',100),
	('VL15','LVL07',N'Gạch 6 lỗ vuông',N'Khả năng cách âm, cách nhiệt tốt',N'Viên',3500.00 ,'01-05-2023',NULL,N'Bình Chánh',5600),
	('VL16','LVL09',N'Thép Pomina',N'Có chứng chỉ chất lượng của nhà máy',N'Cây',129500.00 ,'25-08-2023',null,N'Quảng Ninh',150),
	('VL17','LVL15',N'Vách kính chống cháy EI 15 phút',N'Khả năng chống cháy, ngăn chặn lửa, ',N'm2',1150000.00 ,'11-04-2023',Null,N'TP Hồ Chí Minh',20),
	('VL18','LVL14',N'Mút cách âm PE',N'Nhẹ, có độ bền cao, không thấm nước/ mỡ,...',N'm2',450000.00,'25-05-2023',null,N'Tây Ninh',32),
	('VL19','LVL01',N'Cát san lấp',N'Sử dụng để san lấp nền móng các công trình',N'm3',230000.00,'10-05-2023','10-05-2023',N'Nha Trang',300),
	('VL20','LVL14',N'Giấy cách âm',N'Nhằm mục đích cách âm tạm thời. ',N'm2',50000.00 ,'10-03-2023','10-03-2025',N'Tây Ninh',40),
	('VL21','LVL14',N'Mút cách âm XPS',N'Cách nhiệt, giúp tiết kiệm điện năng.',N'm2',350000.00 ,'12-06-2023',null,N'Bến tre',45),
	('VL22','LVL04',N'Xi măng Thăng Long',N'PCB 40, XI MĂNG pooc lăng hỗn hợp',N'Bao',74000.00 ,'15-08-2023','15-02-2024',N'TP Hồ Chí Minh',70),
	('VL23','LVL04',N'Xi măng Cotec',N'Chuyên dùng cho các trạm trộn bê tông tươi, có cường độ nén cao. ',N'Bao',78000.00 ,'01-09-2023','01-03-2024',N'Đồng Nai',50),
	('VL24','LVL15',N' Bông thủy tinh chống cháy, cách nhiệt',N'Ngăn nhiệt, dẫn nhiệt kém.12kg/m3 - 1.2m x 30m Dày 50mm',N'm3',750000.00 ,'16-05-2023',null,N'TP Hồ Chí Minh',88),
	('VL25','LVL20',N'Gỗ vân sam',N'Dùng làm tấm ốp sàn, ván ốp tường,...',N'm2',320000.00 ,'21-03-2023',null,N'Lâm Đồng',50),
	('VL26','LVL22',N'Bồn cầu',N'Gạch men, chắc chắn,..',N'Cái',650000.00 ,'14-02-2023',null,N'Long An',23),
	('VL28','LVL23',N'Bồn rửa mặt',N'Nhỏ gọn, tiện lợi',N'Cái',720000.00 ,'25-08-2023',null,N'Long An',30),
	('VL29','LVL20',N'Gỗ phong',N'Cứng và chịu được va đập nên nó thường được sử dụng để làm các lối đi',N'm2',350000.00 ,'12-05-2023',null,N'Lâm Đồng',80),
	('VL30','LVL07',N'Gạch đặc Tuynel',N'Khả năng chịu lực cao & khả năng thấm nước thấp.',N'Viên',980.00 ,'22-06-2023',NULL,N'Tây Ninh',7800),
	('VL31','LVL23',N'Bồn tắm',N'Rộng rãi, dễ sử dụng',N'Cái',1750000.00 ,'12-05-2023',null,N'Long An',5),
	('VL32','LVL04',N'Xi măng Holcim',N'Tiêu chuẩn PCB, dầu hợp quy',N'Bao',89000.00 ,'01-09-2023','01-03-2024',N'Bình Dương',45),
	('VL33','LVL23',N'Vòi hoa sen',N'Sử dụng được tất cả nhu cầu',N'Cái',500000.00 ,'12-05-2023',null,N'Long An',40),
	('VL34','LVL23',N'Vòi nước',N'Sử dụng được tất cả nhu cầu',N'Cái',320000.00 ,'12-06-2023',null,N'Long An',45),	  	  
	('VL35','LVL11',N'Nhôm cây A6061A',N'Chống ăn mòn tốt và độ dẻo dai cao',N'Cây',105000.00 ,'01-01-2023',NULL,N'Bình Phước',260),
	('VL36','LVL11',N'Nhôm tấm',N'Khả năng hàn và chống ăn mòn cao',N'Cây',83000.00 ,'30-06-2023',null,N'Bình Phước',150),
	('VL37','LVL11',N'Nhôm phôi tròn đặc A6061',N'Khả năng tạo hình tốt, có Khả năng gia công cắt gọt',N'Cây',350000.00 ,'04-05-2023',null,N'Bình Phước','200'),
	('VL38','LVL01',N'Cát xây tô',N'Được dùng để xây hoặc trát tường',N'm3',272727.00 ,'01-11-2023',null,N'Nha Trang',100),
	('VL39','LVL21',N'Máy Mài Góc Makita MT M9001B',N'Công dụng mài nhẵn mịn và cắt các loại vật liệu',N'Cái',2300000.00 ,'01-01-2023',null,N'TP Hồ Chí Minh',15),
	('VL40','LVL19',N'Đèn chùm hiện đại - Thả LED 3 Vòng, thân trắng',N'Sử dụng bóng Led 3 chế độ, dễ dàng trong việc lắp đặt',N'Cái',1950000.00 ,'20-02-2023',null,N'TP Hồ Chí Minh',3),
	('VL41','LVL19',N'Kệ trang trí GHF-5957',N'Nhỏ, gọn, dễ lắp đặt',N'Cái',1750000.00 ,'15-08-2023',null,N'Bình Dương',5),
	('VL42','LVL07',N'Gạch không trát 2 lỗ sẫm',N'210x100x60',N'Viên',6200.00 ,'10-07-2023','',N'Tây Ninh',3000),
	('VL43','LVL21',N'Máy xoa nền bê tông DMR-1000',N'Giúp làm phẳng bề mặt bê tông nhanh chóng và hiệu quả',N'Cái',6380000.00 ,'15-05-2022',null,N'TP Hồ Chí Minh',10),
	('VL44','LVL12',N'Sơn Nippon Vatex Trong nhà',N'Trang trí và bảo vệ cho các bề mặt tường nội thất',N'Thùng',480000.00 ,'10-06-2023','10-06-2031',N'Bình Dương',50),
	('VL45','LVL19',N'Bàn trang điểm nhập khẩu VIP06',N'Sang chảnh, đẹp',N'Cái',3100000.00 ,'24-04-2023',null,N'Bình Dương',4),
	('VL46','LVL07',N'Gạch không trát 3 lỗ',N'210x100x60',N'Viên',5600.00 ,'10-07-2023',null,N'Tây Ninh',3500),
	('VL47','LVL04',N'Xi măng Hà Tiên',N'Đổ bê tông móng, sàn, đà hay trộn vữa xây,...',N'Bao',75000.00 ,'15-05-2023','15-05-2033',N'Quảng Trị',300),
	('VL48','LVL21',N'Máy cắt tường FEG EG-118W',N'Chuyên dùng để cắt rãnh tường đi đường dây điện, ống nước hay dây cáp..',N'Cái',2070000.00 ,'20-08-2022',null,N'TP Hồ Chí Minh',10),
	('VL49','LVL21',N'Máy phay gỗ Bosch GOF 130',N'Chìa vặn, Cữ song song, Đầu nối bụi, Bộ mẫu kẹp',N'Cái',2673000.00 ,'01-01-2023',null,N'TP Hồ Chí Minh',10),
	('VL50','LVL04',N'Xi măng Hoàng Thạch',N'Phù hợp với nhiều loại xây dựng như gạch bê tông siêu nhẹ, chưng áp…',N'Bao',60000.00 ,'30-04-2023','30-04-2035',N'Quảng Ninh',400);
----------------------------------------------------------Khách Hàng----------------------------------------------------------
INSERT INTO KHACHHANG --(MAKH, TENKH, DIACHI, SDT_KH, EMAIL_KH)
VALUES('KH01', N'Nguyễn Văn An', N'38 Hoàng Diệu', '0912346455', 'an.nguyen@gmail.com'),
    ('KH02', N'Lê Thị Dung', N'155 Lê Trọng Tấn', '0386012369', 'dung.le@gmail.com'),
    ('KH03', N'Trần Văn Cường', N'22 Bà Triệu', '0934567890', 'cuong.tran@gmail.com'),
    ('KH04', N'Phạm Thị Mai', N'89 Hồ Tùng Mậu', '0865432198', 'mai.pham@gmail.com'),
    ('KH05', N'Hồ Ngọc Bích', N'7 Trần Hưng Đạo', '0978765432', 'bich.ho@gmail.com'),
    ('KH06', N'Vũ Thị Hoa', N'104 Lê Lai', '0987654321', 'hoa.vu@gmail.com'),
    ('KH07', N'Nguyễn Văn Hùng', N'15 Hai Bà Trưng', '0918765432', 'hung.nguyen@gmail.com'),
    ('KH08', N'Trần Thị Lan', N'67 Hàm Long', '0909876543', 'lan.tran@gmail.com'),
    ('KH09', N'Lê Văn Tâm', N'98 Đống Đa', '0965432198', 'tam.le@gmail.com'),
    ('KH10', N'Nguyễn Thị Ngọc', N'33 Hoàng Mai', '0912345678', 'ngoc.nguyen@gmail.com'),
    ('KH11', N'Bùi Văn Long', N'26 Hàng Bài', '0987654321', 'long.bui@gmail.com'),
    ('KH12', N'Đặng Thị Hương', N'40 Cầu Giấy', '0934567890', 'huong.dang@gmail.com'),
    ('KH13', N'Mai Văn Hải', N'72 Nguyễn Du', '0865432198', 'hai.mai@gmail.com'),
    ('KH14', N'Lý Thị Linh', N'51 Phố Huế', '0978765432', 'linh.ly@gmail.com'),
    ('KH15', N'Võ Văn Tú', N'19 Bùi Thị Xuân', '0987654321', 'tu.vo@gmail.com'),
    ('KH16', N'Phan Văn Minh', N'88 Lê Đại Hành', '0918765432', 'minh.phan@gmail.com'),
    ('KH17', N'Đỗ Thị Hà', N'12 Lý Thường Kiệt', '0909876543', 'ha.do@gmail.com'),
    ('KH18', N'Nguyễn Văn Hòa', N'14 Lê Ngọc Hân', '0965432198', 'hoa.nguyen@gmail.com'),
    ('KH19', N'Trương Thị Thu', N'7 Nguyễn Trãi', '0912345678', 'thu.truong@gmail.com'),
    ('KH20', N'Nguyễn Văn Tuấn', N'99 Thái Hà', '0934567890', 'tuan.nguyen@gmail.com'),
    ('KH21', N'Phạm Thị Ngọc', N'8 Lê Văn Lương', '0865432198', 'ngoc.pham@gmail.com'),
    ('KH22', N'Hoàng Văn Hải', N'123 Đê La Thành', '0978765432', 'hai.hoang@gmail.com'),
    ('KH23', N'Lê Thị Hà', N'56 Lương Văn Can', '0987654321', 'ha.le@gmail.com'),
    ('KH24', N'Nguyễn Văn Quang', N'31 Thanh Xuân', '0918765432', 'quang.nguyen@gmail.com'),
    ('KH25', N'Trần Thị Ngân', N'18 Trần Khát Chân', '0909876543', 'ngan.tran@gmail.com'),
    ('KH26', N'Đinh Văn Lợi', N'27 Hồ Xuân Hương', '0965432198', 'loi.dinh@gmail.com'),
    ('KH27', N'Bùi Thị Tâm', N'45 Trung Hòa', '0978765432', 'tam.bui@gmail.com'),
    ('KH28', N'Nguyễn Văn Khánh', N'37 Yên Lãng', '0912345678', 'khanh.nguyen@gmail.com'),
    ('KH29', N'Trần Thị Bảo', N'56 Thái Thịnh', '0934567890', 'bao.tran@gmail.com'),
    ('KH30', N'Vũ Thị Quỳnh', N'22 Lê Thanh Nghị', '0865432198', 'quynh.vu@gmail.com'),
    ('KH31', N'Nguyễn Văn Đạt', N'3 Trần Phú', '0978765432', 'dat.nguyen@gmail.com'),
    ('KH32', N'Đỗ Thị Thuận', N'48 Kim Mã', '0987654321', 'thuan.do@gmail.com'),
    ('KH33', N'Trần Thị Mỹ', N'11 Hai Bà Trưng', '0918765432', 'my.tran@gmail.com'),
    ('KH34', N'Phạm Văn Sơn', N'36 Tây Sơn', '0909876543', 'son.pham@gmail.com'),
    ('KH35', N'Lê Thị Huệ', N'75 Trần Duy Hưng', '0965432198', 'hue.le@gmail.com'),
    ('KH36', N'Nguyễn Thị Hương', N'28 Nguyễn Cơ Thạch', '0978765432', 'huong.nguyen@gmail.com'),
    ('KH37', N'Võ Văn Hậu', N'5 Đặng Thùy Trâm', '0912345678', 'hau.vo@gmail.com'),
    ('KH38', N'Bùi Thị Thảo', N'38 Hoàng Diệu', '0865432198', 'thao.bui@gmail.com'),
    ('KH39', N'Nguyễn Văn Hoàng', N'155 Lê Trọng Tấn', '0978765432', 'hoang.nguyen@gmail.com'),
    ('KH40', N'Trần Thị Yến', N'22 Bà Triệu', '0987654321', 'yen.tran@gmail.com'),
    ('KH41', N'Nguyễn Văn Hùng', N'89 Hồ Tùng Mậu', '0918765432', 'hung.nguyen@gmail.com'),
    ('KH42', N'Đỗ Thị Phương', N'7 Trần Hưng Đạo', '0909876543', 'phuong.do@gmail.com'),
    ('KH43', N'Lê Văn Tiến', N'104 Lê Lai', '0965432198', 'tien.le@gmail.com'),
    ('KH44', N'Trần Thị Lan', N'15 Hai Bà Trưng', '0978765432', 'lan.tran@gmail.com'),
    ('KH45', N'Phạm Văn Hòa', N'67 Hàm Long', '0231231234', 'hoa.pham@gmail.com'),
    ('KH46', N'Vũ Thị Hương', N'98 Đống Đa', '0564564567', 'huong.vu@gmail.com'),
    ('KH47', N'Nguyễn Văn Quốc', N'72 Nguyễn Du', '0897897890', 'quoc.nguyen@gmail.com'),
    ('KH48', N'Nguyễn Thị Nga', N'51 Phố Huế', '0213213210', 'nga.nguyen@gmail.com'),
    ('KH49', N'Trương Văn Hải', N'19 Bùi Thị Xuân', '0546546540', 'hai.truong@gmail.com'),
    ('KH50', N'Nguyễn Thị Hà', N'99 Thái Hà', '0879879870', 'ha.nguyen@gmail.com');
----------------------------------------------------------Nhân Viên----------------------------------------------------------
SET DATEFORMAT DMY;
INSERT INTO NHANVIEN (MANV, TENNV, GIOITINH, NGAYSINH, DIACHI_NV, SDT_NV, EMAIL_NV)
VALUES
    ('NV001', N'Nguyễn Văn An', N'Nam', '1990-01-01', N'5 Hoàng Diệu', '0912346001', 'nguyenan1@gmail.com'),
    ('NV002', N'Lê Thị Dung', N'Nữ', '1995-02-15', N'1556 Lê Trọng Tấn', '0912346002', 'ledung@gmail.com'),
    ('NV003', N'Trần Văn Cường', N'Nam', '1988-05-20', N'38 Quang Trung', '0912346003', 'trancuong3@gmail.com'),
    ('NV004', N'Phạm Thị Mai', N'Nữ', '1992-07-10', N'72 Hàm Long', '0912346004', 'phammai4@gmail.com'),
    ('NV005', N'Hồ Ngọc Bích', N'Nam', '1998-11-30', N'205 Lê Lai', '0912346005', 'hobich5@gmail.com'),
    ('NV006', N'Vũ Thị Hoa', N'Nữ', '1994-03-25', N'96 Trần Hưng Đạo', '0912346006', 'vuhoa6@gmail.com'),
    ('NV007', N'Nguyễn Văn Hùng', N'Nam', '1993-09-12', N'31B Nguyễn Huệ', '0912346007', 'nguyenhung7@gmail.com'),
    ('NV008', N'Trần Thị Lan', N'Nữ', '1997-08-05', N'77B Lê Lợi', '0912346008', 'tranlan8@gmail.com'),
    ('NV009', N'Lê Văn Tâm', N'Nam', '1996-06-18', N'42 Phan Chu Trinh', '0912346009', 'letam9@gmail.com'),
    ('NV010', N'Nguyễn Thị Ngọc', N'Nữ', '1991-04-22', N'18 Cao Thắng', '0912346010', 'nguyenngoc10@gmail.com'),
    ('NV011', N'Nguyễn Văn Hải', N'Nam', '1990-06-15', N'55B Đinh Công Tráng', '0912346011', 'nguyenhai11@gmail.com'),
    ('NV012', N'Lê Thị Hương', N'Nữ', '1995-03-20', N'22B Hoàng Diệu', '0912346012', 'lehuong12@gmail.com'),
    ('NV013', N'Mai Văn Hải', N'Nam', '1988-08-25', N'11 Lê Thánh Tôn', '0912346013', 'maihai13@gmail.com'),
    ('NV014', N'Lý Thị Linh', N'Nữ', '1992-11-10', N'29B Nguyễn Bỉnh Khiêm', '0912346014', 'lytrinh14@gmail.com'),
    ('NV015', N'Võ Văn Tú', N'Nam', '1998-04-30', N'48 Hai Bà Trưng', '0912346015', 'votu15@gmail.com'),
    ('NV016', N'Phan Văn Minh', N'Nữ', '1994-02-25', N'36A Nguyễn Thái Học', '0912346016', 'phanminh16@gmail.com'),
    ('NV017', N'Đỗ Thị Hà', N'Nam', '1993-10-12', N'14B Yersin', '0912346017', 'doha17@gmail.com'),
    ('NV018', N'Nguyễn Văn Hòa', N'Nữ', '1997-09-05', N'61A Phan Đăng Lưu', '0912346018', 'nguyenhoa18@gmail.com'),
    ('NV019', N'Trương Thị Thu', N'Nam', '1996-07-18', N'9B Lý Thường Kiệt', '0912346019', 'truongthu19@gmail.com'),
    ('NV020', N'Nguyễn Văn Tuấn', N'Nữ', '1991-05-22', N'40B Ngô Quyền', '0912346020', 'nguyentuan20@gmail.com'),
    ('NV021', N'Phạm Thị Ngọc', N'Nam', '1990-08-15', N'17 Trương Định', '0912346021', 'phamngoc21@gmail.com'),
    ('NV022', N'Hoàng Văn Hải', N'Nữ', '1995-04-20', N'88C Đồng Khởi', '0912346022', 'hoanghai22@gmail.com'),
    ('NV023', N'Lê Thị Hà', N'Nam', '1988-09-25', N'26B Phạm Ngọc Thạch', '0912346023', 'leha23@gmail.com'),
    ('NV024', N'Nguyễn Văn Quang', N'Nữ', '1992-12-10', N'72 Trần Hưng Đạo', '0912346024', 'nguyenquang24@gmail.com'),
    ('NV025', N'Trần Thị Ngân', N'Nam', '1998-05-30', N'39 Lê Lợi', '0912346025', 'tranngan25@gmail.com'),
    ('NV026', N'Vũ Thị Hà', N'Nữ', '1994-03-25', N'15 Hoàng Diệu', '0912346026', 'vuha26@gmail.com'),
    ('NV027', N'Nguyễn Văn Tâm', N'Nam', '1993-11-12', N'50C Nguyễn Huệ', '0912346027', 'nguyentam27@gmail.com'),
    ('NV028', N'Ngô Thị Mai', N'Nữ', '1997-10-05', N'23B Lê Lai', '0912346028', 'ngomai28@gmail.com'),
    ('NV029', N'Hoàng Văn Anh', N'Nam', '1996-08-18', N'10 Phan Chu Trinh', '0912346029', 'hoanganh29@gmail.com'),
    ('NV030', N'Trần Thị Bích', N'Nữ', '1991-06-22', N'31 Nguyễn Bỉnh Khiêm', '0912346030', 'tranbich30@gmail.com'),
    ('NV031', N'Nguyễn Văn Hải', N'Nam', '1990-11-15', N'41 Hai Bà Trưng', '0912346031', 'nguyenhai31@gmail.com'),
    ('NV032', N'Trần Thị Yến', N'Nữ', '1995-06-20', N'20B Nguyễn Thái Học', '0912346032', 'tranyen32@gmail.com'),
    ('NV033', N'Phạm Văn Cường', N'Nam', '1988-10-25', N'34A Yersin', '0912346033', 'phamcuong33@gmail.com'),
    ('NV034', N'Võ Thị Hương', N'Nữ', '1992-01-10', N'13 Lê Thánh Tôn', '0912346034', 'vohuong34@gmail.com'),
    ('NV035', N'Lê Văn Bình', N'Nam', '1998-06-30', N'35B Nguyễn Bỉnh Khiêm', '0912346035', 'lebinh35@gmail.com'),
    ('NV036', N'Đỗ Thị Ngọc', N'Nữ', '1994-04-25', N'36 Nguyễn Thái Học', '0912346036', 'dongoc36@gmail.com'),
    ('NV037', N'Trần Văn Tú', N'Nam', '1993-12-12', N'37C Phạm Ngọc Thạch', '0912346037', 'trantu37@gmail.com'),
    ('NV038', N'Lê Thị Thu', N'Nữ', '1997-11-05', N'38A Phan Đăng Lưu', '0912346038', 'lethu38@gmail.com'),
    ('NV039', N'Nguyễn Văn Hòa', N'Nam', '1996-09-18', N'39B Lý Thường Kiệt', '0912346039', 'nguyenhoa39@gmail.com'),
    ('NV040', N'Vũ Thị Mai', N'Nữ', '1991-07-22', N'40C Ngô Quyền', '0912346040', 'vumai40@gmail.com'),
    ('NV041', N'Phạm Văn Hải', N'Nam', '1990-12-15', N'41A Trương Định', '0912346041', 'phamhai41@gmail.com'),
    ('NV042', N'Trần Thị Hương', N'Nữ', '1995-07-20', N'42B Đồng Khởi', '0912346042', 'tranhuong42@gmail.com'),
    ('NV043', N'Mai Văn Hải', N'Nam', '1988-11-25', N'43A Phạm Ngọc Thạch', '0912346043', 'maihai43@gmail.com'),
    ('NV044', N'Lý Thị Linh', N'Nữ', '1992-02-10', N'44 Hai Bà Trưng', '0912346044', 'lylinh44@gmail.com'),
    ('NV045', N'Võ Văn Tú', N'Nam', '1998-07-30', N'45B Đồng Khởi', '0912346045', 'votu45@gmail.com'),
    ('NV046', N'Phan Văn Minh', N'Nữ', '1994-05-25', N'46A Lê Thánh Tôn', '0912346046', 'phanminh46@gmail.com'),
    ('NV047', N'Đỗ Thị Hà', N'Nam', '1993-01-12', N'47 Hai Bà Trưng', '0912346047', 'doha47@gmail.com'),
    ('NV048', N'Nguyễn Văn Quang', N'Nữ', '1997-12-05', N'48C Đồng Khởi', '0912346048', 'nguyenquang48@gmail.com'),
    ('NV049', N'Trương Thị Thu', N'Nam', '1996-10-18', N'49 Phan Đăng Lưu', '0912346049', 'truongthu49@gmail.com'),
    ('NV050', N'Nguyễn Văn Tuấn', N'Nữ', '1991-08-22', N'50A Lý Thường Kiệt', '0912346050', 'nguyentuan50@gmail.com'),
	('NV051',N'Lê Huỳnh Đức',N'Nam','01-01-2000',N'61 Bình Long','0468219347','leduc51@gmail.com'),
	('NV052',N'Nguyễn Thị Thu Hiền',N'Nữ','25-05-2000','01 Vườn Lài ',N'0915359864','nguyenhien52@gmail.com'),
	('NV053',N'Nguyễn Thị Hằng',N'Nữ','12-03-2000',N'613 Quang Trung','0385169231','nguyenhang53@gmail.com'),
	('NV054',N'Lưu Văn Hoàng',N'Nam','25-05-2000',N'29 Nguyễn Đỗ Cung','0262761894','luuhoang54@gmail.com'),
	('NV055',N'Cao Minh Trí',N'Nam','14-06-2000',N'80 Nguyễn Qúy Anh','0386219321','caotri55@gmail.com');

----------------------------------------------------------Nhà Cung Cấp----------------------------------------------------------
INSERT INTO NHACUNGCAP (MANCC, TENNCC, DIACHI_NCC, SDT_NCC, EMAIL_NCC)
VALUES
    ('NCC001', N'Công ty Vật liệu Xây dựng Á Châu', N'123 Nguyễn Lương Bằng, Quận 1, TP.HCM', '0123456789', 'info@achauconstruction.com'),
    ('NCC002', N'Công ty Cổ phần Vật liệu Xây dựng Đông Dương', N'456 Lê Hồng Phong, Quận 5, TP.HCM', '0987654321', 'contact@dongduongmaterials.com'),
    ('NCC003', N'Công ty TNHH Vật liệu Xây dựng Bắc Nam', N'789 Nguyễn Văn Linh, Quận 7, TP.HCM', '0123987654', 'sales@bacnamconstruction.com'),
    ('NCC004', N'Công ty Cổ phần Vật liệu Xây dựng Miền Trung', N'101 Trần Hưng Đạo, Đà Nẵng', '0909876543', 'info@mientrungmaterials.com'),
    ('NCC005', N'Công ty TNHH Vật liệu Xây dựng Phương Đông', N'456 Lê Lợi, Hải Phòng', '0912345678', 'phuongdongconstruction@gmail.com'),
    ('NCC006', N'Công ty Cổ phần Xây dựng và Vật liệu Đại Dương', N'789 Lê Duẩn, Hà Nội', '0987123456', 'daiduongconstruction@gmail.com'),
    ('NCC007', N'Công ty TNHH Vật liệu Xây dựng Nam Bộ', N'321 Nguyễn Huệ, Bình Dương', '0918765432', 'nambomaterials@gmail.com'),
	 ('NCC008', N'Công ty TNHH Vật liệu Xây dựng Phát Triển', N'27 Đinh Công Tráng, Quận 3, TP.HCM', '0918765432', 'phattrienconstruction@gmail.com'),
    ('NCC009', N'Công ty Cổ phần Xây dựng và Vật liệu Hoàng Gia', N'89 Nguyễn Thị Minh Khai, Quận 10, TP.HCM', '0909123456', 'hoanggiaconstruction@gmail.com'),
    ('NCC010', N'Công ty TNHH Vật liệu Xây dựng Xuân Thuận', N'456 Lê Văn Lương, Quận 7, TP.HCM', '0918234567', 'xuanthuanmaterials@gmail.com'),
    ('NCC011', N'Công ty Cổ phần Vật liệu Xây dựng Minh Quân', N'12 Lý Thường Kiệt, Quận 1, TP.HCM', '0987456123', 'minhquanconstruction@gmail.com'),
    ('NCC012', N'Công ty TNHH Vật liệu Xây dựng Đại Phúc', N'34 Trần Phú, Hải Phòng', '0912345678', 'daiphucmaterials@gmail.com'),
    ('NCC013', N'Công ty Cổ phần Xây dựng và Vật liệu An Bình', N'56 Nguyễn Đình Chính, Quận Bình Thạnh, TP.HCM', '0909988776', 'anbinhconstruction@gmail.com'),
    ('NCC014', N'Công ty TNHH Vật liệu Xây dựng Thành Đạt', N'78 Hoàng Diệu, Đà Nẵng', '0911122334', 'thanhdatmaterials@gmail.com'),
    ('NCC015', N'Công ty Cổ phần Vật liệu Xây dựng Nam Sơn', N'90 Lê Thị Riêng, Quận Phú Nhuận, TP.HCM', '0909234567', 'namsonconstruction@gmail.com'),
    ('NCC016', N'Công ty TNHH Vật liệu Xây dựng Thăng Long', N'23 Trần Phú, Hà Nội', '0988776655', 'thanglongmaterials@gmail.com'),
    ('NCC017', N'Công ty Cổ phần Vật liệu Xây dựng Kim Phát', N'45 Lê Văn Tám, Quận Bình Thạnh, TP.HCM', '0918345678', 'kimphatconstruction@gmail.com'),
    ('NCC018', N'Công ty TNHH Vật liệu Xây dựng Tân Phú', N'67 Cộng Hòa, Quận Tân Bình, TP.HCM', '0909456789', 'tanphumaterials@gmail.com'),
    ('NCC019', N'Công ty Cổ phần Xây dựng và Vật liệu Hải Long', N'78 Hùng Vương, Quận 1, TP.HCM', '0918567890', 'hailongconstruction@gmail.com'),
    ('NCC020', N'Công ty TNHH Vật liệu Xây dựng Minh Tâm', N'56 Nguyễn Thị Minh Khai, Quận 3, TP.HCM', '0909345678', 'minhtammaterials@gmail.com'),
    ('NCC021', N'Công ty Cổ phần Vật liệu Xây dựng Phúc An', N'34 Hoàng Hoa Thám, Đà Nẵng', '0918234455', 'phucanconstruction@gmail.com'),
    ('NCC022', N'Công ty TNHH Vật liệu Xây dựng Long Phú', N'90 Đinh Công Tráng, Quận 10, TP.HCM', '0919456789', 'longphumaterials@gmail.com'),
    ('NCC023', N'Công ty Cổ phần Xây dựng và Vật liệu Hòa Phát', N'23 Lê Lai, Hải Phòng', '0918567890', 'hoaphatconstruction@gmail.com'),
    ('NCC024', N'Công ty TNHH Vật liệu Xây dựng An Khang', N'45 Nguyễn Văn Cừ, Quận 4, TP.HCM', '0909345678', 'ankhangmaterials@gmail.com'),
    ('NCC025', N'Công ty Cổ phần Xây dựng và Vật liệu Phú Thọ', N'78 Phan Chu Trinh, Quận 5, TP.HCM', '0918234455', 'phuthoconstruction@gmail.com'),
    ('NCC026', N'Công ty TNHH Vật liệu Xây dựng Hòa Bình', N'56 Bạch Đằng, Quận 1, TP.HCM', '0919456789', 'hoabinhmaterials@gmail.com'),
    ('NCC027', N'Công ty Cổ phần Vật liệu Xây dựng Minh Thành', N'34 Lê Thị Hồng, Quận 7, TP.HCM', '0918567890', 'minhthanhconstruction@gmail.com'),
    ('NCC028', N'Công ty TNHH Vật liệu Xây dựng Thanh Hải', N'90 Trần Hưng Đạo, Hà Nội', '0909345678', 'thanhhaimaterials@gmail.com'),
	 ('NCC029', N'Công ty Cổ phần Vật liệu Xây dựng Vạn Phát', N'23B Phan Đăng Lưu, Quận Bình Thạnh, TP.HCM', '0919456123', 'vanphatconstruction@gmail.com'),
    ('NCC030', N'Công ty TNHH Vật liệu Xây dựng Minh Khoa', N'56 Lê Lai, Quận 1, TP.HCM', '0909123456', 'minhkhoamaterials@gmail.com'),
    ('NCC031', N'Công ty Cổ phần Vật liệu Xây dựng Phúc Long', N'78B Nguyễn Huệ, Quận 3, TP.HCM', '0918234567', 'phuclongconstruction@gmail.com'),
    ('NCC032', N'Công ty TNHH Vật liệu Xây dựng Hải Minh', N'90 Lý Thường Kiệt, Quận 5, TP.HCM', '0987654321', 'haiminhmaterials@gmail.com'),
    ('NCC033', N'Công ty Cổ phần Xây dựng và Vật liệu Kim Anh', N'34B Hai Bà Trưng, Hà Nội', '0912345678', 'kimanhconstruction@gmail.com'),
    ('NCC034', N'Công ty TNHH Vật liệu Xây dựng Tân Thành', N'45 Nguyễn Thị Minh Khai, Quận 10, TP.HCM', '0918345678', 'tanthanhmaterials@gmail.com'),
    ('NCC035', N'Công ty Cổ phần Vật liệu Xây dựng Nam An', N'67 Lê Thị Riêng, Quận 1, TP.HCM', '0909456789', 'namanconstruction@gmail.com'),
    ('NCC036', N'Công ty TNHH Vật liệu Xây dựng Thái Hòa', N'23 Trần Hưng Đạo, Đà Nẵng', '0911122334', 'thaihoaconstruction@gmail.com'),
    ('NCC037', N'Công ty Cổ phần Vật liệu Xây dựng Anh Đức', N'78 Lê Thánh Tôn, Quận 3, TP.HCM', '0909234567', 'anhducmaterials@gmail.com'),
    ('NCC038', N'Công ty TNHH Vật liệu Xây dựng Đại Minh', N'56 Lê Duẩn, Quận Bình Thạnh, TP.HCM', '0988776655', 'daiminhconstruction@gmail.com'),
    ('NCC039', N'Công ty Cổ phần Vật liệu Xây dựng Hương Sơn', N'45 Nguyễn Đình Chính, Quận Phú Nhuận, TP.HCM', '0918345678', 'huongsonmaterials@gmail.com'),
    ('NCC040', N'Công ty TNHH Vật liệu Xây dựng Long Thành', N'67 Cộng Hòa, Quận Tân Bình, TP.HCM', '0909456789', 'longthanhmaterials@gmail.com'),
    ('NCC041', N'Công ty Cổ phần Xây dựng và Vật liệu Minh Tâm', N'78B Hùng Vương, Quận 1, TP.HCM', '0918567890', 'minhtamconstruction@gmail.com'),
    ('NCC042', N'Công ty TNHH Vật liệu Xây dựng An Khánh', N'56B Nguyễn Văn Cừ, Quận 4, TP.HCM', '0909345678', 'ankhanhmaterials@gmail.com'),
    ('NCC043', N'Công ty Cổ phần Vật liệu Xây dựng Phú Anh', N'34 Hoàng Hoa Thám, Hà Nội', '0918234455', 'phuanhconstruction@gmail.com'),
    ('NCC044', N'Công ty TNHH Vật liệu Xây dựng Lê Phát', N'90 Đinh Công Tráng, Quận 10, TP.HCM', '0919456789', 'lephatmaterials@gmail.com'),
    ('NCC045', N'Công ty Cổ phần Xây dựng và Vật liệu Minh Hòa', N'23 Lê Thị Hồng, Quận 7, TP.HCM', '0918567890', 'minhhoaconstruction@gmail.com'),
    ('NCC046', N'Công ty TNHH Vật liệu Xây dựng Thanh Bình', N'90 Trần Hưng Đạo, Hà Nội', '0909345678', 'thanhbinhmaterials@gmail.com'),
    ('NCC047', N'Công ty Cổ phần Vật liệu Xây dựng Tân Hiệp', N'56 Bạch Đằng, Quận 1, TP.HCM', '0919456789', 'tanhiepconstruction@gmail.com'),
    ('NCC048', N'Công ty TNHH Vật liệu Xây dựng Anh Tuấn', N'34 Lê Thị Minh Khai, Quận 3, TP.HCM', '0918567890', 'anhtuanmaterials@gmail.com'),
    ('NCC049', N'Công ty Cổ phần Xây dựng và Vật liệu Hòa Phong', N'78 Nguyễn Huệ, Quận 1, TP.HCM', '0909345678', 'hoaphongconstruction@gmail.com'),
    ('NCC050', N'Công ty TNHH Vật liệu Xây dựng Hải Dương', N'56B Lê Lai, Quận Bình Thạnh, TP.HCM', '0918234455', 'haiduongmaterials@gmail.com');


----------------------------------------------------------Người Dùng----------------------------------------------------------
INSERT INTO NGUOIDUNG (USERNAME, PASSWORD, LOAI, MANV)
VALUES
	('nguyenan1', 'nguyenan10', 0, 'NV001'),
	('ledung2', 'ledung21', 1, 'NV002'),
	('trancuong3', 'trancuong31', 1, 'NV003'),
	('phammai4', 'phammai41', 1, 'NV004'),
	('hobich5', 'hobich51', 1, 'NV005'),
	('vuhoa6', 'vuhoa61', 1, 'NV006'),
	('nguyenhung7', 'nguyenhung71', 1, 'NV007'),
	('tranlan8', 'tranlan81', 1, 'NV008'),
	('letam9', 'letam91', 1, 'NV009'),
	('nguyenngoc10', 'nguyenngoc100', 0, 'NV010'),
	('nguyenhai11', 'nguyenhai111', 1, 'NV011'),
	('lehuong12', 'lehuong121', 1, 'NV012'),
	('maihai13', 'maihai131', 1, 'NV013'),
	('lytrinh14', 'lytrinh141', 1, 'NV014'),
	('votu15', 'votu151', 1, 'NV015'),
	('phanminh16', 'phanminh161', 1, 'NV016'),
	('doha17', 'doha171', 1, 'NV017'),
	('nguyenhoa18', 'nguyenhoa181', 1, 'NV018'),
	('truongthu19', 'truongthu191', 1, 'NV019'),
	('nguyentuan20', 'nguyentuan201', 1, 'NV020'),
	('phamngoc21', 'phamngoc211', 1, 'NV021'),
	('hoanghai22', 'hoanghai221', 1, 'NV022'),
	('leha23', 'leha231', 1, 'NV023'),
	('nguyenquang24', 'nguyenquang241', 1, 'NV024'),
	('tranngan25', 'tranngan250', 0, 'NV025'),
	('vuha26', 'vuha261', 1, 'NV026'),
	('nguyentam27', 'nguyentam271', 1, 'NV027'),
	('ngomai28', 'ngomai281', 1, 'NV028'),
	('hoanganh29', 'hoanganh291', 1, 'NV029'),
	('tranbich30', 'tranbich301', 1, 'NV030'),
	('nguyenhai31', 'nguyenhai311', 1, 'NV031'),
	('tranyen32', 'tranyen321', 1, 'NV032'),
	('phamcuong33', 'phamcuong331', 1, 'NV033'),
	('vohuong34', 'vohuong341', 1, 'NV034'),
	('lebinh35', 'lebinh351', 1, 'NV035'),
	('dongoc36', 'dongoc361', 1, 'NV036'),
	('trantu37', 'trantu371', 1, 'NV037'),
	('lethu38', 'lethu381', 1, 'NV038'),
	('nguyenhoa39', 'nguyenhoa391', 1, 'NV039'),
	('vumai40', 'vumai401', 1, 'NV040'),
	('phamhai41', 'phamhai411', 1, 'NV041'),
	('tranhuong42', 'tranhuong421', 1, 'NV042'),
	('maihai43', 'maihai431', 1, 'NV043'),
	('lylinh44', 'lylinh441', 1, 'NV044'),
	('votu45', 'votu451', 1, 'NV045'),
	('phanminh46', 'phanminh461', 1, 'NV046'),
	('doha47', 'doha471', 1, 'NV047'),
	('nguyenquang48', 'nguyenquang481', 1, 'NV048'),
	('truongthu49', 'truongthu491', 1, 'NV049'),
	('nguyentuan50', 'nguyentuan501', 1, 'NV050'),
	('leduc51', 'leduc510', 0, 'NV051'),
	('nguyenhien52', 'nguyenhien521', 1, 'NV052'),
	('nguyenhang53', 'nguyenhang531', 1, 'NV053'),
	('luuhoang54', 'luuhoang540', 0, 'NV054'),
	('caotri55', 'caotri550', 0, 'NV055');
----------------------------------------------------------Xem bảng----------------------------------------------------------
SELECT * FROM NHANVIEN

SELECT * FROM VATLIEU

SELECT * FROM LOAIVATLIEU

SELECT * FROM KHACHHANG

SELECT * FROM NHACUNGCAP

SELECT * FROM NGUOIDUNG

----------------------------------------------------------Tạo PROCEDURE----------------------------------------------------------
----------------------------------------------------------Thêm Nhà cung cấp---------------------------------------------------------- (CÓ SỬ DỤNG TRONG PHẦN MỀMM TỪ DÒNG 549-1174)
CREATE PROC  sp_Insert_NhaCungCap
    @MaNCC VARCHAR(10),
    @TenNCC NVARCHAR(50),
    @DiaChiNCC NVARCHAR(100),
    @SDTNCC VARCHAR(15),
    @EmailNCC NVARCHAR(50)
AS
BEGIN
    INSERT INTO NHACUNGCAP (MANCC, TENNCC, DIACHI_NCC, SDT_NCC, EMAIL_NCC)
    VALUES (@MaNCC, @TenNCC, @DiaChiNCC, @SDTNCC, @EmailNCC);
END;
GO
----------------------------------------------------------Cập nhật Nhà cung cấp----------------------------------------------------------
CREATE PROCEDURE sp_Update_NhaCungCap
    @MaNCC VARCHAR(10),
    @TenNCC NVARCHAR(50),
    @DiaChiNCC NVARCHAR(100),
    @SDTNCC VARCHAR(15),
    @EmailNCC NVARCHAR(50)
AS
BEGIN
    UPDATE NHACUNGCAP
    SET TENNCC = @TenNCC,
        DIACHI_NCC = @DiaChiNCC,
        SDT_NCC = @SDTNCC,
        EMAIL_NCC = @EmailNCC
    WHERE MANCC = @MaNCC;
END;
GO
----------------------------------------------------------Xóa Nhà cung cấp----------------------------------------------------------
CREATE PROCEDURE sp_Delete_NhaCungCap
    @MaNCC VARCHAR(10)
AS
BEGIN
    DELETE FROM NHACUNGCAP
    WHERE MANCC = @MaNCC;
END;
GO
----------------------------------------------------------Lấy tất cả các cột trong bảng Nhà cung cấp----------------------------------------------------------
CREATE PROCEDURE sp_SelectAll_NhaCungCap
AS
BEGIN
    SELECT * FROM NHACUNGCAP;
END;
GO
----------------------------------------------------------Tìm kiếm theo mã Nhà cung cấp----------------------------------------------------------
CREATE PROCEDURE sp_SelectByID_NhaCungCap
    @MaNCC VARCHAR(10)
AS
BEGIN
    SELECT * FROM NHACUNGCAP WHERE MANCC = @MaNCC;
END;
GO
---------------------------------------------------------Thêm Nhân Viên----------------------------------------------------------
CREATE PROCEDURE sp_Insert_NhanVien
    @MANV VARCHAR(10),
    @TENNV NVARCHAR(50),
    @HINHANH IMAGE,
    @GIOITINH NVARCHAR(5),
    @NGAYSINH DATE,
    @DIACHI_NV NVARCHAR(50),
    @SDT_NV VARCHAR(15),
    @EMAIL_NV NVARCHAR(50)
AS
BEGIN
    INSERT INTO NHANVIEN (MANV, TENNV, HINHANH, GIOITINH, NGAYSINH, DIACHI_NV, SDT_NV, EMAIL_NV)
    VALUES (@MANV, @TENNV, @HINHANH, @GIOITINH, @NGAYSINH, @DIACHI_NV, @SDT_NV, @EMAIL_NV)
END
GO
---------------------------------------------------------Cập nhật Nhân Viên----------------------------------------------------------
CREATE PROCEDURE sp_Update_NhanVien
    @MANV VARCHAR(10),
    @TENNV NVARCHAR(50),
    @HINHANH IMAGE,
    @GIOITINH NVARCHAR(5),
    @NGAYSINH DATE,
    @DIACHI_NV NVARCHAR(50),
    @SDT_NV VARCHAR(15),
    @EMAIL_NV NVARCHAR(50)
AS
BEGIN
    UPDATE NHANVIEN
    SET TENNV = @TENNV,
        HINHANH = @HINHANH,
        GIOITINH = @GIOITINH,
        NGAYSINH = @NGAYSINH,
        DIACHI_NV = @DIACHI_NV,
        SDT_NV = @SDT_NV,
        EMAIL_NV = @EMAIL_NV
    WHERE MANV = @MANV
END
go
---------------------------------------------------------Xóa Nhân Viên----------------------------------------------------------
CREATE PROCEDURE sp_Delete_NhanVien
    @MANV VARCHAR(10)
AS
BEGIN
    DELETE FROM NHANVIEN
    WHERE MANV = @MANV
END
go
---------------------------------------------------------Lấy tất cả các cột trong bảng Nhân Viên----------------------------------------------------------
CREATE PROCEDURE sp_SelectAll_NhanVien
AS
BEGIN
    SELECT * FROM NHANVIEN
END
go
---------------------------------------------------------Tìm theo mã Nhân Viên----------------------------------------------------------
CREATE PROCEDURE sp_SelectByID_NhanVien
    @MANV VARCHAR(10)
AS
BEGIN
    SELECT * FROM NHANVIEN
    WHERE MANV = @MANV
END
go
---------------------------------------------------------Thêm Tài Khoản----------------------------------------------------------
CREATE PROCEDURE sp_Insert_TaiKhoan
    @USERNAME VARCHAR(50),
    @PASSWORD VARCHAR(50),
    @LOAI INT,
    @MANV VARCHAR(10)
AS
BEGIN
    INSERT INTO NGUOIDUNG(USERNAME, PASSWORD, LOAI, MANV)
    VALUES (@USERNAME, @PASSWORD, @LOAI, @MANV)
END
go
---------------------------------------------------------Cập nhật Tài Khoản----------------------------------------------------------
CREATE PROCEDURE sp_Update_TaiKhoan
    @USERNAME NVARCHAR(50),
    @PASSWORD NVARCHAR(50),
    @LOAI INT,
    @MANV NVARCHAR(50)
AS
BEGIN
    UPDATE NGUOIDUNG
    SET PASSWORD = @PASSWORD,
        LOAI = @LOAI,
        MANV = @MANV
    WHERE USERNAME = @USERNAME;
END
go
---------------------------------------------------------Xóa Tài Khoản----------------------------------------------------------
CREATE PROCEDURE sp_Delete_TaiKhoan
    @USERNAME NVARCHAR(50)
AS
BEGIN
    DELETE FROM NGUOIDUNG WHERE USERNAME = @USERNAME;
END
go
---------------------------------------------------------Lấy tất cả các cột trong bảng Tài Khoản----------------------------------------------------------
CREATE PROCEDURE sp_SelectAll_TaiKhoan
AS
BEGIN
    SELECT * FROM NGUOIDUNG;
END
go
---------------------------------------------------------Tìm theo mã Tài Khoản----------------------------------------------------------
CREATE PROCEDURE sp_SelectByID_TaiKhoan
    @USERNAME NVARCHAR(50)
AS
BEGIN
    SELECT * FROM NGUOIDUNG WHERE USERNAME = @USERNAME;
END
go
---------------------------------------------------------Thêm Khách Hàng----------------------------------------------------------
CREATE PROC sp_Insert_KhachHang
	@MaKH VARCHAR(10),
	@TenKH NVARCHAR(50),
	@DiaChiKH NVARCHAR(100),
	@SDT_KH VARCHAR(15),
	@Email_KH NVARCHAR(50)
AS
BEGIN 
	INSERT INTO KHACHHANG(MAKH, TENKH, DIACHI, SDT_KH,EMAIL_KH)
    VALUES (@MaKH, @TenKH, @DiaChiKH, @SDT_KH, @Email_KH);
END;
GO
---------------------------------------------------------Cập nhật Khách Hàng----------------------------------------------------------
CREATE PROC sp_Update_KhachHang
    @MaKH VARCHAR(10),
	@TenKH NVARCHAR(50),
	@DiaChiKH NVARCHAR(100),
	@SDT_KH VARCHAR(15),
	@Email_KH NVARCHAR(50)
AS
BEGIN
    UPDATE KHACHHANG
    SET TENKH = @TenKH,
        DIACHI = @DiaChiKH,
        SDT_KH = @SDT_KH,
        EMAIL_KH = @Email_KH
    WHERE MAKH = @MaKH;
END;
GO
---------------------------------------------------------Xóa Khách Hàng----------------------------------------------------------
CREATE PROC sp_Delete_KhachHang
    @MaKH VARCHAR(10)
AS
BEGIN
    DELETE FROM KHACHHANG
    WHERE MAKH = @MaKH;
END;
GO
---------------------------------------------------------Lấy tất cả các cột trong bảng Khách Hàng----------------------------------------------------------
CREATE PROC sp_SelectAll_KhachHang
AS
BEGIN
    SELECT * FROM KHACHHANG;
END;
GO
---------------------------------------------------------Tìm theo mã Khách Hàng----------------------------------------------------------
CREATE PROC sp_SelectByID_KhachHang
    @MaKH VARCHAR(10)
AS
BEGIN
    SELECT * FROM KHACHHANG WHERE MAKH = @MaKH;
END;
GO
---------------------------------------------------------Thêm Phiếu Nhập Hàng----------------------------------------------------------
CREATE PROCEDURE sp_Insert_PhieuNhapHang
    @MAPN VARCHAR(10),
    @MANCC VARCHAR(10),
    @MANV VARCHAR(10),
    @NGAYNHAP DATETIME,
    @TONGNHAP DECIMAL(18, 0)
AS
BEGIN
    INSERT INTO PHIEUNHAPHANG (MAPN, MANCC, MANV, NGAYNHAP, TONGNHAP)
    VALUES (@MAPN, @MANCC, @MANV, @NGAYNHAP, @TONGNHAP)
END
GO
---------------------------------------------------------Cập Nhật Phiếu Nhập Hàng----------------------------------------------------------
CREATE PROCEDURE sp_Update_PhieuNhapHang
    @MAPN VARCHAR(10),
    @MANCC VARCHAR(10),
    @MANV VARCHAR(10),
    @NGAYNHAP DATETIME,
    @TONGNHAP DECIMAL(18, 0)
AS
BEGIN
    UPDATE PHIEUNHAPHANG
    SET MANCC = @MANCC,
        MANV = @MANV,
        NGAYNHAP = @NGAYNHAP,
        TONGNHAP = @TONGNHAP
    WHERE MAPN = @MAPN
END
GO
---------------------------------------------------------Xóa Phiếu Nhập Hàng----------------------------------------------------------
CREATE PROCEDURE sp_Delete_PhieuNhapHang
    @MAPN VARCHAR(10)
AS
BEGIN
    DELETE FROM PHIEUNHAPHANG
    WHERE MAPN = @MAPN
END
GO
---------------------------------------------------------Lấy tất cả các cột trong bảng Phiếu Nhập Hàng----------------------------------------------------------
CREATE PROCEDURE sp_SelectAll_PhieuNhapHang
AS
BEGIN
    SELECT *
    FROM PHIEUNHAPHANG
END
GO
---------------------------------------------------------Tìm theo mã Phiếu Nhập Hàng----------------------------------------------------------
CREATE PROCEDURE sp_SelectByID_PhieuNhapHang
    @MAPN VARCHAR(10)
AS
BEGIN
    SELECT *
    FROM PHIEUNHAPHANG
    WHERE MAPN = @MAPN
END
GO
---------------------------------------------------------Thêm Chi tiết Phiếu Nhập Hàng----------------------------------------------------------
CREATE PROCEDURE sp_Insert_ChiTietPhieuNhapHang
    @MAPN VARCHAR(10),
    @MAVL VARCHAR(10),
    @GIANHAP DECIMAL(18, 0),
    @SOLUONGNHAP INT
AS
BEGIN
    INSERT INTO CHITIET_PHIEUNHAPHANG (MAPN, MAVL, GIANHAP, SOLUONGNHAP)
    VALUES (@MAPN, @MAVL, @GIANHAP, @SOLUONGNHAP)
END
GO
---------------------------------------------------------Cập nhật Chi tiết Phiếu Nhập Hàng----------------------------------------------------------
CREATE PROCEDURE sp_Update_ChiTietPhieuNhapHang
    @MAPN VARCHAR(10),
    @MAVL VARCHAR(10),
    @GIANHAP DECIMAL(18, 0),
    @SOLUONGNHAP INT
AS
BEGIN
    UPDATE CHITIET_PHIEUNHAPHANG
    SET GIANHAP = @GIANHAP,
        SOLUONGNHAP = @SOLUONGNHAP
    WHERE MAPN = @MAPN AND MAVL = @MAVL
END
GO
---------------------------------------------------------Xóa Chi tiết Phiếu Nhập Hàng----------------------------------------------------------
CREATE PROCEDURE sp_Delete_ChiTietPhieuNhapHang
    @MAPN VARCHAR(10),
    @MAVL VARCHAR(10)
AS
BEGIN
    DELETE FROM CHITIET_PHIEUNHAPHANG
    WHERE MAPN = @MAPN AND MAVL = @MAVL
END
GO
---------------------------------------------------------Lấy tất cả các cột trong Chi tiết Phiếu Nhập Hàng----------------------------------------------------------
CREATE PROCEDURE sp_SelectAll_ChiTietPhieuNhapHang
AS
BEGIN
    SELECT * FROM CHITIET_PHIEUNHAPHANG
END
GO
---------------------------------------------------------Tìm theo mã Chi tiết Phiếu Nhập Hàng----------------------------------------------------------
CREATE PROCEDURE sp_SelectByID_ChiTietPhieuNhapHang
    @MAPN VARCHAR(10),
    @MAVL VARCHAR(10)
AS
BEGIN
    SELECT * FROM CHITIET_PHIEUNHAPHANG
    WHERE MAPN = @MAPN AND MAVL = @MAVL
END
go
---------------------------------------------------------Cập nhật Tổng Tiền Phiếu Nhập----------------------------------------------------------
CREATE PROCEDURE sp_Update_TongTien_PhieuNhap
    @MAPN VARCHAR(10)
AS
BEGIN
    DECLARE @TongTien DECIMAL(18, 0);

    -- Kiểm tra sự tồn tại của dữ liệu
    IF EXISTS (SELECT 1 FROM CHITIET_PHIEUNHAPHANG WHERE MAPN = @MAPN)
    BEGIN
        -- Tính tổng tiền từ chi tiết phiếu nhập
        SELECT @TongTien = SUM(GIANHAP * SOLUONGNHAP)
        FROM CHITIET_PHIEUNHAPHANG
        WHERE MAPN = @MAPN;
    END
    ELSE
    BEGIN
        -- Nếu không có dữ liệu, gán tổng tiền bằng 0
        SET @TongTien = 0;
    END

    -- Cập nhật tổng tiền trong bảng PhieuNhap
    UPDATE PHIEUNHAPHANG
    SET TONGNHAP = @TongTien
    WHERE MAPN = @MAPN;
END;
go
---------------------------------------------------------Xóa tất cả Chi tiết Phiếu Nhập----------------------------------------------------------
CREATE PROCEDURE sp_Delete_AllChiTietPhieuNhap
    @MAPN VARCHAR(10)
AS
BEGIN
    -- Xóa tất cả chi tiết phiếu thanh toán dựa trên MADH
    DELETE FROM CHITIET_PHIEUNHAPHANG
    WHERE MAPN = @MAPN;
END
GO
---------------------------------------------------------Thực hiện xác thực Người Dùng trong hệ thống----------------------------------------------------------
---------------------------------------------------------Kiểm tra sự tồn tại của tên đăng nhập và mật khẩu trong bảng---------------------------------------------------------- 
CREATE PROCEDURE p_login_MaNV
    @username NVARCHAR(255),
    @password NVARCHAR(255)
AS
BEGIN
    -- Check for valid username and password
    IF EXISTS (SELECT 1 FROM NGUOIDUNG WHERE USERNAME = @username AND PASSWORD = @password)
    BEGIN
        -- Retrieve MANV based on the provided username and password
        SELECT MANV
        FROM NGUOIDUNG
        WHERE USERNAME = @username AND PASSWORD = @password;
    END
    ELSE
    BEGIN
        -- Return NULL if no matching record is found
        SELECT NULL AS MANV;
    END
END
--------------------------------------------------------Truy vấn tất cả cột từ bảng NGUOIDUNG dựa trên tên đăng nhập và mật khẩu----------------------------------------------------------
create proc proc_login @username varchar(10), @password nvarchar(50)
as
begin 
	select * from NGUOIDUNG where USERNAME = @username and PASSWORD = @password
end
---------------------------------------------------------Thực hiện xác thực người dùng trong hệ thống và trả về loại người dùng (LOAI)---------------------------------------------------------- 
create PROCEDURE p_login
    @username NVARCHAR(255),
    @password NVARCHAR(255)
AS
BEGIN
    DECLARE @loai INT
    BEGIN
      
        SET @loai = (SELECT LOAI FROM NGUOIDUNG WHERE USERNAME = @username and PASSWORD = @password)

    END
    -- Trả về kết quả đăng nhập
    --SELECT @loginResult AS LoginResult
	return @loai;
END
---------------------------------------------------------Thêm Vật Liệu----------------------------------------------------------
CREATE PROCEDURE sp_Insert_VatLieu
    @MAVL varchar(10),
    @MALOAI varchar(10),
    @TENVL nvarchar(50),
    @HINHANH image,
    @MOTA nvarchar(100),
    @DONVITINH nvarchar(10),
    @GIA decimal(18, 0),
    @NGAYSX date,
    @HANSD date,
    @XUATXU nvarchar(50),
    @SOLUONGCON int
AS
BEGIN
    INSERT INTO VATLIEU (MAVL, MALOAI, TENVL, HINHANH, MOTA, DONVITINH, GIA, NGAYSX, HANSD, XUATXU, SOLUONGCON)
    VALUES (@MAVL, @MALOAI, @TENVL, @HINHANH, @MOTA, @DONVITINH, @GIA, @NGAYSX, @HANSD, @XUATXU, @SOLUONGCON)
END
go
---------------------------------------------------------Cập nhật Vật Liệu----------------------------------------------------------
CREATE PROCEDURE sp_Update_VatLieu
    @MAVL varchar(10),
    @MALOAI varchar(10),
    @TENVL nvarchar(50),
    @HINHANH image,
    @MOTA nvarchar(100),
    @DONVITINH nvarchar(10),
    @GIA decimal(18, 0),
    @NGAYSX date,
    @HANSD date,
    @XUATXU nvarchar(50),
    @SOLUONGCON int
AS
BEGIN
    UPDATE VATLIEU
    SET MALOAI = @MALOAI,
        TENVL = @TENVL,
        HINHANH = @HINHANH,
        MOTA = @MOTA,
        DONVITINH = @DONVITINH,
        GIA = @GIA,
        NGAYSX = @NGAYSX,
        HANSD = @HANSD,
        XUATXU = @XUATXU,
        SOLUONGCON = @SOLUONGCON
    WHERE MAVL = @MAVL
END
go
---------------------------------------------------------Xóa Vật Liệu----------------------------------------------------------

CREATE PROCEDURE sp_Delete_VatLieu
    @MAVL varchar(10)
AS
BEGIN
    DELETE FROM VATLIEU WHERE MAVL = @MAVL
END
go
---------------------------------------------------------Lấy tất cả các cột trong bảng Vật Liệu----------------------------------------------------------
CREATE PROCEDURE sp_SelectAll_VatLieu
AS
BEGIN
    SELECT * FROM VATLIEU
END
go
---------------------------------------------------------Tìm theo mã Vật Liệu----------------------------------------------------------
CREATE PROCEDURE sp_SelectByID_VatLieu
    @MAVL varchar(10)
AS
BEGIN
    SELECT * FROM VATLIEU WHERE MAVL = @MAVL
END
go

---------------------------------------------------------Lấy tất cả các cột trong Phiếu Thanh Toán----------------------------------------------------------
CREATE PROCEDURE sp_SelectAll_PhieuThanhToan
AS
BEGIN
    SELECT * FROM PHIEUTHANHTOAN
END
go

---------------------------------------------------------Tìm theo mã Phiếu Thanh Toán----------------------------------------------------------
CREATE PROCEDURE sp_SelectByID_PhieuThanhToan
    @MADH VARCHAR(10)
AS
BEGIN
    SELECT * FROM PHIEUTHANHTOAN WHERE MADH = @MADH
END
go
---------------------------------------------------------Thêm Phiếu Thanh Toán----------------------------------------------------------
CREATE PROCEDURE sp_Insert_PhieuThanhToan
    @MADH VARCHAR(10),
    @MAKH VARCHAR(10),
    @MANV VARCHAR(10),
    @NGAYDAT DATE,
    @TRANGTHAI NVARCHAR(50),
    @TONGHOADON DECIMAL(18, 0)
AS
BEGIN
    INSERT INTO PHIEUTHANHTOAN (MADH, MAKH, MANV, NGAYDAT, TRANGTHAI, TONGHOADON)
    VALUES (@MADH, @MAKH, @MANV, @NGAYDAT, @TRANGTHAI, @TONGHOADON)
END
go
---------------------------------------------------------Cập nhật Phiếu Thanh Toán----------------------------------------------------------
CREATE PROCEDURE sp_Update_PhieuThanhToan
    @MADH VARCHAR(10),
    @MAKH VARCHAR(10),
    @MANV VARCHAR(10),
    @NGAYDAT DATE,
    @TRANGTHAI NVARCHAR(50),
    @TONGHOADON DECIMAL(18, 0)
AS
BEGIN
    UPDATE PHIEUTHANHTOAN
    SET MAKH = @MAKH, MANV = @MANV, NGAYDAT = @NGAYDAT, TRANGTHAI = @TRANGTHAI, TONGHOADON = @TONGHOADON
    WHERE MADH = @MADH
END
go
---------------------------------------------------------Xóa Phiếu Thanh Toán----------------------------------------------------------
CREATE PROCEDURE sp_Delete_PhieuThanhToan
    @MADH VARCHAR(10)
AS
BEGIN
    DELETE FROM PHIEUTHANHTOAN WHERE MADH = @MADH
END
go
---------------------------------------------------------Lấy tất cả các cột trong bảng Chi tiết Phiếu Thanh Toán----------------------------------------------------------
CREATE PROCEDURE sp_SelectAll_ChiTietPhieuThanhToan
AS
BEGIN
    SELECT * FROM CHITIET_PHIEUTHANHTOAN
END
go
---------------------------------------------------------Tìm theo mã Chi tiết Phiếu Thanh Toán----------------------------------------------------------
CREATE PROCEDURE sp_SelectByID_ChiTietPhieuThanhToan
    @MADH VARCHAR(10),
    @MAVL VARCHAR(10)
AS
BEGIN
    SELECT * FROM CHITIET_PHIEUTHANHTOAN WHERE MADH = @MADH AND MAVL = @MAVL
END
go
---------------------------------------------------------Thêm Chi tiết Phiếu Thanh Toán----------------------------------------------------------
CREATE PROCEDURE sp_Insert_ChiTietPhieuThanhToan
    @MADH VARCHAR(10),
    @MAVL VARCHAR(10),
    @GIA DECIMAL(18, 0),
    @SOLUONGBAN INT
AS
BEGIN
    INSERT INTO CHITIET_PHIEUTHANHTOAN (MADH, MAVL, GIA, SOLUONGBAN)
    VALUES (@MADH, @MAVL, @GIA, @SOLUONGBAN)
END
go
---------------------------------------------------------Cập nhật Chi tiết Phiếu Thanh Toán----------------------------------------------------------
CREATE PROCEDURE sp_Update_ChiTietPhieuThanhToan
    @MADH VARCHAR(10),
    @MAVL VARCHAR(10),
    @GIA DECIMAL(18, 0),
    @SOLUONGBAN INT
AS
BEGIN
    UPDATE CHITIET_PHIEUTHANHTOAN
    SET GIA = @GIA, SOLUONGBAN = @SOLUONGBAN
    WHERE MADH = @MADH AND MAVL = @MAVL
END
go
---------------------------------------------------------Xóa Chi tiết Phiếu Thanh Toán----------------------------------------------------------
CREATE PROCEDURE sp_Delete_ChiTietPhieuThanhToan
    @MADH VARCHAR(10),
    @MAVL VARCHAR(10)
AS
BEGIN
    DELETE FROM CHITIET_PHIEUTHANHTOAN WHERE MADH = @MADH AND MAVL = @MAVL
END
go
---------------------------------------------------------Cập nhật Tổng tiền của Phiếu Thanh Toán----------------------------------------------------------
CREATE PROCEDURE sp_Update_TongTien_PhieuThanhToan
    @MADH VARCHAR(10)
AS
BEGIN
    DECLARE @TongTien DECIMAL(18, 0);

    -- Kiểm tra sự tồn tại của dữ liệu trong CHITIET_PHIEUTHANHTOAN
    IF EXISTS (SELECT 1 FROM CHITIET_PHIEUTHANHTOAN WHERE MADH = @MADH)
    BEGIN
        -- Nếu có, tính tổng tiền
        SELECT @TongTien = SUM(GIA * SOLUONGBAN) 
        FROM CHITIET_PHIEUTHANHTOAN 
        WHERE MADH = @MADH;
    END
    ELSE
    BEGIN
        -- Nếu không có, gán tổng tiền bằng 0
        SET @TongTien = 0;
    END

    -- Cập nhật tổng tiền trong bảng PHIEUTHANHTOAN
    UPDATE PHIEUTHANHTOAN
    SET TONGHOADON = @TongTien
    WHERE MADH = @MADH;
END
GO

---------------------------------------------------------Xóa theo mã đơn hàng trong bảng Chi tiết Phiếu Thanh Toán----------------------------------------------------------(CÓ SỬ DỤNG TRONG PHẦN MỀM TỪ DÒNG 549-1173)
CREATE PROCEDURE sp_Delete_AllChiTietPhieuThanhToan
    @MADH VARCHAR(10)
AS
BEGIN
    -- Xóa tất cả chi tiết phiếu thanh toán dựa trên MADH
    DELETE FROM CHITIET_PHIEUTHANHTOAN
    WHERE MADH = @MADH;
END
GO
---------------------------------------------------------Cập nhật tất cả số lượng còn = 20000----------------------------------------------------------
 UPDATE VATLIEU
 SET SOLUONGCON = 20000
 GO
---------------------------------------------------------Viết thủ tục để kiểm tra xem một loại vật liệu có tồn tại trong bảng LOAIVATLIEU không?----------------------------------------------------------
CREATE PROCEDURE sp_CheckMaterialTypeExists
    @MaLoai VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    
    IF EXISTS (SELECT * FROM LOAIVATLIEU WHERE MALOAI = @MaLoai)
        SELECT N'Loại vật liệu tồn tại' AS Result
    ELSE
        SELECT N'Loại vật liệu không tồn tại' AS Result
END
go
EXEC sp_CheckMaterialTypeExists 'LVL01'
---------------------------------------------------------Viết thủ tục để tính tổng số lượng vật liệu còn trong kho?----------------------------------------------------------
CREATE PROCEDURE sp_TotalRemainingMaterial

AS
BEGIN
    SELECT SUM(SOLUONGCON) AS TongSoLuongCon
    FROM VATLIEU;
END;

EXEC sp_TotalRemainingMaterial
---------------------------------------------------------Viết thủ tục để kiểm tra xem một hóa đơn xuất có tồn tại trong bảng PHIEUTHANHTOAN không?----------------------------------------------------------
CREATE PROCEDURE sp_CheckExistsOutputInvoice
    @MaDonHang VARCHAR(10)
AS
BEGIN
    IF EXISTS (SELECT * FROM PHIEUTHANHTOAN WHERE MADH = @MaDonHang)
        PRINT N'Hóa đơn xuất tồn tại'
    ELSE
        PRINT N'Hóa đơn xuất không tồn tại'
END;

EXEC sp_CheckExistsOutputInvoice 'DH01'
----------------------------------------------------------Viết thủ tục thêm một chi tiết hóa đơn xuất mới vào bảng CHITIET_PHIEUTHANHTOAN?----------------------------------------------------------
CREATE PROCEDURE sp_Add_Detail_Invoice
    @MaDonHang VARCHAR(10),
    @MaVatLieu VARCHAR(10),
    @SoLuongBan INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM PHIEUTHANHTOAN WHERE MADH = @MaDonHang)
    BEGIN
        INSERT INTO CHITIET_PHIEUTHANHTOAN (MADH, MAVL, SOLUONGBAN)
        VALUES (@MaDonHang, @MaVatLieu, @SoLuongBan);

        PRINT N'Thêm chi tiết hóa đơn xuất thành công';
    END
    ELSE
        PRINT N'Hóa đơn xuất không tồn tại. Vui lòng kiểm tra lại mã đơn hàng';
END;


EXEC sp_Add_Detail_Invoice 'DH01', 'LVL20', 100
----------------------------------------------------------Viết thủ tục để xóa một khách hàng từ bảng KHACHHANG----------------------------------------------------------
CREATE PROCEDURE P_XoaKhachHang @MKH VARCHAR(10)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM KHACHHANG WHERE MAKH = @MKH)
    BEGIN
        DELETE FROM KHACHHANG WHERE MAKH = @MKH;

        PRINT N'Khách hàng đã được xóa thành công.';
    END
    ELSE
    BEGIN
        PRINT N'Không tìm thấy khách hàng có mã ' + @MKH + '.';
    END
END;
----------------------------------------------------------Viết thủ tục tính tổng số lượng vật liệu đã nhập từ một nhà cung cấp cụ thể?----------------------------------------------------------
CREATE PROCEDURE P_TongSL_Nhap_TheoNCC @MaNCC VARCHAR(10)
AS
BEGIN
    SELECT SUM(SOLUONGNHAP) AS TongSoLuongNhap
    FROM CHITIET_PHIEUNHAPHANG cpn
    INNER JOIN PHIEUNHAPHANG pn ON cpn.MAPN = pn.MAPN
    WHERE pn.MANCC = @MaNCC;
END;
GO
----------------------------------------------------------Viết thủ tục để kiểm tra xem một nhân viên có tồn tại trong bảng NHANVIEN không?----------------------------------------------------------
CREATE PROCEDURE P_KiemTra_NhanVien_exists @MaNV VARCHAR(10)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM NHANVIEN WHERE MANV = @MaNV)
    BEGIN
        PRINT N'Nhân viên có mã ' + @MaNV + N' tồn tại.';
    END
    ELSE
    BEGIN
        PRINT N'Không tìm thấy nhân viên có mã ' + @MaNV + '.';
    END
END;
go
----------------------------------------------------------Viết thủ tục để xóa một tài khoản nhân viên từ bảng người dùng khi truyền vào tên tài khoản----------------------------------------------------------
CREATE PROC Pc_Xoataikhoan @username VARCHAR(10)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM NGUOIDUNG WHERE USERNAME = @username)
    BEGIN
        DELETE FROM NGUOIDUNG WHERE USERNAME = @username;
        PRINT N'Tài khoản đã được ';
    END
    ELSE
    BEGIN
        PRINT N'Tài khoản cần xóa';
    END
END
go
----------------------------------------------------------Cho biết nhân viên nào trên 32 tuổi----------------------------------------------------------
CREATE PROCEDURE PR_NVtren30tuoi
AS
BEGIN
    SELECT * FROM NHANVIEN
    WHERE DATEDIFF(YEAR, NGAYSINH, GETDATE()) > 32;
END
go
exec PR_NVtren30tuoi
----------------------------------------------------------Kiểm tra coi sản phẩm đó còn hạn sử dụng hay không khi truyền vào mã vật liệu----------------------------------------------------------
CREATE PROCEDURE P_Hansudungcuavatlieu @MAVL VARCHAR(10)
AS
BEGIN
    DECLARE @CurrentDate DATE = GETDATE();
    
    SELECT 
        MAVL,
        TENVL,
        HANSD,
        CASE
            WHEN HANSD < @CurrentDate THEN N'Hết hạn'
            WHEN HANSD = @CurrentDate THEN N'Hết hạn hôm nay'
            ELSE 'Còn hạn sử dụng '
        END 
    FROM VATLIEU
    WHERE MAVL = @MAVL;
END
go
---------------------------------------------------------- Viết proc cho biết thông tin số điện thoại khi cho biết username ----------------------------------------------------------
CREATE PROCEDURE PR_SDT_NGUOIDUNG
    @USERNAME VARCHAR(20)
AS
BEGIN
    SELECT NV.SDT_NV
    FROM NGUOIDUNG ND
    JOIN NHANVIEN NV ON ND.MANV = NV.MANV
    WHERE ND.USERNAME = @USERNAME;
END
go
---------------------------------------------------------- Viết procedure để kiểm tra xem số lượng trong kho còn đủ hay không dựa trên mã vật liệu: ----------------------------------------------------------
CREATE PROCEDURE PR_KTSOLUONGTRONGKHO_SOLUONGNHAP
@MAVL VARCHAR(10),
@SOLUONGCANNHAP INT
AS
BEGIN
    DECLARE @SOLUONGCON INT;
    SELECT @SOLUONGCON = SOLUONGCON
    FROM VATLIEU
    WHERE MAVL = @MAVL;
    IF @SOLUONGCON IS NOT NULL AND @SOLUONGCON >= @SOLUONGCANNHAP
        PRINT N'Số lượng trong kho đủ, không cần thêm vào.';
    ELSE
        PRINT N'Số lượng trong kho không đủ, cần thêm vào.';
END
go
----------------------------------------------------------Trả về các danh sách các vật liệu nhập hàng trong ngày ----------------------------------------------------------
CREATE PROCEDURE DSVL_HANGNGAY
    @NGAYNHAP DATE
AS
BEGIN
    SELECT
        PN.MAPN,
        VL.MAVL,
        VL.TENVL,
        PN.NGAYNHAP,
        CTPN.SOLUONGNHAP
    FROM
        PHIEUNHAPHANG PN
        INNER JOIN CHITIET_PHIEUNHAPHANG CTPN ON PN.MAPN = CTPN.MAPN
        INNER JOIN VATLIEU VL ON CTPN.MAVL = VL.MAVL
    WHERE
        PN.NGAYNHAP = @NGAYNHAP;
END
GO
EXEC DSVL_HANGNGAY '2023-01-01';
----------------------------------------------------------Lấy danh sách các đơn đặt hàng của một khách hàng cụ thể----------------------------------------------------------
CREATE PROCEDURE DS_KH
    @MAKH VARCHAR(10)
AS
BEGIN
    SELECT
        PT.MADH AS 'MaDonHang',
        PT.NGAYDAT AS 'NgayDatHang',
        PT.TONGHOADON AS 'TongHoaDon'
    FROM
        PHIEUTHANHTOAN PT
    WHERE
        PT.MAKH = @MAKH;
END;
GO
EXEC DS_KH 'MaKhachHangCuThe';

----------------------------------Tạo FUNCTION----------------------------------------------------------
----------------------------------------------------------Viết hàm để tính giá trung bình của một loại vật liệu từ bảng VATLIEU?----------------------------------------------------------
CREATE FUNCTION f_AvgCostMaterials
(
    @MaLoaiVatLieu VARCHAR(10)
)
RETURNS MONEY
AS
BEGIN
    DECLARE @GiaTrungBinh MONEY

    SELECT @GiaTrungBinh = AVG(GIA)
    FROM VATLIEU
    WHERE MALOAI = @MaLoaiVatLieu;

    RETURN @GiaTrungBinh;
END;
go

DECLARE @MaLoaiVatLieu VARCHAR(10)

SELECT dbo.f_AvgCostMaterials ('LVL01') AS GiaTrungBinh;
----------------------------------------------------------Viết hàm trả về danh sách các vật liệu có số lượng còn ít hơn một ngưỡng cụ thể từ bảng VATLIEU?----------------------------------------------------------
CREATE FUNCTION f_MaterialUnderThreshold
(
    @Nguong INT --Threshold
)
RETURNS TABLE
AS
RETURN
(
    SELECT MAVL, TENVL, SOLUONGCON
    FROM VATLIEU
    WHERE SOLUONGCON < @Nguong
);

DECLARE @NgungSoLuong INT

SELECT * FROM dbo.f_MaterialUnderThreshold(50);
----------------------------------------------------------Viết hàm để tính tổng giá trị của các hóa đơn nhập một ngày cụ thể----------------------------------------------------------
CREATE FUNCTION F_TinhTongGiaTriHoaDonNhap (@NgayNhap DATE)
RETURNS DECIMAL(18, 0)
AS
BEGIN
    DECLARE @TongGT DECIMAL(18, 0);
    SELECT @TongGT = ISNULL(SUM(TONGNHAP), 0)
    FROM PHIEUNHAPHANG
    WHERE NGAYNHAP = @NgayNhap;

    RETURN @TongGT;
END;
go
----------------------------------------------------------Viết hàm để tính tổng số lượng vật liệu đã bán từ bảng CHITIET_PHIEUTHANHTOAN của 1 đơn hàng cụ thể----------------------------------------------------------
CREATE FUNCTION TinhTongSoLuongVatLieuDaBan (@MaDH VARCHAR(10))
RETURNS INT
AS
BEGIN
    DECLARE @TongSL INT;
    SELECT @TongSL = ISNULL(SUM(SOLUONGBAN), 0)
    FROM CHITIET_PHIEUTHANHTOAN
    WHERE MADH = @MaDH;

    RETURN @TongSL;
END;
---------------------------------------------------------- Viết hàm tính tuổi của một nhân viên----------------------------------------------------------
CREATE FUNCTION Fn_TinhTuoiNhanVien(@MANV varchar(10))
RETURNS INT
AS
BEGIN
    DECLARE @age INT;
	begin 
		SELECT @age = DATEDIFF(YEAR, NGAYSINH, GETDATE())
		FROM NHANVIEN
		WHERE MANV = @MANV;
	end
    RETURN @age;
END;
----------------------------------------------------------Trả về danh sách các khách hàng có tổng giá trị đơn đặt hàng cao nhất----------------------------------------------------------
CREATE FUNCTION KH_TGTCaoNhat
()
RETURNS TABLE
AS
RETURN
(
    SELECT TOP (100) PERCENT
        KH.TENKH AS 'TenKhachHang',
        KH.MAKH AS 'MaKhachHang',
        SUM(PT.TONGHOADON) AS 'TongGiaTriDonDatHang',
        COUNT(PT.MADH) AS 'SoLuongDonDatHang'
    FROM
        KHACHHANG KH
    LEFT JOIN
        PHIEUTHANHTOAN PT ON KH.MAKH = PT.MAKH
    GROUP BY
        KH.MAKH, KH.TENKH
    ORDER BY
        SUM(PT.TONGHOADON) DESC
);

SELECT * FROM dbo.KH_TGTCaoNhat();
----------------------------------------------------------Tạo TRIGGER----------------------------------------------------------

----------------------------------------------------------Trigger thực hiện thay đổi dữ liệu khi bán hàng----------------------------------------------------------
CREATE TRIGGER trg_UpdateSOLUONGCON
ON CHITIET_PHIEUTHANHTOAN
AFTER INSERT, DELETE, UPDATE
AS
BEGIN
    -- Update SOLUONGCON in VATLIEU table for INSERTED rows
    UPDATE v
    SET v.SOLUONGCON = v.SOLUONGCON - i.SOLUONGBAN
    FROM VATLIEU v
    INNER JOIN INSERTED i ON v.MAVL = i.MAVL
    WHERE i.SOLUONGBAN IS NOT NULL;

    -- Update SOLUONGCON in VATLIEU table for DELETED rows
    UPDATE v
    SET v.SOLUONGCON = v.SOLUONGCON + d.SOLUONGBAN
    FROM VATLIEU v
    INNER JOIN DELETED d ON v.MAVL = d.MAVL
    WHERE d.SOLUONGBAN IS NOT NULL;

    -- Update SOLUONGCON in VATLIEU table for UPDATED rows
    UPDATE v
    SET v.SOLUONGCON = v.SOLUONGCON + d.SOLUONGBAN - i.SOLUONGBAN
    FROM VATLIEU v
    INNER JOIN INSERTED i ON v.MAVL = i.MAVL
    INNER JOIN DELETED d ON v.MAVL = d.MAVL
    WHERE i.SOLUONGBAN IS NOT NULL AND d.SOLUONGBAN IS NOT NULL;
END;
GO
----------------------------------------------------------Trigger khi nhập hàng số lượng sẽ được cộng vào bảng vật liệu----------------------------------------------------------
CREATE TRIGGER trg_UpdateSOLUONGCON
ON CHITIET_PHIEUNHAPHANG
AFTER INSERT
AS
BEGIN
    UPDATE VATLIEU
    SET SOLUONGCON = SOLUONGCON + i.SOLUONGNHAP
    FROM inserted i
    WHERE VATLIEU.MAVL = i.MAVL;
END;
-----------------------------------------------------------CURSOR Duyệt qua tất cả các dòng trong bảng NHANVIEN và hiển thị thông tin nhân viên:-----------------------------------
DECLARE employee_cursor CURSOR FOR
SELECT MANV, TENNV, GIOITINH, NGAYSINH, DIACHI_NV, SDT_NV, EMAIL_NV
FROM NHANVIEN;

OPEN employee_cursor;
FETCH NEXT FROM employee_cursor;
WHILE @@FETCH_STATUS = 0
BEGIN
    -- Xử lý dữ liệu ở đây
    FETCH NEXT FROM employee_cursor;
END

CLOSE employee_cursor;
DEALLOCATE employee_cursor;
-----------------------------------------------------------CURSOR Duyệt qua bảng VATLIEU và cập nhật giá của tất cả các vật liệu có ngày sản xuất trước 01/05/2023::-----------------------------------
DECLARE update_price_cursor CURSOR FOR
SELECT MAVL
FROM VATLIEU
WHERE NGAYSX < '2023-05-01';

OPEN update_price_cursor;
FETCH NEXT FROM update_price_cursor;
WHILE @@FETCH_STATUS = 0
BEGIN
    -- Xử lý cập nhật giá ở đây
    FETCH NEXT FROM update_price_cursor;
END

CLOSE update_price_cursor;
DEALLOCATE update_price_cursor;
-----------------------------------------------------------CURSOR Duyệt qua bảng LOAIVATLIEU và hiển thị tên loại vật liệu cùng với số lượng vật liệu thuộc loại đó::-----------------------------------
DECLARE type_count_cursor CURSOR FOR
SELECT LOAIVATLIEU.TENLOAI, COUNT(VATLIEU.MALOAI) AS SO_LUONG
FROM LOAIVATLIEU
LEFT JOIN VATLIEU ON LOAIVATLIEU.MALOAI = VATLIEU.MALOAI
GROUP BY LOAIVATLIEU.TENLOAI;

OPEN type_count_cursor;
FETCH NEXT FROM type_count_cursor;
WHILE @@FETCH_STATUS = 0
BEGIN
    -- Xử lý dữ liệu ở đây
    FETCH NEXT FROM type_count_cursor;
END

CLOSE type_count_cursor;
DEALLOCATE type_count_cursor;














































