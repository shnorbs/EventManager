using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        public int FindEventsPrivateToday(int uID, string date)
        {
            string query = "select count(*) from Users u, EventT E, Invites I where u.UserID = I.UserID AND E.EventID = I.EventID AND E.Privacy_Status = 1 AND u.UserID = " + uID + " AND i.RSVP_Status = 1 AND E.Edate = '" + date + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int FindPublicEventsToday(string date)
        {
            string query = "select count(E.EventID) from EventT E where E.Edate = '" + date + "' AND E.Privacy_Status = 0;";
            return (int)dbMan.ExecuteScalar(query);
        }




        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
