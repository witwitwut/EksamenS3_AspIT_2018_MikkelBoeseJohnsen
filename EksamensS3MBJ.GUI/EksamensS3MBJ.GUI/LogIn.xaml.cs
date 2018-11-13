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
using EksamensS3MBJ.Entities;

namespace EksamensS3MBJ.GUI
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : UserControl
    {
        Grid gridMain;
        ClassBiz biz = new ClassBiz();
        public LogIn(Grid grid, ClassBiz Inbiz)
        {
            InitializeComponent();
            gridMain = grid;
            biz = Inbiz;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User LUser = new User();
            UserStatus userStatus = new UserStatus();
            //bool Checklogin = false;
            try
            {
                labelWrongPW.Visibility = Visibility.Hidden;
                //while (Checklogin == false)
                //{
                    LUser = biz.UseVerifyUser(user.Text, pw.Text);

                    if (LUser.ID != 0)
                    {
                        userStatus = biz.UseGetUserStatus(LUser.StatusId);
                        switch (userStatus.Status)
                        {
                            case "Regular":
                                gridMain.Children.Clear();
                                GrainSupplier gs = new GrainSupplier(gridMain, biz);
                                gridMain.Children.Add(gs);
                                break;
                            case "Administrator":
                                gridMain.Children.Clear();
                                GrainSupplierAdm adm = new GrainSupplierAdm(gridMain);
                                gridMain.Children.Add(adm);
                                break;
                            default:
                                break;
                        }
                        //Checklogin = true;
                    }
                    else
                    {
                        labelWrongPW.Visibility = Visibility.Visible;
                        //Checklogin = true;
                    }
                //}
            }
            catch (Exception exe)
            {
                throw exe;
            }
            


        }
    }
}
