using BUS.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace _3.PL.Views
{
    public partial class FrmThongKeDoanhThu : Form
    {
        private int monthOrYear = 0;
        List<ReportType> reports;
        public FrmThongKeDoanhThu()
        {
            InitializeComponent();
            reports = new List<ReportType>();
        }
        private void LoadData()
        {
            AnalyticsBLL analyticsBLL = new AnalyticsBLL();
            if (this.monthOrYear == 0)
            {
                this.reports = analyticsBLL.GetAnalyticsByMonth(this.dateThongKe.Value.Month, this.dateThongKe.Value.Year);
            }
            else
            {
                this.reports = analyticsBLL.GetAnalyticsByYear(this.dateThongKe.Value.Year);
            }
            this.dgridDoanhThu.DataSource = reports;
        }
        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.monthOrYear == 0)return;
            this.monthOrYear = 0;
            this.LoadData();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.monthOrYear == 1)return;
            this.monthOrYear = 1;
            this.LoadData();
        }

        private void dateThongKe_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.ShowDialog();
            if (this.saveFileDialog.FileName != "")
            {
                Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbook wb = application.Workbooks.Add(Type.Missing);
                try
                {
                    Excel.Worksheet sheet = wb.ActiveSheet;
                    sheet.Name = "Report";

                    sheet.Cells[1, 1].Value = "Ngày";
                    sheet.Cells[1, 2].Value = "Tổng doanh thu";
                    sheet.Cells[1, 3].Value = "Số lượng đơn hàng";

                    for (int i = 0; i < this.reports.Count; i++)
                    {
                        sheet.Cells[i + 2, 1].Value = this.reports[i].ngaychon1;
                        sheet.Cells[i + 2, 2].Value = this.reports[i].doanhthu1;
                        sheet.Cells[i + 2, 3].Value = this.reports[i].sodon1;
                    }
                    wb.SaveAs(this.saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                finally
                {
                    application.Quit();
                    wb = null;
                }
            }

        }
    }
}



