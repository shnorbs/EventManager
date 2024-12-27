using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Runtime.Remoting.Messaging;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }


        public int LogIn(string email, string pass)
        {
            string query = "select count(*) from Users u where u.Email = '" + email + "' AND u.Password = '" + pass + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int CheckUniqueEmail(string email)
        {
            string query = "select count(*) from Users where Email = '" + email + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int AddOrganzierWithLastName(string Fname, string Lname, string Type, string Email, string Pass, float number, string Spec)
        {
            string query = "INSERT INTO Users (First_Name, Last_Name, UserType, Email, Password, Phone_Number, Banned, Specialization) VALUES " +
                "('" + Fname + "', '" + Lname + "', '" + Type + "', '" + Email + "', '" + Pass + "', " + number + ", 0, '" + Spec + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int AddOrganzier(string Fname, string Type, string Email, string Pass, float number, string Spec)
        {
            string query = "INSERT INTO Users (First_Name, Last_Name, UserType, Email, Password, Phone_Number, Banned, Specialization) VALUES " +
                "('" + Fname + "', NULL, '" + Type + "', '" + Email + "', '" + Pass + "', " + number + ", 0, '" + Spec + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int AddUserWithLastName(string Fname, string Lname, string Type, string Email, string Pass, float number)
        {
            string query = "INSERT INTO Users (First_Name, Last_Name, UserType, Email, Password, Phone_Number, Banned, Specialization) VALUES " +
                "('" + Fname + "', '" + Lname + "', '" + Type + "', '" + Email + "', '" + Pass + "', " + number + ", 0, NULL);";
            return dbMan.ExecuteNonQuery(query);
        }

        public int AddUser(string Fname, string Type, string Email, string Pass, float number)
        {
            string query = "INSERT INTO Users (First_Name, Last_Name, UserType, Email, Password, Phone_Number, Banned, Specialization) VALUES " +
                "('" + Fname + "', NULL, '" + Type + "', '" + Email + "', '" + Pass + "', " + number + ", 0, NULL);";
            return dbMan.ExecuteNonQuery(query);
        }

        public int getUserID(string email, string pass)
        {
            string query = "select UserID from Users u where u.Email = '" + email + "' AND u.Password = '" + pass + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public string getUserType(string email, string pass)
        {
            string query = "select UserType from Users u where u.Email = '" + email + "' AND u.Password = '" + pass + "';";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int FindCountPrivateToday(int uID, string date)
        {
            string query = "select count(*) from Users u, EventT E, Invites I where u.UserID = I.UserID AND E.EventID = I.EventID AND E.Privacy_Status = 1 AND u.UserID = " + uID + " AND i.RSVP_Status = 1 AND E.Edate = '" + date + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int FindCountPublicToday(string date)
        {
            string query = "select count(E.EventID) from EventT E where E.Edate = '" + date + "' AND E.Privacy_Status = 0;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable FindPublicEventsToday(string date)
        {
            string query = "select E.EventName AS [Event Name], E.Start_Time AS [Starts At], E.End_Time AS [Ends At], V.Venue_Name AS [Venue Name]  from EventT E, Venue V where E.Location = V.Venue_ID AND E.Edate = '" + date + "' AND E.Privacy_Status = 0;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable FindPrivateEventsToday(int uID, string date)
        {
            string query = "select E.EventName AS [Event Name], E.Start_Time AS [Starts At], E.End_Time AS [Ends At], V.Venue_Name AS [Venue Name] from Users u, EventT E, Invites I, Venue V where u.UserID = I.UserID AND E.EventID = I.EventID AND E.Location = V.Venue_ID AND E.Privacy_Status = 1 AND u.UserID = " + uID + " AND i.RSVP_Status = 1 AND E.Edate = '" + date + "';";
            return dbMan.ExecuteReader(query);
        }

        public int GetEventID(string name, string startTime, string date)
        {
            string query = "select E.EventID from EventT E where E.EventName = '" + name + "' AND E.Start_Time = '" + startTime + "' AND E.Edate = '" + date + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public string GetEventDescription(int EventID)
        {
            string query = "select Descriptions from EventT where EventID = " + EventID + ";";
            return (string)dbMan.ExecuteScalar(query);
        }


        public DataTable LoadReports ()
        {
            string query = "SELECT R.Handled, E.EventName, R.Report_Description, R.Admin_Reply " +
                           "FROM Report AS R " +
                           "JOIN EventT AS E ON R.EventID = E.EventID";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ShowReports (string filter) 
        {
            string query = "SELECT R.Handled, E.EventName, R.Report_Description, R.Admin_Reply " +
                           "FROM Report AS R " +
                           "JOIN EventT AS E ON R.EventID = E.EventID"; // Default query for "All"

            if (filter == "Handled")
            {
                query += " WHERE R.Handled = 1";
            }
            else if (filter == "Unhandled")
            {
                query += " WHERE R.Handled = 0";
            }

            return dbMan.ExecuteReader(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
