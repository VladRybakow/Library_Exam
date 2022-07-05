using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Library_Exam.DB;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Library_Exam.Windows
{
    /// <summary>
    /// Логика взаимодействия для BooksWindow.xaml
    /// </summary>
    public partial class BooksWindow : Window
    {
        public static LibraryEntities librarydb = new LibraryEntities();
        public static Book book = new Book();
        public BooksWindow()
        {
            InitializeComponent();

            lstbook.ItemsSource = MainWindow.librarydb.Book.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow adm = new AdminWindow();
            adm.Show();
            this.Close();
        }
    }
}
