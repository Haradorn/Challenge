﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge
{
    public class Controller
    {
        private BookStore controllerBookStore;
        public IBookStoreWindow ControllerMainStoreWindow { get; private set; }
        public IMessager ControlerMessager { get; private set; }
        public XmlManager<BookStore> ControllerXMLManager { get; private set; }

        public Controller(BookStore bookStore, IMessager messager, IBookStoreWindow storeWindow)
        {
            this.ControlerMessager = messager;
            this.ControllerXMLManager = new XmlManager<BookStore>();
            this.controllerBookStore = bookStore;

            this.ControllerMainStoreWindow = storeWindow;
            storeWindow.DGVStoreSource = controllerBookStore.StoreBooksBindingList;
            ControllerMainStoreWindow.OpenButtonClicked += ControllerMainStoreWindow_OpenButtonClicked;
            ControllerMainStoreWindow.SaveButtonClicked += ControllerMainStoreWindow_SaveButtonClicked;
            ControllerMainStoreWindow.HtmlReportButtonClicked += ControllerMainStoreWindow_HtmlReportButtonClicked;

            ControllerMainStoreWindow.AddButtonClicked += ControllerMainStoreWindow_AddButtonClicked;
            ControllerMainStoreWindow.DeleteButtonClicked += ControllerMainStoreWindow_DeleteButtonClicked;
            ControllerMainStoreWindow.EditButtonClicked += ControllerMainStoreWindow_EditButtonClicked;

            ControllerMainStoreWindow.ErrorOccurred += ControllerMainStoreWindow_ErrorOccurred;

        }

        void ControllerMainStoreWindow_ErrorOccurred(object sender, ObjectEventArgs e)
        {
            ControlerMessager.ShowError((string)e.Data);
        }

        void ControllerMainStoreWindow_EditButtonClicked(object sender, ObjectEventArgs e)
        {
            ControllerMainStoreWindow.EditingBook = controllerBookStore.ReturnBookAt((int)e.Data);
        }

        void ControllerMainStoreWindow_HtmlReportButtonClicked(object sender, ObjectEventArgs e)
        {
            string message = string.Empty;

            if (!ControllerXMLManager.TryConvertFromXMLAndResourcesToHTML((string)e.Data, "doc.xml", Challenge.Properties.Resources.bookstoreStyle, controllerBookStore, out message))
                ControlerMessager.ShowMessage(message);
        }

        void ControllerMainStoreWindow_DeleteButtonClicked(object sender, ObjectEventArgs e)
        {
            controllerBookStore.RemoveBookAt((int)e.Data);
        }

        void ControllerMainStoreWindow_AddButtonClicked(object sender, ObjectEventArgs e)
        {
            controllerBookStore.AddBook((Book)e.Data);
        }

        void ControllerMainStoreWindow_SaveButtonClicked(object sender, ObjectEventArgs e)
        {
            string message;

            string path = (string)e.Data;

            if (!ControllerXMLManager.TrySerializeToXML(path, controllerBookStore, out message))
                ControlerMessager.ShowMessage(message);
        }

        void ControllerMainStoreWindow_OpenButtonClicked(object sender, ObjectEventArgs e)
        {
            string message;

            string path = (string)e.Data;

            if (!ControllerXMLManager.TryDeserializeFromXML(path, ref controllerBookStore, out message))
                ControlerMessager.ShowError(message);
            else
                ControllerMainStoreWindow.DGVStoreSource = controllerBookStore.StoreBooksBindingList;
        }

    }
}
