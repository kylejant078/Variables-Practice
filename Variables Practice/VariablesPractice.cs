using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_Practice
{
    public partial class VariablesPractice : Form
    {
        public VariablesPractice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            hockey.Visible = false;

            //String Variable that stores "Wayne Gretzky"
            string playerName = "Wayne Gretzky";

            //Create integer variable sthat stores the value 99
            int playerNumber = 99;

            //Display "Wayne Gretzky is number 99"
            outputLabel.Text += $"\n{playerName}";
            outputLabel.Text += " ";
            outputLabel.Text += "is number";
            outputLabel.Text += " ";
            outputLabel.Text += $"{playerNumber}";

        }

        private void area_Click(object sender, EventArgs e)
        {
            //Make button disapear
            areabutton.Visible = false;
            //Area of a circle
            double radius = 15;
            double radiusSquared = 225;
            double pi = 3.14;
            double area = radiusSquared * pi;
            outputLabel.Text += $"\n\nRadius Squared=: {radiusSquared}";
            outputLabel.Text += $"\nPi=: {pi}";
            outputLabel.Text += $"\nArea=: {area}";

            //Sectence answer
            outputLabel.Text += $"\nThe area of circle with a radius of";
            outputLabel.Text += " ";
            outputLabel.Text += $"{radius}";
            outputLabel.Text += "cm";
            outputLabel.Text += " ";
            outputLabel.Text += "is";
            outputLabel.Text += $"{area}";
            outputLabel.Text += "cm^2";

        }

        private void carpet_Click(object sender, EventArgs e)
        {
            //Make button disapear
            carpet.Visible = false;

            //Carpet area cost
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double areaRug = length * width;
            double totalCost = areaRug * costPerMeter;
            outputLabel.Text += $"\n\nLength(m)=: {length}";
            outputLabel.Text += $"\nWidth(m)=: {width}";
            outputLabel.Text += $"\nPrice Per m^2=: {costPerMeter}";
            outputLabel.Text += $"\nArea(m^2)=:{areaRug}";
            outputLabel.Text += $"\nFinal Cost($)=:{areaRug * costPerMeter}";
            outputLabel.Text += $"\n\nThe area of a room with dimesions";
            outputLabel.Text += " ";
            outputLabel.Text += $"{length}";
            outputLabel.Text += "m x ";
            outputLabel.Text += $"{width}";
            outputLabel.Text += $"m is {areaRug}";
            outputLabel.Text += "m^2";
            outputLabel.Text += $"\nThe cost to carpet this area at";
            outputLabel.Text += $"{costPerMeter}";
            outputLabel.Text += "$ per square meter is $";
            outputLabel.Text += $"{totalCost}";
        }

        private void bill_Click(object sender, EventArgs e)
        {
            //Make button disapear
            bill.Visible = false;

            //Create Bill of Sale
            double shirt = 12.49;
            double tax = 0.13 * 12.49;
            double total = shirt + tax;
            string tendered = "20.00";
            double change = 5.89;
            outputLabel.Text += $"\n\nBill of Sale";
            outputLabel.Text += $"\n\nShirt:            ";
            outputLabel.Text += $"{shirt}";
            outputLabel.Text += $"\n\nTax:              ";
            outputLabel.Text += $"{tax}";
            outputLabel.Text += $"\nTotal:            ";
            outputLabel.Text += $"{total}";
            outputLabel.Text += $"\n\nTendered:    ";
            outputLabel.Text += $"{tendered}";
            outputLabel.Text += $"\nChange:       ";
            outputLabel.Text += $"{change}";



        }
    }

}