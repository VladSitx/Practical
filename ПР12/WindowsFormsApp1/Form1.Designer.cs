namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownColumns = new System.Windows.Forms.NumericUpDown();
            this.groupBoxMatrix_A = new System.Windows.Forms.GroupBox();
            this.buttonFill = new System.Windows.Forms.Button();
            this.labelColumns = new System.Windows.Forms.Label();
            this.labelRows = new System.Windows.Forms.Label();
            this.dataGridViewMatrix_A = new System.Windows.Forms.DataGridView();
            this.groupBoxMatrix_B = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_B = new System.Windows.Forms.DataGridView();
            this.buttonFill_1 = new System.Windows.Forms.Button();
            this.numericUpDownColumns_1 = new System.Windows.Forms.NumericUpDown();
            this.labelColumns_1 = new System.Windows.Forms.Label();
            this.labelRows_1 = new System.Windows.Forms.Label();
            this.numericUpDownRows_1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).BeginInit();
            this.groupBoxMatrix_A.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_A)).BeginInit();
            this.groupBoxMatrix_B.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows_1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownRows
            // 
            this.numericUpDownRows.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownRows.Location = new System.Drawing.Point(213, 9);
            this.numericUpDownRows.Name = "numericUpDownRows";
            this.helpProvider1.SetShowHelp(this.numericUpDownRows, true);
            this.numericUpDownRows.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownRows.TabIndex = 5;
            this.numericUpDownRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRows.ValueChanged += new System.EventHandler(this.numericUpDownRows_ValueChanged);
            // 
            // numericUpDownColumns
            // 
            this.numericUpDownColumns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownColumns.Location = new System.Drawing.Point(321, 9);
            this.numericUpDownColumns.Name = "numericUpDownColumns";
            this.helpProvider1.SetShowHelp(this.numericUpDownColumns, true);
            this.numericUpDownColumns.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownColumns.TabIndex = 8;
            this.numericUpDownColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColumns.ValueChanged += new System.EventHandler(this.numericUpDownColumns_ValueChanged);
            // 
            // groupBoxMatrix_A
            // 
            this.groupBoxMatrix_A.Controls.Add(this.dataGridViewMatrix_A);
            this.groupBoxMatrix_A.Controls.Add(this.buttonFill);
            this.groupBoxMatrix_A.Controls.Add(this.numericUpDownColumns);
            this.groupBoxMatrix_A.Controls.Add(this.labelColumns);
            this.groupBoxMatrix_A.Controls.Add(this.labelRows);
            this.groupBoxMatrix_A.Controls.Add(this.numericUpDownRows);
            this.groupBoxMatrix_A.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMatrix_A.Name = "groupBoxMatrix_A";
            this.groupBoxMatrix_A.Size = new System.Drawing.Size(500, 300);
            this.groupBoxMatrix_A.TabIndex = 0;
            this.groupBoxMatrix_A.TabStop = false;
            this.groupBoxMatrix_A.Text = "Матрица А:";
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(365, 9);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(129, 20);
            this.buttonFill.TabIndex = 1;
            this.buttonFill.Text = "Заполнить";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Location = new System.Drawing.Point(257, 11);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(58, 13);
            this.labelColumns.TabIndex = 7;
            this.labelColumns.Text = "Столбцов:";
            this.labelColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(167, 11);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(40, 13);
            this.labelRows.TabIndex = 6;
            this.labelRows.Text = "Строк:";
            this.labelRows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewMatrix_A
            // 
            this.dataGridViewMatrix_A.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMatrix_A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_A.GridColor = System.Drawing.Color.Red;
            this.dataGridViewMatrix_A.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewMatrix_A.Name = "dataGridViewMatrix_A";
            this.dataGridViewMatrix_A.Size = new System.Drawing.Size(488, 260);
            this.dataGridViewMatrix_A.TabIndex = 9;
            // 
            // groupBoxMatrix_B
            // 
            this.groupBoxMatrix_B.Controls.Add(this.dataGridViewMatrix_B);
            this.groupBoxMatrix_B.Controls.Add(this.buttonFill_1);
            this.groupBoxMatrix_B.Controls.Add(this.numericUpDownColumns_1);
            this.groupBoxMatrix_B.Controls.Add(this.labelColumns_1);
            this.groupBoxMatrix_B.Controls.Add(this.labelRows_1);
            this.groupBoxMatrix_B.Controls.Add(this.numericUpDownRows_1);
            this.groupBoxMatrix_B.Location = new System.Drawing.Point(12, 367);
            this.groupBoxMatrix_B.Name = "groupBoxMatrix_B";
            this.groupBoxMatrix_B.Size = new System.Drawing.Size(500, 300);
            this.groupBoxMatrix_B.TabIndex = 1;
            this.groupBoxMatrix_B.TabStop = false;
            this.groupBoxMatrix_B.Text = "Матрица B:";
            // 
            // dataGridViewMatrix_B
            // 
            this.dataGridViewMatrix_B.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMatrix_B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_B.GridColor = System.Drawing.Color.Red;
            this.dataGridViewMatrix_B.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewMatrix_B.Name = "dataGridViewMatrix_B";
            this.dataGridViewMatrix_B.Size = new System.Drawing.Size(488, 260);
            this.dataGridViewMatrix_B.TabIndex = 9;
            // 
            // buttonFill_1
            // 
            this.buttonFill_1.Location = new System.Drawing.Point(365, 9);
            this.buttonFill_1.Name = "buttonFill_1";
            this.buttonFill_1.Size = new System.Drawing.Size(129, 20);
            this.buttonFill_1.TabIndex = 1;
            this.buttonFill_1.Text = "Заполнить";
            this.buttonFill_1.UseVisualStyleBackColor = true;
            // 
            // numericUpDownColumns_1
            // 
            this.numericUpDownColumns_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownColumns_1.Location = new System.Drawing.Point(321, 9);
            this.numericUpDownColumns_1.Name = "numericUpDownColumns_1";
            this.helpProvider1.SetShowHelp(this.numericUpDownColumns_1, true);
            this.numericUpDownColumns_1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownColumns_1.TabIndex = 8;
            this.numericUpDownColumns_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownColumns_1.ValueChanged += new System.EventHandler(this.numericUpDownColumns_1_ValueChanged);
            // 
            // labelColumns_1
            // 
            this.labelColumns_1.AutoSize = true;
            this.labelColumns_1.Location = new System.Drawing.Point(257, 11);
            this.labelColumns_1.Name = "labelColumns_1";
            this.labelColumns_1.Size = new System.Drawing.Size(58, 13);
            this.labelColumns_1.TabIndex = 7;
            this.labelColumns_1.Text = "Столбцов:";
            this.labelColumns_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRows_1
            // 
            this.labelRows_1.AutoSize = true;
            this.labelRows_1.Location = new System.Drawing.Point(167, 11);
            this.labelRows_1.Name = "labelRows_1";
            this.labelRows_1.Size = new System.Drawing.Size(40, 13);
            this.labelRows_1.TabIndex = 6;
            this.labelRows_1.Text = "Строк:";
            this.labelRows_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownRows_1
            // 
            this.numericUpDownRows_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownRows_1.Location = new System.Drawing.Point(213, 9);
            this.numericUpDownRows_1.Name = "numericUpDownRows_1";
            this.helpProvider1.SetShowHelp(this.numericUpDownRows_1, true);
            this.numericUpDownRows_1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownRows_1.TabIndex = 5;
            this.numericUpDownRows_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRows_1.ValueChanged += new System.EventHandler(this.numericUpDownRows_1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(591, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 288);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(884, 679);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBoxMatrix_B);
            this.Controls.Add(this.groupBoxMatrix_A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матричный калькулятор";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).EndInit();
            this.groupBoxMatrix_A.ResumeLayout(false);
            this.groupBoxMatrix_A.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_A)).EndInit();
            this.groupBoxMatrix_B.ResumeLayout(false);
            this.groupBoxMatrix_B.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.GroupBox groupBoxMatrix_A;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.NumericUpDown numericUpDownColumns;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_A;
        private System.Windows.Forms.GroupBox groupBoxMatrix_B;
        private System.Windows.Forms.Button buttonFill_1;
        private System.Windows.Forms.NumericUpDown numericUpDownColumns_1;
        private System.Windows.Forms.Label labelColumns_1;
        private System.Windows.Forms.Label labelRows_1;
        private System.Windows.Forms.NumericUpDown numericUpDownRows_1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dataGridViewMatrix_B;
    }
}

