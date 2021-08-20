using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphLibrary;

namespace GraphLibraryExample
{
    
    public partial class FormInput : Form
    {
      
        public FormInput()
        {
            InitializeComponent();
            
            comboBoxGraphType.SelectedIndex = 0;
            comboBoxNodeType.SelectedIndex = 0;
            comboBoxLinkType.SelectedIndex = 0;
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string graphType = comboBoxGraphType.SelectedItem.ToString();
            string nodeType = comboBoxNodeType.SelectedItem.ToString();
            string linkType = comboBoxLinkType.SelectedItem.ToString();
           
           
            Hide();
            MainForm formInput = new MainForm(graphType, nodeType, linkType);
            formInput.ShowDialog();
        }
    }
}
