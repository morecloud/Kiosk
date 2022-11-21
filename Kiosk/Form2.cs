using Kiosk.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Form2 : Form
    {

        int TotalMenu = classes.Total.total_;
        String order = "";

        private Form1 mainform;

        public Form2()
        {
            InitializeComponent();
        }


        public Form2(int TotalMenu,ListBox.ObjectCollection order)
        {
            InitializeComponent();
            this.TotalMenu = TotalMenu;

            foreach (var item in order)
            {
                this.txtOrder.Text += "\n" + item;
            }

            this.txtOrder.Text +=("\n========================================================"+"\n총 주문금액 : \t"+ TotalMenu);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (MessageBox.Show("결제하시겠습니까?", "결제여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("결제가 완료었습니다.", "결제완료");
                this.Close();
                Application.Restart();
            }
            else {
                MessageBox.Show("사용자가 결제를 취소했습니다.", "결제 오류");
                this.Close();
            }
        }
    }
}
