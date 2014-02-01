using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD_Library.Core.ViewModels
{
    public class SecondViewModel
    : MvxViewModel
    { 
        private string _name = "Segunda Pantalla";

        public string Name
        {   
            get { return _name; }
            set { _name = value; RaisePropertyChanged(() => Name); }
        }

        //TERCERA PAGINA
        private Cirrious.MvvmCross.ViewModels.MvxCommand _goThirdCommand;
        public System.Windows.Input.ICommand GoThirdCommand
        {
            get
            {
                _goThirdCommand = _goThirdCommand ?? new Cirrious.MvvmCross.ViewModels.MvxCommand(DoGoThird);
                return _goThirdCommand;
            }
        }

        private void DoGoThird()
        {
            ShowViewModel<ThirdViewModel>(new { question = "What time is it?"});
        }



        //PRIMERO
        private string _ConBasic1 =
        "La velocidad se define como la derivada de la posición respecto al tiempo. Una derivada no es más que un cociente entre dos cantidades muy pequeñas y por tanto sus dimensiones serán las del numerador dividido por las del denominador";

        public string ConBasic1
        {
            get { return _ConBasic1; }
            set { _ConBasic1 = value; RaisePropertyChanged(() => _ConBasic1); }
        }

        private string _Img1 = "ms-appx:///Assets/Formula1.png";

        public string Img1
        {
            get { return _Img1; }
            set { _Img1 = value; RaisePropertyChanged(() => _Img1); }
        }

        private string _Fondo1 = "ms-appx:///Assets/Einstein.png";

        public string Fondo1
        {
            get { return _Fondo1; }
            set { _Fondo1 = value; RaisePropertyChanged(() => _Fondo1); }
        }


        //SEGUNDO

        private string _ConBasic2 =
        "La Cantidad de movimiento es el producto de la masa por la velocidad, por lo que sus dimensiones serán las del producto de estas dos cantidades:";

        public string ConBasic2
        {
            get { return _ConBasic2; }
            set { _ConBasic2 = value; RaisePropertyChanged(() => _ConBasic2); }
        }

        private string _Img2 = "ms-appx:///Assets/Formula2.png";

        public string Img2
        {
            get { return _Img2; }
            set { _Img2 = value; RaisePropertyChanged(() => _Img2); }
        }

        private string _Fondo2 = "ms-appx:///Assets/Einstein.png";

        public string Fondo2
        {
            get { return _Fondo2; }
            set { _Fondo2 = value; RaisePropertyChanged(() => _Fondo2); }
        }

        
        //TERCERO
        private string _ConBasic3 =
        "La aceleración es la derivada de la velocidad respecto al tiempo, por tanto";

        public string ConBasic3
        {
            get { return _ConBasic3; }
            set { _ConBasic3 = value; RaisePropertyChanged(() => _ConBasic3); }
        }

        private string _Img3 = "ms-appx:///Assets/Formula3.png";

        public string Img3
        {
            get { return _Img3; }
            set { _Img3 = value; RaisePropertyChanged(() => _Img3); }
        }

        private string _Fondo3 = "ms-appx:///Assets/Einstein.png";

        public string Fondo3
        {
            get { return _Fondo3; }
            set { _Fondo3 = value; RaisePropertyChanged(() => _Fondo3); }
        }



        //CUARTO
        private string _ConBasic4 =
        "La fuerza se define como la derivada de la cantidad de movimiento con respecto al tiempo (aunque también suele expresarse como el producto de la masa por la aceleración). Por ello";

        public string ConBasic4
        {
            get { return _ConBasic4; }
            set { _ConBasic4 = value; RaisePropertyChanged(() => _ConBasic4); }
        }

        private string _Img4 = "ms-appx:///Assets/Formula4.png";

        public string Img4
        {
            get { return _Img4; }
            set { _Img4 = value; RaisePropertyChanged(() => _Img4); }
        }

        private string _Fondo4 = "ms-appx:///Assets/Einstein.png";

        public string Fondo4
        {
            get { return _Fondo4; }
            set { _Fondo4 = value; RaisePropertyChanged(() => _Fondo4); }
        }



        //QUINTO
        private string _ConBasic5 =
        "El trabajo se define a partir de una integral, esto es, una suma de muchas cantidades muy pequeñas.  Las dimensiones de la integral son entonces las  mismas que las de cada uno de los sumandos. Cada  sumando es un trabajo diferencial, igual al producto escalar de una fuerza por un desplazamiento. Por ello";

        public string ConBasic5
        {
            get { return _ConBasic5; }
            set { _ConBasic5 = value; RaisePropertyChanged(() => _ConBasic5); }
        }

        private string _Img5 = "ms-appx:///Assets/Formula5.png";

        public string Img5
        {
            get { return _Img5; }
            set { _Img5 = value; RaisePropertyChanged(() => _Img5); }
        }

        private string _Fondo5 = "ms-appx:///Assets/Einstein.png";

        public string Fondo5
        {
            get { return _Fondo5; }
            set { _Fondo5 = value; RaisePropertyChanged(() => _Fondo5); }
        }


        //SEXTO
        private string _ConBasic6 =
        "La potencia es el cociente entre un trabajo diferencial y el tiempo diferencial en que se realiza. Las dimensiones las da también el cociente";

        public string ConBasic6
        {
            get { return _ConBasic6; }
            set { _ConBasic6 = value; RaisePropertyChanged(() => _ConBasic6); }
        }

        private string _Img6 = "ms-appx:///Assets/Formula6.png";

        public string Img6
        {
            get { return _Img6; }
            set { _Img6 = value; RaisePropertyChanged(() => _Img6); }
        }

        private string _Fondo6 = "ms-appx:///Assets/Einstein.png";

        public string Fondo6
        {
            get { return _Fondo6; }
            set { _Fondo6 = value; RaisePropertyChanged(() => _Fondo6); }
        }
    }
}
