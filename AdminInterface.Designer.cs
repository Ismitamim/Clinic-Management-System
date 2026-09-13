namespace Diagnostic
{
    partial class AdminInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterface));
            this.lblTest = new System.Windows.Forms.Label();
            this.lblAdminProduct = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblAdminUsers = new System.Windows.Forms.Label();
            this.lblAdminDashboard = new System.Windows.Forms.Label();
            this.btnLogOut = new CuoreUI.Controls.cuiButton();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.pnlUserControl = new CuoreUI.Controls.cuiGradientPanel();
            this.cuiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            resources.ApplyResources(this.lblTest, "lblTest");
            this.lblTest.BackColor = System.Drawing.Color.Transparent;
            this.lblTest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTest.Name = "lblTest";
            this.lblTest.Click += new System.EventHandler(this.lblTest_Click);
            // 
            // lblAdminProduct
            // 
            resources.ApplyResources(this.lblAdminProduct, "lblAdminProduct");
            this.lblAdminProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAdminProduct.Name = "lblAdminProduct";
            this.lblAdminProduct.Click += new System.EventHandler(this.lblAdminProduct_Click);
            // 
            // lblWelcome
            // 
            resources.ApplyResources(this.lblWelcome, "lblWelcome");
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAdminUsers
            // 
            resources.ApplyResources(this.lblAdminUsers, "lblAdminUsers");
            this.lblAdminUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAdminUsers.Name = "lblAdminUsers";
            this.lblAdminUsers.Click += new System.EventHandler(this.lblAdminUsers_Click);
            // 
            // lblAdminDashboard
            // 
            resources.ApplyResources(this.lblAdminDashboard, "lblAdminDashboard");
            this.lblAdminDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAdminDashboard.Name = "lblAdminDashboard";
            this.lblAdminDashboard.Click += new System.EventHandler(this.lblAdminDashboard_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.CheckButton = false;
            this.btnLogOut.Checked = false;
            this.btnLogOut.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLogOut.CheckedForeColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedImageTint = System.Drawing.Color.White;
            this.btnLogOut.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLogOut.Content = "Log Out";
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            resources.ApplyResources(this.btnLogOut, "btnLogOut");
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.HoverBackground = System.Drawing.Color.White;
            this.btnLogOut.HoverForeColor = System.Drawing.Color.Black;
            this.btnLogOut.HoverImageTint = System.Drawing.Color.White;
            this.btnLogOut.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.Image = null;
            this.btnLogOut.ImageAutoCenter = true;
            this.btnLogOut.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnLogOut.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.NormalBackground = System.Drawing.Color.Transparent;
            this.btnLogOut.NormalForeColor = System.Drawing.Color.Black;
            this.btnLogOut.NormalImageTint = System.Drawing.Color.White;
            this.btnLogOut.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.OutlineThickness = 1F;
            this.btnLogOut.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLogOut.PressedImageTint = System.Drawing.Color.White;
            this.btnLogOut.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogOut.Rounding = new System.Windows.Forms.Padding(8);
            this.btnLogOut.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLogOut.TextOffset = new System.Drawing.Point(0, 0);
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cuiPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuiPanel1.Controls.Add(this.btnLogOut);
            this.cuiPanel1.Controls.Add(this.lblAdminDashboard);
            this.cuiPanel1.Controls.Add(this.lblAdminUsers);
            this.cuiPanel1.Controls.Add(this.lblWelcome);
            this.cuiPanel1.Controls.Add(this.lblAdminProduct);
            this.cuiPanel1.Controls.Add(this.lblTest);
            resources.ApplyResources(this.cuiPanel1, "cuiPanel1");
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(8);
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.GradientAngle = 0F;
            resources.ApplyResources(this.pnlUserControl, "pnlUserControl");
            this.pnlUserControl.Name = "pnlUserControl";
            this.pnlUserControl.OutlineThickness = 1F;
            this.pnlUserControl.PanelColor1 = System.Drawing.Color.Ivory;
            this.pnlUserControl.PanelColor2 = System.Drawing.Color.Transparent;
            this.pnlUserControl.PanelOutlineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.pnlUserControl.PanelOutlineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.pnlUserControl.Rounding = new System.Windows.Forms.Padding(8);
            // 
            // AdminInterface
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlUserControl);
            this.Controls.Add(this.cuiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "AdminInterface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminInterface_FormClosing);
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblAdminProduct;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblAdminUsers;
        private System.Windows.Forms.Label lblAdminDashboard;
        private CuoreUI.Controls.cuiButton btnLogOut;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiGradientPanel pnlUserControl;
    }
}