using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson06
{
    public class Car
    {
        // Fields
        protected string _make;  
        protected string _model; 
        protected int _elapsedMileage; 

        // Properties
        //public string Make
        //{
        //    get { return _make; }
        //    set { _make = value; }
        //}

        public string Make
        {
            get { return _make; }
            // set { return _make = value; }

            // The following is an example of why its
            // important to use a Property rather than
            // a public Field.  A Property allows you to
            // check the value before allowing the 
            // private member field to be mutated.
            set
            {
                if ((value == "Oldsmobile") || (value == "Chevrolet"))
                {
                    _make = value;
                }
                else
                {
                    _make = "";
                }
            }

        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int ElapsedMileage
        {
            get { return _elapsedMileage; }
            set { _elapsedMileage = value; }
        }


        // This is an example of a Constructor
        // A Constructor is a method that is executed
        // each time a new instance of this Class is
        // created.
        public Car()
        {
            _make = "DEFAULT";
            _model = "DEFAULT";
            _elapsedMileage = 0;

            System.Windows.Forms.MessageBox.Show("Called Constructor");
        }



        // This is an example of an Overloaded method.
        // This just happens to be a constructor, so
        // its commonly called an 'Overloaded Constructor'.
        // Overloading just means that the method name 
        // is the same, but the number of arguments 
        // (the 'Method Signature') is different.
        public Car(string make, string model, int elapsedMileage)
        {
            _make = make;
            _model = model;
            _elapsedMileage = elapsedMileage;
        }


        public string Drive(int miles)
        {

            _elapsedMileage += miles;

            // Could perform some additional calculations here
            // for determining fuel consumption and wear & tear
            // costs ...

            string result;
            result = "The " + _make + " " + _model + " now has " + _elapsedMileage + " miles.";
            return result;

        }


    }


    // Minivan Inherits from Car, meaning that it will get
    // all the Properties and Methods that Car has, AND we
    // can add additional properties and methods that are
    // unique to Minivan ... OR can override them to
    // create a specialized version of the method.

    public class Minivan : Car
    {



        public Minivan()
        {
            _make = "NA";
        }


        private int _passengers;

        public int Passengers
        {
            get { return _passengers; }
            set { _passengers = value; }
        }

        public new string Drive(int miles) 
        {
            _elapsedMileage += miles;

            double cost = Utility.CalculateGasPrices(miles);

            string result;
            result = "The " + _make + " " + _model + " now has " + _elapsedMileage +
                " miles (mostly to soccer games) costing " + cost.ToString();
            return result;
        }

    }


}
