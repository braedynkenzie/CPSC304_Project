﻿using System;
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
    /// Interaction logic for AddUserToProjectWindow.xaml
    /// </summary>
    public partial class AddUserToProjectWindow : Window
    {
        Window callerWindow;
        List<Project> allProjects;

        public AddUserToProjectWindow( Window caller)
        {
            callerWindow = caller;
            InitializeComponent ();
            allProjects = DatabaseHandler.getInstance ().getAllProjects ();
            foreach ( Project project in allProjects )
            {
                Label projectLabel = new Label ()
                {
                    Content = project.getName(),
                    FontSize = 16,
                    FontWeight = FontWeights.Bold,
                };
                MainStackPanel.Children.Add ( projectLabel );
                Button addUserToProjectButton = new Button ()
                {
                    Content = "Add User",
                    FontSize = 16,
                    Background = new SolidColorBrush(Colors.Transparent),
                    Tag = project,
                };
                addUserToProjectButton.Click += AddUserToProjectButton_Click;
                
            }
        }

        private void AddUserToProjectButton_Click( object sender, RoutedEventArgs e )
        {
            throw new NotImplementedException ();
        }

        private void CloseButton_Click( object sender, RoutedEventArgs e )
        {
            callerWindow.IsEnabled = true;
            this.Close ();
        }
    }
}
