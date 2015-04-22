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
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this._btnSaveChanges = new System.Windows.Forms.Button();
            this._dgvNonBindedQuestions = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._dgvBindedQuestions = new System.Windows.Forms.DataGridView();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._addQuestionToTestBtn = new System.Windows.Forms.Button();
            this._removeQuestionFromTestBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgvNonBindedQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBindedQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(12, 12);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(194, 53);
            this.btnAddQuestion.TabIndex = 0;
            this.btnAddQuestion.Text = "Добавить вопрос";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            // 
            // _btnSaveChanges
            // 
            this._btnSaveChanges.Location = new System.Drawing.Point(340, 535);
            this._btnSaveChanges.Name = "_btnSaveChanges";
            this._btnSaveChanges.Size = new System.Drawing.Size(117, 40);
            this._btnSaveChanges.TabIndex = 3;
            this._btnSaveChanges.Text = "Сохранить изменения";
            this._btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // _dgvNonBindedQuestions
            // 
            this._dgvNonBindedQuestions.AllowUserToAddRows = false;
            this._dgvNonBindedQuestions.AllowUserToDeleteRows = false;
            this._dgvNonBindedQuestions.AutoGenerateColumns = false;
            this._dgvNonBindedQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvNonBindedQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this._dgvNonBindedQuestions.DataSource = this.questionBindingSource;
            this._dgvNonBindedQuestions.Location = new System.Drawing.Point(12, 127);
            this._dgvNonBindedQuestions.MultiSelect = false;
            this._dgvNonBindedQuestions.Name = "_dgvNonBindedQuestions";
            this._dgvNonBindedQuestions.ReadOnly = true;
            this._dgvNonBindedQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvNonBindedQuestions.Size = new System.Drawing.Size(323, 389);
            this._dgvNonBindedQuestions.TabIndex = 4;
            this._dgvNonBindedQuestions.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNonBindedQuestions_CellMouseMove);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 250;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 250;
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataSource = typeof(MilitaryFaculty.KnowledgeTest.Entities.Entities.Question);
            // 
            // _dgvBindedQuestions
            // 
            this._dgvBindedQuestions.AllowUserToAddRows = false;
            this._dgvBindedQuestions.AllowUserToDeleteRows = false;
            this._dgvBindedQuestions.AutoGenerateColumns = false;
            this._dgvBindedQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvBindedQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn1});
            this._dgvBindedQuestions.DataSource = this.questionBindingSource1;
            this._dgvBindedQuestions.Location = new System.Drawing.Point(464, 127);
            this._dgvBindedQuestions.MultiSelect = false;
            this._dgvBindedQuestions.Name = "_dgvBindedQuestions";
            this._dgvBindedQuestions.ReadOnly = true;
            this._dgvBindedQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvBindedQuestions.Size = new System.Drawing.Size(317, 389);
            this._dgvBindedQuestions.TabIndex = 5;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn1.Width = 250;
            // 
            // questionBindingSource1
            // 
            this.questionBindingSource1.DataSource = typeof(MilitaryFaculty.KnowledgeTest.Entities.Entities.Question);
            // 
            // _addQuestionToTestBtn
            // 
            this._addQuestionToTestBtn.Location = new System.Drawing.Point(362, 277);
            this._addQuestionToTestBtn.Name = "_addQuestionToTestBtn";
            this._addQuestionToTestBtn.Size = new System.Drawing.Size(75, 23);
            this._addQuestionToTestBtn.TabIndex = 6;
            this._addQuestionToTestBtn.Text = ">>>>>";
            this._addQuestionToTestBtn.UseVisualStyleBackColor = true;
            // 
            // _removeQuestionFromTestBtn
            // 
            this._removeQuestionFromTestBtn.Location = new System.Drawing.Point(362, 351);
            this._removeQuestionFromTestBtn.Name = "_removeQuestionFromTestBtn";
            this._removeQuestionFromTestBtn.Size = new System.Drawing.Size(75, 23);
            this._removeQuestionFromTestBtn.TabIndex = 7;
            this._removeQuestionFromTestBtn.Text = "<<<<<";
            this._removeQuestionFromTestBtn.UseVisualStyleBackColor = true;
            // 
            // MainTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 587);
            this.Controls.Add(this._removeQuestionFromTestBtn);
            this.Controls.Add(this._addQuestionToTestBtn);
            this.Controls.Add(this._dgvBindedQuestions);
            this.Controls.Add(this._dgvNonBindedQuestions);
            this.Controls.Add(this._btnSaveChanges);
            this.Controls.Add(this.btnAddQuestion);
            this.Name = "MainTeacherForm";
            this.Text = "MainTeacherForm";
            ((System.ComponentModel.ISupportInitialize)(this._dgvNonBindedQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBindedQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button _btnSaveChanges;
        private System.Windows.Forms.DataGridView _dgvNonBindedQuestions;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private System.Windows.Forms.DataGridView _dgvBindedQuestions;
        private System.Windows.Forms.Button _addQuestionToTestBtn;
        private System.Windows.Forms.Button _removeQuestionFromTestBtn;
        private System.Windows.Forms.BindingSource questionBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
    }
}