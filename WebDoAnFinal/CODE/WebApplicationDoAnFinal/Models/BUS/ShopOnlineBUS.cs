using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationDoAnFinal.Models.BUS
{
    public class ShopOnlineBUS
    {
      public static IEnumerable<SANPHAM> DanhSach()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<SANPHAM>("SELECT * FROM SANPHAM WHERE TINHTRANG=MOI ");
        }
    }
}