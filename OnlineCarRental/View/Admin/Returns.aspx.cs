﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineCarRental.View.Admin
{
    public partial class Returns : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Conn = new Models.Functions();
            ShowReturn();
        }

        Models.Functions Conn;
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void ShowReturn()
        {

            string Query = "select * from ReturnTbl ";
            ReturnList.DataSource = Conn.GetData(Query);
            ReturnList.DataBind();
        }
    }
}