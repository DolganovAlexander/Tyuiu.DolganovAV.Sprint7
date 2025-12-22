using Tyuiu.DolganovAV.Sprint7.Project.V11.Lib;
namespace Tyuiu.DolganovAV.Sprint7.Project.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            private List<Employee> employees = new List<Employee>();
        }
        DataService ds = new DataService();

        private void buttonGetEmpInfo_DAV_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpen_DAV_Click(object sender, EventArgs e)
        {
            try
            {
                ds.LoadEmpFromFile(openFileDialog_DAV.FileName);
                employees = ds.GetAllEmployees();
                
            }
            catch
            {

            }
        }

        private void buttonSave_DAV_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoad_DAV_Click(object sender, EventArgs e)
        {

        }
    }
}
