namespace BA
{
    public partial class AppShell : Shell
    {
        private Level _viewModel;
        public AppShell()
        {
            
            
            InitializeComponent();
            _viewModel = Level.Instance;
            string current = Preferences.Get("Theme", "default_value");
            if (current != "default_value" )
            {
                _viewModel.CurrentTheme = current;
            }
            string level = Preferences.Get("level", "default_value");
            if (level != "default_value")
            {
                _viewModel.Difficult = level;
            }

            BindingContext = Level.Instance;

            
        }
    }
}
