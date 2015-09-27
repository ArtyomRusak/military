namespace UITest
{
    partial class MainTeacherForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this._btnSaveChanges = new System.Windows.Forms.Button();
            this._dgvBindedQuestions = new System.Windows.Forms.DataGridView();
            this._dgvNonBindedQuestions = new System.Windows.Forms.DataGridView();
            this._addQuestionToTestBtn = new System.Windows.Forms.Button();
            this._removeQuestionFromTestBtn = new System.Windows.Forms.Button();
            this._nmbxNumberOfQuestions = new System.Windows.Forms.NumericUpDown();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindedQuestionSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nonBindedQuestionSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._dgvBindedQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvNonBindedQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nmbxNumberOfQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindedQuestionSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonBindedQuestionSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(44, 15);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(194, 53);
            this.btnAddQuestion.TabIndex = 0;
            this.btnAddQuestion.Text = "Добавить вопрос";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            // 
            // _btnSaveChanges
            // 
            this._btnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSaveChanges.Location = new System.Drawing.Point(244, 15);
            this._btnSaveChanges.Name = "_btnSaveChanges";
            this._btnSaveChanges.Size = new System.Drawing.Size(170, 53);
            this._btnSaveChanges.TabIndex = 3;
            this._btnSaveChanges.Text = "Сохранить изменения";
            this._btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // _dgvBindedQuestions
            // 
            this._dgvBindedQuestions.AllowUserToAddRows = false;
            this._dgvBindedQuestions.AllowUserToDeleteRows = false;
            this._dgvBindedQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvBindedQuestions.AutoGenerateColumns = false;
            this._dgvBindedQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvBindedQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn});
            this._dgvBindedQuestions.DataSource = this.bindedQuestionSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvBindedQuestions.DefaultCellStyle = dataGridViewCellStyle7;
            this._dgvBindedQuestions.Location = new System.Drawing.Point(464, 74);
            this._dgvBindedQuestions.MultiSelect = false;
            this._dgvBindedQuestions.Name = "_dgvBindedQuestions";
            this._dgvBindedQuestions.ReadOnly = true;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dgvBindedQuestions.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this._dgvBindedQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvBindedQuestions.Size = new System.Drawing.Size(323, 396);
            this._dgvBindedQuestions.TabIndex = 4;
            // 
            // _dgvNonBindedQuestions
            // 
            this._dgvNonBindedQuestions.AllowUserToAddRows = false;
            this._dgvNonBindedQuestions.AllowUserToDeleteRows = false;
            this._dgvNonBindedQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dgvNonBindedQuestions.AutoGenerateColumns = false;
            this._dgvNonBindedQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvNonBindedQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn1});
            this._dgvNonBindedQuestions.DataSource = this.nonBindedQuestionSource;
            this._dgvNonBindedQuestions.Location = new System.Drawing.Point(44, 74);
            this._dgvNonBindedQuestions.MultiSelect = false;
            this._dgvNonBindedQuestions.Name = "_dgvNonBindedQuestions";
            this._dgvNonBindedQuestions.ReadOnly = true;
            this._dgvNonBindedQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvNonBindedQuestions.Size = new System.Drawing.Size(317, 396);
            this._dgvNonBindedQuestions.TabIndex = 5;
            this._dgvNonBindedQuestions.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this._dgvNonBindedQuestions_DataError);
            // 
            // _addQuestionToTestBtn
            // 
            this._addQuestionToTestBtn.Location = new System.Drawing.Point(373, 197);
            this._addQuestionToTestBtn.Name = "_addQuestionToTestBtn";
            this._addQuestionToTestBtn.Size = new System.Drawing.Size(75, 23);
            this._addQuestionToTestBtn.TabIndex = 6;
            this._addQuestionToTestBtn.Text = ">>>>>";
            this._addQuestionToTestBtn.UseVisualStyleBackColor = true;
            // 
            // _removeQuestionFromTestBtn
            // 
            this._removeQuestionFromTestBtn.Location = new System.Drawing.Point(373, 285);
            this._removeQuestionFromTestBtn.Name = "_removeQuestionFromTestBtn";
            this._removeQuestionFromTestBtn.Size = new System.Drawing.Size(75, 23);
            this._removeQuestionFromTestBtn.TabIndex = 7;
            this._removeQuestionFromTestBtn.Text = "<<<<<";
            this._removeQuestionFromTestBtn.UseVisualStyleBackColor = true;
            // 
            // _nmbxNumberOfQuestions
            // 
            this._nmbxNumberOfQuestions.Location = new System.Drawing.Point(118, 476);
            this._nmbxNumberOfQuestions.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this._nmbxNumberOfQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nmbxNumberOfQuestions.Name = "_nmbxNumberOfQuestions";
            this._nmbxNumberOfQuestions.Size = new System.Drawing.Size(120, 20);
            this._nmbxNumberOfQuestions.TabIndex = 8;
            this._nmbxNumberOfQuestions.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 82;
            // 
            // bindedQuestionSource
            // 
            this.bindedQuestionSource.DataSource = typeof(MilitaryFaculty.KnowledgeTest.Entities.Entities.Question);
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn1.Width = 82;
            // 
            // nonBindedQuestionSource
            // 
            this.nonBindedQuestionSource.DataSource = typeof(MilitaryFaculty.KnowledgeTest.Entities.Entities.Question);
            // 
            // MainTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 501);
            this.Controls.Add(this._nmbxNumberOfQuestions);
            this.Controls.Add(this._removeQuestionFromTestBtn);
            this.Controls.Add(this._addQuestionToTestBtn);
            this.Controls.Add(this._dgvNonBindedQuestions);
            this.Controls.Add(this._dgvBindedQuestions);
            this.Controls.Add(this._btnSaveChanges);
            this.Controls.Add(this.btnAddQuestion);
            this.Name = "MainTeacherForm";
            this.Text = "MainTeacherForm";
            ((System.ComponentModel.ISupportInitialize)(this._dgvBindedQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvNonBindedQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nmbxNumberOfQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindedQuestionSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonBindedQuestionSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button _btnSaveChanges;
        private System.Windows.Forms.DataGridView _dgvBindedQuestions;
        private System.Windows.Forms.BindingSource bindedQuestionSource;
        private System.Windows.Forms.DataGridView _dgvNonBindedQuestions;
        private System.Windows.Forms.Button _addQuestionToTestBtn;
        private System.Windows.Forms.Button _removeQuestionFromTestBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown _nmbxNumberOfQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource nonBindedQuestionSource;
    }
}