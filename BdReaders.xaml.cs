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
    /// Логика взаимодействия для BdReaders.xaml
    /// </summary>
    public partial class BdReaders : Page
    {
        xxEntities db = new xxEntities();
        public static DataGrid datagrid;
        public BdReaders()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
           
            myDataGrid2.ItemsSource = db.Reader.ToList();
            datagrid = myDataGrid2;
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (myDataGrid2.SelectedItem as dynamic).NumberTicket;
           var  query = from g in db.Getting
                        join r in db.Reader on g.NumberReader equals r.NumberTicket
                       where Id==g.NumberReader
                        select new {g.codeBooks };
           
            MessageBox.Show( " Количество взятых книг: " + Convert.ToString(query.Count())  );

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
         //   int Id = (myDataGrid2.SelectedItem as dynamic).NumberTicket;
          //  var deleteMember = db.Reader.Where(m => m.NumberTicket == Id).Single();

          //  db.Reader.Remove(deleteMember);
           // db.SaveChanges();
           // Load();
        }

       
    }
}
