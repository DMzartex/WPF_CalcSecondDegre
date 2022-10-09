using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ACT3_EX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            textBox1.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            btnCalculer.MouseEnter += new MouseEventHandler(SurvolBtn);
            btnCalculer.MouseLeave += new MouseEventHandler(AfterSurvolBtn);
        }
        private bool EstEntier(string texteUser)
        {

            return int.TryParse(texteUser, out int number);
        }

        private void VerifTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "," && !EstEntier(e.Text) && e.Text != "-")
            {
               e.Handled = true;
            }
            else
            {
               if(e.Text == "," || e.Text == "-")
                {
                    if (((TextBox)sender).Text.IndexOf(e.Text) > -1)
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }     
            }
       
            
        }

        private void SurvolBtn(object sender, MouseEventArgs e)
        {
            btnV.Visibility = Visibility.Visible;
            btnV.Background = Brushes.Red;
        }

        private void AfterSurvolBtn(object sender, MouseEventArgs e)
        {
            btnV.Visibility = Visibility.Hidden; 
            btnV.Background = Brushes.Transparent;
        }

        private void ClickCalc(object sender, RoutedEventArgs e)
        {
            MethodesDuProjet mesOutils = new MethodesDuProjet();
            string result;
            int textbox1 = Convert.ToInt32(textBox1.Text);
            int textbox2 = Convert.ToInt32(textBox2.Text);
            int textbox3 = Convert.ToInt32(textBox3.Text);
            mesOutils.ResoudreTrinome(textbox1, textbox2, textbox3, out result);

            PageResultat secondPage = new PageResultat();
            secondPage.textBlockResult.Text = secondPage.textBlockResult.Text + " " + result;
            this.Visibility = Visibility.Hidden;
            secondPage.Show();


        }
    }
}
