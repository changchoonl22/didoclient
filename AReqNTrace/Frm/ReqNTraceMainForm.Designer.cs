namespace AReqNTrace
{
    partial class ReqNTraceMainForm
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
            this.rfpReqDefControl1 = new AReqNTrace.Ctnl.RFPReqDefControl();
            this.reqDefControl1 = new AReqNTrace.Ctnl.ReqDefControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.rfpReqDefControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reqDefControl1);
            this.splitContainer1.Size = new System.Drawing.Size(839, 480);
            this.splitContainer1.SplitterDistance = 457;
            this.splitContainer1.TabIndex = 0;
            // 
            // rfpReqDefControl1
            // 
            this.rfpReqDefControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rfpReqDefControl1.Location = new System.Drawing.Point(0, 0);
            this.rfpReqDefControl1.Name = "rfpReqDefControl1";
            this.rfpReqDefControl1.Size = new System.Drawing.Size(457, 480);
            this.rfpReqDefControl1.TabIndex = 0;
            // 
            // reqDefControl1
            // 
            this.reqDefControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reqDefControl1.Location = new System.Drawing.Point(0, 0);
            this.reqDefControl1.Name = "reqDefControl1";
            this.reqDefControl1.Size = new System.Drawing.Size(378, 480);
            this.reqDefControl1.TabIndex = 0;
            // 
            // ReqNTraceMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 480);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ReqNTraceMainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Ctnl.RFPReqDefControl rfpReqDefControl1;
        private Ctnl.ReqDefControl reqDefControl1;
    }
}

