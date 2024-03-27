using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVCalc
{
    public partial class NatureViewerForm : Form
    {

        private List<DVIVNatureTriplet> data;

        public NatureViewerForm(List<DVIVNatureTriplet> data)
        {
            InitializeComponent();
            this.data = data;
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            // Create a BindingList to bind to the DataGridView
            var bindingList = new BindingList<DVIVNatureTriplet>(data.ToList());

            // Set the DataSource of the DataGridView
            natureGridView.DataSource = bindingList;

            // Set the columns
            natureGridView.Columns[0].HeaderText = "IV";
            natureGridView.Columns[0].DataPropertyName = "IV";
            natureGridView.Columns[1].HeaderText = "Nature";
            natureGridView.Columns[1].DataPropertyName = "Nature";
            natureGridView.Columns[2].HeaderText = "DV";
            natureGridView.Columns[2].DataPropertyName = "DV";

            // Adjust column widths
            natureGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
