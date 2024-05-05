using System.Runtime.InteropServices;
using System.Speech.Synthesis;


namespace Online_Enrollment_System{

  class BSIT:Parent{


        public override void Display()
        {
               SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;


            do{
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(@"
                                                _____ _                                                    __     __                               _    _____                          _            
                                               / ____| |                                                   \ \   / /                              | |  / ____|                        | |           
                                              | |    | |__   ___   ___  ___  ___   _   _  ___  _   _ _ __   \ \_/ /__  __ _ _ __    __ _ _ __   __| | | (___   ___ _ __ ___   ___  ___| |_ ___ _ __ 
                                              | |    | '_ \ / _ \ / _ \/ __|/ _ \ | | | |/ _ \| | | | '__|   \   / _ \/ _` | '__|  / _` | '_ \ / _` |  \___ \ / _ \ '_ ` _ \ / _ \/ __| __/ _ \ '__|
                                              | |____| | | | (_) | (_) \__ \  __/ | |_| | (_) | |_| | |       | |  __/ (_| | |    | (_| | | | | (_| |  ____) |  __/ | | | | |  __/\__ \ ||  __/ |   
                                               \_____|_| |_|\___/ \___/|___/\___|  \__, |\___/ \__,_|_|       |_|\___|\__,_|_|     \__,_|_| |_|\__,_| |_____/ \___|_| |_| |_|\___||___/\__\___|_|   
                                                                                   __/ |                                                                                                           
                                                                                  |___/                                                                                                                                                                                         
                                              =======================================================================================================================================================
            
            

                                                                                                  [1] F I R S T  Y E A R 


                                                                                                  [2] S E C O N D  Y E A R 


                                                                                                  [3] T H I R D  Y E A R


                                                                                                  [4] F O U R T H  Y E A R 



                                                      TYPE: B to Back - 


                                                                                                  C H O I C E :  
            ");
            base.Display();

            choice = Console.ReadLine();


            while((!double.TryParse(choice, out input) || input < 1 || input > 4) && !(choice == "B" || choice == "b")){

              Console.ForegroundColor = ConsoleColor.Red;
               Console.Write(@"
                                                                                             ╔═════════════════════════╗ 
                                                                                             ║  I  N  V  A  L  I D !   ║ 
                                                                                             ╚═════════════════════════╝
               ");     
                run.Speak("Invalid input!");
                Display();
            }

            if(choice == "B" || choice == "b"){

                     Console.Beep(); 
                SelectCourse sc = new SelectCourse(); sc.Display(); 
            }

            


            
        }while(false);

        }




        public static void FirstYear(){


        }

          public static void FirstYear_SecondSem(){


        }



          public static void SecondYear(){


        }



           public static void SecondYear_SecondSem(){


        }





          public static void ThirdYear(){


        }

          public static void ThirdYear_SecondSem(){


        }

          public static void FourthYear(){
          
        }


        public static void FourthYear_SecondSem() {


        }
    }
  
}