using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Threading;

namespace LowBudgetMotorsportManager
{
    public static class Game
    {
        //Test Stuff//
        static int tableWidth = 73;

        //Driver Strings//
        //OWT1 Drivers//
        //static string 
        private static string[] OWT1RandomDriver = new string[22] { "Driver 1", "Driver 2", "Driver 3", "Driver 4", "Driver 5", "Driver 6", "Driver 7", "Driver 8", "Driver 9", "Driver 10", "Driver 11", "Driver 12", "Driver 13", "Driver 14", "Driver 15", "Driver 16", "Driver 17", "Driver 18", "Driver 19", "Driver 20", "Driver 21", "Driver 22" };

        //Championship Strings
        static string OWT1 = "Formula Ultra";
        //static string OWT2 = "Formula Nitro";
        //static string OWT3 = "Formula Turbo";
        //static string SCT1 = "Stockcar";
        //static string SCT2 = "Truckcar";
        //static string ENDUT1 = "Prototype World Challenge 1";
        //static string ENDUT2 = "Prototype World Challenge 2";
        //static string ENDUT3 = "Prototype World Challenge 3";
        //static string GTT1 = "GT1";
        //static string GTT2 = "GT2";
        //static string GTT3 = "GT3";
        //static string TCT1 = "Touring Car Masters";
        //static string TCT2 = "Touring Car Championship";

        //Championship Strings
        static string OWT1S = "FU";
        //static string OWT2S = "FN";
        //static string OWT3S = "FT";
        //static string SCT1S = "Stockcar";
        //static string SCT2S = "Truckcar";
        //static string ENDUT1S = "PWC1";
        //static string ENDUT2S = "PWC2";
        //static string ENDUT3S = "PWC3";
        //static string GTT1S = "GT1";
        //static string GTT2S = "GT2";
        //static string GTT3S = "GT3";
        //static string TCT1S = "TCM";
        //static string TCT2S = "TCC";

        //Mail Strings//


        //Year Strings//
        static string CYear = "2020";
        static string LYear = "2019";
        static string NYear = "2021";

        //News outlet strings//
        static string NewsOutlet1 = "Channel 69420";
        static string NewsOutlet1Mail = "Channel69420";

        //Weather//
        private static string[] WeatherType = new string[9] { "Clear", "Light Cloud", "Partially Cloudy", "Cloudy", "Overcast", "Light Rain", "Rain", "Heavy Rain", "Monsoon" };
        private static int randomIndex = -1;
        private static String UserInput = "";
        private static string[] AUSTemp = new string[13] { "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28" };

        //CURRENT//
        //Team Strings//
        static string CharacterName = "";
        static string TeamName = "";
        static string TeamChairman = "Place Chairman";
        static string ChairmanEmail = "PChairman";
        static string TeamDriver1 = "";
        static string TeamDriver2 = "";
        //static string TeamDriver3 = "";
        //static string TeamDriver4 = "";
        //static string TeamDriver5 = "";
        //static string TeamDriver6 = "";
        static string TeamEngineer = "";
        //Current Track
        //Current Calendar

        //Radio Strings
        static string[] RadioCheck = { "10-4, Loud and clear", " Unable to hear you", " Still can't here you" };

        //SessionStartRaceControl
        static string[] RaceControlSessionCountDown = { "Session goes green in :", "10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "Session is now green" };

        //OWT1 ONLY STATIC STRINGS//
        ////////////////////////////



        //Teams//
        static string[] OWT1Teams = { "Pole Position Racing", "Kone Killers", "Party Mode GP", "Team Fullspeed", "Cornercut Motorsport", "Bad Decision Racing",
                                    "Backmarker Racing", "Infinity Motorsport", "Team Divebomb", "Smooth Operators", "Wrong Wheel Drive Mafia", "Inglorious Bastards"};
        static string[] OWT1TeamsRandom = new string[12] { "Pole Position Racing", "Kone Killers", "Party Mode GP", "Team Fullspeed", "Cornercut Motorsport", "Bad Decision Racing",
                                    "Backmarker Racing", "Infinity Motorsport", "Team Divebomb", "Smooth Operators", "Wrong Wheel Drive Mafia", "Inglorious Bastards"};

        static string[] PPR = { "Pole Position Racing", "PPR" };
        static string[] KKL = { "Kone Killers", "KKL" };

        //Circuits - Australia
        static string[] Albertpark = { "Albert Park Street Circuit", "Albert Park", "Melbourne", "Australia", "	5.303 km (3.296 mi)", "58 Laps", "1996",
                                        "The entire track consists of normally public roads, each sector includes medium to high speed characteristics more commonly associated with dedicated racetracks facilitated by\ngrass and gravel run-off safety zones that are reconstructed annually. However, the circuit also has characteristics of a street circuit's enclosed nature due to concrete barriers.",
                                        "This track has loads of medium to high downforce turns. With some very important braking zones, key to fast and consistant laptimes.\nAnd with tyre wear being low, tyre management should be very important during the race."};

        //Circuits - Austria

        //Circuits - Argentina
        //Buenos Aires

        //Circuits - Bahrain
        //Bahrain

        //Circuits - Belgium
        //Spa

        //Circuits - Brazil
        //Interlagos

        //Zolder


        //Calendar//
        static string OWT1R0S = "0 - 17";

        //Intro Choices//
        static string[] TypedWrong = { "Type it again, make sure you have no typos." };

        //Scenarios//
        static int PracticeScenarios = 10;
        static string[] PartOne = { "Test" };
        static string[] PartTwo = { "Test" };
        static string[] PartThree = { "Test" };
        static string[] PartFour = { "Test" };
        static string[] PartFive = { "Test" };
        static string[] PartSix = { "Test" };
        static string[] PartSeven = { "Test" };
        static string[] PartEight = { "Test" };
        static string[] PartNine = { "Test" };
        static string[] PartTen = { "Test" };
        public static void StartGame()
        {
            //Intro and Title//  
            GameTitle();

            //Starting Game//

            NameCharacter();
            TeamChoice();

            OWT1Intro();

            //Menu's//
            Menu0();
            Menu9();

            //RaceWeekend//
            Random();
            PracticeOWT1();
            RandomRace();
            OWT1Race();

            ///GAME///

            //EXIT GAME//
            EndGame();

            static void NameCharacter()
            {
                Console.WriteLine("It's time to start your manager career. What is your name?");
                CharacterName = Console.ReadLine();
                Console.WriteLine("Welcome to the world of Motorsport " + CharacterName + "!");

            }

            static void TeamChoice()
            {
                string input = "";
                Console.WriteLine(CharacterName + ", Which racing series will you choose? Open Wheel (OW), GT, Endurance (ER), Stockcar (SC) or Touring Car (TC). Use the 2 letter abbreviation to choose your series.");
                input = Console.ReadLine();
                input = input.ToUpper();
                /////////////////////////////////////////Open Wheel Stuff/////////////////////////////////////////
                if (input == "OW")
                {
                    Console.WriteLine("\nWelcome to Open Wheel racing! There are 3 Tiers. Formula Ultra, Nitro and Turbo. Use T1-3 to choose your series!");
                    input = Console.ReadLine();
                    /////////////////////////////////////////Tier 1 Stuff/////////////////////////////////////////
                    input = input.ToUpper();
                    if (input == "T1")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(@"
   ____  ____    ___    __  ___  __  __   __    ___        __  __   __  ______   ___    ___                    
  / __/ / __ \  / _ \  /  |/  / / / / /  / /   / _ |      / / / /  / / /_  __/  / _ \  / _ |                   
 / _/  / /_/ / / , _/ / /|_/ / / /_/ /  / /__ / __ |     / /_/ /  / /__ / /    / , _/ / __ |                   
/_/    \____/ /_/|_| /_/  /_/  \____/  /____//_/ |_|     \____/  /____//_/    /_/|_| /_/ |_| ");
                        Console.ResetColor();
                        Console.WriteLine("\n \nThe pinnacle of motorsport. 12 of the best teams and 24 of the best drivers go against eachother on the worlds most famous tracks.\n");
                        Console.WriteLine(@"Now the most important thing, Choosing the team you want the manage!

COLOR        TEAM NAME                   ABBREVIATION     PERFORMANCE LEVEL");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("DarkMagenta  Pole Position Racing            PPR");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Cyan         Kone Killers                    KKL");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Green        Party Mode GP                   PGP");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("White        Team Fullspeed                  TFS");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Red          Cornercut Motorsport            CCM");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Blue         Bad Decision Racing             BDR");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Yellow       Backmarker Racing               BMR");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("DarkBlue     Infinity Motorsport             IFM");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("DarkGreen    Team Divebomb                   TDB");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("DarkCyan     Smooth Operators                SOP");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("DarkRed      Wrong Wheel Drive Mafia         WWD");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Magenta      Inglorious Bastards             IGB");
                        Console.ResetColor();
                        Console.WriteLine("\nUse the abbreviation to choose your team.");
                        /////////////////////////////////////////Tier 1 Choose Team/////////////////////////////////////////                         
                        input = Console.ReadLine();
                        input = input.ToUpper();
                        if (input == "PPR") { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write(@"                  
  _      __        __                            ______                                                        
 | | /| / / ___   / / ____ ___   __ _  ___      /_  __/ ___                                                    
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)      / /   / _ \                                                   
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      /_/    \___/   
                                                                            
   ___         __             ___              _   __    _                    ___               _              
  / _ \ ___   / / ___        / _ \ ___   ___  (_) / /_  (_) ___   ___        / _ \ ___ _ ____  (_)  ___   ___ _
 / ___// _ \ / / / -_)      / ___// _ \ (_-< / / / __/ / / / _ \ / _ \      / , _// _ `// __/ / /  / _ \ / _ `/
/_/    \___//_/  \__/      /_/    \___//___//_/  \__/ /_/  \___//_//_/     /_/|_| \_,_/ \__/ /_/  /_//_/ \_, / 
                                                                                                        /___/  "); TeamName = "Pole Position Racing"; TeamDriver1 = "Mark Rutte"; TeamDriver2 = "Philip Dyer"; TeamChairman = "Jeremy Mayfield"; TeamEngineer = "Andrew Hawkins"; ChairmanEmail = "JMayfieldyes"; }
                        if (input == "KKL") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(@"
  _      __        __                            ______                                     
 | | /| / / ___   / / ____ ___   __ _  ___      /_  __/ ___                                 
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)      / /   / _ \                                
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      /_/    \___/                                
   __ __                        __ __   _    __   __                                        
  / //_/ ___   ___  ___        / //_/  (_)  / /  / / ___   ____  ___                        
 / ,<   / _ \ / _ \/ -_)      / ,<    / /  / /  / / / -_) / __/ (_-<                        
/_/|_|  \___//_//_/\__/      /_/|_|  /_/  /_/  /_/  \__/ /_/   /___/ 
                                                                    "); TeamName = "Kone Killers"; }
                        if (input == "PGP") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"
  _      __        __                            ______                           
 | | /| / / ___   / / ____ ___   __ _  ___      /_  __/ ___                       
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)      / /   / _ \                      
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      /_/    \___/                      
   ___               __                __  ___          __            _____   ___ 
  / _ \ ___ _  ____ / /_  __ __       /  |/  / ___  ___/ / ___       / ___/  / _ \
 / ___// _ `/ / __// __/ / // /      / /|_/ / / _ \/ _  / / -_)     / (_ /  / ___/
/_/    \_,_/ /_/   \__/  \_, /      /_/  /_/  \___/\_,_/  \__/      \___/  /_/    
                        /___/                                                    "); TeamName = "Patry Mode GP"; }

                        if (input == "TFS") { Console.Clear(); Console.ForegroundColor = ConsoleColor.White; Console.Write(@"
  _      __        __                            ______                           
 | | /| / / ___   / / ____ ___   __ _  ___      /_  __/ ___                       
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)      / /   / _ \                      
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      /_/    \___/                      
 ______                          ____         __   __                           __
/_  __/ ___  ___ _  __ _        / __/ __ __  / /  / /  ___   ___  ___  ___  ___/ /
 / /   / -_)/ _ `/ /  ' \      / _/  / // / / /  / /  (_-<  / _ \/ -_)/ -_)/ _  / 
/_/    \__/ \_,_/ /_/_/_/     /_/    \_,_/ /_/  /_/  /___/ / .__/\__/ \__/ \_,_/  
                                                          /_/                    "); TeamName = "Team Fullspeed"; }
                        if (input == "CCM") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"
  _      __        __                            ______                                                            
 | | /| / / ___   / / ____ ___   __ _  ___      /_  __/ ___                                                        
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)      / /   / _ \                                                       
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      /_/    \___/                                                       
  _____                                         __         __  ___       __                                     __ 
 / ___/ ___   ____  ___  ___   ____ ____ __ __ / /_       /  |/  / ___  / /_ ___   ____  ___   ___  ___   ____ / /_
/ /__  / _ \ / __/ / _ \/ -_) / __// __// // // __/      / /|_/ / / _ \/ __// _ \ / __/ (_-<  / _ \/ _ \ / __// __/
\___/  \___//_/   /_//_/\__/ /_/   \__/ \_,_/ \__/      /_/  /_/  \___/\__/ \___//_/   /___/ / .__/\___//_/   \__/ 
                                                                                            /_/                   "); TeamName = "Cornercut Motorsport"; }
                        if (input == "BDR") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Blue; Console.Write(@"
  _      __        __                            ______                                                      
 | | /| / / ___   / / ____ ___   __ _  ___      /_  __/ ___                                                  
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)      / /   / _ \                                                 
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      /_/    \___/                                                 
   ___            __        ___              _         _                    ___               _              
  / _ ) ___ _ ___/ /       / _ \ ___  ____  (_)  ___  (_) ___   ___        / _ \ ___ _ ____  (_)  ___   ___ _
 / _  |/ _ `// _  /       / // // -_)/ __/ / /  (_-< / / / _ \ / _ \      / , _// _ `// __/ / /  / _ \ / _ `/
/____/ \_,_/ \_,_/       /____/ \__/ \__/ /_/  /___//_/  \___//_//_/     /_/|_| \_,_/ \__/ /_/  /_//_/ \_, / 
                                                                                                      /___/  "); TeamName = "Bad Decision Racing"; }
                        if (input == "BMR") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(@"
  _      __        __                            ______                                                
 | | /| / / ___   / / ____ ___   __ _  ___      /_  __/ ___                                            
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)      / /   / _ \                                           
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      /_/    \___/                                           
   ___               __                        __                     ___               _              
  / _ ) ___ _ ____  / /__  __ _  ___ _  ____  / /__ ___   ____       / _ \ ___ _ ____  (_)  ___   ___ _
 / _  |/ _ `// __/ /  '_/ /  ' \/ _ `/ / __/ /  '_// -_) / __/      / , _// _ `// __/ / /  / _ \ / _ `/
/____/ \_,_/ \__/ /_/\_\ /_/_/_/\_,_/ /_/   /_/\_\ \__/ /_/        /_/|_| \_,_/ \__/ /_/  /_//_/ \_, / 
                                                                                                /___/  "); TeamName = "Backmarker Racing"; }
                        if (input == "IFM") { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write(@"
  _      __        __                            ______                                                        
 | | /| / / ___   / / ____ ___   __ _  ___      /_  __/ ___                                                    
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)      / /   / _ \                                                   
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      /_/    \___/                                                   
   ____         ___   _          _   __                __  ___       __                                     __ 
  /  _/  ___   / _/  (_)  ___   (_) / /_  __ __       /  |/  / ___  / /_ ___   ____  ___   ___  ___   ____ / /_
 _/ /   / _ \ / _/  / /  / _ \ / / / __/ / // /      / /|_/ / / _ \/ __// _ \ / __/ (_-<  / _ \/ _ \ / __// __/
/___/  /_//_//_/   /_/  /_//_//_/  \__/  \_, /      /_/  /_/  \___/\__/ \___//_/   /___/ / .__/\___//_/   \__/ 
                                        /___/                                           /_/                    "); TeamName = "Infinity Motorsport"; }
                        if (input == "TDB") { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(@"
  _      __        __                            ______                      
 | | /| / / ___   / / ____ ___   __ _  ___      /_  __/ ___                  
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)      / /   / _ \                 
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      /_/    \___/                 
 ______                          ___    _               __                __ 
/_  __/ ___  ___ _  __ _        / _ \  (_) _  __ ___   / /  ___   __ _   / / 
 / /   / -_)/ _ `/ /  ' \      / // / / / | |/ // -_) / _ \/ _ \ /  ' \ / _ \
/_/    \__/ \_,_/ /_/_/_/     /____/ /_/  |___/ \__/ /_.__/\___//_/_/_//_.__/
                                                                             "); TeamName = "Team Divebomb"; }
                        if (input == "SOP") { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write(@"
  _      __        __                            ______                                     
 | | /| / / ___   / / ____ ___   __ _  ___      /_  __/ ___                                 
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)      / /   / _ \                                
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      /_/    \___/                                
   ____                   __    __        ____                           __                 
  / __/  __ _  ___  ___  / /_  / /       / __ \   ___  ___   ____ ___ _ / /_ ___   ____  ___
 _\ \   /  ' \/ _ \/ _ \/ __/ / _ \     / /_/ /  / _ \/ -_) / __// _ `// __// _ \ / __/ (_-<
/___/  /_/_/_/\___/\___/\__/ /_//_/     \____/  / .__/\__/ /_/   \_,_/ \__/ \___//_/   /___/
                                               /_/                                          "); TeamName = "Smooth Operators"; }
                        if (input == "WWD") { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(@"
  _      __        __                            ______                                                                                         
 | | /| / / ___   / / ____ ___   __ _  ___      /_  __/ ___                                                                                     
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)      / /   / _ \                                                                                    
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      /_/    \___/                                                                                    
  _      __                               _      __   __              __        ___          _                    __  ___         ___   _       
 | | /| / /  ____ ___   ___   ___ _      | | /| / /  / /  ___  ___   / /       / _ \  ____  (_) _  __ ___        /  |/  / ___ _  / _/  (_) ___ _
 | |/ |/ /  / __// _ \ / _ \ / _ `/      | |/ |/ /  / _ \/ -_)/ -_) / /       / // / / __/ / / | |/ // -_)      / /|_/ / / _ `/ / _/  / / / _ `/
 |__/|__/  /_/   \___//_//_/ \_, /       |__/|__/  /_//_/\__/ \__/ /_/       /____/ /_/   /_/  |___/ \__/      /_/  /_/  \_,_/ /_/   /_/  \_,_/ 
                            /___/                                                                                                              "); TeamName = "Wrong Wheel Drive Mafia"; }
                        if (input == "IGB") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(@"
  _      __        __                            ______                                                      
 | | /| / / ___   / / ____ ___   __ _  ___      /_  __/ ___                                                  
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)      / /   / _ \                                                 
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      /_/    \___/                                                 
   ____                __              _                         ___              __                  __     
  /  _/  ___   ___ _  / / ___   ____  (_) ___  __ __  ___       / _ ) ___ _  ___ / /_ ___ _  ____ ___/ /  ___
 _/ /   / _ \ / _ `/ / / / _ \ / __/ / / / _ \/ // / (_-<      / _  |/ _ `/ (_-</ __// _ `/ / __// _  /  (_-<
/___/  /_//_/ \_, / /_/  \___//_/   /_/  \___/\_,_/ /___/     /____/ \_,_/ /___/\__/ \_,_/ /_/   \_,_/  /___/
             /___/                                                                                           "); TeamName = "Inglorious Bastards"; }


                        Console.ResetColor(); Console.WriteLine("\nYou are now the team principal for " + TeamName + "!");
                        Console.ReadKey();
                    }

                    /////////////////////////////////////////Tier 2 Stuff/////////////////////////////////////////                        
                    if (input == "T2")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(@"
   ____                           __              _  __   _   __            
  / __/ ___   ____  __ _  __ __  / / ___ _       / |/ /  (_) / /_  ____ ___ 
 / _/  / _ \ / __/ /  ' \/ // / / / / _ `/      /    /  / / / __/ / __// _ \
/_/    \___//_/   /_/_/_/\_,_/ /_/  \_,_/      /_/|_/  /_/  \__/ /_/   \___/
                                                                            ");
                        Console.ResetColor();
                        Console.WriteLine("\n \nThis half spec racing series is the step-up class to Formula Ultra.\n");
                        Console.WriteLine(@"Now the most important thing, Choosing the team you want the manage!

COLOR        TEAM NAME                   ABBREVIATION     PERFORMANCE LEVEL");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Yellow       Team Nuclear Power              TNP");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("DarkBlue     Underprepared Motorsport        UPM");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("DarkGreen    Hairpin Time                    HPT");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Cyan         Durex Racing Team               DRT");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Magenta      Tyre Fuckers                    TFK");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("DarkCyan     Team Maximum Down               TMD");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Blue         Team Virgin                      TV");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("DarkRed      Demonitization Racing           DTR");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("White        Gangbangers Motorsport          GBM");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("DarkYellow   Gulag Express Racing            GER");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Red          Scuderia Fartari                SDF");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Green        Bunch of Idiots                 BOI");
                        Console.ResetColor();
                        Console.WriteLine("\nUse the Abbreviation to choose your team.");
                        /////////////////////////////////////////Tier 2 Choose Team/////////////////////////////////////////   
                        input = Console.ReadLine();
                        input = input.ToUpper();
                        if (input == "TNP") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(@"                  
  _      __        __                             __                                                       
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                                  
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                                 
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                                 
 ______                          _  __              __                         ___                         
/_  __/ ___  ___ _  __ _        / |/ / __ __ ____  / / ___  ___ _  ____       / _ \ ___  _    __ ___   ____
 / /   / -_)/ _ `/ /  ' \      /    / / // // __/ / / / -_)/ _ `/ / __/      / ___// _ \| |/|/ // -_) / __/
/_/    \__/ \_,_/ /_/_/_/     /_/|_/  \_,_/ \__/ /_/  \__/ \_,_/ /_/        /_/    \___/|__,__/ \__/ /_/   "); TeamName = "Team Nuclear Power"; }
                        if (input == "UPM") { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write(@"                  
  _      __        __                             __                                                                                             
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                                                                        
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                                                                       
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                                                                       
  __  __           __                                                          __        __  ___       __                                     __ 
 / / / /  ___  ___/ / ___   ____   ___   ____ ___    ___  ___ _  ____ ___  ___/ /       /  |/  / ___  / /_ ___   ____  ___   ___  ___   ____ / /_
/ /_/ /  / _ \/ _  / / -_) / __/  / _ \ / __// -_)  / _ \/ _ `/ / __// -_)/ _  /       / /|_/ / / _ \/ __// _ \ / __/ (_-<  / _ \/ _ \ / __// __/
\____/  /_//_/\_,_/  \__/ /_/    / .__//_/   \__/  / .__/\_,_/ /_/   \__/ \_,_/       /_/  /_/  \___/\__/ \___//_/   /___/ / .__/\___//_/   \__/ 
                                /_/               /_/                                                                     /_/                   "); TeamName = "Underprepared Motorsport"; }
                        if (input == "HPT") { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(@"                  
  _      __        __                             __                    
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___               
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \              
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/              
   __ __         _                 _             ______   _             
  / // / ___ _  (_)  ____   ___   (_)  ___      /_  __/  (_)  __ _  ___ 
 / _  / / _ `/ / /  / __/  / _ \ / /  / _ \      / /    / /  /  ' \/ -_)
/_//_/  \_,_/ /_/  /_/    / .__//_/  /_//_/     /_/    /_/  /_/_/_/\__/ 
                         /_/                                            "); TeamName = "Hairpin Time"; }
                        if (input == "DRT") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(@"                  
  _      __        __                             __                                                 
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                            
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                           
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                           
   ___                                ___               _                    ______                  
  / _ \ __ __  ____ ___  __ __       / _ \ ___ _ ____  (_)  ___   ___ _     /_  __/ ___  ___ _  __ _ 
 / // // // / / __// -_) \ \ /      / , _// _ `// __/ / /  / _ \ / _ `/      / /   / -_)/ _ `/ /  ' \
/____/ \_,_/ /_/   \__/ /_\_\      /_/|_| \_,_/ \__/ /_/  /_//_/ \_, /      /_/    \__/ \_,_/ /_/_/_/
                                                                /___/                                "); TeamName = "Durex Racing Team"; }
                        if (input == "TFK") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(@"                  
  _      __        __                             __                   
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___              
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \             
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/             
 ______                          ____              __                  
/_  __/  __ __  ____ ___        / __/ __ __ ____  / /__ ___   ____  ___
 / /    / // / / __// -_)      / _/  / // // __/ /  '_// -_) / __/ (_-<
/_/     \_, / /_/   \__/      /_/    \_,_/ \__/ /_/\_\ \__/ /_/   /___/
       /___/                                                           "); TeamName = "Tyre Fuckers"; }
                        if (input == "TMD") { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write(@"                  
  _      __        __                             __                                                        
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                                   
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                                  
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                                  
 ______                          __  ___               _                             ___                    
/_  __/ ___  ___ _  __ _        /  |/  / ___ _ __ __  (_)  __ _  __ __  __ _        / _ \ ___  _    __  ___ 
 / /   / -_)/ _ `/ /  ' \      / /|_/ / / _ `/ \ \ / / /  /  ' \/ // / /  ' \      / // // _ \| |/|/ / / _ \
/_/    \__/ \_,_/ /_/_/_/     /_/  /_/  \_,_/ /_\_\ /_/  /_/_/_/\_,_/ /_/_/_/     /____/ \___/|__,__/ /_//_/
                                                                                                            "); TeamName = "Team Maximum Down"; }
                        if (input == "TV") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Blue; Console.Write(@"                  
  _      __        __                             __               
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___          
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \         
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/         
 ______                         _   __   _                 _       
/_  __/ ___  ___ _  __ _       | | / /  (_)  ____  ___ _  (_)  ___ 
 / /   / -_)/ _ `/ /  ' \      | |/ /  / /  / __/ / _ `/ / /  / _ \
/_/    \__/ \_,_/ /_/_/_/      |___/  /_/  /_/    \_, / /_/  /_//_/
                                                 /___/            "); TeamName = "Team Virgin"; }
                        if (input == "DTR") { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(@"                  
  _      __        __                             __                                                                 
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                                            
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                                           
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                                           
   ___                           _   __    _             __    _                    ___               _              
  / _ \ ___   __ _  ___   ___   (_) / /_  (_) ___ ___ _ / /_  (_) ___   ___        / _ \ ___ _ ____  (_)  ___   ___ _
 / // // -_) /  ' \/ _ \ / _ \ / / / __/ / / /_ // _ `// __/ / / / _ \ / _ \      / , _// _ `// __/ / /  / _ \ / _ `/
/____/ \__/ /_/_/_/\___//_//_//_/  \__/ /_/  /__/\_,_/ \__/ /_/  \___//_//_/     /_/|_| \_,_/ \__/ /_/  /_//_/ \_, / 
                                                                                                              /___/  "); TeamName = "Demonitization Racing"; }
                        if (input == "GBM") { Console.Clear(); Console.ForegroundColor = ConsoleColor.White; Console.Write(@"                  
  _      __        __                             __                                                                               
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                                                          
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                                                         
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                                                         
  _____                      __                                            __  ___       __                                     __ 
 / ___/ ___ _  ___   ___ _  / /  ___ _  ___   ___ _ ___   ____  ___       /  |/  / ___  / /_ ___   ____  ___   ___  ___   ____ / /_
/ (_ / / _ `/ / _ \ / _ `/ / _ \/ _ `/ / _ \ / _ `// -_) / __/ (_-<      / /|_/ / / _ \/ __// _ \ / __/ (_-<  / _ \/ _ \ / __// __/
\___/  \_,_/ /_//_/ \_, / /_.__/\_,_/ /_//_/ \_, / \__/ /_/   /___/     /_/  /_/  \___/\__/ \___//_/   /___/ / .__/\___//_/   \__/ 
                   /___/                    /___/                                                           /_/                    "); TeamName = "Gangbangers Motorsport"; }
                        if (input == "GER") { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write(@"                  
  _      __        __                             __                                                                  
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                                             
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                                            
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                                            
  _____         __                     ____                                          ___               _              
 / ___/ __ __  / / ___ _  ___ _       / __/ __ __   ___   ____ ___   ___  ___       / _ \ ___ _ ____  (_)  ___   ___ _
/ (_ / / // / / / / _ `/ / _ `/      / _/   \ \ /  / _ \ / __// -_) (_-< (_-<      / , _// _ `// __/ / /  / _ \ / _ `/
\___/  \_,_/ /_/  \_,_/  \_, /      /___/  /_\_\  / .__//_/   \__/ /___//___/     /_/|_| \_,_/ \__/ /_/  /_//_/ \_, / 
                        /___/                    /_/                                                           /___/ "); TeamName = "Gulag Express Racing"; }
                        if (input == "SDF") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"                  
  _      __        __                             __                                         
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                    
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                   
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                   
   ____                __              _               ____              __                _ 
  / __/ ____ __ __ ___/ / ___   ____  (_) ___ _       / __/ ___ _  ____ / /_ ___ _  ____  (_)
 _\ \  / __// // // _  / / -_) / __/ / / / _ `/      / _/  / _ `/ / __// __// _ `/ / __/ / / 
/___/  \__/ \_,_/ \_,_/  \__/ /_/   /_/  \_,_/      /_/    \_,_/ /_/   \__/ \_,_/ /_/   /_/  "); TeamName = "Scuderia Fartari"; }
                        if (input == "BOI") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"                  
  _      __        __                             __                                 
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                            
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                           
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                           
   ___                     __              ___        ____     __   _        __      
  / _ ) __ __  ___  ____  / /       ___   / _/       /  _/ ___/ /  (_) ___  / /_  ___
 / _  |/ // / / _ \/ __/ / _ \     / _ \ / _/       _/ /  / _  /  / / / _ \/ __/ (_-<
/____/ \_,_/ /_//_/\__/ /_//_/     \___//_/        /___/  \_,_/  /_/  \___/\__/ /___/"); TeamName = "Bunch of Idiots"; }

                        Console.ResetColor(); Console.WriteLine("\nYou are now the team principal for " + TeamName + "!");
                        Console.ReadKey();
                    }

                    /////////////////////////////////////////Tier 3 Stuff///////////////////////////////////////// 
                    if (input == "T3")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(@"
   ____                           __            ______               __      
  / __/ ___   ____  __ _  __ __  / / ___ _     /_  __/ __ __  ____  / /  ___ 
 / _/  / _ \ / __/ /  ' \/ // / / / / _ `/      / /   / // / / __/ / _ \/ _ \
/_/    \___//_/   /_/_/_/\_,_/ /_/  \_,_/      /_/    \_,_/ /_/   /_.__/\___/
                                                                             ");
                        Console.ResetColor();
                        Console.WriteLine("\n \nSingle make, full spec and close racing, This series offers a great challenge in managing your team. 10 Teams with each 3 drivers!");
                        Console.WriteLine(@"Now the most important thing, Choosing the team you want the manage!  

COLOR        TEAM NAME                   ABBREVIATION     PERFORMANCE LEVEL");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Green        Cheat'N Slow                    CNS");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("DarkBlue     Loose Lugnut Racing             LLR");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Red          Box Box Racing                  BBR");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("DarkGreen    Cow Fart Racing                 CFR");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Yellow       Racing Group of Bumbles         RGB");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Magenta      Bad Strategy Motorsport         BSM");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Blue         Mid-Drive Crisis                MDC");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("White        Heavy Drug Racing               HDR");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Cyan         Team Thot Patrol                TTP");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("DarkGrey     Team-ing with bad Ideas         TBI");
                        Console.ResetColor();
                        Console.WriteLine(@"                        
Use the Abbreviation to choose your team.");
                        /////////////////////////////////////////Tier 3 Choose Team/////////////////////////////////////////   
                        input = Console.ReadLine();
                        input = input.ToUpper();
                        if (input == "CNS") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Green; Console.Write(@"                  
  _      __        __                             __                     
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \               
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/               
  _____   __              __       _               ____   __             
 / ___/  / /  ___  ___ _ / /_     ( )  ___        / __/  / / ___  _    __
/ /__   / _ \/ -_)/ _ `// __/     |/  / _ \      _\ \   / / / _ \| |/|/ /
\___/  /_//_/\__/ \_,_/ \__/         /_//_/     /___/  /_/  \___/|__,__/ 
                                                                         "); TeamName = "Cheat 'n Slow"; }
                        if (input == "LLR") { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkBlue; Console.Write(@"                  
  _      __        __                             __                                                        
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                                   
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                                  
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                                  
   __                             __                            __         ___               _              
  / /  ___  ___   ___ ___        / /  __ __  ___ _  ___  __ __ / /_       / _ \ ___ _ ____  (_)  ___   ___ _
 / /__/ _ \/ _ \ (_-</ -_)      / /__/ // / / _ `/ / _ \/ // // __/      / , _// _ `// __/ / /  / _ \ / _ `/
/____/\___/\___//___/\__/      /____/\_,_/  \_, / /_//_/\_,_/ \__/      /_/|_| \_,_/ \__/ /_/  /_//_/ \_, / 
                                           /___/                                                     /___/  "); TeamName = "Loose Lugnut Racing"; }
                        if (input == "BBR") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Red; Console.Write(@"                  
  _      __        __                             __                              
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                         
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                        
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                        
   ___                    ___                    ___               _              
  / _ ) ___  __ __       / _ ) ___  __ __       / _ \ ___ _ ____  (_)  ___   ___ _
 / _  |/ _ \ \ \ /      / _  |/ _ \ \ \ /      / , _// _ `// __/ / /  / _ \ / _ `/
/____/ \___//_\_\      /____/ \___//_\_\      /_/|_| \_,_/ \__/ /_/  /_//_/ \_, / 
                                                                           /___/  "); TeamName = "Box Box Racing"; }
                        if (input == "CFR") { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(@"                  
  _      __        __                             __                                      
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                 
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                
  _____                     ____              __         ___               _              
 / ___/ ___  _    __       / __/ ___ _  ____ / /_       / _ \ ___ _ ____  (_)  ___   ___ _
/ /__  / _ \| |/|/ /      / _/  / _ `/ / __// __/      / , _// _ `// __/ / /  / _ \ / _ `/
\___/  \___/|__,__/      /_/    \_,_/ /_/   \__/      /_/|_| \_,_/ \__/ /_/  /_//_/ \_, / 
                                                                                   /___/  "); TeamName = "Cow Fart Racing"; }
                        if (input == "RGB") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write(@"                  
  _      __        __                             __                                                                                  
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                                                             
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                                                            
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                                                            
   ___               _                     _____                                     ___        ___                 __    __          
  / _ \ ___ _ ____  (_)  ___   ___ _      / ___/  ____ ___  __ __   ___       ___   / _/       / _ ) __ __  __ _   / /   / / ___   ___
 / , _// _ `// __/ / /  / _ \ / _ `/     / (_ /  / __// _ \/ // /  / _ \     / _ \ / _/       / _  |/ // / /  ' \ / _ \ / / / -_) (_-<
/_/|_| \_,_/ \__/ /_/  /_//_/ \_, /      \___/  /_/   \___/\_,_/  / .__/     \___//_/        /____/ \_,_/ /_/_/_//_.__//_/  \__/ /___/
                             /___/                               /_/                                                                  "); TeamName = "Racing Group of Bumbles"; }
                        if (input == "BSM") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write(@"                  
  _      __        __                             __                                                                                     
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                                                                
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                                                               
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                                                               
   ___            __        ____  __               __                            __  ___       __                                     __ 
  / _ ) ___ _ ___/ /       / __/ / /_  ____ ___ _ / /_ ___   ___ _  __ __       /  |/  / ___  / /_ ___   ____  ___   ___  ___   ____ / /_
 / _  |/ _ `// _  /       _\ \  / __/ / __// _ `// __// -_) / _ `/ / // /      / /|_/ / / _ \/ __// _ \ / __/ (_-<  / _ \/ _ \ / __// __/
/____/ \_,_/ \_,_/       /___/  \__/ /_/   \_,_/ \__/ \__/  \_, /  \_, /      /_/  /_/  \___/\__/ \___//_/   /___/ / .__/\___//_/   \__/ 
                                                           /___/  /___/                                           /_/                    "); TeamName = "Bad Strategy Motorsport"; }
                        if (input == "MDC") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Blue; Console.Write(@"                  
  _      __        __                             __                                          
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                     
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                    
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                    
   __  ___   _      __        ___          _                   _____         _         _      
  /  |/  /  (_) ___/ / ____  / _ \  ____  (_) _  __ ___       / ___/  ____  (_)  ___  (_)  ___
 / /|_/ /  / / / _  / /___/ / // / / __/ / / | |/ // -_)     / /__   / __/ / /  (_-< / /  (_-<
/_/  /_/  /_/  \_,_/       /____/ /_/   /_/  |___/ \__/      \___/  /_/   /_/  /___//_/  /___/
                                                                                              "); TeamName = "Mid-Drive Crisis"; }
                        if (input == "HDR") { Console.Clear(); Console.ForegroundColor = ConsoleColor.White; Console.Write(@"                  
  _      __        __                             __                                                    
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                               
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                              
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                              
   __ __                                ___                            ___               _              
  / // / ___  ___ _ _  __  __ __       / _ \  ____ __ __  ___ _       / _ \ ___ _ ____  (_)  ___   ___ _
 / _  / / -_)/ _ `/| |/ / / // /      / // / / __// // / / _ `/      / , _// _ `// __/ / /  / _ \ / _ `/
/_//_/  \__/ \_,_/ |___/  \_, /      /____/ /_/   \_,_/  \_, /      /_/|_| \_,_/ \__/ /_/  /_//_/ \_, / 
                         /___/                          /___/                                    /___/  "); TeamName = "Heavy Drug Racing"; }
                        if (input == "TTP") { Console.Clear(); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write(@"                  
  _      __        __                             __                                        
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                   
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                  
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                  
 ______                        ______   __        __         ___         __               __
/_  __/ ___  ___ _  __ _      /_  __/  / /  ___  / /_       / _ \ ___ _ / /_  ____ ___   / /
 / /   / -_)/ _ `/ /  ' \      / /    / _ \/ _ \/ __/      / ___// _ `// __/ / __// _ \ / / 
/_/    \__/ \_,_/ /_/_/_/     /_/    /_//_/\___/\__/      /_/    \_,_/ \__/ /_/   \___//_/  
                                                                                            "); TeamName = "Team Thot Patrol"; }
                        if (input == "TBI") { Console.Clear(); Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write(@"                  
  _      __        __                             __                                                                                    
 | | /| / / ___   / / ____ ___   __ _  ___       / /_ ___                                                                               
 | |/ |/ / / -_) / / / __// _ \ /  ' \/ -_)     / __// _ \                                                                              
 |__/|__/  \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/                                                                              
 ______                          _                              _   __    __         __            __        ____     __                
/_  __/ ___  ___ _  __ _  ____  (_)  ___   ___ _      _    __  (_) / /_  / /        / /  ___ _ ___/ /       /  _/ ___/ / ___  ___ _  ___
 / /   / -_)/ _ `/ /  ' \/___/ / /  / _ \ / _ `/     | |/|/ / / / / __/ / _ \      / _ \/ _ `// _  /       _/ /  / _  / / -_)/ _ `/ (_-<
/_/    \__/ \_,_/ /_/_/_/     /_/  /_//_/ \_, /      |__,__/ /_/  \__/ /_//_/     /_.__/\_,_/ \_,_/       /___/  \_,_/  \__/ \_,_/ /___/
                                         /___/                                                                                          "); TeamName = "Team-ing with bad Ideas"; }

                        Console.ResetColor(); Console.WriteLine("\nYou are now the team principal for " + TeamName + "!");
                        Console.ReadKey();
                    }
                }
                if (input == "GT")
                {
                    Console.WriteLine("Welcome to GT Racing!");
                }
                if (input == "ER")
                {
                    Console.WriteLine("Welcome to Endurance!");
                }
                if (input == "SC")
                {
                    Console.WriteLine("Welcome to Stockcar Racing!");
                }
                if (input == "TC")
                {
                    Console.WriteLine("Welcome to Touring Car racing!");
                }
            }
        }

        static void OWT1Intro()
        {
            Console.Clear();
            Console.WriteLine("\nWelcome to the office of " + TeamName + ", " + CharacterName + ". We are extremely pleased that you joined our team to lead us to victory! \n" +
            "I heard that the chairman, " + TeamChairman + ", send you an email with everything you need to know about our team!\n\nOpen your mail and look what he has to say to our latest addition to the team.");
            Console.WriteLine("Press enter to go to your mail");
            Console.ReadKey();
            Console.Clear();

            for (int scenario = 1; scenario <= 1; scenario++)
            {
                string input = "";

                switch (scenario)
                {
                    case 1:
                        Console.WriteLine(DateTime.Now);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(@"
  ____                  _ _ 
 |  _ \                (_) |
 | |_) |_ __ ___   __ _ _| |
 |  _ <| '_ ` _ \ / _` | | |
 | |_) | | | | | | (_| | | |
 |____/|_| |_| |_|\__,_|_|_|");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\nINBOX - 1 UNOPENED MAIL\n");
                        Console.ResetColor();
                        Console.WriteLine(@"Sender                                                    Topic                                Date");
                        Console.WriteLine(@"" + ChairmanEmail + "@Bmail.com" + "                                     -Welcome!" + "                            Just Now");
                        Console.WriteLine("\n\n\nType : WEL, to open the mail. Note : To open emails later, Type the first 3 letters of the topic.\n");
                        input = Console.ReadLine();
                        input = input.ToUpper();
                        if (input == "WEL")
                        {
                            Console.Clear();
                            Console.WriteLine(@"
|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
|| From : " + TeamChairman + @"@bmail.com                                                                                                                                                               
|| Subject : Welcome to " + TeamName + "!" +
@"
||
||
|| " + CharacterName + @",
||
|| We are very happy to announce you as our team principal for the 2020 season onwards, This mail will help you learn the team alongside the staff.
|| We finished 6th last year in the team standings, hopefully you can help us improve this year...
||
|| During the race your lead engineer will be Andrew Hawkins, he'll work together with you during the race weekends.
||
||
|| So let's start with introducing the drivers :
||
|| " + TeamDriver1 + @"
||
|| One of the better drivers in " + OWT1 + @", although a little bit old, he still got it. Atleast... He said that himself.
||
||
|| " + TeamDriver2 + @"
||
|| He's a young prospect with a decent career in the junior series. He will need to prove himself this year after a though rookie season.
||
||
|| Best Regards,
|| " + TeamChairman + ", " + TeamName + @"
|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                            Console.WriteLine("\nIf you are done reading the mail, press enter and we'll starting doing the first preperations for the first race weekend at " + Albertpark[1] + ".");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(TypedWrong[0]);
                            Console.ReadKey();
                            Console.Clear();
                            goto case 1;
                        }
                        break;
                }
            }
        }

        static void Menu0() //Main Menu, you will come back to this a lot.
        {
            Console.Clear();
            string input = "";
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine(@"
0 - Home
1 - Mail
2 - Car Development
3 - Drivers
4 - Team Overview
5 - Standings
6 - Calendar
7 - Scouting
8 - HQ
9 - Continue to " + Albertpark[1]);
            input = Console.ReadLine();
            if (input == "1")
            {
                Menu1();
            }
            if (input == "2")
            {
                Menu2();
            }
            if (input == "3")
            {
                Menu3();
            }
            if (input == "4")
            {
                Menu4();
            }
            if (input == "5")
            {
                Menu5();
            }
            if (input == "6")
            {
                Menu6();
            }
            if (input == "7")
            {
                Menu7();
            }
            if (input == "8")
            {
                Menu8();
            }
            if (input == "9")
            {
                return;
            }
            else { Menu0(); };
        }


        static void Menu1()
        {
            Console.Clear();
            string input = "";
            Console.WriteLine(DateTime.Now);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
  ____                  _ _ 
 |  _ \                (_) |
 | |_) |_ __ ___   __ _ _| |
 |  _ <| '_ ` _ \ / _` | | |
 | |_) | | | | | | (_| | | |
 |____/|_| |_| |_|\__,_|_|_|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nINBOX - 1 UNOPENED MAIL\n");
            Console.ResetColor();
            Console.WriteLine(@"Sender                                                    Topic                                Date");
            Console.WriteLine(@"" + NewsOutlet1Mail + "@Bmail.com" + "                                   PPR New manager!" + "                     Today");
            Console.WriteLine(@"" + ChairmanEmail + "@Bmail.com" + "                                     -Welcome!" + "                            Today");
            Console.WriteLine("\n\nTo go back to home, press 0");
            input = Console.ReadLine();

            if (input == "0")
            {
                Menu0();
            }
            if (input == "PPR")
            {
                Console.Clear();
                Console.WriteLine(@"
|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
|| From : " + NewsOutlet1Mail + @"@bmail.com                                                                                                                                                               
|| Subject : Pole Position Racing New manager!
||
||
|| Pole Position Racing announced new manager for the 2020 season!
||
|| He's a total newcomer to the world of motorsport so time will tell if he's the perfect fit for the job.
||
|| PPR Fans reactions were mixed when the news came out. 'Is " + CharacterName + @" really good enough for our team?' One of the fans replied
|| on the announcement post.
||
|| " + TeamChairman + @" said that he has a contract for 2020 only, with the option to extend to 2021 or 2022. 
||
||
|| " + NewsOutlet1 + @"
|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("\nTo go back, press 0");
                Console.ReadKey();
                Menu1();
            }
        }
        static void Menu2()
        {
            Console.Clear();
            string input = "";
            Console.WriteLine("Car Development");
            Console.WriteLine("\nTo go back to home, press 0");
            Console.WriteLine("\nHere you can develop and improve your car.");

            Console.WriteLine("");
            input = Console.ReadLine();
            if (input == "0")
            {
                Menu0();
            }
            else
            {
                Menu2();
            };
        }

        static void Menu3()
        {
            Console.Clear();
            string input = "";
            Console.WriteLine("Drivers");
            Console.WriteLine("\nTo go back to home, press 0");
            Console.WriteLine(@"" +
                TeamDriver1 +
                "" +
                "Placeholder Text" +
                "Placeholder Text2");
            Console.WriteLine(@"" +
                TeamDriver2 +
                "" +
               "Placeholder Text3" +
               "Placeholder Text4");
            input = Console.ReadLine();
            if (input == "0")
            {
                Menu0();
            }
            else
            {
                Menu3();
            };
        }
        static void Menu4()
        {
            Console.Clear();
            string input = "";
            Console.WriteLine("Team Overview");
            Console.WriteLine("\nTo go back to home, press 0\n\n");
            Console.WriteLine(@"
Drivers : " + TeamDriver1 + @" and " + TeamDriver2 +

@"Lead Engineer : " + TeamEngineer);
            input = Console.ReadLine();
            if (input == "0")
            {
                Menu0();
            }
            else
            {
                Menu4();
            };
        }

        static void Menu5()
        {
            {
                Console.Clear();
                string input = "";
                Console.WriteLine("Standings");
                Console.WriteLine("\nTo go back to home, press 0");
                Console.WriteLine("\n\n" + CYear + "  " + OWT1 + " Standings after " + OWT1R0S + " races");
                PrintLine();
                PrintRow("Pos", "Driver", "Team");
                PrintLine();
                Console.ForegroundColor = ConsoleColor.White;
                PrintRow("1.", "Henk Kerk", "Team Fullspeed");
                PrintRow("2.", "Jon Spriggs", "Team Fullspeed");
                Console.ForegroundColor = ConsoleColor.Red;
                PrintRow("3.", "Barack Obama", "Cornercut Motorsport");
                PrintRow("4.", "Cameron Mckay", "Cornercut Motorsport");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                PrintRow("5.", "Norm Benning", "Infinity Motorsport");
                PrintRow("6.", "Phil Swift", "Infinity Motorsport");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                PrintRow("7.", "Mahaveer Raghunathan", "Team Divebomb");
                PrintRow("8.", "Aiden Hoek", "Team Divebomb");
                Console.ForegroundColor = ConsoleColor.Magenta;
                PrintRow("9.", "Dzjengis Khan", "Inglorious Bastards");
                PrintRow("10.", "Grote Smurf", "Inglorious Bastards");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                PrintRow("11.", "Leandre Berube Berbegon", "Wrong Wheel Drive Mafia");
                PrintRow("12.", "Joseph Stalin", "Wrong Wheel Drive Mafia");
                Console.ForegroundColor = ConsoleColor.Green;
                PrintRow("13.", "Tommy Vercetti", "Party Mode GP");
                PrintRow("14.", "Stefan Douwma", "Party Mode GP");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                PrintRow("15.", "Philip Dryer", "Pole Position Racing");
                PrintRow("16.", "Mark Rutte", "Pole Position Racing");
                Console.ForegroundColor = ConsoleColor.Yellow;
                PrintRow("17.", "Max Knoll", "Backmarker Racing");
                PrintRow("18.", "Vreek Vonk", "Backmarker Racing");
                Console.ForegroundColor = ConsoleColor.Cyan;
                PrintRow("19.", "Kim Jong-Il", "Kone Killers");
                PrintRow("20.", "Pablo Escobar", "Kone Killers");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Blue;
                PrintRow("21.", "Matt Judge", "Bad Decision Racing");
                PrintRow("22.", "Alain Giorla", "Bad Decision Racing");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                PrintRow("23.", "Will Power", "Smooth Operators");
                PrintRow("24.", "Matthew Gallagher", "Smooth Operators");
                Console.ResetColor();
                PrintLine();

                static void PrintLine()
                {
                    Console.WriteLine(new string('-', tableWidth));
                }

                static void PrintRow(params string[] columns)
                {
                    int width = (tableWidth - columns.Length) / columns.Length;
                    string row = "|";

                    foreach (string column in columns)
                    {
                        row += AlignCentre(column, width) + "|";
                    }

                    Console.WriteLine(row);
                }

                static string AlignCentre(string text, int width)
                {
                    text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

                    if (string.IsNullOrEmpty(text))
                    {
                        return new string(' ', width);
                    }
                    else
                    {
                        return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
                    }
                }

                input = Console.ReadLine();
                if (input == "0")
                {
                    Menu0();
                }
                else
                {
                    Menu5();
                };
            }
        }

        static void Menu6()
        {

            {

                Console.Clear();
                Console.WriteLine("Calendar Menu");
                Console.WriteLine("\nTo go back to home, press 0");
                Console.WriteLine("\n\n" + CYear + @" " + OWT1 + " Calendar :\n");
                PrintLine();
                PrintRow("Race", "Country", "Circuit");
                PrintLine();
                PrintRow("1.", "Australia", "Albert Park");
                PrintRow("2.", "Maylasia", "Sepang");
                PrintRow("3.", "Brazil", "José Carlos Pace");
                PrintRow("4.", "San Marino", "Enzo e Imola");
                PrintRow("5.", "Spain", "Catalunya");
                PrintRow("6.", "Monaco", "Monaco");
                PrintRow("7.", "Canada", "Montréal");
                PrintRow("8.", "Austria", "A1 Ring");
                PrintRow("9.", "France", "Magny - Cours");
                PrintRow("10.", "UK", "Silverstone");
                PrintRow("11.", "Germany", "Hockenheim");
                PrintRow("12.", "Hungary", "Hungaroring");
                PrintRow("13.", "Belgium", "Spa");
                PrintRow("14.", "Europe", "Nürburgring");
                PrintRow("15.", "Italy", "Monza");
                PrintRow("16.", "USA", "Indianapolis (GP)");
                PrintRow("17.", "Japan", "Suzuka");
                PrintLine();
            }

            static void PrintLine()
            {
                Console.WriteLine(new string('-', tableWidth));
            }

            static void PrintRow(params string[] columns)
            {
                int width = (tableWidth - columns.Length) / columns.Length;
                string row = "|";

                foreach (string column in columns)
                {
                    row += AlignCentre(column, width) + "|";
                }

                Console.WriteLine(row);
            }

            static string AlignCentre(string text, int width)
            {
                text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

                if (string.IsNullOrEmpty(text))
                {
                    return new string(' ', width);
                }
                else
                {
                    return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
                }
            }
            string input = "";
            input = Console.ReadLine();
            if (input == "0")
            {
                Menu0();
            }
            else
            {
                Menu6();
            }
        }

        static void Menu7()
        {
            Console.Clear();
            string input = "";
            Console.WriteLine("Scouting");
            Console.WriteLine("\nTo go back to home, press 0");
            input = Console.ReadLine();
            if (input == "0")
            {
                Menu0();
            }
            else
            {
                Menu7();
            }
        }
        static void Menu8()
        {
            Console.Clear();
            string input = "";
            Console.WriteLine("HQ");
            Console.WriteLine("\nTo go back to home, press 0");
            input = Console.ReadLine();
            if (input == "0")
            {
                Menu0();
            }
            else
            {
                Menu8();
            }
        }
        static void Menu9()
        {
            Console.Clear();
            string input = "";
            Console.WriteLine("Are you ready to travel to " + Albertpark[1]);
            Console.WriteLine("\nYes or No?");
            input = input.ToUpper();
            input = Console.ReadLine();
            if (input == "Yes")
            {
                return;
            }

            if (input == "No")
            {
                Menu0();
            }

            else
            {
                Menu9();
            }

        }
        public static void Random()
        {
            Random rd = new Random();
            randomIndex = rd.Next(0, WeatherType.Length);
        }
        static void PracticeOWT1()
        {
            for (int scenario = 1; scenario <= 1; scenario++)
            {
                Console.Clear();
                Console.WriteLine(@"WELCOME TO");
                Console.ReadKey();
                Console.WriteLine(@"
           _ _               _     _____           _    
     /\   | | |             | |   |  __ \         | |   
    /  \  | | |__   ___ _ __| |_  | |__) |_ _ _ __| | __
   / /\ \ | | '_ \ / _ \ '__| __| |  ___/ _` | '__| |/ /
  / ____ \| | |_) |  __/ |  | |_  | |  | (_| | |  |   < 
 /_/    \_\_|_.__/ \___|_|   \__| |_|   \__,_|_|  |_|\_\

  __  __      _ _                                                       _             _ _       
 |  \/  |    | | |                                       /\            | |           | (_)      
 | \  / | ___| | |__   ___  _   _ _ __ _ __   ___       /  \  _   _ ___| |_ _ __ __ _| |_  __ _ 
 | |\/| |/ _ \ | '_ \ / _ \| | | | '__| '_ \ / _ \     / /\ \| | | / __| __| '__/ _` | | |/ _` |
 | |  | |  __/ | |_) | (_) | |_| | |  | | | |  __/_   / ____ \ |_| \__ \ |_| | | (_| | | | (_| |
 |_|  |_|\___|_|_.__/ \___/ \__,_|_|  |_| |_|\___( ) /_/    \_\__,_|___/\__|_|  \__,_|_|_|\__,_|
                                                 |/                                             
");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("March 13th, 2020, Free Practice");
                Console.WriteLine("\nWeather Report :");

                Console.WriteLine(@"Current Track conditions : " + WeatherType[randomIndex] + ", " + AUSTemp[randomIndex] + " Degrees air temperature");
                Console.WriteLine("\n\n");
                Console.WriteLine("Type Go to continue, inf if you want to read some info about the track!\n");
                string input = "";
                input = input.ToUpper();
                input = input.ToLower();
                input = Console.ReadLine();
                if (input == "go")
                {
                    Console.WriteLine("Alright, Practice will start soon!");
                    Console.ReadKey();
                }
                if (input == "inf")
                {
                    Console.Clear();
                    Console.WriteLine(@"                                                                                                
                    _,__        .:
            Darwin <*  /        | \
               .-./     |.     :  :,
              /           '-._/     \_
             /                '       \
           .'                         *: Brisbane
        .-'                             ;
        |                               |
        \                              /
         |                            /
   Perth  \*        __.--._          /
           \     _.'       \:.       |
           >__,-'             \_/*_.-'
                                 Melbourne
                                :--,
                                 '/ 



");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Albertpark[0] + "\n" + Albertpark[1] + ", " + Albertpark[2] + ", " + Albertpark[3] + "\nTrack Length : " + Albertpark[4] + ",\nRace Distance : " + Albertpark[5] + ",\nFirst Race : " + Albertpark[6]);
                    Console.ResetColor();
                    Console.WriteLine("\nTrack Description : " + Albertpark[7]);
                    Console.WriteLine("\nMechanic Notes : " + Albertpark[8]);
                    Console.WriteLine("\nWhen ready, press enter to continue...");
                    Console.ReadKey();

                    Console.Clear();

                    Console.WriteLine("11:59 AM, 1 minute before pitlane opens for Free Practice.");
                    Console.WriteLine("\n-- " + TeamDriver1 + " : Radio Check, 1 2 3, Radio Check\n");
                    string word = "";
                    word = word.ToUpper();
                    word = Console.ReadLine();
                    if (word == "Radio Check")
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(4));
                        Console.WriteLine("-- " + TeamDriver1 + " : " + RadioCheck[0]);
                        Console.WriteLine("\n");
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        Console.WriteLine("-- Race Control : " + RaceControlSessionCountDown[0]);
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.WriteLine(RaceControlSessionCountDown[1]);
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.WriteLine(RaceControlSessionCountDown[2]);
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.WriteLine(RaceControlSessionCountDown[3]);
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.WriteLine(RaceControlSessionCountDown[4]);
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.WriteLine(RaceControlSessionCountDown[5]);
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.WriteLine(RaceControlSessionCountDown[6]);
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.WriteLine(RaceControlSessionCountDown[7]);
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.WriteLine(RaceControlSessionCountDown[8]);
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.WriteLine(RaceControlSessionCountDown[9]);
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.WriteLine(RaceControlSessionCountDown[10]);
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.WriteLine("-- Race Control : " + RaceControlSessionCountDown[11]);
                    }
                    else
                    {
                        Console.WriteLine(RadioCheck[1]);
                        Console.ReadKey();
                        Console.Clear();
                        Console.SetCursorPosition(0, Console.CursorTop);
                    }

                    switch (scenario)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Thread.Sleep(TimeSpan.FromSeconds(5));
                            Console.WriteLine("\nParty Mode GP's Tommy Vercetti goes out on track, soft tyres.");
                            Console.ResetColor();
                            Thread.Sleep(TimeSpan.FromSeconds(5));
                            Console.WriteLine("\n-- " + TeamDriver2 + " : Shouldn't we go out, the track is clear.\n");
                            string sc1 = "";
                            sc1 = sc1.ToUpper();
                            sc1 = Console.ReadLine();
                            if (sc1 == "out")
                            {
                                Console.WriteLine("-- " + TeamEngineer + " : Confirmed, " + TeamDriver2 + ", you'll go out for 12 laps, race trim, medium tyres. All personnel be advised, we have a car leaving.\n");
                                Thread.Sleep(TimeSpan.FromSeconds(5));
                                Console.WriteLine("-- " + TeamEngineer + " : Boss, should we send out " + TeamDriver1 + " too? I suggest quali trim for 4 laps, Soft Tyres. yes or no?\n");
                                string sc1_1 = "";
                                sc1_1 = sc1_1.ToUpper();
                                sc1_1 = Console.ReadLine();
                                if (sc1_1 == "yes")
                                {
                                    Thread.Sleep(TimeSpan.FromSeconds(1));
                                    Console.WriteLine("-- " + TeamEngineer + " : Copy that.\n");
                                    Thread.Sleep(TimeSpan.FromSeconds(5));
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(TeamDriver2 + " goes out on medium tyres.");
                                    Thread.Sleep(TimeSpan.FromSeconds(3));
                                    Console.WriteLine(TeamDriver1 + " for " + OWT1Teams[0] + " exits the pits on soft tyres.");
                                    Console.ResetColor();
                                    Thread.Sleep(TimeSpan.FromSeconds(10));
                                    Console.WriteLine("-- " + TeamEngineer + " > " + TeamDriver1 + " : Be advised, kerbs are slippery in Turn 4, 6 and 10...");
                                    Thread.Sleep(TimeSpan.FromSeconds(3));
                                    Console.WriteLine("-- " + TeamDriver1 + " > " + TeamEngineer + " : Copy.");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Thread.Sleep(TimeSpan.FromSeconds(5));
                                    Console.WriteLine("\nLeandre Bérubé Bergeron for Wrong Wheel Drive Mafia exits the pitlane on hard tyres.");
                                    Console.ResetColor();
                                    Thread.Sleep(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("\n--" + TeamEngineer + " : " + CharacterName + ", I think we should let them conserve a little bit in the beginning. Less Risk of losing track time due to unfortunate events. yes or no?");
                                    string sc1_2 = "";
                                    sc1_2 = sc1_2.ToUpper();
                                    sc1_2 = Console.ReadLine();
                                    if (sc1_2 == "yes")
                                    {
                                        Thread.Sleep(TimeSpan.FromSeconds(3));
                                        Console.WriteLine("--" + TeamEngineer + " : Copy " + CharacterName + ".");
                                        Thread.Sleep(TimeSpan.FromSeconds(5));
                                        Console.WriteLine("\n--" + TeamEngineer + " > " + TeamDriver1 + ", " + TeamDriver2 + " : Don't take too many risks in the first half of this session, we don't want to lose out on any tracktime due to a crash or spin.");
                                        Thread.Sleep(TimeSpan.FromSeconds(3));
                                        Console.WriteLine("\n--" + TeamDriver2 + " : Roger that.");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Thread.Sleep(TimeSpan.FromSeconds(5));
                                        Console.WriteLine("\nTeam Fullspeed sends their drivers, Henk Kerk and Jon Spriggs, out on medium tyres");
                                        Console.ResetColor();
                                        Thread.Sleep(TimeSpan.FromMilliseconds(500));
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine(TeamDriver2 + " starts his first flying lap");
                                        Thread.Sleep(TimeSpan.FromSeconds(6));
                                        Console.WriteLine(TeamDriver1 + " is starting his first flying lap");
                                        Console.ResetColor();
                                        Thread.Sleep(TimeSpan.FromSeconds(4));
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Tommy Vercetti sets the fastest time of the session. (1:33.184)");
                                        Thread.Sleep(TimeSpan.FromSeconds(4));
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("Team Divebomb sends out Aiden Hoek for a reconnaissance lap");
                                        Thread.Sleep(TimeSpan.FromSeconds(6));
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine(TeamDriver1 + " sets the 2nd fastest time of the session. (1.35.860)");
                                        Thread.Sleep(TimeSpan.FromSeconds(4));
                                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                                        Console.WriteLine("Mahaveer Raghunathan goes out for Team Divebomb.");
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        Console.WriteLine(TeamDriver2 + " sets the 2nd fastest time of the session. (1.35.377). Pushing " + TeamDriver1 + " down to 3rd.");
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Thread.Sleep(TimeSpan.FromSeconds(5));
                                        Console.WriteLine("Leandre Bérubé Bergeron goes 1st, " + TeamDriver2 + " falls down to 3rd, " + TeamDriver1 + " to 4th.");
                                        Console.ResetColor();
                                        Thread.Sleep(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("--" + TeamEngineer + " > " + TeamDriver1 + ", " + TeamDriver2 + " : Keep these times up, engine mix to 3, both cars.\n");
                                        Thread.Sleep(TimeSpan.FromSeconds(4));
                                        Console.WriteLine("A few laps later...");
                                        Thread.Sleep(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("\n-- " + TeamDriver1 + " : I have some understeer in the car at high speed, I need more downforce. Should I return to box or pit for another run?\n");
                                        string sc1_3 = "";
                                        sc1_3 = sc1_3.ToUpper();
                                        sc1_3 = Console.ReadLine();
                                        if (sc1_3 == "box")
                                        {
                                            Thread.Sleep(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("--" + TeamDriver1 + " : Copy, pitting this lap.\n");
                                            Thread.Sleep(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("--" + TeamEngineer + " : " + TeamDriver1 + ", We'll apply some setup changes in the box.\n");
                                            Thread.Sleep(TimeSpan.FromSeconds(6));
                                            Console.WriteLine("--" + TeamEngineer + " : Traffic behind you, let them by.\n");
                                            Thread.Sleep(TimeSpan.FromSeconds(3));
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine(TeamDriver1 + " enters the pits after completing 4 laps.\n");
                                            Console.ResetColor();
                                            Thread.Sleep(TimeSpan.FromSeconds(3));
                                            Console.WriteLine("--" + TeamEngineer + " > " + TeamDriver2 + " : How does the car drive?\n");
                                            Thread.Sleep(TimeSpan.FromSeconds(3));
                                            Console.WriteLine("--" + TeamDriver2 + " : Yeah, it [CENSORED] drives [CENSORED], Understeer everywhere and I have zero power!\n");
                                            Thread.Sleep(TimeSpan.FromSeconds(4));
                                            Console.WriteLine("--" + TeamEngineer + " : Copy, we are checking.\n");
                                            Thread.Sleep(TimeSpan.FromSeconds(4));
                                            Console.WriteLine("--" + TeamEngineer + " : Try Fail A1 please, Fail A1\n");
                                            Thread.Sleep(TimeSpan.FromSeconds(3));
                                            Console.WriteLine("--" + TeamDriver2 + " : It does nothing!\n");
                                            Thread.Sleep(TimeSpan.FromSeconds(3));
                                            Console.WriteLine("--" + TeamEngineer + " : Okay box box box, we have a problem.\n");
                                            Thread.Sleep(TimeSpan.FromSeconds(3));
                                            Console.WriteLine("--" + TeamDriver2 + " : Confirm boxing\n");
                                            Console.ReadKey();
                                            goto case 3;
                                        }
                                        if (sc1_3 == "pit")
                                        {
                                            Thread.Sleep(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("--" + TeamDriver1 + " : Copy, pitting this lap for another run.\n");
                                            Thread.Sleep(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("--" + TeamEngineer + " > " + TeamDriver1 + " : We'll apply some front aero during the stop.\n");
                                            Thread.Sleep(TimeSpan.FromSeconds(6));
                                            Console.WriteLine("--" + TeamEngineer + " : Traffic behind you, They'll also pit, let them by.");
                                            Thread.Sleep(TimeSpan.FromSeconds(5));
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("\nParty Mode GP's Tommy Vercetti enteres the pits after completing 5 laps.");
                                            Thread.Sleep(TimeSpan.FromSeconds(3));
                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                            Console.WriteLine(TeamDriver1 + " comes in for a pitstop");
                                            Console.ResetColor();
                                            Thread.Sleep(TimeSpan.FromSeconds(3));
                                            Console.WriteLine("--" + TeamEngineer + " : Watch for traffic as you enter the track, 2 cars on a timed lap.");
                                            Thread.Sleep(TimeSpan.FromSeconds(3));
                                            Console.WriteLine("--" + TeamEngineer + " > " + TeamDriver2 + " : How does the car drive?\n");
                                            Thread.Sleep(TimeSpan.FromSeconds(3));
                                            Console.WriteLine("--" + TeamDriver2 + " : Yeah, it [CENSORED] drives [CENSORED], Oversteer everywhere and too much downforce!\n");
                                            Thread.Sleep(TimeSpan.FromSeconds(3));
                                            Console.WriteLine("--" + TeamEngineer + " : Copy, we are checking.\n");
                                            Thread.Sleep(TimeSpan.FromSeconds(3));
                                            Console.WriteLine("--" + TeamEngineer + " : You can pit if you want, and we'll look into it.\n");
                                            Thread.Sleep(TimeSpan.FromSeconds(3));
                                            Console.WriteLine("--" + TeamDriver2 + " : Yeah, box box box.\n");
                                            Console.ReadKey();
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(0, Console.CursorTop);
                                        }

                                    }
                                    if (sc1_2 == "no")
                                    {
                                        Thread.Sleep(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("--" + TeamEngineer + " : Roger " + CharacterName + ".\n");
                                        Thread.Sleep(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("--" + TeamEngineer + " > " + TeamDriver1 + " , " + TeamDriver2 + " : push a little harder on these laps, we can get more useful data.\n");
                                        Thread.Sleep(TimeSpan.FromSeconds(1));
                                        Console.WriteLine("A few laps later\n");
                                        Thread.Sleep(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("--Race control : Yellow flag sector 1 : Mark Rutte Pole Position Racing\n");
                                        Thread.Sleep(TimeSpan.FromSeconds(3));
                                        Console.WriteLine("--Mark Rutte : [CENSORED], Front wing is damaged\n");
                                        Thread.Sleep(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("--" + TeamEngineer + " : Copy, box box.\n");
                                        Console.ReadKey();

                                    }
                                    else { return; }
                                }
                                if (sc1_1 == "no")
                                {
                                    Thread.Sleep(TimeSpan.FromSeconds(1));
                                    Console.WriteLine("-- " + TeamEngineer + " : 10-4 , only " + TeamDriver2 + " will go out.\n");
                                    Thread.Sleep(TimeSpan.FromSeconds(5));
                                    Console.WriteLine(TeamDriver2 + " goes out on medium tyres.");
                                }
                                else { return; }
                            }
                            if (sc1 == "stay")
                            {
                                Console.WriteLine("-- " + TeamDriver2 + " : Copy, staying in.\n");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine("-- " + TeamEngineer + " : Boss, should we then send out " + TeamDriver1 + "?");
                                string sc3 = "";
                                sc3 = sc3.ToUpper();
                                sc3 = Console.ReadLine();
                                if (sc3 == "yes")
                                {
                                    Console.WriteLine("-- " + TeamEngineer + " : Affirm boss, sending out " + TeamDriver1 + ".");
                                    Console.ReadKey();
                                    break;
                                }
                                if (sc3 == "no")
                                {
                                    Console.WriteLine("-- " + TeamEngineer + " : Copy boss, both cars stay inside.");
                                    Thread.Sleep(TimeSpan.FromSeconds(5));

                                    Thread.Sleep(TimeSpan.FromSeconds(4));
                                    Console.WriteLine("-- " + TeamEngineer + " : The track is quite empty now, I suggest we send out the cars now, also there's limited time remaining.");

                                    break;
                                }
                                else
                                {
                                    return;
                                }
                            }
                            else
                            {
                                return;
                            }




                        case 2:
                            Console.WriteLine("Some time later...");
                            Console.ReadKey();

                            goto case 3;

                        //Qualifying//
                        case 3:
                            Console.Clear();

                            Console.WriteLine("The next day... Saturday 14th of March 2020, Qualifying time.");
                            Console.WriteLine("13:59 AM, 1 minute before pitlane opens for qualifying\n");
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("\n-- " + TeamDriver2 + " : Radio Check, 1 2 3, Radio Check\n");
                            string q1 = "";
                            q1 = q1.ToUpper();
                            q1 = Console.ReadLine();
                            if (q1 == "Radio Check")
                            {
                                Console.WriteLine("\n-- " + TeamDriver2 + " : " + RadioCheck[0]);
                                Thread.Sleep(TimeSpan.FromSeconds(5));
                                Console.WriteLine("\n-- " + TeamEngineer + " : Alright, it's almost quali time, 20 minute session. We just need to know how many runs we will do. 1, 2, 3 or 4 runs.");
                                string q1_1 = "";
                                q1_1 = q1_1.ToUpper();
                                q1_1 = Console.ReadLine();
                                if (q1_1 == "1")
                                {
                                    Thread.Sleep(TimeSpan.FromSeconds(4));
                                    Console.WriteLine("-- " + TeamEngineer + " : 10-4 boss, 1 run both cars.");
                                    Thread.Sleep(TimeSpan.FromSeconds(4));
                                    goto case 4;
                                }
                                if (q1_1 == "2")
                                {
                                    Thread.Sleep(TimeSpan.FromSeconds(4));
                                    Console.WriteLine("-- " + TeamEngineer + " : 10-4 boss, 2 runs both cars.");
                                    goto case 5;
                                }
                                if (q1_1 == "3")
                                {
                                    Thread.Sleep(TimeSpan.FromSeconds(4));
                                    Console.WriteLine("-- " + TeamEngineer + " : 10-4 boss, 3 runs both cars.");
                                    goto case 6;
                                }
                                if (q1_1 == "4")
                                {
                                    Thread.Sleep(TimeSpan.FromSeconds(4));
                                    Console.WriteLine("-- " + TeamEngineer + " : 10-4 boss, 4 runs both cars.");
                                    goto case 7;
                                }

                                else
                                {
                                    Console.WriteLine("-- " + TeamDriver2 + " : " + RadioCheck[1]);
                                    Console.ReadKey();
                                    Console.SetCursorPosition(0, Console.CursorTop);
                                }
                            }
                            break;

                        case 4:
                            Console.Clear();
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine("-- Race Control : " + RaceControlSessionCountDown[0]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[1]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[2]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[3]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[4]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[5]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[6]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[7]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[8]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[9]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[10]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine("-- Race Control : " + RaceControlSessionCountDown[11]);
                            Thread.Sleep(TimeSpan.FromSeconds(5));
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\nMichael Stonebank for Inglorious Bastards goes out!");
                            Thread.Sleep(TimeSpan.FromSeconds(2));
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Backmarker Racing sends out Freek Vonk!");
                            Thread.Sleep(TimeSpan.FromSeconds(2));
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cornercut Motorsport sends out Barack Obama on soft tyres.");
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Stefan Douwma goes out on track for Party Mode GP.");
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Tommy Vercetti goes out on track.");
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Kim Jong-Il for Kone Killers goes out on track.");
                            Thread.Sleep(TimeSpan.FromSeconds(5));
                            Console.ResetColor();
                            Console.WriteLine("\n-- " + TeamEngineer + " : Boss, should we send out both drivers now, or and the end of the session when there's more grip out there?");
                            string q2 = "";
                            q2 = q2.ToUpper();
                            q2 = Console.ReadLine();
                            if (q2 == "now")
                            {
                                Console.WriteLine("\n-- " + TeamEngineer + " : Copy, we'll send them out right now");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.WriteLine("\n-- " + TeamEngineer + " > " + TeamDriver2 + ", " + TeamDriver1 + " : Get ready, we'll send both of you out right now.\n");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(TeamDriver1 + " exits the pits.");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine(TeamDriver2 + " is going out.");
                                Thread.Sleep(TimeSpan.FromSeconds(8));
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Smooth Operators send out Will Power.");
                                Thread.Sleep(TimeSpan.FromSeconds(5));
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Pablo Escobar exits the pits for Kone Killers.");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Vreek Fonk starts his flying lap.");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Barack Obama has started his first flying lap.");
                                Thread.Sleep(TimeSpan.FromSeconds(4));
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Michael Stonebank started his first flying lap!");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Stefan Douwma has started his first flying lap.");
                                Thread.Sleep(TimeSpan.FromSeconds(6));
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Kim Jong-Il for Kone Killers started his first flying lap.");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Tommy Vercetti for Party Mode GP starts his first flying lap.");

                                Thread.Sleep(TimeSpan.FromSeconds(6));
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(TeamDriver1 + " starts his first flying lap.");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.WriteLine(TeamDriver2 + " started his first flying lap.");

                                Thread.Sleep(TimeSpan.FromSeconds(8));
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Will Power starts his first flying lap.");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Pablo Escobar is starting his first flying lap.");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Vreek Fonk goes fastest. (1.29.402)");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Barack Obama goes 1st. (1.29.205");
                                Thread.Sleep(TimeSpan.FromSeconds(4));
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Michael Stonebank goes to p3. (1.29.953)");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Stefan Douwma jumps Michael Stonebank to third. (1.29.563)");
                                Thread.Sleep(TimeSpan.FromSeconds(5));
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Kim Jong-Il goes fastest in the session. (1.29.007");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Tommy Vercetti sets the second fastest time of the session. (1.29.200)");

                                Thread.Sleep(TimeSpan.FromSeconds(6));
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(TeamDriver1 + " sets a time, fast enough for p3. (1.29.155)");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.WriteLine(TeamDriver2 + " goes p3, " + TeamDriver1 + " drops down to p4.");
                                Thread.Sleep(TimeSpan.FromSeconds(4));
                                Console.ResetColor();
                                Console.WriteLine("\n-- " + TeamEngineer + " : good laps guys, confirm box please. Fuel mode to mix 2. Multi 2.5.");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine("\n-- " + TeamDriver2 + " : Confirm, boxing now.");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.WriteLine("\n-- " + TeamDriver1 + " : Confirmed, boxing.");
                                Thread.Sleep(TimeSpan.FromSeconds(8));
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Will Power goes 4th fastest, dropping " + TeamDriver1 + " down to 5th.");
                                Thread.Sleep(TimeSpan.FromSeconds(1));
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Pablo Escobar goes 8th fastest. (1.29.781)");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Joseph Stalin, for Wrong Wheel Drive Mafia, goes out.");
                                Thread.Sleep(TimeSpan.FromSeconds(5));
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(TeamDriver1 + " (3rd) drives into the pits.");
                                Thread.Sleep(TimeSpan.FromSeconds(5));
                                Console.WriteLine(TeamDriver2 + " (5th) comes back in.");
                                Console.ResetColor();
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine("\n-- " + TeamEngineer + " > " + TeamDriver2 + ", " + TeamDriver1 + " : Well done guys, Now we'll have to wait and see what the others run.\n");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine("Press any key to continue to the results");
                                Console.ReadKey();
                                goto case 8;
                            }
                            if (q2 == "end")
                            {
                                Console.WriteLine("\n-- " + TeamEngineer + " : Copy, we'll send them out at the end of the session.");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.WriteLine("\n-- " + TeamEngineer + " > " + TeamDriver2 + TeamDriver1 + " : Get ready, we'll send both of you out at the end of the session.");
                                Thread.Sleep(TimeSpan.FromSeconds(6));
                                Console.WriteLine("17 Minutes later...\n");

                                Thread.Sleep(TimeSpan.FromSeconds(5));
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("\nNorm Benning goes out for a second run!");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Barack Obama goes out to do his third run of the session");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Henk Kerk goes out on soft tyres.");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Kim Jong-Il for Kone Killers goes out.");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Mahaveer Raghunathan goes out on track.");
                                Thread.Sleep(TimeSpan.FromSeconds(1));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Tean Fullspeed sends out Jon Spriggs for a second quali run.");
                                Thread.Sleep(TimeSpan.FromSeconds(5));
                                Console.ResetColor();
                                Console.WriteLine("\n-- " + TeamEngineer + " : We'll send them out right now with 3 minutes left");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.WriteLine("\n-- " + TeamEngineer + " > " + TeamDriver1 + ", " + TeamDriver2 + " : Get ready, we'll send both of you out right now.\n");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(TeamDriver2 + " exits the pits.");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine(TeamDriver1 + " is going out.");
                                Thread.Sleep(TimeSpan.FromSeconds(3));

                                Thread.Sleep(TimeSpan.FromSeconds(8));
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Stefan Douwma goes out for a third run.");
                                Thread.Sleep(TimeSpan.FromSeconds(5));
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Max Knoll exits the pits for Kone Killers.");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Norm Benning starts his final flying lap");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Barack Obama is starting his last flying lap of the session.");
                                Thread.Sleep(TimeSpan.FromSeconds(4));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Henk Kerk for Backmarker Racing starts his final lap.");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Kim Jong-Il starts his flying lap.");
                                Thread.Sleep(TimeSpan.FromSeconds(6));
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Mahaveer Raghunathan goes out on track.");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Jon Spriggs for Team Fullspeed starts his final lap.");
                                Thread.Sleep(TimeSpan.FromSeconds(6));
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(TeamDriver1 + " starts his first flying lap.");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.WriteLine(TeamDriver2 + " started his first flying lap.");

                                Thread.Sleep(TimeSpan.FromSeconds(8));
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Stefan Douwma is starting a hotlap.");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Max Knoll is starting his 2nd hotlap.");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ResetColor();
                                Console.WriteLine("\n-- Race Control : Session Over, finish your final lap.\n");
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("Norm Benning goes p8. (1.30.245)");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Barack Obama goes 1st. (1.29.205");
                                Thread.Sleep(TimeSpan.FromSeconds(4));
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Michael Stonebank goes to p3. (1.29.953)");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Stefan Douwma jumps Michael Stonebank to third. (1.29.563)");
                                Thread.Sleep(TimeSpan.FromSeconds(5));
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Kim Jong-Il goes fastest in the session. (1.29.007");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Tommy Vercetti sets the second fastest time of the session. (1.29.200)");

                                Thread.Sleep(TimeSpan.FromSeconds(6));
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(TeamDriver1 + " Spins into the gravel! Yellow Flag sector 2");
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.WriteLine(TeamDriver2 + " goes p8 for Pole Position Racing. (1.30.133)");
                                Console.ResetColor();
                                Thread.Sleep(TimeSpan.FromSeconds(4));
                                Console.WriteLine("\n-- Race Control : Session Over, Red Flag for Car 7 : " + TeamDriver1 + " (Pole Position Racing)!\n");
                                Console.ResetColor();
                                Console.WriteLine("\n-- " + TeamEngineer + " > " + TeamDriver1 + ": Are you okay? Though luck mate.");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine("\n-- " + TeamDriver1 + " : [CENSORED] [CENSORED], Sorry guys. [CENSORED]");
                                Thread.Sleep(TimeSpan.FromSeconds(4));
                                Console.WriteLine("\n-- " + TeamDriver2 + " : What position are we in?");
                                Thread.Sleep(TimeSpan.FromSeconds(8));
                                Console.ResetColor();
                                Console.WriteLine("\n-- " + TeamEngineer + " > " + TeamDriver2 + ": P8, P8, good job.\n");
                                Thread.Sleep(TimeSpan.FromSeconds(5));
                                Console.WriteLine("Press any key to continue to the results");
                                Console.ReadKey();
                                goto case 8;
                            }
                            else
                            {
                                Console.Clear();
                                Console.SetCursorPosition(0, Console.CursorTop);
                            }

                            break;
                        case 5:
                            Console.Clear();
                            Thread.Sleep(TimeSpan.FromSeconds(4));
                            Console.WriteLine("-- Race Control : " + RaceControlSessionCountDown[0]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[1]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[2]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[3]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[4]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[5]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[6]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[7]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[8]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[9]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[10]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine("\n-- Race Control : " + RaceControlSessionCountDown[11]);
                            break;
                        case 6:
                            Console.Clear();
                            Thread.Sleep(TimeSpan.FromSeconds(4));
                            Console.WriteLine("-- Race Control : " + RaceControlSessionCountDown[0]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[1]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[2]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[3]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[4]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[5]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[6]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[7]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[8]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[9]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[10]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine("\n-- Race Control : " + RaceControlSessionCountDown[11]);
                            break;
                        case 7:
                            Console.Clear();
                            Thread.Sleep(TimeSpan.FromSeconds(4));
                            Console.WriteLine("-- Race Control : " + RaceControlSessionCountDown[0]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[1]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[2]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[3]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[4]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[5]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[6]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[7]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[8]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[9]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine(RaceControlSessionCountDown[10]);
                            Thread.Sleep(TimeSpan.FromSeconds(1));
                            Console.WriteLine("\n-- Race Control : " + RaceControlSessionCountDown[11]);
                            break;

                        case 8:
                            {
                                Console.Clear();
                                Console.WriteLine("Qualifying Results");
                                Console.WriteLine("\n\n" + CYear + @" " + OWT1 + " Albert Park qualifying results\n");
                                PrintLine();
                                PrintRow("Pos", "Driver", "Team");
                                PrintLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                PrintRow("1.", "Henk Kerk", "Team Fullspeed");
                                Console.ForegroundColor = ConsoleColor.Red;
                                PrintRow("2.", "Barack Obama", "Cornercut Motorsport");
                                Console.ForegroundColor = ConsoleColor.White;
                                PrintRow("3.", "Jon Spriggs", "Team Fullspeed");
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                PrintRow("4.", "Norm Benning", "Infinity Motorsport");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                PrintRow("5.", "Mahaveer Raghunathan", "Team Divebomb");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                PrintRow("6.", "Dzjengis Khan", "Inglorious Basterds");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                PrintRow("7.", "Leandre Berube Berbegon", "Wrong Wheel Drive Mafia");
                                Console.ForegroundColor = ConsoleColor.Green;
                                PrintRow("8.", "Tommy Vercetti", "Party Mode GP");
                                PrintRow("9.", "Stefan Douwma", "Party Mode GP");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                PrintRow("10.", "Aiden Hoek", "Team Divebomb");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                PrintRow("11.", "Philip Dryer", "Pole Position Racing");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                PrintRow("12.", "Max Knoll", "Backmarker Racing");
                                Console.ForegroundColor = ConsoleColor.Red;
                                PrintRow("13.", "Cameron Mckay", "Cornercut Motorsport");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                PrintRow("14.", "Kim Jong-Il", "Kone Killers");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                PrintRow("15.", "Mark Rutte", "Pole Position Racing");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                PrintRow("16.", "Joseph Stalin", "Wrong Wheel Drive Mafia");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                PrintRow("17.", "Matt Judge", "Bad Decision Racing");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                PrintRow("18.", "Pablo Escobar", "Kone Killers");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                PrintRow("19.", "Alain Giorla", "Bad Decision Racing");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                PrintRow("20.", "Grote Smurf", "Inglorious Basterds");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                PrintRow("21.", "Will Power", "Smooth Operators");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                PrintRow("22.", "Vreek Vonk", "Backmarker Racing");
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                PrintRow("23.", "Phil Swift", "Infinity Motorsport");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                PrintRow("24.", "Matthew Gallagher", "Smooth Operators");
                                Console.ResetColor();
                                PrintLine();

                                static void PrintLine()
                                {
                                    Console.WriteLine(new string('-', tableWidth));
                                }

                                static void PrintRow(params string[] columns)
                                {
                                    int width = (tableWidth - columns.Length) / columns.Length;
                                    string row = "|";

                                    foreach (string column in columns)
                                    {
                                        row += AlignCentre(column, width) + "|";
                                    }

                                    Console.WriteLine(row);
                                }

                                static string AlignCentre(string text, int width)
                                {
                                    text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

                                    if (string.IsNullOrEmpty(text))
                                    {
                                        return new string(' ', width);
                                    }
                                    else
                                    {
                                        return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
                                    }
                                }

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Henk Kerk is on pole position in Albert Park for Team FullSpeed!");
                                Console.ResetColor();
                                Console.WriteLine("Press enter to continue to the race!");
                                Console.ReadKey();
                                continue;
                            }
                        case 9:
                            {
                                Console.Clear();
                                Console.WriteLine("Qualifying Results");
                                Console.WriteLine("\n\n" + CYear + @" " + OWT1 + " Albert Park qualifying results\n");
                                PrintLine();
                                PrintRow("Pos", "Driver", "Team");
                                PrintLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                PrintRow("1.", "Henk Kerk", "Team Fullspeed");
                                Console.ForegroundColor = ConsoleColor.Red;
                                PrintRow("2.", "Barack Obama", "Cornercut Motorsport");
                                Console.ForegroundColor = ConsoleColor.White;
                                PrintRow("3.", "Jon Spriggs", "Team Fullspeed");
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                PrintRow("4.", "Norm Benning", "Infinity Motorsport");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                PrintRow("5.", "Mahaveer Raghunathan", "Team Divebomb");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                PrintRow("6.", "Dzjengis Khan", "Inglorious Basterds");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                PrintRow("7.", "Leandre Berube Berbegon", "Wrong Wheel Drive Mafia");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                PrintRow("8.", "Philip Dryer", "Pole Position Racing");
                                Console.ForegroundColor = ConsoleColor.Green;
                                PrintRow("9.", "Stefan Douwma", "Party Mode GP");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                PrintRow("10.", "Aiden Hoek", "Team Divebomb");
                                Console.ForegroundColor = ConsoleColor.Green;
                                PrintRow("11.", "Tommy Vercetti", "Party Mode GP");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                PrintRow("12.", "Max Knoll", "Backmarker Racing");
                                Console.ForegroundColor = ConsoleColor.Red;
                                PrintRow("13.", "Cameron Mckay", "Cornercut Motorsport");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                PrintRow("14.", "Kim Jong-Il", "Kone Killers");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                PrintRow("15.", "Matthew Gallagher", "Smooth Operators");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                PrintRow("16.", "Joseph Stalin", "Wrong Wheel Drive Mafia");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                PrintRow("17.", "Matt Judge", "Bad Decision Racing");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                PrintRow("18.", "Pablo Escobar", "Kone Killers");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                PrintRow("19.", "Alain Giorla", "Bad Decision Racing");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                PrintRow("20.", "Grote Smurf", "Inglorious Basterds");
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                PrintRow("21.", "Will Power", "Smooth Operators");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                PrintRow("22.", "Vreek Vonk", "Backmarker Racing");
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                PrintRow("23.", "Phil Swift", "Infinity Motorsport");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                PrintRow("24.", "Mark Rutte", "Pole Position Racing");
                                Console.ResetColor();
                                PrintLine();

                                static void PrintLine()
                                {
                                    Console.WriteLine(new string('-', tableWidth));
                                }

                                static void PrintRow(params string[] columns)
                                {
                                    int width = (tableWidth - columns.Length) / columns.Length;
                                    string row = "|";

                                    foreach (string column in columns)
                                    {
                                        row += AlignCentre(column, width) + "|";
                                    }

                                    Console.WriteLine(row);
                                }

                                static string AlignCentre(string text, int width)
                                {
                                    text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

                                    if (string.IsNullOrEmpty(text))
                                    {
                                        return new string(' ', width);
                                    }
                                    else
                                    {
                                        return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
                                    }
                                }
                            }

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Henk Kerk is on pole position in Albert Park for Team FullSpeed!");
                            Console.ResetColor();
                            Console.WriteLine("Press enter to continue to the race!");
                            Console.ReadKey();
                            break;
                    }
                }

                else
                {
                    Console.WriteLine(TypedWrong[0]);
                    Console.ReadKey();
                    Console.SetCursorPosition(0, Console.CursorTop);
                }
            }
        }

        static void RandomRace()
        {
            Random rd = new Random();
            randomIndex = rd.Next(0, WeatherType.Length);
        }

        static void OWT1Race()
        {
            for (int scenario = 1; scenario <= PracticeScenarios; scenario++)
            {
                switch (scenario)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("The next day... Sunday 15th of March 2020, Race time.");
                        Console.WriteLine("12:40, 20 minutes before formation lap for the Australian GP at Albert Park.\n");
                        Console.WriteLine("Weather Report :");

                        Console.WriteLine("\nCurrent Track conditions : " + WeatherType[randomIndex] + ", " + AUSTemp[randomIndex] + " Degrees air temperature, 30% chance for rain.");
                        Thread.Sleep(TimeSpan.FromSeconds(3));
                        Console.WriteLine("\n-- " + TeamDriver1 + " : Radio Check, 1 2 3, Radio Check\n");

                        string word = "";
                        word = word.ToUpper();
                        word = Console.ReadLine();

                        if (word == "Radio Check")
                        {
                            goto case 2;
                        }
                        else
                        {
                            return;
                        }

                    case 2:
                        Thread.Sleep(TimeSpan.FromSeconds(3));
                        Console.WriteLine("\n-- " + TeamDriver1 + " : Loud and clear boss\n");
                        Thread.Sleep(TimeSpan.FromSeconds(5));
                        Console.WriteLine("\n-- " + TeamEngineer + " : We have some pretty interesting starting positions today, we just need to figure out the strategy for both cars.\n There are several strategies we can use.\n" +
                            "1. Plan A. We could make a one stop work. The drivers will need to conserve the tyres for quite a bit, so we'll lose time on track. But we'll let them start on hards, and finish on medium.\n" +
                            "2. Plan B. 2 Stops seems more reasonable, our drivers can push more but will lose more time in the pits than with a one stop. Our drivers will start on mediums, then pit for mediums again and then on softs for the final stint.\n" +
                            "3. Plan C. Three stops can work out under specific circumstances. We would need a safety car or rain to make it work. We'll let them start on soft. Then for stint 2, they'll go on softs again. Stint 3 will be medium and on the final stint they'll go on soft again.\n\n" +
                            "Let me know what you think boss. Just say the number");
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        string input = "";
                        input = input.ToUpper();
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("\n-- " + TeamEngineer + " : Copy that, 1 stopper it is. Drivers will start");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            goto case 3;
                        }
                        if (input == "2")
                        {
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("\n-- " + TeamEngineer + " : Copy that, 2 stops.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            goto case 4;
                        }
                        if (input == "3")
                        {
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("\n-- " + TeamEngineer + " : Copy that, 3 stops.");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            goto case 5;
                        }
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/ 
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/ 
                                        ");
                        Thread.Sleep(TimeSpan.FromSeconds(5));
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"
   ___  
  / _ \ 
 | | | |
 | | | |
 | |_| |
  \___/ 
   ___  
  / _ \ 
 | | | |
 | | | |
 | |_| |
  \___/ ");

                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___  
  / _ \   / _ \ 
 | | | | | | | |
 | | | | | | | |
 | |_| | | |_| |
  \___/   \___/ 
   ___     ___  
  / _ \   / _ \ 
 | | | | | | | |
 | | | | | | | |
 | |_| | | |_| |
  \___/   \___/ ");

                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___     ___  
  / _ \   / _ \   / _ \ 
 | | | | | | | | | | | |
 | | | | | | | | | | | |
 | |_| | | |_| | | |_| |
  \___/   \___/   \___/ 
   ___     ___     ___  
  / _ \   / _ \   / _ \ 
 | | | | | | | | | | | |
 | | | | | | | | | | | |
 | |_| | | |_| | | |_| |
  \___/   \___/   \___/ ");

                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/ 
   ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/ ");

                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/ 
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/ 
                                        ");

                        Thread.Sleep(TimeSpan.FromSeconds(6));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/ 
                                        ");
                        Console.ResetColor();
                        Console.WriteLine("ITS LIGHTS OUT, AND AWAY WE GO!");
                        Thread.Sleep(TimeSpan.FromSeconds(3));
                        Console.Clear();
                        Thread.Sleep(TimeSpan.FromSeconds(3));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Henk Kerk goes into turn 1 first");
                        Thread.Sleep(TimeSpan.FromSeconds(3));
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Philip Dyer jumps to P7!");
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Stefan Douwma for Party Mode GP goes off track in Turn 2!");
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        Console.ResetColor();
                        Console.WriteLine("Lap 2 starts");
                        Thread.Sleep(TimeSpan.FromSeconds(3));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Henk Kerk sets the fastest lap of the race.");
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Philip Dyer has to defend from Leandre Berube Berbegon");
                        Thread.Sleep(TimeSpan.FromSeconds(3));
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Mark Rutte is now in p20.");
                        Thread.Sleep(TimeSpan.FromSeconds(5));
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Philip Dyer has fallen to p8. Leandre Berube Berbegon takes p7!");
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        Console.ResetColor();
                        Console.WriteLine("Lap 3 starts");
                        Thread.Sleep(TimeSpan.FromSeconds(4));
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Barack Obama is attempting to overtake Henk Kerk for 1st!");
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        Console.WriteLine("Barack Obama has overtaken Henk Kerk for 1st!");
                        Thread.Sleep(TimeSpan.FromSeconds(3));
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Mark Rutte is now P20, attempting to overtake Pablo Escobar");
                        Thread.Sleep(TimeSpan.FromSeconds(4));
                        Console.WriteLine("Philip Dyer is attacking Leandre Berube Berbegon for P7, with Aiden Hoek right behind them.");
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        Console.ResetColor();
                        Console.WriteLine("Lap 4 starts");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        Console.WriteLine("Jon Spriggs has set the fastest lap of the race!");
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        Console.ResetColor();
                        Console.WriteLine("Lap 5 starts");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.WriteLine("Jon Spriggs has set another fastest lap of the race!");
                        Thread.Sleep(TimeSpan.FromSeconds(4));
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Aiden Hoek has overtaken 2 cars, he's no P7! Philip Dyer is now P9");
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        Console.ResetColor();
                        Console.WriteLine("Lap 7 starts");
                        Thread.Sleep(TimeSpan.FromSeconds(5));
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Stefan Douwma is pitting for Party Mode GP, We think he's on a 3 stop strategy!");
                        Console.ResetColor();
                        Thread.Sleep(TimeSpan.FromSeconds(5));
                        Console.WriteLine("Lap 9 starts");
                        Thread.Sleep(TimeSpan.FromSeconds(5));
                        Console.ResetColor();
                        Console.WriteLine("\n--Philip Dyer : Can I push a little bit more? I have been stuck behind Hoek for ages now!");
                        string race1 = "";
                        race1 = race1.ToUpper();
                        race1 = Console.ReadLine();
                        if (race1 == "yes")
                        {
                            Console.WriteLine("\n--Philip Dyer : Copy boss. Pushing now");
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Philip Dyer has overtaken Aiden Hoek for 7th!");
                            Console.ResetColor();
                            Thread.Sleep(TimeSpan.FromSeconds(5));
                            Console.WriteLine("Lap 11 starts");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Thread.Sleep(TimeSpan.FromSeconds(5));
                            Console.WriteLine("Max Knoll is pitting, it looks like he's on a 2 stop strategy");
                            Console.ResetColor();
                            Thread.Sleep(TimeSpan.FromSeconds(5));
                            Console.WriteLine("Lap 15 starts");
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("Mark Rutte is now P18, overtaking Pablo Escobar!");
                            Console.ResetColor();
                            Thread.Sleep(TimeSpan.FromSeconds(5));
                            Console.WriteLine("Lap 16 starts");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(TimeSpan.FromSeconds(2));
                            Console.WriteLine("Jon Spriggs has overtaking his teammate Henk Kerk for P2!");
                            Console.ResetColor();
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("Lap 16 starts");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Cameron Mckay for Cornercut Motorsport has retired in sector 2! (brakes)");
                            Thread.Sleep(TimeSpan.FromSeconds(2));
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Kim Jong-Il is now pitting!");
                            Console.ResetColor();
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("Lap 20 starts");
                            Thread.Sleep(TimeSpan.FromSeconds(5));
                            Console.ResetColor();
                            Console.WriteLine("\n--Philip Dyer : Tyres are feeling worse and worse, when do we pit?");
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("\n--Andrew Hawkins : Pit windows is open, box box.");
                            Thread.Sleep(TimeSpan.FromSeconds(2));
                            Console.WriteLine("\n--Philip Dyer : Confirm Boxing.");
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("\nLap 21 starts");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Thread.Sleep(TimeSpan.FromSeconds(4));
                            Console.WriteLine("Philip Dyer has come into the pits for hard tyres.");
                            Thread.Sleep(TimeSpan.FromSeconds(2));
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Matthew Gallagher is pitting!");
                            Thread.Sleep(TimeSpan.FromSeconds(2));
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Joseph Stalin for Wrong Wheel Drive Mafia is in the pits");
                            Thread.Sleep(TimeSpan.FromSeconds(2));
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Matt Judge is now in the pit");
                            Console.ResetColor();
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("Lap 25 starts");
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("\n--Andrew Hawkins > Mark Rutte : Pit window for you is now open, box box confirm please.");
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("\n--Mark Rutte : Yeah Box Box Box");
                            Console.ResetColor();
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("\nLap 29 starts");
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("\nHalfway through! Philip Dyer is 9th, Mark Rutte is 20th. Barack Obama is leading the race.\n");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Thread.Sleep(TimeSpan.FromSeconds(4));
                            Console.WriteLine("Mark Rutte is attempting to overtake Matt Judge for 19th.");
                            Thread.Sleep(TimeSpan.FromSeconds(2));
                            Console.WriteLine("Mark Rutte is now 19th, ahead of Matt Judge");
                            Console.ResetColor();
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("\nLap 35 starts");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Thread.Sleep(TimeSpan.FromSeconds(4));
                            Console.WriteLine("Mark Rutte has overtaken Joseph Stalin for 17th.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(TimeSpan.FromSeconds(2));
                            Console.WriteLine("Jon Spriggs is attempting to overtake Barack Obama for P1!");
                            Console.ResetColor();
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("\nLap 50 starts");
                            Thread.Sleep(TimeSpan.FromSeconds(3));
                            Console.WriteLine("--Race Control : SAFETY CAR IS OUT, SAFETY CAR IS OUT. Crash Turn 1 involving cars 6 - 7 (Mahaveer Raghunathanm, Dzjengis Khan)");
                            Thread.Sleep(TimeSpan.FromSeconds(4));
                            Console.ResetColor();
                            Console.WriteLine("\n--Philip Dyer : Safety car! Should we pit and risk it?");
                            string race2 = "";
                            race2 = race2.ToUpper();
                            race2 = Console.ReadLine();
                            if (race2 == "yes")
                            {
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine("\n--Philip Dyer : Copy, Boxing");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Henk Kerk is pitting from 3rd position");
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Thread.Sleep(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Norm Benning is pitting");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Thread.Sleep(TimeSpan.FromSeconds(4));
                                Console.WriteLine("Philip Dyer is boxing");
                                Thread.Sleep(TimeSpan.FromSeconds(6));
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Tommy Vercetti is now in the pits");
                                Console.ResetColor();
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine("\nLap 55 starts");
                                Thread.Sleep(TimeSpan.FromSeconds(1));
                                Console.WriteLine("--Race Control : SAFETY CAR IS IN, GREEN FLAG!");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Thread.Sleep(TimeSpan.FromSeconds(4));
                                Console.WriteLine("Philip Dyer has overtaken Stefan Douwma for 6th!");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine("Mark Rutte has overtaking Kim Jong-Il for 14th.");

                                Console.ResetColor();
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine("\nLap 58 starts");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine("Barack Obama has won the Australian GP for Cornercut motorsport!");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine("Philip Dyer has crossed the line in 6th position");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.ResetColor();
                                Console.WriteLine("\n--Philip Dyer : Well done guys, p6!");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine("\n--Andrew Hawkins : great drive bud, great drive.");
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine("Mark Rutte comes home in P13");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.ResetColor();
                                Console.WriteLine("\n--Mark Rutte : [CENSORED] that was tough in the end there");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine("\n--Andrew Hawkins : Biggest mover of the field mate, good job.");
                                Thread.Sleep(TimeSpan.FromSeconds(3));
                                Console.WriteLine("Press enter to continue to results");
                                Console.ReadKey();
                                goto case 6;
                            }
                        }
                        if (race1 == "no")
                        {
                            Console.WriteLine("\n--Philip Dyer : Copy boss.");
                        }
                        else
                        {
                            continue;
                        }



                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@"
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/ 
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/ 
                                        ");
                        Thread.Sleep(TimeSpan.FromSeconds(5));
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"
   ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___     ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \   / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| | | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/   \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
   ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___     ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \   / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| | | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/   \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
                                        ");

                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/   \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
   ___     ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/   \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
                                        ");

                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___     ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/   \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
   ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___     ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/   \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
                                        ");

                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \   / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| | | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/   \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
   ___     ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \   / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| | | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/   \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
                                        ");

                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/ 
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/ 
                                        ");

                        Thread.Sleep(TimeSpan.FromSeconds(6));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/ 
                                        ");
                        Console.ResetColor();
                        Console.WriteLine("ITS LIGHTS OUT, AND AWAY WE GO!");

                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(TimeSpan.FromSeconds(6));
                        Console.WriteLine("Henk Kerk goes into turn 1 first");




                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@"
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/ 
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/ 
                                        ");
                        Thread.Sleep(TimeSpan.FromSeconds(5));
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(@"
   ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___     ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \   / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| | | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/   \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
   ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___     ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \   / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| | | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/   \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
                                        ");

                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/   \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
   ___     ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/   \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
                                        ");

                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___     ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/   \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
   ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___     ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | | | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/   \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
                                        ");

                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \   / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| | | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/   \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
   ___     ___     ___     ___  "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"   ___  "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  / _ \   / _ \   / _ \   / _ \ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  / _ \ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | | | | | | | | | | | | | | | |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | | | |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
 | |_| | | |_| | | |_| | | |_| |"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@" | |_| |"); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
  \___/   \___/   \___/   \___/ "); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(@"  \___/ "); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(@"
                                        ");

                        Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/ 
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/ 
                                        ");

                        Thread.Sleep(TimeSpan.FromSeconds(6));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine(@"
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/
   ___     ___     ___     ___     ___  
  / _ \   / _ \   / _ \   / _ \   / _ \ 
 | | | | | | | | | | | | | | | | | | | |
 | | | | | | | | | | | | | | | | | | | |
 | |_| | | |_| | | |_| | | |_| | | |_| |
  \___/   \___/   \___/   \___/   \___/ 
                                        ");
                        Console.ResetColor();
                        Console.WriteLine("ITS LIGHTS OUT, AND AWAY WE GO!");

                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(TimeSpan.FromSeconds(6));
                        Console.WriteLine("Henk Kerk goes into turn 1 first");
                        break;

                    case 6:
                        PrintLine();
                        PrintRow("Pos", "Driver", "Team");
                        PrintLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        PrintRow("1.", "Barack Obama", "Cornercut Motorsport");
                        Console.ForegroundColor = ConsoleColor.White;
                        PrintRow("2.", "Jon Spriggs", "Team Fullspeed");
                        Console.ForegroundColor = ConsoleColor.White;
                        PrintRow("3.", "Henk Kerk", "Team Fullspeed");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        PrintRow("4.", "Norm Benning", "Infinity Motorsport");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        PrintRow("5.", "Leandre Berube Berbegon", "Wrong Wheel Drive Mafia");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        PrintRow("6.", "Philip Dryer", "Pole Position Racing");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        PrintRow("7.", "Aiden Hoek", "Team Divebomb");
                        Console.ForegroundColor = ConsoleColor.Green;
                        PrintRow("8.", "Stefan Douwma", "Party Mode GP");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        PrintRow("9.", "Max Knoll", "Backmarker Racing");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        PrintRow("10.", "Matthew Gallagher", "Smooth Operators");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        PrintRow("11.", "Alain Giorla", "Bad Decision Racing");
                        Console.ForegroundColor = ConsoleColor.Green;
                        PrintRow("12.", "Tommy Vercetti", "Party Mode GP");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        PrintRow("13.", "Grote Smurf", "Inglorious Basterds");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        PrintRow("14.", "Mark Rutte", "Pole Position Racing");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        PrintRow("15.", "Kim Jong-Il", "Kone Killers");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        PrintRow("16.", "Matt Judge", "Bad Decision Racing");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        PrintRow("17.", "Joseph Stalin", "Wrong Wheel Drive Mafia");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        PrintRow("18.", "Will Power", "Smooth Operators");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        PrintRow("19.", "Pablo Escobar", "Kone Killers");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        PrintRow("20.", "Vreek Vonk", "Backmarker Racing");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        PrintRow("21.", "Phil Swift", "Infinity Motorsport");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        PrintRow("22.", "Mahaveer Raghunathan", "Team Divebomb");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        PrintRow("23.", "Dzjengis Khan", "Inglorious Basterds");
                        Console.ForegroundColor = ConsoleColor.Red;
                        PrintRow("24.", "Cameron Mckay", "Cornercut Motorsport");

                        static void PrintLine()
                        {
                            Console.WriteLine(new string('-', tableWidth));
                        }

                        static void PrintRow(params string[] columns)
                        {
                            int width = (tableWidth - columns.Length) / columns.Length;
                            string row = "|";

                            foreach (string column in columns)
                            {
                                row += AlignCentre(column, width) + "|";
                            }

                            Console.WriteLine(row);
                        }

                        static string AlignCentre(string text, int width)
                        {
                            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

                            if (string.IsNullOrEmpty(text))
                            {
                                return new string(' ', width);
                            }
                            else
                            {
                                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
                            }
                        }
                        Console.ResetColor();
                        Console.WriteLine("Well done, you have completed your first ever race! See you in 2 weeks!");
                        Console.ReadKey();
                        break;
                }
            }
        }


        static void GameTitle()
        {
            Console.WindowHeight = Console.LargestWindowHeight - 20;
            Console.WindowWidth = Console.LargestWindowWidth - 20;

            Console.Title = "Low Budget Motorsport Manager";
            string title = @"
  _                     ____            _            _     __  __       _                                  _     __  __                                   
 | |                   |  _ \          | |          | |   |  \/  |     | |                                | |   |  \/  |                                  
 | |     _____      __ | |_) |_   _  __| | __ _  ___| |_  | \  / | ___ | |_ ___  _ __ ___ _ __   ___  _ __| |_  | \  / | __ _ _ __   __ _  __ _  ___ _ __ 
 | |    / _ \ \ /\ / / |  _ <| | | |/ _` |/ _` |/ _ \ __| | |\/| |/ _ \| __/ _ \| '__/ __| '_ \ / _ \| '__| __| | |\/| |/ _` | '_ \ / _` |/ _` |/ _ \ '__|
 | |___| (_) \ V  V /  | |_) | |_| | (_| | (_| |  __/ |_  | |  | | (_) | || (_) | |  \__ \ |_) | (_) | |  | |_  | |  | | (_| | | | | (_| | (_| |  __/ |   
 |______\___/ \_/\_/   |____/ \__,_|\__,_|\__, |\___|\__| |_|  |_|\___/ \__\___/|_|  |___/ .__/ \___/|_|   \__| |_|  |_|\__,_|_| |_|\__,_|\__, |\___|_|   
                                           __/ |                                         | |                                               __/ |          
                                          |___/                                          |_|                                              |___/           
";
            Console.WriteLine(title);
            Console.WriteLine("Welcome to Low Budget Motorsport Manager.");
            Console.WriteLine(@"
Take control your favorite teams, choosing the drivers, improving the car, upgrading your HQ and make the winning strategy for the race.
You can choose from a few racing classes : Open Wheel, GT, Endurance, Stockcars, Touring Cars. One of these is probably for you!");
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
            Console.Clear();
        }




        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////// QUIT GAME /////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        static void EndGame()
        {
            Console.WriteLine("\nThanks for playing, press enter to exit game.");
        }

        class Program
        {

            static void Main()
            {

                Game.StartGame();
                Console.ReadKey();
            }
        }

    }
}
