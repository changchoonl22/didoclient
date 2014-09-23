namespace ACompDsgn
{
    partial class ACompDsgnMainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.udaClusteringControl1 = new ACompDsgn.Ctnl.UdaClusteringControl();
            this.compListControl1 = new ACompDsgn.Ctnl.CompListControl();
            this.compItemControl1 = new ACompDsgn.Ctnl.CompItemControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(948, 517);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.udaClusteringControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(940, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UDA클러스터링";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(940, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "컴포넌트설계";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.compListControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.compItemControl1);
            this.splitContainer1.Size = new System.Drawing.Size(934, 485);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 0;
            // 
            // udaClusteringControl1
            // 
            this.udaClusteringControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.udaClusteringControl1.Location = new System.Drawing.Point(3, 3);
            this.udaClusteringControl1.Name = "udaClusteringControl1";
            this.udaClusteringControl1.Size = new System.Drawing.Size(934, 485);
            this.udaClusteringControl1.TabIndex = 0;
            // 
            // compListControl1
            // 
            this.compListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compListControl1.Location = new System.Drawing.Point(0, 0);
            this.compListControl1.Name = "compListControl1";
            this.compListControl1.Size = new System.Drawing.Size(934, 311);
            this.compListControl1.TabIndex = 0;
            // 
            // compItemControl1
            // 
            this.compItemControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compItemControl1.Location = new System.Drawing.Point(0, 0);
            this.compItemControl1.Name = "compItemControl1";
            this.compItemControl1.Size = new System.Drawing.Size(934, 170);
            this.compItemControl1.TabIndex = 0;
            // 
            // ACompDsgnMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 517);
            this.Controls.Add(this.tabControl1);
            this.Name = "ACompDsgnMainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Ctnl.UdaClusteringControl udaClusteringControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Ctnl.CompListControl compListControl1;
        private Ctnl.CompItemControl compItemControl1;
    }
}

