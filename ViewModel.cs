using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA
{
    public class Level : INotifyPropertyChanged
    {

        private static Level _instance;

        public static Level Instance => _instance ??= new Level();

        public event PropertyChangedEventHandler PropertyChanged;
        //public string _currentTheme = LocalStorage.GetValue();
        public string _currentTheme;
        public string CurrentTheme
        {
            get => _currentTheme;
            set
            {
                if (_currentTheme != value)
                {
                    _currentTheme = value;
                    OnPropertyChanged(nameof(CurrentTheme));


                }

            }

        }
        public List<string> _operations = new List<string>();
        public List<string> AbleOperations
        {
            get => _operations;
            set
            {
                if (_operations != value)
                {
                    _operations = value;
                    OnPropertyChanged(nameof(AbleOperations));


                }

            }

        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Level() { }
    }
}
