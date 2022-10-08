using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

namespace Market_AromatniyMir
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            CheckData(); 
        }


        private void GuestButton_Click(object sender, RoutedEventArgs e)
        {
            Products okno1 = new Products();
            this.Hide();
            okno1.Show();
        }
        public void CheckData()
        {
            TradeEntities db = new TradeEntities();

            User schet = null;

            schet = db.User.Where(a => a.UserLogin == LoginBox.Text && a.UserPassword == PassBox.Password).FirstOrDefault();

            if (schet == null)
            {
                MessageBox.Show("Такого аккаунта не существует!");
            }
            else
            {
                Products okno3 = new Products();
                this.Hide();
                okno3.Show();
                // Peredacha.peremenaya peremenaya = new Peredacha.peremenaya();
                //MessageBox.Show(peremenaya.Login);
                // Login.login = Avtor_login.Text;
                //((ProfileWindow)Application.Current.ProfileWindow).Profile_login.Text = Avtor_login.Text;
                string login = LoginBox.Text;
                string password = PassBox.Password;
            }
        }

        //public void Role()
        //{
        //    TradeEntities db = new TradeEntities();

        //    User schet1 = null;

        //    schet1 = 1;
        //}
    }
}
