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
                //projeye ait configiration dosyasından alınmalı
                using (SqlConnection connection = new SqlConnection(@"
                    Server = DESKTOP-4SVI4H2; Database = logDb; Trusted_Connection = True;
                "))
                {
                    string query = @"
                        INSERT INTO LogTable (LogDec, LogDate, LogTypes) VALUES ( @LogDec, @LogDate, @LogTypes)
                        Select Scope_Identity()"; 

                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                    {

                        sqlCommand.Parameters.Add(new SqlParameter("@LogDec", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@LogDec"].Value = model.LogDec;

                        sqlCommand.Parameters.Add(new SqlParameter("@LogDate", SqlDbType.DateTime));
                        sqlCommand.Parameters["@LogDate"].Value = model.LogDate;

                        sqlCommand.Parameters.Add(new SqlParameter("@LogTypes", SqlDbType.SmallInt));
                        sqlCommand.Parameters["@LogTypes"].Value = Convert.ToInt16(model.LogTypes);

                        // Add the output parameter.
                    
                        try
                        {
                            connection.Open();

                            // Run the stored procedure.
                            sqlCommand.ExecuteNonQuery();

                         
                            model.ID = Convert.ToInt32(sqlCommand.ExecuteScalar());

                            connection.Close();

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
