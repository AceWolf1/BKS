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
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
        }

        private void BtnCloseRegWindow_Click(object sender, RoutedEventArgs e)
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

        private void CollapseBtnRegWindow_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Btn_RegRegWindow_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstName.Text))
            {
                MessageBox.Show("Поле Имя не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(LastName.Text))
            {
                MessageBox.Show("Поле Фамилия не заполнено");
                return;
            }

            if (string.IsNullOrWhiteSpace(Phone.Text))
            {
                MessageBox.Show("Поле Телефон не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(Email.Text))
            {
                MessageBox.Show("Поле Email не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(Login.Text))
            {
                MessageBox.Show("Поле Логин не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Поле Пароль не заполнено");
                return;
            }

            DB.Staff addStaff = new DB.Staff();

            addStaff.LastName = LastName.Text;
            addStaff.FirstName = FirstName.Text;
            addStaff.Patronumic = Patronymic.Text;
            addStaff.Phone = Phone.Text;
            addStaff.Email = Email.Text;
            addStaff.Login = Login.Text;
            addStaff.Password = Password.Text;

            if (Patronymic.Text != string.Empty)
            {
                addStaff.Patronumic = Patronymic.Text;
            }

            ClassHelper.EF.Context.Staff.Add(addStaff);

            ClassHelper.EF.Context.SaveChanges();

            MessageBox.Show($"Пользователь {addStaff.LastName} {addStaff.FirstName} успешно добавлен");

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
            
        }

        private void FirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void LastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Patronymic_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Phone_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
