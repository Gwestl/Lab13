using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace WpfApp1 {
    public partial class Window3 : Window {
        public Window3() {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e) {
            DateTime dateTime = DateTime.Now;
            File.AppendAllText(@"D:\C#\WpfApp1\WpfApp1\1Name.txt", "\n" + TextBox1.Text);
            File.AppendAllText(@"D:\C#\WpfApp1\WpfApp1\1Number.txt", "\n" + TextBox2.Text);
            File.AppendAllText(@"D:\C#\WpfApp1\WpfApp1\1BookName.txt", "\n" + TextBox3.Text);
            File.AppendAllText(@"D:\C#\WpfApp1\WpfApp1\1BorrowDate.txt", "\n" + dateTime.ToShortDateString());
            File.AppendAllText(@"D:\C#\WpfApp1\WpfApp1\1ReturnDate.txt", "\n" + dateTime.AddDays(30).ToShortDateString());
            this.Close();
        }
    }
}
