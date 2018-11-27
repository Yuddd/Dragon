using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private string str="";
        private string str1 = "";
        private string[] reg = { "+", "-", "*", "/" };

        public int Inclu(string y)
        {
            int x = 0;
            for (int i = 0; i < 4; i++)
            {
                if (y.Substring(y.Length - 1, 1).Equals(reg[i]))
                {
                    x++;
                }
            }
            return x;
        }

        public void AddNum(string x)
        {
            string y=x.Substring(x.Length-1, 1);
            str += y;
            input.Text = str;
        }

        private void Bt_0(object sender, RoutedEventArgs e)
        {

            AddNum((sender as Button).ToString());
        }

        private void Bt_num(object sender, RoutedEventArgs e)
        {
            AddNum((sender as Button).ToString());
        }



        

        private void Bt_except(object sender, RoutedEventArgs e)
        {
            string last = (sender as Button).ToString();
            int index = Inclu(input.Text);
            if (index == 1)
            {
                string str1 = input.Text.Substring(0, input.Text.Length - 1);
                str = str1 + last.Substring(last.Length-1,1);
                input.Text = str;
            }
            else
            {
                str += last.Substring(last.Length-1,1);
                input.Text = str;
            }
            str1 = str.Substring(0,str.Length - 1);
            oldinput.Content = str1;
        }

        private void Bt_dot(object sender, RoutedEventArgs e)
        {
            str += ".";
            input.Text = str;
        }

        private void Bt_invese(object sender, RoutedEventArgs e)
        {

        }

        private void Bt_quyu(object sender, RoutedEventArgs e)
        {
            
        }

        private void Bt_sqrt(object sender, RoutedEventArgs e)
        {

        }

        private void Bt_x2(object sender, RoutedEventArgs e)
        {

        }

        private void Bt_1x(object sender, RoutedEventArgs e)
        {

        }

        private void Bt_c(object sender, RoutedEventArgs e)
        {
            str = "";
            input.Text = str;
        }

        private void Bt_ce(object sender, RoutedEventArgs e)
        {

        }

        private void Bt_equals(object sender, RoutedEventArgs e)
        {
            if (input.Text.Equals("")) 
            {
                input.Text = "错啦兄弟";
            }
            DataTable dt = new DataTable();
            var result = dt.Compute(str,"");
            input.Text = Convert.ToString(result);
            oldinput.Content = str;
            str = "";
        }

        private void Bt_del(object sender, RoutedEventArgs e)
        {
            if (input.Text.Equals(""))
            {
                input.Text = "";
            }
            else
            {
                string str1 = input.Text;
                str = str1.Substring(0, str1.Length - 1);
                input.Text = str;
            }
            
        }
    }
}
