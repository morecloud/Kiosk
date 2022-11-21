namespace Kiosk
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Hamburger = new System.Windows.Forms.Button();
            this.Side = new System.Windows.Forms.Button();
            this.Drink = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // Hamburger
            // 
            this.Hamburger.Location = new System.Drawing.Point(26, 31);
            this.Hamburger.Name = "Hamburger";
            this.Hamburger.Size = new System.Drawing.Size(140, 50);
            this.Hamburger.TabIndex = 3;
            this.Hamburger.Text = "Hamburger";
            this.Hamburger.UseVisualStyleBackColor = true;
            this.Hamburger.Click += new System.EventHandler(this.Hamburger_Click);
            // 
            // Side
            // 
            this.Side.Location = new System.Drawing.Point(26, 87);
            this.Side.Name = "Side";
            this.Side.Size = new System.Drawing.Size(140, 50);
            this.Side.TabIndex = 3;
            this.Side.Text = "Side";
            this.Side.UseVisualStyleBackColor = true;
            this.Side.Click += new System.EventHandler(this.Side_Click);
            // 
            // Drink
            // 
            this.Drink.Location = new System.Drawing.Point(26, 143);
            this.Drink.Name = "Drink";
            this.Drink.Size = new System.Drawing.Size(140, 50);
            this.Drink.TabIndex = 3;
            this.Drink.Text = "Drink";
            this.Drink.UseVisualStyleBackColor = true;
            this.Drink.Click += new System.EventHandler(this.Drink_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(250, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 300);
            this.panel1.TabIndex = 4;
            // 
            // MenuBox
            // 
            this.MenuBox.FormattingEnabled = true;
            this.MenuBox.ItemHeight = 12;
            this.MenuBox.Location = new System.Drawing.Point(23, 270);
            this.MenuBox.Name = "MenuBox";
            this.MenuBox.Size = new System.Drawing.Size(206, 160);
            this.MenuBox.TabIndex = 5;
            this.MenuBox.SelectedIndexChanged += new System.EventHandler(this.MenuBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "메뉴";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(244, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "가격 :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 93);
            this.button1.TabIndex = 9;
            this.button1.Text = "결제하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 93);
            this.button2.TabIndex = 10;
            this.button2.Text = "첫 화면으로 돌아가기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(244, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "메뉴이름 :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(331, 372);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 16);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "???";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrice.Location = new System.Drawing.Point(296, 408);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 16);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "$ 0";
            this.lblPrice.Click += new System.EventHandler(this.label5_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Drink);
            this.Controls.Add(this.Side);
            this.Controls.Add(this.Hamburger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Hamburger;
        private System.Windows.Forms.Button Side;
        private System.Windows.Forms.Button Drink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox MenuBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ImageList imageList1;
    }
}

