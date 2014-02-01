using Cirrious.MvvmCross.ViewModels;

namespace AD_Library.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

        private Cirrious.MvvmCross.ViewModels.MvxCommand _myCommand;
        public System.Windows.Input.ICommand MyCommand
        {
            get
            {
                _myCommand = _myCommand ?? new Cirrious.MvvmCross.ViewModels.MvxCommand(DoMyCommand);
                return _myCommand;
            }
        }

        private void DoMyCommand()
        {
            Hello = Hello + "Hola";
        }



        private Cirrious.MvvmCross.ViewModels.MvxCommand _goSecondCommand;
        public System.Windows.Input.ICommand GoSecondCommand
        {
            get
            {
                _goSecondCommand = _goSecondCommand ?? new Cirrious.MvvmCross.ViewModels.MvxCommand(DoGoCommand);
                return _goSecondCommand;
            }
        }

        private void DoGoCommand()
        {
            ShowViewModel<SecondViewModel>();
        }

        /// <summary>
        /// CUARTA PAGINA
        /// </summary>

        private Cirrious.MvvmCross.ViewModels.MvxCommand _goFourthCommand;
        public System.Windows.Input.ICommand GoFourthCommand
        {
            get
            {
                _goFourthCommand = _goFourthCommand ?? new Cirrious.MvvmCross.ViewModels.MvxCommand(DoGoFourth);
                return _goFourthCommand;
            }
        }

        private void DoGoFourth()
        {
            ShowViewModel<FourthViewModel>();
        }

        //OCTAVA PAGINA
        private Cirrious.MvvmCross.ViewModels.MvxCommand _goEigthCommand;
        public System.Windows.Input.ICommand GoEigthCommand
        {
            get
            {
                _goEigthCommand = _goEigthCommand ?? new Cirrious.MvvmCross.ViewModels.MvxCommand(DoGoEigth);
                return _goEigthCommand;
            }
        }

        private void DoGoEigth()
        {
            ShowViewModel<EigthViewModel>();
        }
        
        
    }
}



