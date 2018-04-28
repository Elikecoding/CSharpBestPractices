using FirstHelperLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DemoConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                
                //Calling my person from outside the static void main method because EACH METHOD SHOULD ONLY HAVE ONE FUNCTION
                //CreateMyPerson();

                //Calling my sample 
                //SetUpSampleData();

                //Calling my greet function
                //GreetAllPeople();

                //Create An Array and Loop through the contents
                //TeachMeArrays();

                //Create a stack and Loop through the contents of the stack
                //CreateMyStack();

                //Create a Queue and Loop through the contents
                //CreateMyQueue();

                //Create a dictionary and display the contents 
                //CreateMyDictionary();

                //Call an if statement
                //DothisIf();

                //Call an if else statement
                //DoThisElse();

                //Call my else-if-else statement
                //DoThisElseIfElse();

                //Call my Case-switch statement
                //CreateCaseSwitch();

                //Call a for loop
                //CreateAForLoop();

                //Call a while loop
                //CreateAWhileLoop();

                //Call a Do-While Loop
                //CreateADoWhileLoop();

                //Get my string builder
                //StringBuilderTest();

                //Call my string concat
                //StringConcat();

                //Call My Ternary Conditon
                //TeachMeTernarys();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                var ix = ex.InnerException;

                while (ix != null)
                {
                    Console.WriteLine(ix.StackTrace);
                    ix = ix.InnerException;
                };
            }
            finally
            {
                //Tell me how long it took to perform everything
                Console.WriteLine("Total Time Taken is :" + DateTime.Now.Second + " Seconds");
                Console.ReadLine();
            }
        }

        //Concatinate a string
        private static void StringConcat()
        {
            try
            {
                //Say hello to someone from my person using old string contact
                //string test = "Hello" + person.FirstName + "" + person.LastName + "!";

                //Say hello to a person using the new string concat
                //string betterTest = $"Hello {person2.FirstName} {person2.LastName} !";
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Please check your string", ex);
            }
        }

        //Test for my string builder
        private static void StringBuilderTest()
        {
            try
            {
                //Create a counter, my string and a string builder
                DateTime clock = new DateTime();
                string speakFam = "Original String";
                StringBuilder Ns = new StringBuilder();

                //Tell me how long it has taken to build my objects 
                Console.WriteLine("Time now is :" + clock.Second + " Seconds");
                Console.WriteLine(Ns.ToString());

                //Loop through my string object and append a string to to it
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(speakFam + Ns.Append("New String + "));
                }

                //Tell when loop has finished and how long it has taken
                Console.WriteLine("No more strings to add");
                Console.WriteLine("Adding 100 strings to " + speakFam + " took an extra :" + clock.Second + "  Seconds");
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Please check if your string is null", ex);
            }

        }

        //Create a list of people
        private static List<Person> people = new List<Person>();

        //Create person
        private static void CreateMyPerson()
        {
            try
            {
                //NEW Person TEMPLATE 
                Person newPerson = new Person();

                newPerson.FirstName = "TIMMYYY";
                newPerson.LastName = "TURRRNEER";
                newPerson.Age = 99;
                newPerson.Email = "suckmydick@hotmail.com";
                newPerson.Balance = 110;
                newPerson.IsAdmin = false;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Please check if you correctly entered your details", ex);
            }
        }

        //Add a list of people to the the Person Class
        private static void SetUpSampleData()
        {
            //Add people to my list
            people.Add(new Person { FirstName = "Jack", LastName = "Sawyer", Email = "Fict@hotmail.com", Age = 25, Balance = 100 });
            people.Add(new Person { FirstName = "Nick", LastName = "Shelby", Email = "Fict1@hotmail.com", Age = 35, Balance = 300 });
            people.Add(new Person { FirstName = "Joe", LastName = "Jones", Email = "Fict2@hotmail.com", Age = 47, Balance = 450 });
            people.Add(new Person { FirstName = "Harry", LastName = "Doe", Email = "Fict3@hotmail.com", Age = 16, Balance = 500 });
            people.Add(new Person { FirstName = "Tim", LastName = "Butcher", Email = "Fict4@hotmail.com", Age = 28, Balance = 900 });
            people.Add(new Person { FirstName = "Jonas", LastName = "Butcher", Email = "Fict5@hotmail.com", Age = 28, Balance = 900 });
        }

        //Method to greet all my customers 
        private static void GreetAllPeople()
        {
            //Loop through a list of people and say hello
            foreach (var person in people)
            {
                //Say hello to my people if they exist
                if (person.FirstName != null)
                {
                    Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
                    Console.WriteLine($"These are your details :");
                    Console.WriteLine($"{person.FirstName} is {person.Age} years old. Your Email is: {person.Email} and your Balance is {person.Balance}");

                }
                //Only run this line if nobody exists
                else
                {
                    Console.WriteLine("I've got no friends");
                }
            }
        }

        //Create an Array 
        private static void TeachMeArrays()
        {
            String[] stringArray = new string[]{
            "Item 1","Item 2","Item 3","Item 4","Item 5","Item 6","Item 7","Item 8","Item 9","Item 10"
            };

            int[] numArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Combine both Arrays
            Array myArrays = new Array[] { numArray, stringArray };

            //Tell me about my string Array
            Console.WriteLine(" This is an Array made of strings ");
            Console.WriteLine(" The item at Index 2 is: " + stringArray[3]);
            Console.WriteLine(" The item at Index 4 is : " + stringArray[7]);

            //Tell me about my num Array
            Console.WriteLine(" This is an Array made of numbers ");
            Console.WriteLine(" The item at Index 3 is : " + numArray[4]);
            Console.WriteLine(" The item at Index 5 is : " + numArray[6]);

            //Tell me the conents of my Arrays
            Console.WriteLine(" I will now display the contents of both Arrays ");

            foreach (var item in myArrays)
            {
                Console.WriteLine(" String Items ");
                Console.WriteLine(" String Array : " + stringArray);

                Console.WriteLine("Number Items");
                Console.WriteLine(" Number Array : " + numArray);
            }

            Console.WriteLine(" No more items to display :( ");
        }

        //Create some stacks
        private static void CreateMyStack()
        {
            Stack myStack = new Stack();

            Stack numStack = new Stack();

            //Add Items to my string stack
            myStack.Push("String Item 1");
            myStack.Push("String Item 2");
            myStack.Push("String Item 3");
            myStack.Push("String Item 4");
            myStack.Push("String Item 5 ");
            myStack.Push("String Item 6");
            myStack.Push("String Item 7");
            myStack.Push("String Item 8");
            myStack.Push("String Item 9");
            myStack.Push("String Item 10");

            //Add Items to the number stack
            numStack.Push(1);
            numStack.Push(2);
            numStack.Push(3);
            numStack.Push(4);
            numStack.Push(5);
            numStack.Push(6);
            numStack.Push(7);
            numStack.Push(8);
            numStack.Push(9);
            numStack.Push(10);

            //Count the String stack
            Console.WriteLine($"Initial String Stack Count:" + myStack.Count);

            //Count the Int stack
            Console.WriteLine($"Initial Number Stack Count:" + numStack.Count);

            //Remove items from both stacks
            while (myStack.Count > 0 && numStack.Count > 0)
            {
                Console.WriteLine($"String & Number Stack count before items were removed: " + myStack.Count + numStack.Count);
                Object item = myStack.Pop();
                Console.WriteLine($"Popped " + item.ToString() + " off the String stack");
                Console.WriteLine($"String Stack count after items were removed: " + myStack.Count);

                Object item2 = numStack.Pop();
                Console.WriteLine($"Popped " + item2.ToString() + " off the Number stack");
                Console.WriteLine($"Number Stack count after items were removed: " + numStack.Count);
            }
            Console.WriteLine($"No more " + myStack.ToString() + " and no more " + numStack.ToString() + " in the Stack :(");

        }

        //Create a Queue
        private static void CreateMyQueue()
        {
            Queue myQueue = new Queue();

            //Add Items to my queue
            myQueue.Enqueue("Item 1");
            myQueue.Enqueue("Item 2");
            myQueue.Enqueue("Item 3");
            myQueue.Enqueue("Item 4");
            myQueue.Enqueue("Item 5");
            myQueue.Enqueue("Item 6");
            myQueue.Enqueue("Item 7");
            myQueue.Enqueue("Item 8");
            myQueue.Enqueue("Item 9");
            myQueue.Enqueue("Item 10");

            //Count the number of items in my queue
            Console.WriteLine(myQueue.Peek());
            Console.WriteLine(myQueue.Count);

            //Gather all the queue items and remove one item from the queue
            Object qValue = myQueue.Dequeue();
            Console.WriteLine(qValue.ToString());
            Console.WriteLine("The queue count is : " + myQueue.Count);
            Console.WriteLine(myQueue.Peek());



        }

        //Create a dictionary
        private static void CreateMyDictionary()
        {
            Dictionary<Int32, string> myDictionary = new Dictionary<Int32, string>();

            //Add Items to my dictionary
            myDictionary.Add(1, "First Item");
            myDictionary.Add(2, "Second Item");
            myDictionary.Add(3, "Third Item");
            myDictionary.Add(4, "Fourth Item");
            myDictionary.Add(5, "Fith Item");

            //Display an item from my dictionary
            Console.WriteLine("Item is represented by the key 'Key3' : " + myDictionary[3]);
            myDictionary.Remove(4);
            Console.WriteLine("There are " + myDictionary.Count + " items remaining in the dictionary");

        }

        //Create an if statement
        private static void DothisIf()
        {
            int condition1;

            condition1 = 0;
            if (condition1 == 1)
            {
                Console.WriteLine("You picked " + condition1);
            }
            else
            {
                Console.WriteLine("No condition was selected");
            }
        }

        //Create a if-else statement
        private static void DoThisElse()
        {
            string condition2 = "True";
            string condition3 = "False";

            condition2 = "asfasf";
            if (condition2 == "True")
            {
                Console.WriteLine(condition2.ToString());
            }
            else
            {
                Console.WriteLine(condition3.ToString());
            }

        }

        //Create an else-if-else statement
        private static void DoThisElseIfElse()
        {
            //Initialise my conditions
            string condition4;


            //Pick a condition
            condition4 = "NULLLLLLLLLLLLLL";

            //Run my statement based on my choice of condition
            if (condition4 == "True")
            {
                Console.WriteLine("The answer is True");
            }
            else if (condition4 == "False")
            {
                Console.WriteLine("The answer is false");
            }
            else
            {
                Console.WriteLine("The answer is Null");
            }
        }

        //Create a Case-Switch Statement
        private static void CreateCaseSwitch()
        {
            int switchCondition;

            //Pick your case
            switchCondition = 9000;

            //Go get my case
            switch (switchCondition)
            {
                case 1:
                    Console.WriteLine("This value is 1");
                    break;

                case 2:
                    Console.WriteLine("This value is 2");
                    break;

                case 3:
                    Console.WriteLine("This value is 3");
                    break;

                default:
                    Console.WriteLine("Value is " + switchCondition);
                    break;
            }

        }

        //Create a for loop
        private static void CreateAForLoop()
        {
            //Create a collection of items and loop through m items
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i.ToString());
                Console.WriteLine("Counter has counted " + i + " items");
            }

        }

        //Create a while loop
        private static void CreateAWhileLoop()
        {
            //Create a my counter and loop through its contents
            int counter = 10;

            while (counter > 0)
            {
                Console.WriteLine("The countdown is at: " + counter);
                counter--;
            }
        }

        //Create a Do-While loop
        private static void CreateADoWhileLoop()
        {
            //Initialize a counter and count through the items in the list
            int doCounter = 10;

            //Count for me
            do
            {
                Console.WriteLine("Counter is at: " + doCounter);
                doCounter--;
            } while (doCounter > 0);
        }

        //Create a Ternary Condition from user input
        private static void TeachMeTernarys()
        {

            //Create my inputs
            Console.WriteLine("Give me a number between 1 and 10 ? :)");
            int myInput = Convert.ToInt32(Console.ReadLine());

            string myClassifer;

            //Ternary my g 
            myClassifer = (myInput > 10) ? "You picked a BIG number :) " : "You picked a small number :( ";

            //Read out my condition
            Console.WriteLine(myClassifer);
            Console.WriteLine("Thanks for playing :)");
        }
    }

}

