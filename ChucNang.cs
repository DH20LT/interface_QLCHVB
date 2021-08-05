using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_QLCHVB
{
    class ChucNang
    {
        public static int NhapSoNguyen()
        {
            int i = 0;
            try
            {
                i = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Bạn Nhập Sai, Hãy Nhập Lại");
            }
            return i;
        }
        public static void FilterObject(ArrayList arrVangBac, int iCaiNao)
        {
            switch(iCaiNao)
            {
                case 1: // lọc ra Vàng
                    {
                        Console.WriteLine("=====================================");
                        for (int i = 0; i < arrVangBac.Count; i++)
                        {
                            exVang vang = new exVang();
                            Type ia = arrVangBac[i].GetType();
                            Type iVang = vang.GetType();
                            if (ia.Equals(iVang))
                            {
                                vang = (exVang)arrVangBac[i];
                                vang.XuatTTSanPham();
                            }
                        }
                        Console.WriteLine("=====================================");
                        Console.ReadLine();
                        Program.Programming(arrVangBac);
                        break;
                    }
                case 2: // lọc ra Bạc
                    {
                        Console.WriteLine("=====================================");
                        for (int i = 0; i < arrVangBac.Count; i++)
                        {
                            exBac bac = new exBac();
                            Type ia = arrVangBac[i].GetType();
                            Type iBac = bac.GetType();
                            if (ia.Equals(iBac))
                            {
                                bac = (exBac)arrVangBac[i];
                                bac.XuatTTSanPham();
                            }
                        }
                        Console.WriteLine("=====================================");
                        Console.ReadLine();
                        Program.Programming(arrVangBac);
                        break;
                    }
                case 3: // Lọc Hết Tất Cả Đối Tượng
                    {
                        Console.Title = "Tất Cả Đối Tượng | " + Program.getName();
                        Console.Clear();
                        Console.WriteLine("           --Hiện Tất Cả--           ");
                        for (int i = 0; i < arrVangBac.Count; i++)
                        {
                            exBac bac = new exBac();
                            exVang vang = new exVang();
                            Type ia = arrVangBac[i].GetType();
                            Type iBac = bac.GetType();
                            Type iVang = vang.GetType();
                            if (ia.Equals(iBac))
                            {
                                bac = (exBac)arrVangBac[i];
                                Console.WriteLine("=====================================");
                                bac.XuatTTSanPham();
                                Console.WriteLine("=====================================");
                            }
                            else if(ia.Equals(iVang))
                            {
                                vang = (exVang)arrVangBac[i];
                                Console.WriteLine("=====================================");
                                vang.XuatTTSanPham();
                                Console.WriteLine("=====================================");
                            }
                        }
                        Console.ReadLine();
                        Program.Programming(arrVangBac);
                        break;
                    }
            }
        }
        static int UpdateReturn(ArrayList arrVangBac, int i)
        {
            int SoDinhMenh = 0;
            for (int j = 0; j < arrVangBac.Count; j++)
            {
                exVang vang = new exVang();
                exBac bac = new exBac();

                Type ia = arrVangBac[i].GetType();

                Type iVang = vang.GetType();
                Type iBac = bac.GetType();
                if (ia.Equals(iVang))
                {
                    SoDinhMenh = 1;
                }
                else if (ia.Equals(iBac))
                {
                    SoDinhMenh = 2;
                }
            }
            return SoDinhMenh;
        }
        public static void UpdateObject(ArrayList arrVangBac)
        {
            Console.Clear();
            for (int i = 0; i < arrVangBac.Count; i++)
            {
                int STT = i + 1;
                exBac bac = new exBac();
                exVang vang = new exVang();
                Type ia = arrVangBac[i].GetType();
                Type iBac = bac.GetType();
                Type iVang = vang.GetType();
                if (ia.Equals(iBac))
                {
                    bac = (exBac)arrVangBac[i];
                    Console.WriteLine("=====================================");
                    Console.WriteLine(STT + ". " + bac.getTenSP());
                    Console.WriteLine("=====================================");
                }
                else if (ia.Equals(iVang))
                {
                    vang = (exVang)arrVangBac[i];
                    Console.WriteLine("=====================================");
                    Console.WriteLine(STT + ". " + vang.getTenSP());
                    Console.WriteLine("=====================================");
                }
            }
            Console.WriteLine("Bạn muốn cập nhật Đối Tượng Nào? - 0 Để Hủy");
            int iCapNhat = int.Parse(Console.ReadLine());
            int iTempIndex = iCapNhat - 1;
            if (iCapNhat == 0)
            {
                Program.Programming(arrVangBac);
            }
            else
                switch (UpdateReturn(arrVangBac, iTempIndex))
                {
                    case 0:
                        {
                            break;
                        }
                    case 1: // Vàng
                        {
                            exVang vang = new exVang();
                            vang = (exVang)arrVangBac[iTempIndex];
                            vang.XuatTTSanPham();
                            vang.CapNhatThongTin(arrVangBac, 1);
                            arrVangBac.Insert(iTempIndex, vang);
                            break;
                        }
                    case 2: //Bạc
                        {
                            exBac bac = new exBac();
                            bac = (exBac)arrVangBac[iTempIndex];
                            bac.XuatTTSanPham();
                            bac.CapNhatThongTin(arrVangBac, 2);
                            arrVangBac.Insert(iTempIndex, bac);
                            break;
                        }
                }
        }
    }
}
