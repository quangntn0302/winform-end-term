using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using System.Globalization;
using System.Threading;

namespace CoffeeManager
{
    public partial class ucBill : UserControl
    {
        public ucBill()
        {
            InitializeComponent();
        }

        #region Method
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
            
        }
        #endregion
        #region Event
        #endregion

        private void ucBill_Load(object sender, EventArgs e)
        {
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            lblShow.Text = string.Format("Tổng doanh thu " + (Environment.NewLine) + "từ: {0} " + (Environment.NewLine) + "đến: {1}", dtpkFromDate.Value.ToString("dd/MM/yyyy"), dtpkToDate.Value.ToString("dd/MM/yyyy"));
            float sum = 0;
            for (int i = 0; i < dtgvBill.Rows.Count; i++)
                sum += (float)Convert.ToDouble(dtgvBill.Rows[i].Cells[2].Value);
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txbBillDate.Text = sum.ToString("c");
        }

        private void btnCheckBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            lblShow.Text = string.Format("Tổng doanh thu " + (Environment.NewLine) + "từ: {0} " + (Environment.NewLine) + "đến: {1}", dtpkFromDate.Value.ToString("dd/MM/yyyy"), dtpkToDate.Value.ToString("dd/MM/yyyy"));
            float sum = 0;
            for (int i = 0; i < dtgvBill.Rows.Count; i++)
                sum += (float)Convert.ToDouble(dtgvBill.Rows[i].Cells[2].Value);
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txbBillDate.Text = sum.ToString("c");
        }

        private void btnReportBill_Click(object sender, EventArgs e)
        {
            fReportBill f = new fReportBill();
            f.ShowDialog();
        }
    }
}
