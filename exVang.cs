using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_QLCHVB
{
    class exVang : VangBac
    {

        int TuoiVang; // 96, 97, 98, 99
        public void setTuoiVang(int TuoiVang) { this.TuoiVang = TuoiVang; }
        public int getTuoiVang() { return TuoiVang; }
        int LoaiVang; // 1 - Nhẫn, 2 - Miếng
        public void setLoaiVang(int LoaiVang) { this.LoaiVang = LoaiVang; }
        public int getLoaiVang() { return LoaiVang; }


        public exVang()
        {

            setMaSP("");
            setTenSP("");
            setHangSX("");
            setDonGia(0.0);
            setTuoiVang(0);
            setLoaiVang(0);
            setSoLuong(0);
        }
        public exVang(
                        string MaSP, string TenSP, string HangSX,
                        double DonGia,
                        int TuoiVang, int LoaiVang, int SoLuong)
        {
            setMaSP(MaSP);
            setTenSP(TenSP);
            setHangSX(HangSX);
            setDonGia(DonGia);
            setTuoiVang(TuoiVang);
            setLoaiVang(LoaiVang);
            setSoLuong(SoLuong);
        }
        public override double XetGiamGia()
        {
            double GiamGia = 0;
            if (TuoiVang == 96 && LoaiVang == 1)
            {
                GiamGia = getDonGia() * 0.03;
            }
            else if (TuoiVang == 97 && LoaiVang == 1)
            {
                GiamGia = getDonGia() * 0.02;
            }
            else if (TuoiVang == 98 && LoaiVang == 1)
            {
                GiamGia = getDonGia() * 0.01;
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
            Console.Title = "Nhập Thông Tin | " + Program.getName();
            Console.WriteLine("            --Nhập Vàng--            ");
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
                            Console.WriteLine("Tuổi Vàng    : ");
                            setSoLuong(int.Parse(Console.ReadLine()));
                            NhapTTSanPham(arrVangBac, i);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Loại Vàng     : ");
                            LoaiVang = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Tuổi Vàng     : ");
                            TuoiVang = int.Parse(Console.ReadLine());
                            break;
                        }
                }
            } while (true);
        }
    }
    
}
