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
    public interface IBookStoreWindow
    {
        BindingList<Book> DGVStoreSource { get; set; }
        Book EditingBook { get; set; }
        event EventHandler<ObjectEventArgs> OpenButtonClicked;
        event EventHandler<ObjectEventArgs> SaveButtonClicked;
        event EventHandler<ObjectEventArgs> HtmlReportButtonClicked;
        event EventHandler<ObjectEventArgs> DeleteButtonClicked;
        event EventHandler<ObjectEventArgs> AddButtonClicked;
        event EventHandler<ObjectEventArgs> EditButtonClicked;
        event EventHandler<ObjectEventArgs> ErrorOccurred;
    }
    public partial class mainForm : Form, IBookStoreWindow
    {
        public BindingList<Book> DGVStoreSource { get; set; } //источник для датагрид
        public Book EditingBook { get; set; } //книга, которая будет редактироваться
        private bookForm AddBookDialogWindow;
        public event EventHandler<ObjectEventArgs> OpenButtonClicked;
        public event EventHandler<ObjectEventArgs> SaveButtonClicked;
        public event EventHandler<ObjectEventArgs> HtmlReportButtonClicked;
        public event EventHandler<ObjectEventArgs> DeleteButtonClicked;
        public event EventHandler<ObjectEventArgs> AddButtonClicked;
        public event EventHandler<ObjectEventArgs> EditButtonClicked;
        public event EventHandler<ObjectEventArgs> ErrorOccurred;
        public mainForm(BindingList<Book> DGVSource)
        {
            DGVStoreSource = DGVSource;
            InitializeComponent();
            storeDataGridView.DataSource = DGVStoreSource;
            storeDataGridView.AllowUserToAddRows = false;
        }

        //загружаем в приложение данные из xml файла
        private void openXMLbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files|*.xml|All files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (OpenButtonClicked != null)
                    OpenButtonClicked(this, new ObjectEventArgs(openFileDialog.FileName));
                storeDataGridView.DataSource = DGVStoreSource;
            }
        }

        //выбираем место и имя для xml файла, в который будут сохранены данные таблицы
        private void saveXMLbutton_Click(object sender, EventArgs e) 
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files|*.xml";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (SaveButtonClicked != null)
                    SaveButtonClicked(this, new ObjectEventArgs(saveFileDialog.FileName));
            }
        }

        //удаляем запись по выделенному индексу строки
        private void deleteRecordbutton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in storeDataGridView.SelectedRows)
            {
                if (row.Selected)
                {
                    int index = row.Index;

                    if (DeleteButtonClicked != null)
                        DeleteButtonClicked(this, new ObjectEventArgs(index));
                }
            }
        }

        //добавляем запись в таблицу
        private void addRecordbutton_Click(object sender, EventArgs e)
        {
            AddBookDialogWindow = new bookForm();
            AddBookDialogWindow.ErrorOccurred += AddBookDialogWindow_ErrorOccurred;
            if (AddBookDialogWindow.ShowDialog(this) == DialogResult.OK)
            {
                Book anotherBook = AddBookDialogWindow.DisplayedBook;
                if (AddButtonClicked != null)
                    AddButtonClicked(this, new ObjectEventArgs(anotherBook));
            }
            AddBookDialogWindow.Dispose();
        }

        //редактируем выделенную запись таблицы
        private void editRecordbutton_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in storeDataGridView.SelectedRows)
            {
                if (row.Selected)
                {
                    int index = row.Index;
                    if (EditButtonClicked != null)
                    {
                        EditButtonClicked(this, new ObjectEventArgs(index));
                        break;
                    }
                }
            }
            if (EditingBook != null)
            {
                AddBookDialogWindow = new bookForm(EditingBook);
                AddBookDialogWindow.ErrorOccurred += AddBookDialogWindow_ErrorOccurred;
                if(AddBookDialogWindow.ShowDialog(this) == DialogResult.OK)
                {
                    DGVStoreSource.ResetBindings();
                }
                AddBookDialogWindow.Dispose();
                EditingBook = null;
            }
        }

        //формирование отчёта в html
        private void reportHTMLbutton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HTML files|*.html";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (HtmlReportButtonClicked != null)
                    HtmlReportButtonClicked(this, new ObjectEventArgs(saveFileDialog.FileName));
            }
        }
        private void AddBookDialogWindow_ErrorOccurred(object Sender, ObjectEventArgs e)
        {
            if (ErrorOccurred != null)
                ErrorOccurred(this, e);
        }
    }
    public class ObjectEventArgs : EventArgs
    {
        public object Data { get; private set; }
        public ObjectEventArgs(object data)
        {
            this.Data = data;
        }
    }
}
