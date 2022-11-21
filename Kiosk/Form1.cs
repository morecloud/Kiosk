using Kiosk.classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kiosk
{
    public partial class Form1 : Form
    {
        private Control control = null;
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Hamburger_Click(object sender, EventArgs e)
        {
            if (control != null) panel1.Controls.Remove(control);
            control = new HamburgerForm(this);
            panel1.Controls.Add(control);
        }

        private void Side_Click(object sender, EventArgs e)
        {
            if (control != null) panel1.Controls.Remove(control);
            control = new SideForm(this);
            panel1.Controls.Add(control);
        }

        private void Drink_Click(object sender, EventArgs e)
        {
            if (control != null) panel1.Controls.Remove(control);
            control = new DrinkForm(this);
            panel1.Controls.Add(control);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            var MenuBoxList = MenuBox.Items;




            Form2 _From = new Form2(classes.Total.total_,MenuBoxList);

            _From.Show();
        }

        public void updateLabel(Product product) {
            lblName.Text = product.GetName();
            lblPrice.Text = Convert.ToString(product.GetPrice());
        }

        //상품의 이름 , 개수, 가격을 리스트 박스에 기록하는 함수이다.
        public void FillList(Product product, int amount) {
            //상품 정보를 가지고 있는 product객체와 상품의 개수를 저장하는 정수형 변수인 amount를 매개변수로 입력받는다.

            //기록할 상품 정보의 형식은 이름 , 수량  , 가격(총 가격)이다.
            var name = product.GetName();
            int price = product.GetPrice();
            int num = amount;

                
            if (this.MenuBox.Items.Count > 0)
            {
                
                //상품의 위치를 나타내는 정수형 변수이다.
                int idx = this.MenuBox.FindString(name);
               
                String information = name + " " + num + " " + num * price;

                if (idx > -1)
                {
                    this.MenuBox.Items.RemoveAt(idx);
                    this.MenuBox.Items.Insert(idx, information);
                }
                else {
                    this.MenuBox.Items.Add(information);

                }
                
               
            }
            else {
                //처음 항목을 추가할 때
                String information = name + " " + num + " " + num * price;
                this.MenuBox.Items.Add(information);
                
             
            }
          


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MenuBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (control != null) panel1.Controls.Remove(control);
            control = new HamburgerForm(this);
            panel1.Controls.Add(control);
        }
    }
}
