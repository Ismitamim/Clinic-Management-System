using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagnostic
{
    public partial class UCDoctorOperation : UserControl
    {

        private DataAccess Da { get; set; }

        public UCDoctorOperation()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            //this.dvgTest.ClearSelection();
            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        private void PopulateGridView(string sql = "select * from Doctor;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dvgDoctor.AutoGenerateColumns = true;
            this.dvgDoctor.DataSource = ds.Tables[0];
        }


        private void ClearAll()
        {
            this.txtDoctorId.Clear();
            this.txtName.Clear();
            this.txtSpecialization.Clear();
            this.txtFees.Clear();
            this.txtSearch.Text = "";

            this.dvgDoctor.ClearSelection();
            this.AutoIdGenerate();
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtName.Text) || string.IsNullOrEmpty(this.txtSpecialization.Text))
                return false;
            double price;
            if (!double.TryParse(this.txtFees.Text, out price))
            {
                return false;
            }
            else return true;
        }



        private void AutoIdGenerate()
        {
            var query = "select max(Id) from Doctor;";
            var dt = this.Da.ExecuteQueryTable(query);
            var oldId = dt.Rows[0][0].ToString();
            var s = oldId.Split('-');
            var temp = Convert.ToInt32(s[1]);
            var newId = "D-" + (++temp).ToString("d3");
            this.txtDoctorId.Text = newId;
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {

            this.PopulateGridView();
            this.ClearAll();
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {

            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the fields properly.");
                    return;
                }

                var query = "select * from Doctor where ID ='" + this.txtDoctorId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {

                    var sql = @"update Doctor
                                set Name = '" + this.txtName.Text + @"',
                                SPECIALIZATION = '" + this.txtSpecialization.Text + @"',
                               FEES = " + this.txtFees.Text + @"
                                where ID = '" + this.txtDoctorId.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Doctor Information has been updated");
                    else MessageBox.Show("Doctor information hasn't been updated");
                }
                else
                {

                    var sql = "insert into Doctor values('" + this.txtDoctorId.Text + "', '" + this.txtName.Text + "', '" + this.txtSpecialization.Text + "', " + this.txtFees.Text + ");";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Doctor has been Added");
                    else
                        MessageBox.Show("Doctor hasn't been added");

                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has Occured: " + exc.Message);
            }

        }

        private void dvgTest_DoubleClick(object sender, EventArgs e)
        {

            this.txtDoctorId.Text = this.dvgDoctor.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dvgDoctor.CurrentRow.Cells[1].Value.ToString();
            this.txtSpecialization.Text = this.dvgDoctor.CurrentRow.Cells[2].Value.ToString();
            this.txtFees.Text = this.dvgDoctor.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.dvgDoctor.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dvgDoctor.CurrentRow.Cells[0].Value.ToString();
                var name = this.dvgDoctor.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from Doctor where Id = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("This Doctor hasn't been deleted");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.AutoIdGenerate();
            this.ClearAll();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            this.txtDoctorId.Text = this.dvgDoctor.CurrentRow.Cells[0].Value.ToString();
            this.txtName.Text = this.dvgDoctor.CurrentRow.Cells[1].Value.ToString();
            this.txtSpecialization.Text = this.dvgDoctor.CurrentRow.Cells[2].Value.ToString();
            this.txtFees.Text = this.dvgDoctor.CurrentRow.Cells[3].Value.ToString();

        }

        private void txtSearch_ContentChanged(object sender, EventArgs e)
        {

            try
            {

                string sql = $"SELECT * FROM [Doctor] WHERE Name like '%{this.txtSearch.contentTextField.Text.Replace("'", "''")}%'";

                var ds = this.Da.ExecuteQuery(sql);
                dvgDoctor.AutoGenerateColumns = false;
                dvgDoctor.DataSource = ds.Tables[0];

            }

            catch (Exception exc)
            {
                MessageBox.Show("Try Again in proper way");
            }
        }
    }
}
