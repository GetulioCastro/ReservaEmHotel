using MahApps.Metro.Controls;
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

namespace ReservaEmHotel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void areaLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Login();
            }
        }
        private void Login()
        {
            if (txtUsuario.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Campo vazio, digite seu usuário.", "Campo Vazio", MessageBoxButton.OK, MessageBoxImage.Information);
                txtUsuario.Text = "";
                txtUsuario.Focus();
                return;
            }
            if (pswSenha.Password.ToString().Trim() == "")
            {
                MessageBox.Show("Campo vazio, digite sua senha.", "Campo Vazio", MessageBoxButton.OK, MessageBoxImage.Information);
                pswSenha.Password = "";
                pswSenha.Focus();
                return;
            }

            // código para efetuar login
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login();

        }

        private void LimparCampos()
        {
            txtUsuario.Text = "";
            pswSenha.Password = "";
            txtUsuario.Focus();
        }
    }


}
