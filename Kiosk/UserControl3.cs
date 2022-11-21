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
    public partial class DrinkForm : UserControl
    {
        static int Amount_CocaCola = 0;
        static int Amount_CocaColaZero = 0;
        static int Amount_OrangeJuice = 0;


        private Form1 mainform;
        
        public DrinkForm(Form1 mainform)
        {
            InitializeComponent();

            this.mainform = mainform;
        }

        private void CocaCola_Click(object sender, EventArgs e)
        {
            Amount_CocaCola++;


            classes.Product CocaCola = new classes.Product("CocaCola", 1500);

            classes.Total.total_ += CocaCola.GetPrice();

            mainform.FillList(CocaCola, Amount_CocaCola);
            mainform.updateLabel(CocaCola);
        }

        private void CocaColaZero_Click(object sender, EventArgs e)
        {
            Amount_CocaColaZero++;


            classes.Product CocaColaZero = new classes.Product("CocaColaZero", 1500);

            classes.Total.total_ += CocaColaZero.GetPrice();

            mainform.FillList(CocaColaZero, Amount_CocaColaZero);
            mainform.updateLabel(CocaColaZero);
        }

        private void OrangeJuice_Click(object sender, EventArgs e)
        {
            Amount_OrangeJuice++;


            classes.Product OrangeJuice = new classes.Product("OrangeJuice", 2500);

            classes.Total.total_ += OrangeJuice.GetPrice();

            mainform.FillList(OrangeJuice, Amount_OrangeJuice);
            mainform.updateLabel(OrangeJuice);
        }
    }
}
