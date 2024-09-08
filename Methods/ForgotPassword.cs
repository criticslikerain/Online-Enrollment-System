
using System.Speech.Synthesis;
namespace Online_Enrollment_System{


  class Forgot:Parent{

           private static Data user = new Data();
        public override void Display()
        {

              patakilid = (DisplayNiya - displayNiya);
            SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;
          do{
           Console.Clear();
           Console.ResetColor();
            Console.WriteLine(@"
'B' to go back.            
             
                                                                                                             ▓▓▓▓▓▓    
                                                                                                          ▓▓▓▓▓▓▓▓▓▓▓▓  
                                                                                                          ▓▓▓▓▓▓▓▓▓▓▓▓  
                                                                                                          ▓▓▓▓▓▓▓▓▓▓▓▓  
                                                                                                             ▓▓▓▓▓▓    
                                                                                                       ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓   
                                                                                                      ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓       
                                                                                                      ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓    
            
            ");
           

            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                                                            ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║  Student ID:                                               ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                                                            ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t╚════════════════════════════════════════════════════════════╝");

          run.Speak("Enter Student ID");
          Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 3);
          string username = Console.ReadLine();
          if(username == "b" || username =="B"){

                 OE oe = new OE();   oe.Oras();    
          }

          if(username != user.ID && username != user.returnee_ID) {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(@"
            


                                                                                               INVALID INPUT! 
            ");
            run.Speak("Invalid input!");
            Display();
          }

            Proceed1();
        }while(false);
      }

      public static void Proceed1(){

          patakilid = (DisplayNiya - displayNiya);
            SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;

      run.Speak("Please wait...");
      Thread.Sleep(3000);

        Proceed();
      }

      public static void Proceed(){
             patakilid = (DisplayNiya - displayNiya);
            SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;
            Console.Clear();
            Console.Write($@"



                                                                                Recovery code sent to email successfully! 



                                                                                Tracking No#: {transactionIdentifier} 
                                                                                ------------------------------------


                                                                                    Press any key to continue...
            ");
            /* assuming nga ni send sya og prompt sa email  

             user.email.push(recovery_code);
            
            */

            Console.ReadKey();
            Thread.Sleep(100); run.Speak("Returning..."); OE run1 = new OE();   run1.Oras();     
      }
    }
}