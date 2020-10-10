namespace Challenge
{
    partial class mainForm
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
            this.storeDataGridView = new System.Windows.Forms.DataGridView();
            this.openXMLbutton = new System.Windows.Forms.Button();
            this.saveXMLbutton = new System.Windows.Forms.Button();
            this.reportHTMLbutton = new System.Windows.Forms.Button();
            this.deleteRecordButton = new System.Windows.Forms.Button();
            this.addRecordbutton = new System.Windows.Forms.Button();
            this.editRecordbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // storeDataGridView
            // 
            this.storeDataGridView.AllowUserToAddRows = false;
            this.storeDataGridView.AllowUserToDeleteRows = false;
            this.storeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeDataGridView.Location = new System.Drawing.Point(12, 99);
            this.storeDataGridView.MultiSelect = false;
            this.storeDataGridView.Name = "storeDataGridView";
            this.storeDataGridView.ReadOnly = true;
            this.storeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storeDataGridView.Size = new System.Drawing.Size(649, 267);
            this.storeDataGridView.TabIndex = 0;
            // 
            // openXMLbutton
            // 
            this.openXMLbutton.BackColor = System.Drawing.Color.Orange;
            this.openXMLbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openXMLbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openXMLbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openXMLbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.openXMLbutton.Location = new System.Drawing.Point(12, 32);
            this.openXMLbutton.Name = "openXMLbutton";
            this.openXMLbutton.Size = new System.Drawing.Size(195, 39);
            this.openXMLbutton.TabIndex = 1;
            this.openXMLbutton.Text = "Открыть XML";
            this.openXMLbutton.UseVisualStyleBackColor = false;
            this.openXMLbutton.Click += new System.EventHandler(this.openXMLbutton_Click);
            // 
            // saveXMLbutton
            // 
            this.saveXMLbutton.BackColor = System.Drawing.Color.Chocolate;
            this.saveXMLbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveXMLbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveXMLbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveXMLbutton.Location = new System.Drawing.Point(243, 32);
            this.saveXMLbutton.Name = "saveXMLbutton";
            this.saveXMLbutton.Size = new System.Drawing.Size(195, 39);
            this.saveXMLbutton.TabIndex = 2;
            this.saveXMLbutton.Text = "Сохранить XML";
            this.saveXMLbutton.UseVisualStyleBackColor = false;
            this.saveXMLbutton.Click += new System.EventHandler(this.saveXMLbutton_Click);
            // 
            // reportHTMLbutton
            // 
            this.reportHTMLbutton.BackColor = System.Drawing.Color.Green;
            this.reportHTMLbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportHTMLbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportHTMLbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reportHTMLbutton.Location = new System.Drawing.Point(468, 32);
            this.reportHTMLbutton.Name = "reportHTMLbutton";
            this.reportHTMLbutton.Size = new System.Drawing.Size(193, 39);
            this.reportHTMLbutton.TabIndex = 3;
            this.reportHTMLbutton.Text = "Отчёт в HTML";
            this.reportHTMLbutton.UseVisualStyleBackColor = false;
            this.reportHTMLbutton.Click += new System.EventHandler(this.reportHTMLbutton_Click);
            // 
            // deleteRecordButton
            // 
            this.deleteRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteRecordButton.BackColor = System.Drawing.Color.Maroon;
            this.deleteRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteRecordButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteRecordButton.Location = new System.Drawing.Point(12, 385);
            this.deleteRecordButton.Name = "deleteRecordButton";
            this.deleteRecordButton.Size = new System.Drawing.Size(195, 39);
            this.deleteRecordButton.TabIndex = 4;
            this.deleteRecordButton.Text = "Удалить запись";
            this.deleteRecordButton.UseVisualStyleBackColor = false;
            this.deleteRecordButton.Click += new System.EventHandler(this.deleteRecordbutton_Click);
            // 
            // addRecordbutton
            // 
            this.addRecordbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addRecordbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addRecordbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRecordbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRecordbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addRecordbutton.Location = new System.Drawing.Point(243, 385);
            this.addRecordbutton.Name = "addRecordbutton";
            this.addRecordbutton.Size = new System.Drawing.Size(195, 39);
            this.addRecordbutton.TabIndex = 5;
            this.addRecordbutton.Text = "Добавить запись";
            this.addRecordbutton.UseVisualStyleBackColor = false;
            this.addRecordbutton.Click += new System.EventHandler(this.addRecordbutton_Click);
            // 
            // editRecordbutton
            // 
            this.editRecordbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editRecordbutton.BackColor = System.Drawing.Color.Firebrick;
            this.editRecordbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRecordbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editRecordbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editRecordbutton.Location = new System.Drawing.Point(468, 385);
            this.editRecordbutton.Name = "editRecordbutton";
            this.editRecordbutton.Size = new System.Drawing.Size(192, 39);
            this.editRecordbutton.TabIndex = 6;
            this.editRecordbutton.Text = "Редактировать запись";
            this.editRecordbutton.UseVisualStyleBackColor = false;
            this.editRecordbutton.Click += new System.EventHandler(this.editRecordbutton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(672, 436);
            this.Controls.Add(this.editRecordbutton);
            this.Controls.Add(this.addRecordbutton);
            this.Controls.Add(this.deleteRecordButton);
            this.Controls.Add(this.reportHTMLbutton);
            this.Controls.Add(this.saveXMLbutton);
            this.Controls.Add(this.openXMLbutton);
            this.Controls.Add(this.storeDataGridView);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "challengeTask";
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView storeDataGridView;
        private System.Windows.Forms.Button openXMLbutton;
        private System.Windows.Forms.Button saveXMLbutton;
        private System.Windows.Forms.Button reportHTMLbutton;
        private System.Windows.Forms.Button deleteRecordButton;
        private System.Windows.Forms.Button addRecordbutton;
        private System.Windows.Forms.Button editRecordbutton;
    }
}

