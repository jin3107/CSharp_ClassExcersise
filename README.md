>
> Thực hiện: **Huỳnh Tấn Chương**
>
> Cập nhật lần cuối: **01/01/2025**

# Bài tập Hướng đối tượng bằng ngôn ngữ C#
### Mực lục
[1. Bài 1 - Quản lý cán bộ](#1)

[2. Bài 2 - Quản lý sách](#2)

[3. Bài 3 - Quản lý tuyển sinh](#3)

[8. Bài 8 - Quản lý việc mượn, trả sách](#8)

[9. Bài 9 - Quản lý biên lai thu tiền điện](#9)

<a name="1"></a>
### Bài 1
Một đơn vị sản xuất gồm có các cán bộ là công nhân, kỹ sư, nhân viên. Mỗi cán bộ cần quản lý các dữ liệu: Họ tên, tuổi, giới tính(name, nữ, khác), địa chỉ.

Cấp công nhân sẽ có thêm các thuộc tính riêng: Bậc (1 đến 10).
Cấp kỹ sư có thuộc tính riêng: Nghành đào tạo.
Các nhân viên có thuộc tính riêng: công việc.

Yêu cầu 1: Xây dựng các lớp CongNhan, KySu, NhanVien kế thừa từ lớp CanBo.

Yêu cầu 2: Xây dựng lớp QLCB(quản lý cán bộ) cài đặt các phương thức thực hiện các chức năng sau:

* Thêm mới cán bộ.
* Tìm kiếm theo họ tên.
* Hiện thị thông tin về danh sách các cán bộ.
* Thoát khỏi chương trình.

<a name="2"></a>
### Bài 2
Một thư viện cần quản lý các tài liệu bao gồm Sách, Tạp chí, Báo. Mỗi tài liệu gồm có các thuộc tính sau: Mã tài liệu(Mã tài liệu là duy nhất), Tên nhà xuất bản, số bản phát hành.

Các loại sách cần quản lý thêm các thuộc tính: tên tác giả, số trang.

Các tạp chí cần quản lý thêm: Số phát hành, tháng phát hành.

Các báo cần quản lý thêm: Ngày phát hành.

Yêu cầu 1: Xây dựng các lớp để quản lý tài liệu cho thư viện một cách hiệu quả.

Yêu cầu 2: Xây dựng lớp QuanLySach có các chức năng sau

* Thêm mới tài liêu: Sách, tạp chí, báo.
* Xoá tài liệu theo mã tài liệu.
* Hiện thị thông tin về tài liệu.
* Tìm kiếm tài liệu theo loại: Sách, tạp chí, báo.
* Thoát khỏi chương trình.

<a name="3"></a>
### Bài 3
Các thí sinh dự thi đại học bao gồm các thí sinh thi khối A, B, và khối C. Các thí sinh cần quản lý các thông tin sau: Số báo danh, họ tên, địa chỉ, mức ưu tiên. 

Thí sinh thi khối A thi các môn: Toán, Lý, Hoá.

Thí sinh thi khối B thi các môn: Toán, Hoá, Sinh.

Thí sinh thi khối C thi các môn: Văn, Sử, Địa.

Yêu cầu 1: Xây dựng các lớp để quản lý các thi sinh dự thi đại học.

Yêu cầu 2: Xây dựng lớp TuyenSinh có các chức năng:

* Thêm mới thí sinh.
* Hiện thị thông tin của thí sinh và khối thi của thí sinh.
* Tìm kiếm theo số báo danh.
* Thoát khỏi chương trình.

<a name="8"></a>
### Bài 8
Thư viện trung tâm đại học quốc gia có nhu cầu quản lý việc mượn, trả sách. Sinh viên đăng ký tham gia mượn sách thông qua thẻ mà thư viện cung cấp.
Với mỗi thẻ sẽ lưu các thông tin sau: Mã phiếu mượn, ngày mượn, hạn trả, số hiệu sách, và các thông tin cá nhân của sinh viên mượn sách. Các thông tin của sinh viên mượn sách bao gồm: Họ tên, tuổi, lớp.
Để đơn giản cho ứng dụng console. Chúng ta mặc định ngày mượn, ngày trả là số nguyên dương.

Yêu cầu 1: Xây dựng lớp SinhVien để quản lý thông tin của mỗi sinh viên.

Yêu cầu 2: Xây dựng lớp TheMuon để quản lý việc mượn trả sách của các sinh viên.

Yêu cầu 3: Xây dựng các phương thức: 

* Thêm thẻ mượn
* Xoá theo mã phiếu mượn
* Hiển thị thông tin các thẻ mượn

<a name="9"></a>
### Bài 9
Để quản lý biên lai thu tiền điện, người ta cần các thông tin sau:

Với mỗi biên lai: Thông tin về hộ sử dụng điện, chỉ số điện cũ, chỉ số mới, số tiền phải trả.
Các thông tin riêng của từng hộ gia đình sử dụng điện: Họ tên chủ hộ, số nhà, mã số công tơ điện.

Yêu cầu 1: Hãy xây dựng lớp khachHang để lưu trữu các thông tin riêng của mỗi hộ gia đình.

Yêu cầu 2: Xây dựng lớp BienLai để quản lý việc sử dụng và thanh toán tiền điện của các hộ dân.

Yêu cầu 3: Xây dựng các phương thức thêm, xoá sửa các thông tin riêng của mỗi hộ sử dụng điện.

Yêu cầu 4: Viết phương thức tính tiền điện cho mỗi hộ gia đình theo công thức: (số mới - số cũ ) * 5