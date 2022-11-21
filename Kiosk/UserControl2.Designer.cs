namespace Kiosk
{
    partial class SideForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideForm));
            this.FrnchFries = new System.Windows.Forms.Button();
            this.CheeseSticks = new System.Windows.Forms.Button();
            this.McNuggets = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // FrnchFries
            // 
            this.FrnchFries.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FrnchFries.ImageIndex = 0;
            this.FrnchFries.ImageList = this.imageList1;
            this.FrnchFries.Location = new System.Drawing.Point(20, 20);
            this.FrnchFries.Name = "FrnchFries";
            this.FrnchFries.Size = new System.Drawing.Size(100, 100);
            this.FrnchFries.TabIndex = 0;
            this.FrnchFries.Text = "FrnchFries";
            this.FrnchFries.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FrnchFries.UseVisualStyleBackColor = true;
            this.FrnchFries.Click += new System.EventHandler(this.FrnchFries_Click);
            // 
            // CheeseSticks
            // 
            this.CheeseSticks.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CheeseSticks.ImageIndex = 1;
            this.CheeseSticks.ImageList = this.imageList1;
            this.CheeseSticks.Location = new System.Drawing.Point(140, 20);
            this.CheeseSticks.Name = "CheeseSticks";
            this.CheeseSticks.Size = new System.Drawing.Size(100, 100);
            this.CheeseSticks.TabIndex = 1;
            this.CheeseSticks.Text = "CheeseSticks";
            this.CheeseSticks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CheeseSticks.UseVisualStyleBackColor = true;
            this.CheeseSticks.Click += new System.EventHandler(this.CheeseSticks_Click);
            // 
            // McNuggets
            // 
            this.McNuggets.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.McNuggets.ImageIndex = 2;
            this.McNuggets.ImageList = this.imageList1;
            this.McNuggets.Location = new System.Drawing.Point(260, 20);
            this.McNuggets.Name = "McNuggets";
            this.McNuggets.Size = new System.Drawing.Size(100, 100);
            this.McNuggets.TabIndex = 2;
            this.McNuggets.Text = "McNuggets";
            this.McNuggets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.McNuggets.UseVisualStyleBackColor = true;
            this.McNuggets.Click += new System.EventHandler(this.McNuggets_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "프렌치프라이.jpg");
            this.imageList1.Images.SetKeyName(1, "치즈스틱.jpg");
            this.imageList1.Images.SetKeyName(2, "맥너겟.jpg");
            // 
            // SideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.McNuggets);
            this.Controls.Add(this.CheeseSticks);
            this.Controls.Add(this.FrnchFries);
            this.Name = "SideForm";
            this.Size = new System.Drawing.Size(500, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FrnchFries;
        private System.Windows.Forms.Button CheeseSticks;
        private System.Windows.Forms.Button McNuggets;
        private System.Windows.Forms.ImageList imageList1;
    }
}
