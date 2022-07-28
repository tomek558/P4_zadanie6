using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;

namespace zadanie6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var path = Environment.CurrentDirectory + @"\ModifiedDictionary.xaml";
            var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            var content = XamlReader.Load(stream);
            var dictionary = (ResourceDictionary) content;
            Resources.MergedDictionaries.Add(dictionary);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            var path = Environment.CurrentDirectory + @"\DefaultDictionary.xaml";
            var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            var content = XamlReader.Load(stream);
            var dictionary = (ResourceDictionary)content;
            Resources.MergedDictionaries.Add(dictionary);
        }
    }
}
