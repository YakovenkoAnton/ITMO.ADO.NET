using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace std
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Person". При необходимости она может быть перемещена или удалена.
            this.personTableAdapter.Fill(this.schoolDataSet.Person);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Person". При необходимости она может быть перемещена или удалена.
            this.personTableAdapter.Fill(this.schoolDataSet.Person);

        }

        private void personBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void personBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);
        }
    }
}
