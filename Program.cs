using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace TextBasedGame
{
    public static class Game
    {
        //Driver Strings//
        //OWT1 Drivers//
        //static string 
        
        //Championship Strings
        static string OWT1 = "Formula Ultra";
        static string OWT2 = "Formula Nitro";
        static string OWT3 = "Formula Turbo";
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
        static string OWT2S = "FN";
        static string OWT3S = "FT";
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
        static string UNOPENED = "";

        //Year Strings//
        static string CYear = "2020";
        static string LYear = "2019";

        //News outlet strings//
        static string NewsOutlet1 = "Channel 69420";
        static string NewsOutlet1Mail = "Channel69420";

        //Weather//
        private static string[] WeatherType = new string[9] { "Clear", "Light Cloud", "Partially Cloudy", "Cloudy", "Overcast", "Light Rain", "Rain", "Heavy Rain", "Monsoon" };
        private static int randomIndex = -1;
        private static String UserInput = "";



        //OWT1 ONLY STATIC STRINGS//
        ////////////////////////////

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

        //Teams//
        static string OWT1Team1 = "Pole Position Racing";
        static string OWT1Team2 = "Kone Killers";
        static string OWT1Team3 = "Party Mode GP";
        static string OWT1Team4 = "Team Fullspeed";
        static string OWT1Team5 = "Cornercut Motorsport";
        static string OWT1Team6 = "Bad Decision Racing";
        static string OWT1Team7 = "Backmarker Racing";
        static string OWT1Team8 = "Infinity Motorsport";
        static string OWT1Team9 = "Team Divebomb";
        static string OWT1Team10 = "Smooth Operators";
        static string OWT1Team11 = "Wrong Wheel Drive Mafia";
        static string OWT1Team12 = "Inglorious Bastards";

        //Circuits - Australia
        //Albert Park
        static string Albertpark = "Albert Park";
        static string AlbertParkLoc = "Australia";
        static string AlbertParkInfo1 = "Race Distance - 58 Laps";
        static string AlbertParkInfo2 = "First Race - 1996";
        //Bathurst

        //Circuits - Austria
        //Austria

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
        static int IntroChoices = 1;
        static string[] IntroChoice = { "Type it again, make sure you have no typos." };

        //Scenarios//
        static int Scenarios = 10;
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
            ///Intro and Title///  
            GameTitle();

            ///Menu///            


            //Starting Game//
            NameCharacter();
            TeamChoice();
            OWT1Intro();
            MenuOWT1();

            //RaceWeekend//
            PracticeOWT1();
            //QualiOWT1();
            //RaceOWT1();

            ///GAME///

            ///EXIT GAME///
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
                        Console.WriteLine("\n \nThe pinnacle of motorsport. 12 of the best teams and 24 of the best drivers go against eachother on the world's famous tracks.\n");
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
                                                                                                        /___/  "); TeamName = "Pole Position Racing"; TeamDriver1 = "T Driver 1"; TeamDriver2 = "T Driver 2"; }
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
|| From : " + ChairmanEmail + @"@bmail.com                                                                                                                                                               
|| Subject : Welcome to " + TeamName + "!" +
@"
||
||
|| " + CharacterName + @",
||
|| We are very happy to announce you as our team principal for the 2020 season onwards, This mail will help you learn the team alongside the staff.
||
|| So let's start with introducing the drivers :
||
|| " + TeamDriver1 + @"
||
|| He's a young prospect with a decent career in the junior series. He will need to prove himself this year after a though rookie season.
||
||
|| " + TeamDriver2 + @"
||
|| One of the better drivers in " + OWT1 + @", although a little bit old, he still got it. Atleast... He said that himself.
||
||
|| Best Regards,
|| " + TeamChairman + ", " + TeamName + @"
|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                            Console.WriteLine("\nIf you are done reading the mail, press enter and we'll starting doing the first preperations for the first race weekend at " + Albertpark + ".");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(IntroChoice[0]);
                            Console.ReadKey();
                            Console.Clear();
                            goto case 1;
                        }
                        break;
                }
            }
        }

        static void MenuOWT1()
        {
            Console.Clear();

            for (int scenario = 1; scenario <= Scenarios; scenario++)
            {
                string input = "";

                switch (scenario)
                {
                    case 1:
                        //Main Menu
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
9 - Continue to " + Albertpark);
                        input = Console.ReadLine();
                        if (input == "1")
                        { goto case 2; }
                        if (input == "2")
                        { goto case 3; }
                        if (input == "3")
                        { goto case 4; }
                        if (input == "4")
                        { goto case 5; }
                        if (input == "5")
                        { goto case 6; }
                        if (input == "6")
                        { goto case 7; }
                        if (input == "7")
                        { goto case 8; }
                        if (input == "8")
                        { goto case 9; }
                        if (input == "9")
                        { goto case 10; }
                        else { goto case 1; };

                    case 2:
                        Console.Clear();
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
                            continue;
                        }
                        if (input == "PPR")
                        {
                            Console.Clear();
                            Console.WriteLine(@"
|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
|| From : " + NewsOutlet1Mail + @"@bmail.com                                                                                                                                                               
|| Subject : PPR New manager!
||
||
|| " + CharacterName + @",
||
|| We are very happy to announce you as our team principal for the 2020 season onwards, This mail will help you learn the team alongside the staff.
||
|| So let's start with introducing the drivers :
||
|| " + TeamDriver1 + @"
||
|| He's a young prospect with a decent career in the junior series. He will need to prove himself this year after a though rookie season.
||
||
|| " + TeamDriver2 + @"
||
|| One of the better drivers in " + OWT1 + @", although a little bit old, he still got it. Atleast... He said that himself.
||
||
|| Best Regards,
|| " + NewsOutlet1 + @"
|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                            Console.WriteLine("\nTo go back, press 0");
                            Console.ReadKey();
                            goto case 2;
                        }
                        else
                        {
                            goto case 2;
                        };

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Car Development");
                        Console.WriteLine("\nTo go back to home, press 0");
                        Console.WriteLine("\nHere you can improve your car");

                        Console.WriteLine("");
                        input = Console.ReadLine();
                        if (input == "0")
                        {
                            continue;
                        }
                        else
                        {
                            goto case 3;
                        };

                    case 4:
                        Console.Clear();
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
                            continue;
                        }
                        else
                        {

                            goto case 4;
                        };

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Team Overview");
                        Console.WriteLine("\nTo go back to home, press 0");
                        Console.WriteLine("\nDisplay TeamOverview Here!");
                        input = Console.ReadLine();
                        if (input == "0")
                        {
                            continue;
                        }
                        else
                        {
                            goto case 5;
                        };

                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("Standings");
                            Console.WriteLine("\nTo go back to home, press 0");
                            Console.WriteLine("\n\n" + CYear + "  " + OWT1 + " Standings after " + OWT1R0S + " races");
                            Console.WriteLine(@"
Driver      Team    NAT     POINTS      BEHIND LEADER

1.  P Holder
2.  P Holder
3.  P Holder
4.  P Holder
5.  P Holder
6.  P Holder
7.  P Holder
8.  P Holder
9.  P Holder
10. P Holder
11. P Holder
12. P Holder
13. P Holder
14. P Holder
15. P Holder
16. P Holder
17. P Holder
18. P Holder
19. P Holder
20. P Holder
21. P Holder
22. P Holder
23. P Holder
24. P Holder");
                        }
                        input = Console.ReadLine();
                        if (input == "0")
                        {
                            continue;
                        }
                        else { Console.Clear(); goto case 7; };



                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine("Calendar Menu");
                            Console.WriteLine("\nTo go back to home, press 0");
                            Console.WriteLine("\n\n" + CYear + @" " + OWT1 + " Calendar :");
                            Console.WriteLine(@"

1.      Australia    - Albert Park
2.      Maylasia     - Sepang
3.      Brazil       - José Carlos Pace
4.      San Marino   - Enzo e Imola
5.      Spain        - Catalunya
6.      Monaco       - Monaco
7.      Canada       - Montréal
8.      Austria      - A1 Ring
9.      France      - Magny - Cours
10.	    UK          - Silverstone
11.	    Germany     - Hockenheim
12.	    Hungary     - Hungaroring
13.	    Belgium     - Spa
14.	    Germany     - Nürburgring
15.	    Italy       - Monza
16.	    USA         - Indianapolis (GP)
17.	    Japan       - Suzuka");
                        }
                        input = Console.ReadLine();
                        if (input == "0")
                        {
                            continue;
                        }
                        else { goto case 7; };

                    case 8:
                        Console.Clear();
                        Console.WriteLine("Scouting");
                        Console.WriteLine("\nTo go back to home, press 0");
                        input = Console.ReadLine();
                        if (input == "0")
                        {
                            continue;

                        }
                        else { goto case 8; };
                    case 9:
                        Console.Clear();
                        Console.WriteLine("HQ");
                        Console.WriteLine("\nTo go back to home, press 0");
                        input = Console.ReadLine();
                        if (input == "0")
                        {
                            continue;
                        }
                        else { goto case 9; };
                    case 10:
                        Console.Clear();
                        Console.WriteLine("Are you ready to travel to " + Albertpark);
                        Console.WriteLine("\nYes or No?");
                        input = input.ToUpper();
                        input = Console.ReadLine();
                        if (input == "Yes")
                        {
                            PracticeOWT1();
                            break;
                        }
                        
                        if (input == "No")
                        {
                            continue;
                            
                        }
                        else { goto case 10; };
                    default:

                        break;
                }
            }
        }


        static void PracticeOWT1()
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
                                                        
                                                        
                    _             _ _                   
     /\            | |           | (_)                  
    /  \  _   _ ___| |_ _ __ __ _| |_  __ _             
   / /\ \| | | / __| __| '__/ _` | | |/ _` |            
  / ____ \ |_| \__ \ |_| | | (_| | | | (_| |            
 /_/    \_\__,_|___/\__|_|  \__,_|_|_|\__,_|            
                                                        
                                                        ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Friday 13th, 2020");
            Console.WriteLine("\nWeather Report :\n");
            Random rd = new Random();
            randomIndex = rd.Next(0, WeatherType.Length);
            Console.WriteLine(@"Current Track conditions : " + WeatherType[randomIndex]);
            {
                for (int scenario = 1; scenario <= 1; scenario++)
                {
                    string input = "";

                    switch (scenario)
                    {
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:

                            break;

                        case 4:

                            break;
                        case 5:

                            break;
                        case 6:

                            break;
                        case 7:

                            break;
                        case 8:

                            break;
                        case 9:

                            break;
                        case 10:

                            break;
                        default:

                            break;
                    }

                }
            }
        }



        static void GameTitle()
        {
            Console.WindowHeight = Console.LargestWindowHeight - 20;
            Console.WindowWidth = Console.LargestWindowWidth - 20;

            Console.Title = "GameTitle";
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
            Console.WriteLine("\nPress enter to exit game.");
        }

        class Item { }
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


