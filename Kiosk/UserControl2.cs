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
    public partial class SideForm : UserControl
    {
        //사이드 주문 개수를 저장할 클래스 변수이다.
        static int Amount_CheeseSticks = 0;
        static int Amount_FrnchFries = 0;
        static int Amount_McNuggets = 0;



        private Form1 mainform;
        
        public SideForm(Form1 mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void CheeseSticks_Click(object sender, EventArgs e)
        {
            Amount_CheeseSticks++;


            classes.Product CheeseSticks = new classes.Product("CheeseSticks", 3000);

            classes.Total.total_ += CheeseSticks.GetPrice();

            mainform.FillList(CheeseSticks, Amount_CheeseSticks);
            mainform.updateLabel(CheeseSticks);
        }

        private void FrnchFries_Click(object sender, EventArgs e)
        {
            Amount_FrnchFries++;


            classes.Product FrnchFries = new classes.Product("FrnchFries", 2000);

            classes.Total.total_ += FrnchFries.GetPrice();

            mainform.FillList(FrnchFries, Amount_FrnchFries);
            mainform.updateLabel(FrnchFries);
        }

        private void McNuggets_Click(object sender, EventArgs e)
        {
            Amount_McNuggets++;


            classes.Product McNuggets = new classes.Product("McNuggets", 5000);

            classes.Total.total_ += McNuggets.GetPrice();

            mainform.FillList(McNuggets, Amount_McNuggets);
            mainform.updateLabel(McNuggets);
        }
    }
}
