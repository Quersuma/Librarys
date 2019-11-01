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

namespace WpfApp20
{
    /// <summary>
    /// Логика взаимодействия для insert.xaml
    /// </summary>
    /// 
    public partial class insert : Page
    {
        xxEntities db = new xxEntities();


       

        public insert()
        {
            InitializeComponent();
            sec.ItemsSource = db.Section.Select(i => i.Section1).ToList();
            author.ItemsSource = db.Authors.Select(i => i.Surname + "  " + i.Names).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Year.Text == "" || Page.Text == "" || names.Text == "" || author.SelectedIndex < 0 || sec.SelectedIndex < 0)
            {
                MessageBox.Show("Все поля обязательны к заполнению!");
            }
            else
            {
                Books newBook = new Books()
                {
                    Title = names.Text,
                    YearPublish = Convert.ToString(Year.Text),
                    CountPage = Convert.ToInt32(Page.Text),
                    codeAt = db.Authors.FirstOrDefault(i => i.Surname + "  " + i.Names == author.SelectedItem.ToString()).CodeAuthor,
                    SectionD = db.Section.FirstOrDefault(i => i.Section1 == sec.SelectedItem.ToString()).Section_Id,
                    status =false
                };
                db.Books.Add(newBook);
                db.SaveChanges();

                MessageBox.Show("Вы успешно добавили книгу!");
            }
        }

           

        

        private void Page_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;
            Page.MaxLength = 5;
        }

        private void Names_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 S = new Window1();
            S.Show();
        }
    }
}
