
namespace CourseProject_Eselevich
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
            this.table = new System.Windows.Forms.DataGridView();
            this.transportSelect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.periodStartPicker = new System.Windows.Forms.DateTimePicker();
            this.periodEndPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.voucherNumberLabel = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(25, 99);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(744, 239);
            this.table.TabIndex = 0;
            this.table.SelectionChanged += new System.EventHandler(this.table_SelectionChanged);
            // 
            // transportSelect
            // 
            this.transportSelect.FormattingEnabled = true;
            this.transportSelect.Location = new System.Drawing.Point(25, 59);
            this.transportSelect.Name = "transportSelect";
            this.transportSelect.Size = new System.Drawing.Size(172, 24);
            this.transportSelect.TabIndex = 2;
            this.transportSelect.SelectedIndexChanged += new System.EventHandler(this.transportSelect_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип транспорта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип меню";
            // 
            // menuSelect
            // 
            this.menuSelect.FormattingEnabled = true;
            this.menuSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuSelect.Location = new System.Drawing.Point(219, 59);
            this.menuSelect.Name = "menuSelect";
            this.menuSelect.Size = new System.Drawing.Size(173, 24);
            this.menuSelect.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Период";
            // 
            // periodStartPicker
            // 
            this.periodStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.periodStartPicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.periodStartPicker.Location = new System.Drawing.Point(456, 61);
            this.periodStartPicker.Name = "periodStartPicker";
            this.periodStartPicker.Size = new System.Drawing.Size(144, 22);
            this.periodStartPicker.TabIndex = 9;
            this.periodStartPicker.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.periodStartPicker.ValueChanged += new System.EventHandler(this.periodStartPicker_ValueChanged);
            // 
            // periodEndPicker
            // 
            this.periodEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.periodEndPicker.Location = new System.Drawing.Point(625, 61);
            this.periodEndPicker.Name = "periodEndPicker";
            this.periodEndPicker.Size = new System.Drawing.Size(144, 22);
            this.periodEndPicker.TabIndex = 10;
            this.periodEndPicker.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.periodEndPicker.ValueChanged += new System.EventHandler(this.periodEndPicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Стоимость:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(172, 395);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(0, 29);
            this.costLabel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(22, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Путевка №";
            // 
            // voucherNumberLabel
            // 
            this.voucherNumberLabel.AutoSize = true;
            this.voucherNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voucherNumberLabel.Location = new System.Drawing.Point(99, 378);
            this.voucherNumberLabel.Name = "voucherNumberLabel";
            this.voucherNumberLabel.Size = new System.Drawing.Size(0, 17);
            this.voucherNumberLabel.TabIndex = 16;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(594, 378);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(174, 46);
            this.buyButton.TabIndex = 17;
            this.buyButton.Text = "Купить";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.voucherNumberLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.periodEndPicker);
            this.Controls.Add(this.periodStartPicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.transportSelect);
            this.Controls.Add(this.table);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.ComboBox transportSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox menuSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker periodStartPicker;
        private System.Windows.Forms.DateTimePicker periodEndPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label voucherNumberLabel;
        private System.Windows.Forms.Button buyButton;
    }
}

