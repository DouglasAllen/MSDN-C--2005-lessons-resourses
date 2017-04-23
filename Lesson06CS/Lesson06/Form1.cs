using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lesson06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Car myCar;
            myCar = new Car();

            //Car myCar = new Car();
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.ElapsedMileage = 200000;


            // Demonstrating the creation and use of an inherited
            // class.
            Minivan myMinivan = new Minivan();
            myMinivan.Make = "Chrysler";
            myMinivan.Model = "Town and Country";
            myMinivan.ElapsedMileage = 2500;
            myMinivan.Passengers = 6;

            MessageBox.Show(myMinivan.Drive(30));


            //myCar.Make = "Toyota";
            //MessageBox.Show("New value: " + myCar.Make);


            //string result;
            //result = myCar.Drive(30);
            //MessageBox.Show(result);

            //myCar.Drive(40);

            //MessageBox.Show(myCar.ElapsedMileage.ToString());


            // MessageBox.Show(myCar.Make);


            //int result = AddTwoNumbers(3, 5);
            //displayMessage(result.ToString());
            // displayMessage(AddTwoNumbers(3, 5).ToString());

            //string myModel = "";
            //if (myCar.Make == "Oldsmobile")
            //{
            
            //    myModel = myCar.Model;
                
            //}

            //MessageBox.Show(myModel);


            //Car myOtherCar = new Car("Oldsmobile", "Cutlas Supreme", 200000);
            //MessageBox.Show("myOtherCar: " + myOtherCar.Model);

            // MessageBox.Show("Driving 300 miles costs: " + Utility.CalculateGasPrices(300).ToString());


        }

        public int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public void displayMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(myCar.ElapsedMileage.ToString());

        }

    }
}