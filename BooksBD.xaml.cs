using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для BooksBD.xaml
    /// </summary>
    public partial class BooksBD : Page
    {
        xxEntities db = new xxEntities();
        public static DataGrid datagrid;
       
        public BooksBD()
        {
            InitializeComponent();
            Load();
          
        }
      
       
        public void Load()
        {
            try
            {
                var query = from s in db.Section
                            join b in db.Books on s.Section_Id equals b.SectionD
                            join a in db.Authors on b.codeAt equals a.CodeAuthor
                            select new { b.CodeBook, b.Title, b.YearPublish, b.CountPage, b.status, a.Surname, a.Names, s.Section1 };


                myDataGrid.ItemsSource = query.ToList();
                datagrid = myDataGrid;
            }
            catch { }
            
           
        }
   
        private void MyDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
             int Id = (myDataGrid.SelectedItem as dynamic).CodeBook;
        
               
                UpdateBook UpWs = new UpdateBook(Id);

            UpWs.ShowDialog();
       
          
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid.SelectedItem as dynamic).CodeBook;
            var deleteMember = db.Books.Where(m => m.CodeBook == Id).Single();
            db.Books.Remove(deleteMember);
            db.SaveChanges();
            Load();
        }

        private void Filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            
           
        }
    }
}
