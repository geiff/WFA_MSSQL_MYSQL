namespace RegisterOfImmunizedCows.View
{
    using System.Data;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;

    public static class DataGridPreview
    {
        //Filling Grid with data from datbase
        public static void Fill(DataGridView dataGridView)
        {
            string connectionString = "server=127.0.0.1;user=root;database=register_of_immunized_cows;port=3306;password=12345;";
            string sql = "select r.Id as 'Номер Регистър', c.NumberOnCow as 'Марк. Номер на крава', " +
                         "c.PopulatedPlace as 'Населено място', i.Name as Имунизация, i.Description as 'Описание на имунизация'," +
                         " r.DateOnImmunization as 'Дата на имунизация'" +
                         "from registers r join cows c on c.Id = r.CowID join immunizations i on i.Id = r.ImmunisationID order by r.Id";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection))
                {
                    using (DataTable dataTable = new DataTable())
                    {
                        dataAdapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                        dataGridView.Update();

                    }
                }
            }
        }

        //Filling the Grid with the searching data by date 
        public static void FillWirhSearchData(string date, DataGridView dataGridView)
        {
            string connectionString =
                "server=127.0.0.1;user=root;database=register_of_immunized_cows;port=3306;password=12345;";
            string sql = "select r.Id as 'Номер Регистър', c.NumberOnCow as 'Марк. Номер на крава', " +
                         "c.PopulatedPlace as 'Населено място', i.Name as Имунизация, i.Description as 'Описание на имунизация'," +
                         " r.DateOnImmunization as 'Дата на имунизация'" +
                         "from registers r join cows c on c.Id = r.CowID join immunizations i on i.Id = r.ImmunisationID " +
                         "where r.DateOnImmunization = '" + date + "'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection))
                {
                    using (DataTable dataTable = new DataTable())
                    {
                        dataAdapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                        dataGridView.Update();

                    }
                }
            }
        }
    }
}