namespace BA
{
    public partial class MainPage : ContentPage
    {

        public static int Value;
        public static string Sample;
        private Level level;
        public MainPage()
        {
            level = Level.Instance;
            InitializeComponent();
            //BindingContext = level._operations;
            if (level._currentTheme == "easy")
            {
                var arr = ChangeText(level._operations.ToArray(), 150, 240, 10, 150, 1);
                MainPage.Value = arr.Item2;
                MainPage.Sample = arr.Item1;
                MyTask.Text = arr.Item1;
            }
            else if (level._currentTheme == "middle")
            {
                var arr = ChangeText(level._operations.ToArray(), 250, 500, 100, 200, 2);
                MainPage.Value = arr.Item2;
                MainPage.Sample = arr.Item1;
                MyTask.Text = arr.Item1;
            }
            else if (level._currentTheme == "hard")
            {
                var arr = ChangeText(level._operations.ToArray(), 500, 658, 300, 430, 3);
                MainPage.Value = arr.Item2;
                MainPage.Sample = arr.Item1;
                MyTask.Text = arr.Item1;
            }
            else if (level._currentTheme == "user")
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
                if (level._currentTheme == "easy")
                {
                    var arr = ChangeText(level._operations.ToArray(), 150, 240, 10, 150, 1);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;

                }
                else if (level._currentTheme == "middle")
                {
                    var arr = ChangeText(level._operations.ToArray(), 250, 500, 100, 200, 2);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;
                }
                else if (level._currentTheme == "hard")
                {
                    var arr = ChangeText(level._operations.ToArray(), 500, 658, 300, 430, 3);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;
                }
                else if (level._currentTheme == "user")
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
            else
            {
                MyTask.Text = "Неверно!";
                await Task.Delay(1000);
                if (level._currentTheme == "easy")
                {
                    var arr = ChangeText(level._operations.ToArray(), 150, 240, 10, 150, 1);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;
                }
                else if (level._currentTheme == "middle")
                {
                    var arr = ChangeText(level._operations.ToArray(), 250, 500, 100, 200, 2);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;
                }
                else if (level._currentTheme == "hard")
                {
                    var arr = ChangeText(level._operations.ToArray(), 500, 658, 300, 430, 3);
                    MainPage.Value = arr.Item2;
                    MainPage.Sample = arr.Item1;
                    MyTask.Text = arr.Item1;
                }
                else if (level._currentTheme == "user")
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
    }

}
