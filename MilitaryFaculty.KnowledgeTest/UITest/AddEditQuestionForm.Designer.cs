namespace UITest
{
    partial class AddEditQuestionForm
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
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxDescrition = new System.Windows.Forms.TextBox();
            this.cmbxCounters = new System.Windows.Forms.ComboBox();
            this.tbxVariant1 = new System.Windows.Forms.TextBox();
            this.tbxVariant2 = new System.Windows.Forms.TextBox();
            this.tbxVariant3 = new System.Windows.Forms.TextBox();
            this.tbxVariant4 = new System.Windows.Forms.TextBox();
            this.tbxVariant5 = new System.Windows.Forms.TextBox();
            this.chbxVariant1 = new System.Windows.Forms.CheckBox();
            this.chbxVariant2 = new System.Windows.Forms.CheckBox();
            this.chbxVariant3 = new System.Windows.Forms.CheckBox();
            this.chbxVariant4 = new System.Windows.Forms.CheckBox();
            this.chbxVariant5 = new System.Windows.Forms.CheckBox();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(463, 383);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(172, 44);
            this.btnAddQuestion.TabIndex = 0;
            this.btnAddQuestion.Text = "Добавить";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(30, 27);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(135, 16);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Название вопроса:";
            // 
            // tbxDescrition
            // 
            this.tbxDescrition.Location = new System.Drawing.Point(12, 56);
            this.tbxDescrition.Multiline = true;
            this.tbxDescrition.Name = "tbxDescrition";
            this.tbxDescrition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDescrition.Size = new System.Drawing.Size(388, 286);
            this.tbxDescrition.TabIndex = 2;
            // 
            // cmbxCounters
            // 
            this.cmbxCounters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCounters.FormattingEnabled = true;
            this.cmbxCounters.Location = new System.Drawing.Point(136, 383);
            this.cmbxCounters.Name = "cmbxCounters";
            this.cmbxCounters.Size = new System.Drawing.Size(121, 21);
            this.cmbxCounters.TabIndex = 3;
            this.cmbxCounters.SelectedIndexChanged += new System.EventHandler(this.cmbxCounters_SelectedIndexChanged);
            // 
            // tbxVariant1
            // 
            this.tbxVariant1.Location = new System.Drawing.Point(563, 56);
            this.tbxVariant1.Multiline = true;
            this.tbxVariant1.Name = "tbxVariant1";
            this.tbxVariant1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxVariant1.Size = new System.Drawing.Size(446, 38);
            this.tbxVariant1.TabIndex = 9;
            // 
            // tbxVariant2
            // 
            this.tbxVariant2.Location = new System.Drawing.Point(563, 121);
            this.tbxVariant2.Multiline = true;
            this.tbxVariant2.Name = "tbxVariant2";
            this.tbxVariant2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxVariant2.Size = new System.Drawing.Size(446, 38);
            this.tbxVariant2.TabIndex = 10;
            // 
            // tbxVariant3
            // 
            this.tbxVariant3.Location = new System.Drawing.Point(563, 187);
            this.tbxVariant3.Multiline = true;
            this.tbxVariant3.Name = "tbxVariant3";
            this.tbxVariant3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxVariant3.Size = new System.Drawing.Size(446, 38);
            this.tbxVariant3.TabIndex = 11;
            // 
            // tbxVariant4
            // 
            this.tbxVariant4.Location = new System.Drawing.Point(563, 249);
            this.tbxVariant4.Multiline = true;
            this.tbxVariant4.Name = "tbxVariant4";
            this.tbxVariant4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxVariant4.Size = new System.Drawing.Size(446, 38);
            this.tbxVariant4.TabIndex = 12;
            // 
            // tbxVariant5
            // 
            this.tbxVariant5.Location = new System.Drawing.Point(563, 306);
            this.tbxVariant5.Multiline = true;
            this.tbxVariant5.Name = "tbxVariant5";
            this.tbxVariant5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxVariant5.Size = new System.Drawing.Size(446, 38);
            this.tbxVariant5.TabIndex = 13;
            // 
            // chbxVariant1
            // 
            this.chbxVariant1.AutoSize = true;
            this.chbxVariant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxVariant1.Location = new System.Drawing.Point(427, 65);
            this.chbxVariant1.Name = "chbxVariant1";
            this.chbxVariant1.Size = new System.Drawing.Size(96, 20);
            this.chbxVariant1.TabIndex = 14;
            this.chbxVariant1.Text = "Вариант 1:";
            this.chbxVariant1.UseVisualStyleBackColor = true;
            // 
            // chbxVariant2
            // 
            this.chbxVariant2.AutoSize = true;
            this.chbxVariant2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxVariant2.Location = new System.Drawing.Point(427, 121);
            this.chbxVariant2.Name = "chbxVariant2";
            this.chbxVariant2.Size = new System.Drawing.Size(96, 20);
            this.chbxVariant2.TabIndex = 15;
            this.chbxVariant2.Text = "Вариант 2:";
            this.chbxVariant2.UseVisualStyleBackColor = true;
            // 
            // chbxVariant3
            // 
            this.chbxVariant3.AutoSize = true;
            this.chbxVariant3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxVariant3.Location = new System.Drawing.Point(427, 187);
            this.chbxVariant3.Name = "chbxVariant3";
            this.chbxVariant3.Size = new System.Drawing.Size(96, 20);
            this.chbxVariant3.TabIndex = 16;
            this.chbxVariant3.Text = "Вариант 3:";
            this.chbxVariant3.UseVisualStyleBackColor = true;
            // 
            // chbxVariant4
            // 
            this.chbxVariant4.AutoSize = true;
            this.chbxVariant4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxVariant4.Location = new System.Drawing.Point(427, 249);
            this.chbxVariant4.Name = "chbxVariant4";
            this.chbxVariant4.Size = new System.Drawing.Size(96, 20);
            this.chbxVariant4.TabIndex = 17;
            this.chbxVariant4.Text = "Вариант 4:";
            this.chbxVariant4.UseVisualStyleBackColor = true;
            // 
            // chbxVariant5
            // 
            this.chbxVariant5.AutoSize = true;
            this.chbxVariant5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbxVariant5.Location = new System.Drawing.Point(427, 306);
            this.chbxVariant5.Name = "chbxVariant5";
            this.chbxVariant5.Size = new System.Drawing.Size(96, 20);
            this.chbxVariant5.TabIndex = 18;
            this.chbxVariant5.Text = "Вариант 5:";
            this.chbxVariant5.UseVisualStyleBackColor = true;
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.Location = new System.Drawing.Point(463, 383);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(172, 44);
            this.btnSaveQuestion.TabIndex = 19;
            this.btnSaveQuestion.Text = "Сохранить";
            this.btnSaveQuestion.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 426);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(177, 28);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // AddEditQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 467);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSaveQuestion);
            this.Controls.Add(this.chbxVariant5);
            this.Controls.Add(this.chbxVariant4);
            this.Controls.Add(this.chbxVariant3);
            this.Controls.Add(this.chbxVariant2);
            this.Controls.Add(this.chbxVariant1);
            this.Controls.Add(this.tbxVariant5);
            this.Controls.Add(this.tbxVariant4);
            this.Controls.Add(this.tbxVariant3);
            this.Controls.Add(this.tbxVariant2);
            this.Controls.Add(this.tbxVariant1);
            this.Controls.Add(this.cmbxCounters);
            this.Controls.Add(this.tbxDescrition);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnAddQuestion);
            this.Name = "AddEditQuestionForm";
            this.Text = "AddQuestionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbxDescrition;
        private System.Windows.Forms.ComboBox cmbxCounters;
        private System.Windows.Forms.TextBox tbxVariant1;
        private System.Windows.Forms.TextBox tbxVariant2;
        private System.Windows.Forms.TextBox tbxVariant3;
        private System.Windows.Forms.TextBox tbxVariant4;
        private System.Windows.Forms.TextBox tbxVariant5;
        private System.Windows.Forms.CheckBox chbxVariant1;
        private System.Windows.Forms.CheckBox chbxVariant2;
        private System.Windows.Forms.CheckBox chbxVariant3;
        private System.Windows.Forms.CheckBox chbxVariant4;
        private System.Windows.Forms.CheckBox chbxVariant5;
        private System.Windows.Forms.Button btnSaveQuestion;
        private System.Windows.Forms.Button btnEdit;
    }
}