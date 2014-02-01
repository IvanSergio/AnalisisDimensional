using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD_Library.Core.ViewModels
{
    class EigthViewModel
        : MvxViewModel
    {
        private string _titulo = "   Ejemplo de Analisis Dimensional";
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; RaisePropertyChanged(() => Titulo); }
        }

        private string _enunciado = "      Enunciado";
        public string Enunciado
        {
            get { return _enunciado; }
            set { _enunciado = value; RaisePropertyChanged(() => Enunciado); }
        }

        private string _paso1 = "   Considerando las siguientes equivalencias";
        public string Paso1
        {
            get { return _paso1; }
            set { _paso1 = value; RaisePropertyChanged(() => Paso1); }
        }

        private string _paso2 = "   Obtenemos lo siguiente";
        public string Paso2
        {
            get { return _paso2; }
            set { _paso2 = value; RaisePropertyChanged(() => Paso2); }
        }

        private string _paso3 = "   Ahora despejando K obtenemos.";
        public string Paso3
        {
            get { return _paso3; }
            set { _paso3 = value; RaisePropertyChanged(() => Paso3); }
        }

        private string _paso4 = "   Simplificando  “M” ,  “L“  y  “T“  Obtenemos.";
        public string Paso4
        {
            get { return _paso4; }
            set { _paso4 = value; }
        }

        private string _paso5 = "   Conclusion: ";

        public string Paso5
        {
            get { return _paso5; }
            set { _paso5 = value; }
        }
        
        
        
        
        
    }
}
