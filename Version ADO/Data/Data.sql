CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

-- Food.
-- Table.
-- FoodCategory.
-- Account.
-- Bill.
-- BillInfo.

create TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống' -- Trống. || Có người.
)
GO

create TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 -- 1: Admin. || 0: staff.
)
GO

create TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

create TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
	on delete cascade
)
GO

create TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0,-- 1: đã thanh toán. || 0: chưa thanh toán.
	discount int not null
	
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
	on delete cascade
)
GO

alter table dbo.Bill add totalPrice int
GO

create TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill (id)
	on delete cascade,
	FOREIGN KEY (idFood) REFERENCES dbo.Food (id)
	on delete cascade
)
GO

INSERT INTO dbo.Account
(
    UserName,
    DisplayName,
    PassWord,
    Type
)
VALUES
(   N'quang', -- UserName - nvarchar(100)
    N'Quang Nguyễn', -- DisplayName - nvarchar(100)
    N'1', -- PassWord - nvarchar(1000)
    1    -- Type - int
    )
GO

INSERT INTO dbo.Account
(
    UserName,
    DisplayName,
    PassWord,
    Type
)
VALUES
(   N'tuan', -- UserName - nvarchar(100)
    N'Tuấn Bùi', -- DisplayName - nvarchar(100)
    N'1', -- PassWord - nvarchar(1000)
    0    -- Type - int
    )
GO

INSERT INTO dbo.Account
(
    UserName,
    DisplayName,
    PassWord,
    Type
)
VALUES
(   N'giao', -- UserName - nvarchar(100)
    N'Giao Đình', -- DisplayName - nvarchar(100)
    N'1', -- PassWord - nvarchar(1000)
    0    -- Type - int
    )
GO


INSERT INTO dbo.TableFood
(
    name,
    status
)
VALUES
(   N'Bàn 1', -- name - nvarchar(100)
    N'Trống'  -- status - nvarchar(100)
    )
GO
INSERT INTO dbo.TableFood
(
    name,
    status
)
VALUES
(   N'Bàn 2', -- name - nvarchar(100)
    N'Trống'  -- status - nvarchar(100)
    )
GO
INSERT INTO dbo.TableFood
(
    name,
    status
)
VALUES
(   N'Bàn 3', -- name - nvarchar(100)
    N'Trống'  -- status - nvarchar(100)
    )
GO
INSERT INTO dbo.TableFood
(
    name,
    status
)
VALUES
(   N'Bàn 4', -- name - nvarchar(100)
    N'Trống'  -- status - nvarchar(100)
    )
GO
INSERT INTO dbo.TableFood
(
    name,
    status
)
VALUES
(   N'Bàn 5', -- name - nvarchar(100)
    N'Trống'  -- status - nvarchar(100)
    )
GO
INSERT INTO dbo.TableFood
(
    name,
    status
)
VALUES
(   N'Bàn 6', -- name - nvarchar(100)
    N'Trống'  -- status - nvarchar(100)
    )
GO
INSERT INTO dbo.TableFood
(
    name,
    status
)
VALUES
(   N'Bàn 7', -- name - nvarchar(100)
    N'Trống'  -- status - nvarchar(100)
    )
GO
INSERT INTO dbo.TableFood
(
    name,
    status
)
VALUES
(   N'Bàn 8', -- name - nvarchar(100)
    N'Trống'  -- status - nvarchar(100)
    )
GO
INSERT INTO dbo.TableFood
(
    name,
    status
)
VALUES
(   N'Bàn 9', -- name - nvarchar(100)
    N'Trống'  -- status - nvarchar(100)
    )
GO
INSERT INTO dbo.TableFood
(
    name,
    status
)
VALUES
(   N'Bàn 10', -- name - nvarchar(100)
    N'Trống'  -- status - nvarchar(100)
    )
GO
INSERT INTO dbo.TableFood
(
    name,
    status
)
VALUES
(   N'Bàn 11', -- name - nvarchar(100)
    N'Trống'  -- status - nvarchar(100)
    )
GO

DECLARE @i int =12

WHILE @i <=20
BEGIN
	INSERT INTO dbo.TableFood
	(
	    name,
	    status
	)
	VALUES
	(   N'Bàn ' + CAST(@i AS NVARCHAR(100)), -- name - nvarchar(100)
	    N'Trống'  -- status - nvarchar(100)
	    )
	SET @i = @i + 1
END
GO

CREATE PROC USP_GetTableList
AS SELECT * FROM dbo.TableFood
GO

EXEC USP_GetTableList
GO

INSERT INTO dbo.FoodCategory
(
    name
)
VALUES
	(N'Coffee' -- name - nvarchar(100)
    )
GO
INSERT INTO dbo.FoodCategory
(
    name
)
VALUES
	(N'Kem' -- name - nvarchar(100)
    )
GO
INSERT INTO dbo.FoodCategory
(
    name
)
VALUES
	(N'Sinh Tố' -- name - nvarchar(100)
    )
GO
INSERT INTO dbo.FoodCategory
(
    name
)
VALUES
	(N'Nước Ngọt' -- name - nvarchar(100)
    )
GO
INSERT INTO dbo.FoodCategory
(
    name
)
VALUES
	(N'Nước ÉP' -- name - nvarchar(100)
    )
GO

INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Coffee Đen', -- name - nvarchar(100)
    1,   -- idCategory - int
    10000  -- price - float
    )
GO
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Coffee Sữa', -- name - nvarchar(100)
    1,   -- idCategory - int
    15000  -- price - float
    )
GO
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Kem 7 Màu', -- name - nvarchar(100)
    2,   -- idCategory - int
    12000  -- price - float
    )
GO
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Kem Dừa', -- name - nvarchar(100)
    2,   -- idCategory - int
    12000  -- price - float
    )
GO
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Sinh Tố Dâu', -- name - nvarchar(100)
    3,   -- idCategory - int
	75000  -- price - float
    )
GO
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Sinh Tố Bơ', -- name - nvarchar(100)
    3,   -- idCategory - int
	75000  -- price - float
    )
GO
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'7 UP', -- name - nvarchar(100)
    4,   -- idCategory - int
    99999  -- price - float
    )
GO
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Sting', -- name - nvarchar(100)
    4,   -- idCategory - int
    99999  -- price - float
    )
GO
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'7UP', -- name - nvarchar(100)
    5,   -- idCategory - int
    15000  -- price - float
    )
GO
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Nước Cam', -- name - nvarchar(100)
    5,   -- idCategory - int
    12000  -- price - float
    )
GO
INSERT INTO dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'Nước Chanh', -- name - nvarchar(100)
    5,   -- idCategory - int
    12000  -- price - float
    )
GO


ALTER PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT INTO dbo.Bill
	(
	    DateCheckIn,
	    DateCheckOut,
	    idTable,
	    status,
		discount
	)
	VALUES
	(   GETDATE(), -- DateCheckIn - date
		NULL, -- DateCheckOut - date
	    @idTable,         -- idTable - int
	    0,          -- status - int
		0
	    )
END
GO

CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1 
	SELECT @isExitsBillInfo = id, @foodCount = b.count FROM dbo.BillInfo AS b WHERE idBill =@idBill AND idFood = @idFood
	IF(@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF(@newCount > 0)
			UPDATE dbo.BillInfo SET count = @foodCount + @count WHERE idFood= @idFood
		ELSE
			DELETE dbo.BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
    BEGIN
	INSERT INTO dbo.BillInfo
	(
	    idBill,
	    idFood,
	    count
	)
	VALUES
	(   @idBill, -- idBill - int
	    @idFood, -- idFood - int
	    @count  -- count - int
	    )
	END
END
GO

create TRIGGER UTG_UpdateBillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = idBill FROM Inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill AND status = 0

	DECLARE @count INT
	SELECT @count = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idBill

	IF(@count > 0)
	BEGIN
		UPDATE dbo.TableFood SET status = N'Có người' WHERE id = @idTable
	end
	ELSE
	BEGIN
	UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
	end
END
GO

create TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT

	SELECT @idBill = id FROM Inserted

	DECLARE @idTable INT

	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill

	DECLARE @count INT = 0

	SELECT @COUNT = COUNT(*) FROM dbo.Bill WHERE idTable = @idTable AND status = 0
	
	IF(@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id= @idTable
END
GO

DECLARE @idBillNew INT = 21
SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idBillNew
GO

DECLARE @idBillOld INT = 12
GO
UPDATE dbo.BillInfo SET idBill = @idBillOld WHERE id IN (SELECT id FROM dbo.IDBillInfoTable)
GO

ALTER PROC USP_SwitchTable
@idTable1 int, @idTable2 INT
AS
BEGIN

	DECLARE @idFirstBill INT
    DECLARE @idSeconrdBill INT

	DECLARE @isFirstTableEmty INT = 1
	DECLARE @isSecondTableEmty INT = 1

	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0

	IF(@idFirstBill IS NULL)
	BEGIN
		INSERT INTO dbo.Bill
		(
		    DateCheckIn,
		    DateCheckOut,
		    idTable,
		    status
		)
		VALUES
		(   GETDATE(), -- DateCheckIn - date
		    null, -- DateCheckOut - date
		    @idTable1,         -- idTable - int
		    0          -- status - int
		    )
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND status = 0
	END

	SELECT @isFirstTableEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill

	IF(@idSeconrdBill IS null)
	BEGIN
		INSERT INTO dbo.Bill
		(
		    DateCheckIn,
		    DateCheckOut,
		    idTable,
		    status
		)
		VALUES
		(   GETDATE(), -- DateCheckIn - date
		    null, -- DateCheckOut - date
		    @idTable2,         -- idTable - int
		    0          -- status - int
		    )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND status = 0
	END
	SELECT @isSecondTableEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill

	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill =@idSeconrdBill

	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill

	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM dbo.IDBillInfoTable)

	DROP TABLE dbo.IDBillInfoTable
	IF(@isFirstTableEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable2
	IF(@isSecondTableEmty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable1
END
GO

EXEC USP_SwitchTable @idTable1 = 1 , @idTable2 = 2
GO

SELECT DISTINCT t.name, discount, b.totalPrice,DateCheckIn, DateCheckOut
FROM dbo.Bill AS b, dbo.TableFood AS t
WHERE DateCheckIn >= '20180401' AND DateCheckOut <='20180430' AND b.status = 1
AND t.id = b.idTable

ALTER PROC USP_GetListBillByDate
@checkIn date, @checkOut date
AS
BEGIN
	SELECT DISTINCT t.name AS [Tên bàn], discount AS [Giảm giá], b.totalPrice AS [Tổng tiền],DateCheckIn AS  [Ngày vào], DateCheckOut AS [Ngày ra]
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO

SELECT * FROM dbo.Account
GO

CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100),@displayName nvarchar(100), @password nvarchar(100), @newPassword nvarchar(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0

	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE  UserName = @userName AND PassWord = @password
	IF(@isRightPass = 1)
	BEGIN
		IF(@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE dbo.Account SET DisplayName=@displayName WHERE UserName = @userName
        END
		ELSE
			UPDATE dbo.Account SET DisplayName=@displayName, PassWord = @newPassword WHERE UserName = @userName
    END
END
GO

SELECT * FROM dbo.Food
GO
SELECT * FROM dbo.FoodCategory
GO

INSERT dbo.Food
(
    name,
    idCategory,
    price
)
VALUES
(   N'', -- name - nvarchar(100)
    0,   -- idCategory - int
    0.0  -- price - float
    )
GO
UPDATE dbo.Food SET name = N'', idCategory = 5 , price = 0 WHERE id =4
GO

CREATE TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS
BEGIN
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
    SELECT @idBillInfo = id, @idBill = Deleted.idBill FROM Deleted

	DECLARE @idTable int
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
    
	DECLARE @count  INT = 0
	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0
	IF(@count = 0)
		UPDATE dbo.TableFood SET  status = N'Trống' WHERE id = @idTable
END
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
SELECT * FROM dbo.Food WHERE dbo.fuConvertToUnsign1(name)  LIKE N'%' + dbo.fuConvertToUnsign1(N'muc') + '%'
GO

SELECT * FROM dbo.Account
GO

SELECT TOP 2 * FROM dbo.Bill
GO

SELECT TOP 7 * FROM dbo.Bill
EXCEPT
SELECT TOP 5 * FROM dbo.Bill
GO

SELECT * FROM dbo.Bill
GO

CREATE PROC USP_GetNumBillByDate
@checkIn date, @checkOut date
AS
BEGIN
	SELECT COUNT(*)
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO

SELECT COUNT(*) FROM dbo.Bill
GO

create PROC USP_GetListBillByDateForReport
@checkIn date, @checkOut date
AS
BEGIN
	SELECT DISTINCT t.name , discount , b.totalPrice ,DateCheckIn , DateCheckOut
	FROM dbo.Bill AS b, dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1
	AND t.id = b.idTable
END
GO

select * from bill
GO

create Proc USP_GetTotalByDate
@checkIn date, @checkOut date
AS
BEGIN
	SELECT sum(totalPrice)
	FROM dbo.Bill
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut
END
GO

Exec USP_GetTotalByDate @checkIn = '2018-04-01', -- date
                        @checkOut = '2018-04-30' -- date

select sum(totalPrice) from Bill where DateCheckIn >= '2018-04-01' and DateCheckOut <= '2018-04-30'
GO

select * from account
GO

select * from FoodCategory
GO


select * from dbo.BillInfo
GO

select * from dbo.Bill
GO

select * from tablefood
GO

insert tablefood
VALUES
(   N'Bàn 21', -- name - nvarchar(100)
    N'Trống'
    )
GO

delete dbo.TableFood where id = 1
GO

create proc USP_DeleteTable
@idTable int
as
begin
	delete from dbo.TableFood where id = @idTable and status = N'Trống'
end 
go

exec USP_DeleteTable 2

ALTER proc [dbo].[USP_InserTableFood]
@name nvarchar(100)
as
begin
	DECLARE @id int
	insert dbo.FoodCategory values (@name)
	select @id = dbo.FoodCategory.id from dbo.FoodCategory where name=@name
	insert dbo.Food values (N'Chưa có món',@id,0)
end


select * from food
select * from FoodCategory

exec USP_InserTableFood N'Món mới update nè'

ALTER proc [dbo].[USP_DeleteFoodCategory]
@idfood int
as
begin
	declare @idtable int
	DECLARE @count int
	declare @id int
	select  @id = fc.id, @count = count(*)
	from dbo.FoodCategory as fc inner join dbo.Food as fo on fc.id=fo.idCategory inner join dbo.BillInfo as bi on fo.id = bi.idFood
	inner join dbo.Bill as b on b.id = bi.idBill inner join dbo.TableFood as tf on tf.id = b.idTable
	where b.status = 1 and fc.id = @idfood and 
	group by fc.id
	if(@count > 0)
		print 'không được xóa'
		
	if(@count = 0)
		print 'được xóa'
		--delete from dbo.FoodCategory where id = @idfood
end
GO
select fc.id , count(*)
	from dbo.FoodCategory as fc inner join dbo.Food as fo on fc.id=fo.idCategory inner join dbo.BillInfo as bi on fo.id = bi.idFood
	inner join dbo.Bill as b on b.id = bi.idBill inner join dbo.TableFood as tf on tf.id = b.idTable
	where b.status = 1 and fc.id = 17 and tf.status = N'Trống'
	group by fc.id

select * from food
select * from FoodCategory
select * from bill
select * from billinfo

select * from account

exec USP_DeleteFoodCategory 17

select * from dbo.TableFood
GO

create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as
begin
	select * from dbo.Account where UserName = @userName and PassWord = @passWord
end
go
