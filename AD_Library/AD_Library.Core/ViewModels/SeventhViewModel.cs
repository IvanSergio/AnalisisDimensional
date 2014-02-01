using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD_Library.Core.ViewModels
{
    class SeventhViewModel
        : MvxViewModel
    {
        private string _hello = "Analisis Dimensional";

        public string Hello
        {
            get { return _hello; }
            set { _hello = value; RaisePropertyChanged(() => Hello); }
        }
    }
}
