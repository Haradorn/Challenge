using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Challenge
{
    public partial class bookForm : Form
    {
        public Book DisplayedBook { get; private set; }
        private static readonly Color errorColor = Color.LightCoral;
        private static readonly Color noErrorColor = Color.White;
        private static readonly Color minusBackColor = Color.Silver;
        private static readonly Color minusMouseDownBackColor = Color.Gray;
        private static readonly Color minusMouseOverBackColor = Color.DarkGray;
        private static readonly Color enabledBackColor = Color.DarkGray;
        private static readonly Color disabledBackColor = Color.LightGray;
        private static readonly Color enabledForeColor = Color.Black;
        private static readonly Color disabledForeColor = Color.WhiteSmoke;
        public event EventHandler<ObjectEventArgs> ErrorOccurred;
        public bookForm(Book book = null)
        {
            DisplayedBook = book;
            InitializeComponent();
            PlaceControls();

            addButton.Enabled = false;
        }
        private void PlaceControls()
        {
            if (DisplayedBook != null)
            {
                titleTextBox.Text = DisplayedBook.Title;
                languageTextBox.Text = DisplayedBook.Language;
                categoryTextBox.Text = DisplayedBook.Category;
                yearTextBox.Text = Convert.ToString(DisplayedBook.Year);
                priceTextBox.Text = Convert.ToString(DisplayedBook.Price);
                coverTextBox.Text = DisplayedBook.Cover;
                authorTextBox.Text = DisplayedBook.Authors[0];
                for(int i = 1; i < DisplayedBook.Authors.Count; i++)
                {
                    AddTextbox(DisplayedBook.Authors[i]);
                }
                titleLabel.Text = "Редактирование книги";
                addButton.Text = "Редактирование";
            }
            titleTextBox.TextChanged += new EventHandler(titleTextBox_TextChanged);
            languageTextBox.TextChanged += new EventHandler(languageTextBox_TextChanged);
            categoryTextBox.TextChanged += new EventHandler(categoryTextBox_TextChanged);
            yearTextBox.TextChanged += new EventHandler(yearTextBox_TextChanged);
            priceTextBox.TextChanged += new EventHandler(priceTextBox_TextChanged);
            coverTextBox.TextChanged += new EventHandler(coverTextBox_TextChanged);
            authorTextBox.TextChanged += authorTextBox_TextChanged;
        }
        void authorTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxTextChangeHandle(Book.OkForAuthor, (TextBox)sender);
        }
        void coverTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxTextChangeHandle(Book.OkForCover, (TextBox)sender);
        }
        void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxTextChangeHandle(Book.OkForPrice, (TextBox)sender);
        }
        void yearTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxTextChangeHandle(Book.OkForYear, (TextBox)sender);
        }
        void categoryTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxTextChangeHandle(Book.OkForCategory, (TextBox)sender);
        }
        void languageTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxTextChangeHandle(Book.OkForLanguage, (TextBox)sender);
        }
        void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBoxTextChangeHandle(Book.OkForTitle, (TextBox)sender);
        }
        private void TextBoxTextChangeHandle(Func<string, bool> Criterion, TextBox tB)
        {
            if (!Criterion(tB.Text))
                tB.BackColor = errorColor;
            else
                tB.BackColor = noErrorColor;
            CheckAllTextBoxes();
        }
        private void AddTextbox(string text)
        {
            //текстбокс для авторов
            TextBox tB = new TextBox()
            {
                BorderStyle = BorderStyle.None,
                Font = new Font("MicrosoftSansSerif", 10),
                Height = 19,
                Width = 190,
                Text = text
            };
            tB.TextChanged += authorTextBox_TextChanged;
            Button b = new Button()
            {
                Height = 16,
                Width = 16,
                FlatStyle = FlatStyle.Flat,
                BackColor = minusBackColor,
                Text = "X",
                Font = new Font("MicrosoftSansSerif", 5)
            };
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseDownBackColor = minusMouseDownBackColor;
            b.FlatAppearance.MouseOverBackColor = minusMouseOverBackColor;
            b.Click += minusButton_Click;
            textBoxAuthorLayoutPanel.Controls.Add(tB);
            minusBFlowLayoutPanel.Controls.Add(b);
        }
        private void minusButton_Click(object sender, EventArgs e)
        {
            int index = minusBFlowLayoutPanel.Controls.IndexOf((Button)sender);
            //удаляем кнопку "убрать" и текстбокс для автора
            minusBFlowLayoutPanel.Controls.RemoveAt(index);
            textBoxAuthorLayoutPanel.Controls.RemoveAt((index + 1));
            CheckAllTextBoxes();
        }
        private void addButton_EnabledChanged(object sender, EventArgs e)
        {
            if (((Button)sender).Enabled == true)
            {
                ((Button)sender).BackColor = enabledBackColor;
                ((Button)sender).ForeColor = enabledForeColor;
            }
            else
            {
                ((Button)sender).BackColor = disabledBackColor;
                ((Button)sender).ForeColor = disabledForeColor;
            }
        }
        private void CheckAllTextBoxes()
        {
            if (Book.OkForCategory(categoryTextBox.Text) &&
                Book.OkForCover(coverTextBox.Text) &&
                Book.OkForLanguage(languageTextBox.Text) &&
                Book.OkForPrice(priceTextBox.Text) &&
                Book.OkForTitle(titleTextBox.Text) &&
                Book.OkForYear(yearTextBox.Text) && CheckAllAuthorTextBoxes())
                addButton.Enabled = true;
            else
                addButton.Enabled = false;
        }
        private bool CheckAllAuthorTextBoxes()
        {
            foreach (var tB in textBoxAuthorLayoutPanel.Controls)
            {
                if (tB is TextBox)
                {
                    if (!Book.OkForAuthor(((TextBox)tB).Text))
                        return false;
                }
            }
            return true;
        }
        private List<string> GetherAuthors()
        {
            List<string> l = new List<string>();
            foreach (var tB in textBoxAuthorLayoutPanel.Controls)
            {
                l.Add(((TextBox)tB).Text);
            }
            return l;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            AddTextbox(string.Empty);
            CheckAllTextBoxes();
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            List<string> authors = GetherAuthors();
            if (DisplayedBook != null)
            {
                try
                {
                    DisplayedBook.Edit(titleTextBox.Text, languageTextBox.Text,
                        authors, categoryTextBox.Text, Convert.ToInt32(yearTextBox.Text),
                        Convert.ToDouble(priceTextBox.Text), coverTextBox.Text);
                }
                catch (Exception ex)
                {
                    if (ErrorOccurred != null)
                        ErrorOccurred(this, new ObjectEventArgs("Некорректное значение поля."));
                }
            }
            else
                try
                {
                    DisplayedBook = new Book(titleTextBox.Text, languageTextBox.Text,
                        authors, categoryTextBox.Text, Convert.ToInt32(yearTextBox.Text),
                        Convert.ToDouble(priceTextBox.Text), coverTextBox.Text);
                }
                catch (Exception ex)
                {
                    if (ErrorOccurred != null)
                        ErrorOccurred(this, new ObjectEventArgs("Некорректное значение поля."));
                }
        }
    }
}
