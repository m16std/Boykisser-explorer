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
using WindowsInput;
using WindowsInput.Native;

namespace Boykisser_explorer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser.Source = new Uri(txtPath.Text);
            }
            catch
            {

            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();
        }

        public BindingList<MainWindow> Items { get; set; } = new BindingList<MainWindow>();

        private void ItemsOnListChanged(object sender, ListChangedEventArgs e)
        {
            txtPath.Text = webBrowser.Source.ToString();
        }
        private void wbSample_Navigating(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            txtPath.Text = e.Uri.OriginalString;
        }

        InputSimulator sim = new InputSimulator();

        public void BtnCopy(object sender, EventArgs e)
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.UP);
            sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_C);
        }
        public void BtnCut(object sender, EventArgs e)
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.UP);
            sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_X);
        }
        public void BtnPaste(object sender, EventArgs e)
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.UP);
            sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
        }
        public void BtnDelete(object sender, EventArgs e)
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.UP);
            sim.Keyboard.KeyPress(VirtualKeyCode.DELETE);
        }
        public void BtnUndo_Click(object sender, EventArgs e)
        {
            sim.Keyboard.KeyPress(VirtualKeyCode.UP);
            sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_Z);
        }
        
    }

}

