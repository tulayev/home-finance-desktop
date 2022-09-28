namespace PersonalFinanceApp
{
    partial class MainForm
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
            this.historyTable = new System.Windows.Forms.DataGridView();
            this.insertButton = new System.Windows.Forms.Button();
            this.incomeCheck = new System.Windows.Forms.CheckBox();
            this.expenseCheck = new System.Windows.Forms.CheckBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.catComboBox = new System.Windows.Forms.ComboBox();
            this.catsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // historyTable
            // 
            this.historyTable.AllowUserToOrderColumns = true;
            this.historyTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.historyTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.historyTable.ColumnHeadersHeight = 40;
            this.historyTable.Location = new System.Drawing.Point(11, 62);
            this.historyTable.Margin = new System.Windows.Forms.Padding(2);
            this.historyTable.Name = "historyTable";
            this.historyTable.RowTemplate.Height = 44;
            this.historyTable.RowTemplate.ReadOnly = true;
            this.historyTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.historyTable.Size = new System.Drawing.Size(895, 414);
            this.historyTable.TabIndex = 0;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(379, 491);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(138, 34);
            this.insertButton.TabIndex = 3;
            this.insertButton.Text = "Ввести данные";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // incomeCheck
            // 
            this.incomeCheck.AutoSize = true;
            this.incomeCheck.Location = new System.Drawing.Point(11, 12);
            this.incomeCheck.Name = "incomeCheck";
            this.incomeCheck.Size = new System.Drawing.Size(76, 24);
            this.incomeCheck.TabIndex = 4;
            this.incomeCheck.Text = "Доход";
            this.incomeCheck.UseVisualStyleBackColor = true;
            this.incomeCheck.CheckedChanged += new System.EventHandler(this.incomeCheck_CheckedChanged);
            // 
            // expenseCheck
            // 
            this.expenseCheck.AutoSize = true;
            this.expenseCheck.Location = new System.Drawing.Point(93, 12);
            this.expenseCheck.Name = "expenseCheck";
            this.expenseCheck.Size = new System.Drawing.Size(82, 24);
            this.expenseCheck.TabIndex = 5;
            this.expenseCheck.Text = "Расход";
            this.expenseCheck.UseVisualStyleBackColor = true;
            this.expenseCheck.CheckedChanged += new System.EventHandler(this.expenseCheck_CheckedChanged);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(181, 13);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(73, 20);
            this.balanceLabel.TabIndex = 6;
            this.balanceLabel.Text = "Баланс: ";
            // 
            // catComboBox
            // 
            this.catComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catComboBox.FormattingEnabled = true;
            this.catComboBox.Location = new System.Drawing.Point(717, 10);
            this.catComboBox.Name = "catComboBox";
            this.catComboBox.Size = new System.Drawing.Size(189, 28);
            this.catComboBox.TabIndex = 7;
            this.catComboBox.SelectedIndexChanged += new System.EventHandler(this.catComboBox_SelectedIndexChanged);
            // 
            // catsLabel
            // 
            this.catsLabel.AutoSize = true;
            this.catsLabel.Location = new System.Drawing.Point(614, 13);
            this.catsLabel.Name = "catsLabel";
            this.catsLabel.Size = new System.Drawing.Size(97, 20);
            this.catsLabel.TabIndex = 8;
            this.catsLabel.Text = "Категории: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 537);
            this.Controls.Add(this.catsLabel);
            this.Controls.Add(this.catComboBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.expenseCheck);
            this.Controls.Add(this.incomeCheck);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.historyTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Finance Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.historyTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView historyTable;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.CheckBox incomeCheck;
        private System.Windows.Forms.CheckBox expenseCheck;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.ComboBox catComboBox;
        private System.Windows.Forms.Label catsLabel;
    }
}

