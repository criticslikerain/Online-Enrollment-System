using System.Speech.Synthesis;

namespace Online_Enrollment_System{



  class SelectCourse:Parent{


   
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






                                                       _____      _           _    __     __                _____           __                       _    _____                          
                                                      / ____|    | |         | |   \ \   / /               |  __ \         / _|                     | |  / ____|                         
                                                     | (___   ___| | ___  ___| |_   \ \_/ /__  _   _ _ __  | |__) | __ ___| |_ ___ _ __ _ __ ___  __| | | |     ___  _   _ _ __ ___  ___ 
                                                      \___ \ / _ \ |/ _ \/ __| __|   \   / _ \| | | | '__| |  ___/ '__/ _ \  _/ _ \ '__| '__/ _ \/ _` | | |    / _ \| | | | '__/ __|/ _ \
                                                      ____) |  __/ |  __/ (__| |_     | | (_) | |_| | |    | |   | | |  __/ ||  __/ |  | | |  __/ (_| | | |___| (_) | |_| | |  \__ \  __/
                                                     |_____/ \___|_|\___|\___|\__|    |_|\___/ \__,_|_|    |_|   |_|  \___|_| \___|_|  |_|  \___|\__,_|  \_____\___/ \__,_|_|  |___/\___|

                                                     =====================================================================================================================================



                                                                                 



                                                                                                   ［１］ Ｉｎｆｏｒｍａｔｉｏｎ Ｔｅｃｈｎｏｌｏｇｙ (BSIT)



                                                                                                   ［２］ Ａｒｔｓ Ａｎｄ Ｓｃｉｅｎｃｅ 



                                                                                                   ［３］ Ｅｄｕｃａｔｉｏｎ  



                                                                                                   ［４］ Ｅｎｇｉｎｅｅｒｉｎｇ




                                                       ［０］ Ｖｉｅｗ Ｃｏｕｒｓｅ's  Ｄｅｓｃｒｉｐｔｉｏｎ                                                     ［５］ Ｄｉｓｒｅｇａｒｄ Ｐｒｏｃｅｓｓ 




                                                                                                        C H O I C E : 


        ");
            run.Speak("Select your preferred Course");
           Console.SetCursorPosition(patakilid - 56, Console.CursorTop - 3);
        choice = Console.ReadLine();

        while(!double.TryParse(choice, out input) || input < 0 || input > 5){

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

          case 0: Console.Beep(); CourseDescription cd = new CourseDescription(); cd.Display(); break;
          case 1: Console.Beep(); BSIT it = new BSIT(); it.Display(); break;
          case 2: Console.Beep(); ArtsAndScience ac = new ArtsAndScience(); ac.Display(); break;
          case 3: Console.Beep(); EducChooseCategory ed = new EducChooseCategory(); ed.Display(); break; 
          case 4: Console.Beep(); EngChooseStudy eng = new EngChooseStudy(); eng.Display(); break;
          case 5: Console.Beep(); run.Speak("Disregarding Process..."); OE oe = new OE(); oe.MainDisplay(); break;
         }



        }while(false);

        

        base.Display();
      }

        




    }

     class NewStudentSelectCourse:Parent{


   
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






                                                       _____      _           _    __     __                _____           __                       _    _____                          
                                                      / ____|    | |         | |   \ \   / /               |  __ \         / _|                     | |  / ____|                         
                                                     | (___   ___| | ___  ___| |_   \ \_/ /__  _   _ _ __  | |__) | __ ___| |_ ___ _ __ _ __ ___  __| | | |     ___  _   _ _ __ ___  ___ 
                                                      \___ \ / _ \ |/ _ \/ __| __|   \   / _ \| | | | '__| |  ___/ '__/ _ \  _/ _ \ '__| '__/ _ \/ _` | | |    / _ \| | | | '__/ __|/ _ \
                                                      ____) |  __/ |  __/ (__| |_     | | (_) | |_| | |    | |   | | |  __/ ||  __/ |  | | |  __/ (_| | | |___| (_) | |_| | |  \__ \  __/
                                                     |_____/ \___|_|\___|\___|\__|    |_|\___/ \__,_|_|    |_|   |_|  \___|_| \___|_|  |_|  \___|\__,_|  \_____\___/ \__,_|_|  |___/\___|

                                                     =====================================================================================================================================



                                                                                 



                                                                                                   ［１］ Ｉｎｆｏｒｍａｔｉｏｎ Ｔｅｃｈｎｏｌｏｇｙ (BSIT)



                                                                                                   ［２］ Ａｒｔｓ Ａｎｄ Ｓｃｉｅｎｃｅ 



                                                                                                   ［３］ Ｅｄｕｃａｔｉｏｎ  



                                                                                                   ［４］ Ｅｎｇｉｎｅｅｒｉｎｇ




                                                       ［０］ Ｖｉｅｗ Ｃｏｕｒｓｅ's  Ｄｅｓｃｒｉｐｔｉｏｎ                                                     ［５］ Ｄｉｓｒｅｇａｒｄ Ｐｒｏｃｅｓｓ 




                                                                                                        C H O I C E : 


        ");
            run.Speak("Select your preferred Course");
           Console.SetCursorPosition(patakilid - 56, Console.CursorTop - 3);
        choice = Console.ReadLine();

        while(!double.TryParse(choice, out input) || input < 0 || input > 5){

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

          case 0: Console.Beep(); CourseDescription cd = new CourseDescription(); cd.Display(); break;
          case 1: Console.Beep(); BSIT.FirstYear.EnlistSubjects(); break;
          case 2: Console.Beep(); ArtsAndScience.FirstYear.EnlistSubjects(); break;
          case 3: Console.Beep(); NewStudentEducChooseCategory ed = new NewStudentEducChooseCategory(); ed.Display(); break; 
          case 4: Console.Beep(); NewStudentEngChooseStudy eng = new NewStudentEngChooseStudy(); eng.Display(); break;
          case 5: Console.Beep(); run.Speak("Disregarding Process..."); OE oe = new OE(); oe.MainDisplay(); break;
         }



        }while(false);

        

        base.Display();
      }

        




    }
}