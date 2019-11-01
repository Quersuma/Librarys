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
    /// Логика взаимодействия для GetBooks.xaml
    /// </summary>
    public partial class GetBooks : Page
    {
        xxEntities db = new xxEntities();
        public GetBooks()
        {
            InitializeComponent();
            reader.ItemsSource = db.Reader.Select(i => i.Surname + "  " + i.name).ToList();
            Load();

        }

        public void Load()
        {
            var query = from b in db.Books
                        join a in db.Authors on b.codeAt equals a.CodeAuthor               
                        select new { b.Title, a.Surname, a.Names };

            booksCombo.ItemsSource = query.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
          //  var code = db.Books
                   //   .Select(c => c.CodeBook).FirstOrDefault().ToString();

          //  var Numb = db.Reader
                 //    .Select(c => c.NumberTicket).FirstOrDefault().ToString();
          //  bool contains2 = Numb.Contains(CodeReader.Text);
           // bool contains = code.Contains(CodeReader.Text);


           // if (contains == false & contains2==false)
           // {
             //   MessageBox.Show("Пожалуйста, проверьте введённые данные на корректность");
           // }
          // else
          //  {
                Getting newGet = new Getting()
                {
                    DateGetting = Convert.ToDateTime(Gettxt.Text),
                    DateReturn = Convert.ToDateTime(Returntxt.Text),

                  

                    NumberReader = db.Reader.FirstOrDefault(i => i.Surname + "  " + i.name == reader.SelectedItem.ToString()).NumberTicket,
                };
                db.Getting.Add(newGet);
                db.SaveChanges();
            MessageBox.Show("Вы успешно выдали книгу");
           // }
        }
    }
}
