using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace qlsv_LeVanDoanh_21203100015_LTNET_M12
{
    public partial class Form1 : Form
    {
        private String sql;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sql = "select * from SinhVien";
            dgv_sv.DataSource = DataAccess.GetData(sql);
            dgv_sv.Columns[0].HeaderText = "Ma SV";
            dgv_sv.Columns[1].HeaderText = "Ten SV";
            dgv_sv.Columns[2].HeaderText = "Ngay Sinh";
            dgv_sv.Columns[3].HeaderText = "Diem Tb";
            dgv_sv.Columns[2].DefaultCellStyle.Format = "dd MM yyyy";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql ="insert into SinhVien values('"+txt_msv.Text+"',N'"+txt_tsv.Text+"','"+date.Value.ToString("yyyy-MM-dd")+"',"+txt_dtb.Text+")";
            DataAccess.Update(sql);
            sql = "select * from SinhVien";
            dgv_sv.DataSource = DataAccess.GetData(sql);
            dgv_sv.Columns[0].HeaderText = "Ma SV";
            dgv_sv.Columns[1].HeaderText = "Ten SV";
            dgv_sv.Columns[2].HeaderText = "Ngay Sinh";
            dgv_sv.Columns[3].HeaderText = "Diem Tb";
            dgv_sv.Columns[2].DefaultCellStyle.Format = "dd MM yyyy";
        }
    }
}
