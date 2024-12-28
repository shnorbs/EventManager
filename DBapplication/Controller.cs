using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Drawing;
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
        public int GetEventOrganizer(int id)
        {
            string query = "select Organizer FROM EventT where EventID = " + id + ";";
            return (int)dbMan.ExecuteScalar(query);
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

        public int ChangePassword(string email, string newPassword)
        {
            string query = "UPDATE Users SET Password = '" + newPassword + "' WHERE Email = '" + email + "';";
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
        public string getUserTypeByUserID(int userID)
        {
            string query = "SELECT UserType FROM Users u WHERE u.UserID = " + userID + ";";
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
        ///Statsitcs Functions
        /// Statistical Functions
        public DataTable Average_Feedback_Rating()
        {
            string query = "SELECT E.EventName, AVG(F.Rating) AS AverageRating " +
                           "FROM Feedback F " +
                           "JOIN EventT E ON F.EventID = E.EventID " +
                           "GROUP BY E.EventName " +
                           "ORDER BY AverageRating DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Total_Revenue_By_Event()
        {
            string query = "SELECT E.EventName, SUM(T.Price * T.Ticket_Count) AS TotalRevenue " +
                           "FROM Tickets T " +
                           "JOIN EventT E ON T.EventID = E.EventID " +
                           "GROUP BY E.EventName " +
                           "ORDER BY TotalRevenue DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Attendance_Trends_By_Month()
        {
            string query = "SELECT MONTH(E.Edate) AS Month, COUNT(A.UserID) AS AttendanceCount " +
                           "FROM Attending A " +
                           "JOIN EventT E ON A.EventID = E.EventID " +
                           "GROUP BY MONTH(E.Edate) " +
                           "ORDER BY Month;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Ticket_Price_Variance()
        {
            string query = "SELECT E.EventName, VAR(T.Price) AS PriceVariance " +
                           "FROM Tickets T " +
                           "JOIN EventT E ON T.EventID = E.EventID " +
                           "GROUP BY E.EventName " +
                           "ORDER BY PriceVariance DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Events_Grouped_By_Type()
        {
            string query = "SELECT E.Etype AS EventType, COUNT(A.UserID) AS TotalAttendance " +
                           "FROM EventT E " +
                           "JOIN Attending A ON E.EventID = A.EventID " +
                           "GROUP BY E.Etype " +
                           "ORDER BY TotalAttendance DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Profit_Gained_By_Organizer()
        {
            string query = "SELECT U.First_Name + ' ' + U.Last_Name AS OrganizerName, SUM(T.Price * T.Ticket_Count) AS TotalProfit " +
                           "FROM Users U " +
                           "JOIN EventT E ON U.UserID = E.Organizer " +
                           "JOIN Tickets T ON E.EventID = T.EventID " +
                           "WHERE U.UserType = 'Organizer' " +
                           "GROUP BY U.First_Name, U.Last_Name " +
                           "ORDER BY TotalProfit DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Events_Without_Feedback()
        {
            string query = "SELECT E.EventName " +
                           "FROM EventT E " +
                           "LEFT JOIN Feedback F ON E.EventID = F.EventID " +
                           "WHERE F.EventID IS NULL " +
                           "ORDER BY E.EventName;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Revenue_By_Event_Type()
        {
            string query = "SELECT E.Etype AS EventType, SUM(T.Price * T.Ticket_Count) AS TotalRevenue " +
                           "FROM EventT E " +
                           "JOIN Tickets T ON E.EventID = T.EventID " +
                           "GROUP BY E.Etype " +
                           "ORDER BY TotalRevenue DESC;";
            return dbMan.ExecuteReader(query);
        }

       

        public DataTable Feedback_Summary_By_Event()
        {
            string query = "SELECT E.EventName, " +
                           "SUM(CASE WHEN F.Rating >= 4 THEN 1 ELSE 0 END) AS PositiveFeedback, " +
                           "SUM(CASE WHEN F.Rating < 4 THEN 1 ELSE 0 END) AS NegativeFeedback " +
                           "FROM EventT E " +
                           "LEFT JOIN Feedback F ON E.EventID = F.EventID " +
                           "GROUP BY E.EventName " +
                           "ORDER BY E.EventName;";
            return dbMan.ExecuteReader(query);
        }


        /// Managerial Functions
        public DataTable Total_Tickets_Sold()
        {
            string query = "SELECT SUM(T.Ticket_Count) AS TotalTicketsSold " +
                           "FROM Tickets T;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Average_Revenue_Per_Event()
        {
            string query = "SELECT AVG(T.Price * T.Ticket_Count) AS AverageRevenue " +
                           "FROM Tickets T " +
                           "JOIN EventT E ON T.EventID = E.EventID;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Most_Popular_Event_By_Sales()
        {
            string query = "SELECT TOP 1 E.EventName, SUM(T.Ticket_Count) AS TotalTickets " +
                           "FROM Tickets T " +
                           "JOIN EventT E ON T.EventID = E.EventID " +
                           "GROUP BY E.EventName " +
                           "ORDER BY TotalTickets DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Min_Max_Attendance_Per_Event()
        {
            string query = "SELECT MIN(A.UserID) AS MinAttendance, MAX(A.UserID) AS MaxAttendance, E.EventName " +
                           "FROM Attending A " +
                           "JOIN EventT E ON A.EventID = E.EventID " +
                           "GROUP BY E.EventName;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Total_Revenue()
        {
            string query = "SELECT SUM(T.Price * T.Ticket_Count) AS TotalRevenue " +
                           "FROM Tickets T;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Most_Profitable_Organizer()
        {
            string query = "SELECT TOP 1 U.First_Name + ' ' + U.Last_Name AS OrganizerName, SUM(T.Price * T.Ticket_Count) AS TotalRevenue " +
                           "FROM Users U " +
                           "JOIN EventT E ON U.UserID = E.Organizer " +
                           "JOIN Tickets T ON E.EventID = T.EventID " +
                           "WHERE U.UserType = 'Organizer' " +
                           "GROUP BY U.First_Name, U.Last_Name " +
                           "ORDER BY TotalRevenue DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Total_Events_By_Type()
        {
            string query = "SELECT E.Etype AS EventType, COUNT(E.EventID) AS TotalEvents " +
                           "FROM EventT E " +
                           "GROUP BY E.Etype " +
                           "ORDER BY TotalEvents DESC;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Average_Feedback_Rating_All_Events()
        {
            string query = "SELECT AVG(F.Rating) AS AverageRating " +
                           "FROM Feedback F;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Total_Users_Registered()
        {
            string query = "SELECT COUNT(U.UserID) AS TotalUsers " +
                           "FROM Users U;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Number_Of_Events_Per_Organizer()
        {
            string query = "SELECT U.First_Name + ' ' + U.Last_Name AS OrganizerName, COUNT(E.EventID) AS TotalEvents " +
                           "FROM Users U " +
                           "JOIN EventT E ON U.UserID = E.Organizer " +
                           "WHERE U.UserType = 'Organizer' " +
                           "GROUP BY U.First_Name, U.Last_Name " +
                           "ORDER BY TotalEvents DESC;";
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

        public string GetEventType(int EventID)
        {
            string query = "select Etype from EventT where EventID = " + EventID + ";";
            return (string)dbMan.ExecuteScalar(query);
        }


        public DataTable SelectEventType()
        {
            DataTable table = new DataTable();
            string query = $"Select * From EventT;";
            table = dbMan.ExecuteReader(query);
            return table;
        }
        public DataTable SelectLocation()
        {
            DataTable table = new DataTable();
            string query = $"Select * From Venue;";
            table = dbMan.ExecuteReader(query);
            return table;
        }

        public void AddEvent(string EventName, int uID, string EventDate, string Description, string EventType, string StartTime, string EndTime, int Privacy, int Location)
        {
            string query = $"INSERT INTO EventT (EventName, Organizer, Edate, Descriptions, Etype, Start_Time, End_Time, Privacy_Status, Location) VALUES('{EventName}','{uID}','{EventDate}','{Description}','{EventType}','{StartTime}','{EndTime}','{Privacy}','{Location}');";
            int obj = dbMan.ExecuteNonQuery(query);
            if (obj == 0)
            {
                MessageBox.Show("Couldn't Add Event");
                return;
            }
            else
            {
                MessageBox.Show("Added Event");
                return;
            }
        }

        public int AddReminder(string date, int eventID, int userID)
        {
            string query = "INSERT INTO Reminds VALUES " +
                "('" + date + "', " + eventID + ", " + userID + ");";
            int obj = dbMan.ExecuteNonQuery(query);
            if (obj == 0)
            {
                MessageBox.Show("Reminder Already Exists!");
                return 0;
            }
            else
            {
                MessageBox.Show("Reminder Added Successfully!");
                return 1;
            }
        }

        public int AddFeedback(int rating, string date, string comment, int userID, int eventID)
        {
            if (comment == "")
            {
                string query = "INSERT INTO Feedback (Rating, FB_Date, Comment, UserID, EventID) VALUES " +
                    "(" + rating + ", '" + date + "', NULL, " + userID + ", " + eventID + ");";
                return dbMan.ExecuteNonQuery(query);
            }

            else
            {
                string query = "INSERT INTO Feedback (Rating, FB_Date, Comment, UserID, EventID) VALUES " +
                    "(" + rating + ", '" + date + "', '" + comment + "', " + userID + ", " + eventID + ");";
                return dbMan.ExecuteNonQuery(query);
            }
        }

        public int AddReport(string desc, int userID, int eventID)
        {
            string query = "INSERT INTO Report (Handled, Report_Description, Admin_Reply, UserID, AdminID, EventID) VALUES " +
                "(0, '" + desc + "', NULL, '" + userID + "', NULL, " + eventID + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public void AddTickets(string TicketType,float price,int NumberofTickets,string EventName)
        {
            string eventid = $"SELECT EventID FROM EventT Where EventName='{EventName}';";
            int Eid=Convert.ToInt32(dbMan.ExecuteScalar(eventid));
            string query = $"INSERT INTO Tickets VALUES('{TicketType}','{NumberofTickets}','{price}','{Eid}');";
            int obj=dbMan.ExecuteNonQuery(query);
            if (obj == 0)
            {
                MessageBox.Show("Couldn't Add Tickets info please enter correct");
                return;
            }
            else
            {
                //MessageBox.Show("Added Event");
                //return;
            }
        }

        public void AddService(string ServiceName, string ServiceType, float Sprice)
        {
            string query1 = $"INSERT INTO Services(Service_Name,Type,Price) VALUES('{ServiceName}','{ServiceType}','{Sprice}');";
            int obj1 = dbMan.ExecuteNonQuery(query1);
            if (obj1 == 0)
            {
                MessageBox.Show("Couldn't Add Service info please enter correct");
                return;
            }
            else
            {
                //MessageBox.Show("Added Event");
                //return;
            }
        }

        public void BookService(string ServiceName, string EventName, string EventDate, float Price)
        {
            string eventid = $"SELECT EventID FROM EventT Where EventName='{EventName}';";
            int Eid = Convert.ToInt32(dbMan.ExecuteScalar(eventid));
            string servicetid = $"SELECT Service_ID FROM Services Where Service_Name='{ServiceName}';";
            int Sid = Convert.ToInt32(dbMan.ExecuteScalar(servicetid));
            string query = $"INSERT INTO Books VALUES('{Sid}','{Eid}','{EventDate}','{Price}');";
            int obj = dbMan.ExecuteNonQuery(query);
            if (obj == 0)
            {
                MessageBox.Show("Couldn't Book Service");
                return;
            }
            else
            {
                //MessageBox.Show("Added Event");
                //return;
            }
        }

        public void AddVenue(string VenueAddress,string VenueName,int Capacity,float BookingPrice)
        {
            string query1 = $"INSERT INTO Venue (Venue_Address,Venue_Name,Capacity,Booking_Price) VALUES('{VenueAddress}','{VenueName}','{Capacity}','{BookingPrice}');";
            int obj1 = dbMan.ExecuteNonQuery(query1);
            if (obj1 == 0) 
            {
                MessageBox.Show("Couldn't Add Venue");
                return;
            }
            else
            {
                MessageBox.Show("Added Venue");
                return;
            }
        }

        public void AddFacility(string VenueName,string FacilityType)
        {
            string retreiveid = $"SELECT Venue_ID FROM Venue Where Venue_Name='{VenueName}';";
            int id = Convert.ToInt32(dbMan.ExecuteScalar(retreiveid));
            string query2 = $"INSERT INTO Facilities(Venue_Related_ID,Type) Values('{id}','{FacilityType}');";
            int obj2 = dbMan.ExecuteNonQuery(query2);
            if (obj2 == 0)
            {
                MessageBox.Show("Couldn't Add Facility");
                return;
            }
            else
            {
              //  MessageBox.Show("Added Venue");
              //  return;
            }
        }

        public DataTable GetUsers()
        {
            DataTable dt = new DataTable();
            string query = $"Select First_Name,Last_Name,Email,Phone_Number From Users;";
            dt=dbMan.ExecuteReader(query);
            return dt;
        }

        public void AddInvite(string email,string Ename,int RSVP)
        {
            string E_id= $"SELECT EventID FROM EventT Where EventName='{Ename}';";
            int Eid = Convert.ToInt32(dbMan.ExecuteScalar(E_id));
            string U_id = $"SELECT UserID FROM Users Where Email='{email}';";
            int Uid = Convert.ToInt32(dbMan.ExecuteScalar(U_id));

            string query = $"Insert Into Invites Values('{Uid}','{Eid}','{RSVP}');";
            int obj = dbMan.ExecuteNonQuery(query);
            if (obj == 0)
            {
                MessageBox.Show("Couldn't Finish Invites");
                return;
            }
            else
            {
                MessageBox.Show("Added Invite");
                return;
            }
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
        public DataTable SelectTicketType(int EventID)
        {
         
            string query = "Select T.Ticket_Type  from Tickets T, EventT E where  T.EventID=E.EventID AND T.EventID="+EventID+";";
            return dbMan.ExecuteReader(query);
        }
        public int InsertIntoBuys(string ticketType, int eventID, int userID, DateTime purchaseDate,  int quantity)
        {
            string query = "INSERT INTO Buys (Ticket_Type, EventID, UserID, Purchase_Date,Quantity) " +
                           "VALUES ('" + ticketType + "', " + eventID + ", " + userID + ", '" + purchaseDate.ToString("yyyy-MM-dd") +"', " + quantity + ");";

            return dbMan.ExecuteNonQuery(query);
        }
        public int GetTicketCount(string ticketType, int eventID)
        {
            string query = "SELECT Ticket_Count FROM Tickets " +
                           "WHERE Ticket_Type = '" + ticketType + "' AND EventID = " + eventID + ";";

            DataTable dt = dbMan.ExecuteReader(query);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["Ticket_Count"]); // Return the ticket count
            }
            else
            {
                return -1; // Return -1 if no matching record is found
            }
        }
        public int UpdateTicketCount(string ticketType, int eventID, int newCount)
        {
            string query = "UPDATE Tickets " +
                           "SET Ticket_Count = " + newCount + " " +
                           "WHERE Ticket_Type = '" + ticketType + "' AND EventID = " + eventID + ";";

            return dbMan.ExecuteNonQuery(query); // Return the number of rows affected
        }
        public int Find_if_tickets(string ticketType, int eventID, int newCount)
        {
            string query = "UPDATE Tickets " +
                           "SET Ticket_Count = " + newCount + " " +
                           "WHERE Ticket_Type = '" + ticketType + "' AND EventID = " + eventID + ";";

            return dbMan.ExecuteNonQuery(query); // Return the number of rows affected
        }
        public bool Find_if_tickets(int eventID)
        {
            string query = "SELECT COUNT(*) FROM Tickets " +
                           "WHERE EventID = " + eventID + ";";

            // Execute the query
            DataTable dt = dbMan.ExecuteReader(query);

            // Check if a matching record exists
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                return true; // Record exists
            }
            else
            {
                return false; // No matching record found
            }
        }


        public void AddSponsor(string CompanyName,string EventName)
        {
            string E_id = $"Select EventID From EventT Where EventName='{EventName}';";
            int Eid = Convert.ToInt32(dbMan.ExecuteScalar(E_id));
            string query = $"Insert INTO Sponsors(CompanyName) values('{CompanyName}');";
            int obj = dbMan.ExecuteNonQuery(query);
            if (obj == 0)
            {
                MessageBox.Show("Couldn't add sponsor");
                return;
            }
            else
            {
                MessageBox.Show("Added Sponsor");
                return;
            }
        }

        public void AddSponsored(string CompanyName,float AmountSponsored ,string EventName)
        {
            string E_id = $"Select EventID From EventT Where EventName='{EventName}';";
            int Eid = Convert.ToInt32(dbMan.ExecuteScalar(E_id));

            string S_id= $"Select SponsorID From Sponsors Where CompanyName='{CompanyName}';";
            int Sid = Convert.ToInt32(dbMan.ExecuteScalar(S_id));

            string query = $"Insert INTO Sponsored values('{Eid}','{Sid}','{AmountSponsored}');";
            int obj = dbMan.ExecuteNonQuery(query);
            //if (obj == 0)
            //{
            //    MessageBox.Show("Couldn't add sponsor");
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("Added Sponsor");
            //    return;
            //}
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
