# DWH_simple
## dữ liệu hình thành DWH
![image](https://user-images.githubusercontent.com/66502497/181421759-4242b9f9-dc2d-4b2a-87b0-b5b8f5eb4468.png)

## Thiết kế DB mới tổ chức phân tích Kho dữ liệu cho phân hệ

 Factor thống kê
- EmployeeID,ProductID,day
- DoanhThu =  SUM(order.quantity*oder.UnitPrice*(1-oder.Discount)).
- DoanhSo =  SUM(order.quatity)

![image](https://user-images.githubusercontent.com/66502497/181421855-6f90f102-e5ae-4a4c-a9ca-d4245649da4d.png)

## trực quang dữ liệu
![image](https://user-images.githubusercontent.com/66502497/181422036-d3392e27-d418-4553-b519-6fe3bb88b296.png)
![image](https://user-images.githubusercontent.com/66502497/181422053-a6cc043d-0c15-44c7-a6d2-142f5afb454e.png)

