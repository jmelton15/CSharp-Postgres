using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using Npgsql;
using Microsoft.VisualBasic;

namespace Final
{
    public partial class Form1 : Form
    {
        /*
         *  The two below variables are used throughout to be used in our queries 
         */
        private string id = "";
        private int lastId = -1;
        public Form1()
        {
            InitializeComponent();
            resetForm();
        }

        /*
         * This is the main function of the form. It uses a Select statement that encompasses a searchTerm.
         * This query allows for Searching all (just "" as the searchTerm) and searching for any name, first or last or both.
         * We use this loadData function anytime we add,update,or delete records
         */
        private void loadData(string searchTerm)
        {
            DBCommands.sql = "SELECT users.id, first_nm, last_nm, job_ttl, work_location, yrs_in_job " +
                            "FROM users JOIN job_details ON job_details.id = users.id WHERE CONCAT(first_nm, ' ', last_nm) ILIKE @searchTerm::varchar AND users.stat_cd = 'A' ORDER BY last_nm";

            
           // The format %str% is postgres language for grabbing anything before and after the search term.
           // example: "John Snow Movies" if search term was snow, it would still grab "John Snow Movies" 
           string strSearchTerm = string.Format("%{0}%", searchTerm);

            // We use our cmd method from our DBCommands class again here to setup a new command with parameters
            // In this case the parameter will be the search term, if there is one
            // We set create a new DataTable object called dt which we set equal to the dt we return from 
            // the PerformCommand method in the class.
            DBCommands.cmd = new NpgsqlCommand(DBCommands.sql, DBCommands.con);
            DBCommands.cmd.Parameters.Clear();

            // you will notice the @ sign inside of the sql Select statment above in front of searchTerm.
            // This is how the AddWithValue() works. It will find searchTerm as the given parameter and set it 
            // to the value we pass in, in this case strSearchTerm
            DBCommands.cmd.Parameters.AddWithValue("searchTerm", strSearchTerm);

            DataTable dt = DBCommands.PerformCommand(DBCommands.cmd);

           
            // The rest below is just styling our Datagridview from the form
            

            DataGridView dgv1 = dbGrid;

            dgv1.MultiSelect = false;
            dgv1.AutoGenerateColumns = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv1.DataSource = dt;

            dgv1.Columns[0].HeaderText = "ID";
            dgv1.Columns[1].HeaderText = "First_Name";
            dgv1.Columns[2].HeaderText = "Last_Name";
            dgv1.Columns[3].HeaderText = "Job_Title";
            dgv1.Columns[4].HeaderText = "Work_Location";
            dgv1.Columns[5].HeaderText = "Years_In_Job";

            dgv1.Columns[0].Width = 120;
            dgv1.Columns[1].Width = 150;
            dgv1.Columns[2].Width = 150;
            dgv1.Columns[3].Width = 150;
            dgv1.Columns[4].Width = 150;
            dgv1.Columns[5].Width = 125;
        }

        /*
         * PostgreSQL requires us to execute after doing sql queries with a command and parameters 
         * and it gets lengthy to type the whole thing out.
         * So, instead, it is good practice to create an execute, or in this case executeCMD function
         *   so you just have to call executeCMD instead. This is like committing in other languages like GIT
         */
        private void executeCMD(string mySQL, string param)
        {
            DBCommands.cmd = new NpgsqlCommand(mySQL, DBCommands.con);
            addParameters(param);
            DBCommands.PerformCommand(DBCommands.cmd);
        }

        /*
         * Similar to the reason above, we create an addParameters function since we will be repeating commands
         *  that have to do with the firstname, lastname, and  many times when we Insert,Update,and Delete
         * This function lets our sql queries know that the columns we want to fill with values correspond to the given parameters
         */
        private void addParameters(string str)
        {
            if (str != "Delete")
            {
                DBCommands.cmd.Parameters.Clear();
                DBCommands.cmd.Parameters.AddWithValue("first_nm", firstnameBox.Text.Trim());
                DBCommands.cmd.Parameters.AddWithValue("last_nm", lastnameBox.Text.Trim());
                DBCommands.cmd.Parameters.AddWithValue("job_ttl", jobTitleBox.Text.Trim());
                DBCommands.cmd.Parameters.AddWithValue("work_location", workLocationBox.Text.Trim());

                // this portion here allows us to get an id from this.id we stored from our gridview
                // when we click on a certain row and use it to update or delete from that id
                if (str == "Update" && !string.IsNullOrEmpty(this.id))
                {
                    if (this.lastId != -1)
                    {
                        DBCommands.cmd.Parameters.AddWithValue("id", this.lastId);
                    }
                    else
                    {
                        DateTime currentTime = DateTime.Now;
                        DBCommands.cmd.Parameters.AddWithValue("id", this.id);
                        DBCommands.cmd.Parameters.AddWithValue("dtm", currentTime);
                    }
                }
                if (str == "Insert" && this.lastId != -1)
                {
                    DBCommands.cmd.Parameters.AddWithValue("id", this.lastId);
                    DBCommands.cmd.Parameters.AddWithValue("yrs_in_job", Int32.Parse(yrsBox.Text.Trim()));
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            loadData("");
        }

        /*
         *  This function is a simple show all records
         */
        private void allBtn_Click(object sender, EventArgs e)
        {
            resetForm();
            loadData("");
            searchLabel.Text = "Searching For: ALL ";
        }

        /*
         *  This function takes the search term from a user's input and grabs any records that match or contain the term in the database
         */
        private void searchBtn_Click(object sender, EventArgs e)
        {
            var searchTerm = searchBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {

                loadData(searchTerm);
                searchLabel.Text = $"Searching For: '{searchTerm.ToLower()}'";
            }
        }
        /*
         *  This function resets the layout of the form back to empty so the user can input/search new things.
         *  This function also closes all and any database connections for safety.
         *  We run this function after all operations to make sure the form is set nicely and the connections are closed.
         */
        private void resetForm()
        {
            searchBox.Text = "";
            firstnameBox.Text = "";
            lastnameBox.Text = "";
            jobTitleBox.Text = "";
            workLocationBox.Text = "";
            yrsBox.Text = "";
            searchLabel.Text = "Searching For: ";
            this.lastId = -1;
            DBCommands.con.Close();
        }

        /*
         * This function is used to get the ID from the most recently added Employee or most recently deleted employee
         */
        private int getId(string method = "Insert")
        {
            if (method == "Insert")
            {
                DBCommands.cmd = new NpgsqlCommand("SELECT id FROM users ORDER BY dtm DESC LIMIT 1", DBCommands.con);
                DBCommands.con.Open();
                using (var reader = DBCommands.cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return Int32.Parse(reader[0].ToString());
                    }
                }
                
            }
            if (method == "Update")
            {
                DBCommands.cmd = new NpgsqlCommand("SELECT id FROM users WHERE stat_cd = 'D' ORDER BY dtm DESC LIMIT 1",DBCommands.con);
                DBCommands.con.Open();
                using (var reader = DBCommands.cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return Int32.Parse(reader[0].ToString());
                    }
                }
            }
            return -1;
        }

        /*
         *  This function is used to check if there are any missing textboxes on the form. It will save time and redundancy
         */
        private bool missingField()
        {
            string[] list = { firstnameBox.Text.Trim(), lastnameBox.Text.Trim(), jobTitleBox.Text.Trim(),workLocationBox.Text.Trim(),yrsBox.Text.Trim() };
            for (int i=0; i<list.Length; i++)
            {
                if (String.IsNullOrEmpty(list[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         *  This is the logic behind adding a new record. We made a function so that it can be reused by any event handler that needs to create a new record.
         */
        private void Add()
        {
            // We make sure that the user inputs some values to the textboxes and  in order to add an entry
            if (missingField())
            {
                MessageBox.Show("One or more text fields are missing. Please make sure to fill out all textboxes", "Data Missing For Insert",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Here we use an INSERT statement using our parameters from addParameters function for 
            // @first_nm and @last_nm; @job_ttl, @work_location and @yrs_in_job
            // We do inserts for the users table and the job_details table
            try
            {
                DBCommands.sql = "INSERT INTO users (first_nm, last_nm) VALUES (@first_nm, @last_nm)";
                executeCMD(DBCommands.sql, "Insert");
                this.lastId = getId();
                DBCommands.sql = "INSERT INTO job_details (id,job_ttl,work_location,yrs_in_job) VALUES (@id,@job_ttl, @work_location, @yrs_in_job)";
                executeCMD(DBCommands.sql, "Insert");

            }
            catch (Exception err)
            {
                MessageBox.Show($"There Was A Problem Adding The New Records. Please Try Again. Error was: {err}", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /*
         *  The below event handlers are all named according to what they do.
         *  Theres the addBtn (adding), updateBtn (updating), delBtn (deleting), purgeBtn (purging), and undoBtn (undeleting)
         *  The logic to these events is all stored in the DBCommands Class for neater code and redundancy's sake
         */
        private void addBtn_Click(object sender, EventArgs e)
        {
            Add();
            loadData("");
            resetForm();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DBCommands.Update(dbGrid, this.id, executeCMD, missingField);
            loadData("");
            resetForm();

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DBCommands.softDelete(dbGrid, this.id, executeCMD);
            loadData("");
            resetForm();
        }


        private void purgeBtn_Click(object sender, EventArgs e)
        {
            DBCommands.Purge(executeCMD);
            loadData("");
            resetForm();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            this.lastId = getId("Update");
            DBCommands.UnDelete(this.lastId, executeCMD);
            loadData("");
            resetForm();

        }


        /*
         *  This is the event handler that allows a user to select a record that is displayed on the form from the database. 
         *  We will use this to gather information for the user to update, or delete a record
         */
        private void dbGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // we have to make sure that the event args e is actually selecting something from the user
            if (e.RowIndex != -1)
            {
                DataGridView dgv1 = dbGrid;

                // we grab the id for that row and convert it to a readable string to store in this.id for our query 
                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                
                // this bit of code auto fills the textboxes with the selected entries data so the user doesn't have to maually
                //   type it 
                firstnameBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                lastnameBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);
                jobTitleBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[3].Value);
                workLocationBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[4].Value);
                yrsBox.Text = Convert.ToString(dgv1.CurrentRow.Cells[5].Value);

                searchLabel.Text = "Selected Employee: " + firstnameBox.Text.Trim() + " " + lastnameBox.Text.Trim();
            }
        }


        /*
         *  The below eventhandlers are for the menu items. The logic follows basically the same pattern as the button events, and can be found in the DBCommands class as well.
         */
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
            loadData("");
            resetForm();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchTerm = Interaction.InputBox("Input The Name of The Employee To Search For.", "Open Employee Record");
            if (!string.IsNullOrEmpty(searchTerm))
            {
                loadData(searchTerm);
                searchLabel.Text = $"Searching For: '{searchTerm.ToLower()}'";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want To Save Current Updates To Selected Employee?", "Save Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                DBCommands.Update(dbGrid, this.id, executeCMD, missingField);
                loadData("");
                resetForm();
            }
            else
            {
                MessageBox.Show("Updates Were Not Saved", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData("");
                resetForm();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Delete The Selected Employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                DBCommands.softDelete(dbGrid, this.id, executeCMD);
                loadData("");
                resetForm();
            }
            else
            {
                MessageBox.Show("Employee Was Not Deleted", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData("");
                resetForm();
            }
        }

        private void undeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lastId = getId("Update");
            DBCommands.UnDelete(this.lastId, executeCMD);
            loadData("");
            resetForm();
        }

        private void purgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBCommands.Purge(executeCMD);
            loadData("");
            resetForm();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Save Current Updates To Selected Employee?", "Save Updates", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                DBCommands.Update(dbGrid, this.id, executeCMD, missingField);
                loadData("");
                resetForm();
            }
            else
            {
                MessageBox.Show("Updates Were Not Saved", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData("");
                resetForm();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

