# Chương trình quản lý bán hàng sử dụng scan bardcode (mã hàng hóa) theo mô hình 3 lớp, SQL Sever
- Các chức năng trong chương trình gồm: Đăng nhập, quản lý hàng hóa, thanh toán hàng hóa, in hóa đơn, Scan mã bardcode, thống kê đơn giản, các chức khác như quản lý nhân viên, quản lý nhập xuất chưa hoàn thiện hoàn toàn có thể phát triển thêm ví dụ: thêm tự động tạo mã QR thanh toán ở `` FormThanhToan.cs `` cho khách hàng khi khách hàng muốn chuyển khoản ..vvv
- Khi xóa một item trong datagridview có thể chưa cập nhập lại tự động tăng trên CSDL hoặc lỗi, mình đã viết hàm tự động update nhiều lúc bị lỗi các bạn có thể tự fix lại bằng cách vào csdl cập nhập lại bảng.
- Trong file `` img_bardcode_scan `` có các ảnh bardcode để mọi người test chức năng Scan bardcode, mình dùng chức năng này thay cho việc tìm kiếm 1 hàng hóa trên csdl luôn.
- Vì chưa có nhiều kinh nghiệm trong việc lập trình về application thức tế nên code còn khá tù mong mọi người thông cảm.
# Các bước cài đặt
1. Create data with file `` script `` in `` /file_tai_lieu/csdl  `` or roll back data file `` QLBH.bak `` (I use SQL SEVER 2022), the `` projectQLBH `` file is the file that creates the initial database you should create database with file `` script `` or you can actack file database in `` /GUI/DataBase/QLBH.mdf ``.

	![image](https://github.com/feanorpham/QLBH_ScanBardcode/assets/104748794/7f8d5b1c-5afe-4c18-aa02-28186958260f)

2. Change connect string in `` /GUI/App.config ``.
   ``````
	<connectionStrings>
		<add name ="myconnection" connectionString="Data Source=(YourServer);Initial Catalog=QLBH;Integrated Security=True" providerName="System.Data.SqlClient"/>
	</connectionStrings>
   ``````
3. Change file audio link  in `` BUS/LinkAudio.cs ``, file audio in `` /QLBH_ScanBardcode/QLBH_ScanBardcode/Audio `` choose file ` .wav `. 
   ```````
        public void audioScan()
        { 
            SoundPlayer player = new SoundPlayer(@"Link file audio");
            player.Play();
        }
   ```````

4. Change select camera in ``` FormThanhToan.cs ``` ; ``` FormHangHoa.cs ``` with ``` void_btunScan_Click ``` line code `` captureDevice = new VideoCaptureDevice(filter[0].MonikerString); `` [0] = select webcam default, I use camera laptop you can change select.
   ``````
           private void btunScan_Click(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            captureDevice = new VideoCaptureDevice(filter[0].MonikerString);   ## change [0]
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
            btunStop.Enabled = true;
        }
   ``````
5. Copy the image file in ``` /file_tai_lieu/img_bardcode_scan ``` to your smartphone or ipad that you want to scan (ALL image files please).

	![image](https://github.com/feanorpham/QLBH_ScanBardcode/assets/104748794/99d8a736-fd82-4caa-8a4f-385cee78326b)

6. Running source code.
