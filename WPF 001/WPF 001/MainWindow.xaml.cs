using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WPF_001
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid = new Grid();
            this.Content = grid;
            Button btn = new Button();
            btn.FontSize = 26;

            WrapPanel wrapPanel = new WrapPanel();
            TextBlock txt = new TextBlock();
            txt.Text = "Multi";
            txt.Foreground = Brushes.Blue;
            TextBlock txt2 = new TextBlock();
            txt2.Text = "Color";
            txt2.Foreground = Brushes.Red;
            TextBlock txt3 = new TextBlock();
            txt3.Text = "Button";
            txt3.Foreground = Brushes.White;
            wrapPanel.Children.Add(txt);
            wrapPanel.Children.Add(txt2);
            wrapPanel.Children.Add(txt3);

            btn.Content = wrapPanel;
            grid.Children.Add(btn);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
