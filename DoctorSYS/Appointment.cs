using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace DoctorSYS
{
    class Appointment
    {
        private int appointmentid;
        private int patientid;
        private DateTime appDate;
        private String appTime;
        private int patientAge;
        private String reasonForVisit;
        private String resultOfVisit;
        private int cost;

        public Appointment()
        {
            appointmentid = 0;
            patientid = 0;
            appDate = default;
            appTime = "";
          

           
        }

        public Appointment(int appointmentid, int patientid, DateTime appDate, String appTime)
        {
            this.appointmentid = appointmentid;
            this.patientid = patientid;
            this.appDate = appDate;
            this.appTime = appTime;
            
            
            
        }

        public Appointment(DateTime appDate, string appTime, string age, string reasonForVisit, string resultOfVisit, int cost)
        {
            this.appDate = appDate;
            this.appTime = appTime;
            this.reasonForVisit = reasonForVisit;
            this.resultOfVisit = resultOfVisit;
            this.cost = cost;
        }

        public int getAppointmentId()
        {
            return appointmentid;
        }

        public int getPatientId()
        {
            return patientid;
        }

        public DateTime getDate()
        {
            return appDate;
        }

        public String getTime()
        {
            return appTime;
        }

        public String getreasonForVisit()
        {
            return reasonForVisit; 
        }
        public String getresultOfVisit()
        {
            return resultOfVisit; 
        }

        public int getCost()
        {
            return cost; 
        }
        public void setDate(DateTime date)
        {
            this.appDate = date;
        }

        public void setTime(String time)
        {
            this.appTime = time;
        }

        public static int getNextAppointmentId()
        {
            int nextAppointmentId = 0;

            String strSQL = "SELECT MAX(AppointmentId) FROM Appointments";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                nextAppointmentId = 1;
            else

                nextAppointmentId = dr.GetInt32(0) + 1;

            conn.Close();

            return nextAppointmentId;
        }

        
        public void makeAppointment()
        {
            //define Sql query
            String strSQL = "Insert INTO Appointments VALUES(" + this.appointmentid + "," + this.patientid + ",'" + String.Format("{0:dd-MMM-yy}", this.appDate) + "','" + this.appTime + "')";

            //Declare an Oracle Connection
            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            //declare Oracle Command to excute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public void getAppointment(int id)
        {

            String strSQL = "SELECT * FROM Appointments WHERE patientid = " + id;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);  

            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            
            this.appointmentid = dr.GetInt32(0);
            this.patientid = dr.GetInt32(1);
            this.appDate = dr.GetDateTime(2);
            this.appTime = dr.GetString(3);

            conn.Close();
        }

        public void getAppointmentCancel(int id)
        {

            String strSQL = "SELECT * FROM Appointments WHERE appointmentid = " + id;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);

            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();


            this.appointmentid = dr.GetInt32(0);
            this.patientid = dr.GetInt32(1);
            this.appDate = dr.GetDateTime(2);
            this.appTime = dr.GetString(3);

            conn.Close();
        }


        public static DataSet getAvailableTimes(String appDate)
        {

            
            String strSQL = "SELECT AppTime " +
                            "FROM Apptimes WHERE Apptime NOT IN (SELECT  AppTime "  +
                                                                "FROM Appointments " +
                                                                "WHERE AppDate = '" + appDate + "')" +
                             "ORDER BY appTime";
            

           // String strSQL = "SELECT * FROM AppTimes ";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "T");

            conn.Close();

            return ds;
        }

        public static DataSet getFutureApps(int patientId)
        {


            String strSQL = "SELECT appointmentid, patientid, AppDate, AppTime FROM Appointments WHERE PatientId = " + patientId + " AND appDate >= '" + DateTime.Now.ToString("dd-MMM-yy") + "'";


            // String strSQL = "SELECT * FROM AppTimes ";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "APP");

            conn.Close();

            return ds;
        }

        public static DataSet getAllApps(int patientId)
        {


            String strSQL = "SELECT appointmentid, patientid, AppDate, AppTime FROM Appointments WHERE PatientId = " + patientId;


            // String strSQL = "SELECT * FROM AppTimes ";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "APP");

            conn.Close();

            return ds;
        }

        public void cancelAppointment()
        { 


            String strSQL = "DELETE FROM Appointments WHERE appointmentId = " + this.appointmentid;

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "APP");

            conn.Close();

        }

        public void recordAppointmentDetails()
        {

            String strSQL = "Insert INTO AppointmentDetails VALUES('" + String.Format("{0:dd-MMM-yy}", this.appDate) + "','" + this.appTime + "','" + this.patientAge + "','" +
                this.reasonForVisit + "','" + this.resultOfVisit + "','" + this.cost + "')";

            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public static DataSet getYearlyAnalysis(String year)
        {

            String strSQL = "SELECT SUM(appCost), to_Char(appDate,'MM') " +
                "FROM APPOINTMENTDETAILS " +
                "WHERE appDate LIKE '%" + year + "'" + 
                "GROUP BY to_Char(appDate, 'MM') " +
                "ORDER BY to_Char(appDate, 'MM')";




            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "APPDT");

            conn.Close();

            return ds;
        }

        public static DataSet getAverageAge(String year)
        {

            String strSQL = "SELECT AVG(patientAge), to_Char(appDate,'MM') " +
                "FROM APPOINTMENTDETAILS " +
                "WHERE appDate LIKE '%" + year + "'" +
                "GROUP BY to_Char(appDate, 'MM') " +
                "ORDER BY to_Char(appDate, 'MM')";


            OracleConnection conn = new OracleConnection(DBConnect.oraDB);
            conn.Open();

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "APPDT");

            conn.Close();

            return ds;
        }

    }

}
