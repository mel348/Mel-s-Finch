using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;

namespace Project_FinchControl
{
    public enum Command
    {
        NONE,
        MOVEFORWARD,
        MOVEBACKWARD,
        STOPMOTORS,
        WAIT,
        TURNRIGHT,
        TURNLEFT,
        LEDON,
        LEDOFF,
        GETTEMPERATURE,
        DONE
    }

    // **************************************************
    //
    // Title: Finch Control - Menu Starter
    // Description: Starter solution with the helper methods,
    //              opening and closing screens, and the menu
    // Application Type: Console
    // Author: Eman, Mel
    // Dated Created: 2/8/2021
    // Last Modified: 3/7/2021
    //
    // M3-S2 WALKTHROUGH: https://www.screencast.com/t/dwmpBL2XaUE
    // M3-S3 WALKTHROUGH: https://www.screencast.com/t/irI7O1zNrhz
    //
    // **************************************************

    class Program
    {
        static void Main(string[] args)
        {
            SetTheme();

            DisplayWelcomeScreen();
            DisplayMainMenuScreen();
            DisplayClosingScreen();
        }

        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.Black;
        }

            /// *****************************************************************
            /// *                       MAIN MENU                               *
            /// *****************************************************************

            #region DISPLAY EXIT
            static void DisplayExit(Finch Jarvis)
            {
                DisplayHeader("Exit");

                Console.WriteLine("\t\tExiting Program");
                DisplayContinuePrompt();
            }
            #endregion

            #region MAIN MENU SCREEN
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
                            LightAlarmMenu(Jarvis);
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
                            Console.WriteLine("\t\tJ.A.R.V.I.S does not understand your strange human ways! ");
                            DisplayContinuePrompt();
                            break;
                    }

                } while (!quitApplication);

            }
            #endregion

            /// *****************************************************************
            /// *                      TALENT SHOW                              *
            /// *****************************************************************

            #region DANCING
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
            #endregion

            #region MIXING IT UP
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
            #endregion

            #region TALENT SHOW MENU SCREEN
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
            #endregion

            #region LIGHT & SOUND
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

            /// ******************************************************************
            /// *                       DATA RECORDER                            *
            /// ******************************************************************

            #region DATA RECORDER MENU
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
            #endregion

            #region DATA TABLE
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
            #endregion

            #region MISC.
            static void DataRecorderDisplayGetData(double[] temperatures)
            {
                DisplayHeader("Show Data");

                DataRecorderDisplayTable(temperatures);

                DisplayContinuePrompt();
            }
            #endregion

            #region DISPLAY TABLE
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
            #endregion

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

            #region DISPLAY GET DATA
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

                for (int index = 0; index < numberOfDataPoints; index++)
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
            #endregion

            #region DATA POINT FREQUENCY
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
            #endregion

            #region NUMBER OF DATA POINTS
            static int DataRecorderDisplayGetNumberOfDataPoints()
            {
                int numberOfDataPoints;
                bool itsValid = false;

                DisplayHeader("Number of Data Points");                                         // Pass String literal to the DisplayHeader method

                do
                {

                    Console.Write("\t\tEnter the number of data points:  ");                        // Prompt user

                    int.TryParse(Console.ReadLine(), out numberOfDataPoints);                       //  Collect their entry once per validation check

                    // VALIDATION CHECK
                    if (numberOfDataPoints >= 0 && numberOfDataPoints <= 9999999)
                    {
                        Console.WriteLine($"\t\t{numberOfDataPoints} has been accepted, please proceed!");
                        itsValid = true;
                    }

                    else
                    {
                        Console.WriteLine("\t\tYour entry is invalid. Please try again.....");
                    }

                } while (!itsValid);

                DisplayContinuePrompt();

                return numberOfDataPoints;
            }
            #endregion

            #region LIGHT DATA
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

            /// ******************************************************************
            /// *                    LIGHT ALARM MENU                            *
            /// ******************************************************************

            #region ALARM MENU SCREEN
            static void LightAlarmMenu(Finch Jarvis)
            {
                Console.CursorVisible = true;

                bool quitMenu = false;
                string menuChoice = null;

                string sensorsToMonitor = "";                                                                                   //allows user to choose left, right, or both sensors
                string rangeType = "";                                                                                          //min or max value for our threshold of what we are monitoring
                int minMaxValue = 0;
                int timeToMonitor = 0;
                bool valid = false;

                do
                {
                    DisplayHeader("Light Alarm Menu");

                    Console.WriteLine("\t\tS Set Sensors to Monitor");
                    Console.WriteLine("\t\tH Set Range Type");
                    Console.WriteLine("\t\tI Set Minimum/Maximum Threshold Value");
                    Console.WriteLine("\t\tE Set Time to Monitor");
                    Console.WriteLine("\t\tL Set the Alarm");
                    Console.WriteLine("\t\tD Return to Main Menu");
                    Console.Write("\n\t\tPlease enter the corresponding letter from the menu:  ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    menuChoice = Console.ReadLine().ToUpper();                                                                 //Allows the user input to be stored in menuChoice variable and also converts user input to lower case      
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    if (string.Equals(menuChoice, "S") || string.Equals(menuChoice, "H") || string.Equals(menuChoice, "I") || string.Equals(menuChoice, "E") || string.Equals(menuChoice, "L") || string.Equals(menuChoice, "D"))
                    {                                                                                                            //"if" user input (menuChoice) is equal to any of the options "i""o", etc. then the if condition is true
                        valid = true;                                                                                           //Since "valid" is technically "false" when declared, we have to change it to true in the if statement so the option is recognized as true and not false
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"\n\t\t{menuChoice} is valid.  You may proceed.");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n\t\tPRESS ANY KEY TO CONTINUE");
                        Console.ReadKey();
                    }
                    else                                                                                                       //Otherwise the statement is false, displaying that message and it will run through the while loop until user input is true
                    {
                        Console.WriteLine($"\n\t\t{menuChoice} is invalid.  Try again.");
                        Console.ReadKey();
                    }


                    switch (menuChoice)
                    {
                        case "S":
                            sensorsToMonitor = LightAlarmSensors();
                            break;

                        case "H":
                            rangeType = LightAlarmRanges();
                            break;

                        case "I":
                            minMaxValue = LightAlarmMinMax(rangeType, Jarvis);
                            break;

                        case "E":
                            timeToMonitor = LightAlarmTime();
                            break;

                        case "L":
                            LightAlarmSet(Jarvis, sensorsToMonitor, rangeType, minMaxValue, timeToMonitor);
                            break;

                        case "D":
                            quitMenu = true;
                            break;

                        default:
                            Console.WriteLine();
                            Console.WriteLine("\t\tPLEASE ENTER A LETTER FOR YOUR MENU CHOICE");
                            break;
                    }

                } while (!quitMenu);
            }
            #endregion

            #region ALARM SENSORS
            static string LightAlarmSensors()
            {
                string sensorsToMonitor;
                bool valid = false;

                DisplayHeader("Sensors to Monitor");

                Console.Write("\n\t\tSensors to monitor [left, right, or both]: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                sensorsToMonitor = Console.ReadLine();

                if (sensorsToMonitor == "left" || sensorsToMonitor == "right" || sensorsToMonitor == "both")
                {
                    valid = true;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"\n\t\tYour sensor choice {sensorsToMonitor} has been accepted, please proceed!");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.WriteLine("\n\t\tYour entry is invalid. Please press any key to try again.....");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    //LightAlarmSensors();
                }

                DisplayMenuPrompt("Light Alarm");
                return sensorsToMonitor;
            }
            #endregion

            #region ALARM RANGES
            static string LightAlarmRanges()
            {
                string rangeType = null;
                bool valid = false;

                DisplayHeader("Range Type");
                Console.SetCursorPosition(5, 5);
                Console.Write("\t\tRange Type [minimum, maximum]: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                rangeType = Console.ReadLine();

                if (rangeType == "minimum" || rangeType == "maximum")
                {
                    valid = true;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"\n\t\tYour entry of {rangeType} has been accepted, please proceed!");
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }
                else
                {
                    Console.WriteLine("\n\t\tYour entry is invalid. Please press any key to try again.....");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.ReadKey();
                }

                DisplayMenuPrompt("Light Alarm");
                return rangeType;
            }
            #endregion

            #region MIN MAX VALUES
            static int LightAlarmMinMax(string rangeType, Finch jarvis)
            {
                int minMaxValue;

                DisplayHeader("Minimum/Maximum Threshold Value");
                Console.SetCursorPosition(5, 5);
                Console.WriteLine($"\n\t\tLeft light sensor ambient value: {jarvis.getLeftLightSensor()}");
                Console.WriteLine($"\n\t\tRight light sensor ambient value: {jarvis.getRightLightSensor()}");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"\n\t\tEnter the {rangeType} light sensor value: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.DarkRed;

                int.TryParse(Console.ReadLine(), out minMaxValue);

                if (minMaxValue >= -0 && minMaxValue <= 9999999)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"\n\t\t{minMaxValue} has been accepted, press any key to continue!");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\n\t\tYour entry is invalid.  Please press any key to try again.....");
                    Console.ReadKey();
                }
                DisplayMenuPrompt("Light Alarm");
                return minMaxValue;
            }
            #endregion

            #region ALARM TIME
            static int LightAlarmTime()
            {
                int timeToMonitor;

                DisplayHeader("Time to Monitor");

                Console.SetCursorPosition(5, 5);
                Console.Write($"\t\tPlease enter how many seconds you would like for monitoring to take:  ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                int.TryParse(Console.ReadLine(), out timeToMonitor);
                Console.ForegroundColor = ConsoleColor.DarkRed;

                if (timeToMonitor >= -0 && timeToMonitor <= 9999999)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"\n\t\tYour entry of {timeToMonitor} seconds has been accepted, Press any key to continue!");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\n\t\tYour entry is invalid.  Please press any key to try again.....");
                    Console.ReadKey();
                }

                DisplayMenuPrompt("Light Alarm");
                return timeToMonitor;
            }
            #endregion

            #region SET ALARM
            static void LightAlarmSet(
                Finch jarvis,
                string sensorsToMonitor,
                string rangeType,
                int minMaxValue,
                int timeToMonitor)
            {
                int secondsElapsed = 0;
                bool thresholdExceeded = false;
                int currentLightSensorValue = 0;

                DisplayHeader("Set Alarm");

                Console.SetCursorPosition(5, 5);
                Console.WriteLine($"\t\tSensors to Monitor {sensorsToMonitor}");
                Console.WriteLine("\t\tRange Type: {0}", rangeType);
                Console.WriteLine("\t\tMin/Max Threshold Value: " + minMaxValue);
                Console.WriteLine($"\t\tTime to Monitor: {timeToMonitor}");
                Console.WriteLine();

                Console.WriteLine("\n\t\tPress any key to start the alarm.");
                Console.ReadKey();
                Console.WriteLine();

                while ((secondsElapsed < timeToMonitor) && !thresholdExceeded)
                {
                    switch (sensorsToMonitor)
                    {
                        case "left":
                            currentLightSensorValue = jarvis.getLeftLightSensor();
                            break;

                        case "right":
                            currentLightSensorValue = jarvis.getRightLightSensor();
                            break;

                        case "both":
                            currentLightSensorValue = (jarvis.getLeftLightSensor() + jarvis.getRightLightSensor()) / 2;
                            break;
                    }

                    switch (rangeType)
                    {
                        case "minimum":
                            if (currentLightSensorValue < minMaxValue)
                            {
                                thresholdExceeded = true;
                            }
                            break;
                        case "maximum":
                            if (currentLightSensorValue > minMaxValue)
                            {
                                thresholdExceeded = true;
                            }
                            break;
                    }
                    jarvis.wait(1000);
                    secondsElapsed++;
                }
                if (thresholdExceeded)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    jarvis.setLED(100, 0, 0);
                    jarvis.noteOn(164);
                    jarvis.wait(1000);
                    jarvis.noteOff();
                    Console.WriteLine("\t\t***************");
                    Console.WriteLine("\t\t* WARNING!!!! *");
                    Console.WriteLine("\t\t***************");
                    Console.WriteLine($"\n\t\tThe {rangeType} threshold value of {minMaxValue} was exceeded by the current light sensor value of {currentLightSensorValue}.");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    jarvis.setLED(0, 100, 0);
                    jarvis.noteOn(260);
                    jarvis.wait(1000);
                    jarvis.noteOff();
                    Console.WriteLine($"\n\t\tThe {rangeType} threshold value of {minMaxValue} was not exceeded.");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }

                DisplayMenuPrompt("Light Alarm");
            }

            #endregion

            ///******************************************************************
            ///*                        USER PROGRAMMING                        *
            ///******************************************************************

            #region USER PROGRAMMING MENU
        static void UserProgrammingDisplayMenuScreen(Finch Jarvis)
        {
            string menuChoice;
            bool quitMenu = false;

            (int motorSpeed, int ledBrightness, double waitSeconds) commandParameters;
            commandParameters.motorSpeed = 0;
            commandParameters.ledBrightness = 0;
            commandParameters.waitSeconds = 0;

            List<Command> commands = new List<Command>();                                   //Tuple to store all three command parameters

            do
            {
                DisplayHeader("User Programming Menu");                                     //get user menu choice

                Console.WriteLine("\t\tV) Set Command Parameters");
                Console.WriteLine("\t\tE) Add Commands");
                Console.WriteLine("\t\tN) View Commands");
                Console.WriteLine("\t\tO) Execute Commands");
                Console.WriteLine("\t\tM) Return to Main Menu");
                Console.Write("\n\t\tWhat would you like to do? \n\t\t");
                menuChoice = Console.ReadLine().ToUpper();

                switch (menuChoice)
                {
                    case "V":
                        commandParameters = UserProgrammingDisplayGetCommandParameters();
                        break;

                    case "E":
                        UserProgrammingDisplayGetFinchCommands(commands);
                        break;

                    case "N":
                        UserProgrammingDisplayFinchCommands(commands);
                        break;

                    case "O":
                        UserProgrammingDisplayExecuteFinchCommands(Jarvis, commands, commandParameters);
                        break;

                    case "M":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\t\tJ.A.R.V.I.S does not understand your strange human ways! ");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitMenu);

        }
        #endregion

            #region GET COMMAND PARAMETERS FROM USER
        /// ************************************************************
        /// *           GET COMMAND PARAMETERS FROM USER               *
        /// ************************************************************
        /// <returns>Tuple of command parameters</returns>
        static (int motorSpeed, int ledBrightness, double waitSeconds) UserProgrammingDisplayGetCommandParameters()
        {
            DisplayHeader("Command Parameters");

            (int motorSpeed, int ledBrightness, double waitSeconds) commandParameters;
            commandParameters.motorSpeed = 0;
            commandParameters.ledBrightness = 0;
            commandParameters.waitSeconds = 0;

            GetValidInteger("\t\tEnter Motor Speed [1-255]: ", 1, 255, out commandParameters.motorSpeed);
            GetValidInteger("\t\tEnter LED Brightness [1-255]: ", 1, 255, out commandParameters.ledBrightness);
            GetValidDouble("\t\tEnter wait in Seconds: ", 1, 255, out commandParameters.waitSeconds);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\t\tMotor speed: {commandParameters.motorSpeed}");
            Console.WriteLine($"\t\tLED Brightness: {commandParameters.ledBrightness}");
            Console.WriteLine($"\t\tWait command duration: {commandParameters.waitSeconds}");
            Console.ForegroundColor = ConsoleColor.DarkRed;

            DisplayMenuPrompt("User Programming");

            return commandParameters;

        }
        #endregion

            #region CHECK USER INPUT VALIDATION

        static void GetValidInteger(string userPrompt, int minSpeed, int maxSpeed, out int userResponse)         //this is similar to a parallel array. 
        {                                                                                                       //You are comparing these variables (in order) with the GetValidInteger prompt for user input.
            bool validInteger = false;                                                                          //flag used to escape the do/while loop

            do
            {
                Console.Write(userPrompt);                                                                  //prompt the user
                Console.ForegroundColor = ConsoleColor.Cyan;
                Int32.TryParse(Console.ReadLine(), out userResponse);                                           //store user input and check validation
                Console.ForegroundColor = ConsoleColor.DarkRed;

                if (userResponse >= minSpeed && userResponse <= maxSpeed)                                       //Validation Check... number needs to be within min and max range
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t\tYour entry has been accepted. Please proceed.\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    validInteger = true;                                                                       // Set our flag to true because they entered a valid number and exit
                }
                else
                {
                    Console.WriteLine("\t\tOops looks like you entered a number outside of the range. Please enter a number between 1-255.");
                }

            } while (!validInteger);                                                                            //when validInteger is true it will end the loop

        }
        static void GetValidDouble(string userPrompt, int minSpeed, int maxSpeed, out double userResponse)      //Comparing variables (in order) with the GetValid Integer prompt for user input
        {
            bool validDouble = false;                                                                           //flag used to escape the do/while loop

            do
            {
                Console.Write(userPrompt);                                                                  //prompt the user
                Console.ForegroundColor = ConsoleColor.Cyan;
                double.TryParse(Console.ReadLine(), out userResponse);                                          //store user input and check validation
                Console.ForegroundColor = ConsoleColor.DarkRed;

                if (userResponse >= minSpeed && userResponse <= maxSpeed)                                       //Validation Check...number needs to be within min and max range.
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\t\tYour entry has been accepted. Please proceed.\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    validDouble = true;                                                                         //set our flag to true because they entered a valid number and exit
                }
                else
                {
                    Console.WriteLine("\t\tOops looks like you entered a number outside of the range.  Please enter a number between 1-255.");
                }
            } while (!validDouble);                                                                             //when validInteger is true it will end the loop
        }


        #endregion

            #region GET FINCH COMMANDS 
        /// *************************************************************
        /// *               GET FINCH COMMANDS                          *
        /// *************************************************************
        /// <param name="commands"></param>
        static void UserProgrammingDisplayGetFinchCommands(List<Command> commands)
        {
            Command command = Command.NONE;                                             //none = default (no value)

            DisplayHeader("Finch Robot Commands");

            int commandCount = 1;                                                       //list commands
            Console.WriteLine("\t\tList of Available Commands");
            Console.WriteLine();
            Console.WriteLine();

            foreach (string commandName in Enum.GetNames(typeof(Command)))              //instead of listing out all of the user choices individually i.e. console.writeline();
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\t\t- {commandName.ToLower()}\n");                  //take string (to lower case)
                if (commandCount % 11 == 0) Console.Write("\t\t\n");                   //counts how many can be run on that line
                commandCount++;
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }

            Console.WriteLine();
            Console.WriteLine("\t\tAfter you enter all the commands you would like Jarvis to perform.");
            Console.WriteLine("\n\t\tWhen there are no more commands you want to enter type DONE to complete the process.");


            while (command != Command.DONE)                                             //loop that allows us to continue to get commands from the user
            {
                Console.Write("\n\t\t Command:  ");
                Console.ForegroundColor = ConsoleColor.Cyan;

                if (Enum.TryParse(Console.ReadLine().ToUpper(), out command))           //have to convert user input to all uppercase before you compare it to the enumeration variables
                {
                    commands.Add(command);                                              //added to commands list
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\t******************************************************");
                    Console.WriteLine("\t\t*     PLEASE ENTER ONE OF THE PROVIDED OPTIONS       *");
                    Console.WriteLine("\t\t******************************************************");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
            }

            Console.WriteLine("\n\t\tThe orders you are giving to Jarvis: ");

            foreach (Command element in commands)                                       //syntax is foreach( data type and temp variable in(keyword) commands (iterable items - command is our list)
            
            {                                                                           //each element will take the first command in the list and store it into element and print element.
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\n\t\t{element}\n");
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            
            DisplayMenuPrompt("User Programming");
        }
            #endregion

            #region DISPLAY FINCH COMMANDS
            /// **********************************************
            /// *           DISPLAY FINCH COMMANDS           *
            /// **********************************************
            static void UserProgrammingDisplayFinchCommands(List<Command> commands)
            {
                Command command = Command.NONE;                                             //none = default (no value)

                int count = 1;
                Console.WriteLine("\t\tList of Available Commands");

                foreach (string commandName in Enum.GetNames(typeof(Command)))              //instead of listing out all of the user choices individually i.e. console.writeline();
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\t\t- {commandName.ToLower()}\n");                  //take string (to lower case)
                    if (count % 11 == 0) Console.Write("\t\t\n");                   //counts how many can be run on that line
                    count++;
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                }
                DisplayMenuPrompt("User Programming");
            }

            #endregion

            #region EXECUTE COMMANDS
            /// ************************************************
            /// *           EXECUTE COMMANDS                   *
            /// ************************************************
            static void UserProgrammingDisplayExecuteFinchCommands(
               Finch Jarvis,                                                                                 //send the finch robot, because we are going to work with a finch robot       
               List<Command> commands,                                                                       //send all the commands
               (int motorSpeed, int ledBrightness, double waitSeconds) commandParameters)                    //send the command parameters...need to know user input for these commands
            {                                                                                                //unwind command parameters from the basket
                int motorSpeed = commandParameters.motorSpeed;                                               //want motorSpeed to be equal to basket speed                                 
                int ledBrightness = commandParameters.ledBrightness;
                int waitMilliSeconds = (int)(commandParameters.waitSeconds * 1000);                         //take user input for waitSeconds multiply by 1000 for milliseconds.need an integer for milliseconds, can't use double
                string commandFeedback = "";                                                                //user feedback
                const int TURNING_MOTOR_SPEED = 100;                                                        //USE ALL UPPERCASE FOR CONSTANTS WITH UNDERSCORE BETWEEN WORDS

                DisplayHeader("Deploy Jarvis");

                Console.WriteLine("\t\tJarvis is ready to give his orders!");

                foreach (Command command in commands)                                                        //cycle through this loop for each of the commands
                {
                    switch (command)                                                                        //focuses on command, and creates feedback
                    {                                                                                       //every time run through the loop you run one of the cases in the block
                        case Command.NONE:                                                                  //it will do something with the finch and provide feedback after
                            break;

                            case Command.MOVEFORWARD:                                                            //have to reference the Command enum
                            Console.WriteLine("\t\tMoving Forward...");
                            Jarvis.setMotors(motorSpeed, motorSpeed);                                        //user input
                            Jarvis.wait(waitMilliSeconds);
                            commandFeedback = Command.MOVEFORWARD.ToString();                               //turn enum into string so command feedback will work
                            break;

                        case Command.MOVEBACKWARD:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\t\tMoving Backwards...");
                            Jarvis.setMotors(-motorSpeed, -motorSpeed);
                            Jarvis.wait(waitMilliSeconds);
                            commandFeedback = Command.MOVEBACKWARD.ToString();
                            break;

                        case Command.STOPMOTORS:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\t\tStopping the motors...");
                            Jarvis.setMotors(0, 0);
                            Jarvis.wait(waitMilliSeconds);
                            commandFeedback = Command.STOPMOTORS.ToString();
                            break;

                        case Command.WAIT:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\t\tMaking Jarvis wait...");
                            Jarvis.wait(waitMilliSeconds);
                            commandFeedback = Command.WAIT.ToString();
                            break;

                        case Command.TURNRIGHT:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\t\tTurning Right...");
                            Jarvis.setMotors(TURNING_MOTOR_SPEED, -TURNING_MOTOR_SPEED);
                            Jarvis.wait(waitMilliSeconds);
                            commandFeedback = Command.TURNRIGHT.ToString();
                            break;

                        case Command.TURNLEFT:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\t\tTurning Left...");
                            Jarvis.setMotors(-TURNING_MOTOR_SPEED, TURNING_MOTOR_SPEED);
                            Jarvis.wait(waitMilliSeconds);
                            commandFeedback = Command.TURNLEFT.ToString();
                            break;

                        case Command.LEDON:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\t\tLights on!!");
                            Jarvis.setLED(ledBrightness, ledBrightness, ledBrightness);
                            Jarvis.wait(waitMilliSeconds);
                            commandFeedback = Command.LEDON.ToString();
                            break;

                        case Command.LEDOFF:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\t\tLights off!!");
                            Jarvis.setLED(0, 0, 0);
                            Jarvis.wait(waitMilliSeconds);
                            commandFeedback = Command.LEDOFF.ToString();
                            break;

                        case Command.GETTEMPERATURE:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\t\tTime to get the temperature...");
                            commandFeedback = $"Temperature: {Jarvis.getTemperature().ToString("n2")}\n";
                            Jarvis.wait(waitMilliSeconds);
                            break;                                                                                  //interpilation to get a string, it will return a double value and convert to a string, n2 rounds to 2 decimals places

                        case Command.DONE:
                            Console.ForegroundColor = ConsoleColor.White;
                            Jarvis.wait(waitMilliSeconds);
                            commandFeedback = Command.DONE.ToString();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;

                        default:
                            break;
                     Console.WriteLine("\t\tJarvis has completed his orders!");
                    }
                    
                    Console.WriteLine($"\t\t{commandFeedback}");
                }
            DisplayMenuPrompt("User Programming");
           
            }
            #endregion

            ///******************************************************************
            ///*                    FINCH ROBOT MANAGEMENT                      *
            ///******************************************************************

            #region DISCONNECT FINCH
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
            #endregion

            #region CONNECT FINCH 
            static bool DisplayConnectFinchRobot(Finch finchRobot)
            {
                Console.CursorVisible = false;

                bool robotConnected;

                DisplayHeader("J.A.R.V.I.S Initializing");

                Console.WriteLine("\n\t\tPlease be sure the USB cable is connected to J.A.R.V.I.S. and the computer.\n");
                DisplayContinuePrompt();

                robotConnected = finchRobot.connect();

                while (robotConnected)
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

                    Console.WriteLine("\n\t\tHello, I am J.A.R.V.I.S. Press any key to start the program!");
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

            ///******************************************************************
            ///*                          USER INTERFACE                        *
            ///******************************************************************

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

            static void DisplayContinuePrompt()
            {
                Console.WriteLine();
                Console.WriteLine("\t\tPRESS ANY KEY TO CONTINUE.");
                Console.ReadKey();
            }
            static void DisplayMenuPrompt(string menuName)
            {
                Console.WriteLine();
                Console.WriteLine($"\t\tPRESS ANY KEY TO RETURN TO {menuName} MENU.");
                Console.ReadKey();
            }
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


