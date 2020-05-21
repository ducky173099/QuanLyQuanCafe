Thêm vào bảng FoodCategory

Insert FoodCategory Values (N'Cafe')
Insert FoodCategory Values (N'Hoa Quả')
Insert FoodCategory Values (N'Trà Sữa')
Insert FoodCategory Values (N'Pudding')
Insert FoodCategory Values (N'Đồ Ăn Nhanh')
Insert FoodCategory Values (N'Nước Ép Hoa Quả')

Select * from FoodCategory

Thêm vào bảng Food

Insert Food Values(N'Cafe Nâu đá', 1, 25000)
Insert Food Values(N'Cafe Sữa ', 1, 20000)
Insert Food Values(N'Cafe Capuchino', 1, 27000)
Insert Food Values(N'Cafe Đen', 1, 23000)

Insert Food Values(N'Táo', 2, 20000)
Insert Food Values(N'Can', 2, 22000)
Insert Food Values(N'Xoài dầm', 2, 15000)
Insert Food Values(N'Thanh Long', 2, 20000)

Insert Food Values(N'Trà Sữa Đường Đen', 3, 25000)
Insert Food Values(N'Trà Sữa Việt Quất', 3, 22000)
Insert Food Values(N'Trà Sữa 3 Anh Em', 3, 25000)
Insert Food Values(N'Trà Sữa Hoa Quả', 3, 20000)

Select * from Food

/* Từ bảng này chở đi là dữ liệu Test */

Thêm dữ liệu vào bảng Bill

Insert Bill values(GETDATE(),GETDATE(), 1, 0)
Insert Bill values(GETDATE(),GETDATE(), 2, 1)
Insert Bill values(GETDATE(),GETDATE(), 3, 0)

Select * from Bill

Thêm dữ liệu vào bảng Bill Info

Insert BillInfo values(1,2,4)
Insert BillInfo values(2,1,3)
Insert BillInfo values(3,4,1)

Select * from BillInfo
Select * from TableFood


// Phần này không cần quan tâm ^^
Select * from Bill Where idTable = 3 And status = 0

Select * from BillInfo where idBill = 3

Select f.name, bi.count, f.price, f.price*bi.count as totalPrice from BillInfo As bi, Bill as b, Food as f 
where bi.idBill = b.id And bi.idFood = f.id And b.idTable = 3