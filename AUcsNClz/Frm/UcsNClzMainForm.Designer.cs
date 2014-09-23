namespace AUcsNClz.Frm
{
    partial class UcsNClzMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ucsListControl1 = new AUcsNClz.Ctnl.UcsListControl();
            this.clzDefControl1 = new AUcsNClz.Ctnl.ClzDefControl();
            this.eventFlowControl1 = new AUcsNClz.Ctnl.EventFlowControl();
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
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clzDefControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1015, 509);
            this.splitContainer1.SplitterDistance = 375;
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
            this.splitContainer2.Panel1.Controls.Add(this.ucsListControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.eventFlowControl1);
            this.splitContainer2.Size = new System.Drawing.Size(1015, 375);
            this.splitContainer2.SplitterDistance = 198;
            this.splitContainer2.TabIndex = 0;
            // 
            // ucsListControl1
            // 
            this.ucsListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucsListControl1.Location = new System.Drawing.Point(0, 0);
            this.ucsListControl1.Name = "ucsListControl1";
            this.ucsListControl1.Size = new System.Drawing.Size(198, 375);
            this.ucsListControl1.TabIndex = 0;
            // 
            // clzDefControl1
            // 
            this.clzDefControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clzDefControl1.Location = new System.Drawing.Point(0, 0);
            this.clzDefControl1.Name = "clzDefControl1";
            this.clzDefControl1.Size = new System.Drawing.Size(1015, 130);
            this.clzDefControl1.TabIndex = 0;
            // 
            // eventFlowControl1
            // 
            this.eventFlowControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventFlowControl1.Location = new System.Drawing.Point(0, 0);
            this.eventFlowControl1.Name = "eventFlowControl1";
            this.eventFlowControl1.Size = new System.Drawing.Size(813, 375);
            this.eventFlowControl1.TabIndex = 0;
            // 
            // UcsNClzMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 509);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UcsNClzMainForm";
            this.Text = "UcsNClzMainForm";
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
        private Ctnl.ClzDefControl clzDefControl1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Ctnl.UcsListControl ucsListControl1;
        private Ctnl.EventFlowControl eventFlowControl1;
    }
}