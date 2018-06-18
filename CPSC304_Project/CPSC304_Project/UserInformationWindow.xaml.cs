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
    /// Interaction logic for UserInformationWindow.xaml
    /// </summary>
    public partial class UserInformationWindow : Window
    {
        private User activeUser;
        private Window callerWindow;

        public UserInformationWindow( User user, Window caller )
        {
            activeUser = user;
            callerWindow = caller;
            InitializeComponent ();
            UsernameTextBlock.Text = activeUser.username;
        }

        private void CloseButton_Click( object sender, RoutedEventArgs e )
        {
            callerWindow.IsEnabled = true;
            this.Close ();
        }
    }
}
