using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOOPShow
{
    public class Car
    {
        //static
        private static int counter = 0;
        public static int Counter { get { return counter; } }

        //fields - defualt accsess is private
        int id;
        int modelYear;
        string brand;
        string modelName;
        string color;// not following ecapsilatuon

        string regPlate;
        public string RegPlate
        {
            get { return regPlate; }
            set { regPlate = value.ToUpper(); }
        }

        //constructor
        public Car(int modelYear, string brand, string carModelName)
        {
            id = ++counter;

            this.modelYear = modelYear;
            this.brand = brand;
            modelName = carModelName;
        }

        public Car(int modelYear, string brand, string carModelName, string color, string regPlate)
            : this(modelYear, brand, carModelName)
        {
            this.color = color;
            RegPlate = regPlate;
        }


        public string CarInfomation()
        {
            return $"Car id:{id} | Total amount of cars created so far: {counter}\nBrand: {brand}\nModel: {modelName}\nYear: {modelYear}\nReg. Plate: {regPlate}\nColor: {color}\n\n";
        }
    }
}
