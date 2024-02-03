using EF_CORE_FluentApi_Homework3.Contexts;
using EF_CORE_FluentApi_Homework3.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EF_CORE_FluentApi_Homework3
{

    public partial class MainWindow : Window
    {
        public LibraryDBContext context = new LibraryDBContext();
        public MainWindow()
        {
            InitializeComponent();



        }


        private void GetAll(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (authorRadioButton.IsChecked == true)
                {
                    var a = context.Authors.ToList();
                    dataGrid.ItemsSource = a;

                }
                else if (bookRadioButton.IsChecked == true)
                {
                    dataGrid.ItemsSource = context.Books.ToList();
                }
                else if (categoryRadioButton.IsChecked == true)
                {
                    dataGrid.ItemsSource = context.Categories.ToList();
                }
                else if (departmentRadioButton.IsChecked == true)
                {
                    dataGrid.ItemsSource = context.Departments.ToList();
                }
                else if (facultyRadioButton.IsChecked == true)
                {
                    dataGrid.ItemsSource = context.Faculties.ToList();
                }
                else if (groupRadioButton.IsChecked == true)
                {
                    dataGrid.ItemsSource = context.Groups.ToList();
                }
                else if (libRadioButton.IsChecked == true)
                {
                    dataGrid.ItemsSource = context.Libs.ToList();
                }
                else if (presRadioButton.IsChecked == true)
                {
                    dataGrid.ItemsSource = context.Press.ToList();
                }
                else if (scardRadioButton.IsChecked == true)
                {
                    dataGrid.ItemsSource = context.SCards.ToList();
                }
                else if (studentRadioButton.IsChecked == true)
                {
                    dataGrid.ItemsSource = context.Students.ToList();
                }
                else if (tcardRadioButton.IsChecked == true)
                {
                    dataGrid.ItemsSource = context.TCards.ToList();
                }
                else if (teacherRadioButton.IsChecked == true)
                {
                    dataGrid.ItemsSource = context.Teachers.ToList();
                }
                else if (themeRadioButton.IsChecked == true)
                {
                    dataGrid.ItemsSource = context.Themes.ToList();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message,"ERROR!!!",MessageBoxButton.YesNo,MessageBoxImage.Error);
            }

        }


        private void UpdateDatabase(object sender, MouseButtonEventArgs e)
        {
            context.SaveChangesAsync();
            
        }
    }
}