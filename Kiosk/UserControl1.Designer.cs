namespace Kiosk
{
    partial class HamburgerForm
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HamburgerForm));
            this.BigMac = new System.Windows.Forms.Button();
            this.Shanghia = new System.Windows.Forms.Button();
            this.Deluxe = new System.Windows.Forms.Button();
            this.DoubleBulgogi = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // BigMac
            // 
            this.BigMac.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BigMac.ImageIndex = 0;
            this.BigMac.ImageList = this.imageList1;
            this.BigMac.Location = new System.Drawing.Point(20, 20);
            this.BigMac.Name = "BigMac";
            this.BigMac.Size = new System.Drawing.Size(100, 100);
            this.BigMac.TabIndex = 0;
            this.BigMac.Text = "BigMac";
            this.BigMac.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BigMac.UseVisualStyleBackColor = true;
            this.BigMac.Click += new System.EventHandler(this.BigMac_Click);
            // 
            // Shanghia
            // 
            this.Shanghia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Shanghia.ImageIndex = 1;
            this.Shanghia.ImageList = this.imageList1;
            this.Shanghia.Location = new System.Drawing.Point(140, 20);
            this.Shanghia.Name = "Shanghia";
            this.Shanghia.Size = new System.Drawing.Size(100, 100);
            this.Shanghia.TabIndex = 1;
            this.Shanghia.Text = "Shanghia";
            this.Shanghia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Shanghia.UseVisualStyleBackColor = true;
            this.Shanghia.Click += new System.EventHandler(this.Shanghia_Click);
            // 
            // Deluxe
            // 
            this.Deluxe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Deluxe.ImageIndex = 2;
            this.Deluxe.ImageList = this.imageList1;
            this.Deluxe.Location = new System.Drawing.Point(260, 20);
            this.Deluxe.Name = "Deluxe";
            this.Deluxe.Size = new System.Drawing.Size(100, 100);
            this.Deluxe.TabIndex = 2;
            this.Deluxe.Text = "Deluxe";
            this.Deluxe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Deluxe.UseVisualStyleBackColor = true;
            this.Deluxe.Click += new System.EventHandler(this.Deluxe_Click);
            // 
            // DoubleBulgogi
            // 
            this.DoubleBulgogi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DoubleBulgogi.ImageIndex = 3;
            this.DoubleBulgogi.ImageList = this.imageList1;
            this.DoubleBulgogi.Location = new System.Drawing.Point(380, 20);
            this.DoubleBulgogi.Name = "DoubleBulgogi";
            this.DoubleBulgogi.Size = new System.Drawing.Size(100, 100);
            this.DoubleBulgogi.TabIndex = 3;
            this.DoubleBulgogi.Text = "DoubleBulgogi";
            this.DoubleBulgogi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DoubleBulgogi.UseVisualStyleBackColor = true;
            this.DoubleBulgogi.Click += new System.EventHandler(this.DoubleBulgogi_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "빅맥.jpg");
            this.imageList1.Images.SetKeyName(1, "상하이버거.jpg");
            this.imageList1.Images.SetKeyName(2, "디럭스.jpg");
            this.imageList1.Images.SetKeyName(3, "더블불고기.jpg");
            // 
            // HamburgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DoubleBulgogi);
            this.Controls.Add(this.Deluxe);
            this.Controls.Add(this.Shanghia);
            this.Controls.Add(this.BigMac);
            this.Name = "HamburgerForm";
            this.Size = new System.Drawing.Size(500, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BigMac;
        private System.Windows.Forms.Button Shanghia;
        private System.Windows.Forms.Button Deluxe;
        private System.Windows.Forms.Button DoubleBulgogi;
        private System.Windows.Forms.ImageList imageList1;
    }
}
