using System.ComponentModel;

namespace BA
{
    public partial class MainPage : ContentPage
    {

        public static int Value;
        public static string Sample;
        private Level level;
        public string[] standart_buttons = ["One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Zero"];
        public MainPage()
        {
            
            InitializeComponent();
            level = Level.Instance;
            level.PropertyChanged += ViewModel_PropertyChanged;
            if (level._difficult == "easy")
            {
                var arr = ChangeText(level._operations.ToArray(), 150, 240, 10, 150, 1);
                MainPage.Value = arr.Item2;
                MainPage.Sample = arr.Item1;
                MyTask.Text = arr.Item1;
            }
            else if (level._difficult == "middle")
            {
                var arr = ChangeText(level._operations.ToArray(), 250, 500, 100, 200, 2);
                MainPage.Value = arr.Item2;
                MainPage.Sample = arr.Item1;
                MyTask.Text = arr.Item1;
            }
            else if (level._difficult == "hard")
            {
                var arr = ChangeText(level._operations.ToArray(), 500, 658, 300, 430, 3);
                MainPage.Value = arr.Item2;
                MainPage.Sample = arr.Item1;
                MyTask.Text = arr.Item1;
            }
            else if (level._difficult == "user")
            {
                var arr = ChangeText(level._operations.ToArray(), 150, 240, 10, 150, level._operations.ToArray().Length);
                MainPage.Value = arr.Item2;
                MainPage.Sample = arr.Item1;
                MyTask.Text = arr.Item1;
            }
            else
            {
                var arr = ChangeText(level._operations.ToArray(), 150, 240, 10, 150, 1);
                MainPage.Value = arr.Item2;
                MainPage.Sample = arr.Item1;
                MyTask.Text = arr.Item1;
            }




            string themeKey = $"{level.CurrentTheme}.StandartButtonBackgroundColor";
            string textColorKey = $"{level.CurrentTheme}.TextColor";
            string forLabel = $"{level.CurrentTheme}.TextColorForLabel";
            string forInput = $"{level.CurrentTheme}.TextColorForInput";

            string top = $"{level.CurrentTheme}.TopScreenBackgroundColor";
            string bottom = $"{level.CurrentTheme}.BottomScreenBackgroundColor";

            string funcButton = $"{level.CurrentTheme}.OperationButtonBackgroundColor";

            string done = $"{level.CurrentTheme}.DoneButtonBackgroundColor";



            One.Background = (Color)Application.Current.Resources[themeKey];
            One.TextColor = (Color)Application.Current.Resources[textColorKey];

            Two.Background = (Color)Application.Current.Resources[themeKey];
            Two.TextColor = (Color)Application.Current.Resources[textColorKey];

            Three.Background = (Color)Application.Current.Resources[themeKey];
            Three.TextColor = (Color)Application.Current.Resources[textColorKey];

            Four.Background = (Color)Application.Current.Resources[themeKey];
            Four.TextColor = (Color)Application.Current.Resources[textColorKey];

            Five.Background = (Color)Application.Current.Resources[themeKey];
            Five.TextColor = (Color)Application.Current.Resources[textColorKey];

            Six.Background = (Color)Application.Current.Resources[themeKey];
            Six.TextColor = (Color)Application.Current.Resources[textColorKey];

            Seven.Background = (Color)Application.Current.Resources[themeKey];
            Seven.TextColor = (Color)Application.Current.Resources[textColorKey];

            Eight.Background = (Color)Application.Current.Resources[themeKey];
            Eight.TextColor = (Color)Application.Current.Resources[textColorKey];

            Nine.Background = (Color)Application.Current.Resources[themeKey];
            Nine.TextColor = (Color)Application.Current.Resources[textColorKey];

            Zero.Background = (Color)Application.Current.Resources[themeKey];
            Zero.TextColor = (Color)Application.Current.Resources[textColorKey];

            Top.Background = (Color)Application.Current.Resources[top];
            Bottom.Background = (Color)Application.Current.Resources[bottom];

            MyTask.TextColor = (Color)Application.Current.Resources[forLabel];
            Place.TextColor = (Color)Application.Current.Resources[forInput];

            Point.Background = (Color)Application.Current.Resources[funcButton];
            Point.TextColor = (Color)Application.Current.Resources[textColorKey];

            Delete.Background = (Color)Application.Current.Resources[funcButton];
            Delete.TextColor = (Color)Application.Current.Resources[textColorKey];

            SettingsB.Background = (Color)Application.Current.Resources[funcButton];
            SettingsB.TextColor = (Color)Application.Current.Resources[textColorKey];

            Minus.Background = (Color)Application.Current.Resources[funcButton];
            Minus.TextColor = (Color)Application.Current.Resources[textColorKey];

            DoneB.Background = (Color)Application.Current.Resources[done];
            DoneB.TextColor = (Color)Application.Current.Resources[textColorKey];





        }

        async private void Settings(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Settings");
        }
        public (string, int) ChangeText(string[] able, int min = 150, int max = 240, int min2 = 10, int max2 = 150, int posibble_opers = 2)
        {
            if (able.Length <= 0)
            {
                able = ["+", "-", "*", "/"];
            }

            Random numbers = new Random();
            int id = numbers.Next(0, posibble_opers);
            int value1 = numbers.Next(min, max);
            int value2 = numbers.Next(min2, max2);
            string oper = able[id];
            string output = Convert.ToString(value1) + Convert.ToString(oper) + Convert.ToString(value2);
            switch (oper)
            {
                case "+":
                    {
                        int res = value1 + value2;
                        return (output, res);
                    }
                case "-":
                    {
                        int res = value1 - value2;
                        return (output, res);
                    }
                case "*":
                    {
                        int res = value1 * value2;
                        return (output, res);
                    }
                case "/":
                    {
                        int res = value1 / value2;
                        return (output, res);
                    }
                default:
                    return (output, 0);
            }

        }
        private void Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            Place.Text += button.Text;
        }
        private void Del(object sender, EventArgs e)
        {
            try
            {
                string result = Place.Text.Substring(0, Place.Text.Length - 1);
                Place.Text = result;
            }
            catch
            {
                
            }
        }
        private async void Done(object sender, EventArgs e)
        {

            if (Convert.ToString(MainPage.Value) == Convert.ToString(Place.Text))
            {
                MyTask.Text = "Верно!";
                await Task.Delay(1000);
                if (level._difficult == "easy")
                {
                    var arr = ChangeText(level._operations.ToArray(), 150, 240, 10, 150, 1);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;

                }
                else if (level._difficult == "middle")
                {
                    var arr = ChangeText(level._operations.ToArray(), 250, 500, 100, 200, 2);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;
                }
                else if (level._difficult == "hard")
                {
                    var arr = ChangeText(level._operations.ToArray(), 500, 658, 300, 430, 3);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;
                }
                else if (level._difficult == "user")
                {
                    var arr = ChangeText(level._operations.ToArray(), 150, 240, 10, 150, level._operations.ToArray().Length);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;
                }
                else
                {
                    var arr = ChangeText(level._operations.ToArray(), 150, 240, 10, 150, 1);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;
                }
                Place.Text = string.Empty;


            }
            else if (Convert.ToString(MainPage.Value) != Convert.ToString(Place.Text) && Convert.ToString(Place.Text) != null && Convert.ToString(Place.Text) != "")
            {
                MyTask.Text = "Неверно!";
                await Task.Delay(1000);
                if (level._difficult == "easy")
                {
                    var arr = ChangeText(level._operations.ToArray(), 150, 240, 10, 150, 1);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;
                }
                else if (level._difficult == "middle")
                {
                    var arr = ChangeText(level._operations.ToArray(), 250, 500, 100, 200, 2);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;
                }
                else if (level._difficult == "hard")
                {
                    var arr = ChangeText(level._operations.ToArray(), 500, 658, 300, 430, 3);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;
                }
                else if (level._difficult == "user")
                {
                    var arr = ChangeText(level._operations.ToArray(), 150, 240, 10, 150, level._operations.ToArray().Length);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;
                }
                else
                {
                    var arr = ChangeText(level._operations.ToArray(), 150, 240, 10, 150, 1);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;
                }
                Place.Text = string.Empty;
            }
            
        }
        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            string themeKey = $"{level.CurrentTheme}.StandartButtonBackgroundColor";
            string textColorKey = $"{level.CurrentTheme}.TextColor";
            string forLabel = $"{level.CurrentTheme}.TextColorForLabel";
            string forInput = $"{level.CurrentTheme}.TextColorForInput";

            string top = $"{level.CurrentTheme}.TopScreenBackgroundColor";
            string bottom = $"{level.CurrentTheme}.BottomScreenBackgroundColor";

            string funcButton = $"{level.CurrentTheme}.OperationButtonBackgroundColor";

            string done = $"{level.CurrentTheme}.DoneButtonBackgroundColor";



            One.Background = (Color)Application.Current.Resources[themeKey];
            One.TextColor = (Color)Application.Current.Resources[textColorKey];

            Two.Background = (Color)Application.Current.Resources[themeKey];
            Two.TextColor = (Color)Application.Current.Resources[textColorKey];

            Three.Background = (Color)Application.Current.Resources[themeKey];
            Three.TextColor = (Color)Application.Current.Resources[textColorKey];

            Four.Background = (Color)Application.Current.Resources[themeKey];
            Four.TextColor = (Color)Application.Current.Resources[textColorKey];

            Five.Background = (Color)Application.Current.Resources[themeKey];
            Five.TextColor = (Color)Application.Current.Resources[textColorKey];

            Six.Background = (Color)Application.Current.Resources[themeKey];
            Six.TextColor = (Color)Application.Current.Resources[textColorKey];

            Seven.Background = (Color)Application.Current.Resources[themeKey];
            Seven.TextColor = (Color)Application.Current.Resources[textColorKey];

            Eight.Background = (Color)Application.Current.Resources[themeKey];
            Eight.TextColor = (Color)Application.Current.Resources[textColorKey];

            Nine.Background = (Color)Application.Current.Resources[themeKey];
            Nine.TextColor = (Color)Application.Current.Resources[textColorKey];

            Zero.Background = (Color)Application.Current.Resources[themeKey];
            Zero.TextColor = (Color)Application.Current.Resources[textColorKey];

            Top.Background = (Color)Application.Current.Resources[top];
            Bottom.Background = (Color)Application.Current.Resources[bottom];

            MyTask.TextColor = (Color)Application.Current.Resources[forLabel];
            Place.TextColor = (Color)Application.Current.Resources[forInput];

            Point.Background = (Color)Application.Current.Resources[funcButton];
            Point.TextColor = (Color)Application.Current.Resources[textColorKey];

            Delete.Background = (Color)Application.Current.Resources[funcButton];
            Delete.TextColor = (Color)Application.Current.Resources[textColorKey];

            SettingsB.Background = (Color)Application.Current.Resources[funcButton];
            SettingsB.TextColor = (Color)Application.Current.Resources[textColorKey];

            Minus.Background = (Color)Application.Current.Resources[funcButton];
            Minus.TextColor = (Color)Application.Current.Resources[textColorKey];

            DoneB.Background = (Color)Application.Current.Resources[done];
            DoneB.TextColor = (Color)Application.Current.Resources[textColorKey];

        }
    }
}
