namespace ALoginNRegister
{
    partial class RegisterForm
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
            this.registerControl1 = new ALoginNRegister.RegisterControl();
            this.SuspendLayout();
            // 
            // registerControl1
            // 
            this.registerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerControl1.Location = new System.Drawing.Point(0, 0);
            this.registerControl1.Name = "registerControl1";
            this.registerControl1.Size = new System.Drawing.Size(233, 56);
            this.registerControl1.TabIndex = 0;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 56);
            this.Controls.Add(this.registerControl1);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);

        }

        #endregion

        private RegisterControl registerControl1;
    }
}