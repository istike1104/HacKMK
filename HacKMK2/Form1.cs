using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
/*

LOADING...

Starting GOOGLE API >>>

GOOOGLE API Integrated


API is running... <calculating_routes> <calculating_time>


very original an nessesary program lines, 
Do not DELETE or MODIFY these lines.

*/


namespace HacKMK2

{
    public partial class Form1 : Form
    {
        const int MAX_ROWS = 400;
        const int NUM_FIELDS = 7;
        int numRead = 0;
        string[,] cities = new string[MAX_ROWS, NUM_FIELDS];
        int numRows = 0;
        bool[] ridees = new bool[10];
        int[,] matrixdata = new int[20, 2];

        public Form1()
        {
            InitializeComponent();
            OrderItems();
            SetBackgroundImage();
            SetWindowSizeAndStyle();
        }

        private void OrderItems()
        {
            MainForm_Load();
            btdriver1.Hide();
            btdriver2.Hide();
            btdriver3.Hide();
            btdriver4.Hide();
            btShowEverything.Hide();
            richTextBox4.Hide();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            bt_start.Hide();
        }

        private void SetWindowSizeAndStyle()
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        private void SetBackgroundImage()
        {
            try
            {
                // Load the image from file
                Image backgroundImage = Image.FromFile("..\\..\\..\\images\\initialbackground.jpg");

                // Set the background image of the form
                this.BackgroundImage = backgroundImage;

                // Optionally, you can adjust the background image layout
                // to suit your preferences
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                // Handle any exceptions, such as file not found
                MessageBox.Show("Error loading background image: " + ex.Message);
            }
        }

        private void MainForm_Load()
        {
            Random rand = new Random();
            string filename = "..\\..\\..\\sources\\hackmk.csv";
            ReadCSV(filename);

            if (numRead == -1)
            {
                MessageBox.Show("Error opening file.");
                return;
            }

            if (numRows == 0)
            {
                MessageBox.Show("No data found in CSV.");
                return;
            }

            int transport = rand.Next(3, 10); // Number of lines to display
            DisplayRoute(transport);
        }

        private void ReadCSV(string filename)
        {
            Random rand = new Random();
            using (StreamReader file = new StreamReader(filename))
            {
                file.ReadLine(); // Skip header line

                numRows = 0;
                string line;
                while (numRows < MAX_ROWS && (line = file.ReadLine()) != null)
                {
                    string[] fields = line.Split(',');
                    for (int i = 0; i < fields.Length && i < NUM_FIELDS; i++)
                    {
                        cities[numRows, i] = fields[i];
                    }
                    numRows++;
                }
            }
        }

        public void ConvertHourtoMinSec(double tim) //ki kell majd iratni valahova
        {
            int hours = (int)tim;

            double remainingMinutesDecimal = (tim - hours) * 60;
            int minutes = (int)remainingMinutesDecimal;

            double remainingSecondsDecimal = (remainingMinutesDecimal - minutes) * 60;
            int seconds = (int)remainingSecondsDecimal;
            richTextBox3.Text += hours + ":";
            if (minutes < 10)
            {
                richTextBox3.Text += "0" + minutes + ":";
            }
            else
            {
                richTextBox3.Text += minutes + ":";
            }
            if (seconds < 10)
            {
                richTextBox3.Text += "0" + seconds;
            }
            else
            {
                richTextBox3.Text += seconds;
            }

        }

        // cost mediu, mennyi a koltseg egy tirre x km re
        // atrendezes, ha kozbe jon valami es a legjobban fizetuket, legkevesebb costal elore
        // tobb auto/ember felvetele, attol fugg mi kell, a bugetbol hogyan tudsz jatszani az ingadozassal

        private void DisplayRoute(int rides)
        {
            Random rand = new Random();
            bool[] ridees = new bool[rides];
            tbHowMany.Clear();
            tbHowMany.Text += $"You have {rides} trips today:\n\n";


            for (int i = 0; i < rides; i++)
            {
                ridees[i] = false;
                int index1 = rand.Next(numRows); // Random index within valid range
                int index2;
                do
                {
                    index2 = rand.Next(numRows); // Random index within valid range
                } while (index1 == index2);

                if (index1 >= 0 && index1 < numRows && index2 >= 0 && index2 < numRows)
                {
                    richTextBox1.Text += $"Nr [{index1}]:\t";
                    for (int j = 1; j < NUM_FIELDS; j++)
                    {
                        matrixdata[i, 0] = index1;
                        matrixdata[i, 1] = index2;
                        richTextBox1.Text += $"{cities[index1, j],-30}";
                        if (j < NUM_FIELDS - 1)
                            richTextBox1.Text += "|\t";
                    }
                    richTextBox1.Text += "\n\n";

                    richTextBox2.Text += $"Nr [{index2}]:\t";
                    for (int j = 1; j < NUM_FIELDS - 2; j++)
                    {

                        richTextBox2.Text += $"{cities[index2, j],-30}";
                        if (j < NUM_FIELDS - 3)
                            richTextBox2.Text += "|\t";
                    }
                    richTextBox2.Text += "\n\n";

                    double dist = CalculateDistance(Convert.ToDouble(cities[index1, 3]), Convert.ToDouble(cities[index1, 4]), Convert.ToDouble(cities[index2, 3]), Convert.ToDouble(cities[index2, 4]));
                    double time = CalculateTime(dist);
                    richTextBox3.Text += $"<{i + 1}>  ";
                    richTextBox3.Text += $"[{index1}] - [{index2}]:      \t";
                    richTextBox3.Text += "Distanta:    " + dist + " km" + "        \t     Avg. timp:   ";
                    ConvertHourtoMinSec(time);
                    richTextBox3.Text += "\n\n";
 					richTextBox4.Text += "\tTervezes...\t\t\t Utazas: A --> B \t\t Kozeli munkak keresese: Loading... \t\t\t Menj: B --> C \t\t Vidd a csomagot C --> D\n\n";


                }
                else
                {
                    MessageBox.Show("Invalid index.");
                    return;
                }
                /*double km0 = 0; int xopo = 0;
                while (xopo < rides)
                {
                    while (km0 < 700)
                    {
                        xopo++;
                        km0 += CalculateDistance(Convert.ToDouble(cities[matrixdata[xopo, 0], 3]), Convert.ToDouble(cities[matrixdata[xopo, 0], 4]), 
						Convert.ToDouble(cities[matrixdata[xopo, 1], 3]), Convert.ToDouble(cities[matrixdata[xopo, 1], 4]));
                        //ridees[counter] = true;
                    }
                    richTextBox4.Clear();
                    for (int k = 0; k < xopo; k++)
                    {
                        richTextBox4.Text += cities[matrixdata[k, 0], 1] + "   ->   ";
                    }
                    xopo++;
                }*/

            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            DisplayRoute(rand.Next(3, 10));
        }


        private const double EarthRadiusKm = 6371.0; // Mean radius of the Earth in kilometers

        public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            // Convert latitude and longitude from degrees to radians
            lat1 = DegreeToRadian(lat1);
            lon1 = DegreeToRadian(lon1);
            lat2 = DegreeToRadian(lat2);
            lon2 = DegreeToRadian(lon2);


            double distance = Math.Acos(Math.Sin(lat1) * Math.Sin(lat2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Cos(lon2 - lon1)) * EarthRadiusKm;

            return Math.Round((distance / 100.0) * 3.75, 2);
        }

        public static double CalculateTime(double dis)
        {
            return dis / 70.0;
        }



        private static double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        private void tbHowMany_TextChanged(object sender, EventArgs e)
        {

        }

        private void btShowEverything_Click(object sender, EventArgs e)
        {
            btdriver1.Hide();
            btdriver2.Hide();
            btdriver3.Hide();
            btdriver4.Hide();
            richTextBox1.Show();
            richTextBox2.Show();
            richTextBox3.Show();
            btShowEverything.Hide();
            btShowDriver.Show(); 
            button1.Show();
            richTextBox4.Hide();

        }

        private void btdriver2_Click(object sender, EventArgs e)
        {

        }

        private void btShowDriver_Click(object sender, EventArgs e)
        {
            btdriver1.Show();
            btdriver2.Show();
            btdriver3.Show();
            btdriver4.Show();
            richTextBox1.Hide();
            richTextBox2.Hide();
            richTextBox3.Hide();
            btShowEverything.Show();
            btShowDriver.Hide();
            button1.Hide();
            richTextBox4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}