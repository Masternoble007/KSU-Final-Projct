/* DatabaseManagement.cs
 * By Steven Avila
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ManageDiabetic.Classes
{
    public static class DatabaseManagement
    {
        public static int InsertDateTime(DateTime date, DateTime time)
        {
            int rowId = 0;

            using (SqlConnection connection = new SqlConnection(LoadConnectionString()))
            {
                string querry = "INSERT INTO Measurement (Date, Time) VALUES (@Date, @Time)";
                using (SqlCommand command = new SqlCommand(querry, connection))
                {
                    querry = "SELECT IDENT_CURRENT('Measurement')";
                    using (SqlCommand readCommand = new SqlCommand(querry, connection))
                    {
                        command.Parameters.AddWithValue("@Date", System.Data.DbType.String).Value = date.ToString("MM-dd-yyyy");
                        command.Parameters.AddWithValue("@Time", System.Data.DbType.String).Value = time.ToString("HH:mm");

                        connection.Open();
                        command.ExecuteNonQuery();
                        
                        using (SqlDataReader reader = readCommand.ExecuteReader())
                        {
                            reader.Read();
                            rowId = (int)reader.GetDecimal(0);
                            reader.Close();
                        }
                        
                        connection.Close();
                    }
                }

            }
            return rowId;
        }
        
        public static List<InsulinType> LoadInsulinTypes()
        {
            List<InsulinType> insulinTypes = new List<InsulinType>();
            using (SqlConnection connection = new SqlConnection(LoadConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("SELECT Name, Brand FROM Insulin", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            insulinTypes.Add(new InsulinType(reader.GetString(0), reader.GetString(1)));
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
            }

            return insulinTypes;
        }

        public static List<Food> LoadFoodTypes()
        {
            List<Food> foods = new List<Food>();
            using (SqlConnection connection = new SqlConnection(LoadConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("SELECT Name, Brand, Carbs FROM Food", connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            string brand = reader.GetString(1);
                            float carbs = (float)reader.GetDouble(2);
                            foods.Add(new Food(name, brand, carbs));
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            return foods;
        }

        public static void InsertFoodType(Food foodToAdd)
        {
            using (SqlConnection connection = new SqlConnection(LoadConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Food (Name, Brand, Carbs) VALUES (@Name, @Brand, @Carbs)", connection))
                {
                    command.Parameters.AddWithValue("@Name", System.Data.DbType.String).Value = foodToAdd.Name;
                    command.Parameters.AddWithValue("@Brand", System.Data.DbType.String).Value = foodToAdd.Brand;
                    command.Parameters.AddWithValue("@Carbs", System.Data.DbType.Single).Value = foodToAdd.Carbs;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static void InsertInsulinType(InsulinType tmp)
        {
            using (SqlConnection connection = new SqlConnection(LoadConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Insulin (Name, Brand) VALUES (@Name, @Brand)", connection))
                {
                    command.Parameters.AddWithValue("@Name", System.Data.DbType.String).Value = tmp.Name;
                    command.Parameters.AddWithValue("@Brand", System.Data.DbType.String).Value = tmp.Brand;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static void InsertMeasurement(int rowId, double value)
        {
            using (SqlConnection connection = new SqlConnection(LoadConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("UPDATE Measurement SET MeasuredValue = @Value WHERE MeasurementId = @RowId", connection))
                {
                    command.Parameters.AddWithValue("@Value", System.Data.DbType.Double).Value = value;
                    command.Parameters.AddWithValue("@RowId", System.Data.DbType.Int32).Value = rowId;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static void InsertMeal(int rowId, Meal meal)
        {
            int foodId;
            using (SqlConnection connection = new SqlConnection(LoadConnectionString()))
            {
                using (SqlCommand command = new SqlCommand("SELECT FoodId FROM Food WHERE Name = @Name AND Brand = @Brand", connection))
                {
                    command.Parameters.AddWithValue("@Name", System.Data.DbType.String).Value = meal.food.Name;
                    command.Parameters.AddWithValue("@Brand", System.Data.DbType.String).Value = meal.food.Brand;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        foodId = reader.GetInt32(0);
                        reader.Close();
                    }
                    connection.Close();
                }
                using (SqlCommand command = new SqlCommand("INSERT INTO MeasurementFood (MeasurementId, FoodId, AmountInGrams) VALUES (@MeasurementId, @FoodId, @AmountInGrams)", connection))
                {
                    command.Parameters.AddWithValue("@MeasurementId", System.Data.DbType.Int32).Value = rowId;
                    command.Parameters.AddWithValue("@FoodId", System.Data.DbType.Int32).Value = foodId;
                    command.Parameters.AddWithValue("@AmountInGrams", System.Data.DbType.Double).Value = meal.amount;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static void InsertInsulinMeasurement(int rowId, int value, InsulinType insulin)
        {
            using (SqlConnection connection = new SqlConnection(LoadConnectionString()))
            {
                int insulinId = -1;
                int addedInsulinId = -1;
                using (SqlCommand command = new SqlCommand("SELECT InsulinId FROM Insulin WHERE Name = @Name AND Brand = @Brand", connection))
                {
                    command.Parameters.AddWithValue("@Name", System.Data.DbType.String).Value = insulin.Name;
                    command.Parameters.AddWithValue("@Brand", System.Data.DbType.String).Value = insulin.Brand;
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        insulinId = reader.GetInt32(0);
                        reader.Close();
                    }
                    connection.Close();
                }

                using (SqlCommand insertCommand = new SqlCommand("INSERT INTO AddedInsulin (InsulinId, InsulinAmount) VALUES (@InsulinId, @InsulinAmount)", connection))
                {
                    insertCommand.Parameters.AddWithValue("@InsulinId", System.Data.DbType.Int32).Value = insulinId;
                    insertCommand.Parameters.AddWithValue("@InsulinAmount", System.Data.DbType.Int32).Value = value;
                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                    using (SqlCommand returnIdCommand = new SqlCommand("SELECT IDENT_CURRENT('AddedInsulin')", connection))
                    {
                        using (SqlDataReader reader = returnIdCommand.ExecuteReader())
                        {
                            reader.Read();
                            addedInsulinId = (int)reader.GetDecimal(0);
                            reader.Close();
                        }
                    }
                    connection.Close();
                }


                using (SqlCommand command = new SqlCommand("UPDATE Measurement SET AddedInsulinId = @AddedInsulinId WHERE MeasurementId = @RowId", connection))
                {
                    command.Parameters.AddWithValue("@AddedInsulinId", System.Data.DbType.Int32).Value = addedInsulinId;
                    command.Parameters.AddWithValue("@RowId", System.Data.DbType.Int32).Value = rowId;
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public static List<TimeMeasurement> MeasurementsOnDate(DateTime date)
        {
            List<TimeMeasurement> timeMeasurements = new List<TimeMeasurement>();
            List<int> ids = new List<int>();
            using (SqlConnection connection = new SqlConnection(LoadConnectionString()))
            {
                string querry = "SELECT MeasurementId, Time, MeasuredValue, AddedInsulin.InsulinAmount, Insulin.Name, Insulin.Brand FROM Measurement LEFT JOIN AddedInsulin ON(Measurement.AddedInsulinId=AddedInsulin.AddedInsulinId) LEFT JOIN Insulin ON(AddedInsulin.InsulinId=Insulin.InsulinId) WHERE Date = CAST(@date AS DATE) ORDER BY Time ASC";
                using (SqlCommand command = new SqlCommand(querry, connection))
                {


                    command.Parameters.AddWithValue("@date", System.Data.DbType.String).Value = date.ToString("MM-dd-yyyy");
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            ids.Add(reader.GetInt32(0));
                            DateTime time = reader.GetDateTime(1);
                            float measuredValue = reader.IsDBNull(2) ? 0 : reader.GetFloat(2);
                            int insulinAmount = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                            String insulinName = reader.IsDBNull(4) ? "/" : reader.GetString(4);
                            String insulinBrand = reader.IsDBNull(5) ? "/" : reader.GetString(5);

                            timeMeasurements.Add(new TimeMeasurement(time, measuredValue, new AddedInsulin(new InsulinType(insulinName, insulinBrand), insulinAmount)));
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
                if (ids.Count > 0)
                {
                    querry = "SELECT Food.Name, Food.Brand, Food.Carbs, MeasurementFood.AmountInGrams FROM MeasurementFood LEFT JOIN Food ON(MeasurementFood.FoodId=Food.FoodId) WHERE MeasurementId = @id";
                    using (SqlCommand command = new SqlCommand(querry, connection))
                    {
                        command.Parameters.AddWithValue("@id", System.Data.DbType.Int32);

                        for (int i = 0, size = ids.Count; i < size; ++i)
                        {
                            command.Parameters["@id"].Value = ids[i];
                            connection.Open();
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    String name = reader.IsDBNull(0) ? "/" : reader.GetString(0);
                                    String manufacturer = reader.IsDBNull(1) ? "/" : reader.GetString(1);
                                    float carbs = reader.IsDBNull(2) ? 0 : (float)reader.GetDouble(2);
                                    double amountInGrams = reader.IsDBNull(3) ? 0 : (double)reader.GetSqlSingle(3);
                                    timeMeasurements[i].addMeal(new Meal(new Food(name, manufacturer, carbs), amountInGrams));
                                }

                                reader.Close();
                            }
                            connection.Close();
                        }
                    }
                }
            }
            return timeMeasurements;
        }

        public static float AvgBGMeasurement()
        {
            float avgBG = 0.0f;
            using (SqlConnection connection = new SqlConnection(LoadConnectionString()))
            {
                string querry = "SELECT AVG(Measurement.MeasuredValue) FROM Measurement WHERE Date >= DATEADD(DAY, -90, GETDATE())";
                using (SqlCommand command = new SqlCommand(querry, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            avgBG = (float)reader.GetDouble(0);
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            return avgBG;
        }

        private static string LoadConnectionString(string name = "LocalDiabetesServ")
        {
            var theString = ConfigurationManager.ConnectionStrings[name].ConnectionString;
            return theString;
        }
    }
}
