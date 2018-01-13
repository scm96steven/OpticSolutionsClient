using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OpticSolutionsClient.Repositories.Entitys;

namespace OpticSolutionsClient.Repositories
{
    public class DataRepositories
    {
        public SqlConnection conn = new SqlConnection();

        public DataRepositories()
        {
            conn.ConnectionString = "Server=tcp:opticsolutions.database.windows.net,1433;Initial Catalog=OpticSolutions;Persist Security Info=False;User ID=osuser;Password=p@ssw0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


        }

        public List<Doctor> GetDoctors()
        {
            conn.Open();
            var data = conn.Query<Doctor>("GET_DOCTORS", null, commandType: System.Data.CommandType.StoredProcedure).ToList();
            conn.Close();
            return data;
        }

        public List<Appointment> GetAppointments(Appointment ap)
        {
            conn.Open();
            var queryParameters = new DynamicParameters();
            queryParameters.Add("@date", ap.Date);
            queryParameters.Add("@doctor_username", ap.DoctorUsername);

            var data = conn.Query<Appointment>("GET_APPOINTMENTS", queryParameters, commandType: System.Data.CommandType.StoredProcedure).ToList();


            conn.Close();
            return data;
        }
    }
}
