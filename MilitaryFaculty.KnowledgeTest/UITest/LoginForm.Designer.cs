namespace UITest
{
    partial class LoginForm
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
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this._testButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTeacher
            // 
            this.btnTeacher.Location = new System.Drawing.Point(268, 56);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(135, 59);
            this.btnTeacher.TabIndex = 0;
            this.btnTeacher.Text = "Войти как преподаватель";
            this.btnTeacher.UseVisualStyleBackColor = true;
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(268, 147);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(135, 56);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Войти как студент";
            this.btnStudent.UseVisualStyleBackColor = true;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPassword.Location = new System.Drawing.Point(443, 71);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(134, 26);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // _testButton
            // 
            this._testButton.Location = new System.Drawing.Point(36, 87);
            this._testButton.Name = "_testButton";
            this._testButton.Size = new System.Drawing.Size(149, 93);
            this._testButton.TabIndex = 3;
            this._testButton.Text = "button1";
            this._testButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnTeacher;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 282);
            this.Controls.Add(this._testButton);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnTeacher);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button _testButton;
    }
}