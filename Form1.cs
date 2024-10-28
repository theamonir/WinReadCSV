using CsvHelper;
using System.Globalization;
using System.Text;

namespace WinReadCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadCSV_Click(object sender, EventArgs e)
        {
            try
            {
                CustomCSV ccsv = new CustomCSV();
                ccsv.Read();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnCreateCSV_Click(object sender, EventArgs e)
        {
            try
            {
                CustomCSV ccsv = new CustomCSV();
                ccsv.Write();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
