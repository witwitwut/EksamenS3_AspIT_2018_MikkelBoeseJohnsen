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
using EksamensS3MBJ.Biz;

namespace EksamensS3MBJ.GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBiz MainBiz = new ClassBiz();
        public MainWindow()
        {
            InitializeComponent();
            MainGrid.Children.Clear();
            LogIn logIn = new LogIn(MainGrid, MainBiz);
            MainGrid.Children.Add(logIn);
        }
    }
}
