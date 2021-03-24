using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Final
{
    class DBCommands
    {
         
        /*
         * I first create a method for getting the connection string which allows me to connect to the postgreSQL DB
         *  I have my password saved in a passfile environment variable so it does not show up in my code
         */
        private static string getConnectionString()
        {
            var cs = "Host=localhost;Port=5432;Database=employees;Username=postgres;";
            return cs;
        }
        /*
         *  Below we instantiate some default Npgsql classes as default values for later use with the CRUDOPS class
         *  cmd is what we will use to do start our CRUD operation code for postgres
         */
        public static NpgsqlConnection con = new NpgsqlConnection(getConnectionString());
        public static NpgsqlCommand cmd = default(NpgsqlCommand);
        public static string sql = string.Empty;


        /*
         *  PerformCommand is my method for doing just that, performing any CRUD operations
         *  Inside the method we create a DataAdapter 'da' that we will pass various commands into from our cmd
         *  We also create a DataTable object 'dt' that we will use for holding our table data
         *  
         *  If we have any issues performing a crud operation or creating either da or dt, we catch it with a message box
         */
        public static DataTable PerformCommand(NpgsqlCommand com)
        {
            NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                da = new NpgsqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Has Occurred: " + ex.Message, "Could Not Perform Operation.", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                dt = null;
            }
            return dt;
        }

        /*
         *  This is the function that handles the logic for updating a selected record in the database. This function can and will be reused, which saves time and is neater.
         */
        public static void Update(DataGridView dbGrid, string id, Action<string,string> executeCMD, Func<bool> missingField)
        {
            // we don't want to be able to update anything if there is no data present in our table
            if (dbGrid.Rows.Count == 0)
            {
                return;
            }
            // we make sure the user has selected a row from the table on the form
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please Select An Employee From The Table To Update By Clicking A Row", "Data Missing To Update",
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // Again, We make sure that the user inputs some values to the textboxes
            // This should be auto generated from a function we create when they click a row in the datagrid
            //    but just in case we add this check
            if (missingField())
            {
                MessageBox.Show("One or more text fields are missing. Please make sure to fill out at least one textbox", "Data Missing For Update",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Here we use an UPDATE statement using our parameters from addParameters function for 
            // We use the same parameters as the Insert statement
            try
            {
                DBCommands.sql = "UPDATE users SET first_nm = @first_nm, last_nm = @last_nm " +
                          "WHERE id = @id::integer";
                executeCMD(DBCommands.sql, "Update");
                DBCommands.sql = "UPDATE users SET chg_dtm = @dtm WHERE id = @id::integer";
                executeCMD(DBCommands.sql, "Update");
                DBCommands.sql = "UPDATE job_details SET job_ttl = @job_ttl, work_location = @work_location, yrs_in_job = @yrs_in_job " +
                                "WHERE id = @id::integer";
                executeCMD(DBCommands.sql, "Update");

                MessageBox.Show("The Record Has Been Updated!", "Updated Entry!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception err)
            {
                MessageBox.Show($"There Was A Problem Updating The Records. Please Try Again. Error was: {err}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        /*
         *  This function handles logically deleting a record from the database. We only change the status code of the records so that we can handle undeleting them or purging them later.
         *  This function can and will be reused, which saves time and is neater.
         */
        public static void softDelete(DataGridView grid, string id, Action<string,string> executeCMD)
        {
            // we don't want to be able to delete anything if there is no data present in our table
            if (grid.Rows.Count == 0)
            {
                return;
            }
            // we make sure the user has selected a row from the table on the form
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please Select An Item From The Table To Delete By Clicking A Row", "Data Missing To Delete",
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                DBCommands.sql = "UPDATE users SET stat_cd = 'D' WHERE id = @id::integer";
                executeCMD(DBCommands.sql, "Update");
                DBCommands.sql = "UPDATE job_details SET stat_cd = 'D' WHERE id = @id::integer";
                executeCMD(DBCommands.sql, "Update");

                MessageBox.Show("The Record Has Been Deleted! If this was by mistake, click the 'Undelete' Button To Restore It.", "Record Deleted Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            }
            catch (Exception err)
            {
                MessageBox.Show($"There Was A Problem Deleting The Records. Please Try Again. Error was: {err}", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*
         *  This function handles undeleting the last deleted record. It will work for as many records as you have deleted, grabbing one record at a time based on most recently deleted.
         *  This function can and will be reused, which saves time and is neater.
         */
        public static void UnDelete(int lastId,Action<string,string> executeCMD)
        {
            try
            {

                if (lastId != -1)
                {
                    DBCommands.sql = "UPDATE users SET stat_cd = 'A' WHERE stat_cd = 'D' AND id = @id";
                    executeCMD(DBCommands.sql, "Update");

                    DBCommands.sql = "UPDATE job_details SET stat_cd = 'A' WHERE stat_cd = 'D' AND id = @id";
                    executeCMD(DBCommands.sql, "Update");

                    MessageBox.Show("The Record Has Been UnDeleted!", "Record UnDeleted Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"There Are No Records To UnDelete.", "UnDelete Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
            catch (Exception err)
            {
                MessageBox.Show($"There Was A Problem UnDeleting The Record. Please Try Again. Error was: {err}", "UnDelete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }


        /*
         *  This function works a lot like the trash on Windows and other OS. It will delete every record that has been sent to "deletion" status.
         *  This function can and will be reused, which saves time and is neater.
         */
        public static void Purge(Action<string,string> executeCMD)
        {
            if (MessageBox.Show("Do You Want To Permanently Empty The Deleted Records? This Will Delete Employee Job Details Too", "Confirm Delete", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    DBCommands.sql = "DELETE FROM users WHERE stat_cd = 'D'";
                    executeCMD(DBCommands.sql, "Delete");
                    DBCommands.sql = "DELETE FROM job_details WHERE stat_cd = 'D'";
                    executeCMD(DBCommands.sql, "Delete");

                    MessageBox.Show("The Records Have Been Deleted!", "Records Deleted Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception err)
                {
                    MessageBox.Show($"There Was A Problem Purging The Records. Please Try Again. Error was: {err}", "Purge Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
        }
    }
}
