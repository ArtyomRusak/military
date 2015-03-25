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
            this.btnTest = new System.Windows.Forms.Button();
            this._dgvNonBindedQuestions = new System.Windows.Forms.DataGridView();
            this._dgvBindedQuestions = new System.Windows.Forms.DataGridView();
            this._addQuestionToTestBtn = new System.Windows.Forms.Button();
            this._removeQuestionFromTestBtn = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dgvNonBindedQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBindedQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(116, 38);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(194, 53);
            this.btnAddQuestion.TabIndex = 0;
            this.btnAddQuestion.Text = "Добавить вопрос";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(607, 39);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(131, 52);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "button1";
            this.btnTest.UseVisualStyleBackColor = true;
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
            this._dgvNonBindedQuestions.Size = new System.Drawing.Size(323, 389);
            this._dgvNonBindedQuestions.TabIndex = 4;
            this._dgvNonBindedQuestions.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNonBindedQuestions_CellMouseMove);
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
            this._dgvBindedQuestions.Location = new System.Drawing.Point(422, 127);
            this._dgvBindedQuestions.MultiSelect = false;
            this._dgvBindedQuestions.Name = "_dgvBindedQuestions";
            this._dgvBindedQuestions.ReadOnly = true;
            this._dgvBindedQuestions.Size = new System.Drawing.Size(287, 389);
            this._dgvBindedQuestions.TabIndex = 5;
            // 
            // _addQuestionToTestBtn
            // 
            this._addQuestionToTestBtn.Location = new System.Drawing.Point(341, 289);
            this._addQuestionToTestBtn.Name = "_addQuestionToTestBtn";
            this._addQuestionToTestBtn.Size = new System.Drawing.Size(75, 23);
            this._addQuestionToTestBtn.TabIndex = 6;
            this._addQuestionToTestBtn.Text = "Добавить";
            this._addQuestionToTestBtn.UseVisualStyleBackColor = true;
            // 
            // _removeQuestionFromTestBtn
            // 
            this._removeQuestionFromTestBtn.Location = new System.Drawing.Point(341, 344);
            this._removeQuestionFromTestBtn.Name = "_removeQuestionFromTestBtn";
            this._removeQuestionFromTestBtn.Size = new System.Drawing.Size(75, 23);
            this._removeQuestionFromTestBtn.TabIndex = 7;
            this._removeQuestionFromTestBtn.Text = "Исключить";
            this._removeQuestionFromTestBtn.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 200;
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
            // questionBindingSource1
            // 
            this.questionBindingSource1.DataSource = typeof(MilitaryFaculty.KnowledgeTest.Entities.Entities.Question);
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn1.Width = 200;
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
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnAddQuestion);
            this.Name = "MainTeacherForm";
            this.Text = "MainTeacherForm";
            ((System.ComponentModel.ISupportInitialize)(this._dgvNonBindedQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvBindedQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.DataGridView _dgvNonBindedQuestions;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private System.Windows.Forms.DataGridView _dgvBindedQuestions;
        private System.Windows.Forms.Button _addQuestionToTestBtn;
        private System.Windows.Forms.Button _removeQuestionFromTestBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource questionBindingSource1;
    }
}