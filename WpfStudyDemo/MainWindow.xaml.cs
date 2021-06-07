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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfStudyDemo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Layouts.GridDemoControl gridDemo = new Layouts.GridDemoControl();
            this.SetMainControl(gridDemo);
        }

        private void SetMainControl(ContentControl control)
        {
            this.mainContent.Content = control;
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.SpeedRatio = 2.5;
            if (this.menuPanel.Width > 30)
            {
                animation.From = this.menuPanel.Width;
                animation.To = 30;
                this.btnShow.Content = "显示";
            }
            else
            {
                animation.From = 30;
                animation.To = 200;
                this.btnShow.Content = "隐藏";
            }

            this.menuPanel.BeginAnimation(WidthProperty, animation);
        }

        private void btnStack_Click(object sender, RoutedEventArgs e)
        {
            Layouts.StackPanelDemoControl gridDemo = new Layouts.StackPanelDemoControl();
            this.SetMainControl(gridDemo);
        }

        private void btnWrap_Click(object sender, RoutedEventArgs e)
        {
            Layouts.WrapPanelDemoControl gridDemo = new Layouts.WrapPanelDemoControl();
            this.SetMainControl(gridDemo);
        }

        private void btnNative_Click(object sender, RoutedEventArgs e)
        {
            Windows.NativeWindow window = new Windows.NativeWindow();
            window.ShowDialog();
        }

        private void btnNoBorder_Click(object sender, RoutedEventArgs e)
        {
            Windows.NoBorder window = new Windows.NoBorder();
            window.ShowDialog();
        }

        private void btnHandy_Click(object sender, RoutedEventArgs e)
        {
            HandyControls.HCWindow window = new HandyControls.HCWindow();
            window.ShowDialog();
        }

        private void btnMvvm_Click(object sender, RoutedEventArgs e)
        {
            Mvvm.MvvmDemoControl control = new Mvvm.MvvmDemoControl();
            this.SetMainControl(control);
        }

        private void btnCanvas_Click(object sender, RoutedEventArgs e)
        {
            Layouts.CanvasDemoControl control = new Layouts.CanvasDemoControl();
            this.SetMainControl(control);
        }

        private void btnStyle_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
