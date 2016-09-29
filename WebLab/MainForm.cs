using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebLab.Models;
using WebLab.Providers;
using WebLab.Utilities;

namespace WebLab
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }

        private void projectTemplatesUserControl1_SelectedTemplateChanged(object sender, UserControls.TemplateSelectionEventArgs e)
        {
            try
            {
                projectTemplateBundlesUserControl1.LoadTemplate(e.SelectedProjectTemplate);
            }
            catch (Exception ex)
            {
                ex.PromptMsg();
            }
        }
    }
}
