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

namespace Chapter_0022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TaskRecord Record { get; set; } = new TaskRecord();
        
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this.Record;
        }

        private void ShowValueButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.Record.Title);
        }

        private void IncrementPriorityButton_Click(object sender, RoutedEventArgs e)
        {
            this.Record.Priority += 1;
        }
        private void DecrementPriorityButton_Click(object sender, RoutedEventArgs e)
        {
            this.Record.Priority -= 1;
        }
    }
}
