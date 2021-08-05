﻿using System;
using System.Collections;
using System.Net.NetworkInformation;

namespace interface_QLCHVB
{
    class Program
    {
        const string Name = "Quản Lý Cửa Hàng Vàng Bạc";
        public static string getName() { return Name; }
        public static void Programming(ArrayList arrVangBac)
        {
            Console.Clear();
            Menu.MenuChinh();
            int iChucNang = ChucNang.NhapSoNguyen();
            do
            {
                switch (iChucNang)
                {
                    case 0: // Thoát chương trình
                        {
                            Environment.Exit(0);
                            break;
                        }
                    case 1: //Tạo Đối Tượng Vàng
                        {
                            exVang vang = new exVang();
                            arrVangBac.Add(vang);
                            vang.NhapTTSanPham(arrVangBac, 1);
                            break;
                        }
                    case 2: //Tạo Đối Tượng Bạc
                        {
                            exBac bac = new exBac();
                            arrVangBac.Add(bac);
                            bac.NhapTTSanPham(arrVangBac, 2);
                            break;
                        }
                    case 3: //Lọc Đối Tượng Vàng
                        {
                            ChucNang.FilterObject(arrVangBac, 1);
                            break;
                        }
                    case 4: //Lọc Đối Tượng Bạc
                        {
                            ChucNang.FilterObject(arrVangBac, 2);
                            break;
                        }
                    case 5: //Hiện Tất Cả Đối Tượng
                        {
                            ChucNang.FilterObject(arrVangBac, 3);
                            break;
                        }
                    case 6: //Sắp Xếp Các Đối Tượng
                        {
                            int So = arrVangBac.Count;
                            VangBac[] arrTam = (VangBac[])arrVangBac.ToArray(typeof(VangBac));
                            for (int i = 0; i < So; i++)
                            {
                                for (int j = i + 1; j < So; j++)
                                {
                                    if (arrTam[i].getDonGia() > arrTam[j].getDonGia())
                                    {
                                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                                        VangBac temp = arrTam[i];
                                        arrTam[i] = arrTam[j];
                                        arrTam[j] = temp;
                                    }
                                }
                            }
                            for (int i = 0; i < So; i++)
                            {
                                arrTam[i].XuatTTSanPham();
                            }
                            break;
                        }
                    case 7: //Hãng Sản Xuất PNJ
                        {
                            for (int i = 0; i < arrVangBac.Count; i++)
                            {
                                exBac bac = new exBac();
                                exVang vang = new exVang();
                                Type ia = arrVangBac[i].GetType();
                                Type iBac = bac.GetType();
                                Type iVang = vang.GetType();
                                if (ia.Equals(iBac) && bac.getHangSX() == "PNJ")
                                {
                                    bac = (exBac)arrVangBac[i];
                                    bac.XuatTTSanPham();
                                }
                                else if (ia.Equals(iVang) && vang.getHangSX() == "PNJ")
                                {
                                    vang = (exVang)arrVangBac[i];
                                    vang.XuatTTSanPham();
                                }
                            }
                            Console.ReadLine();
                            Program.Programming(arrVangBac);
                            break;
                        }
                    case 8: //Cập Nhật Đối Tượng
                        {
                            break;
                        }
                }
            } while (true);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Title = "Quản Lý Cửa Hàng Vàng Bạc";
            ArrayList arrVangBac = new ArrayList();
            Programming(arrVangBac);
        }
    }
}
