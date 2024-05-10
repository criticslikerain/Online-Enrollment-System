using System.Speech.Synthesis;

namespace Online_Enrollment_System{

  class EducChooseCategory:Parent{

          public override void Display(){
          
             SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;

        do{
        Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write($@"
                    
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓






                                                       ____           _                 _        ____                                          ___     __     ____    _                 _         
                                                      / ___|    ___  | |   ___    ___  | |_     / ___|   ___    _   _   _ __   ___    ___     / _ \   / _|   / ___|  | |_   _   _    __| |  _   _ 
                                                      \___ \   / _ \ | |  / _ \  / __| | __|   | |      / _ \  | | | | | '__| / __|  / _ \   | | | | | |_    \___ \  | __| | | | |  / _` | | | | |
                                                       ___) | |  __/ | | |  __/ | (__  | |_    | |___  | (_) | | |_| | | |    \__ \ |  __/   | |_| | |  _|    ___) | | |_  | |_| | | (_| | | |_| |
                                                      |____/   \___| |_|  \___|  \___|  \__|    \____|  \___/   \__,_| |_|    |___/  \___|    \___/  |_|     |____/   \__|  \__,_|  \__,_|  \__, |
                                                                                                                                                                                             |___/ 
                                                     =============================================================================================================================================



                                                                                 



                                                                                                   ［１］ Bachelor of Science In Elementary Education



                                                                                                   ［２］ Bachelor of Science In Secondary Education



                                                                                                   ［３］ B A C K  







                                                                                                        C H O I C E : 


        ");
        run.Speak("Select your couse program");
           Console.SetCursorPosition(patakilid - 56, Console.CursorTop - 3);
        choice = Console.ReadLine();

        while(!double.TryParse(choice, out input) || input < 1 || input > 3){

          Console.ForegroundColor = ConsoleColor.Magenta; 
          Console.Write(@"


                                                                                                    ╔═════════════════════════╗ 
                                                                                                    ║  I  N  V  A  L  I D !   ║ 
                                                                                                    ╚═════════════════════════╝
          ");
          run.Speak("Invalid Input!");
          Display();
        }


        switch(input){

          case 1: Console.Beep(); BSME bsme = new BSME(); bsme.Display(); break;
          case 2: Console.Beep(); BSCE bsce = new BSCE(); bsce.Display(); break;
          case 3: Console.Beep(); SelectCourse sc = new SelectCourse(); sc.Display(); break;
         }



        }while(false);

        

        base.Display();
      }

    }
}