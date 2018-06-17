using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CPSC304_Project
{
    class DatabaseHandler
    {
        private static MySqlConnection mySqlConnection;
        private static string connectionString;
        private static DatabaseHandler dbHandlerInstance = null;
        private static string databaseName = null;
        private static bool initialized = false;

        public static DatabaseHandler getInstance()
        {
            if ( databaseName == null )
            {
                throw new Exception ( "Database name is null. Use setDatabase(string dbName) before calling getInstance()." );
            }

            if ( dbHandlerInstance == null )
            {
                try
                {
                    dbHandlerInstance = new DatabaseHandler ();
                    connectionString = String.Format ( "server=localhost;userid=root;password=lolipop26;database={0};", databaseName );
                    mySqlConnection = new MySqlConnection ( connectionString );

                    mySqlConnection.Open ();
                    MySqlCommand cmd = mySqlConnection.CreateCommand ();
                    cmd.CommandText = "SELECT COUNT(*) FROM 'Users'";
                    cmd.ExecuteNonQuery ();
                    mySqlConnection.Close ();
                    initialized = true;

                }
                catch (Exception e )
                {
                    // Create new database
                    connectionString = "server=localhost;userid=root;password=lolipop26;";
                    mySqlConnection = new MySqlConnection ( connectionString );

                    mySqlConnection.Open ();
                    MySqlCommand cmd = mySqlConnection.CreateCommand ();
                    cmd.CommandText = String.Format ( "CREATE DATABASE IF NOT EXISTS `{0}`;", MainWindow.DATABASE_NAME );
                    cmd.ExecuteNonQuery ();
                    mySqlConnection.Close ();

                    connectionString = String.Format ( "server=localhost;userid=root;password=lolipop26;database={0};", databaseName );
                    mySqlConnection = new MySqlConnection ( connectionString );

                    initialized = false;
                }
            }
            return dbHandlerInstance;
        }

        internal string getUsername( int userId )
        {
            // Return the username corresponding to the given userId
            throw new NotImplementedException ();
        }

        internal static void initDatabase()
        {
            // If database has not already been initialized, create a new database with the appropriate tables
            if ( !initialized )
            {
                mySqlConnection.Open ();

                MySqlCommand createUsersTableCmd = mySqlConnection.CreateCommand ();
                createUsersTableCmd.CommandText =
                    "CREATE TABLE IF NOT EXISTS Users (" +
                    "id INT PRIMARY KEY, " +
                    "isManager INT," +
                    "username CHAR(20), " +
                    "password CHAR(20) " +
                    ");";
                createUsersTableCmd.ExecuteNonQuery ();

                MySqlCommand createProjectsTableCmd = mySqlConnection.CreateCommand ();
                createProjectsTableCmd.CommandText =
                    "CREATE TABLE IF NOT EXISTS Projects (" +
                    "id INT PRIMARY KEY, " +
                    "title CHAR(20) " +
                    ");";
                createProjectsTableCmd.ExecuteNonQuery ();

                MySqlCommand createListsTableCmd = mySqlConnection.CreateCommand ();
                createListsTableCmd.CommandText =
                    "CREATE TABLE IF NOT EXISTS Lists (" +
                    "id INT, " +
                    "projectId INT, " +
                    "title CHAR(20), " +
                    "PRIMARY KEY(id, projectId), " +
                    "FOREIGN KEY (projectId) REFERENCES Projects(id) " +
                    ");";
                createListsTableCmd.ExecuteNonQuery ();

                MySqlCommand createTasksTableCmd = mySqlConnection.CreateCommand ();
                createTasksTableCmd.CommandText =
                    "CREATE TABLE IF NOT EXISTS Tasks (" +
                    "id INT, " +
                    "projectId INT, " +
                    "listId INT, " +
                    "taskName CHAR(20), " +
                    "taskDescription CHAR(200)," +
                    "PRIMARY KEY (id, projectId, listId), " +
                    "FOREIGN KEY (projectId) REFERENCES Projects(id), " +
                    "FOREIGN KEY (listId) REFERENCES Lists(id) " +
                    ");";
                createTasksTableCmd.ExecuteNonQuery ();

                MySqlCommand createWorksOnTableCmd = mySqlConnection.CreateCommand ();
                createWorksOnTableCmd.CommandText =
                    "CREATE TABLE IF NOT EXISTS WorksOn (" +
                    "projectId INT, " +
                    "userId INT, " +
                    "PRIMARY KEY (projectId, userId), " +
                    "FOREIGN KEY (projectId) REFERENCES Projects(id), " +
                    "FOREIGN KEY (userId) REFERENCES Users(id) " +
                    ");";
                createWorksOnTableCmd.ExecuteNonQuery ();
                mySqlConnection.Close ();

            }
            initialized = true;

        }

        public static void setDatabase( string dbName )
        {
            databaseName = dbName;
        }

        public List<User> getAllUsers()
        {
            // Return a list of all users, including usernames and passwords
            mySqlConnection.Open ();
            List<User> allUsers = new List<User> ();
            MySqlCommand cmd = mySqlConnection.CreateCommand ();
            cmd.CommandText =
                "SELECT username, password, id, isManager " +
                "FROM Users ";
            MySqlDataReader reader = cmd.ExecuteReader ();
            while ( reader.Read () )
            {
                string username  = reader.GetString ( 0 );
                string password  = reader.GetString ( 1 );
                int    id        = reader.GetInt32  ( 2 );
                int    isManager = reader.GetInt32  ( 3 );
                User user = new User ( username, password, id, (isManager == 1) );
                allUsers.Add ( user );
            }
            mySqlConnection.Close ();
            return allUsers;
        }

        public void addNewUser( string userName, string password, bool isManager )
        {
            List<User> allUsers = getAllUsers ();
            int isManagerInt = isManager ? 1 : 0;
            int newUserId = 0;
            foreach ( User user in allUsers )
            {
                if ( user.id >= newUserId )
                {
                    newUserId = user.id + 1;
                }
            }

            mySqlConnection.Open ();
            MySqlCommand cmd = mySqlConnection.CreateCommand ();
            cmd.CommandText =
                String.Format (
                    "INSERT INTO Users(id,username,password,isManager)" +
                    "VALUES ({0},'{1}','{2}','{3}');",
                    newUserId, userName, password, isManagerInt );
            cmd.ExecuteNonQuery ();
              
            mySqlConnection.Close ();
        }





        public void testDb()
        {
            mySqlConnection.Open ();
            
            string createNewDb =
                "CREATE DATABASE IF NOT EXISTS `HelloWorld`;";

            MySqlCommand cmd1 = mySqlConnection.CreateCommand ();
            cmd1.CommandText = createNewDb;
            cmd1.ExecuteNonQuery ();

            string db = mySqlConnection.Database;

            MySqlCommand cmd2 = mySqlConnection.CreateCommand ();
            cmd2.CommandText =
                "CREATE TABLE IF NOT EXISTS Users (" +
                "id INT PRIMARY KEY," +
                "username CHAR(20)," +
                "password CHAR(20)" +
                ");";
            cmd2.ExecuteNonQuery ();

            MySqlCommand cmd3 = mySqlConnection.CreateCommand ();
            cmd3.CommandText =
                "INSERT INTO Users(id,username,password) " +
                "VALUES (42,'Braedyn','password123');";
            //cmd3.ExecuteNonQuery ();

            MySqlCommand cmd4 = mySqlConnection.CreateCommand ();
            cmd4.CommandText =
                "SELECT id, username " +
                "FROM Users ";
            MySqlDataReader reader = cmd4.ExecuteReader ();
            while ( reader.Read () )
            {
                string idNum = reader.GetString(0);
                Console.WriteLine ( idNum );
            }

            mySqlConnection.Close ();
        }
    }
}
