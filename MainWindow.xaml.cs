

using System;
namespace ascii_translator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string txt = textBox1.Text;
            textBox1.Text = "";
            for (int i = 0; i < txt.Length; i++)
            {
                char[] c = txt.ToString().ToCharArray();
                textBox1.Text += Convert.ToInt32(c[i]).ToString()+" ";
            }
        }
    }
}
