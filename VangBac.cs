using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_QLCHVB
{
    abstract class VangBac : iVangBac
    {
        string MaSP, TenSP, HangSX;
        double DonGia;
        public string getMaSP() { return MaSP; }
        public string getTenSP() { return TenSP; }
        public string getHangSX() { return HangSX; }
        public double getDonGia() { return DonGia; }
        public void setMaSP(string MaSP) { this.MaSP = MaSP; }
        public void setTenSP(string TenSP) { this.TenSP = TenSP; }
        public void setHangSX(string HangSX) { this.HangSX = HangSX; }
        public void setDonGia(double DonGia) { this.DonGia = DonGia; }

        int SoLuong;
        public void setSoLuong(int SoLuong) { this.SoLuong = SoLuong; }
        public int getSoLuong() { return SoLuong; }

        abstract public double XetGiamGia();
        abstract public void TinhTongTien();
        public virtual void NhapTTSanPham(ArrayList arrVangBac, int i)
        {
            //Console.Clear();

        }
        public virtual void XuatTTSanPham()
        {
            Console.Write("Mã Sản Phẩm  : ");
            Console.WriteLine(MaSP);
            Console.Write("Tên Sản Phẩm : ");
            Console.WriteLine(TenSP);
            Console.Write("Hãng Sản Xuất: ");
            Console.WriteLine(HangSX);
            Console.Write("Đơn Giá      : ");
            Console.WriteLine(DonGia);
            Console.Write("Số Lượng     : ");
            Console.WriteLine(SoLuong);
        }
    }
    
}
