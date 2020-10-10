namespace Challenge
{
    partial class bookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookForm));
            this.title = new System.Windows.Forms.Label();
            this.publicationDate = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.cover = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.coverTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAuthorLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.minusBFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.textBoxAuthorLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.title.Location = new System.Drawing.Point(12, 86);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(82, 16);
            this.title.TabIndex = 0;
            this.title.Text = "Название";
            // 
            // publicationDate
            // 
            this.publicationDate.AutoSize = true;
            this.publicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publicationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.publicationDate.Location = new System.Drawing.Point(12, 217);
            this.publicationDate.Name = "publicationDate";
            this.publicationDate.Size = new System.Drawing.Size(100, 16);
            this.publicationDate.TabIndex = 1;
            this.publicationDate.Text = "Год издания";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.price.Location = new System.Drawing.Point(12, 259);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(45, 16);
            this.price.TabIndex = 2;
            this.price.Text = "Цена";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.category.Location = new System.Drawing.Point(12, 175);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(85, 16);
            this.category.TabIndex = 3;
            this.category.Text = "Категория";
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.author.Location = new System.Drawing.Point(465, 89);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(73, 16);
            this.author.TabIndex = 4;
            this.author.Text = "Автор(ы)";
            // 
            // cover
            // 
            this.cover.AutoSize = true;
            this.cover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cover.Location = new System.Drawing.Point(12, 301);
            this.cover.Name = "cover";
            this.cover.Size = new System.Drawing.Size(73, 16);
            this.cover.TabIndex = 5;
            this.cover.Text = "Обложка";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(121, 83);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(277, 22);
            this.titleTextBox.TabIndex = 1;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryTextBox.Location = new System.Drawing.Point(121, 172);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(277, 22);
            this.categoryTextBox.TabIndex = 3;
            this.categoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // yearTextBox
            // 
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearTextBox.Location = new System.Drawing.Point(121, 214);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(277, 22);
            this.yearTextBox.TabIndex = 4;
            this.yearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(121, 256);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(277, 22);
            this.priceTextBox.TabIndex = 5;
            // 
            // coverTextBox
            // 
            this.coverTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coverTextBox.Location = new System.Drawing.Point(121, 298);
            this.coverTextBox.Name = "coverTextBox";
            this.coverTextBox.Size = new System.Drawing.Size(277, 22);
            this.coverTextBox.TabIndex = 6;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorTextBox.Location = new System.Drawing.Point(3, 3);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(267, 22);
            this.authorTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Indigo;
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Location = new System.Drawing.Point(15, 358);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(130, 47);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "ОК";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DarkOrange;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.Location = new System.Drawing.Point(268, 358);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(130, 47);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // languageTextBox
            // 
            this.languageTextBox.Location = new System.Drawing.Point(121, 129);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(277, 20);
            this.languageTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Язык";
            // 
            // textBoxAuthorLayoutPanel
            // 
            this.textBoxAuthorLayoutPanel.Controls.Add(this.authorTextBox);
            this.textBoxAuthorLayoutPanel.Location = new System.Drawing.Point(468, 129);
            this.textBoxAuthorLayoutPanel.Name = "textBoxAuthorLayoutPanel";
            this.textBoxAuthorLayoutPanel.Size = new System.Drawing.Size(275, 555);
            this.textBoxAuthorLayoutPanel.TabIndex = 12;
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addAuthorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAuthorButton.Location = new System.Drawing.Point(570, 74);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(41, 41);
            this.addAuthorButton.TabIndex = 13;
            this.addAuthorButton.Text = "+";
            this.addAuthorButton.UseVisualStyleBackColor = false;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // minusBFlowLayoutPanel
            // 
            this.minusBFlowLayoutPanel.Location = new System.Drawing.Point(749, 132);
            this.minusBFlowLayoutPanel.Name = "minusBFlowLayoutPanel";
            this.minusBFlowLayoutPanel.Size = new System.Drawing.Size(30, 555);
            this.minusBFlowLayoutPanel.TabIndex = 14;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.titleLabel.Location = new System.Drawing.Point(304, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(234, 24);
            this.titleLabel.TabIndex = 15;
            this.titleLabel.Text = "Добавить новую книгу";
            // 
            // bookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(791, 433);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.minusBFlowLayoutPanel);
            this.Controls.Add(this.addAuthorButton);
            this.Controls.Add(this.textBoxAuthorLayoutPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.languageTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.coverTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.cover);
            this.Controls.Add(this.author);
            this.Controls.Add(this.category);
            this.Controls.Add(this.price);
            this.Controls.Add(this.publicationDate);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "bookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о книге";
            this.textBoxAuthorLayoutPanel.ResumeLayout(false);
            this.textBoxAuthorLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label publicationDate;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Label cover;
        protected internal System.Windows.Forms.TextBox titleTextBox;
        protected internal System.Windows.Forms.TextBox categoryTextBox;
        protected internal System.Windows.Forms.TextBox yearTextBox;
        protected internal System.Windows.Forms.TextBox priceTextBox;
        protected internal System.Windows.Forms.TextBox coverTextBox;
        protected internal System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel textBoxAuthorLayoutPanel;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.FlowLayoutPanel minusBFlowLayoutPanel;
        private System.Windows.Forms.Label titleLabel;
    }
}