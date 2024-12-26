﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Drawing;

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
            string query = "select E.EventName AS [Event Name], E.Start_Time AS [Starts At], E.End_Time AS [Ends At], V.Venue_Name AS [Venue Name]  from EventT E, Venue V where E.Location = V.Venue_ID AND E.Edate = '2024-12-1' AND E.Privacy_Status = 0;";
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

        public void AddEvent(string EventName,int uID,string EventDate,string Description,string EventType,string StartTime,string EndTime,int Privacy,int Location)
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


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
