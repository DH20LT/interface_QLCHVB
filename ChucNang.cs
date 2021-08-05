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
                        Console.ReadLine();
                        Program.Programming(arrVangBac);
                        break;
                    }
                case 2: // lọc ra Bạc
                    {
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
                        Console.ReadLine();
                        Program.Programming(arrVangBac);
                        break;
                    }
                case 3: // Lọc Hết
                    {
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
                                bac.XuatTTSanPham();
                            }
                            else if(ia.Equals(iVang))
                            {
                                vang = (exVang)arrVangBac[i];
                                vang.XuatTTSanPham();
                            }
                        }
                        Console.ReadLine();
                        Program.Programming(arrVangBac);
                        break;
                    }

            }
        }
    }
}
