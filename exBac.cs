using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_QLCHVB
{
    class exBac : VangBac
    {
        string LoaiBac; // 8k, 10k, 12k, 14k
        public void setLoaiBac(string LoaiBac) { this.LoaiBac = LoaiBac; }
        public string getLoaiBac() { return LoaiBac; }
        int KieuBac; // 1 - Dây chuyền, 2 - Lắc
        public void setKieuBac(int KieuBac) { this.KieuBac = KieuBac; }
        public int getKieuBac() { return KieuBac; }

        public exBac()
        {
            setMaSP("");
            setTenSP("");
            setHangSX("");
            setDonGia(0.0);
            setLoaiBac("");
            setKieuBac(0);
            setSoLuong(0);
        }
        public exBac(
                        string MaSP, string TenSP, string HangSX,
                        double DonGia,
                        string LoaiBac, int KieuBac, int SoLuong)
        {
            setMaSP(MaSP);
            setTenSP(TenSP);
            setHangSX(TenSP);
            setDonGia(DonGia);
            setLoaiBac(LoaiBac);
            setKieuBac(KieuBac);
            setSoLuong(SoLuong);
        }
        public override double XetGiamGia()
        {
            double GiamGia = 0;
            if (KieuBac == 1 && LoaiBac == "8k")
            {
                GiamGia = getDonGia() * 0.04;
            }
            else if (KieuBac == 2 && LoaiBac == "10k")
            {
                GiamGia = getDonGia() * 0.02;
            }
            return GiamGia;
        }
        public override void TinhTongTien()
        {
            setDonGia(getDonGia() - XetGiamGia());
        }
        public override void NhapTTSanPham(ArrayList arrVangBac, int i)
        {
            Console.Clear();
            Console.WriteLine("            --Nhập Bạc--            ");
            Console.Title = "Nhập Thông Tin | " + Program.getName();
            Menu.MenuNhapTTSanPham(i);
            int iChucNang = int.Parse(Console.ReadLine());
            do
            {
                switch (iChucNang)
                {
                    case 0: // Về Menu Chính
                        {
                            Program.Programming(arrVangBac);
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Mã Sản Phẩm  : ");
                            setMaSP(Console.ReadLine());
                            NhapTTSanPham(arrVangBac, i);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Tên Sản Phẩm : ");
                            setTenSP(Console.ReadLine());
                            NhapTTSanPham(arrVangBac, i);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Hãng Sản Xuất: ");
                            setHangSX(Console.ReadLine());
                            NhapTTSanPham(arrVangBac, i);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Đơn Giá      : ");
                            setDonGia(double.Parse(Console.ReadLine()));
                            NhapTTSanPham(arrVangBac, i);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Số Lượng    : ");
                            setSoLuong(int.Parse(Console.ReadLine()));
                            NhapTTSanPham(arrVangBac, i);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Loại Bạc     : ");
                            LoaiBac = Console.ReadLine();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Kiểu Bạc     : ");
                            KieuBac = int.Parse(Console.ReadLine());
                            break;
                        }
                }
            } while (true);
        }
        public override void XuatTTSanPham()
        {
            base.XuatTTSanPham();
            Console.WriteLine("Loại Bạc     : ");
            Console.WriteLine("Kiểu Bạc     : ");
        }
        public void CapNhatThongTin(ArrayList arrVangBac, int i)
        {
            Console.WriteLine("            --Nhập Bạc--            ");
            Console.Title = "Nhập Thông Tin | " + Program.getName();
            Menu.MenuNhapTTSanPham(i);
            int iChucNang = int.Parse(Console.ReadLine());
            do
            {
                switch (iChucNang)
                {
                    case 0: // Về Menu Chính
                        {
                            Program.Programming(arrVangBac);
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Mã Sản Phẩm  : ");
                            setMaSP(Console.ReadLine());
                            NhapTTSanPham(arrVangBac, i);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Tên Sản Phẩm : ");
                            setTenSP(Console.ReadLine());
                            NhapTTSanPham(arrVangBac, i);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Hãng Sản Xuất: ");
                            setHangSX(Console.ReadLine());
                            NhapTTSanPham(arrVangBac, i);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Đơn Giá      : ");
                            setDonGia(double.Parse(Console.ReadLine()));
                            NhapTTSanPham(arrVangBac, i);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Số Lượng    : ");
                            setSoLuong(int.Parse(Console.ReadLine()));
                            NhapTTSanPham(arrVangBac, i);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Loại Bạc     : ");
                            LoaiBac = Console.ReadLine();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Kiểu Bạc     : ");
                            KieuBac = int.Parse(Console.ReadLine());
                            break;
                        }
                }
            } while (true);
        }
    }
    
}
