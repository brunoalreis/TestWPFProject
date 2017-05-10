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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MenusModelView modelView = new MenusModelView
            {
                Name = "MainMVVM",
                PageViewModels = new List<MenusModelView>{
                    new MenusModelView{
                        Name = "Tab 1",
                        PageViewModels = new List<MenusModelView>{
                            new MenusModelView{
                                Name = "Group 1",
                                PageViewModels = new List<MenusModelView>{
                                    new MenusModelView{
                                        Name = "Label 1"
                                    },
                                    new MenusModelView{
                                        Name = "Label 2"
                                    },
                                }
                            },
                            new MenusModelView{
                                Name = "Group 2",
                                PageViewModels = new List<MenusModelView>{
                                    new MenusModelView{
                                        Name = "Label 3"
                                    },
                                    new MenusModelView{
                                        Name = "Label 4"
                                    },
                                }
                            },
                        }
                    },
                    new MenusModelView{
                        Name = "Tab 2",
                        PageViewModels = new List<MenusModelView>{
                            new MenusModelView{
                                Name = "Group 3",
                                PageViewModels = new List<MenusModelView>{
                                    new MenusModelView{
                                        Name = "Label 5"
                                    },
                                }
                            },
                            new MenusModelView{
                                Name = "Group 4",
                                PageViewModels = new List<MenusModelView>{
                                    new MenusModelView{
                                        Name = "Label 6"
                                    },
                                }
                            },
                        }
                    },
                }
            };

            this.DataContext = modelView;
        }
    }
}
