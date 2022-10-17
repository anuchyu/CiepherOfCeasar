using System;
using System.Text;
using System.Windows;

namespace CiepherOfCeasar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static string al = "абвгдеёжзийклмнопрстуфхцчшщъьэюя 1234567890";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textOut.Text = ori(textIn.Text);
        }
        public string ori(string inp)
        { 
            StringBuilder code = new StringBuilder();
            string s = textIn.Text;
            string sd = Result.Text;
            int step = Convert.ToInt32(sd);
            for (int i=0; i < al.Length; i++)
            {
                for (int j=0; j < al.Length; j++)
                {
                    if (s[i] == al[j])
                    {
                        code.Append(al[(j + step) % al.Length]);
                    }
                }
            }
            return code.ToString();


        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textIn.Text = org(textOut.Text);
        }
        public string org(string inp)
        {
            StringBuilder code = new StringBuilder();
            string s = textOut.Text;
            string sd = Result.Text;
            int step = Convert.ToInt32(sd);
            for (int i = 0; i < al.Length; i++)
            {
                for (int j = 0; j < al.Length; j++)
                {
                    if (s[i] == al[j])
                    {
                        code.Append(al[(j - step + al.Length) % al.Length]);
                    }
                }
            }
            return code.ToString();


        }

    }
}
