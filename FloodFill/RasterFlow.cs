using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
namespace FloodFill
{
    class RasterFlow
    {

        public void Init()
        {
            //Init background worker

            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorker_DoWork);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(BackgroundWorker_ProgressChanged);
        }

        public void Run(string pointsPath, string rasterPath, string outputPath, List<String> directions, string zName, int maxDistance, ProgressBar progressBar)
        {

            //Create backgroundworker arguments
            List<object> arguments = new List<object>
            {
                pointsPath,
                rasterPath,
                outputPath,
                directions,
                zName,
                maxDistance,
                progressBar
            };

            //run backgroundworker if available
            if (!backgroundWorker.IsBusy)
            { 
                backgroundWorker.RunWorkerAsync(arguments);
                
            }
            else
            {
                MessageBox.Show("BackgroundWorker Busy");
            }

        }


        public void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Background worker, prevent freezing UI

            //read arguments
            List<object> genericList = e.Argument as List<object>;

            string pointPath = genericList[0].ToString();
            string rasterPath = genericList[1].ToString();
            string outputPath = genericList[2].ToString();
            directions = (List<String>)genericList[3];
            string zName = genericList[4].ToString();
            int maxDist = (int)genericList[5];
            progressBar = (ProgressBar)genericList[6];


            backgroundWorker.ReportProgress(10);

            float[,] raster = AsciiToRaster(rasterPath);

            backgroundWorker.ReportProgress(20);
            costSoFar = ClearCostSoFar();
            backgroundWorker.ReportProgress(40);
            //grab data from points
            List<EntryPoint> StartPoints = CoordsFromPoints(pointPath, zName);

            backgroundWorker.ReportProgress(60);
            for (int i = 0; i < StartPoints.Count; ++i)
            {
                Algorithm(StartPoints[i].X, StartPoints[i].Y, StartPoints[i].Z, raster, maxDist);
            }
            backgroundWorker.ReportProgress(80);

            RasterToAscii(costSoFar, outputPath);

            backgroundWorker.ReportProgress(100);
        }



        public float[,] AsciiToRaster(string rasterPath)
        {
            string[] lines = File.ReadAllLines(rasterPath);

            width = int.Parse(lines[0].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1]);
            height = int.Parse(lines[1].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1]);
            xllcorner = float.Parse(lines[2].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1]);
            yllcorner = float.Parse(lines[3].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1]);
            cellSize = float.Parse(lines[4].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1]);
            NODATA = (lines[5].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1]).ToString();

            float[,] raster = new float[height, width];
            StreamReader sr = new StreamReader(rasterPath);

            for (int i = 0; i <= 5; ++i)
            {
                sr.ReadLine();
            }

            int row = 0;
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < width; ++col)
                {
                    raster[row, col] = float.Parse(line[col]);
                }

                row++;
            }
            return raster;
        }

        public int[,] ClearCostSoFar()
        {
            int[,] c = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    c[i, j] = -1;
                }
            }
            return c;
        }


        public List<EntryPoint> CoordsFromPoints(string pointPath, string zName)
        {

            //Config???
            string posXCoordName = "XCoord";
            string posYCoordName = "YCoord";
            string posZValueName = zName;
            //

            int posXCoord = -1;
            int posYCoord = -1;
            int posZValue = -1;


            List<EntryPoint> p = new List<EntryPoint>();
            //find X
            using (StreamReader sr = new StreamReader(pointPath))
            {
                string pointsHeaders = sr.ReadLine();
                string[] pointsHeadersSplit = pointsHeaders.Split(' ');

                for (int i = 0; i < pointsHeadersSplit.Length; ++i)
                {
                    //get data positions
                    if (pointsHeadersSplit[i].ToString() == posXCoordName)
                    {
                        posXCoord = i;
                        continue;
                    }

                    //get positions
                    if (pointsHeadersSplit[i] == posYCoordName)
                    {
                        posYCoord = i;
                        continue;
                    }

                    //get positions
                    if (pointsHeadersSplit[i] == posZValueName)
                    {
                        posZValue = i;
                        continue;
                    }

                }
                //TODO Check if values exist

                while (!sr.EndOfStream)
                {

                    string data = sr.ReadLine();
                    string[] dataSplit = data.Split(' ');
                    //todo Read data
                    float tempX = float.Parse(dataSplit[posXCoord].ToString());
                    float tempY = float.Parse(dataSplit[posYCoord]);
                    float tempZ = float.Parse(dataSplit[posZValue]);


                    EntryPoint currentPoint = PointRasterPosition(tempX, tempY, tempZ, xllcorner, yllcorner, cellSize);
                    p.Add(currentPoint);
                }
            }


            return p;
        }

        public void Algorithm(int sx, int sy, float z, float[,] raster, int maxDist)
        {

            //create qt
            bool[,] visited = new bool[height, width];
            Queue<Point> qt = new Queue<Point>();

            Point start = new Point(sx, sy);
            qt.Enqueue(start);

            visited[sy, sx] = true;

            costSoFar[sy, sx] = 1;

            while (qt.Any())
            {
                Point current = qt.Dequeue();


                //get neightbbours
                List<Point> n = Neightbours(current);
                for (int i = 0; i < n.Count; ++i)
                {
                    //continue: will just skip the current iteration.

                    //Safety Return
                    if (n[i].X < 0) { continue; }
                    if (n[i].X >= width) { continue; }
                    if (n[i].Y < 0) { continue; }
                    if (n[i].Y >= height) { continue; }

                    //below z value
                    if (raster[n[i].Y, n[i].X] > z) { continue; }
                        //nodata
                    if (raster[n[i].Y, n[i].X].ToString() == NODATA) { continue; }


                    //outside maxDist
                    if (maxDist != 0) { if (costSoFar[current.Y, current.X] + 1 > maxDist) { continue; } }
                    //already visited
                    if (visited[n[i].Y, n[i].X] == true) { continue; }

                    int newCost = costSoFar[current.Y, current.X] + 1;

                    visited[n[i].Y, n[i].X] = true;
                    if (costSoFar[n[i].Y, n[i].X] == -1)
                    {
                        costSoFar[n[i].Y, n[i].X] = newCost;
                    }
                    else
                    {
                        costSoFar[n[i].Y, n[i].X] = Math.Min(costSoFar[n[i].Y, n[i].X], newCost);
                    }
                    qt.Enqueue(n[i]);
                }
            }
        }

        public List<Point> Neightbours(Point from)
        {
            //4 Way or 8 way, you choose

            List<Point> n = new List<Point>();


            if (directions.Contains("UL")) { n.Add(new Point(from.X - 1, from.Y - 1)); } //up-left
            if (directions.Contains("UM")) { n.Add(new Point(from.X, from.Y - 1)); } //up-middle
            if (directions.Contains("UR")) { n.Add(new Point(from.X + 1, from.Y - 1)); } //up-right

            if (directions.Contains("ML")) { n.Add(new Point(from.X - 1, from.Y)); } //middle-left
            if (directions.Contains("MR")) { n.Add(new Point(from.X + 1, from.Y)); } //middle-right

            if (directions.Contains("DL")) { n.Add(new Point(from.X - 1, from.Y + 1)); } //down-left
            if (directions.Contains("DM")) { n.Add(new Point(from.X, from.Y + 1)); } //down-middle
            if (directions.Contains("DR")) { n.Add(new Point(from.X + 1, from.Y + 1)); } //down-right


            return n;
        }

        public EntryPoint PointRasterPosition(float x, float y, float z, float xllcorner, float yllcorner, float cellSize)
        {

            EntryPoint ep = new EntryPoint();
            float dx = (x - xllcorner);
            float dy = (y - yllcorner);
            double px = Math.Floor(dx / cellSize);
            double py = height - Math.Floor(dy / cellSize);

            ep.X = (int)px;
            ep.Y = (int)py;
            ep.Z = z;

            return ep;
        }

        public void RasterToAscii(int[,] raster, string ExportPath)
        {

            using (StreamWriter sw = new StreamWriter(ExportPath + "/Export" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt"))
            {
                sw.WriteLine("ncols " + width.ToString());
                sw.WriteLine("nrows " + height.ToString());
                sw.WriteLine("xllcorner " + xllcorner.ToString());
                sw.WriteLine("yllcorner " + yllcorner.ToString());
                sw.WriteLine("cellsize " + cellSize.ToString());
                sw.WriteLine("NODATA_value " + NODATA.ToString());

                //write data
                for (int i = 0; i < height; ++i)
                {
                    for (int j = 0; j < width; ++j)
                    {
                        //write nodata
                        if (raster[i, j] == -1)
                        {
                            sw.Write(NODATA);

                        }
                        else
                        {
                            sw.Write(raster[i, j]);
                        }
                        sw.Write(" ");
                    }
                    sw.WriteLine();
                }

            }

        }



        public void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }


        public BackgroundWorker backgroundWorker = new BackgroundWorker();

        public int[,] costSoFar;
        public int width;
        public int height;
        public float xllcorner;
        public float yllcorner;
        public float cellSize;
        public string NODATA;
        public List<String> directions;
        public ProgressBar progressBar;

    }


    public struct EntryPoint //custom point in pointList (need Z value for height from poiint)
    {
        public int X { get; set; }
        public int Y { get; set; }
        public float Z { get; set; }
    }
}
