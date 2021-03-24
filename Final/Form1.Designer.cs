
namespace Final
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dbGrid = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDS = new Final.UsersDS();
            this.searchLabel = new System.Windows.Forms.Label();
            this.usersTableAdapter = new Final.UsersDSTableAdapters.usersTableAdapter();
            this.addBtn = new System.Windows.Forms.Button();
            this.allBtn = new System.Windows.Forms.Button();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobdetailsDS = new Final.jobdetailsDS();
            this.jobdetailsDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesjobdetailsDS = new Final.employeesjobdetailsDS();
            this.employeesjobdetailsDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.job_detailsTableAdapter = new Final.employeesjobdetailsDSTableAdapters.job_detailsTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new Final.employeesjobdetailsDSTableAdapters.usersTableAdapter();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.jobTitleBox = new System.Windows.Forms.TextBox();
            this.workLocationBox = new System.Windows.Forms.TextBox();
            this.yrsBox = new System.Windows.Forms.TextBox();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.jobTitleLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.workLocationLabel = new System.Windows.Forms.Label();
            this.yrsLabel = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.purgeBtn = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDS)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobdetailsDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobdetailsDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesjobdetailsDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesjobdetailsDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dbGrid
            // 
            this.dbGrid.AllowUserToAddRows = false;
            this.dbGrid.AllowUserToDeleteRows = false;
            this.dbGrid.AutoGenerateColumns = false;
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.DataSource = this.bindingSource1;
            this.dbGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dbGrid.Location = new System.Drawing.Point(0, 370);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.ReadOnly = true;
            this.dbGrid.RowHeadersWidth = 62;
            this.dbGrid.RowTemplate.Height = 28;
            this.dbGrid.Size = new System.Drawing.Size(1361, 480);
            this.dbGrid.TabIndex = 0;
            this.dbGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGrid_CellClick);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.usersDS;
            // 
            // usersDS
            // 
            this.usersDS.DataSetName = "UsersDS";
            this.usersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(37, 229);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(219, 36);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Searching For: ";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(813, 206);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(133, 59);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // allBtn
            // 
            this.allBtn.Location = new System.Drawing.Point(735, 304);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(126, 51);
            this.allBtn.TabIndex = 3;
            this.allBtn.Text = "Show All";
            this.allBtn.UseVisualStyleBackColor = true;
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(301, 79);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(245, 26);
            this.lastnameBox.TabIndex = 4;
            // 
            // firstnameBox
            // 
            this.firstnameBox.Location = new System.Drawing.Point(12, 79);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.Size = new System.Drawing.Size(245, 26);
            this.firstnameBox.TabIndex = 5;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(276, 304);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(129, 51);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(12, 310);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(244, 26);
            this.searchBox.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1361, 33);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.undeleteToolStripMenuItem,
            this.purgeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // undeleteToolStripMenuItem
            // 
            this.undeleteToolStripMenuItem.Name = "undeleteToolStripMenuItem";
            this.undeleteToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.undeleteToolStripMenuItem.Text = "Undelete";
            this.undeleteToolStripMenuItem.Click += new System.EventHandler(this.undeleteToolStripMenuItem_Click);
            // 
            // purgeToolStripMenuItem
            // 
            this.purgeToolStripMenuItem.Name = "purgeToolStripMenuItem";
            this.purgeToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.purgeToolStripMenuItem.Text = "Purge";
            this.purgeToolStripMenuItem.Click += new System.EventHandler(this.purgeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 32);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(151, 34);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // jobdetailsDS
            // 
            this.jobdetailsDS.DataSetName = "jobdetailsDS";
            this.jobdetailsDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobdetailsDSBindingSource
            // 
            this.jobdetailsDSBindingSource.DataSource = this.jobdetailsDS;
            this.jobdetailsDSBindingSource.Position = 0;
            // 
            // employeesjobdetailsDS
            // 
            this.employeesjobdetailsDS.DataSetName = "employeesjobdetailsDS";
            this.employeesjobdetailsDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesjobdetailsDSBindingSource
            // 
            this.employeesjobdetailsDSBindingSource.DataSource = this.employeesjobdetailsDS;
            this.employeesjobdetailsDSBindingSource.Position = 0;
            // 
            // jobdetailsBindingSource
            // 
            this.jobdetailsBindingSource.DataMember = "job_details";
            this.jobdetailsBindingSource.DataSource = this.employeesjobdetailsDSBindingSource;
            // 
            // job_detailsTableAdapter
            // 
            this.job_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.employeesjobdetailsDSBindingSource;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "users";
            this.usersBindingSource2.DataSource = this.employeesjobdetailsDSBindingSource;
            // 
            // usersBindingSource3
            // 
            this.usersBindingSource3.DataMember = "users";
            this.usersBindingSource3.DataSource = this.employeesjobdetailsDSBindingSource;
            // 
            // jobTitleBox
            // 
            this.jobTitleBox.Location = new System.Drawing.Point(13, 159);
            this.jobTitleBox.Name = "jobTitleBox";
            this.jobTitleBox.Size = new System.Drawing.Size(245, 26);
            this.jobTitleBox.TabIndex = 10;
            // 
            // workLocationBox
            // 
            this.workLocationBox.Location = new System.Drawing.Point(301, 159);
            this.workLocationBox.Name = "workLocationBox";
            this.workLocationBox.Size = new System.Drawing.Size(245, 26);
            this.workLocationBox.TabIndex = 9;
            // 
            // yrsBox
            // 
            this.yrsBox.Location = new System.Drawing.Point(582, 159);
            this.yrsBox.Name = "yrsBox";
            this.yrsBox.Size = new System.Drawing.Size(245, 26);
            this.yrsBox.TabIndex = 11;
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLabel.Location = new System.Drawing.Point(8, 46);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(106, 25);
            this.fnameLabel.TabIndex = 13;
            this.fnameLabel.Text = "First Name";
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobTitleLabel.Location = new System.Drawing.Point(8, 121);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(87, 25);
            this.jobTitleLabel.TabIndex = 14;
            this.jobTitleLabel.Text = "Job Title";
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLabel.Location = new System.Drawing.Point(296, 46);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(106, 25);
            this.lnameLabel.TabIndex = 15;
            this.lnameLabel.Text = "Last Name";
            // 
            // workLocationLabel
            // 
            this.workLocationLabel.AutoSize = true;
            this.workLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workLocationLabel.Location = new System.Drawing.Point(296, 121);
            this.workLocationLabel.Name = "workLocationLabel";
            this.workLocationLabel.Size = new System.Drawing.Size(138, 25);
            this.workLocationLabel.TabIndex = 16;
            this.workLocationLabel.Text = "Work Location";
            // 
            // yrsLabel
            // 
            this.yrsLabel.AutoSize = true;
            this.yrsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yrsLabel.Location = new System.Drawing.Point(577, 121);
            this.yrsLabel.Name = "yrsLabel";
            this.yrsLabel.Size = new System.Drawing.Size(122, 25);
            this.yrsLabel.TabIndex = 17;
            this.yrsLabel.Text = "Years In Job";
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(422, 304);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(133, 51);
            this.delBtn.TabIndex = 18;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(977, 206);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(133, 59);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // purgeBtn
            // 
            this.purgeBtn.Location = new System.Drawing.Point(1062, 307);
            this.purgeBtn.Name = "purgeBtn";
            this.purgeBtn.Size = new System.Drawing.Size(133, 51);
            this.purgeBtn.TabIndex = 20;
            this.purgeBtn.Text = "Purge";
            this.purgeBtn.UseVisualStyleBackColor = true;
            this.purgeBtn.Click += new System.EventHandler(this.purgeBtn_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(1216, 307);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(133, 51);
            this.cmdExit.TabIndex = 21;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.Location = new System.Drawing.Point(582, 304);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(133, 51);
            this.undoBtn.TabIndex = 22;
            this.undoBtn.Text = "UnDelete";
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 850);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.undoBtn);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.purgeBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.yrsLabel);
            this.Controls.Add(this.workLocationLabel);
            this.Controls.Add(this.lnameLabel);
            this.Controls.Add(this.jobTitleLabel);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.yrsBox);
            this.Controls.Add(this.jobTitleBox);
            this.Controls.Add(this.workLocationBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.firstnameBox);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.allBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.dbGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Employee Records";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDS)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobdetailsDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobdetailsDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesjobdetailsDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesjobdetailsDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbGrid;
        private System.Windows.Forms.Label searchLabel;
        private UsersDS usersDS;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private UsersDSTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button allBtn;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.TextBox firstnameBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.BindingSource employeesjobdetailsDSBindingSource;
        private employeesjobdetailsDS employeesjobdetailsDS;
        private jobdetailsDS jobdetailsDS;
        private System.Windows.Forms.BindingSource jobdetailsDSBindingSource;
        private System.Windows.Forms.BindingSource jobdetailsBindingSource;
        private employeesjobdetailsDSTableAdapters.job_detailsTableAdapter job_detailsTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private employeesjobdetailsDSTableAdapters.usersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.BindingSource usersBindingSource3;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox jobTitleBox;
        private System.Windows.Forms.TextBox workLocationBox;
        private System.Windows.Forms.TextBox yrsBox;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label jobTitleLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Label workLocationLabel;
        private System.Windows.Forms.Label yrsLabel;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button purgeBtn;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
    }
}

