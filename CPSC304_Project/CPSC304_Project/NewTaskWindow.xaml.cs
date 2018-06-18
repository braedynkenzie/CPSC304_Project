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
    /// Interaction logic for NewTaskWindow.xaml
    /// </summary>
    public partial class NewTaskWindow : Window
    {
        StackPanel parentStackPanel;
        MainWindow2 callerWindow;
        private int listId;
        private int projectId;

        public NewTaskWindow( StackPanel parent, MainWindow2 mainWindow2, int listId, int projectId )
        {
            parentStackPanel = parent;
            callerWindow = mainWindow2;
            this.listId = listId;
            this.projectId = projectId;
            InitializeComponent ();
        }

        private void CreateButton_Click( object sender, RoutedEventArgs e )
        {
            string taskName = TaskNameTextBox.Text;
            string taskDescription = TaskDescriptionTextBox.Text;
            int taskId = DatabaseHandler.generateNextTaskId ();
            Task newTask = new Task ( taskId, taskName, taskDescription, listId, projectId );
            callerWindow.AddNewTaskToList ( newTask, parentStackPanel );
            DatabaseHandler.getInstance ().addNewTask ( newTask );

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
