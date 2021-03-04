using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;

namespace Project_FinchControl
{

    // **************************************************
    //
    // Title: Finch Control - Menu Starter
    // Description: Starter solution with the helper methods,
    //              opening and closing screens, and the menu
    // Application Type: Console
    // Author: Eman, Mel
    // Dated Created: 2/8/2021
    // Last Modified: 2/27/2021
    //
    // **************************************************

    class Program
    {
        /// first method run when the app starts up
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SetTheme();

            DisplayWelcomeScreen();
            DisplayMainMenuScreen();
            DisplayClosingScreen();
        }

        /// setup the console theme
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
       
        static void AlarmSystemDisplayMenuScreen(Finch Jarvis)
        {
            DisplayHeader("Alarm System");

            Console.WriteLine("\tThis module is under development.");
            DisplayContinuePrompt();
        }

        static void UserProgrammingDisplayMenuScreen(Finch Jarvis)
        {
            DisplayHeader("User Programming");

            Console.WriteLine("\tThis module is under development");
            DisplayContinuePrompt();
        }
        static void DisplayExit(Finch Jarvis)
        {
            DisplayHeader("Exit");

            Console.WriteLine("\tExiting Program");
            DisplayContinuePrompt();
        }
        
        static void DisplayMainMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;
            bool valid = false;

            Finch Jarvis = new Finch();

            do
            {
               
                DisplayHeader("J.A.R.V.I.S.'S MAIN FRAME");

                Console.WriteLine("\t\tj) Connect J.A.R.V.I.S.");
                Console.WriteLine("\t\ta) Talent Show");
                Console.WriteLine("\t\tr) Data Recorder");
                Console.WriteLine("\t\tv) Alarm System");
                Console.WriteLine("\t\ti) User Programming");
                Console.WriteLine("\t\ts) Disconnect J.A.R.V.I.S");
                Console.WriteLine("\t\t.) Exit");
                Console.Write("\n\t\tWhat would you like to do? ");
                menuChoice = Console.ReadLine().ToLower();

                switch (menuChoice)
                {
                    case "j":
                        DisplayConnectFinchRobot(Jarvis);
                        break;

                    case "a":
                        TalentShowDisplayMenuScreen(Jarvis);
                        break;

                    case "r":
                        DataRecorderDisplayMenuScreen(Jarvis);
                        break;
                    
                    case "v":
                        AlarmSystemDisplayMenuScreen(Jarvis);
                        break;

                    case "i":
                        UserProgrammingDisplayMenuScreen(Jarvis);
                        break;

                    case "s":
                        DisplayDisconnectFinchRobot(Jarvis);
                        break;

                    case ".":
                        DisplayExit(Jarvis);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tJ.A.R.V.I.S does not understand your strange human ways! ");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);

        }

        #region TALENT SHOW

        /// *****************************************************************
        /// *                     Talent Show Menu                          *
        /// *****************************************************************
        
        static void TalentShowDisplayDance(Finch Jarvis)
        {
            DisplayHeader("A friend once told me to throw a little hot red in mix!");

            Console.WriteLine("\n\tWorking on it, sir. This is a prototype.\n");
            DisplayContinuePrompt();

            Console.CursorVisible = false;

            Jarvis.setLED(100, 0, 0);
            Jarvis.setMotors(100, 100);
            Jarvis.wait(3000);
            Jarvis.setMotors(100, -100);
            Jarvis.wait(3000);

            Jarvis.setLED(218, 165, 32);
            Jarvis.setMotors(-100, 100);
            Jarvis.wait(3000);
            Jarvis.setMotors(-50, -50);
            Jarvis.wait(1000);
           
            Jarvis.setLED(100, 0, 0);
            Jarvis.setMotors(50, 50);
            Jarvis.wait(1000);
           
            Jarvis.setLED(218, 165, 32);
            Jarvis.setMotors(-100, 100);
            Jarvis.wait(1000);
            
            Jarvis.setLED(100, 0, 0);
            Jarvis.setMotors(100, -100);
            Jarvis.wait(1000);
            
            Jarvis.setLED(218, 165, 32);
            Jarvis.setMotors(-100, 100);
            Jarvis.wait(1000);
            
            Jarvis.setLED(100, 0, 0);
            Jarvis.setMotors(100, -100);
            Jarvis.wait(1000);
            
            Jarvis.setLED(218, 165, 32);
            Jarvis.setMotors(-100, 100);
            Jarvis.wait(1000);
            
            Jarvis.setLED(100, 0, 0);
            Jarvis.setMotors(100, -100);
            Jarvis.wait(1000);

            Jarvis.setLED(218, 165, 32);
            Jarvis.setMotors(-100, 100);
            Jarvis.wait(1000);

            Jarvis.setLED(100, 0, 0);
            Jarvis.setMotors(100, -100);
            Jarvis.wait(1000);

            Jarvis.setLED(100, 0, 0);
            Jarvis.setMotors(50, 50);
            Jarvis.wait(1000);

            Jarvis.setLED(218, 165, 32);
            Jarvis.setMotors(-50, -50);
            Jarvis.wait(1000);

            Jarvis.setLED(100, 0, 0);
            Jarvis.setMotors(0, 0);
            Jarvis.wait(1000);

            Console.WriteLine("\n\tYes, that shall help you keep a low profile.\n");
            DisplayMenuPrompt("Talent Show");

        }

        static void TalentShowDisplayMixingItUp(Finch Jarvis)
        { 
             DisplayHeader("The House Party Protocol, sir?");

            //Lights and Song

            Jarvis.setLED(100, 0, 0);
            Jarvis.noteOn(165);
            Jarvis.wait(600);
            Jarvis.noteOff();

            Jarvis.setLED(218, 165, 32);
            Jarvis.noteOn(196);
            Jarvis.wait(600);
            Jarvis.noteOff();

            Jarvis.setLED(218, 165, 32);
            Jarvis.noteOn(196);
            Jarvis.wait(500);
            Jarvis.noteOff();

            Jarvis.setLED(100, 0, 0);
            Jarvis.noteOn(220);
            Jarvis.wait(500);
            Jarvis.noteOff();

            Jarvis.setLED(100, 0, 0);
            Jarvis.noteOn(220);
            Jarvis.wait(500);
            Jarvis.noteOff();

            Jarvis.setLED(218, 165, 32);
            Jarvis.noteOn(262);
            Jarvis.wait(350);
            Jarvis.noteOff();

            Jarvis.setLED(100, 0, 0);
            Jarvis.noteOn(247);
            Jarvis.wait(350);
            Jarvis.noteOff();

            Jarvis.setLED(218, 165, 32);
            Jarvis.noteOn(262);
            Jarvis.wait(350);
            Jarvis.noteOff();

            Jarvis.setLED(100, 0, 0);
            Jarvis.noteOn(247);
            Jarvis.wait(350);
            Jarvis.noteOff();

            Jarvis.setLED(218, 165, 32);
            Jarvis.noteOn(262);
            Jarvis.wait(500);
            Jarvis.noteOff();

            Jarvis.setLED(100, 0, 0);
            Jarvis.noteOn(196);
            Jarvis.wait(500);
            Jarvis.noteOff();

            Jarvis.setLED(100, 0, 0);
            Jarvis.noteOn(196);
            Jarvis.wait(500);
            Jarvis.noteOff();

            Jarvis.setLED(218, 165, 32);
            Jarvis.noteOn(220);
            Jarvis.wait(500);
            Jarvis.noteOff();

            Jarvis.setLED(218, 165, 32);
            Jarvis.noteOn(220);
            Jarvis.wait(500);
            Jarvis.noteOff();


            //Lights, "song", and dancing (Can't really hear the song over the motor)

            Jarvis.setLED(100, 0, 0);
            Jarvis.noteOn(165);
            Jarvis.setMotors(100, 100);
            Jarvis.wait(600);
            Jarvis.noteOff();

            Jarvis.setLED(218, 165, 32);
            Jarvis.noteOn(196);
            Jarvis.setMotors(-100, -100);
            Jarvis.wait(600);
            Jarvis.noteOff();

            Jarvis.setLED(218, 165, 32);
            Jarvis.noteOn(196);
            Jarvis.setMotors(-50, 50);
            Jarvis.wait(500);
            Jarvis.noteOff();

            Jarvis.setLED(100, 0, 0);
            Jarvis.noteOn(220);
            Jarvis.setMotors(50, -50);
            Jarvis.wait(500);
            Jarvis.noteOff();

            Jarvis.setLED(100, 0, 0);
            Jarvis.noteOn(220);
            Jarvis.setMotors(-50, 50);
            Jarvis.wait(500);
            Jarvis.noteOff();

            Jarvis.setLED(218, 165, 32);
            Jarvis.noteOn(262);
            Jarvis.setMotors(50, -50);
            Jarvis.wait(350);
            Jarvis.noteOff();

            Jarvis.setLED(100, 0, 0);
            Jarvis.noteOn(247);
            Jarvis.setMotors(50, 0);
            Jarvis.wait(350);
            Jarvis.noteOff();

            Jarvis.setLED(218, 165, 32);
            Jarvis.noteOn(262);
            Jarvis.setMotors(0, 50);
            Jarvis.wait(350);
            Jarvis.noteOff();

            Jarvis.setLED(100, 0, 0);
            Jarvis.noteOn(247);
            Jarvis.setMotors(10, 10);
            Jarvis.wait(350);
            Jarvis.noteOff();

            Jarvis.setLED(218, 165, 32);
            Jarvis.noteOn(262);
            Jarvis.setMotors(-10, -10);
            Jarvis.wait(500);
            Jarvis.noteOff();

            Jarvis.setLED(100, 0, 0);
            Jarvis.noteOn(196);
            Jarvis.setMotors(-100, 100);
            Jarvis.wait(500);
            Jarvis.noteOff();

            Jarvis.setLED(100, 0, 0);
            Jarvis.noteOn(196);
            Jarvis.setMotors(100, -100);
            Jarvis.wait(500);
            Jarvis.noteOff();

            Jarvis.setLED(218, 165, 32);
            Jarvis.noteOn(220);
            Jarvis.setMotors(50, 50);
            Jarvis.wait(500);
            Jarvis.noteOff();

            Jarvis.setLED(218, 165, 32);
            Jarvis.noteOn(220);
            Jarvis.setMotors(0, 0);
            Jarvis.wait(500);
            Jarvis.noteOff();

            Console.WriteLine("\n\tI don’t wanna see this on a Myspace page. Please, no gang signs. \n\tNo, throw it up; I’m kidding. Yeah, peace. I love peace. I’d be out of a job with peace.\n");
            DisplayContinuePrompt();
        }

        static void TalentShowDisplayMenuScreen(Finch Jarvis)
        {
            Console.CursorVisible = true;

            bool quitTalentShowMenu = false;
            string menuChoice;

            do
            {
                DisplayHeader("J.A.R.V.I.S. Abilities");
                
                Console.WriteLine("\ti) Sound & Light Show");
                Console.WriteLine("\tr) Dancing");
                Console.WriteLine("\to) Ironette Audition");
                Console.WriteLine("\tn) Return to Main Menu");
                Console.Write("\n\t\tWhat would you like to see J.A.R.V.I.S. to do?");
                Console.WriteLine("\n\t\tPlease enter the corresponding letter from the menu (keep in mind this module is under development):  ");
                menuChoice = Console.ReadLine().ToLower();

                switch (menuChoice)
                {
                    case "i":
                        TalentShowDisplayLightAndSound(Jarvis);
                        break;

                    case "r":
                        TalentShowDisplayDance(Jarvis);
                        break;

                    case "o":
                        TalentShowDisplayMixingItUp(Jarvis);
                        break;

                    case "n":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPLEASE ENTER A LETTER FOR THE THE MENU CHOICE");
                        break;
                }

            } while (!quitTalentShowMenu);
        }

        /// *****************************************************************
        /// *               Talent Show > Light and Sound                   *
        /// *****************************************************************
        /// <param name="Jarvis">finch robot object</param>

        static void TalentShowDisplayLightAndSound(Finch Jarvis)
        {
            Console.CursorVisible = false;

            DisplayHeader("Song and light show!");

            Console.WriteLine("\tAvenger's Theme Song");
            DisplayContinuePrompt();

            for (int lightSoundLevel = 0; lightSoundLevel < 400; lightSoundLevel++)
            {
                Jarvis.setLED(lightSoundLevel, lightSoundLevel, lightSoundLevel);
                Jarvis.setLED(131, 46, 118);
                Jarvis.noteOn(146);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(131, 46, 118);
                Jarvis.noteOn(146);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(131, 46, 118);
                Jarvis.noteOn(146);
                Jarvis.wait(600);
                Jarvis.noteOff();

                Jarvis.setLED(131, 46, 118);
                Jarvis.noteOn(146);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(131, 46, 118);
                Jarvis.noteOn(146);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(131, 46, 118);
                Jarvis.noteOn(146);
                Jarvis.wait(600);
                Jarvis.noteOff();

                Jarvis.setLED(131, 46, 118);
                Jarvis.noteOn(146);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(131, 46, 118);
                Jarvis.noteOn(146);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(131, 46, 118);
                Jarvis.noteOn(146);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(131, 46, 118);
                Jarvis.noteOn(146);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(13, 108, 172);
                Jarvis.noteOn(155);
                Jarvis.wait(100);
                Jarvis.noteOff();
                Jarvis.setLED(13, 108, 172);
                Jarvis.noteOn(155);
                Jarvis.wait(100);
                Jarvis.noteOff();
                Jarvis.setLED(13, 108, 172);
                Jarvis.noteOn(155);
                Jarvis.wait(600);
                Jarvis.noteOff();

                Jarvis.setLED(13, 108, 172);
                Jarvis.noteOn(155);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(13, 108, 172);
                Jarvis.noteOn(155);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(100, 0, 0);
                Jarvis.noteOn(164);
                Jarvis.wait(600);
                Jarvis.noteOff();

                Jarvis.setLED(100, 0, 0);
                Jarvis.noteOn(164);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(100, 0, 0);
                Jarvis.noteOn(164);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(100, 0, 0);
                Jarvis.noteOn(164);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(100, 0, 0);
                Jarvis.noteOn(164);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(230, 132, 49);
                Jarvis.noteOn(174);
                Jarvis.wait(150);
                Jarvis.setLED(230, 132, 49);
                Jarvis.noteOn(174);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(230, 132, 49);
                Jarvis.noteOn(174);
                Jarvis.wait(350);
                Jarvis.noteOff();

                Jarvis.setLED(230, 132, 49);
                Jarvis.noteOn(174);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(230, 132, 49);
                Jarvis.noteOn(174);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(100, 0, 0);
                Jarvis.noteOn(164);
                Jarvis.wait(500);
                Jarvis.noteOff();

                Jarvis.setLED(100, 0, 0);
                Jarvis.noteOn(164);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(100, 0, 0);
                Jarvis.noteOn(164);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(100, 0, 0);
                Jarvis.noteOn(164);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(100, 0, 0);
                Jarvis.noteOn(164);
                Jarvis.wait(150);
                Jarvis.noteOff();
                Jarvis.setLED(131, 46, 118);
                Jarvis.noteOn(155);
                Jarvis.wait(100);
                Jarvis.noteOff();
                Jarvis.setLED(131, 46, 118);
                Jarvis.noteOn(155);
                Jarvis.wait(100);
                Jarvis.noteOff();
                Jarvis.setLED(131, 46, 118);
                Jarvis.noteOn(155);
                Jarvis.wait(350);
                Jarvis.noteOff();

                Jarvis.setLED(131, 46, 118);
                Jarvis.noteOn(155);
                Jarvis.wait(100);
                Jarvis.noteOff();
                Jarvis.setLED(131, 46, 118);
                Jarvis.noteOn(155);
                Jarvis.wait(100);
                Jarvis.noteOff();

                Jarvis.setLED(23, 88, 32);
                Jarvis.noteOn(123);
                Jarvis.wait(800);
                Jarvis.noteOff();

                Jarvis.setLED(253, 242, 45);
                Jarvis.noteOn(130);
                Jarvis.wait(600);
                Jarvis.noteOff();

                break;
            }

            DisplayMenuPrompt("J.A.R.V.I.S.'s Abilities Menu");
        }

        #endregion

        #region DATA RECORDER
        static void DataRecorderDisplayMenuScreen(Finch Jarvis)
        {
            int numberOfDataPoints = 0;
            double dataPointFrequency = 0;
            double[] temperatures = null;

            Console.CursorVisible = true;

            bool quitMenu = false;
            string menuChoice = null;
            bool valid = false;

            do
            {
                DisplayHeader("Data Recorder Menu");

                Console.WriteLine("\t\ti Number of Data Points");
                Console.WriteLine("\t\tr Frequency of Data Points");
                Console.WriteLine("\t\to Get Data");
                Console.WriteLine("\t\tn Show Data");
                Console.WriteLine("\t\t* Get Light Data");
                Console.WriteLine("\t\t. Return to Main Menu");
                Console.Write("\n\t\tPlease enter the corresponding letter from the menu:  ");
                menuChoice = Console.ReadLine().ToLower();                                                                 //Allows the user input to be stored in menuChoice variable and also converts user input to lower case      

                if (string.Equals(menuChoice, "i") || string.Equals(menuChoice, "r") || string.Equals(menuChoice, "o") || string.Equals(menuChoice, "n") || string.Equals(menuChoice, "*") || string.Equals(menuChoice, "."))
                {                                                                                                            //"if" user input (menuChoice) is equal to any of the options "i""o", etc. then the if condition is true
                    valid = true;                                                                                           //Since "valid" is technically "false" when declared, we have to change it to true in the if statement so the option is recognized as true and not false
                    Console.WriteLine($"\t\t{menuChoice} is valid.  You may proceed.");
                    Console.WriteLine("\t\tPRESS ANY KEY TO CONTINUE");
                    Console.ReadKey();
                }
                else                                                                                                       //Otherwise the statement is false, displaying that message and it will run through the while loop until user input is true
                {
                    Console.WriteLine($"{menuChoice} is invalid.  Try again.");
                    Console.ReadKey();
                }
                                                                                                                            //fail safe to ensure that after the user input has been recognized as true
                                                                                                                            //that you will exit out of the loop.
                switch (menuChoice)
                {
                    case "i":
                        numberOfDataPoints = DataRecorderDisplayGetNumberOfDataPoints();
                        break;

                    case "r":
                        dataPointFrequency = DataRecorderDisplayGetDataPointFrequency();
                        break;

                    case "o":
                        temperatures = DataRecorderDisplayGetData(numberOfDataPoints, dataPointFrequency, Jarvis);
                        break;

                    case "n":
                        DataRecorderDisplayDataTable(temperatures);
                        break;

                    case "*":
                        GetLightData(Jarvis);
                        break;


                    case ".":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPLEASE ENTER A LETTER FOR THE THE MENU CHOICE");
                        break;
                 }
        
            } while (!quitMenu);
        }

        static void DataRecorderDisplayDataTable(double[] temperatures)
        {
            DisplayHeader("Show Data");

            //
            // display table headers
            //

            Console.WriteLine( 
                "Recording #".PadLeft(17) + 
                "Temp".PadLeft(12)
                );

            Console.WriteLine(
              "\n__________".PadLeft(15) +
           "__________".PadLeft(15)
                );

            //
            // Display Table Data
            //

            for (int index = 0; index < temperatures.Length; index++)
            {
                Console.WriteLine(
                    (index + 1).ToString().PadLeft(15) +
                    temperatures[index].ToString("n2").PadLeft(15) + "°F"
                    );
            }

            DisplayContinuePrompt();
        }
        static void DataRecorderDisplayGetData(double[] temperatures)
        {
            DisplayHeader("Show Data");

            DataRecorderDisplayTable(temperatures);

            DisplayContinuePrompt();
        }
        static void DataRecorderDisplayTable(double[] temperatures)
        {
            //
            // display table headers
            //
            Console.WriteLine(
                "Recording #".PadLeft(17) +
                "Temp".PadLeft(12)
                );
            Console.WriteLine(
                "__________".PadLeft(15) +
           "__________".PadLeft(15)
                );


            //
            // Display Table Data
            //

            for (int index = 0; index < temperatures.Length; index++)
            {
                double fahrenheit = ConvertCelsiusToFahrenheit(temperatures[index]);            //find celcius data


                Console.WriteLine(
                    (index + 1).ToString().PadLeft(15) +
                    temperatures[index].ToString("n2").PadLeft(15) + "°F"
                    );
            }
        DisplayContinuePrompt();

        }

        #region CONVERT CELSIUS TO FAHRENHEIT
        /// <summary>
        /// Converting Celsius to Fahrenheit
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }
        #endregion


        static double[] DataRecorderDisplayGetData(int numberOfDataPoints, double dataPointFrequency, Finch jarvis)
        {
            double[] temperatures = new double[numberOfDataPoints];
            
            DisplayHeader("Get Data");

            Console.WriteLine($"\t\tNumber of data points: {numberOfDataPoints}");
            Console.WriteLine($"\t\tData point frequency: {dataPointFrequency}");
            Console.WriteLine();

            Console.WriteLine("\t\tJarvis is ready to begin recording the temperature data.");
            Console.WriteLine("\t\tPress Any Key To Continue.");
            DisplayContinuePrompt();

            for  (int index = 0; index < numberOfDataPoints; index++)
            {
                temperatures[index] = jarvis.getTemperature();
                Console.WriteLine($"\t\tReading {index + 1}:{temperatures[index].ToString("n2")}");
                int waitInSeconds = (int)(dataPointFrequency * 1000);
                jarvis.wait(waitInSeconds);
            }
            Console.WriteLine("\t\tYour data recording has been completed.");
            DisplayContinuePrompt();


            DisplayHeader("Get Data");
            Console.WriteLine();

            Console.WriteLine("\t\tTable of Temperatures");
            Console.WriteLine();

            DataRecorderDisplayTable(temperatures);

            DisplayContinuePrompt();

            return temperatures;
        }

    /// <summary>
    /// Get the frequency of data points from the user
    /// </summary>
    /// <returns>frequency of data points</returns>
    /// 

        static double DataRecorderDisplayGetDataPointFrequency()
        {
            double dataPointFrequency;

            DisplayHeader("Data Point Frequency");

            Console.Write("\t\tEnter the frequency (in seconds) you would like to receive data points:  ");
            double.TryParse(Console.ReadLine(), out dataPointFrequency);                                                                            //we have to convert the string to a double for the array
                                                                                                                                                    //we have to convert the string to a double for the array
                                                                                                                                                        //so even though its a number that is being typed in it thinks its a string
                                                                                                                                                  //this way the user can enter decimal numbers as well

            if (dataPointFrequency >= -0 && dataPointFrequency <= 9999999)
            {
                Console.WriteLine($"\t\t{dataPointFrequency} has been accepted, you may proceed!");
                Console.ReadKey();
                DisplayContinuePrompt();
            }
            else
            {
                Console.WriteLine("\t\tYour entry is invalid. Please press any key to try again....");
                Console.ReadKey();
                DataRecorderDisplayGetDataPointFrequency();
            }          

            return dataPointFrequency;
        }

        /// <summary>
        /// Get The Number of Data Points from the User
        /// </summary>
        /// <returns> number of data points </returns>

        static int DataRecorderDisplayGetNumberOfDataPoints()
        {
            int numberOfDataPoints;

            DisplayHeader("Number of Data Points");

            Console.Write("\t\tEnter the number of data points:  ");

            int.TryParse(Console.ReadLine(), out numberOfDataPoints);

            if ( numberOfDataPoints >= -0 && numberOfDataPoints <= 9999999 )
            {
                Console.WriteLine($"\t\t{numberOfDataPoints} has been accepted, please proceed!");
                Console.ReadKey();
                DisplayContinuePrompt();
            }
            else
            {
                Console.WriteLine("\t\tYour entry is invalid. Please press any key to try again.....");
                Console.ReadKey();
                DataRecorderDisplayGetNumberOfDataPoints();
            }

            return numberOfDataPoints;
        }

        static int[] GetLightData(Finch Jarvis)
        {
            DisplayHeader("Jarvis will see how much light is nearby!");
            DisplayContinuePrompt();

            int[] lightSensor = Jarvis.getLightSensors();
            Array.Sort(lightSensor);

            for (int index = 0; index < lightSensor.Length; index++)
            {
                Console.WriteLine($"\t\t1, 2, 3 Go!  {lightSensor[index]}");
            }            

            DisplayContinuePrompt();
            
            return lightSensor;
        }
        #endregion



        #region FINCH ROBOT MANAGEMENT

        /// <summary>
        /// *****************************************************************
        /// *               Disconnect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="Jarvis">finch robot object</param>
        static void DisplayDisconnectFinchRobot(Finch Jarvis)
        {
            Console.CursorVisible = false;

            DisplayHeader("Disconnecting J.A.R.V.I.S.\n");

            int valid = 450;
            double userAnswer;

            Console.WriteLine("\n\t\tSolve this equation? 60 / 2 (10+5)\n");
            Console.WriteLine("\n\t\tPlease enter your answer:\n");
            userAnswer = Convert.ToInt32(Console.ReadLine());

            DisplayContinuePrompt();


            if (userAnswer == valid)
            {
                Console.WriteLine("Your answer {0} is correct!  Congratulations you may proceed.", userAnswer);
            }
            else
            {
                Console.WriteLine("You really thought you could outsmart J.A.R.V.I.S? {0} is wrong.  The answer is: 450.", userAnswer);
            }

            Console.WriteLine("\n\t\tClean Slate Protocol, Sir?\n");
            DisplayContinuePrompt();

            Jarvis.disConnect();

            Console.WriteLine("\n\t\tAs always sir, a great pleasure watching you work.\n");

            DisplayMenuPrompt("J.A.R.V.I.S.'S MAIN FRAME");
        }

        /// <summary>
        /// *****************************************************************
        /// *                  Connect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        /// <returns>notify if the robot is connected</returns>
        /// 
        static bool DisplayConnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            bool robotConnected;

            DisplayHeader("J.A.R.V.I.S Initializing");

            Console.WriteLine("\n\t\tPlease be sure the USB cable is connected to J.A.R.V.I.S. and the computer.\n");
            DisplayContinuePrompt();

            robotConnected = finchRobot.connect();

            while(robotConnected)
            {
                finchRobot.setLED(0, 100, 0);
                finchRobot.noteOn(261);
                finchRobot.wait(500);
                finchRobot.noteOff();
                finchRobot.noteOn(246);
                finchRobot.wait(500);
                finchRobot.noteOff();
                finchRobot.noteOn(220);
                finchRobot.wait(500);
                finchRobot.noteOff();

                Console.WriteLine("\n\t\tHello, I am J.A.R.V.I.S. ");
                Console.ReadKey();
                break;

            }
            if (!(robotConnected))
            {
                Console.WriteLine("I am unable to access the mainframe, what are you trying to...Please check the USB connection and try again!");

            }

            // TODO test connection and provide user feedback - text, lights, sounds

            DisplayMenuPrompt("J.A.R.V.I.S's MAIN FRAME");

            // reset finch robot
            
            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            return robotConnected;
        }

        #endregion

        #region USER INTERFACE

        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t\tWelcome!\n");

            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE", "ru-RU" };
            Console.WriteLine("\n\t\tThe current date and time in Traverse City is {0}.", DateTime.Now);

            double cost = .01;
            Console.WriteLine($"\n\t\tA ${cost.ToString("N2")} for your thoughts?");

            Console.WriteLine("\n\t\tJ.A.R.V.I.S. is ready to show off his abilities!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// display continue prompt
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\t\tPRESS ANY KEY TO CONTINUE.");
            Console.ReadKey();
        }

        /// display menu prompt
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\t\tPRESS ANY KEY TO RETURN TO {menuName} MENU.");
            Console.ReadKey();
        }

        /// display screen header
        static void DisplayHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
    }
}