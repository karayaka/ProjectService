using Getway.Infrastructure.LogInterfaces;
using Getway.Models.LogModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getway.Services.LogServices
{
    public class MsSqlLogService : IMsSqlLogServices
    {


        public MsSqlLogService() { }

        public LogModel AddLog(LogModel model)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(""))
                {
                    string query = "INSERT INTO Customers VALUES(@ID,@Log, @LogDate)"; 

                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {

                        sqlCommand.CommandType = CommandType.StoredProcedure;


                        sqlCommand.Parameters.Add(new SqlParameter("@Log", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@Log"].Value = model.Log;

                        sqlCommand.Parameters.Add(new SqlParameter("@LogDate", SqlDbType.DateTime, 40));
                        sqlCommand.Parameters["@LogDate"].Value = model.LogDate;

                        // Add the output parameter.
                        sqlCommand.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int));
                        sqlCommand.Parameters["@ID"].Direction = ParameterDirection.Output;

                        try
                        {
                            connection.Open();

                            // Run the stored procedure.
                            sqlCommand.ExecuteNonQuery();

                            connection.Close();

                            model.ID = (int)sqlCommand.Parameters["@ID"].Value;


                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }


            }
            catch (Exception e)
            {
                throw e;
            }
            return model;
        }
    }
}
