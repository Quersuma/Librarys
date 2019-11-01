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
using System.Windows.Shapes;

namespace WpfApp20
{
    /// <summary>
    /// Логика взаимодействия для UpdateBook.xaml
    /// </summary>
    public partial class UpdateBook : Window
    {
        int Id;
        xxEntities db = new xxEntities();

        public void Load()
        {
        }

        public UpdateBook(int BooksId)
        {
            InitializeComponent();
            Id = BooksId;

            Books updateBook = (from m in db.Books
                                where m.CodeBook == Id
                                select m).Single();

            TitleTxt.Text = updateBook.Title;
            YearPublishtxt.Text = updateBook.YearPublish;
            CountPagetxt.Text = Convert.ToString(updateBook.CountPage);
            SectionTxt.ItemsSource = db.Section.Select(i => i.Section1).ToList();
            AuthorTxt.ItemsSource = db.Authors.Select(i => i.Surname + "  " + i.Names).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Books updateBook = (from m in db.Books
                                where m.CodeBook == Id
                                select m).Single();

            updateBook.Title = TitleTxt.Text;
            updateBook.YearPublish = YearPublishtxt.Text;
            updateBook.CountPage = Convert.ToInt32(CountPagetxt.Text);
            updateBook.SectionD = db.Section.FirstOrDefault(i => i.Section1 == SectionTxt.SelectedItem.ToString()).Section_Id;
            updateBook.codeAt = db.Authors.FirstOrDefault(i => i.Surname + "  " + i.Names == AuthorTxt.SelectedItem.ToString()).CodeAuthor;

            db.SaveChanges();


            var query = from s in db.Section
                        join b in db.Books on s.Section_Id equals b.SectionD
                        join a in db.Authors on b.codeAt equals a.CodeAuthor
                        select new { b.CodeBook, b.Title, b.YearPublish, b.CountPage, b.status, a.Surname, a.Names, s.Section1 };



            BooksBD.datagrid.ItemsSource = query.ToList();
        }
    }
}
