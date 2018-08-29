using System;
using System.Windows.Forms;

namespace MechBuilder {
    /// <summary>
    /// 
    /// </summary>
    public partial class MainForm : Form {
        /// <summary>
        /// 
        /// </summary>
        public MainForm() {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e) {
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            propertyGrid1.SelectedObject = e.Node.Tag;
        }
    }
}

