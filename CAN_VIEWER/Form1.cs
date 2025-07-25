using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAN_VIEWER
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PropName = new PropertyName();
        }
        PropertyName PropName;

        private void trNode_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            dgCanView.Columns.Clear();

            if (trNode.SelectedNode.Name == "네트워크")
            {
                for (int i = 0; i < PropName.Networks_Name.Length; i++)
                {
                    dgCanView.Columns.Add(PropName.Networks_Name[i], PropName.Networks_Name[i]);
                    dgCanView.Columns[i].Name = PropName.Networks_Name[i];
                }
            }
            if (trNode.SelectedNode.Name == "ECU")
            {
                for (int i = 0; i < PropName.ECU_Name.Length; i++)
                {
                    dgCanView.Columns.Add(PropName.ECU_Name[i], PropName.ECU_Name[i]);
                    dgCanView.Columns[i].Name = PropName.ECU_Name[i];
                }
            }
        }
    }
}
