namespace AUIDsgn
{
    partial class UIDsgnMainForm
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.uiMenuListControl1 = new AUIDsgn.Ctnl.UIMenuListControl();
            this.uiTemplateNServiceListControl1 = new AUIDsgn.Ctnl.UITemplateNServiceListControl();
            this.uiClzListControl1 = new AUIDsgn.Ctnl.UIClzListControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.uiMenuListControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1027, 499);
            this.splitContainer2.SplitterDistance = 253;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.uiTemplateNServiceListControl1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.uiClzListControl1);
            this.splitContainer3.Size = new System.Drawing.Size(770, 499);
            this.splitContainer3.SplitterDistance = 344;
            this.splitContainer3.TabIndex = 0;
            // 
            // uiMenuListControl1
            // 
            this.uiMenuListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiMenuListControl1.Location = new System.Drawing.Point(0, 0);
            this.uiMenuListControl1.Name = "uiMenuListControl1";
            this.uiMenuListControl1.Size = new System.Drawing.Size(253, 499);
            this.uiMenuListControl1.TabIndex = 0;
            // 
            // uiTemplateNServiceListControl1
            // 
            this.uiTemplateNServiceListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTemplateNServiceListControl1.Location = new System.Drawing.Point(0, 0);
            this.uiTemplateNServiceListControl1.Name = "uiTemplateNServiceListControl1";
            this.uiTemplateNServiceListControl1.Size = new System.Drawing.Size(344, 499);
            this.uiTemplateNServiceListControl1.TabIndex = 0;
            // 
            // uiClzListControl1
            // 
            this.uiClzListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiClzListControl1.Location = new System.Drawing.Point(0, 0);
            this.uiClzListControl1.Name = "uiClzListControl1";
            this.uiClzListControl1.Size = new System.Drawing.Size(422, 499);
            this.uiClzListControl1.TabIndex = 0;
            // 
            // UIDsgnMainForm
            // 
            this.ClientSize = new System.Drawing.Size(1027, 499);
            this.Controls.Add(this.splitContainer2);
            this.Name = "UIDsgnMainForm";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Ctnl.UIClzListControl uiClzDefControl1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Ctnl.UIMenuListControl uiMenuListControl1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private Ctnl.UITemplateNServiceListControl uiTemplateNServiceListControl1;
        private Ctnl.UIClzListControl uiClzListControl1;
    }
}

