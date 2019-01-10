using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Management;
namespace FloodFill
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            rasterFill.Init();
        }



        private void Click_btnPoints(object sender, EventArgs e)
        {
            ofd.Filter = "Points|*.txt";
            //ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                tbPoints.Text = ofd.FileName;
                //read headers
                cbPointsHeader.Items.Clear();
                string pointsHeaders = File.ReadLines(ofd.FileName.ToString()).First();
                string[] pointsHeadersSplit = pointsHeaders.Split(' ');
                cbPointsHeader.Items.AddRange(pointsHeadersSplit);
                cbPointsHeader.SelectedIndex = 0;
            }

        }

        private void Click_btnRaster(object sender, EventArgs e)
        {
            ofd.Filter = "Raster|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbRaster.Text = ofd.FileName;
            }
        }

        private void Click_btnOutput(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                tbOutput.Text = sfd.SelectedPath;
            }
        }

        private void Click_btnRun(object sender, EventArgs e)
        {

            //run the algoritm
            rasterFill.Run(tbPoints.Text, tbRaster.Text, tbOutput.Text,GetDirectionsUsed(),cbPointsHeader.Text ,(int)numericUpDownMaxDistance.Value, pb);
            
        }

        public List<String> GetDirectionsUsed()
        {
            List<String> list = new List<string>();

            if (cbUL.Checked) { list.Add("UL"); }
            if (cbUM.Checked) { list.Add("UM"); }
            if (cbUR.Checked) { list.Add("UR"); }

            if (cbML.Checked) { list.Add("ML"); }
            if (cbMR.Checked) { list.Add("MR"); }

            if (cbDL.Checked) { list.Add("DL"); }
            if (cbDM.Checked) { list.Add("DM"); }
            if (cbDR.Checked) { list.Add("DR"); }

            return list;
        }
            


        public OpenFileDialog ofd = new OpenFileDialog();
        public FolderBrowserDialog sfd = new FolderBrowserDialog();
        public List<string> usedDirections;

        RasterFlow rasterFill = new RasterFlow();
        
    }
}

public struct EntryPoint //custom point in pointList (need Z value for height from poiint)
{
    public int X { get; set; }
    public int Y { get; set; }
    public float Z { get; set; }
}


