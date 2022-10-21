use SalesApp

insert into Item
values(0,'Laptop','Gaming',25,'Asus','10/10/2019',20,null,'.\\Image\\ImageItem\\luffy.jpg')
insert into Item
values(1,'Laptop','Gaming',25,'Asus','10/10/2019',20,null,'.\\Image\\ImageItem\\luffy.jpg')
insert into Item
values(2,'Laptop','Gaming',25,'Asus','10/10/2019',20,null,'.\\Image\\ImageItem\\luffy.jpg')
insert into Item
values(3,'Laptop','Gaming',25,'Asus','10/10/2019',20,null,'.\\Image\\ImageItem\\luffy.jpg')
insert into Item
values(4,'Laptop','Gaming',25,'Asus','10/10/2019',20,null,'.\\Image\\ImageItem\\luffy.jpg')
insert into Item
values(5,'Laptop','Gaming',25,'Asus','10/10/2019',20,null,'.\\Image\\ImageItem\\luffy.jpg')


insert into Discount
values(0,'KM1','10/10/2020','12/10/2020','Hàng tháng',10,30)
insert into Discount
values(1,'KM1','10/10/2020','12/10/2020','Hàng tháng',10,30)
insert into Discount
values(2,'KM1','10/10/2020','12/10/2020','Hàng tháng',10,30)
insert into Discount
values(3,'KM1','10/10/2020','12/10/2020','Hàng tháng',10,30)
insert into Discount
values(4,'KM1','10/10/2020','12/10/2020','Hàng tháng',10,30)
insert into Discount
values(5,'KM1','10/10/2020','12/10/2020','Hàng tháng',10,30)


insert into Customer
values('0123654789123','Nguyễn Thị Thu Hằng','11/16/2002','Thái Nguyên','0978123456','Khách mua lẻ',1090,'10/10/2020','trungdung@xmail.com','.\\Image\\ImageCustomer\\Hang.jpg');
insert into Customer
values('1123654789123','Nguyễn Thị Thu Hằng','11/16/2002','Thái Nguyên','0978123456','Khách mua lẻ',1090,'10/10/2020','trungdung@xmail.com','.\\Image\\ImageCustomer\\Hang.jpg');
insert into Customer
values('2123654789123','Nguyễn Thị Thu Hằng','11/16/2002','Thái Nguyên','0978123456','Khách mua lẻ',1090,'10/10/2020','trungdung@xmail.com','.\\Image\\ImageCustomer\\Hang.jpg');
insert into Customer
values('3123654789123','Nguyễn Thị Thu Hằng','11/16/2002','Thái Nguyên','0978123456','Khách mua lẻ',1090,'10/10/2020','trungdung@xmail.com','.\\Image\\ImageCustomer\\Hang.jpg');
insert into Customer
values('4123654789123','Nguyễn Thị Thu Hằng','11/16/2002','Thái Nguyên','0978123456','Khách mua lẻ',1090,'10/10/2020','trungdung@xmail.com','.\\Image\\ImageCustomer\\Hang.jpg');
insert into Customer
values('5123654789123','Nguyễn Thị Thu Hằng','11/16/2002','Thái Nguyên','0978123456','Khách mua lẻ',1090,'10/10/2020','trungdung@xmail.com','.\\Image\\ImageCustomer\\Hang.jpg');


insert into Bill
values(0,'0123654789123','Nguyễn Minh Hoàng','10/10/2020',5,230,30,200,'Đang xử lý')
insert into Bill
values(1,'1123654789123','Nguyễn Minh Hoàng','10/10/2020',5,230,30,200,'Đang xử lý')
insert into Bill
values(2,'2123654789123','Nguyễn Minh Hoàng','10/10/2020',5,230,30,200,'Đang xử lý')
insert into Bill
values(3,'3123654789123','Nguyễn Minh Hoàng','10/10/2020',5,230,30,200,'Đang xử lý')
insert into Bill
values(4,'4123654789123','Nguyễn Minh Hoàng','10/10/2020',5,230,30,200,'Đang xử lý')
insert into Bill
values(5,'5123654789123','Nguyễn Minh Hoàng','10/10/2020',5,230,30,200,'Đang xử lý')


insert into BillDetail
values(0,0,'LapTop',5,100,50,123)
insert into BillDetail
values(1,1,'LapTop',5,100,50,123)
insert into BillDetail
values(2,2,'LapTop',5,100,50,123)
insert into BillDetail
values(3,3,'LapTop',5,100,50,123)
insert into BillDetail
values(4,4,'LapTop',5,100,50,123)
insert into BillDetail
values(5,5,'LapTop',5,100,50,123)

delete from Bill
delete from BillDetail

alter table Bill
alter column TotalAmount int