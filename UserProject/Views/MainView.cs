using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserProject.Controllers;

namespace UserProject.Views
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            MainViewController controller = new MainViewController(usersDataGridView);

            Load += controller.MainView_Load;
            addToolStripButton.Click += controller.addToolStripButton_Click;
            changeToolStripButton.Click += controller.changeToolStripButton_Click;
        }
    }
}
