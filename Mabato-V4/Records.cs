using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Mabato_V4
{
    public partial class Records : MaterialSkin.Controls.MaterialForm
    {

        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseMB.mdf;Integrated Security=True";
        private SqlCommand sql_cmd;
        private DataTable sqlDT = new DataTable();
        private DataSet sqlDS = new DataSet();
        private string txtQuery;
        
        public Records()
        {
            InitializeComponent();
        }
        string lrn = string.Empty;
        string returning = string.Empty;
        private void Records_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseMBDataSet2.StudentsRecord' table. You can move, or remove it, as needed.
            this.studentsRecordTableAdapter.Fill(this.databaseMBDataSet2.StudentsRecord);
          


        }

   



        private void Edit(bool value)
        {
           
          
            txtDOB.Enabled = value;
            txtGender.Enabled = value;
            txtIndi.Enabled = value;
            txtFirstname.Enabled = value;
            txtLastname.Enabled = value;
            txtLrnNo.Enabled = value;
            txtAddress.Enabled = value;
            txtZipcode.Enabled = value;




        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                databaseMBDataSet2.StudentsRecord.AddStudentsRecordRow(databaseMBDataSet2.StudentsRecord.NewStudentsRecordRow());
                studentsRecordBindingSource.MoveLast();
                txtSearch.Focus();

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                databaseMBDataSet2.StudentsRecord.RejectChanges();
                
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
          


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            studentsRecordBindingSource.ResetBindings(false);
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                studentsRecordBindingSource.EndEdit();
                studentsRecordTableAdapter.Update(databaseMBDataSet2.StudentsRecord);
                studentsRecordDataGridView.Refresh();
                MessageBox.Show("Data is saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                databaseMBDataSet2.StudentsRecord.RejectChanges();
            }
        }

        private void bunifuCustomDataGrid1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13) // 13 is enter
            {
                if (MessageBox.Show("Are you sure you want to delete record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                    DialogResult.Yes)
                    studentsRecordBindingSource.RemoveCurrent();
            }
        }

        private void Datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                  DialogResult.Yes)
                studentsRecordBindingSource.RemoveCurrent();
        }

        private void BtnLoadRef_Click(object sender, EventArgs e)
        {
            
        }

        private void studentsRecordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsRecordBindingSource.EndEdit();
        

        }

        private void BtnExe_Click(object sender, EventArgs e)
        {

                    SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseMB.mdf;Integrated Security=True");
                    sqlcon.Open();
                    sql_cmd = sqlcon.CreateCommand();
                    sql_cmd.CommandText = txtQuery = "INSERT INTO StudentsRecord(Firstname, Lastname, MI) VALUES('" + this.txtFirstname.Text + "','" + this.txtLastname.Text + "','" + this.txtMI.Text + "')";
                    sql_cmd.ExecuteNonQuery();
            MessageBox.Show("Records has been saved to database!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
            //close connection




            sqlcon.Close();      
            Edit(false);

             



            
        }

        private void lrnYes_OnValueChange(object sender, EventArgs e)
        {
            lrn = "YES";
        }

        private void returningYes_OnValueChange(object sender, EventArgs e)
        {
            returning = "YES";
        }

        private void RdYes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
