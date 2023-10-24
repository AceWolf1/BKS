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

namespace BKS
{
    /// <summary>
    /// Логика взаимодействия для AutoWindow.xaml
    /// </summary>
    public partial class AutoWindow : Window
    {
        public AutoWindow()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            {
                var userAuth = ClassHelper.EF.Context.Staff.ToList().
                  Where(i => i.Login == FirsName.Text && i.Password == LastName.Password).
                  FirstOrDefault();

                if (userAuth != null)
                {

                    MainWindow MainWindow = new MainWindow();
                    MainWindow.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Пользователя не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            
            RegWindow regWindow = new RegWindow();
            regWindow.Show();
            this.Close();
        }

        private void BtnCloseAutWindow_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButton.YesNo);
            if (MessageBoxResult.Yes == result)
            {
                Application.Current.Shutdown();
            }
            else
            {
                MessageBox.Show("Спасибо , что остались! :)");
            }
        }
    

        private void CollapseBtnAutWindow_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
