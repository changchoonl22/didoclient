namespace AIfDsgn
{
    partial class IfDsgnMainForm
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ifSystemListControl1 = new AIfDsgn.Ctnl.IfSystemListControl();
            this.ifItemListControl1 = new AIfDsgn.Ctnl.IfItemListControl();
            this.ifItemDetailControl1 = new AIfDsgn.Ctnl.IfItemDetailControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ifSystemListControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1097, 524);
            this.splitContainer1.SplitterDistance = 365;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ifItemListControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ifItemDetailControl1);
            this.splitContainer2.Size = new System.Drawing.Size(728, 524);
            this.splitContainer2.SplitterDistance = 249;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            // 
            // ifSystemListControl1
            // 
            this.ifSystemListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ifSystemListControl1.Location = new System.Drawing.Point(0, 0);
            this.ifSystemListControl1.Name = "ifSystemListControl1";
            this.ifSystemListControl1.Size = new System.Drawing.Size(365, 524);
            this.ifSystemListControl1.TabIndex = 0;
            // 
            // ifItemListControl1
            // 
            this.ifItemListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ifItemListControl1.Location = new System.Drawing.Point(0, 0);
            this.ifItemListControl1.Name = "ifItemListControl1";
            this.ifItemListControl1.Size = new System.Drawing.Size(728, 249);
            this.ifItemListControl1.TabIndex = 1;
            // 
            // ifItemDetailControl1
            // 
            this.ifItemDetailControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ifItemDetailControl1.Location = new System.Drawing.Point(0, 0);
            this.ifItemDetailControl1.Name = "ifItemDetailControl1";
            this.ifItemDetailControl1.Size = new System.Drawing.Size(728, 271);
            this.ifItemDetailControl1.TabIndex = 0;
            // 
            // IfDsgnMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 524);
            this.Controls.Add(this.splitContainer1);
            this.Name = "IfDsgnMainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Ctnl.IfSystemListControl ifSystemListControl1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Ctnl.IfItemListControl ifItemListControl1;
        private Ctnl.IfItemDetailControl ifItemDetailControl1;
    }
}

