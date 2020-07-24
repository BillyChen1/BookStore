using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys.Logic;
using WingtipToys.Models;

namespace WingtipToys.Admin
{
    public partial class Statistics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //顾客购买统计
            var _db = new WingtipToys.Models.ProductContext();
            List<OrderDetail> orderList = _db.OrderDetails.ToList();
            PurchaseList.DataSource = orderList;
            PurchaseList.DataBind();

            //销售统计
            AdminOperation admin = new AdminOperation();
            List<Product> list = admin.GetAllProduct();

            ProductsList.DataSource = list;
            ProductsList.DataBind();
            int sumNum = 0;
            double sumMoeny = 0;

            foreach (Product p in list)
            {
                sumNum += p.Sold;
                sumMoeny += (double)p.Sold * (double)p.UnitPrice;
            }
            SumNumber.Text = "书籍销售总数：" + sumNum.ToString();
            SumMoney.Text = "书籍销售总金额：" + sumMoeny.ToString();
        }
    }
}