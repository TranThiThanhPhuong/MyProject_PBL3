create database CoffeeManagement
go

use CoffeeManagement
go

create table TableCoffee
(
	ID int identity primary key,
	Name nvarchar(100) not null default N'Chưa đặt tên',
	Status nvarchar(100) not null default N'Trống'
)

create table AccountType
(
	ID int identity primary key,
	TypeName nvarchar(50) not null
)
go

alter table Account
(
	UserName varchar(100) primary key,
	DisplayName nvarchar(100) not null default N'Name',
	Password varchar(500) not null default '5feceb66ffc86f38d952786c6d696c79c2dbc239dd4e91b46729d73a27fb57e9',
	TypeID int not null

	foreign key (TypeID) references AccountType(ID)
)
go
ALTER TABLE Account
ADD Password varchar(500) NOT NULL DEFAULT '5feceb66ffc86f38d952786c6d696c79c2dbc239dd4e91b46729d73a27fb57e9';

create table CategoryFood
(
	ID int identity not null primary key,
	Name nvarchar(100) not null default N'Chưa đặt tên'
)
go

create table Food
(
	ID int identity primary key,
	Name nvarchar(100) not null default N'Chưa đặt tên',
	CategoryID int not null,
	Price int not null default 0

	foreign key (CategoryID) references CategoryFood(id)
)
go

create table Bill
(
	ID int identity primary key,
	CheckIn Date not null default GETDATE(),
	CheckOut Date,
	TableID int not null,
	Discount int not null default 0,
	TotalPrice int default 0,
	Status int not null default 0 -- 1: Da thanh toan, 0: Chua thanh toan

	foreign key (TableID) references TableCoffee(ID)
)
go

create table BillInfo
(
	ID int identity primary key,
	BillID int not null,
	FoodID int not null,
	Amount int not null default 0

	foreign key (BillID) references Bill(ID),
	foreign key (FoodID) references Food(ID)
)
go

insert AccountType (TypeName) values (N'Quản lý')
insert AccountType (TypeName) values (N'Nhân viên')

insert into Account (UserName, DisplayName, Password, TypeID)
values ('admin', 'Quản lý', 'admin', 1)
go

insert into Account(UserName, DisplayName, Password, TypeID)
values ('nhanh', 'Nhân viên (Tài Nhanh)' ,'12345', 2)
go

insert into Account(UserName, DisplayName, Password, TypeID)
values ('anh', 'Nhân viên (Trúc Anh)' ,'12345', 2)
go

insert into Account(UserName, DisplayName, Password, TypeID)
values ('tan', 'Nhân viên (Minh Tân)' ,'12345', 2)
go

-- add information into TableCoffee
declare @i int = 1
while @i <= 30
begin
	insert into TableCoffee(Name)
	values (N'Bàn ' + CAST(@i as nvarchar(100)))
	set @i = @i + 1
end
go
select * from BAN
-- add information into Category
insert into CategoryFood (Name) values (N'Cà phê')
insert into CategoryFood (Name) values (N'Ăn vặt')
insert into CategoryFood (Name) values (N'Thức uống khác')
insert into CategoryFood (Name) values (N'Nước ép trái cây')
insert into CategoryFood (Name) values (N'Trà sữa')
go

-- add information into Food
insert into Food (Name, CategoryID, Price) values (N'Cà phê đá', 1, 10000)
insert into Food (Name, CategoryID, Price) values (N'Cà phê sữa', 1, 12000)
insert into Food (Name, CategoryID, Price) values (N'Cà phê fin (đen)', 1, 8000)
insert into Food (Name, CategoryID, Price) values (N'Cà phê fin (sữa)', 1, 10000)
insert into Food (Name, CategoryID, Price) values (N'Mì cay', 2, 25000)
insert into Food (Name, CategoryID, Price) values (N'Sushi', 2, 15000)
insert into Food (Name, CategoryID, Price) values (N'Bò viên chiên', 2, 10000)
insert into Food (Name, CategoryID, Price) values (N'Xúc xích chiên', 2, 10000)
insert into Food (Name, CategoryID, Price) values (N'Ốc nhồi chiên', 2, 12000)
insert into Food (Name, CategoryID, Price) values (N'Há cảo chiên', 2, 15000)
insert into Food (Name, CategoryID, Price) values (N'7up', 3, 16000)
insert into Food (Name, CategoryID, Price) values (N'Sữa tươi', 3, 16000)
insert into Food (Name, CategoryID, Price) values (N'Sinh tố cam', 4, 14000)
insert into Food (Name, CategoryID, Price) values (N'Sinh tố dâu', 4, 10000)
insert into Food (Name, CategoryID, Price) values (N'Trà sữa truyền thống', 5, 18000)
insert into Food (Name, CategoryID, Price) values (N'Trà sữa Chocolate', 5, 22000)
insert into Food (Name, CategoryID, Price) values (N'Trà sữa Matcha', 5, 20000)
insert into Food (Name, CategoryID, Price) values (N'Trà sữa Việt quất', 5, 24000)
insert into Food (Name, CategoryID, Price) values (N'Capuchino', 5, 25000)
insert into Food (Name, CategoryID, Price) values (N'Macchiato', 5, 25000)
go

-- add information into Bill
insert into Bill (CheckIn, TableID) values (GETDATE(), 1)
insert into Bill (CheckIn, TableID) values (GETDATE(), 2)
insert into Bill (CheckIn, TableID) values (GETDATE(), 3)
go

-- add information into BillInfo
insert into BillInfo (BillID, FoodID, Amount) values (1, 1, 2)
insert into BillInfo (BillID, FoodID, Amount) values (1, 3, 3)
insert into BillInfo (BillID, FoodID, Amount) values (2, 2, 1)
insert into BillInfo (BillID, FoodID, Amount) values (3, 5, 1)
insert into BillInfo (BillID, FoodID, Amount) values (2, 4, 2)
GO

-- Account's procedure
CREATE PROC dbo.USP_Login
@UserName NVARCHAR(100), @Password NVARCHAR(100)
AS
	SELECT *
	FROM dbo.Account
	WHERE UserName = @UserName AND Password = @Password
GO

CREATE PROC USP_GetAccountByUserName
@UserName VARCHAR(100)
AS
	SELECT *
	FROM dbo.Account
	WHERE UserName = @UserName
GO

create PROC USP_GetAllAccount
AS
	SELECT UserName, DisplayName, TypeID, Password FROM dbo.Account
GO

CREATE PROC USP_InsertAccount
@UserName VARCHAR(100), @DisplayName NVARCHAR(100), @TypeID INT
AS
	INSERT dbo.Account ( UserName, DisplayName, TypeID )
	VALUES  ( @UserName, @DisplayName, @TypeID )
GO
--CREATE PROC USP_InsertAccount2
--@UserName VARCHAR(100), @DisplayName NVARCHAR(100), @TypeID INT, @PassWord int
--AS
--	INSERT dbo.Account ( UserName, DisplayName, TypeID, PassWord )
--	VALUES  ( @UserName, @DisplayName, @TypeID, @PassWord )
--GO
create PROC USP_ResetPassword
@UserName VARCHAR(100)
AS
	UPDATE dbo.Account SET Password = '5feceb66ffc86f38d952786c6d696c79c2dbc239dd4e91b46729d73a27fb57e9' WHERE UserName = @UserName
GO

CREATE PROC USP_UpdateAccount
@UserName VARCHAR(100), @DisplayName NVARCHAR(100), @Password VARCHAR(100), @NewPassword VARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM Account WHERE UserName = @UserName and Password = @Password
	IF (@isRightPass = 1)
	BEGIN
		IF (@NewPassword = null or @NewPassword = '')
			UPDATE Account SET DisplayName = @DisplayName WHERE UserName = @UserName
		ELSE
			UPDATE Account SET DisplayName = @DisplayName, Password = @NewPassword WHERE UserName = @UserName
	END
END
GO

CREATE PROC USP_DeleteAccount
@UserName VARCHAR(100)
AS
	DELETE dbo.Account WHERE UserName = @UserName
GO

CREATE PROC USP_SearchAccountByUserName
@UserName VARCHAR(100)
AS
	SELECT * FROM dbo.Account WHERE dbo.fuConvertToUnsign1(UserName) LIKE N'%' + dbo.fuConvertToUnsign1(@UserName) + '%'
GO
-- end Account's procedure

-- Food's procedure
CREATE PROC USP_GetAllFood
AS
	SELECT * FROM dbo.Food
GO

CREATE PROC USP_GetListFoodByCategoryID
@CategoryID INT
AS
	SELECT ID, Name, Price FROM dbo.Food WHERE CategoryID = @CategoryID
GO

CREATE PROC USP_InsertFood
@Name NVARCHAR(100), @CategoryID INT, @Price INT
AS
	INSERT dbo.Food( Name, CategoryID, Price )
	VALUES  ( @Name, @CategoryID, @Price )
GO

CREATE PROC USP_UpdateFood
@ID INT, @Name NVARCHAR(100), @CategoryID INT, @Price INT
AS
	DECLARE @BillIDCount INT = 0
	SELECT @BillIDCount = COUNT(*) FROM Bill AS b, BillInfo AS bi WHERE FoodID = @ID AND b.ID = bi.BillID AND b.Status = 0

	IF (@BillIDCount = 0)
		UPDATE dbo.Food SET Name = @Name, CategoryID = @CategoryID, Price = @Price WHERE ID = @ID
GO

CREATE PROC USP_DeleteFood
@FoodID INT
AS
BEGIN
	DECLARE @BillIDCount INT = 0
	SELECT @BillIDCount = COUNT(*) FROM Bill AS b, BillInfo AS bi WHERE FoodID = @FoodID AND b.ID = bi.BillID AND b.Status = 0

	IF (@BillIDCount = 0)
	BEGIN
		DELETE BillInfo WHERE FoodID = @FoodID
		DELETE Food WHERE ID = @FoodID
	END
END
GO

CREATE PROC USP_SearchFoodByName
@Name NVARCHAR(100)
AS
	SELECT * FROM dbo.Food WHERE dbo.fuConvertToUnsign1(Name) LIKE N'%' + dbo.fuConvertToUnsign1(@Name) + '%'
GO
-- end Food's procedure

-- Bill's procedure
CREATE PROC USP_InsertBill
@TableID INT
AS
	INSERT dbo.Bill (CheckIn, TableID, status, discount) VALUES (GETDATE(), @TableID, 0, 0)
GO

CREATE PROC GetUnCheckBillIDByTableID
@TableID INT
AS
	SELECT * FROM dbo.Bill WHERE TableID = @TableID AND Status = 0
GO
CREATE PROC GetUnCheckBillIDByTableID2
@ID INT
AS
	SELECT * FROM dbo.Bill WHERE ID = @ID 
GO
CREATE PROC USP_GetListBillByDay
@FromDate DATE, @ToDate DATE
AS
BEGIN
	SELECT b.ID, t.Name, CheckIn, discount, TotalPrice
	FROM Bill AS b, TableCoffee AS t
	WHERE CheckIn >= @FromDate AND CheckIn <= @ToDate AND b.status = 1 AND t.ID = b.TableID
END
GO
create PROC USP_GetListBillByBillID
@BillID int
AS
BEGIN
	SELECT f.Name AS FoodName, bi.Amount, f.Price, (f.Price * bi.Amount) AS TotalPrice
	FROM Bill AS b
	JOIN BillInfo AS bi ON b.ID = bi.BillID
	JOIN Food AS f ON f.ID = bi.FoodID
	WHERE b.ID = @BillID;
END;
GO

CREATE PROC USP_DeleteBill
@ID INT
AS
	DELETE dbo.Bill WHERE ID = @ID
GO

CREATE PROC USP_CheckOut
@ID INT, @Discount INT, @TotalPrice INT
AS
	UPDATE dbo.Bill SET Status = 1, Discount = @Discount, TotalPrice = @TotalPrice WHERE ID = @ID
GO

CREATE PROC USP_GetMaxBillID
AS
	SELECT MAX(ID) FROM dbo.Bill
GO
-- end Bill's procedure

-- Bill Info's procedure
CREATE PROC USP_InsertBillInfo
@BillID int, @FoodID int, @Amount int
as
begin
	declare @isExistBillInfo int
	declare @foodAmount int = 1

	select @isExistBillInfo = ID, @foodAmount = Amount
	from BillInfo
	where BillID = @BillID and FoodID = @FoodID

	if (@isExistBillInfo > 0)
	begin
		declare @newAmount int = @foodAmount + @Amount
		if (@newAmount > 0)
			update BillInfo set Amount = @newAmount where FoodID = @FoodID
		ELSE IF (@newAmount <= 0)
			delete BillInfo where BillID = @BillID and FoodID = @FoodID
	end
	else
		IF (@Amount > 0)
			INSERT into BillInfo (BillID, FoodID, Amount) values (@BillID, @FoodID, @Amount)
end
GO

CREATE PROC USP_DeleteBillInfoByBillID
@BillID INT
AS
	DELETE dbo.BillInfo WHERE BillID = @BillID
GO
-- end Bill's procedure
create trigger UTG_UpdateBillInfo
on BillInfo for insert
as
begin
	declare @billID int
	select @billID = BillID from inserted

	declare @tableID int
	select @tableID = TableID from Bill where ID = @billID and status = 0

	declare @count int
	select @count = COUNT(*) from BillInfo where BillID = @billID

	if (@count > 0)
		update TableCoffee set Status = N'Có người' where ID = @tableID
	else
		update TableCoffee set Status = N'Trống' where ID = @tableID
end
go

CREATE TRIGGER UTG_UpdateBill
on Bill for update
as
begin
	declare @billID int
	select @billID = ID from inserted
	declare @tableID int
	select @tableID = TableID from Bill where ID = @billID
	declare @amount int = 0
	select @amount = COUNT(*) from Bill where TableID = @tableID and Status = 0
	if (@amount = 0)
		update TableCoffee set Status = N'Trống' where ID = @tableID
end
GO

create trigger UTG_DeleteBillInfo
on BillInfo for delete
as
begin
	declare @IDBillInfo int
	declare @BillID int
	select @IDBillInfo = id, @BillID = BillID from deleted

	declare @TableID int
	select @TableID = TableID from Bill where ID = @BillID

	declare @count int = 0
	select @count = COUNT(*) from BillInfo as bi, Bill as b where b.ID = bi.BillID and b.ID = @BillID and b.status = 0

	if (@count = 0)
		update TableCoffee set Status = N'Trống' where ID = @TableID
end
go
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000)
AS
BEGIN
	IF @strInput IS NULL RETURN @strInput
	IF @strInput = '' RETURN @strInput

	DECLARE @RT NVARCHAR(4000)
	DECLARE @SIGN_CHARS NCHAR(136)
	DECLARE @UNSIGN_CHARS NCHAR (136)

	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272)+ NCHAR(208)
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
	
	DECLARE @COUNTER int
	DECLARE @COUNTER1 int
	SET @COUNTER = 1

	WHILE (@COUNTER <= LEN(@strInput))
	BEGIN
		SET @COUNTER1 = 1
		WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
			BEGIN
				IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
				BEGIN
					IF @COUNTER=1
						SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)
					ELSE
						SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)
					BREAK
				END
					SET @COUNTER1 = @COUNTER1 +1
			END
			SET @COUNTER = @COUNTER +1
	END
	SET @strInput = replace(@strInput,' ','-')
	RETURN @strInput
END
GO

create proc USP_GetListBillByDayForReport
@FromDate Date, @ToDate Date
as
begin
	select t.Name, CheckIn, Discount, TotalPrice
	from Bill as b, TableCoffee as t
	where CheckIn >= @FromDate and CheckIn <= @ToDate and b.status = 1 and t.ID = b.TableID
end
go

create proc USP_DeleteCategory
@ID int
as
begin
	declare @FoodCount int = 0
	select @FoodCount = COUNT(*) from Food where CategoryID = @ID

	if (@FoodCount = 0)
		delete CategoryFood where ID = @ID
end
go

-- TableFood's procedure
create proc USP_DeleteTableFood
@ID int
as begin
	declare @count int = 0
	select @count = COUNT(*) from TableCoffee where ID = @ID and Status = N'Trống'

	if (@count <> 0)
	begin
		declare @BillID int
		select @BillID = b.ID from Bill as b, TableCoffee as t where b.TableID = t.ID

		delete BillInfo where BillID = @BillID
		delete Bill where ID = @BillID
		delete TableCoffee where ID = @ID
	end
end
GO

--CREATE PROC USP_SwitchTable
--@TableID1 INT, @TableID2 INT
--AS
--BEGIN
--	DECLARE @isTable1Null INT = 0
--	DECLARE @isTable2Null INT = 0
--	SELECT @isTable1Null = ID FROM dbo.Bill WHERE TableID = @TableID1 AND Status = 0
--	SELECT @isTable2Null = ID FROM dbo.Bill WHERE TableID = @TableID2 AND Status = 0

--	IF (@isTable1Null = 0 AND @isTable2Null > 0)
--		BEGIN
--			UPDATE dbo.Bill SET TableID = @TableID1 WHERE ID = @isTable2Null
--			UPDATE dbo.TableCoffee SET Status = N'Có người' WHERE ID = @TableID1
--			UPDATE dbo.TableCoffee SET Status = N'Trống' WHERE ID = @TableID2
--        END
--	ELSE IF (@isTable1Null > 0 AND @isTable2Null = 0)
--		BEGIN
--			UPDATE dbo.Bill SET TableID = @TableID2 WHERE Status = 0 AND ID = @isTable1Null
--			UPDATE dbo.TableCoffee SET Status = N'Có người' WHERE ID = @TableID2
--			UPDATE dbo.TableCoffee SET Status = N'Trống' WHERE ID = @TableID1
--        END
--    ELSE IF (@isTable1Null > 0 AND @isTable2Null > 0)
--		BEGIN
--			UPDATE dbo.Bill SET TableID = @TableID2 WHERE ID = @isTable1Null
--			UPDATE dbo.Bill SET TableID = @TableID1 WHERE ID = @isTable2Null
--        END
--END
--GO

CREATE PROC USP_GetAllTable
AS
	SELECT ID, Name FROM dbo.TableCoffee
GO

CREATE PROC USP_GetListTable
AS
	SELECT * FROM dbo.TableCoffee
GO

CREATE PROC USP_InsertTable
@Name NVARCHAR(100)
AS
	INSERT dbo.TableCoffee ( Name )
	VALUES  ( @Name )
GO

CREATE PROC USP_UpdateTable
@ID INT, @Name NVARCHAR(100)
AS
	UPDATE dbo.TableCoffee SET Name = @Name WHERE ID = @ID
GO
-- end TableCoffee's procedure

CREATE PROC USP_GetListTempBillByTableID
@TableID INT
AS
	SELECT f.Name, bi.Amount, f.Price, f.Price * bi.Amount AS totalPrice
	FROM dbo.BillInfo bi, dbo.Bill b, dbo.Food f
	WHERE b.ID = bi.BillID AND bi.FoodID = f.ID AND b.Status = 0 AND b.TableID = @TableID
GO

--CREATE PROC USP_MergeTable
--@TableID1 INT, @TableID2 INT
--AS
--	BEGIN
--		DECLARE @UnCheckBillID1 INT = -1
--		DECLARE @UnCheckBillID2 INT = -1
--		SELECT @UnCheckBillID1 = ID FROM dbo.Bill WHERE TableID = @TableID1 AND Status = 0
--		SELECT @UnCheckBillID2 = ID FROM dbo.Bill WHERE TableID = @TableID2 AND Status = 0

--		IF (@UnCheckBillID1 != -1 AND @UnCheckBillID2 != -1)
--			BEGIN
--				DECLARE @BillInfoID INT
--				SELECT @BillInfoID = ID FROM dbo.BillInfo WHERE BillID = @UnCheckBillID1

--				UPDATE dbo.BillInfo SET BillID = @UnCheckBillID2 WHERE ID = @BillInfoID
--				DELETE dbo.Bill WHERE ID = @UnCheckBillID1

--				UPDATE dbo.TableCoffee SET STATUS = N'Trống' WHERE ID = @TableID1
--			END
--    END
--GO
create PROC USP_SwitchTable2
@TableID1 INT, @TableID2 INT
AS
BEGIN
    DECLARE @isTable1BillID INT = 0
    DECLARE @isTable2BillID INT = 0
    SELECT @isTable1BillID = ID FROM dbo.Bill WHERE TableID = @TableID1 AND Status = 0
    SELECT @isTable2BillID = ID FROM dbo.Bill WHERE TableID = @TableID2 AND Status = 0

    IF (@isTable1BillID > 0 AND @isTable2BillID > 0)
    BEGIN
        -- Gộp các món ăn từ hóa đơn của TableID1 vào TableID2
        UPDATE bi2
        SET bi2.Amount = bi2.Amount + ISNULL(bi1.Amount, 0)
        FROM dbo.BillInfo bi2
        INNER JOIN dbo.BillInfo bi1 ON bi2.FoodID = bi1.FoodID
        WHERE bi2.BillID = @isTable2BillID AND bi1.BillID = @isTable1BillID

        -- Chuyển các món ăn không trùng từ hóa đơn của TableID1 sang hóa đơn của TableID2
        INSERT INTO dbo.BillInfo (BillID, FoodID, Amount)
        SELECT @isTable2BillID, bi1.FoodID, bi1.Amount
        FROM dbo.BillInfo bi1
        LEFT JOIN dbo.BillInfo bi2 ON bi2.FoodID = bi1.FoodID AND bi2.BillID = @isTable2BillID
        WHERE bi2.BillID IS NULL AND bi1.BillID = @isTable1BillID

        -- Xóa hóa đơn của TableID1
        DELETE FROM dbo.BillInfo WHERE BillID = @isTable1BillID
        DELETE FROM dbo.Bill WHERE ID = @isTable1BillID

        -- Cập nhật trạng thái bàn
        UPDATE dbo.TableCoffee SET Status = N'Có người' WHERE ID = @TableID2
        UPDATE dbo.TableCoffee SET Status = N'Trống' WHERE ID = @TableID1
    END
    ELSE IF (@isTable1BillID > 0 AND @isTable2BillID = 0)
    BEGIN
        -- Chuyển hóa đơn từ TableID1 sang TableID2
        UPDATE dbo.Bill SET TableID = @TableID2 WHERE ID = @isTable1BillID
        -- Cập nhật trạng thái bàn
        UPDATE dbo.TableCoffee SET Status = N'Có người' WHERE ID = @TableID2
        UPDATE dbo.TableCoffee SET Status = N'Trống' WHERE ID = @TableID1
    END
    ELSE IF (@isTable1BillID = 0 AND @isTable2BillID > 0)
    BEGIN
        -- Chuyển hóa đơn từ TableID2 sang TableID1
        UPDATE dbo.Bill SET TableID = @TableID1 WHERE ID = @isTable2BillID
        -- Cập nhật trạng thái bàn
        UPDATE dbo.TableCoffee SET Status = N'Có người' WHERE ID = @TableID1
        UPDATE dbo.TableCoffee SET Status = N'Trống' WHERE ID = @TableID2
    END
END
GO
