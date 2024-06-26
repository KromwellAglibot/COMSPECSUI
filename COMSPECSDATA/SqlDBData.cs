using COMSPECSMODEL;
using System.Data.SqlClient;

namespace COMSPECSDATA
{
    public class SqlDbData
    {

        string connectionString
        = "Data Source =DESKTOP-7NDQCQL\\SQLEXPRESS; Initial Catalog = COMSPECSUI; Integrated Security = True;";

        SqlConnection sqlConnection;

        public SqlDbData()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<User> GetUsers()
        {
            string selectStatement = "SELECT Userid FROM Comp";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            List<User> model = new List<User>();

            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                string Userid = reader["model"].ToString();

                User readModel = new User();
                readModel.Userid = Userid;

                model.Add(readModel);
            }

            sqlConnection.Close();

            return model;
        }

        public int AddModel(string Userid)
        {
            int success;

            string insertStatement = "INSERT INTO Comp VALUES (@Userid)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@Userid", Userid);
            sqlConnection.Open();

            success = insertCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        public int UpdateModel(string Userid)
        {
            int success;

            string updateStatement = $"UPDATE model SET Userid = @Userid WHERE Userid = @Userid";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
            sqlConnection.Open();

            updateCommand.Parameters.AddWithValue("@Userid", Userid);

            success = updateCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        public int DeleteModel(string Userid)
        {
            int success;

            string deleteStatement = $"DELETE FROM model WHERE Userid = @Userid";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            sqlConnection.Open();

            deleteCommand.Parameters.AddWithValue("@Userid", Userid);

            success = deleteCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }
    }
}