 
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace CMJGasStationPointSystem
{
    class ConnString
    {
        private SqlConnection cn = new SqlConnection();
        private SqlCommand COMM = new SqlCommand();
        public void ConnDB()
        {
            cn.Close();
            try
            {               
                cn.ConnectionString = "Server = server\\sa;Database = CMJGasStationDB;user id= sa; password = markadmin_28";
                cn.Open();                
            }
            catch
            {
                MessageBox.Show("Can't connect to server.", "Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return; 
            }
        }
        public void IUD(string QUERY)
        {
            COMM = new SqlCommand(QUERY,cn);
            cn.Close();
            cn.Open();
            COMM.ExecuteNonQuery();
            cn.Close();
        }
        public DataTable DISPLAY(string QUERY)
        {
            COMM = new SqlCommand(QUERY,cn);
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(COMM);
            adp.Fill(dt);
            return dt;

        }
        public void disconMy()
        {            
            cn.Dispose();
            cn.Close();
        }
    }
    static class UserID
    {
        private static int _userid = 101;
        public static int userid
        {
            get { return _userid; }
            set { _userid = value; }
        }
    }
    static class UserName
    {
        private static string _userName = "";
        public static string userName
        {
            get { return _userName; }
            set { _userName = value; }
        }
    }
    static class UserUserName
    {
        private static string _userUsername = "";
        public static string userUsername
        {
            get { return _userUsername; }
            set { _userUsername = value; }
        }
    }
    static class AccessLevel
    {
        private static int _accessLevel = 0;
        public static int accessLevel
        {
            get { return _accessLevel; }
            set { _accessLevel = value; }
        }
    }
     
}
