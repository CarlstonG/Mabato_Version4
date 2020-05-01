using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mabato_V4
{
    public partial class MabatoV4 : Form
    {
        public MabatoV4()
        {
            InitializeComponent();
        }

        private void MabatoV4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseMBDataSet2.StudentsRecord' table. You can move, or remove it, as needed.
            this.studentsRecordTableAdapter.Fill(this.databaseMBDataSet2.StudentsRecord);

        }

        private void studentsRecordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsRecordBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseMBDataSet2);

        }
    }
}
