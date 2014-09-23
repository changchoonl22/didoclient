namespace ABizNObj
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.bizPkgListControl1 = new ABizNObj.Ctnl.BizPkgListControl();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bizRuleListControl1 = new ABizNObj.Ctnl.BizRuleListControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bizObjDefControl1 = new ABizNObj.Ctnl.BizObjDefControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.termDefControl1 = new ABizNObj.Ctnl.TermDefControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.codeDefControl1 = new ABizNObj.Ctnl.CodeDefControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ddDefControl1 = new ABizNObj.Ctnl.DDDefControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(925, 462);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.bizPkgListControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(925, 297);
            this.splitContainer2.SplitterDistance = 229;
            this.splitContainer2.TabIndex = 0;
            // 
            // bizPkgListControl1
            // 
            this.bizPkgListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bizPkgListControl1.Location = new System.Drawing.Point(0, 0);
            this.bizPkgListControl1.Name = "bizPkgListControl1";
            this.bizPkgListControl1.Size = new System.Drawing.Size(229, 297);
            this.bizPkgListControl1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.bizRuleListControl1);
            this.splitContainer3.Size = new System.Drawing.Size(692, 297);
            this.splitContainer3.SplitterDistance = 431;
            this.splitContainer3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 297);
            this.panel1.TabIndex = 0;
            // 
            // bizRuleListControl1
            // 
            this.bizRuleListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bizRuleListControl1.Location = new System.Drawing.Point(0, 0);
            this.bizRuleListControl1.Name = "bizRuleListControl1";
            this.bizRuleListControl1.Size = new System.Drawing.Size(257, 297);
            this.bizRuleListControl1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 161);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bizObjDefControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(917, 135);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "객체정의";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bizObjDefControl1
            // 
            this.bizObjDefControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bizObjDefControl1.Location = new System.Drawing.Point(3, 3);
            this.bizObjDefControl1.Name = "bizObjDefControl1";
            this.bizObjDefControl1.Size = new System.Drawing.Size(911, 129);
            this.bizObjDefControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.termDefControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(917, 135);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "용어정의";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // termDefControl1
            // 
            this.termDefControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.termDefControl1.Location = new System.Drawing.Point(3, 3);
            this.termDefControl1.Name = "termDefControl1";
            this.termDefControl1.Size = new System.Drawing.Size(911, 129);
            this.termDefControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.codeDefControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(917, 135);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "코드정의";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // codeDefControl1
            // 
            this.codeDefControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeDefControl1.Location = new System.Drawing.Point(3, 3);
            this.codeDefControl1.Name = "codeDefControl1";
            this.codeDefControl1.Size = new System.Drawing.Size(911, 129);
            this.codeDefControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ddDefControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(917, 135);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "도메인정의";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ddDefControl1
            // 
            this.ddDefControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddDefControl1.Location = new System.Drawing.Point(3, 3);
            this.ddDefControl1.Name = "ddDefControl1";
            this.ddDefControl1.Size = new System.Drawing.Size(911, 129);
            this.ddDefControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 462);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Ctnl.BizPkgListControl bizPkgListControl1;
        private Ctnl.BizRuleListControl bizRuleListControl1;
        private Ctnl.BizObjDefControl bizObjDefControl1;
        private Ctnl.CodeDefControl codeDefControl1;
        private Ctnl.DDDefControl ddDefControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private Ctnl.TermDefControl termDefControl1;
        private System.Windows.Forms.Panel panel1;
    }
}

