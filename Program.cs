// See https://aka.ms/new-console-template for more information

using System;

namespace FreeCodeCamp {
    class FreeCodeCamp {
        static void Main(string[] args) {

            // if Statement
            IfStatement();

            // Methods
            SayHi(); // without parameters
            Console.Write("Your name is: ");
            SayHiWithName(Console.ReadLine());

            // Array
            Array();

            // Mad Lib
            MadLib();

            // Calculate
            Calculator();

            // Basics
            InitialSteps();
        }

        static void IfStatement() {
            bool isMale = false;
            bool isTall = false;

            if(isMale && isTall) {
                Console.WriteLine("You're a greate tall guy!");
            } else if(isMale && !isTall) {
                Console.WriteLine("You're a greate guy, a little short!");
            } else if(!isMale && isTall) {
                Console.WriteLine("You're a greate tall girl!");
            } else {
                Console.WriteLine("You're a greate girl, a little short!");
            };

        }

        static void Comparacens() {

        }
        static void InitialSteps() {
            // User input
            //  you can read code with Console.ReadLine()

            // Working with numbers
            int num1 = 32;
            int num2 = 2;
            Console.WriteLine(String.Format("Add {0} + {1}: ", num1, num2) + (num1 + num2));
            Console.WriteLine(String.Format("Multiplication {0} * {1}: ", num1, num2) + (num1 * num2));
            Console.WriteLine(String.Format("Add {0} - {1}: ", num1, num2) + (num1 - num2));
            Console.WriteLine(String.Format("Add {0} % {1}: ", num1, num2) + (num1 % num2));
            Console.WriteLine("Actual num1: " + num1 + "\n++num1 = " + (++num1));


            //Working with vars
            Console.Write("Hello World\nFirst Program with FreeCodeCamp\nYour name: ");
            string name = Console.ReadLine();
            Console.Write("Your Age is: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your collage: ");
            string collage = Console.ReadLine();
            Console.Write("Your grade: ");
            char grade = Convert.ToChar(Console.ReadLine());
            Console.Write("Cost of your favorite Food: ");
            double costOfFavoriteFood = Convert.ToDouble(Console.ReadLine());
            Console.Write("Are you male? (true/false): ");
            bool isMale = Convert.ToBoolean(Console.ReadLine());
            // float, double, decimal || DECIMAL VARS ORDERD SHORTER TO BIGGER
            //strings have methods like Substring, IndexOf, Contains, ToLower, ToUpper, properties like length, support string[IndexOfCharacter]
            Console.Write(
              String.Format("\nThere once was a man({1}) named {0}", name, isMale) +
              String.Format("\nHe was {0} years old", age) +
              String.Format("\nHe really like the name {0}", name) +
              String.Format("\nBut didn't like being {0}", age) +
              String.Format("\nHe went to {0} is in the grade {1}", collage, grade) +
              String.Format("\nHis favorite food costs: ${0}", costOfFavoriteFood)
            );
        }

        static void Calculator() {
            Console.WriteLine("Calculator");

            Console.Write("Give a number 1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Give a number 2:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Select an operation (add|rest|multiply|division|module operator):");
            string operation = Console.ReadLine().ToLower();
            double result = CalculatorOperation(num1, num2, operation);

            Console.WriteLine(String.Format("{0} {2} {1} is {3}\n\n\n", num1, num2, operation, result));

        }

        static Double CalculatorOperation(double num1, double num2, string operation) {
            double result = 0;
            if(operation == "add") {
                result = num1 + num2;
            } else if(operation == "rest") {
                result = num1 - num2;
            } else if(operation == "multiply") {
                result = num1 * num2;
            } else if(operation == "division") {
                result = num1 / num2;
            } else if(operation == "module operator") {
                result = num1 % num2;
            } else if(operation == "cube"){
                result =  Convert.ToDouble(Cube(Convert.ToInt32(num1)));
            } else {
                Console.WriteLine("Invalid operation.");
            };

            return result;
        }

        static int Cube(int number) {
            return number * number;
        }

        static void MadLib() {
            string color, pluralNoun, celebrity;
            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural color : ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity : ");
            celebrity = Console.ReadLine();

            Console.WriteLine("\n\nRoses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity + "\n\n");

        }

        static void Array() {
            int[] luckyNumber = { };
            PrintArray(luckyNumber);
            luckyNumber = new int[] { 3, 4, 5, 6 };
            PrintArray(luckyNumber);
            PrintArrayIndex(luckyNumber, 0);
            PrintArrayIndex(luckyNumber, 1);
            luckyNumber[0] = 23;
            Console.WriteLine("luckyNumber[0] = 23; ");
            PrintArrayIndex(luckyNumber, 0);


            string[] friends = new string[3];
            friends[0] = "Jim";
            friends[1] = "Kalle";
            friends[2] = "Porty";
            // friends[3] = "Sasha"; // System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            // friends[4] = "Marty"; // System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            // friends[5] = "Mary"; // System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            // the above errs happened because at the initial, we said the array have only 3 spaces
            PrintArray(friends);

            //local function
            // <thisIsGeneric> is a way to say to C# the arg is generic and
            // it's take a type when the function is called
            static void PrintArray<thisIsGeneric>(thisIsGeneric[] array) {
                Console.WriteLine("Array: " + string.Join(", ", array) + ". My Array Length: " + array.Length);
            };
            //local function
            static void PrintArrayIndex(int[] array, int index) {
                Console.WriteLine("Array[" + index + "] = " + array[index]);
            };

        }

        static void SayHi() {

            Console.WriteLine("Hello User!");

        }

        static void SayHiWithName(string name) {
            Console.WriteLine($"Hello {name}!");

            /**
             * 
             * public: Los miembros públicos son accesibles desde cualquier lugar, ya sea dentro del mismo ensamblado o desde otros ensamblados.
             * public int MyPublicMember;
             * 
             * private: Los miembros privados son accesibles solo desde dentro de la misma clase o estructura.
             * private int MyPrivateMember;
             * 
             * protected: Los miembros protegidos son accesibles desde la misma clase, así como desde clases derivadas(subclases), pero no son accesibles desde instancias de la clase fuera de la jerarquía de herencia.
             * protected int MyProtectedMember;
             * 
             * internal: Los miembros internos son accesibles dentro del mismo ensamblado, pero no desde fuera del ensamblado.
             * internal int MyInternalMember;
             * 
             * protected internal: Los miembros protegidos internos son accesibles dentro del mismo ensamblado y desde clases derivadas(subclases) incluso si están en un ensamblado diferente.
             * protected internal int MyProtectedInternalMember;
             *
             * private protected: Los miembros privados protegidos son accesibles desde la misma clase o desde clases derivadas(subclases) en el mismo ensamblado.
             * private protected int MyPrivateProtectedMember;
             *
             * Si no se especifica un modificador de acceso, el modificador por defecto es private.
             * Esto significa que si un miembro no tiene explícitamente un modificador de acceso, se 
             * considera privado y solo es accesible desde dentro de la misma clase.Por lo tanto, en
             * muchos casos, no especificar un modificador de acceso equivale a usar private.
             * 
             */






        }

        //NEXT CLOSE KEY IS FOR THE CLASS

    };

}