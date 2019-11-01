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
    /// Логика взаимодействия для ReadTicket.xaml
    /// </summary>
    public partial class ReadTicket : Page
    {
        xxEntities context = new xxEntities();

        public ReadTicket()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Surnametxt.Text == "" || Nametxt.Text == "" || Patronymictxt.Text == "" || Addresstxt.Text == "" || Telephonetxt.Text == "")
            {
                MessageBox.Show("Все поля обязательны к заполнению!");
            }


            else
            {
                try
                {
                    Reader newReader = new Reader()
                    {
                        Surname = Surnametxt.Text,
                        name = Nametxt.Text,
                        patronymic = Patronymictxt.Text,
                        address = Addresstxt.Text,
                        telephone = Telephonetxt.Text
                    };
                    context.Reader.Add(newReader);
                    context.SaveChanges();
                    MessageBox.Show("Вы успешно добавили читателя!");
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
            }
        }
            private void Telephonetxt_TextChanged(object sender, TextChangedEventArgs e)
            {
                Telephonetxt.MaxLength = 11;
            }

        private void Telephonetxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;
            Telephonetxt.MaxLength = 11;
        }
    }
    
}

