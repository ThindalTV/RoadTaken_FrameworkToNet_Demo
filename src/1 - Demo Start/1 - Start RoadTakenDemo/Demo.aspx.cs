﻿using System;
using System.Configuration;
using System.Web.UI;

namespace RoadTakenDemoTemplate
{
    public partial class Demo : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            litFirstNumber.Text = ConfigurationManager.AppSettings["FirstNumber"];
            if (!IsPostBack)
            {
                txtSecondNumber.Text = "0";
            }
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            var intFirstNumber = Int32.Parse(litFirstNumber.Text);
            var intSecondNumber = Int32.Parse(txtSecondNumber.Text);
            var intResult = intFirstNumber + intSecondNumber;
            litResult.Text = intResult.ToString();
        }
    }
}