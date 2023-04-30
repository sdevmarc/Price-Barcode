using AForge.Video.DirectShow;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace PriceBarcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videocapturedevice;

        public MySqlConnection connect;

        public void con()
        {
            string connectionstring;
            connectionstring = "server=localhost; username=root; database=db_price_checker; password= tite";
            connect = new MySqlConnection(connectionstring);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                cmbCam.Items.Add(device.Name);
            cmbCam.SelectedIndex = 0;

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            videocapturedevice = new VideoCaptureDevice(filterInfoCollection[cmbCam.SelectedIndex].MonikerString);
            videocapturedevice.NewFrame += Videocapturedevice_NewFrame;
            videocapturedevice.Start();
        }

        private void Videocapturedevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if(result != null)
            {
                txtBar.Invoke(new MethodInvoker(delegate ()
                {
                    MessageBox.Show("Barcode Scanned!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBar.Text = result.ToString();
                }));
            }
            pbPic.Image = bitmap;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(videocapturedevice != null)
            {
                if(videocapturedevice.IsRunning)
                    videocapturedevice.Stop();
            }
        }

        private void txtBar_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            string sql = "Select * from tbl_products where barcode = '"+ txtBar.Text + "'; ";

            MySqlDataReader reader;

            con();
            connect.Open();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connect;
            reader = cmd.ExecuteReader();

            if(reader.Read() == true)
            {
                lblPrice.Text = reader.GetString("price");
                txtDes.Text = reader.GetString("description");
            }
            else
            {
                
            }
            connect.Close();
        }
    }
}
