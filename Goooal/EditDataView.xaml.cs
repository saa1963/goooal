using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Goooal
{
    /// <summary>
    /// Логика взаимодействия для EditDataView.xaml
    /// </summary>
    public partial class EditDataView : Window
    {
        public EditDataView()
        {
            InitializeComponent();
            this.PreviewKeyDown += EditDataView_PreviewKeyDown;
        }

        private void EditDataView_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                e.Handled = true;
                DialogResult = false;
            }
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
