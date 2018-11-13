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
    /// Interaction logic for GrainSupplier.xaml
    /// </summary>
    public partial class GrainSupplier : UserControl
    {
        Grid gridMain;
        ClassBiz cb;
        public GrainSupplier(Grid grid, ClassBiz inbiz)
        {
            InitializeComponent();
            gridMain = grid;
            cb = inbiz;
            cb.UseGetAllSuppliers();
            gbxGrainSupplier.DataContext = cb;
        }
    }
}
