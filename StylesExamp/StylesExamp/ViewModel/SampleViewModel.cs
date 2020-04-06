using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StylesExamp.ViewModel
{
    public class SampleViewModel : INotifyPropertyChanged
    {
        public SampleViewModel()
        {
            userName = "Hello Xamarin Forms";

            _UserColor = Color.Red;

            
            _visibleButton = new Command(LabelEnable);
            _UnvisibleButton = new Command(LabelDisable);
        }
        void LabelDisable()
        {
            _NeedToShow = false;
            raisePropertyChanged("NeedToShow");


        }
        void LabelEnable()
        {
            _NeedToShow = true;
            raisePropertyChanged("NeedToShow");
        }
        private ICommand _visibleButton;
        public ICommand VisibleButton
        { set
            {
                _visibleButton = value;
            }
            get
            {
                return _visibleButton;
            }
        }
        private ICommand _UnvisibleButton;
        public ICommand UnvisibleButton
        {
            set
            {
                _UnvisibleButton = value;
            }
            get
            {
                return _UnvisibleButton;
            }
        }

        private bool _NeedToShow;
        public bool NeedToShow
        {
            set
            {
                _NeedToShow = value;
            }
            get
            {
                return _NeedToShow;
            }
        }

        private Color _UserColor;
        public Color UserColor
        {
            set
            {
                _UserColor = value;
            }
            get
            {
                return _UserColor;
            }
        }


        private string userName;

        public event PropertyChangedEventHandler PropertyChanged;
        private void raisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }

        public string UserName
        {
            set
            {
                userName = value;
            }
            get
            {
                return userName;
            }
        }


        
    }
}
