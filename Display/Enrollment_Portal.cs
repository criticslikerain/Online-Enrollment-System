using System.Speech.Synthesis;

namespace Online_Enrollment_System{




class OE: Parent{



        public void MainDisplay(){

                Console.Clear();
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write(@"
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓         
      ");
      Display();
        }
        public void Display(){
    SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;
      



      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.DarkCyan;

      Console.Write($@"                                                             
                                                                                                         {Online_Enrollment_System.Parent.greet}

                                                                        __________________________________________________________________________________________
                                                                       |                                                                                          | 
                                                                       |                                                                                          |
                                                                       |                                                                                          |
                                                                       |                        █▀▀ █▄░█ █▀█ █▀█ █░░ █░░ █▀▄▀█ █▀▀ █▄░█ ▀█▀                       |
                                                                       |                        ██▄ █░▀█ █▀▄ █▄█ █▄▄ █▄▄ █░▀░█ ██▄ █░▀█ ░█░                       |
                                                                       |                                                                                          |
                                                                       |                                                                                          |
                                                                       |                                 █▀█ █▀█ █▀█ ▀█▀ ▄▀█ █░░                                  |
                                                                       |                                 █▀▀ █▄█ █▀▄ ░█░ █▀█ █▄▄                                  |
                                                                       |                                                                                          |
                                                                       |                                                                                          |
                                                                       |                                                                                          |    
                                                                       |                                                                                          |
                                                                       |         ____________________                                __________________           |
                                                                       |        | 1. E N R O L L     |                              | 2. L O G I N     |          |
                                                                       |        |____________________|                              |__________________|          |
                                                                       |                                                                                          |
                                                                       |                                                                                          |
                                                                       |                                                                                          |
                                                                       |                                                                                          |
                                                                       |                                                                                          |
                                                                       |         ____________________                                __________________           |
                                                                       |        | 3.  F O R G O T    |                              |                  |          |
                                                                       |        |    P A S S W O R D |                              | 4.  E  X  I  T   |          |
                                                                       |        |____________________|                              |__________________|          |
                                                                       |                                                                                          |
                                                                       |                                                                                          |
                                                                       |                                                                                          |
                                                                       |                                                                                          |
                                                                       |                             E N T E R  C H O I C E :                                     |
                                                                       |                                                                                          |
                                                                       |__________________________________________________________________________________________|                                                                                          





                                                                                                Copyright 2024 Group2. All rights reserved.



      ");
      Console.SetCursorPosition(patakilid - 48, Console.CursorTop - 13);
      run.Speak($"{greet2}");
      choice = Console.ReadLine();
      while(!double.TryParse(choice, out input) || input < 1 || input > 4) {

        
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t Invalid Input!");
        run.Speak("Invalid Input!");
        MainDisplay();
        
      }

      switch(input) {


        case 1: Console.Beep(); Enroll enroll = new Enroll(); enroll.Display(); break;  
        case 2: Console.Beep(); Portal portal = new Portal(); portal.Display(); break;
        case 3: Console.Beep(); Forgot forgot = new Forgot(); forgot.Display(); break;
        case 4: Console.Clear(); Console.Beep();

      Console.WriteLine("\n\n");
      Console.Clear();
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write(@"
      
      
                                                                            ████████╗██╗░░██╗░█████╗░███╗░░██╗██╗░░██╗  ██╗░░░██╗░█████╗░██╗░░░██╗██╗
                                                                            ╚══██╔══╝██║░░██║██╔══██╗████╗░██║██║░██╔╝  ╚██╗░██╔╝██╔══██╗██║░░░██║██║
                                                                            ░░░██║░░░███████║███████║██╔██╗██║█████═╝░  ░╚████╔╝░██║░░██║██║░░░██║██║
                                                                            ░░░██║░░░██╔══██║██╔══██║██║╚████║██╔═██╗░  ░░╚██╔╝░░██║░░██║██║░░░██║╚═╝
                                                                            ░░░██║░░░██║░░██║██║░░██║██║░╚███║██║░╚██╗  ░░░██║░░░╚█████╔╝╚██████╔╝██╗
                                                                            ░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝  ░░░╚═╝░░░░╚════╝░░╚═════╝░╚═╝

      
      ");
      run.Speak("Thank you!");
      Console.ResetColor();
      Thread.Sleep(1000);
      Console.Write("\n");
      Console.ForegroundColor = ConsoleColor.Red;
      
Console.Write(@"
                                                                                              █▀▀ █▀█ █▀█ █▀▄   █▄▄ █▄█ █▀▀   ▀ ▀▄
                                                                                              █▄█ █▄█ █▄█ █▄▀   █▄█ ░█░ ██▄   ▄ ▄▀
");
run.Speak("Good bye!");
Thread.Sleep(1000);
Console.Beep();
Console.Clear();
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("\n\n");
Console.Write(@"



                                                                          ████████╗███████╗██████╗░███╗░░░███╗██╗███╗░░██╗░█████╗░████████╗███████╗██████╗░██╗
                                                                          ╚══██╔══╝██╔════╝██╔══██╗████╗░████║██║████╗░██║██╔══██╗╚══██╔══╝██╔════╝██╔══██╗██║
                                                                          ░░░██║░░░█████╗░░██████╔╝██╔████╔██║██║██╔██╗██║███████║░░░██║░░░█████╗░░██║░░██║██║
                                                                          ░░░██║░░░██╔══╝░░██╔══██╗██║╚██╔╝██║██║██║╚████║██╔══██║░░░██║░░░██╔══╝░░██║░░██║╚═╝
                                                                          ░░░██║░░░███████╗██║░░██║██║░╚═╝░██║██║██║░╚███║██║░░██║░░░██║░░░███████╗██████╔╝██╗
                                                                          ░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░░░╚═╝░░░╚══════╝╚═════╝░╚═╝


");

Environment.Exit(0);

break;
  

      }

  

  }

  


        public override void Loading()
        {   
          Console.Clear();
    Thread.Sleep(1000);
    Console.Beep();


                                    Console.Write(@"






                                                                                                P L E A S E  W A I T  ▄             
                                    
                                    
                                    
                                    ");
  Thread.Sleep(1000);
  Loading2();
            
            base.Loading();
        }

        public override void Loading2()
        {
          Console.Clear();


                                            Console.Write(@"






                                                                                                P L E A S E  W A I T  ▄  ▄           
                                                                                            
                                    
                                    
                                    ");
  Thread.Sleep(1000);
  Loading3();

            base.Loading2();
        }



        public override void Loading3()
        {
          Console.Clear();


                                         Console.Write(@"






                                                                                                P L E A S E  W A I T  ▄  ▄  ▄           
                                    
                                    
                                    
                                    ");
  Thread.Sleep(1000);
            base.Loading3();
        }
    }
  
}