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
using System.Windows.Shapes;

namespace Library_Exam.Windows
{
    public partial class ReadersWindow : Window
    {
        public static LibraryEntities librarydb = new LibraryEntities();
        public static ReaderCard rf = new ReaderCard();

        public ReadersWindow()
        {
            InitializeComponent();

            lstread.ItemsSource = MainWindow.librarydb.ReaderCard.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow adm = new AdminWindow();
            adm.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ReaderCard reader = new ReaderCard();

            if ((surtex.Text.Trim() != null) || (nametex.Text.Trim() != null) || (pattex.Text.Trim() != null) || (addrestex.Text.Trim() != null) || (phonetex.Text.Trim() != null))
            {
                reader.Id = 2;
                reader.Surname = surtex.Text.Trim();
                reader.FirstName = nametex.Text.Trim();
                reader.Patronymic = pattex.Text.Trim();
                reader.Address = addrestex.Text.Trim();
                reader.Phone = phonetex.Text.Trim();

                librarydb.ReaderCard.Add(reader);
                librarydb.SaveChanges();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var zxc = lstread.SelectedItem as ReaderCard;

            zxc.FirstName = nametex.Text.ToString();
            zxc.Surname = surtex.Text.ToString();
            zxc.Patronymic = pattex.Text.ToString();
            zxc.Address = addrestex.Text.ToString();
            zxc.Phone = phonetex.Text.ToString();

            librarydb.SaveChanges();
            MessageBox.Show("Данные о читателе редактированы");
        }

        private void lstread_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var zxc = lstread.SelectedItem as ReaderCard;

            nametex.Text = zxc.FirstName.ToString();
            surtex.Text = zxc.Surname.ToString();
            pattex.Text = zxc.Patronymic.ToString();
            addrestex.Text = zxc.Address.ToString();
            phonetex.Text = zxc.Phone.ToString();

        }
    }
}
