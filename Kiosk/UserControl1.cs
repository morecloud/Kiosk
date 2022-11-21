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
    public partial class HamburgerForm : UserControl
    {
        //햄버거 주문 개수를 저장할 클래스 변수이다.
        static int Amount_BigMac = 0;
        static int Amount_Shanghia = 0;
        static int Amount_Deluxe = 0 ;
        static int Amount_DoubleBulgogi = 0;

       

        private Form1 mainform ;
        
        public HamburgerForm()
        {
            InitializeComponent();
            
        }
        public HamburgerForm(Form1 mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void Deluxe_Click(object sender, EventArgs e)
        {
           
            Amount_Deluxe++;
            

            classes.Product Deluxe = new classes.Product("Deluxe", 9900);

            classes.Total.total_ += Deluxe.GetPrice();

            mainform.FillList(Deluxe, Amount_Deluxe);
            mainform.updateLabel(Deluxe);
        }

        private void BigMac_Click(object sender, EventArgs e)
        {
            Amount_BigMac++;

            classes.Product BigMac = new classes.Product("BigMac", 9800);

            classes.Total.total_  += BigMac.GetPrice();

            mainform.FillList(BigMac, Amount_BigMac);
            mainform.updateLabel(BigMac);
        }

        private void DoubleBulgogi_Click(object sender, EventArgs e)
        {
            Amount_DoubleBulgogi++;

            classes.Product DoubleBulgogi = new classes.Product("DoubleBulgogi", 8900);

            classes.Total.total_ += DoubleBulgogi.GetPrice();


            mainform.FillList(DoubleBulgogi, Amount_DoubleBulgogi);
            mainform.updateLabel(DoubleBulgogi);
        }

        private void Shanghia_Click(object sender, EventArgs e)
        {
            Amount_Shanghia++;
            
            classes.Product Shanghia = new classes.Product("Shanghia", 8888);

            classes.Total.total_ += Shanghia.GetPrice();

            mainform.FillList(Shanghia, Amount_Shanghia);
            mainform.updateLabel(Shanghia);
        }
    }
}
