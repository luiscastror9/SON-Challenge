using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer.BLL;
namespace Report
{
    public partial class Reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                BusinessLayer.BLL.OrderBLL orderBLL = new OrderBLL();
                DateTime baseDate = DateTime.Today;
                var today = baseDate;
                var thisWeekStart = baseDate.AddDays(-(int)baseDate.DayOfWeek);
                var thisWeekEnd = thisWeekStart.AddDays(7).AddSeconds(-1);
                var numbersodWeek = orderBLL.GetAllOrder(thisWeekStart, thisWeekEnd).Count();

                DataTable dt = new DataTable();

                dt.Columns.AddRange(new DataColumn[1] {

                    new DataColumn("OrderNumber",typeof(int))
                });

               
               

                    dt.Rows.Add(numbersodWeek);                
                GridView1.DataSource = dt;
                GridView1.DataBind();

                #region Most Popular hour
                var popHours = orderBLL.PopularHours(thisWeekStart, thisWeekEnd);

                DataTable dt3 = new DataTable();
                
                dt3.Columns.AddRange(new DataColumn[2] {
                    
                    new DataColumn("Id",typeof(int)),
                    new DataColumn("Hour",typeof(int))
                });
              
                int index = 1;
                popHours.ForEach(i =>
                {

                    dt3.Rows.Add(index,i);
                    index++;
                });
                GridView2.DataSource = dt3;
                GridView2.DataBind();
                #endregion

                #region most popular mix–ins
                var rankinMix = orderBLL.RankMixing();

                DataTable dt2 = new DataTable();
                dt2.Columns.AddRange(new DataColumn[2] {new DataColumn("Id",typeof(int)),
                        new DataColumn("Name",typeof(string)),
                         });
                 index = 1;
                rankinMix.ForEach(i =>
                {

                    dt2.Rows.Add(index, i["Mixing"].ToString());
                    index++;
                });
                GridView3.DataSource = dt2;
                GridView3.DataBind();
                #endregion
            }
        }
    }
}