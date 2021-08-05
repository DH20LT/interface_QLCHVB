using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_QLCHVB
{
    class Menu
    {
        public static void MenuChinh()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("| 1. Tạo Đối Tượng Vàng             |");
            Console.WriteLine("| 2. Tạo Đối Tượng Bạc              |");
            Console.WriteLine("| 3. Lọc Đối Tượng Vàng             |");
            Console.WriteLine("| 4. Lọc Đối Tượng Bạc              |");
            Console.WriteLine("| 5. Hiện Tất Cả Đối Tượng          |");
            Console.WriteLine("| 6. Sắp Xếp Các Đối Tượng          |");
            Console.WriteLine("| 7. Lọc Hãng PNJ                   |");
            Console.WriteLine("| 8. Cập Nhật Đối Tượng             |");
            Console.WriteLine("| 0. Thoát Chương Trình             |");
            Console.WriteLine("=====================================");
            Console.WriteLine("Chọn chức năng theo số");
        }
        public static void MenuNhapTTSanPham(int i)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("| 1. Nhập Mã                        |");
            Console.WriteLine("| 2. Nhập Tên                       |");
            Console.WriteLine("| 3. Nhập Hãng Sản Xuất             |");
            Console.WriteLine("| 4. Nhập Đơn Giá                   |");
            Console.WriteLine("| 5. Nhập Số Lượng                  |");
            switch(i)
            {
                case 1:
                    {
            Console.WriteLine("| 6. Nhập Loại Vàng                 |");
            Console.WriteLine("| 7. Nhập Tuổi Vàng                 |");
                        break;
                    }
                case 2:
                    {
            Console.WriteLine("| 6. Nhập Loại Bạc                  |");
            Console.WriteLine("| 7. Nhập Kiểu Bạc                  |");
                        break;
                    }
            }
            Console.WriteLine("| 0. Về Menu Chính                  |");
            Console.WriteLine("=====================================");
            Console.WriteLine("Chọn chức năng theo số");
        }
    }
}
