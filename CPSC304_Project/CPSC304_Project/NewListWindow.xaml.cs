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

namespace CPSC304_Project
{
    /// <summary>
    /// Interaction logic for NewListWindow.xaml
    /// </summary>
    public partial class NewListWindow : Window
    {
        private MainWindow2 callerWindow;

        public NewListWindow( MainWindow2 caller)
        {
            callerWindow = caller;
            InitializeComponent();
        }

        private void CreateButton_Click( object sender, RoutedEventArgs e )
        {
            string listTitle = ListTitleTextBox.Text;
            string listPriority = ( PriorityComboBox.SelectedItem as ComboBoxItem ).Content as string;
            callerWindow.AddNewList ( listTitle, listPriority );

            this.Close ();
            callerWindow.IsEnabled = true;
        }

        private void CancelButton_Click( object sender, RoutedEventArgs e )
        {
            this.Close ();
            callerWindow.IsEnabled = true;
        }
    }
}
