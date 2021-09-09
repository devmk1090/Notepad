using Notepad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Notepad.ViewModels
{
    public class MainViewModel
    {
        private DocumentModel _document;
        public EditorViewModel Editor { get; set; }

        public MainViewModel()
        {
            _document = new DocumentModel();
            Editor = new EditorViewModel(_document);
        }
    }
}
