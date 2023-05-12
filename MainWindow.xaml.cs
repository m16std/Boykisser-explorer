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
using System.ComponentModel;

namespace Boykisser_explorer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser.Source = new Uri(txtPath.Text);
            }
            catch
            {

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();
        }

        public BindingList<MainWindow> Items { get; set; } = new BindingList<MainWindow>();

        private void ItemsOnListChanged(object sender, ListChangedEventArgs e)
        {
            txtPath.Text = webBrowser.Source.ToString();
        }

    }

}

