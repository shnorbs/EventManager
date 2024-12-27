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
        public int AddAdmin(int UserID)
        {
            string query = "UPDATE Users SET UserType = 'Admin' WHERE UserID = " + UserID + "AND UserType!='Organizer' ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable Total_Events_by_Organizer()
        {
            string query = "SELECT Organizer,U.First_Name,U.Last_Name, COUNT(EventID) AS TotalEvents FROM EventT E,Users U WHERE Organizer=U.UserID " +
                "GROUP BY Organizer,U.First_Name,U.Last_Name ORDER BY TotalEvents DESC;"; 

            return dbMan.ExecuteReader(query);
        }
        public DataTable Most_Popular_Venues()
        {
            string query = "SELECT E.Location,V.Venue_Name, COUNT(EventID) AS EventCount   FROM EventT E ,Venue V  where V.Venue_ID=E.Location  GROUP BY E.Location,V.Venue_Name ORDER BY EventCount DESC";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Number_of_events_byMonth()
        {
            string query = "SELECT \n\t\tMONTH(E.Edate) AS Month, \n\t\tCOUNT(A.UserID) AS AttendanceCount\n\tFROM \n\t\tEventT E\n\tJOIN \n\t\tAttending A ON A.EventID = E.EventID\n\tGROUP BY \n\t\tMONTH(E.Edate)\n\tORDER BY \n\t\tMonth;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ShowAllAdmins()
        {
            string query = "Select * From users where UserType ='Admin';";
            return dbMan.ExecuteReader(query);
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
            string query = "SELECT R.Report_ID, R.Handled, E.EventName, R.Report_Description, R.Admin_Reply " +
                           "FROM Report AS R " +
                           "JOIN EventT AS E ON R.EventID = E.EventID";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ShowReports (string filter) 
        {
            string query = "SELECT R.Report_ID, R.Handled, E.EventName, R.Report_Description, R.Admin_Reply " +
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

        public string getReportedEventName(int reportID)
        {
            string query = "SELECT E.EventName " +
                           "FROM Report AS R " +
                           "JOIN EventT AS E ON R.EventID = E.EventID " +
                           "WHERE R.Report_ID = " + reportID + ";";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public string getReportDescription(int reportID)
        {
            string query = "SELECT Report_Description " +
                           "FROM Report " +
                           "WHERE Report_ID = " + reportID + ";";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public string getAdminReply(int reportID)
        {
            string query = "SELECT Admin_Reply " +
                           "FROM Report " +
                           "WHERE Report_ID = " + reportID + ";";
            return dbMan.ExecuteScalar(query).ToString();
        }

        public int getEventID(int reportID) // using reportID
        {
            string query = "SELECT EventID " +
                            "FROM Report " +
                            "WHERE Report_ID = " + reportID + ";";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int DeleteEvent(int reportID)
        {
            int eventID = getEventID(reportID);
            string query = "UPDATE EventT " +
                           "SET Active = 0 " +
                           "WHERE EventID = " + eventID + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int BanOrganizer(int reportID)
        {
            int eventID = getEventID(reportID);

            string query1 = "SELECT Organizer " +
                            "FROM EventT " +
                            "WHERE EventID = " + eventID + ";";
            int organizerID = (int)dbMan.ExecuteScalar(query1);

            string query2 = "UPDATE Users " +
                            "SET Banned = 1 " +
                            "WHERE UserID = " + organizerID + ";";
            return dbMan.ExecuteNonQuery(query2);
        }

        public int setAdminReply(int reportID, string adminReply, int adminID)
        {
            string query = "UPDATE Report " +
                           "SET Handled = 1, Admin_Reply = '" + adminReply + "', AdminID = " + adminID +
                           " WHERE Report_ID = " + reportID + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable LoadReminders (int userID)
        {
            string query = "SELECT E.EventName, E.Descriptions, E.Edate, E.Start_Time, E.End_Time " +
                           "FROM EventT AS E " +
                           "JOIN Reminds AS R ON R.EventID = E.EventID " +
                           "WHERE R.UserID = " + userID + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable LoadInvites (int userID)
        {
            string query = "SELECT E.EventName, E.Descriptions, E.Edate, E.Start_Time, E.End_Time " +
                           "FROM EventT AS E " +
                           "JOIN Invites AS I ON I.EventID = E.EventID " +
                           "WHERE I.RSVP_Status = 0 AND I.UserID = " + userID + ";";
            return dbMan.ExecuteReader(query);
        }

        public int setRSVP (int userID, int eventID)
        {
            string query1 = "UPDATE Invites " +
                            "SET RSVP_Status = 1 " +
                            "WHERE UserID = " + userID + " AND EventID = " + eventID;
            return dbMan.ExecuteNonQuery(query1);
        }

        public int AcceptInvitation(int userID, int eventID)
        {
            int result = setRSVP (userID, eventID);
            if (result == 0)
            {
                MessageBox.Show("Operation failed");
                return 0;
            }
            else
            {
                string query = "INSERT INTO Attending (EventID, UserID) " +
                            "VALUES (" + eventID + ", " + userID + ");";

                return dbMan.ExecuteNonQuery(query);
            }
        }

        public int RejectInvitation(int userID, int eventID)
        {
            string query = "UPDATE Invites " +
                           "SET RSVP_Status = 2 " +
                           "WHERE UserID = " + userID + " AND EventID = " + eventID + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int GetEventIDFromInvite(string eventName, string date, string startTime)
        {
            string query = "SELECT EventID FROM EventT " +
                          "WHERE EventName = '" + eventName + "' " +
                          "AND Edate = '" + date + "' " +
                          "AND Start_Time = '" + startTime + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
