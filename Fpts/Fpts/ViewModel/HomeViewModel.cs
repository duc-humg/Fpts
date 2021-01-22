﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Fpts.Models;

namespace Fpts.ViewModel
{
    public class HomeViewModel
    {
        public bool a;
        public ObservableCollection<Banggia> Giaodich { get; set; }
        public HomeViewModel()
        {
            Giaodich = new ObservableCollection<Banggia>();
            Giaodich.Add(new Banggia { Ma = "VNI" ,thaydoi = "1164.21", sogd = 28.53 ,thaydoi1 = "2.60%" ,monney = "15758.59 tỷ", ma = "TS3", gia = "35", phantram = -0.5, khoiluong = "56,300" });
            Giaodich.Add(new Banggia { Ma = "VN100" ,thaydoi = "1107.82", sogd = 30.53, thaydoi1 = "2.60%" ,monney = "15758.59 tỷ", ma = "PTV", gia = "30", phantram = 0, khoiluong = "56,300" });
            Giaodich.Add(new Banggia { Ma = "VN30", thaydoi = "1151.3", sogd = 35.53 ,thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "PVI", gia = "31", phantram = -0.6, khoiluong = "56,300" });
            Giaodich.Add(new Banggia { Ma = "VNALL" ,thaydoi = "1109.72", sogd = 32.53 ,thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "SHB", gia = "32", phantram = -0.3, khoiluong = "56,300" });
            Giaodich.Add(new Banggia { Ma = "VNMID" ,thaydoi = "1382.57", sogd = 49.53 ,thaydoi1 = "2.60%", monney = "15758.59 tỷ" , ma = "HAD", gia = "36", phantram = -0.2, khoiluong = "56,300" });
            Giaodich.Add(new Banggia { Ma = "VNSML", thaydoi = "1168.07", sogd = 35.53 ,thaydoi1 = "2.60%", monney = "15758.59 tỷ" , ma = "ABC", gia = "48", phantram = 0, khoiluong = "56,300" });
            Giaodich.Add(new Banggia { Ma = "VNXALL", thaydoi = "1176.21", sogd = 48.53 ,thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "HGA", gia = "63", phantram = 1, khoiluong = "56,300" });
            Giaodich.Add(new Banggia { Ma = "HNX30", thaydoi = "1176.21", sogd = 48.53 ,thaydoi1 = "2.60%", monney = "15758.59 tỷ" , ma = "PNT", gia = "21", phantram = 1.2, khoiluong = "56,300" });
            Giaodich.Add(new Banggia { Ma = "HNXCON", thaydoi = "1176.21", sogd = 48.53 ,thaydoi1 = "2.60%", monney = "15758.59 tỷ" , ma = "VIC", gia = "34", phantram = 1.3, khoiluong = "56,300" });
            Giaodich.Add(new Banggia { Ma = "HNXFIN" ,thaydoi = "1176.21", sogd = 48.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ" , ma = "MBB", gia = "30", phantram = 1.6, khoiluong = "56,300" });
            Giaodich.Add(new Banggia { Ma = "HNX", thaydoi = "1176.21", sogd = 38.53 ,thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "MBB", gia = "30", phantram = 1.6, khoiluong = "56,300" });
            Giaodich.Add(new Banggia { Ma = "HNXLCAP", thaydoi = "1176.21", sogd = 38.53 ,thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "MBB", gia = "30", phantram = 1.6, khoiluong = "56,300" });
            Giaodich.Add(new Banggia { Ma = "HNXMAN", thaydoi = "1176.21", sogd = 38.53 ,thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "MBB", gia = "30", phantram = 1.6, khoiluong = "56,300" });
            Giaodich.Add(new Banggia { Ma = "HNXMSCAP", thaydoi = "1176.21", sogd = 38.53, thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "MBB", gia = "30", phantram = 1.6, khoiluong = "56,300" });
            Giaodich.Add(new Banggia { Ma = "UPCOM", thaydoi = "1176.21", sogd = 38.53 ,thaydoi1 = "2.60%", monney = "15758.59 tỷ", ma = "MBB", gia = "30", phantram = 1.6, khoiluong = "56,300" });
            foreach(var item in Giaodich)
            {
                if(item.sogd > 40.00)
                {
                    item.color = "#6ac164";
                }
                if (item.sogd == 48.53)
                {
                    item.color = "#f26f21";
                }
                if (item.sogd < 40.00) 
                {
                    item.color = "#c3161c";
                }
                    
            }
            foreach (var iteam in Giaodich)
            {
                if (iteam.phantram > 0)
                {
                    iteam.mau = "#6ac164";
                }
                if (iteam.phantram == 0)
                {
                    iteam.mau = "#f26f21";
                }
                if (iteam.phantram < 0)
                {
                    iteam.mau = "#c3161c";
                }
            }
        }
        
    }
}