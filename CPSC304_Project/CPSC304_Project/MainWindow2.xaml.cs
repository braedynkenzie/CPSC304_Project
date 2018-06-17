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
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        private List<Project> projects = new List<Project> ();

        public MainWindow2( string username )
        {
            InitializeComponent ();
            CurrentUserLabel.Content = username;
        }

        private void CloseButton_Click( object sender, RoutedEventArgs e )
        {
            this.Close ();
        }

        private void LogoutButton_Click( object sender, RoutedEventArgs e )
        {
            var result = MessageBox.Show ("This will bring you back to the login window. \nProceed?", "Attention", MessageBoxButton.YesNo);
            if ( result == MessageBoxResult.Yes )
            {
                MainWindow loginWindow = new MainWindow ();
                loginWindow.Show ();
                this.Close ();
            }
            else if ( result == MessageBoxResult.No )
            {
                // Do nothing
            }
        }

        private void ProjectListComboBox_SelectionChanged( object sender, SelectionChangedEventArgs e )
        {
            ComboBoxItem selectedItem = ProjectListComboBox.SelectedItem as ComboBoxItem;
            string projectName = selectedItem.Content as string;
            RefreshProjectUI ( projectName );
        }

        private void RefreshProjectUI( string projectName )
        {
            // <Button Name="AddNewListButton" Content="+" FontSize="24" Width="36" Height="36" VerticalAlignment="Top" Margin="10,10,0,0" Click="AddNewListButton_Click"/>

            MainStackPanel.Children.Clear ();
            Button newListButton = new Button ();
            newListButton.Content = "+";
            newListButton.FontSize = 24;
            newListButton.Height = 36;
            newListButton.Width = 36;
            newListButton.VerticalAlignment = VerticalAlignment.Top;
            newListButton.Margin = new Thickness ( 16, 10, 0, 0 );
            newListButton.Click += AddNewListButton_Click;
            MainStackPanel.Children.Add ( newListButton );
        }

        private void ShowProjectMembersButton_Click( object sender, RoutedEventArgs e )
        {
            // TODO
            DatabaseHandler.setDatabase ( "HelloWorld" );
            DatabaseHandler dbHandler = DatabaseHandler.getInstance ();
            dbHandler.testDb ();
        }

        public void AddNewList( string listName, string listPriority )
        {
            MainStackPanel.Children.Add ( new Separator () { Width = 20, Visibility = Visibility.Hidden } );

            StackPanel newStackPanel = new StackPanel ();
            newStackPanel.Width = 120;
            newStackPanel.Margin = new Thickness ( 0, 10, 0, 10 );
            newStackPanel.Background = new SolidColorBrush ( Colors.LightGray );

            Label listHeaderLabel = new Label ();
            listHeaderLabel.Content = listName;
            newStackPanel.Children.Add ( listHeaderLabel );

            ComboBox priorityComboBox = new ComboBox ();
            ComboBoxItem lowPriority = new ComboBoxItem ();
            lowPriority.Content = "Low";
            ComboBoxItem mediumPriority = new ComboBoxItem ();
            mediumPriority.Content = "Medium";
            ComboBoxItem highPriority = new ComboBoxItem ();
            highPriority.Content = "High";
            priorityComboBox.Items.Add ( lowPriority );
            priorityComboBox.Items.Add ( mediumPriority );
            priorityComboBox.Items.Add ( highPriority );
            switch ( listPriority )
            {
                case "Low":
                    priorityComboBox.SelectedIndex = 0;
                    break;
                case "Medium":
                    priorityComboBox.SelectedIndex = 1;
                    break;
                case "High":
                    priorityComboBox.SelectedIndex = 2;
                    break;
            }
            newStackPanel.Children.Add ( priorityComboBox );
            
            newStackPanel.Children.Add ( new Separator () { Visibility = Visibility.Hidden } );

            Button addTaskButton = new Button ();
            addTaskButton.Click += AddTaskButton_Click;
            addTaskButton.Content = "+";
            addTaskButton.Width = 20;
            addTaskButton.Height = 20;
            addTaskButton.HorizontalAlignment = HorizontalAlignment.Left;
            addTaskButton.Margin = new Thickness ( 10, 0, 0, 0 );
            addTaskButton.Tag = newStackPanel;
            newStackPanel.Children.Add ( addTaskButton );

            MainStackPanel.Children.Add ( newStackPanel );

            Button addNewButton = null;
            foreach ( var child in MainStackPanel.Children )
            {
                if ( child is Button )
                {
                    addNewButton = child as Button;
                }
            }
            MainStackPanel.Children.Remove ( addNewButton );
            MainStackPanel.Children.Add ( addNewButton );
        }

        private void AddTaskButton_Click( object sender, RoutedEventArgs e )
        {
            Button addTaskButton = sender as Button;
            StackPanel parentStackPanel = addTaskButton.Tag as StackPanel;

            NewTaskWindow newTaskWindow = new NewTaskWindow ( parentStackPanel, this );
            this.IsEnabled = false;
            newTaskWindow.Show ();
        }

        internal void AddNewTaskToList( Task newTask, StackPanel parentStackPanel )
        {
            StackPanel newTaskStackPanel = new StackPanel ();

            Label taskNameLabel = new Label ();
            taskNameLabel.Content = newTask.GetName ();
            newTaskStackPanel.Children.Add ( taskNameLabel );
            Label taskDescriptionLabel = new Label ();
            taskDescriptionLabel.Content = newTask.GetDescription ();
            newTaskStackPanel.Children.Add ( taskDescriptionLabel );

            parentStackPanel.Children.Add ( new Separator () );
            parentStackPanel.Children.Add ( new Separator () { Visibility = Visibility.Hidden } );
            parentStackPanel.Children.Add ( newTaskStackPanel );
            parentStackPanel.Children.Add ( new Separator () );

            Button addNewTaskButton = null;
            foreach ( UIElement child in parentStackPanel.Children )
            {
                if ( child is Button )
                {
                    addNewTaskButton = child as Button;
                }
            }
            parentStackPanel.Children.Remove ( addNewTaskButton );
            parentStackPanel.Children.Add ( addNewTaskButton );
        }

        private void DragRectangle_MouseDown( object sender, MouseButtonEventArgs e )
        {
            this.DragMove ();
        }

        private void AddNewListButton_Click( object sender, RoutedEventArgs e )
        {
            NewListWindow newListWindow = new NewListWindow ( this );
            this.IsEnabled = false;
            newListWindow.Show ();

            //TODO
            //string listName = "New List";
            //AddNewList ( listName );
        }
    }
}
