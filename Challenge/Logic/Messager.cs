using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Challenge
{
    public interface IMessager
    {
        void ShowMessage(string mssg);
        void ShowError(string mssg);
    }
    class Messager: IMessager
    {
        public void ShowMessage(string mssg)
        {
            MessageBox.Show(mssg, "Сообщение");
        }
        public void ShowError(string mssg)
        {
            MessageBox.Show(mssg, "Ошибка");
        }
    }
}
