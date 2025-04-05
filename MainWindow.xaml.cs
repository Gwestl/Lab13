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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using WpfApp1;
public class User
{
    private string name;
    private string login;
    private string password;
    public User(string name, string login, string password)
    {
        this.name = name;
        this.login = login;
        this.password = password;
    }
    public string Name
    {
        get
        {
            return this.name;
        }
    }
    public string Login
    {
        get
        {
            return this.login;
        }
    }
    public string Password
    {
        get

        {
            return this.password;
        }
    }
}
public class Model
{
    private List<User> users;
private User loggedUser;
    public Model()
    {
        users = new List< User > (); //Создание списка тестовых пользователей
        users.Add(new User("Name1","a1","a1"));
        users.Add(new User("Name2", "Login2", "password2"));
        users.Add(new User("Name3", "Login3", "password3"));
        users.Add(new User("Name4", "Login4", "password4"));
        loggedUser = null;
    }
    public void Login(string login, string password) //Метод авторизации
    {
        bool hasLogged = false;
        foreach (User user in this.users)
        {
            if (user.Login == login && user.Password == password)
        {

                this.loggedUser = user; //Обновление модели
                hasLogged = true;
                break;
            }
        }
        if (!hasLogged)
        {
            this.loggedUser = null;
        }
    }
    public string Message {
        get {
            if(this.loggedUser != null) {
                Window2 window2 = new Window2 (); window2.Show(); Application.Current.MainWindow.Close();
            }
            return this.loggedUser != null ? $" Nice to see you {this.loggedUser.Name}!" :" Wrong login or password!";
        }
    }
}
public class Presenter
{
    private Model model; //Связь с моделью
    public Presenter(Model model)
    {
        this.model = model;
    }
    public Model Login(string login, string password) //Получение данных от вида
    {
        login = login.Trim(); //Обработка полученной информации
        password = password.Trim();
        this.model.Login(login, password); //Обновление модели
        return this.model; //Передача обновлённой модели
    }
}
namespace WpfApp1
//namespace Window1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Model model;
        private Presenter presenter;
        public MainWindow()
        {
            InitializeComponent();
            model = new Model();
            presenter = new Presenter(model);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            this.model = this.presenter.Login(LoginTextBox.Text, PassBox.Password);
            Update();
        }
        private void Update()
        {
            MessageBlock.Text = this.model.Message;
        }

    }
}
