using System.ComponentModel;

namespace BA;

public partial class Settings : ContentPage
{
    private Level _viewModel;
    public List<string> values = new List<string>();
    public Settings()
    {
        InitializeComponent();
        _viewModel = Level.Instance;
        _viewModel.PropertyChanged += ViewModel_PropertyChanged;

        string themeKey = $"{_viewModel.CurrentTheme}.Settings.Screen";
        string standartButton = $"{_viewModel.CurrentTheme}.OperationButtonBackgroundColor";
        string choose_button = $"{_viewModel.CurrentTheme}.DoneButtonBackgroundColor";
        string textColorKey = $"{_viewModel.CurrentTheme}.TextColor";

        easy.BackgroundColor = (Color)Application.Current.Resources[standartButton];
        easy.TextColor = (Color)Application.Current.Resources[textColorKey];

        middle.BackgroundColor = (Color)Application.Current.Resources[standartButton];
        middle.TextColor = (Color)Application.Current.Resources[textColorKey];

        hard.BackgroundColor = (Color)Application.Current.Resources[standartButton];
        hard.TextColor = (Color)Application.Current.Resources[textColorKey];

        userLevelButton.BackgroundColor = (Color)Application.Current.Resources[standartButton];
        userLevelButton.TextColor = (Color)Application.Current.Resources[textColorKey];

        string level = _viewModel.Difficult;
        if (level != "default_value")
        {
            if (level == "user")
            {
                ((Button)this.FindByName("userLevelButton")).BackgroundColor = (Color)Application.Current.Resources[choose_button];
            }
            else
                ((Button)this.FindByName(level)).BackgroundColor = (Color)Application.Current.Resources[choose_button];
        }
        string theme = _viewModel.CurrentTheme;
        if (theme != "default_value")
        {
            screen.BackgroundColor = (Color)Application.Current.Resources[themeKey];
            ((RadioButton)this.FindByName(theme)).IsChecked = true;
        }

    }
    void ChangeTheme(object sender, CheckedChangedEventArgs e)
    {
        RadioButton theme = sender as RadioButton;
        _viewModel.CurrentTheme = theme.Value.ToString();
    }
    private void changeLevel1(object sender, EventArgs e)
    {
        string standartButton = $"{_viewModel.CurrentTheme}.OperationButtonBackgroundColor";
        string choose_button = $"{_viewModel.CurrentTheme}.DoneButtonBackgroundColor";
        string textColorKey = $"{_viewModel.CurrentTheme}.TextColor";




        easy.BackgroundColor = (Color)Application.Current.Resources[choose_button];
        middle.BackgroundColor = (Color)Application.Current.Resources[standartButton];
        hard.BackgroundColor = (Color)Application.Current.Resources[standartButton];
        userLevelButton.BackgroundColor = (Color)Application.Current.Resources[standartButton];

        Plus.IsEnabled = false;
        Minus.IsEnabled = false;
        Multiplication.IsEnabled = false;
        Division.IsEnabled = false;


        _viewModel.Difficult = "easy";
        values.Clear();

    }
    private void changeLevel2(object sender, EventArgs e)
    {
        string standartButton = $"{_viewModel.CurrentTheme}.OperationButtonBackgroundColor";
        string choose_button = $"{_viewModel.CurrentTheme}.DoneButtonBackgroundColor";
        string textColorKey = $"{_viewModel.CurrentTheme}.TextColor";




        easy.BackgroundColor = (Color)Application.Current.Resources[standartButton]; 
        middle.BackgroundColor = (Color)Application.Current.Resources[choose_button];
        hard.BackgroundColor = (Color)Application.Current.Resources[standartButton];
        userLevelButton.BackgroundColor = (Color)Application.Current.Resources[standartButton];

        Plus.IsEnabled = false;
        Minus.IsEnabled = false;
        Multiplication.IsEnabled = false;
        Division.IsEnabled = false;

        _viewModel.Difficult = "middle";
        values.Clear();

    }
    private void changeLevel3(object sender, EventArgs e)
    {
        string standartButton = $"{_viewModel.CurrentTheme}.OperationButtonBackgroundColor";
        string choose_button = $"{_viewModel.CurrentTheme}.DoneButtonBackgroundColor";
        string textColorKey = $"{_viewModel.CurrentTheme}.TextColor";




        easy.BackgroundColor = (Color)Application.Current.Resources[standartButton];
        middle.BackgroundColor = (Color)Application.Current.Resources[standartButton];
        hard.BackgroundColor = (Color)Application.Current.Resources[choose_button];
        userLevelButton.BackgroundColor = (Color)Application.Current.Resources[standartButton];

        Plus.IsEnabled = false;
        Minus.IsEnabled = false;
        Multiplication.IsEnabled = false;
        Division.IsEnabled = false;

        _viewModel.Difficult = "hard";
        values.Clear();

    }
    private void userLevel(object sender, EventArgs e)
    {
        string standartButton = $"{_viewModel.CurrentTheme}.OperationButtonBackgroundColor";
        string choose_button = $"{_viewModel.CurrentTheme}.DoneButtonBackgroundColor";
        string textColorKey = $"{_viewModel.CurrentTheme}.TextColor";




        easy.BackgroundColor = (Color)Application.Current.Resources[standartButton];
        middle.BackgroundColor = (Color)Application.Current.Resources[standartButton];
        hard.BackgroundColor = (Color)Application.Current.Resources[standartButton];
        userLevelButton.BackgroundColor = (Color)Application.Current.Resources[choose_button];


        Plus.IsEnabled = true;
        Minus.IsEnabled = true;
        Multiplication.IsEnabled = true;
        Division.IsEnabled = true;

        _viewModel.Difficult = "user";

    }
    private void CheckChanged(object sender, CheckedChangedEventArgs e)
    {
        CheckBox checkBox = sender as CheckBox;
        string value = string.Empty;
        if (checkBox == Plus)
        {
            value = "+";
        }
        if (checkBox == Minus)
        {
            value = "-";
        }
        if (checkBox == Multiplication)
        {
            value = "*";
        }
        if (checkBox == Division)
        {
            value = "/";
        }

        if (e.Value)
        {
            values.Add(value);
        }
        else
            values.Remove(value);


    }
    private async void Send(object sender, EventArgs e)
    {
        _viewModel.AbleOperations = values;
        await Shell.Current.GoToAsync("//MainPage");
    }
    private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        try
        {
            string themeKey = $"{_viewModel.CurrentTheme}.Settings.Screen";
            screen.BackgroundColor = (Color)Application.Current.Resources[themeKey];
            string standartButton = $"{_viewModel.CurrentTheme}.OperationButtonBackgroundColor";
            string choose_button = $"{_viewModel.CurrentTheme}.DoneButtonBackgroundColor";
            string textColorKey = $"{_viewModel.CurrentTheme}.TextColor";

            easy.BackgroundColor = (Color)Application.Current.Resources[standartButton];
            easy.TextColor = (Color)Application.Current.Resources[textColorKey];

            middle.BackgroundColor = (Color)Application.Current.Resources[standartButton];
            middle.TextColor = (Color)Application.Current.Resources[textColorKey];

            hard.BackgroundColor = (Color)Application.Current.Resources[standartButton];
            hard.TextColor = (Color)Application.Current.Resources[textColorKey];

            userLevelButton.BackgroundColor = (Color)Application.Current.Resources[standartButton];
            userLevelButton.TextColor = (Color)Application.Current.Resources[textColorKey];

            string level = _viewModel.Difficult;
            if (level != "default_value")
            {
                if (level == "user")
                {
                    ((Button)this.FindByName("userLevelButton")).BackgroundColor = (Color)Application.Current.Resources[choose_button];
                }
                else
                    ((Button)this.FindByName(level)).BackgroundColor = (Color)Application.Current.Resources[choose_button];
            }
        }
        catch (Exception ex) 
        { Console.WriteLine(ex); }
    }
}