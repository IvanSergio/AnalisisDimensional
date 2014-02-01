using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD_Library.Core.ViewModels
{
    class SixthViewModel
        : MvxViewModel
    {
        private string _hello = "Pagina Seis Objetivos";
        public string Hello
        {
            get { return _hello; }
            set { _hello = value; RaisePropertyChanged(() => Hello); }
        }


        private string _titulo = " OBJETIVOS Analisis Dimensional ";
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; RaisePropertyChanged(() => _titulo); }
        }

        private string _contenido1 = "-	Comprobar su una formula física o química está escrita correctamente";
        public string Contenido1
        {
            get { return _contenido1; }
            set { _contenido1 = value; RaisePropertyChanged(() => _contenido1); }
        }
        private string _contenido2 = "-	Deducir Fórmulas físicas o Química a partir de datos experimentales.";
        public string Contenido2
        {
            get { return _contenido2; }
            set { _contenido2 = value; RaisePropertyChanged(() => _contenido2); }
        }
        private string _contenido3 = "-	Obtener Unidades de magnitudes derivadas en función de las fundamentales";
        public string Contenido3
        {
            get { return _contenido3; }
            set { _contenido3 = value; RaisePropertyChanged(() => _contenido3); }
        }
    }
}
