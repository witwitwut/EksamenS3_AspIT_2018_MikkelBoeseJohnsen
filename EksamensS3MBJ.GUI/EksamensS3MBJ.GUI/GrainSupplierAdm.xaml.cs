﻿using System;
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

namespace EksamensS3MBJ.GUI
{
    /// <summary>
    /// Interaction logic for GrainSupplierAdm.xaml
    /// </summary>
    public partial class GrainSupplierAdm : UserControl
    {
        Grid gridMain;
        public GrainSupplierAdm(Grid grid)
        {
            InitializeComponent();
            gridMain = grid;
        }
    }
}
