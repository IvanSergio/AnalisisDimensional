using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AD_Library.Core.ViewModels
{
    class ThirdViewModel
        : MvxViewModel
    {
        public void Init(string question)
        {
            TheAnswer = "I don´t know" + question;
        }
        private string _theAnswer;
        public string TheAnswer
        {
            get { return _theAnswer; }
            set { _theAnswer = value; RaisePropertyChanged(() => TheAnswer); }
        }



        ////////////////// IMAGENES

        private string _Img1 = "ms-appx:///Assets/Formula1Partes1.png";
        public string Img1
        {
            get { return _Img1; }
            set { _Img1 = value; RaisePropertyChanged(() => _Img1); }
        }

        private string _Img2 = "ms-appx:///Assets/Formula1Partes1.png";
        public string Img2
        {
            get { return _Img2; }
            set { _Img2 = value; RaisePropertyChanged(() => _Img2); }
        }

        private string _Img3 = "ms-appx:///Assets/Formula1Partes1.png";
        public string Img3
        {
            get { return _Img3; }
            set { _Img3 = value; RaisePropertyChanged(() => _Img3); }
        }


        private string _Img4 = "ms-appx:///Assets/Formula1Partes1.png";
        public string Img4
        {
            get { return _Img4; }
            set { _Img4 = value; RaisePropertyChanged(() => _Img4); }
        }


        private string _Img5 = "ms-appx:///Assets/Formula1Partes1.png";
        public string Img5
        {
            get { return _Img5; }
            set { _Img5 = value; RaisePropertyChanged(() => _Img5); }
        }


        private string _Img6 = "ms-appx:///Assets/Formula1Partes1.png";
        public string Img6
        {
            get { return _Img6; }
            set { _Img6 = value; RaisePropertyChanged(() => _Img6); }
        }
       
    }
}
