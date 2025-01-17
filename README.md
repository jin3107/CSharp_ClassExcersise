> Thực hiện: **Huỳnh Tấn Chương**
>
> Cập nhật lần cuối: **01/01/2025**

# Bài tập Hướng đối tượng bằng ngôn ngữ C#

### Mực lục

[1. Bài 1 - Quản lý cán bộ](#1)

[2. Bài 2 - Quản lý sách](#2)

[3. Bài 3 - Quản lý tuyển sinh](#3)

[4. Bài 4 - Quản lý các hộ dân cư](#4)

[5. Bài 5 - Quản lý khách sạn](#5)

[6. Bài 6 - Quản lý hồ sơ học sinh](#6)

[7. Bài 7 - Quản lý thanh toán tiền lương của các cán bộ giáo viên](#7)

[8. Bài 8 - Quản lý việc mượn, trả sách](#8)

[9. Bài 9 - Quản lý biên lai thu tiền điện](#9)

[10. Bài 10 - Xử lý văn bản](#10)

[11. Bài 11 - Số Phức](#11)

[12. Bài 12 - Quản lý phương tiện](#12)

[16. Bài 16 - Bài tập hình học (tự luyện)](#16)

[20-118. Bài 20 trang 118 (Giáo trình) - Quản lý xét tuyển danh sách học viên](#20-118)

[25-119. Bài 25 trang 119 (Giáo trình) - Bài tập hình học](#25-119)

<a name="1"></a>

### Bài 1

Một đơn vị sản xuất gồm có các cán bộ là công nhân, kỹ sư, nhân viên. Mỗi cán bộ cần quản lý các dữ liệu: Họ tên, tuổi, giới tính(name, nữ, khác), địa chỉ.

Cấp công nhân sẽ có thêm các thuộc tính riêng: Bậc (1 đến 10).
Cấp kỹ sư có thuộc tính riêng: Nghành đào tạo.
Các nhân viên có thuộc tính riêng: công việc.

Yêu cầu 1: Xây dựng các lớp CongNhan, KySu, NhanVien kế thừa từ lớp CanBo.

Yêu cầu 2: Xây dựng lớp QLCB(quản lý cán bộ) cài đặt các phương thức thực hiện các chức năng sau:

- Thêm mới cán bộ.
- Tìm kiếm theo họ tên.
- Hiện thị thông tin về danh sách các cán bộ.
- Thoát khỏi chương trình.

<a name="2"></a>

### Bài 2

Một thư viện cần quản lý các tài liệu bao gồm Sách, Tạp chí, Báo. Mỗi tài liệu gồm có các thuộc tính sau: Mã tài liệu(Mã tài liệu là duy nhất), Tên nhà xuất bản, số bản phát hành.

Các loại sách cần quản lý thêm các thuộc tính: tên tác giả, số trang.

Các tạp chí cần quản lý thêm: Số phát hành, tháng phát hành.

Các báo cần quản lý thêm: Ngày phát hành.

Yêu cầu 1: Xây dựng các lớp để quản lý tài liệu cho thư viện một cách hiệu quả.

Yêu cầu 2: Xây dựng lớp QuanLySach có các chức năng sau

- Thêm mới tài liêu: Sách, tạp chí, báo.
- Xoá tài liệu theo mã tài liệu.
- Hiện thị thông tin về tài liệu.
- Tìm kiếm tài liệu theo loại: Sách, tạp chí, báo.
- Thoát khỏi chương trình.

<a name="3"></a>

### Bài 3

Các thí sinh dự thi đại học bao gồm các thí sinh thi khối A, B, và khối C. Các thí sinh cần quản lý các thông tin sau: Số báo danh, họ tên, địa chỉ, mức ưu tiên.

Thí sinh thi khối A thi các môn: Toán, Lý, Hoá.

Thí sinh thi khối B thi các môn: Toán, Hoá, Sinh.

Thí sinh thi khối C thi các môn: Văn, Sử, Địa.

Yêu cầu 1: Xây dựng các lớp để quản lý các thi sinh dự thi đại học.

Yêu cầu 2: Xây dựng lớp TuyenSinh có các chức năng:

- Thêm mới thí sinh.
- Hiện thị thông tin của thí sinh và khối thi của thí sinh.
- Tìm kiếm theo số báo danh.
- Thoát khỏi chương trình.

<a name="4"></a>

### Bài 4

Để quản lý các hộ dân cư trong một khu phố, người ta cần các thông tin sau: Số thành viên trong gia đình, Số nhà, thông tin mỗi cá nhân trong gia đình. Với mỗi cá nhân, người ta quản lý các thông tin sau: Họ tên, Tuổi, Nghề nghiệp, số chứng minh nhân dân(duy nhất cho mỗi người).

Yêu cầu 1: Hãy xây dựng lớp Nguoi để quản lý thông tin của mỗi cá nhân.

Yêu cầu 2: Xây dựng lớp HoGiaDinh để quản lý thông tin của từng hộ gia đình.

Yêu cầu 2: Xây dựng lớp KhuPho để quản lý các thông tin của từng hộ gia đình.

Yêu cầu 3: Nhập n hộ dân. (n nhập từ bàn phím), hiển thị thông tin của các hộ trong khu phố.

<a name="5"></a>

### Bài 5

Để quản lý khách hàng đến thuê phòng của một khách sạn, người ta cần các thông tin sau: Số ngày thuê, loại phòng, thông tin cá nhân của những người thuê phòng.

Biết rằng phòng loại A có giá 500$, phòng loại B có giá 300$ và loại C có giá 100$.

Với mỗi cá nhân cần quản lý các thông tin sau: Họ tên, tuổi, số chứng minh nhân dân.

Yêu cầu 1: Hãy xây dựng lớp Nguoi để quản lý thông tin cá nhân của những người thuê phòng.

Yêu cầu 2: Xây dựng lớp KhachSan để quản lý các thông tin về các phòng trong khác sạn.

Yêu cầu 3: Xây dựng các phương thức thêm mới, xoá khách theo số chứng minh nhân dân. Tính tiền thuê phòng cho khách(xác định khách bằng số chứng minh nhân dân) dựa vào công thức: (số ngày thuê \* giá của từng loại phòng)

<a name="6"></a>

### Bài 6

Để quản lý hồ sơ học sinh của trường THPT nhà trường cần các thông tin sau: Lớp, và các thông tin về cá nhân của mỗi học sinh.

Mỗi học sinh có các thông tin sau: Họ tên, tuổi, quê quán.

Yêu cầu 1: Xây dựng HocSinh để quản lý thông tin của mỗi học sinh.

Yêu cầu 2: Xây dựng các phương thức thêm, hiển thị thông tin của mỗi học sinh.

Yêu cầu 3: Cài đặt chương trình có các chức năng sau:

- Thêm học sinh mới.
- Hiện thị các học sinh 20 tuổi.
- Cho biết số lượng các học sinh có tuổi là 23 và quê ở DN.

<a name="7"></a>

### Bài 7

Khoa CNTT – DHKHTN cần quản lý việc thanh toán tiền lương cho các cán bộ giá viên trong khoa. Để quản lý được, khoa cần các thông tin sau:

Với mỗi cán bộ giáo viên có các thông tin sau: lương cứng, lương thưởng, tiền phạt, lương thực lĩnh, và các thông tin cá nhân: Họ tên, tuổi, quê quán, mã số giáo viên.

Yêu cầu 1: Xây dựng lớp Nguoi để quản lý các thông tin cá nhân của mỗi giáo viên.

Yêu cầu 2: Xây dựng lớp CBGV để quản lý các thông tin của các cán bộ giáo viên.

Yêu cầu 3: Xây dựng các phương thức thêm, xoá các cán bộ giáo viên theo mã số giáo viên.

Yêu cầu 4: Tính lương thực lĩnh cho giáo viên: Lương thực = Lương cứng + lương thưởng – lương phạt. 


<a name="8"></a>

### Bài 8

Thư viện trung tâm đại học quốc gia có nhu cầu quản lý việc mượn, trả sách. Sinh viên đăng ký tham gia mượn sách thông qua thẻ mà thư viện cung cấp.
Với mỗi thẻ sẽ lưu các thông tin sau: Mã phiếu mượn, ngày mượn, hạn trả, số hiệu sách, và các thông tin cá nhân của sinh viên mượn sách. Các thông tin của sinh viên mượn sách bao gồm: Họ tên, tuổi, lớp.
Để đơn giản cho ứng dụng console. Chúng ta mặc định ngày mượn, ngày trả là số nguyên dương.

Yêu cầu 1: Xây dựng lớp SinhVien để quản lý thông tin của mỗi sinh viên.

Yêu cầu 2: Xây dựng lớp TheMuon để quản lý việc mượn trả sách của các sinh viên.

Yêu cầu 3: Xây dựng các phương thức:

- Thêm thẻ mượn
- Xoá theo mã phiếu mượn
- Hiển thị thông tin các thẻ mượn

<a name="9"></a>

### Bài 9

Để quản lý biên lai thu tiền điện, người ta cần các thông tin sau:

Với mỗi biên lai: Thông tin về hộ sử dụng điện, chỉ số điện cũ, chỉ số mới, số tiền phải trả.
Các thông tin riêng của từng hộ gia đình sử dụng điện: Họ tên chủ hộ, số nhà, mã số công tơ điện.

Yêu cầu 1: Hãy xây dựng lớp khachHang để lưu trữu các thông tin riêng của mỗi hộ gia đình.

Yêu cầu 2: Xây dựng lớp BienLai để quản lý việc sử dụng và thanh toán tiền điện của các hộ dân.

Yêu cầu 3: Xây dựng các phương thức thêm, xoá sửa các thông tin riêng của mỗi hộ sử dụng điện.

Yêu cầu 4: Viết phương thức tính tiền điện cho mỗi hộ gia đình theo công thức: (số mới - số cũ ) \* 5

<a name="10"></a>

### Bài 10

Bài tập tự luyện

Để xử lý văn bản người ta xây dựng lớp VanBan có thuộc tính riêng là một xâu ký tự.

Yêu cầu 1: Xây dựng hàm khởi tạo VanBan(), VanBan(String st).

Yêu cầu 2: Xây dựng phương thức đếm số từ của văn bản.

Yêu cầu 3: Xây dựng phương thức đếm số lượng ký tự A (không phân biệt hoa thường) của văn bản.

Yêu cầu 4: Chuẩn hoá văn bản theo tiêu chuẩn sau: Ở đầu và cuối sâu không có ký tự trống, ở giữa sâu không có 2 hoặc nhiều hơn các ký tự khoảng trắng kiền kề nhau.

<a name="11"></a>

### Bài 11

Bài tập tự luyện

Xây dựng lớp SoPhuc có các thuộc tính PhanThuc, PhanAo kiểu double.

Yêu cầu 1: Xây dựng các phương thức tạo lập

Yêu cầu 2: Xây dựng các phương thức:

- Nhập một số phức.
- Hiện thị số phức.
- Cộng 2 số phức.
- Nhân 2 số phức.

<a name="12"></a>

### Bài 12

Bài tập tự luyện

Nghành công an cần quản lý các phương tiện giao thông gồm: ô tô, xe máy, xe tải. Mỗi loại gồm các thông tin: ID, Hãng sản xuất, năm sản xuất, giá bán và màu xe.

Các ô tô có các thuộc tính riêng: số chỗ ngồi, kiểu động cơ.

Các xe máy có các thuộc tính riêng: công xuất.

Xe tải cần quản lý thêm: Trọng tải.

Yêu cầu 1: Xây dựng các lớp để quản lý các phương tiện trên sao cho hiệu quả.

Yêu cầu 2: Xây dựng lớp QLPTGT có các chức năng:

- Thêm, xoá(theo ID) các phương tiện thuộc các loại trên.
- Tìm phương tiện theo hãng sản xuất, màu.
- Thoát chương trình.

<a name="20-118"></a>

### Bài 20 trang 118 (Giáo trình)

Xây dựng lớp HocVien để quản lý họ tên, năm sinh, điểm chín môn học của tất cả các học viên của lớp học.

Cho biết bao nhiêu học viên trong lớp được phép làm luận văn tốt nghiệp, bao nhiêu học viên thi tốt nghiệp, bao nhiêu người phải thi lại và tên môn thi lại.

Tiêu chuẩn để xét:

- Làm luận văn phải có điểm trung bình lớn hơn 7 trong đó không có môn nào dưới 5.
- Thi tốt nghiệp khi điểm trung bình không lớn hơn 7 và điểm các môn không dưới 5.
- Thi lại có môn dưới 5.
- Mở rộng chức năng để quản lý xét tuyển danh sách học viên
