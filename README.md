>
> Thực hiện: **Huỳnh Tấn Chương**
>
> Cập nhật lần cuối: **dd/MM/yyyy**

# Bài tập Hướng đối tượng bằng ngôn ngữ C#
### Mực lục
[1. Bài 1 - Quản lý cán bộ](#1)

[8. Bài 8 - Quản lý việc mượn, trả sách](#8)

[9. Bài 9 - Quản lý biên lai thu tiền điện](#9)

<a name="1"></a>
### Bài 1
Một đơn vị sản xuất gồm có các cán bộ là công nhân, kỹ sư, nhân viên. Mỗi cán bộ cần quản lý các dữ liệu: Họ tên, tuổi, giới tính(name, nữ, khác), địa chỉ.

Cấp công nhân sẽ có thêm các thuộc tính riêng: Bậc (1 đến 10).
Cấp kỹ sư có thuộc tính riêng: Nghành đào tạo.
Các nhân viên có thuộc tính riêng: công việc.

- Yêu cầu 1: Xây dựng các lớp CongNhan, KySu, NhanVien kế thừa từ lớp CanBo.

- Yêu cầu 2: Xây dựng lớp QLCB(quản lý cán bộ) cài đặt các phương thức thực hiện các chức năng sau:

* Thêm mới cán bộ.
* Tìm kiếm theo họ tên.
* Hiện thị thông tin về danh sách các cán bộ.
* Thoát khỏi chương trình.

<a name="8"></a>
### Bài 8
Thư viện trung tâm đại học quốc gia có nhu cầu quản lý việc mượn, trả sách. Sinh viên đăng ký tham gia mượn sách thông qua thẻ mà thư viện cung cấp.
Với mỗi thẻ sẽ lưu các thông tin sau: Mã phiếu mượn, ngày mượn, hạn trả, số hiệu sách, và các thông tin cá nhân của sinh viên mượn sách. Các thông tin của sinh viên mượn sách bao gồm: Họ tên, tuổi, lớp.
Để đơn giản cho ứng dụng console. Chúng ta mặc định ngày mượn, ngày trả là số nguyên dương.

- Yêu cầu 1: Xây dựng lớp SinhVien để quản lý thông tin của mỗi sinh viên.

- Yêu cầu 2: Xây dựng lớp TheMuon để quản lý việc mượn trả sách của các sinh viên.

- Yêu cầu 3: Xây dựng các phương thức: 

 * Thêm thẻ mượn
 * Xoá theo mã phiếu mượn
 * Hiển thị thông tin các thẻ mượn

<a name="9"></a>
### Bài 9
Để quản lý biên lai thu tiền điện, người ta cần các thông tin sau:

Với mỗi biên lai: Thông tin về hộ sử dụng điện, chỉ số điện cũ, chỉ số mới, số tiền phải trả.
Các thông tin riêng của từng hộ gia đình sử dụng điện: Họ tên chủ hộ, số nhà, mã số công tơ điện.

- Yêu cầu 1: Hãy xây dựng lớp khachHang để lưu trữu các thông tin riêng của mỗi hộ gia đình.

- Yêu cầu 2: Xây dựng lớp BienLai để quản lý việc sử dụng và thanh toán tiền điện của các hộ dân.

- Yêu cầu 3: Xây dựng các phương thức thêm, xoá sửa các thông tin riêng của mỗi hộ sử dụng điện.

- Yêu cầu 4: Viết phương thức tính tiền điện cho mỗi hộ gia đình theo công thức: (số mới - số cũ ) * 5