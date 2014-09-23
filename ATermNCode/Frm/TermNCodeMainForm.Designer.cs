namespace ATermNCode
{
    partial class TermNCodeMainForm
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.toBeDDListControl1 = new ATermNCode.Ctnl.ToBeDDListControl();
            this.asisddListControl1 = new ATermNCode.Ctnl.ASISDDListControl();
            this.diffDDListControl1 = new ATermNCode.Ctnl.DiffDDListControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.codeListControl1 = new ATermNCode.Ctnl.CodeListControl();
            this.codeControl1 = new ATermNCode.Ctnl.CodeControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.codeSearchControl1 = new ATermNCode.Ctnl.CodeSearchControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.useTermList = new ATermNCode.Ctnl.TermListControl();
            this.termControl = new ATermNCode.Ctnl.TermControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.termSearchControl = new ATermNCode.Ctnl.TermSearchControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(800, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "도메인정의";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.diffDDListControl1);
            this.splitContainer3.Size = new System.Drawing.Size(794, 403);
            this.splitContainer3.SplitterDistance = 279;
            this.splitContainer3.TabIndex = 1;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.toBeDDListControl1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.asisddListControl1);
            this.splitContainer4.Size = new System.Drawing.Size(794, 279);
            this.splitContainer4.SplitterDistance = 404;
            this.splitContainer4.TabIndex = 0;
            // 
            // toBeDDListControl1
            // 
            this.toBeDDListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toBeDDListControl1.Location = new System.Drawing.Point(0, 0);
            this.toBeDDListControl1.Name = "toBeDDListControl1";
            this.toBeDDListControl1.Size = new System.Drawing.Size(404, 279);
            this.toBeDDListControl1.TabIndex = 0;
            // 
            // asisddListControl1
            // 
            this.asisddListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asisddListControl1.Location = new System.Drawing.Point(0, 0);
            this.asisddListControl1.Name = "asisddListControl1";
            this.asisddListControl1.Size = new System.Drawing.Size(386, 279);
            this.asisddListControl1.TabIndex = 0;
            // 
            // diffDDListControl1
            // 
            this.diffDDListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diffDDListControl1.Location = new System.Drawing.Point(0, 0);
            this.diffDDListControl1.Name = "diffDDListControl1";
            this.diffDDListControl1.Size = new System.Drawing.Size(794, 120);
            this.diffDDListControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(800, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "코드정의";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 56);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.codeListControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.codeControl1);
            this.splitContainer2.Size = new System.Drawing.Size(794, 350);
            this.splitContainer2.SplitterDistance = 428;
            this.splitContainer2.TabIndex = 1;
            // 
            // codeListControl1
            // 
            this.codeListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeListControl1.Location = new System.Drawing.Point(0, 0);
            this.codeListControl1.Name = "codeListControl1";
            this.codeListControl1.Size = new System.Drawing.Size(428, 350);
            this.codeListControl1.TabIndex = 0;
            // 
            // codeControl1
            // 
            this.codeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeControl1.Location = new System.Drawing.Point(0, 0);
            this.codeControl1.Name = "codeControl1";
            this.codeControl1.Size = new System.Drawing.Size(362, 350);
            this.codeControl1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.codeSearchControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 53);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // codeSearchControl1
            // 
            this.codeSearchControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeSearchControl1.Location = new System.Drawing.Point(3, 17);
            this.codeSearchControl1.Name = "codeSearchControl1";
            this.codeSearchControl1.Size = new System.Drawing.Size(788, 33);
            this.codeSearchControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(800, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "용어정의";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 51);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.useTermList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.termControl);
            this.splitContainer1.Size = new System.Drawing.Size(794, 355);
            this.splitContainer1.SplitterDistance = 420;
            this.splitContainer1.TabIndex = 2;
            // 
            // useTermList
            // 
            this.useTermList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.useTermList.Location = new System.Drawing.Point(0, 0);
            this.useTermList.Name = "useTermList";
            this.useTermList.Size = new System.Drawing.Size(420, 355);
            this.useTermList.TabIndex = 0;
            // 
            // termControl
            // 
            this.termControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.termControl.Location = new System.Drawing.Point(0, 0);
            this.termControl.Name = "termControl";
            this.termControl.Size = new System.Drawing.Size(370, 355);
            this.termControl.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.termSearchControl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // termSearchControl
            // 
            this.termSearchControl.Location = new System.Drawing.Point(6, 15);
            this.termSearchControl.Name = "termSearchControl";
            this.termSearchControl.Size = new System.Drawing.Size(548, 27);
            this.termSearchControl.TabIndex = 0;
            this.termSearchControl.SearchButtonClicked += new System.EventHandler<ATermNCode.Ctnl.TermSearchControl.SearchButtonClickedEventArgs>(this.termSearchControl_SearchButtonClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(808, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // TermNCodeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 435);
            this.Controls.Add(this.tabControl1);
            this.Name = "TermNCodeMainForm";
            this.Text = "Form1";
            this.tabPage3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Ctnl.TermListControl useTermList;
        private Ctnl.TermControl termControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Ctnl.CodeListControl codeListControl1;
        private Ctnl.CodeControl codeControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Ctnl.CodeSearchControl codeSearchControl1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private Ctnl.ToBeDDListControl toBeDDListControl1;
        private Ctnl.ASISDDListControl asisddListControl1;
        private Ctnl.DiffDDListControl diffDDListControl1;
        private Ctnl.TermSearchControl termSearchControl;

    }
}

