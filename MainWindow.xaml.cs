using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hello;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ExitBun_OnClick(object sender, RoutedEventArgs e)
    {
       Close();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        Button button=sender as Button;
        numberBox.Text = numberBox.Text.ToString() + button.Content.ToString();
    }

    private void ButtonBase_OnClick_1(object sender, RoutedEventArgs e)
    {
        numberBox.Text = string.Empty;
    }

    private void ButtonBase_OnClick_2(object sender, RoutedEventArgs e)
    {
        if (numberBox.Text != null && numberBox.Text != "")
        numberBox.Text = numberBox.Text.Substring(0, numberBox.Text.Length - 1);
    }

    private void ButtonBase_OnClick_3(object sender, RoutedEventArgs e)
    {
        Button button=sender as Button;
        numberBox.Text = numberBox.Text.ToString() +" "+ button.Content.ToString()+" ";
    }

    private void ButtonBase_OnClick_4(object sender, RoutedEventArgs e)
    {
        string[] res = numberBox.Text.Split(" ");
        numberBox.Text = Hello(res).ToString();
    }

    public double Hello(string[] res)
    {
        double a = double.Parse(res[0]);
        for (int i = 1; i < res.Length; i+=2)
        {
            switch (res[i])
            {
                case "+":
                {
                    a = a + double.Parse(res[i+1]);
                    break;
                }
                case "-":
                {
                    a = a - double.Parse(res[i+1]);
                    break;
                }
                case "*":
                {
                    a = a * double.Parse(res[i+1]);
                    break;
                }
                case "/":
                {
                    a = a / double.Parse(res[i+1]);
                    break;
                }
            }   
        }
        return a;
    }

    private void ButtonBase_OnClick_5(object sender, RoutedEventArgs e)
    {
        string[] res = numberBox.Text.Split(" ");
        numberBox.Text = Daraja(res).ToString();
    }

    public double Daraja(string[] res)
    {
        double b = double.Parse(res[0]);
        b = b * double.Parse(res[0]);
        return b;
    }

    private void ButtonBase_OnClick_6(object sender, RoutedEventArgs e)
    {
        string[] res = numberBox.Text.Split(" ");
        numberBox.Text = Taqsim(res).ToString();
    }

    public double Taqsim(string[] res)
    {
        double a = double.Parse(res[0]);
        a = 1 / a ;
        return a;
    }

    private void ButtonBase_OnClick_7(object sender, RoutedEventArgs e)
    {
        string[] res = numberBox.Text.Split(" ");
        numberBox.Text = Ildiz(res).ToString();
    }

    public double Ildiz(string[] res)
    {
        double a = double.Parse(res[0]);
        a = Math.Sqrt(a);
        return a;
    }

    private void ButtonBase_OnClick_8(object sender, RoutedEventArgs e)
    {
        string[] res = numberBox.Text.Split(" ");
        numberBox.Text = Foiz(res).ToString();
    }

    public double Foiz(string[] res)
    {
        double a = double.Parse(res[0]);
        double b = double.Parse(res[1]);
        double c = ((a * b) / 100);
        return c;
    }

    private void ButtonBase_OnClick_9(object sender, RoutedEventArgs e)
    {
      
    }
}