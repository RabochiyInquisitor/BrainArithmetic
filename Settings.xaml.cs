namespace BA;

public partial class Settings : ContentPage
{
    private Level _viewModel;
    public List<string> values = new List<string>();
    public Settings()
    {
       
        _viewModel = Level.Instance;
        
        InitializeComponent();

    }
    private void changeLevel1(object sender, EventArgs e)
    {
        easy.BackgroundColor = Colors.Blue;
        middle.BackgroundColor = Colors.White;
        hard.BackgroundColor = Colors.White;
        userLevelButton.BackgroundColor = Colors.White;
        
        Plus.IsEnabled = false;
        Minus.IsEnabled = false;
        Multiplication.IsEnabled = false;
        Division.IsEnabled = false;

        


    }
    private void changeLevel2(object sender, EventArgs e)
    {
        easy.BackgroundColor = Colors.White;
        middle.BackgroundColor = Colors.Blue;
        hard.BackgroundColor = Colors.White;
        userLevelButton.BackgroundColor = Colors.White;

        Plus.IsEnabled = false;
        Minus.IsEnabled = false;
        Multiplication.IsEnabled = false;
        Division.IsEnabled = false;

        _viewModel.CurrentTheme = "middle";

    }
    private void changeLevel3(object sender, EventArgs e)
    {
        easy.BackgroundColor = Colors.White;
        middle.BackgroundColor = Colors.White;
        hard.BackgroundColor = Colors.Blue;
        userLevelButton.BackgroundColor = Colors.White;

        Plus.IsEnabled = false;
        Minus.IsEnabled = false;
        Multiplication.IsEnabled = false;
        Division.IsEnabled = false;

        _viewModel.CurrentTheme = "hard";

    }
    private void userLevel(object sender, EventArgs e)
    {

        easy.BackgroundColor = Colors.White;
        easy.BackgroundColor = Colors.White;
        hard.BackgroundColor = Colors.White;
        userLevelButton.BackgroundColor = Colors.Blue;


        Plus.IsEnabled = true;
        Minus.IsEnabled = true;
        Multiplication.IsEnabled = true;
        Division.IsEnabled = true;

        _viewModel.CurrentTheme = "user";
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
        ;

    }
    private async void Send(object sender, EventArgs e)
    {
        _viewModel.AbleOperations = values;
        await Shell.Current.GoToAsync("//MainPage");
    }
}