using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD_Library.Core.ViewModels
{
    public class FourthViewModel
        : MvxViewModel
    {
        private string _hello1 = "Hello MvvmCross";
        public string Hello1
        {
            get { return _hello1; }
            set { _hello1 = value; RaisePropertyChanged(() => Hello1); }
        }



        /// <summary>
        /// navigation Pagina Concepto
        /// </summary>

        private Cirrious.MvvmCross.ViewModels.MvxCommand _goFifthCommand;
        public System.Windows.Input.ICommand GoFifthCommand
        {
            get
            {
                _goFifthCommand = _goFifthCommand ?? new Cirrious.MvvmCross.ViewModels.MvxCommand(DoGoFifth);
                return _goFifthCommand;
            }
        }

        private void DoGoFifth()
        {
            ShowViewModel<FifthViewModel>();
        }

        /// navigation Pagina Objetivo

        private Cirrious.MvvmCross.ViewModels.MvxCommand _goSixthCommand;
        public System.Windows.Input.ICommand GoSixthCommand
        {
            get
            {
                _goSixthCommand = _goSixthCommand ?? new Cirrious.MvvmCross.ViewModels.MvxCommand(DoGoSixth);
                return _goSixthCommand;
            }
        }

        private void DoGoSixth()
        {
            ShowViewModel<SixthViewModel>();
        }

        /// navigation Pagina Siete

        private Cirrious.MvvmCross.ViewModels.MvxCommand _goSevenCommand;
        public System.Windows.Input.ICommand GoSeventhCommand
        {
            get
            {
                _goSevenCommand = _goSevenCommand ?? new Cirrious.MvvmCross.ViewModels.MvxCommand(DoGoSeventh);
                return _goSevenCommand;
            }
        }

        private void DoGoSeventh()
        {
            ShowViewModel<SeventhViewModel>();
        }


    }
}

