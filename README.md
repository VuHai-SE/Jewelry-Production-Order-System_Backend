# Jewelry Production Order System
1. **Phần mềm quản lý đặt gia công trang sức của khách hàng cho công ty gia công trang sức**
2. **Subject: PRN221_GroupProject**

## Mô tả
- Trang chủ giới thiệu công ty, bộ sưu tập trang sức, mẫu thiết kế, blog chia sẻ, ...
- Khách hàng có thể đặt yêu cầu gia công đồ trang sức theo mẫu thiết kế công ty hoặc theo yêu cầu thiết kế của khách.
- Quản lý quá trình đặt gia công trang sức của khách hàng.

### Quy trình
1. Khách hàng gửi yêu cầu → **Nhân viên kinh doanh** tiếp nhận và trao đổi với khách.
2. **Nhân viên kinh doanh** gửi yêu cầu phê duyệt báo giá → **Người quản lý** phê duyệt.
3. **Nhân viên kinh doanh** gửi báo giá đã phê duyệt → Khách hàng chấp nhận báo giá và tạo đơn hàng gia công.
4. **Nhân viên thiết kế** gửi bản thiết kế 3D cho khách → Khách hàng phê duyệt bản thiết kế.
5. **Nhân viên gia công** thực hiện gia công trang sức → **Nhân viên kinh doanh** bàn giao trang sức đã gia công và giấy bảo hành cho khách hàng.

- Cập nhật chi phí của đơn hàng gia công theo định mức để báo giá và thực tế gia công được tính giá vốn báo giá và thực hiện.

### Công thức tính giá
**Giá vốn sản phẩm = [giá vàng thời điểm * trọng lượng sản phẩm] + tiền công + tiền đá**

- Khai báo chính sách thanh toán, huy động đơn hàng gia công trang sức.
- Khai báo giá vàng và đơn giá đá áp dụng của công ty.
- Khai báo mẫu thiết kế của công ty và định mức chi phí thực hiện kèm theo.

### Dashboard
- Thống kê dữ liệu.

## Các đối tượng sử dụng (Actors)
- **Customer**: Khách hàng
- **Sales Staff**: Nhân viên kinh doanh
- **Design Staff**: Nhân viên thiết kế
- **Production Staff**: Nhân viên sản xuất
- **Manager**: Người quản lý
- **Admin**: Quản trị viên
