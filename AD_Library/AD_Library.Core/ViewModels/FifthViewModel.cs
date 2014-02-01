using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD_Library.Core.ViewModels
{
    class FifthViewModel
        : MvxViewModel
    {
        private string _titulo = "CONCEPTO Analisis Dimensional";
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; RaisePropertyChanged(() => Titulo); }
        }

        private string _contenido = "DEFINICION: \nDesde que la palabra “Física” proviene del término “Physis”, que significa “Naturaleza”, en sus inicios, más o menos hasta los principios del siglo XIX, la Física se consideró como una Ciencia que estudia los fenómenos naturales. Pero a partir del siglo XIX, se redujo su campo, limitándola al estudio de los llamados “Fenómenos Físicos”, el resto de fenómenos pasaron a formar parte de otras ciencias naturales. La física es una ciencia natural encargada de estudiar los fenómenos físicos que ocurren en la naturaleza, sistematizándolos a través de leyes físicas determinadas \n FENOMENO FISICA. Es todo cambio y/o transformación que experimentan ciertos cuerpos sin alterar su estructura intima. Es decir, son cambios reversibles.Por Ejemplo:\n-	Los cambios de estado.\n-	El movimiento de los cuerpos.\n-	La dilatación de los cuerpos, etc.";
        public string Contenido
        {
            get { return _contenido; }
            set { _contenido = value; RaisePropertyChanged(() => _contenido); }
        }

    }
}
