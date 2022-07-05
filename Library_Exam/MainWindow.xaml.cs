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
using Library_Exam.DB;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Library_Exam.Windows;

namespace Library_Exam
{
    public partial class MainWindow : Window
    {
        public static LibraryEntities librarydb = new LibraryEntities();
        public static Employee emp = new Employee();
        public AdminWindow admwin = new AdminWindow();
        public static Employee employee;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in AdminWindow.librarydb.Employee)
            {
                if (user.Login == logintex.Text.Trim() && user.Password == passtex.Text.Trim())
                {
                    AdminWindow zxc = new AdminWindow();
                    zxc.Show();
                    this.Close();
                    MessageBox.Show("Добро пожаловать!");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
