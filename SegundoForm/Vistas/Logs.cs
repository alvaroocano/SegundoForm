using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoForm.Vistas
{
    public partial class Logs : Form
    {
        public string directorio = "";
        public Logs()
        {
            InitializeComponent();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.ShowDialog();
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            List<String> parentDir = new List<string>();
            parentDir.AddRange(Directory.GetFiles(directorio, "*.*"));
            foreach (String s in parentDir)
            {
                FileInfo f = new FileInfo(s);
                TreeNode subItems = new TreeNode(f.Name);
                treeView1.Nodes.Add(subItems);
            }
        }

    }
}
