namespace Diagnostic
{
    partial class UCDoctorOperation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.txtDoctorId = new MetroFramework.Controls.MetroTextBox();
            this.btnUpdatePatient = new MetroFramework.Controls.MetroButton();
            this.txtFees = new MetroFramework.Controls.MetroTextBox();
            this.txtSpecialization = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.pnlAdd = new CuoreUI.Controls.cuiPanel();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.dvgDoctor = new MetroFramework.Controls.MetroGrid();
            this.pnlGrideViewPatient = new MetroFramework.Controls.MetroPanel();
            this.pnlRegisterPatient = new MetroFramework.Controls.MetroPanel();
            this.pnlAdminAddTest = new CuoreUI.Controls.cuiGradientPanel();
            this.txtSearch = new CuoreUI.Controls.cuiTextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.newDiagnosticDataSet = new Diagnostic.NewDiagnosticDataSet();
            this.newDiagnosticDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDoctor)).BeginInit();
            this.pnlGrideViewPatient.SuspendLayout();
            this.pnlRegisterPatient.SuspendLayout();
            this.pnlAdminAddTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newDiagnosticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDiagnosticDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.BackgroundImage = global::Diagnostic.Properties.Resources.Search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(1040, 69);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 64);
            this.btnSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSearch.UseCustomBackColor = true;
            this.btnSearch.UseCustomForeColor = true;
            this.btnSearch.UseSelectable = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(225, 78);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 51);
            this.btnEdit.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEdit.UseCustomBackColor = true;
            this.btnEdit.UseCustomForeColor = true;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(32, 78);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 51);
            this.btnAdd.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseCustomForeColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtDoctorId.CustomButton.Image = null;
            this.txtDoctorId.CustomButton.Location = new System.Drawing.Point(446, 2);
            this.txtDoctorId.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDoctorId.CustomButton.Name = "";
            this.txtDoctorId.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtDoctorId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDoctorId.CustomButton.TabIndex = 1;
            this.txtDoctorId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDoctorId.CustomButton.UseSelectable = true;
            this.txtDoctorId.CustomButton.Visible = false;
            this.txtDoctorId.Lines = new string[0];
            this.txtDoctorId.Location = new System.Drawing.Point(54, 260);
            this.txtDoctorId.Margin = new System.Windows.Forms.Padding(0);
            this.txtDoctorId.MaxLength = 32767;
            this.txtDoctorId.Multiline = true;
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.PasswordChar = '\0';
            this.txtDoctorId.PromptText = "Doctor ID";
            this.txtDoctorId.ReadOnly = true;
            this.txtDoctorId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDoctorId.SelectedText = "";
            this.txtDoctorId.SelectionLength = 0;
            this.txtDoctorId.SelectionStart = 0;
            this.txtDoctorId.ShortcutsEnabled = true;
            this.txtDoctorId.Size = new System.Drawing.Size(488, 44);
            this.txtDoctorId.Style = MetroFramework.MetroColorStyle.White;
            this.txtDoctorId.TabIndex = 13;
            this.txtDoctorId.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDoctorId.UseCustomBackColor = true;
            this.txtDoctorId.UseCustomForeColor = true;
            this.txtDoctorId.UseSelectable = true;
            this.txtDoctorId.UseStyleColors = true;
            this.txtDoctorId.WaterMark = "Doctor ID";
            this.txtDoctorId.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtDoctorId.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnUpdatePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdatePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePatient.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnUpdatePatient.ForeColor = System.Drawing.Color.Black;
            this.btnUpdatePatient.Location = new System.Drawing.Point(578, 78);
            this.btnUpdatePatient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(135, 48);
            this.btnUpdatePatient.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUpdatePatient.TabIndex = 12;
            this.btnUpdatePatient.Text = "Update";
            this.btnUpdatePatient.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnUpdatePatient.UseCustomBackColor = true;
            this.btnUpdatePatient.UseCustomForeColor = true;
            this.btnUpdatePatient.UseSelectable = true;
            this.btnUpdatePatient.Click += new System.EventHandler(this.btnUpdatePatient_Click);
            // 
            // txtFees
            // 
            this.txtFees.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtFees.CustomButton.Image = null;
            this.txtFees.CustomButton.Location = new System.Drawing.Point(446, 2);
            this.txtFees.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFees.CustomButton.Name = "";
            this.txtFees.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtFees.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFees.CustomButton.TabIndex = 1;
            this.txtFees.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFees.CustomButton.UseSelectable = true;
            this.txtFees.CustomButton.Visible = false;
            this.txtFees.Lines = new string[0];
            this.txtFees.Location = new System.Drawing.Point(54, 679);
            this.txtFees.Margin = new System.Windows.Forms.Padding(0);
            this.txtFees.MaxLength = 32767;
            this.txtFees.Multiline = true;
            this.txtFees.Name = "txtFees";
            this.txtFees.PasswordChar = '\0';
            this.txtFees.PromptText = "Fees";
            this.txtFees.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFees.SelectedText = "";
            this.txtFees.SelectionLength = 0;
            this.txtFees.SelectionStart = 0;
            this.txtFees.ShortcutsEnabled = true;
            this.txtFees.Size = new System.Drawing.Size(488, 44);
            this.txtFees.Style = MetroFramework.MetroColorStyle.White;
            this.txtFees.TabIndex = 2;
            this.txtFees.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFees.UseCustomBackColor = true;
            this.txtFees.UseCustomForeColor = true;
            this.txtFees.UseSelectable = true;
            this.txtFees.UseStyleColors = true;
            this.txtFees.WaterMark = "Fees";
            this.txtFees.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtFees.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtSpecialization.CustomButton.Image = null;
            this.txtSpecialization.CustomButton.Location = new System.Drawing.Point(446, 2);
            this.txtSpecialization.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSpecialization.CustomButton.Name = "";
            this.txtSpecialization.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtSpecialization.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSpecialization.CustomButton.TabIndex = 1;
            this.txtSpecialization.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSpecialization.CustomButton.UseSelectable = true;
            this.txtSpecialization.CustomButton.Visible = false;
            this.txtSpecialization.Lines = new string[0];
            this.txtSpecialization.Location = new System.Drawing.Point(54, 545);
            this.txtSpecialization.Margin = new System.Windows.Forms.Padding(0);
            this.txtSpecialization.MaxLength = 32767;
            this.txtSpecialization.Multiline = true;
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.PasswordChar = '\0';
            this.txtSpecialization.PromptText = "Specializaation";
            this.txtSpecialization.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSpecialization.SelectedText = "";
            this.txtSpecialization.SelectionLength = 0;
            this.txtSpecialization.SelectionStart = 0;
            this.txtSpecialization.ShortcutsEnabled = true;
            this.txtSpecialization.Size = new System.Drawing.Size(488, 44);
            this.txtSpecialization.Style = MetroFramework.MetroColorStyle.White;
            this.txtSpecialization.TabIndex = 1;
            this.txtSpecialization.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSpecialization.UseCustomBackColor = true;
            this.txtSpecialization.UseCustomForeColor = true;
            this.txtSpecialization.UseSelectable = true;
            this.txtSpecialization.UseStyleColors = true;
            this.txtSpecialization.WaterMark = "Specializaation";
            this.txtSpecialization.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtSpecialization.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(446, 2);
            this.txtName.CustomButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(54, 395);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.MaxLength = 32767;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Doctor Name";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(488, 44);
            this.txtName.Style = MetroFramework.MetroColorStyle.White;
            this.txtName.TabIndex = 0;
            this.txtName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.UseCustomBackColor = true;
            this.txtName.UseCustomForeColor = true;
            this.txtName.UseSelectable = true;
            this.txtName.UseStyleColors = true;
            this.txtName.WaterMark = "Doctor Name";
            this.txtName.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtName.WaterMarkFont = new System.Drawing.Font("Agency FB", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.LightBlue;
            this.pnlAdd.Controls.Add(this.txtDoctorId);
            this.pnlAdd.Controls.Add(this.btnAddTest);
            this.pnlAdd.Controls.Add(this.cuiLabel1);
            this.pnlAdd.Controls.Add(this.txtFees);
            this.pnlAdd.Controls.Add(this.txtSpecialization);
            this.pnlAdd.Controls.Add(this.txtName);
            this.pnlAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdd.Location = new System.Drawing.Point(1107, 3);
            this.pnlAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.OutlineThickness = 1F;
            this.pnlAdd.PanelColor = System.Drawing.Color.LightBlue;
            this.pnlAdd.PanelOutlineColor = System.Drawing.Color.LightBlue;
            this.pnlAdd.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlAdd.Size = new System.Drawing.Size(633, 1034);
            this.pnlAdd.TabIndex = 18;
            // 
            // btnAddTest
            // 
            this.btnAddTest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddTest.Location = new System.Drawing.Point(178, 770);
            this.btnAddTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(212, 59);
            this.btnAddTest.TabIndex = 10;
            this.btnAddTest.Text = "  SAVE";
            this.btnAddTest.UseVisualStyleBackColor = false;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Add\\ Doctor";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(76, 133);
            this.cuiLabel1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(390, 41);
            this.cuiLabel1.TabIndex = 7;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(398, 78);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 51);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseCustomForeColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dvgDoctor
            // 
            this.dvgDoctor.AllowUserToAddRows = false;
            this.dvgDoctor.AllowUserToDeleteRows = false;
            this.dvgDoctor.AllowUserToResizeRows = false;
            this.dvgDoctor.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dvgDoctor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvgDoctor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvgDoctor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDoctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dvgDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgDoctor.DefaultCellStyle = dataGridViewCellStyle8;
            this.dvgDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgDoctor.EnableHeadersVisualStyles = false;
            this.dvgDoctor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dvgDoctor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvgDoctor.Location = new System.Drawing.Point(0, 0);
            this.dvgDoctor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dvgDoctor.Name = "dvgDoctor";
            this.dvgDoctor.ReadOnly = true;
            this.dvgDoctor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgDoctor.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dvgDoctor.RowHeadersWidth = 82;
            this.dvgDoctor.RowTemplate.Height = 33;
            this.dvgDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgDoctor.Size = new System.Drawing.Size(1112, 891);
            this.dvgDoctor.TabIndex = 17;
            this.dvgDoctor.DoubleClick += new System.EventHandler(this.dvgTest_DoubleClick);
            // 
            // pnlGrideViewPatient
            // 
            this.pnlGrideViewPatient.Controls.Add(this.dvgDoctor);
            this.pnlGrideViewPatient.HorizontalScrollbarBarColor = true;
            this.pnlGrideViewPatient.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlGrideViewPatient.HorizontalScrollbarSize = 9;
            this.pnlGrideViewPatient.Location = new System.Drawing.Point(-2, 167);
            this.pnlGrideViewPatient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlGrideViewPatient.Name = "pnlGrideViewPatient";
            this.pnlGrideViewPatient.Size = new System.Drawing.Size(1112, 891);
            this.pnlGrideViewPatient.TabIndex = 19;
            this.pnlGrideViewPatient.VerticalScrollbarBarColor = true;
            this.pnlGrideViewPatient.VerticalScrollbarHighlightOnWheel = false;
            this.pnlGrideViewPatient.VerticalScrollbarSize = 10;
            // 
            // pnlRegisterPatient
            // 
            this.pnlRegisterPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pnlRegisterPatient.Controls.Add(this.pnlAdminAddTest);
            this.pnlRegisterPatient.HorizontalScrollbarBarColor = true;
            this.pnlRegisterPatient.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlRegisterPatient.HorizontalScrollbarSize = 9;
            this.pnlRegisterPatient.Location = new System.Drawing.Point(0, 16);
            this.pnlRegisterPatient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlRegisterPatient.Name = "pnlRegisterPatient";
            this.pnlRegisterPatient.Size = new System.Drawing.Size(1736, 1238);
            this.pnlRegisterPatient.TabIndex = 9;
            this.pnlRegisterPatient.VerticalScrollbarBarColor = true;
            this.pnlRegisterPatient.VerticalScrollbarHighlightOnWheel = false;
            this.pnlRegisterPatient.VerticalScrollbarSize = 10;
            // 
            // pnlAdminAddTest
            // 
            this.pnlAdminAddTest.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlAdminAddTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAdminAddTest.Controls.Add(this.pnlGrideViewPatient);
            this.pnlAdminAddTest.Controls.Add(this.pnlAdd);
            this.pnlAdminAddTest.Controls.Add(this.btnSearch);
            this.pnlAdminAddTest.Controls.Add(this.btnUpdatePatient);
            this.pnlAdminAddTest.Controls.Add(this.txtSearch);
            this.pnlAdminAddTest.Controls.Add(this.btnEdit);
            this.pnlAdminAddTest.Controls.Add(this.btnDelete);
            this.pnlAdminAddTest.Controls.Add(this.btnAdd);
            this.pnlAdminAddTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdminAddTest.GradientAngle = 0F;
            this.pnlAdminAddTest.Location = new System.Drawing.Point(4, 3);
            this.pnlAdminAddTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlAdminAddTest.Name = "pnlAdminAddTest";
            this.pnlAdminAddTest.OutlineThickness = 1F;
            this.pnlAdminAddTest.PanelColor1 = System.Drawing.Color.LightSkyBlue;
            this.pnlAdminAddTest.PanelColor2 = System.Drawing.Color.Transparent;
            this.pnlAdminAddTest.PanelOutlineColor1 = System.Drawing.Color.PaleTurquoise;
            this.pnlAdminAddTest.PanelOutlineColor2 = System.Drawing.Color.LightBlue;
            this.pnlAdminAddTest.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlAdminAddTest.Size = new System.Drawing.Size(1732, 1268);
            this.pnlAdminAddTest.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtSearch.Content = "";
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusBackgroundColor = System.Drawing.Color.White;
            this.txtSearch.FocusImageTint = System.Drawing.Color.White;
            this.txtSearch.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Image = null;
            this.txtSearch.ImageExpand = new System.Drawing.Point(0, 0);
            this.txtSearch.ImageOffset = new System.Drawing.Point(0, 0);
            this.txtSearch.Location = new System.Drawing.Point(756, 69);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.NormalImageTint = System.Drawing.Color.White;
            this.txtSearch.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtSearch.Padding = new System.Windows.Forms.Padding(29, 18, 29, 0);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.SystemColors.WindowText;
            this.txtSearch.PlaceholderText = "Search With Name";
            this.txtSearch.Rounding = new System.Windows.Forms.Padding(20);
            this.txtSearch.Size = new System.Drawing.Size(343, 64);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextOffset = new System.Drawing.Size(0, 0);
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch.ContentChanged += new System.EventHandler(this.txtSearch_ContentChanged);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // newDiagnosticDataSet
            // 
            this.newDiagnosticDataSet.DataSetName = "NewDiagnosticDataSet";
            this.newDiagnosticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newDiagnosticDataSetBindingSource
            // 
            this.newDiagnosticDataSetBindingSource.DataSource = this.newDiagnosticDataSet;
            this.newDiagnosticDataSetBindingSource.Position = 0;
            // 
            // UCDoctorOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRegisterPatient);
            this.Name = "UCDoctorOperation";
            this.Size = new System.Drawing.Size(1736, 1271);
            this.pnlAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDoctor)).EndInit();
            this.pnlGrideViewPatient.ResumeLayout(false);
            this.pnlRegisterPatient.ResumeLayout(false);
            this.pnlAdminAddTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newDiagnosticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDiagnosticDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtDoctorId;
        private MetroFramework.Controls.MetroButton btnUpdatePatient;
        private MetroFramework.Controls.MetroTextBox txtFees;
        private MetroFramework.Controls.MetroTextBox txtSpecialization;
        private MetroFramework.Controls.MetroTextBox txtName;
        private CuoreUI.Controls.cuiPanel pnlAdd;
        private System.Windows.Forms.Button btnAddTest;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroGrid dvgDoctor;
        private MetroFramework.Controls.MetroPanel pnlGrideViewPatient;
        private MetroFramework.Controls.MetroPanel pnlRegisterPatient;
        private CuoreUI.Controls.cuiGradientPanel pnlAdminAddTest;
        private CuoreUI.Controls.cuiTextBox txtSearch;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private NewDiagnosticDataSet newDiagnosticDataSet;
        private System.Windows.Forms.BindingSource newDiagnosticDataSetBindingSource;
    }
}
