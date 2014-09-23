namespace ATestMgr
{
    partial class TestMgrMainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.uiMenuListControl1 = new AUIDsgn.Ctnl.UIMenuListControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.testCasePlanControl1 = new ATestMgr.Ctnl.TestCasePlanControl();
            this.testCaseControl1 = new ATestMgr.Ctnl.TestCaseControl();
            this.testResultControl1 = new ATestMgr.Ctnl.TestResultControl();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.uiMenuListControl2 = new AUIDsgn.Ctnl.UIMenuListControl();
            this.testCasePlanControl2 = new ATestMgr.Ctnl.TestCasePlanControl();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.testCaseControl2 = new ATestMgr.Ctnl.TestCaseControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.testResultControl2 = new ATestMgr.Ctnl.TestResultControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(922, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(914, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "단위테스트";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.uiMenuListControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(908, 420);
            this.splitContainer1.SplitterDistance = 302;
            this.splitContainer1.TabIndex = 0;
            // 
            // uiMenuListControl1
            // 
            this.uiMenuListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiMenuListControl1.Location = new System.Drawing.Point(0, 0);
            this.uiMenuListControl1.Name = "uiMenuListControl1";
            this.uiMenuListControl1.Size = new System.Drawing.Size(302, 420);
            this.uiMenuListControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(914, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "통합테스트";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.splitContainer2.Panel1.Controls.Add(this.testCasePlanControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer2.Size = new System.Drawing.Size(602, 420);
            this.splitContainer2.SplitterDistance = 246;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(602, 170);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.testCaseControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(594, 144);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "테스트케이스정의";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.testResultControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(594, 144);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "테스트결과";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // testCasePlanControl1
            // 
            this.testCasePlanControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testCasePlanControl1.Location = new System.Drawing.Point(0, 0);
            this.testCasePlanControl1.Name = "testCasePlanControl1";
            this.testCasePlanControl1.Size = new System.Drawing.Size(602, 246);
            this.testCasePlanControl1.TabIndex = 0;
            // 
            // testCaseControl1
            // 
            this.testCaseControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testCaseControl1.Location = new System.Drawing.Point(3, 3);
            this.testCaseControl1.Name = "testCaseControl1";
            this.testCaseControl1.Size = new System.Drawing.Size(588, 138);
            this.testCaseControl1.TabIndex = 0;
            // 
            // testResultControl1
            // 
            this.testResultControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testResultControl1.Location = new System.Drawing.Point(3, 3);
            this.testResultControl1.Name = "testResultControl1";
            this.testResultControl1.Size = new System.Drawing.Size(588, 138);
            this.testResultControl1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.uiMenuListControl2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(908, 420);
            this.splitContainer3.SplitterDistance = 302;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.testCasePlanControl2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tabControl3);
            this.splitContainer4.Size = new System.Drawing.Size(602, 420);
            this.splitContainer4.SplitterDistance = 200;
            this.splitContainer4.TabIndex = 0;
            // 
            // uiMenuListControl2
            // 
            this.uiMenuListControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiMenuListControl2.Location = new System.Drawing.Point(0, 0);
            this.uiMenuListControl2.Name = "uiMenuListControl2";
            this.uiMenuListControl2.Size = new System.Drawing.Size(302, 420);
            this.uiMenuListControl2.TabIndex = 1;
            // 
            // testCasePlanControl2
            // 
            this.testCasePlanControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testCasePlanControl2.Location = new System.Drawing.Point(0, 0);
            this.testCasePlanControl2.Name = "testCasePlanControl2";
            this.testCasePlanControl2.Size = new System.Drawing.Size(602, 200);
            this.testCasePlanControl2.TabIndex = 1;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(602, 216);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.testCaseControl2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(594, 190);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "테스트케이스정의";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // testCaseControl2
            // 
            this.testCaseControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testCaseControl2.Location = new System.Drawing.Point(3, 3);
            this.testCaseControl2.Name = "testCaseControl2";
            this.testCaseControl2.Size = new System.Drawing.Size(588, 184);
            this.testCaseControl2.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.testResultControl2);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(594, 144);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "테스트결과";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // testResultControl2
            // 
            this.testResultControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testResultControl2.Location = new System.Drawing.Point(3, 3);
            this.testResultControl2.Name = "testResultControl2";
            this.testResultControl2.Size = new System.Drawing.Size(588, 138);
            this.testResultControl2.TabIndex = 0;
            // 
            // TestMgrMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 452);
            this.Controls.Add(this.tabControl1);
            this.Name = "TestMgrMainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private AUIDsgn.Ctnl.UIMenuListControl uiMenuListControl1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Ctnl.TestCasePlanControl testCasePlanControl1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private Ctnl.TestCaseControl testCaseControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private Ctnl.TestResultControl testResultControl1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private AUIDsgn.Ctnl.UIMenuListControl uiMenuListControl2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private Ctnl.TestCasePlanControl testCasePlanControl2;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private Ctnl.TestCaseControl testCaseControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private Ctnl.TestResultControl testResultControl2;

    }
}

