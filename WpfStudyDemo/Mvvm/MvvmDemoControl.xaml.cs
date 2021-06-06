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

namespace WpfStudyDemo.Mvvm
{
    /// <summary>
    /// MvvmDemoControl.xaml 的交互逻辑
    /// </summary>
    public partial class MvvmDemoControl : UserControl
    {
        private System.Threading.Timer timer;

        public MvvmDemoControl()
        {
            InitializeComponent();
            var model = new DemoViewModel();
            this.DataContext = model;

            this.timer = new System.Threading.Timer((t) =>
            {
                model.CurrentTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            }, null, 0, 1000);
        }
    }
}
