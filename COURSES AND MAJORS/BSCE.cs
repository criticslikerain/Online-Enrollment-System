using System.Runtime.InteropServices;
using System.Speech.Synthesis;


namespace Online_Enrollment_System{

  class BSCE:Parent{

          private static Data user = new Data();
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
            

                                                                                              C H O O S E  Y O U R  Y E A R  


                                                                                                  [1] F I R S T  Y E A R 


                                                                                                  [2] S E C O N D  Y E A R 


                                                                                                  [3] T H I R D  Y E A R


                                                                                                  [4] F O U R T H  Y E A R
                                                                                                  
                                                                                                   



                                                      TYPE: B to Back - 


                                                                                                  C H O I C E :  
            ");
           run.Speak("");
            Console.SetCursorPosition(patakilid - 61, Console.CursorTop - 1);
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

            switch(input){

              case 1: Console.Beep(); Sem(); break;
              case 2: Console.Beep(); Sem2(); break;
              case 3: Console.Beep(); Sem3(); break;
              case 4: Console.Beep(); Sem4(); break;
            }

            


            
        }while(false);

           base.Display();
        } 



        public class FirstYear() {
              static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "ES111", "UTS", "PURCOM", "CHEM101", "PE1", "NSTP1", "MATH111","MATH112","CEE111"
};



            public static void EnlistSubjects()   {
        string input;
        do
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
            
            

                                               _____________________________________________________________________________________________________________________
                                              |         S U B J E C T  C O D E                        D E S C R I P T I O N                     U N I T S           |
                                              -----------------------------------------------------------------------------------------------------------------------
            

                                                                                          F I R S T  Y E A R  /  F I R S T  S E M E S T E R 


                                                              [] ES111                             Engineering Drawing & Plans                       1
                                                              [] UTS                               Understanding the Self                            3
                                                              [] PURCOM                            Purposive Communication                           3
                                                              [] CHEM101                           Chemistry For Engineers                           4
                                                              [] PE1                               Physical Education 1                              2
                                                              [] NSTP1                             National Service Training Prog. 1                 3
                                                              [] MATH111                           Calculus 1                                        3
                                                              [] MATH112                           Mathemathics for Engineers                        3
                                                              [] CEE111                            Civil Engineering Orientation                     2
                                                        
                                                                                                                                        Total Units: 24
            
            
            
            ");
            Console.ResetColor();
            Console.Write(@"
            
                                                              Available Commands:

                                                              - Type the subject code to enroll (e.g., UTS).
                                                              - Type 'del' to delete a subject (e.g., del UTS).
                                                              - Type 'x' to finish enrollment and display enrolled subjects.
                                                              - Type 'b' to go back.

            ");
            
            subjectcodes:
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
                                                              Enter Prompt/Subject Code: 
            ");
            
           Console.SetCursorPosition(patakilid - 86, Console.CursorTop - 2);
            input = Console.ReadLine();

           while(input == "del"){

            TigDelete();
            goto subjectcodes;
     
          }

          while(input == "b"){

           Enroll enroll = new Enroll(); enroll.Display(); 
          }


          
              while(input == "x" ||  input == "X"){
                  DisplaySubjects();
                  break;
          }
         
              if (!subjectcodes.Contains(input)) {
        Console.ForegroundColor= ConsoleColor.Magenta;
        Console.WriteLine(@$"
                                                              Subject '{input}' is not included or available.
        ");       
            Console.ResetColor();
            goto subjectcodes;
           }

             if(na_add.Contains(input)){
                  Console.ForegroundColor = ConsoleColor.Magenta;
                 Console.WriteLine(@$"
                                                              Subject '{input}' is already enlisted!
                                                              " );    
                    Console.ResetColor();
                    goto subjectcodes;
                
          }
            if(subjectcodes.Contains(input)){
                Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine(@$"
                 
                                                              Successfully Added {input} !
                 ");
                 na_add.Add(input);
                 Console.ResetColor();
                 goto subjectcodes;
          } 
         
            





         
        } while (false);
    }

  

      public static void DisplaySubjects() {
                SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;

              do{
                   Console.Clear();
                   Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          Console.Write(@"


                                                               - T H I S  S U B J E C T  E N L I S T M E N T  I S  I R R E V O C A B L E -
                                                                                  D O  Y O U  W A N T  T O  C O N T I N U E ? 

                                                                                                  [1] Y E S 

                                                                                                  [2] N O


                                                                                            O T H E R  O P T I O N
                                                                                          -------------------------

                                                                                              [3] R E - E D I T 



                                                                                 C H O I C E : 



          
          ");
          Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
          choice = Console.ReadLine();

          while(!double.TryParse(choice,out input) || input < 1 || input > 3){

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(@"
                                                                                               I N V A L I D !       
            ");
            run.Speak("Invalid input!");
           

          }


          switch(input){

            case 1: Console.Beep(); Pay(); break; 
            case 2: Console.Beep(); Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); break;
            case 3: Console.Beep(); EnlistSubjects(); break;
          }


        }while(false);
             
      }


         public static void Pay(){
                        SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;
              do{
              Console.Clear();
              Console.ResetColor(); 
              Console.Write(@"  
                                                                                S U B J E C T S  E N L I S T E D :
              ");
                foreach(string input in na_add) {
              Console.Write($@"
                                                                                         
                                                                                           {input}
                ");
             }

             Console.Write(@"
             

                                                                    E N R O L L M E N T  F E E   

                                                                    - P 500.00 
                                                                    ------------

                                                                        Choose your payment: 
                                                                        [1]. GCASH
                                                                        [2]. Over The Counter

                                                                                  -->: 
             ");
              Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
             choice = Console.ReadLine();

             while(!double.TryParse(choice,out input) || input < 1 || input > 2) {

             Console.ForegroundColor = ConsoleColor.Magenta;
             Console.Write(@"                                    

                                                                           Invalid Input!
             
             ");
            run.Speak("invalid input!");
            Pay();
             }

             if(input == 1){
              payment: 
              Console.ResetColor();
              Console.Write(@"
                                                                        Enter payment: 
              ");
               Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
              string gcash = Console.ReadLine(); 
              double pay;
              while(!double.TryParse(gcash , out pay)){

                run.Speak("Invalid input");
                goto payment;
              }
              if(pay != 500 || pay != 500.00) {
                      Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(@"

                                                                     Pay only P500.00
                ");
                run.Speak("Pay only five hundred!");
                goto payment;
              }
              receipt: 
              Console.Write(@"
              
                                                                      Do you want a receipt?
              
                                                                            [1] Y E S
                                                                            [2] N O 


                                                                              -->: 
              ");
              Console.SetCursorPosition(patakilid - 93, Console.CursorTop - 1);
              string receipt = Console.ReadLine();
              int pili;

              while(!int.TryParse(receipt,out pili) || pili < 1 || pili > 2){

                  run.Speak("invalid input");
                  goto receipt;
              }
              
              Console.Write($@"
                                                                                        ------------------------------------
                                                                                                TRANSACTION RECEIPT

                                                                                        TRANSACTION NO#: {transactionIdentifier}
                                                          
                                                                                        DATE: {DateTime.Now.ToString("yyyy-MM-dd | HH:mm:ss")} 

                                                                                        PAYED AMOUNT: P500.00

                                                                                        ------------------------------------
              ");
              Thread.Sleep(3000);
              Console.Write(@"


                
                                                                 ▀█▀ █░█ ▄▀█ █▄░█ █▄▀ █▀   █▀▀ █▀█ █▀█   █▀▀ █▄░█ █▀█ █▀█ █░░ █░░ █ █▄░█ █▀▀   █
                                                                 ░█░ █▀█ █▀█ █░▀█ █░█ ▄█   █▀░ █▄█ █▀▄   ██▄ █░▀█ █▀▄ █▄█ █▄▄ █▄▄ █ █░▀█ █▄█   ▄



                                                                                          Press any key to contine...
              ");
              run.Speak("Thank you for enrolling!");
                  Console.SetCursorPosition(patakilid - 58, Console.CursorTop - 1);
                  Console.ReadKey();
                  Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display();   
             }

             if(input == 2){
              Console.Write(@"
                                                        Your Enrollment Will be on hold before you make a transaction. Thank you.                             
                ");
              run.Speak("Your Enrollment Will be on hold before you make a transaction. Thank you");
               Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
              Console.Write(@"

                                                                          




                                                                          
                                                                           Press any key to continue... 
              ");
              Console.ReadKey();
              Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); 

             }

              }while(false);
          }

         public static void TigDelete(){
        Console.ForegroundColor = ConsoleColor.DarkGray;
         Console.WriteLine(@"

                                                              Enter subject code what to delete: 
         
         ");
                Console.SetCursorPosition(patakilid - 79, Console.CursorTop - 3);
         string input = Console.ReadLine();

           if(na_add.Contains(input)){
            na_add.Remove(input);
            Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine(@$"
                                                              Successfully Deleted {input} !");
            Console.ResetColor();
             return;
          }


        if(!na_add.Contains(input)){
                        Console.ForegroundColor=  ConsoleColor.Magenta;
                        Console.WriteLine(@$"
                                                              Can't Delete Subject '{input}' because it is not available in the subjects you've enlisted");

                        Console.ResetColor();
                  return;
                    } 
        

    }

    }

 

          public class FirstYear_SecondSem(){
          
             static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "PE2", "MATH123", "PHY101", "ES123", "RIZAL","ES122","ARTAPP","NSTP2","HIST"
};



            public static void EnlistSubjects()   {
        string input;
        do
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
            
            

                                               _____________________________________________________________________________________________________________________
                                              |         S U B J E C T  C O D E                        D E S C R I P T I O N                     U N I T S           |
                                              -----------------------------------------------------------------------------------------------------------------------
            

                                                                                          F I R S T  Y E A R  /  S E C O N D  S E M E S T E R 


                                                              [] PE2                              Physical Education 2                              2
                                                              [] MATH123                          Calculus 2                                        3
                                                              [] PHY101                           Physics for Enginners                             3
                                                              [] ARTAPP                           Art Appreciation                                  3
                                                              [] ES123                            Basic Occupational,Safety & Health                3
                                                              [] ES122                            Computer Aided Design                             3
                                                              [] NSTP2                            National Service Training Prog  . 2               3
                                                              [] RIZAL                            Rizal's Life & Works                              3
                                                              [] HIST                             Readings in Philippines History                   3
                                                            
                                                                                                                                        Total Units: 25
            
            
            
            ");
            Console.ResetColor();
            Console.Write(@"
            
                                                              Available Commands:

                                                              - Type the subject code to enroll (e.g., UTS).
                                                              - Type 'del' to delete a subject (e.g., del UTS).
                                                              - Type 'x' to finish enrollment and display enrolled subjects.
                                                              - Type 'b' to go back.

            ");
            
            subjectcodes:
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
                                                              Enter Prompt/Subject Code: 
            ");
            
           Console.SetCursorPosition(patakilid - 86, Console.CursorTop - 2);
            input = Console.ReadLine();

           while(input == "del"){

            TigDelete();
            goto subjectcodes;
     
          }

          while(input == "b"){

             Enroll enroll = new Enroll(); enroll.Display(); 
          }


          
              while(input == "x" ||  input == "X"){
                  DisplaySubjects();
                  break;
          }
         
              if (!subjectcodes.Contains(input)) {
        Console.ForegroundColor= ConsoleColor.Magenta;
        Console.WriteLine(@$"
                                                              Subject '{input}' is not included or available.
        ");       
            Console.ResetColor();
            goto subjectcodes;
           }

             if(na_add.Contains(input)){
                  Console.ForegroundColor = ConsoleColor.Magenta;
                 Console.WriteLine(@$"
                                                              Subject '{input}' is already enlisted!
                                                              " );    
                    Console.ResetColor();
                    goto subjectcodes;
                
          }
            if(subjectcodes.Contains(input)){
                Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine(@$"
                 
                                                              Successfully Added {input} !
                 ");
                 na_add.Add(input);
                 Console.ResetColor();
                 goto subjectcodes;
          } 
         
            





         
        } while (false);
    }

  

     public static void DisplaySubjects() {
                SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;

              do{
                   Console.Clear();
                   Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          Console.Write(@"


                                                               - T H I S  S U B J E C T  E N L I S T M E N T  I S  I R R E V O C A B L E -
                                                                                  D O  Y O U  W A N T  T O  C O N T I N U E ? 

                                                                                                  [1] Y E S 

                                                                                                  [2] N O


                                                                                            O T H E R  O P T I O N
                                                                                          -------------------------

                                                                                              [3] R E - E D I T 



                                                                                 C H O I C E : 



          
          ");
          Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
          choice = Console.ReadLine();

          while(!double.TryParse(choice,out input) || input < 1 || input > 3){

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(@"
                                                                                               I N V A L I D !       
            ");
            run.Speak("Invalid input!");
           

          }


          switch(input){

            case 1: Console.Beep(); Pay(); break; 
            case 2: Console.Beep(); Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); break;
            case 3: Console.Beep(); EnlistSubjects(); break;
          }


        }while(false);
             
      }


         public static void Pay(){
                        SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;
              do{
              Console.Clear();
              Console.ResetColor(); 
              Console.Write(@"  
                                                                                S U B J E C T S  E N L I S T E D :
              ");
                foreach(string input in na_add) {
              Console.Write($@"
                                                                                         
                                                                                           {input}
                ");
             }

             Console.Write(@"
             

                                                                    E N R O L L M E N T  F E E   

                                                                    - P 500.00 
                                                                    ------------

                                                                        Choose your payment: 
                                                                        [1]. GCASH
                                                                        [2]. Over The Counter

                                                                                  -->: 
             ");
              Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
             choice = Console.ReadLine();

             while(!double.TryParse(choice,out input) || input < 1 || input > 2) {

             Console.ForegroundColor = ConsoleColor.Magenta;
             Console.Write(@"                                    

                                                                           Invalid Input!
             
             ");
            run.Speak("invalid input!");
            Pay();
             }

             if(input == 1){
              payment: 
              Console.ResetColor();
              Console.Write(@"
                                                                        Enter payment: 
              ");
               Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
              string gcash = Console.ReadLine(); 
              double pay;
              while(!double.TryParse(gcash , out pay)){

                run.Speak("Invalid input");
                goto payment;
              }
              if(pay != 500 || pay != 500.00) {
                      Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(@"

                                                                     Pay only P500.00
                ");
                run.Speak("Pay only five hundred!");
                goto payment;
              }
              receipt: 
              Console.Write(@"
              
                                                                      Do you want a receipt?
              
                                                                            [1] Y E S
                                                                            [2] N O 


                                                                              -->: 
              ");
              Console.SetCursorPosition(patakilid - 93, Console.CursorTop - 1);
              string receipt = Console.ReadLine();
              int pili;

              while(!int.TryParse(receipt,out pili) || pili < 1 || pili > 2){

                  run.Speak("invalid input");
                  goto receipt;
              }
              
              Console.Write($@"
                                                                                        ------------------------------------
                                                                                                TRANSACTION RECEIPT

                                                                                        TRANSACTION NO#: {transactionIdentifier}
                                                          
                                                                                        DATE: {DateTime.Now.ToString("yyyy-MM-dd | HH:mm:ss")} 

                                                                                        PAYED AMOUNT: P500.00

                                                                                        ------------------------------------
              ");
              Thread.Sleep(3000);
              Console.Write(@"


                
                                                                 ▀█▀ █░█ ▄▀█ █▄░█ █▄▀ █▀   █▀▀ █▀█ █▀█   █▀▀ █▄░█ █▀█ █▀█ █░░ █░░ █ █▄░█ █▀▀   █
                                                                 ░█░ █▀█ █▀█ █░▀█ █░█ ▄█   █▀░ █▄█ █▀▄   ██▄ █░▀█ █▀▄ █▄█ █▄▄ █▄▄ █ █░▀█ █▄█   ▄



                                                                                          Press any key to contine...
              ");
              run.Speak("Thank you for enrolling!");
                  Console.SetCursorPosition(patakilid - 58, Console.CursorTop - 1);
                  Console.ReadKey();
                  Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display();   
             }

             if(input == 2){
              Console.Write(@"
                                                        Your Enrollment Will be on hold before you make a transaction. Thank you.                             
                ");
              run.Speak("Your Enrollment Will be on hold before you make a transaction. Thank you");
               Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
              Console.Write(@"

                                                                          




                                                                          
                                                                           Press any key to continue... 
              ");
              Console.ReadKey();
              Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); 

             }

              }while(false);
          }

         public static void TigDelete(){
        Console.ForegroundColor = ConsoleColor.DarkGray;
         Console.WriteLine(@"

                                                              Enter subject code what to delete: 
         
         ");
                Console.SetCursorPosition(patakilid - 79, Console.CursorTop - 3);
         string input = Console.ReadLine();

           if(na_add.Contains(input)){
            na_add.Remove(input);
            Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine(@$"
                                                              Successfully Deleted {input} !");
            Console.ResetColor();
             return;
          }


        if(!na_add.Contains(input)){
                        Console.ForegroundColor=  ConsoleColor.Magenta;
                        Console.WriteLine(@$"
                                                              Can't Delete Subject '{input}' because it is not available in the subjects you've enlisted");

                        Console.ResetColor();
                  return;
                    } 
        

    }
           
        }


//=============================================================================================//
          public class SecondYear(){


                 static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "MATH214", "CW", "ARTHUM", "SOCPHIL", "CE211","CE212","PE3", "ES211","ES212"
};



            public static void EnlistSubjects()   {
        string input;
        do
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
            
            

                                               _____________________________________________________________________________________________________________________
                                              |         S U B J E C T  C O D E                        D E S C R I P T I O N                     U N I T S           |
                                              -----------------------------------------------------------------------------------------------------------------------
            

                                                                                          S E C O N D  Y E A R  /  F I R S T  S E M E S T E R 


                                                              [] MATH214                           Differential Equation                             3
                                                              [] CW                                The Contemporary World                            3
                                                              [] ARTHUM                            Arts & Humanities                                 3
                                                              [] SOCPHIL                           Social Sciences & Philosophy                      3
                                                              [] CE211                             Fundamentals of Surveying                         4
                                                              [] PE3                               Physical Education 3                              2
                                                              [] CE212                             Geology for Civil Engineers                       2
                                                              [] ES211                             Statics  of Rigid Bodies                          3
                                                              [] ES212                             Computer Fund & Programming 1                     1
                                                      
                                                                                                                                        Total Units: 24
            
            
            
            ");
            Console.ResetColor();
            Console.Write(@"
            
                                                              Available Commands:

                                                              - Type the subject code to enroll (e.g., UTS).
                                                              - Type 'del' to delete a subject (e.g., del UTS).
                                                              - Type 'x' to finish enrollment and display enrolled subjects.
                                                              - Type 'b' to go back.

            ");
            
            subjectcodes:
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
                                                              Enter Prompt/Subject Code: 
            ");
            
           Console.SetCursorPosition(patakilid - 86, Console.CursorTop - 2);
            input = Console.ReadLine();

           while(input == "del"){

            TigDelete();
            goto subjectcodes;
     
          }

          while(input == "b"){

             Enroll enroll = new Enroll(); enroll.Display(); 
          }


          
              while(input == "x" ||  input == "X"){
                  DisplaySubjects();
                  break;
          }
         
              if (!subjectcodes.Contains(input)) {
        Console.ForegroundColor= ConsoleColor.Magenta;
        Console.WriteLine(@$"
                                                              Subject '{input}' is not included or available.
        ");       
            Console.ResetColor();
            goto subjectcodes;
           }

             if(na_add.Contains(input)){
                  Console.ForegroundColor = ConsoleColor.Magenta;
                 Console.WriteLine(@$"
                                                              Subject '{input}' is already enlisted!
                                                              " );    
                    Console.ResetColor();
                    goto subjectcodes;
                
          }
            if(subjectcodes.Contains(input)){
                Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine(@$"
                 
                                                              Successfully Added {input} !
                 ");
                 na_add.Add(input);
                 Console.ResetColor();
                 goto subjectcodes;
          } 
         
            





         
        } while (false);
    }

  

      public static void DisplaySubjects() {
                SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;

              do{
                   Console.Clear();
                   Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          Console.Write(@"


                                                               - T H I S  S U B J E C T  E N L I S T M E N T  I S  I R R E V O C A B L E -
                                                                                  D O  Y O U  W A N T  T O  C O N T I N U E ? 

                                                                                                  [1] Y E S 

                                                                                                  [2] N O


                                                                                            O T H E R  O P T I O N
                                                                                          -------------------------

                                                                                              [3] R E - E D I T 



                                                                                 C H O I C E : 



          
          ");
          Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
          choice = Console.ReadLine();

          while(!double.TryParse(choice,out input) || input < 1 || input > 3){

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(@"
                                                                                               I N V A L I D !       
            ");
            run.Speak("Invalid input!");
           

          }


          switch(input){

            case 1: Console.Beep(); Pay(); break; 
            case 2: Console.Beep(); Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); break;
            case 3: Console.Beep(); EnlistSubjects(); break;
          }


        }while(false);
             
      }


        public static void Pay(){
                        SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;
              do{
              Console.Clear();
              Console.ResetColor(); 
              Console.Write(@"  
                                                                                S U B J E C T S  E N L I S T E D :
              ");
                foreach(string input in na_add) {
              Console.Write($@"
                                                                                         
                                                                                           {input}
                ");
             }

             Console.Write(@"
             

                                                                    E N R O L L M E N T  F E E   

                                                                    - P 500.00 
                                                                    ------------

                                                                        Choose your payment: 
                                                                        [1]. GCASH
                                                                        [2]. Over The Counter

                                                                                  -->: 
             ");
              Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
             choice = Console.ReadLine();

             while(!double.TryParse(choice,out input) || input < 1 || input > 2) {

             Console.ForegroundColor = ConsoleColor.Magenta;
             Console.Write(@"                                    

                                                                           Invalid Input!
             
             ");
            run.Speak("invalid input!");
            Pay();
             }

             if(input == 1){
              payment: 
              Console.ResetColor();
              Console.Write(@"
                                                                        Enter payment: 
              ");
               Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
              string gcash = Console.ReadLine(); 
              double pay;
              while(!double.TryParse(gcash , out pay)){

                run.Speak("Invalid input");
                goto payment;
              }
              if(pay != 500 || pay != 500.00) {
                      Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(@"

                                                                     Pay only P500.00
                ");
                run.Speak("Pay only five hundred!");
                goto payment;
              }
              receipt: 
              Console.Write(@"
              
                                                                      Do you want a receipt?
              
                                                                            [1] Y E S
                                                                            [2] N O 


                                                                              -->: 
              ");
              Console.SetCursorPosition(patakilid - 93, Console.CursorTop - 1);
              string receipt = Console.ReadLine();
              int pili;

              while(!int.TryParse(receipt,out pili) || pili < 1 || pili > 2){

                  run.Speak("invalid input");
                  goto receipt;
              }
              
              Console.Write($@"
                                                                                        ------------------------------------
                                                                                                TRANSACTION RECEIPT

                                                                                        TRANSACTION NO#: {transactionIdentifier}
                                                          
                                                                                        DATE: {DateTime.Now.ToString("yyyy-MM-dd | HH:mm:ss")} 

                                                                                        PAYED AMOUNT: P500.00

                                                                                        ------------------------------------
              ");
              Thread.Sleep(3000);
              Console.Write(@"


                
                                                                 ▀█▀ █░█ ▄▀█ █▄░█ █▄▀ █▀   █▀▀ █▀█ █▀█   █▀▀ █▄░█ █▀█ █▀█ █░░ █░░ █ █▄░█ █▀▀   █
                                                                 ░█░ █▀█ █▀█ █░▀█ █░█ ▄█   █▀░ █▄█ █▀▄   ██▄ █░▀█ █▀▄ █▄█ █▄▄ █▄▄ █ █░▀█ █▄█   ▄



                                                                                          Press any key to contine...
              ");
              run.Speak("Thank you for enrolling!");
                  Console.SetCursorPosition(patakilid - 58, Console.CursorTop - 1);
                  Console.ReadKey();
                  Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display();   
             }

             if(input == 2){
              Console.Write(@"
                                                        Your Enrollment Will be on hold before you make a transaction. Thank you.                             
                ");
              run.Speak("Your Enrollment Will be on hold before you make a transaction. Thank you");
               Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
              Console.Write(@"

                                                                          




                                                                          
                                                                           Press any key to continue... 
              ");
              Console.ReadKey();
              Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); 

             }

              }while(false);
          }

         public static void TigDelete(){
        Console.ForegroundColor = ConsoleColor.DarkGray;
         Console.WriteLine(@"

                                                              Enter subject code what to delete: 
         
         ");
                Console.SetCursorPosition(patakilid - 79, Console.CursorTop - 3);
         string input = Console.ReadLine();

           if(na_add.Contains(input)){
            na_add.Remove(input);
            Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine(@$"
                                                              Successfully Deleted {input} !");
            Console.ResetColor();
             return;
          }

        if(na_add.Count == 0){
          
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine(@"
                                                              Can't Delete because the enlistment is Empty!
          ");
          Console.ResetColor();
          return;

        }
        if(!na_add.Contains(input)){
                        Console.ForegroundColor=  ConsoleColor.Magenta;
                        Console.WriteLine(@$"
                                                              Can't Delete Subject '{input}' because it is not available in the subjects you've enlisted");

                        Console.ResetColor();
                  return;
                    } 
        

    }

        }


//=============================================================================================//
          public class SecondYear_SecondSem(){
                 static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "MATH225", "MATH226", "UTS", "STS", "MST", "PE4", "ES223", "BES221","ETHICS","ES222"
};



            public static void EnlistSubjects()   {
        string input;
        do
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
            
            

                                               _____________________________________________________________________________________________________________________
                                              |         S U B J E C T  C O D E                        D E S C R I P T I O N                     U N I T S           |
                                              -----------------------------------------------------------------------------------------------------------------------
            

                                                                                          S E C O N D  Y E A R  /  S E C O N D  S E M E S T E R 


                                                              [] MATH225                           Engineering Data Analysis                         3
                                                              [] MATH226                           Advanced Mathematics for Engineering              3
                                                              [] UTS                               Understanding the Self                            3
                                                              [] STS                               Science, Technology and Society                   3
                                                              [] PE4                               Physical Education 4                              2
                                                              [] MST                               Mathemathics Science & Technology                 3
                                                              [] ES223                             Computer Fundamental & Programming 2              3
                                                              [] BES221                            Technopreneurship                                 3
                                                              [] ETHICS                            Ethics                                            3
                                                              [] ES222                             Dynamics of Rigid Bodies                          3
                                                          
                                                                                                                                        Total Units: 26
            
            
            
            ");
            Console.ResetColor();
            Console.Write(@"
            
                                                              Available Commands:

                                                              - Type the subject code to enroll (e.g., UTS).
                                                              - Type 'del' to delete a subject (e.g., del UTS).
                                                              - Type 'x' to finish enrollment and display enrolled subjects.
                                                              - Type 'b' to go back.

            ");
            
            subjectcodes:
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
                                                              Enter Prompt/Subject Code: 
            ");
            
           Console.SetCursorPosition(patakilid - 86, Console.CursorTop - 2);
            input = Console.ReadLine();

           while(input == "del"){

            TigDelete();
            goto subjectcodes;
     
          }

          while(input == "b"){

             Enroll enroll = new Enroll(); enroll.Display(); 
          }


          
              while(input == "x" ||  input == "X"){
                  DisplaySubjects();
                  break;
          }
         
              if (!subjectcodes.Contains(input)) {
        Console.ForegroundColor= ConsoleColor.Magenta;
        Console.WriteLine(@$"
                                                              Subject '{input}' is not included or available.
        ");       
            Console.ResetColor();
            goto subjectcodes;
           }

             if(na_add.Contains(input)){
                  Console.ForegroundColor = ConsoleColor.Magenta;
                 Console.WriteLine(@$"
                                                              Subject '{input}' is already enlisted!
                                                              " );    
                    Console.ResetColor();
                    goto subjectcodes;
                
          }
            if(subjectcodes.Contains(input)){
                Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine(@$"
                 
                                                              Successfully Added {input} !
                 ");
                 na_add.Add(input);
                 Console.ResetColor();
                 goto subjectcodes;
          } 
         
            





         
        } while (false);
    }

  

     public static void DisplaySubjects() {
                SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;

              do{
                   Console.Clear();
                   Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          Console.Write(@"


                                                               - T H I S  S U B J E C T  E N L I S T M E N T  I S  I R R E V O C A B L E -
                                                                                  D O  Y O U  W A N T  T O  C O N T I N U E ? 

                                                                                                  [1] Y E S 

                                                                                                  [2] N O


                                                                                            O T H E R  O P T I O N
                                                                                          -------------------------

                                                                                              [3] R E - E D I T 



                                                                                 C H O I C E : 



          
          ");
          Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
          choice = Console.ReadLine();

          while(!double.TryParse(choice,out input) || input < 1 || input > 3){

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(@"
                                                                                               I N V A L I D !       
            ");
            run.Speak("Invalid input!");
           

          }


          switch(input){

            case 1: Console.Beep(); Pay(); break; 
            case 2: Console.Beep(); Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); break;
            case 3: Console.Beep(); EnlistSubjects(); break;
          }


        }while(false);
             
      }


          public static void Pay(){
                        SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;
              do{
              Console.Clear();
              Console.ResetColor(); 
              Console.Write(@"  
                                                                                S U B J E C T S  E N L I S T E D :
              ");
                foreach(string input in na_add) {
              Console.Write($@"
                                                                                         
                                                                                           {input}
                ");
             }

             Console.Write(@"
             

                                                                    E N R O L L M E N T  F E E   

                                                                    - P 500.00 
                                                                    ------------

                                                                        Choose your payment: 
                                                                        [1]. GCASH
                                                                        [2]. Over The Counter

                                                                                  -->: 
             ");
              Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
             choice = Console.ReadLine();

             while(!double.TryParse(choice,out input) || input < 1 || input > 2) {

             Console.ForegroundColor = ConsoleColor.Magenta;
             Console.Write(@"                                    

                                                                           Invalid Input!
             
             ");
            run.Speak("invalid input!");
            Pay();
             }

             if(input == 1){
              payment: 
              Console.ResetColor();
              Console.Write(@"
                                                                        Enter payment: 
              ");
               Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
              string gcash = Console.ReadLine(); 
              double pay;
              while(!double.TryParse(gcash , out pay)){

                run.Speak("Invalid input");
                goto payment;
              }
              if(pay != 500 || pay != 500.00) {
                      Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(@"

                                                                     Pay only P500.00
                ");
                run.Speak("Pay only five hundred!");
                goto payment;
              }
              receipt: 
              Console.Write(@"
              
                                                                      Do you want a receipt?
              
                                                                            [1] Y E S
                                                                            [2] N O 


                                                                              -->: 
              ");
              Console.SetCursorPosition(patakilid - 93, Console.CursorTop - 1);
              string receipt = Console.ReadLine();
              int pili;

              while(!int.TryParse(receipt,out pili) || pili < 1 || pili > 2){

                  run.Speak("invalid input");
                  goto receipt;
              }
              
              Console.Write($@"
                                                                                        ------------------------------------
                                                                                                TRANSACTION RECEIPT

                                                                                        TRANSACTION NO#: {transactionIdentifier}
                                                          
                                                                                        DATE: {DateTime.Now.ToString("yyyy-MM-dd | HH:mm:ss")} 

                                                                                        PAYED AMOUNT: P500.00

                                                                                        ------------------------------------
              ");
              Thread.Sleep(3000);
              Console.Write(@"


                
                                                                 ▀█▀ █░█ ▄▀█ █▄░█ █▄▀ █▀   █▀▀ █▀█ █▀█   █▀▀ █▄░█ █▀█ █▀█ █░░ █░░ █ █▄░█ █▀▀   █
                                                                 ░█░ █▀█ █▀█ █░▀█ █░█ ▄█   █▀░ █▄█ █▀▄   ██▄ █░▀█ █▀▄ █▄█ █▄▄ █▄▄ █ █░▀█ █▄█   ▄



                                                                                          Press any key to contine...
              ");
              run.Speak("Thank you for enrolling!");
                  Console.SetCursorPosition(patakilid - 58, Console.CursorTop - 1);
                  Console.ReadKey();
                  Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display();   
             }

             if(input == 2){
              Console.Write(@"
                                                        Your Enrollment Will be on hold before you make a transaction. Thank you.                             
                ");
              run.Speak("Your Enrollment Will be on hold before you make a transaction. Thank you");
               Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
              Console.Write(@"

                                                                          




                                                                          
                                                                           Press any key to continue... 
              ");
              Console.ReadKey();
              Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); 

             }

              }while(false);
          }

         public static void TigDelete(){
        Console.ForegroundColor = ConsoleColor.DarkGray;
         Console.WriteLine(@"

                                                              Enter subject code what to delete: 
         
         ");
                Console.SetCursorPosition(patakilid - 79, Console.CursorTop - 3);
         string input = Console.ReadLine();

           if(na_add.Contains(input)){
            na_add.Remove(input);
            Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine(@$"
                                                              Successfully Deleted {input} !");
            Console.ResetColor();
             return;
          }

             if(na_add.Count == 0){
          
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine(@"
                                                              Can't Delete because the Enlistment is Empty!
          ");
          Console.ResetColor();
          return;

        }


        if(!na_add.Contains(input)){
                        Console.ForegroundColor=  ConsoleColor.Magenta;
                        Console.WriteLine(@$"
                                                              Can't Delete Subject '{input}' because it is not available in the subjects you've enlisted");

                        Console.ResetColor();
                  return;
                    } 
        

    }

        }

//=============================================================================================//
    


          public class ThirdYear(){
                 static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "CE321", "CE322", "CE323", "CE324", "CE325", "CE326","CE327"
};



            public static void EnlistSubjects()   {
        string input;
        do
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
            
            

                                               _____________________________________________________________________________________________________________________
                                              |         S U B J E C T  C O D E                        D E S C R I P T I O N                     U N I T S           |
                                              -----------------------------------------------------------------------------------------------------------------------
            

                                                                                          T H I R D  Y E A R  /  F I R S T  S E M E S T E R 


                                                              [] CE321                             Structural Theory                                 4
                                                              [] CE322                             Engineering Utilities 2                           3
                                                              [] CE323                             Research Methods                                  1
                                                              [] CE324                             Technology for Teaching & Learning 1              3
                                                              [] CE325                             Construction Materials and Testing                3
                                                              [] CE326                             Geotechnical Engineering (Soil Mechanics)         4
                                                              [] CE327                             Building System Design                            3

                                                                     
                                                                                                                                        Total Units: 21
            
            
            
            ");
            Console.ResetColor();
            Console.Write(@"
            
                                                              Available Commands:

                                                              - Type the subject code to enroll (e.g., UTS).
                                                              - Type 'del' to delete a subject (e.g., del UTS).
                                                              - Type 'x' to finish enrollment and display enrolled subjects.
                                                              - Type 'b' to go back.

            ");
            
            subjectcodes:
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
                                                              Enter Prompt/Subject Code: 
            ");
            
           Console.SetCursorPosition(patakilid - 86, Console.CursorTop - 2);
            input = Console.ReadLine();

           while(input == "del"){

            TigDelete();
            goto subjectcodes;
     
          }

          while(input == "b"){

            Enroll enroll = new Enroll(); enroll.Display(); 
          }


          
              while(input == "x" ||  input == "X"){
                  DisplaySubjects();
                  break;
          }
         
              if (!subjectcodes.Contains(input)) {
        Console.ForegroundColor= ConsoleColor.Magenta;
        Console.WriteLine(@$"
                                                              Subject '{input}' is not included or available.
        ");       
            Console.ResetColor();
            goto subjectcodes;
           }

             if(na_add.Contains(input)){
                  Console.ForegroundColor = ConsoleColor.Magenta;
                 Console.WriteLine(@$"
                                                              Subject '{input}' is already enlisted!
                                                              " );    
                    Console.ResetColor();
                    goto subjectcodes;
                
          }
            if(subjectcodes.Contains(input)){
                Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine(@$"
                 
                                                              Successfully Added {input} !
                 ");
                 na_add.Add(input);
                 Console.ResetColor();
                 goto subjectcodes;
          } 
         
            





         
        } while (false);
    }

  

      public static void DisplaySubjects() {
                SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;

              do{
                   Console.Clear();
                   Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          Console.Write(@"


                                                               - T H I S  S U B J E C T  E N L I S T M E N T  I S  I R R E V O C A B L E -
                                                                                  D O  Y O U  W A N T  T O  C O N T I N U E ? 

                                                                                                  [1] Y E S 

                                                                                                  [2] N O


                                                                                            O T H E R  O P T I O N
                                                                                          -------------------------

                                                                                              [3] R E - E D I T 



                                                                                 C H O I C E : 



          
          ");
          Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
          choice = Console.ReadLine();

          while(!double.TryParse(choice,out input) || input < 1 || input > 3){

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(@"
                                                                                               I N V A L I D !       
            ");
            run.Speak("Invalid input!");
           

          }


          switch(input){

            case 1: Console.Beep(); Pay(); break; 
            case 2: Console.Beep(); Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); break;
            case 3: Console.Beep(); EnlistSubjects(); break;
          }


        }while(false);
             
      }


         public static void Pay(){
                        SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;
              do{
              Console.Clear();
              Console.ResetColor(); 
              Console.Write(@"  
                                                                                S U B J E C T S  E N L I S T E D :
              ");
                foreach(string input in na_add) {
              Console.Write($@"
                                                                                         
                                                                                           {input}
                ");
             }

             Console.Write(@"
             

                                                                    E N R O L L M E N T  F E E   

                                                                    - P 500.00 
                                                                    ------------

                                                                        Choose your payment: 
                                                                        [1]. GCASH
                                                                        [2]. Over The Counter

                                                                                  -->: 
             ");
              Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
             choice = Console.ReadLine();

             while(!double.TryParse(choice,out input) || input < 1 || input > 2) {

             Console.ForegroundColor = ConsoleColor.Magenta;
             Console.Write(@"                                    

                                                                           Invalid Input!
             
             ");
            run.Speak("invalid input!");
            Pay();
             }

             if(input == 1){
              payment: 
              Console.ResetColor();
              Console.Write(@"
                                                                        Enter payment: 
              ");
               Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
              string gcash = Console.ReadLine(); 
              double pay;
              while(!double.TryParse(gcash , out pay)){

                run.Speak("Invalid input");
                goto payment;
              }
              if(pay != 500 || pay != 500.00) {
                      Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(@"

                                                                     Pay only P500.00
                ");
                run.Speak("Pay only five hundred!");
                goto payment;
              }
              receipt: 
              Console.Write(@"
              
                                                                      Do you want a receipt?
              
                                                                            [1] Y E S
                                                                            [2] N O 


                                                                              -->: 
              ");
              Console.SetCursorPosition(patakilid - 93, Console.CursorTop - 1);
              string receipt = Console.ReadLine();
              int pili;

              while(!int.TryParse(receipt,out pili) || pili < 1 || pili > 2){

                  run.Speak("invalid input");
                  goto receipt;
              }
              
              Console.Write($@"
                                                                                        ------------------------------------
                                                                                                TRANSACTION RECEIPT

                                                                                        TRANSACTION NO#: {transactionIdentifier}
                                                          
                                                                                        DATE: {DateTime.Now.ToString("yyyy-MM-dd | HH:mm:ss")} 

                                                                                        PAYED AMOUNT: P500.00

                                                                                        ------------------------------------
              ");
              Thread.Sleep(3000);
              Console.Write(@"


                
                                                                 ▀█▀ █░█ ▄▀█ █▄░█ █▄▀ █▀   █▀▀ █▀█ █▀█   █▀▀ █▄░█ █▀█ █▀█ █░░ █░░ █ █▄░█ █▀▀   █
                                                                 ░█░ █▀█ █▀█ █░▀█ █░█ ▄█   █▀░ █▄█ █▀▄   ██▄ █░▀█ █▀▄ █▄█ █▄▄ █▄▄ █ █░▀█ █▄█   ▄



                                                                                          Press any key to contine...
              ");
              run.Speak("Thank you for enrolling!");
                  Console.SetCursorPosition(patakilid - 58, Console.CursorTop - 1);
                  Console.ReadKey();
                  Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display();   
             }

             if(input == 2){
              Console.Write(@"
                                                        Your Enrollment Will be on hold before you make a transaction. Thank you.                             
                ");
              run.Speak("Your Enrollment Will be on hold before you make a transaction. Thank you");
               Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
              Console.Write(@"

                                                                          




                                                                          
                                                                           Press any key to continue... 
              ");
              Console.ReadKey();
              Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); 

             }

              }while(false);
          }

         public static void TigDelete(){
        Console.ForegroundColor = ConsoleColor.DarkGray;
         Console.WriteLine(@"

                                                              Enter subject code what to delete: 
         
         ");
                Console.SetCursorPosition(patakilid - 79, Console.CursorTop - 3);
         string input = Console.ReadLine();

           if(na_add.Contains(input)){
            na_add.Remove(input);
            Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine(@$"
                                                              Successfully Deleted {input} !");
            Console.ResetColor();
             return;
          }

             if(na_add.Count == 0){
          
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine(@"
                                                              Can't Delete because the Enlistment is Empty!
          ");
          Console.ResetColor();
          return;

        }


        if(!na_add.Contains(input)){
                        Console.ForegroundColor=  ConsoleColor.Magenta;
                        Console.WriteLine(@$"
                                                              Can't Delete Subject '{input}' because it is not available in the subjects you've enlisted");

                        Console.ResetColor();
                  return;
                    } 
        

    }

        }

          public class ThirdYear_SecondSem(){

               static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "CE311", "CE312", "CE313", "ES315", "CE314", "MATH317","ES311","ES213"
};



            public static void EnlistSubjects()   {
        string input;
        do
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
            
            

                                               _____________________________________________________________________________________________________________________
                                              |         S U B J E C T  C O D E                        D E S C R I P T I O N                     U N I T S           |
                                              -----------------------------------------------------------------------------------------------------------------------
            

                                                                                          T H I R D  Y E A R  /  S E C O N D  S E M E S T E R 


                                                              [] CE311                             Highway and Railrod Engineering                   3
                                                              [] CE312                             Engineering Utilities 1                           3
                                                              [] CE313                             Hydrology                                         2
                                                              [] ES315                             Engineering Econimics                             3
                                                              [] CE314                             Hydraulics                                        5
                                                              [] MATH317                           Numerical Solutions to CE Problems                3
                                                              [] ES311                             Mechanics of Deformable Bodies                    4
                                                              [] ES213                             Environmental Science                             3

                                                                                                                                        Total Units: 25
            
            
            
            ");
            Console.ResetColor();
            Console.Write(@"
            
                                                              Available Commands:

                                                              - Type the subject code to enroll (e.g., UTS).
                                                              - Type 'del' to delete a subject (e.g., del UTS).
                                                              - Type 'x' to finish enrollment and display enrolled subjects.
                                                              - Type 'b' to go back.

            ");
            
            subjectcodes:
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
                                                              Enter Prompt/Subject Code: 
            ");
            
           Console.SetCursorPosition(patakilid - 86, Console.CursorTop - 2);
            input = Console.ReadLine();

           while(input == "del"){

            TigDelete();
            goto subjectcodes;
     
          }

          while(input == "b"){

             Enroll enroll = new Enroll(); enroll.Display(); 
          }


          
              while(input == "x" ||  input == "X"){
                  DisplaySubjects();
                  break;
          }
         
              if (!subjectcodes.Contains(input)) {
        Console.ForegroundColor= ConsoleColor.Magenta;
        Console.WriteLine(@$"
                                                              Subject '{input}' is not included or available.
        ");       
            Console.ResetColor();
            goto subjectcodes;
           }

             if(na_add.Contains(input)){
                  Console.ForegroundColor = ConsoleColor.Magenta;
                 Console.WriteLine(@$"
                                                              Subject '{input}' is already enlisted!
                                                              " );    
                    Console.ResetColor();
                    goto subjectcodes;
                
          }
            if(subjectcodes.Contains(input)){
                Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine(@$"
                 
                                                              Successfully Added {input} !
                 ");
                 na_add.Add(input);
                 Console.ResetColor();
                 goto subjectcodes;
          } 
         
            





         
        } while (false);
    }

  

     public static void DisplaySubjects() {
                SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;

              do{
                   Console.Clear();
                   Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          Console.Write(@"


                                                               - T H I S  S U B J E C T  E N L I S T M E N T  I S  I R R E V O C A B L E -
                                                                                  D O  Y O U  W A N T  T O  C O N T I N U E ? 

                                                                                                  [1] Y E S 

                                                                                                  [2] N O


                                                                                            O T H E R  O P T I O N
                                                                                          -------------------------

                                                                                              [3] R E - E D I T 



                                                                                 C H O I C E : 



          
          ");
          Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
          choice = Console.ReadLine();

          while(!double.TryParse(choice,out input) || input < 1 || input > 3){

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(@"
                                                                                               I N V A L I D !       
            ");
            run.Speak("Invalid input!");
           

          }


          switch(input){

            case 1: Console.Beep(); Pay(); break; 
            case 2: Console.Beep(); Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); break;
            case 3: Console.Beep(); EnlistSubjects(); break;
          }


        }while(false);
             
      }


         public static void Pay(){
                        SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;
              do{
              Console.Clear();
              Console.ResetColor(); 
              Console.Write(@"  
                                                                                S U B J E C T S  E N L I S T E D :
              ");
                foreach(string input in na_add) {
              Console.Write($@"
                                                                                         
                                                                                           {input}
                ");
             }

             Console.Write(@"
             

                                                                    E N R O L L M E N T  F E E   

                                                                    - P 500.00 
                                                                    ------------

                                                                        Choose your payment: 
                                                                        [1]. GCASH
                                                                        [2]. Over The Counter

                                                                                  -->: 
             ");
              Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
             choice = Console.ReadLine();

             while(!double.TryParse(choice,out input) || input < 1 || input > 2) {

             Console.ForegroundColor = ConsoleColor.Magenta;
             Console.Write(@"                                    

                                                                           Invalid Input!
             
             ");
            run.Speak("invalid input!");
            Pay();
             }

             if(input == 1){
              payment: 
              Console.ResetColor();
              Console.Write(@"
                                                                        Enter payment: 
              ");
               Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
              string gcash = Console.ReadLine(); 
              double pay;
              while(!double.TryParse(gcash , out pay)){

                run.Speak("Invalid input");
                goto payment;
              }
              if(pay != 500 || pay != 500.00) {
                      Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(@"

                                                                     Pay only P500.00
                ");
                run.Speak("Pay only five hundred!");
                goto payment;
              }
              receipt: 
              Console.Write(@"
              
                                                                      Do you want a receipt?
              
                                                                            [1] Y E S
                                                                            [2] N O 


                                                                              -->: 
              ");
              Console.SetCursorPosition(patakilid - 93, Console.CursorTop - 1);
              string receipt = Console.ReadLine();
              int pili;

              while(!int.TryParse(receipt,out pili) || pili < 1 || pili > 2){

                  run.Speak("invalid input");
                  goto receipt;
              }
              
              Console.Write($@"
                                                                                        ------------------------------------
                                                                                                TRANSACTION RECEIPT

                                                                                        TRANSACTION NO#: {transactionIdentifier}
                                                          
                                                                                        DATE: {DateTime.Now.ToString("yyyy-MM-dd | HH:mm:ss")} 

                                                                                        PAYED AMOUNT: P500.00

                                                                                        ------------------------------------
              ");
              Thread.Sleep(3000);
              Console.Write(@"


                
                                                                 ▀█▀ █░█ ▄▀█ █▄░█ █▄▀ █▀   █▀▀ █▀█ █▀█   █▀▀ █▄░█ █▀█ █▀█ █░░ █░░ █ █▄░█ █▀▀   █
                                                                 ░█░ █▀█ █▀█ █░▀█ █░█ ▄█   █▀░ █▄█ █▀▄   ██▄ █░▀█ █▀▄ █▄█ █▄▄ █▄▄ █ █░▀█ █▄█   ▄



                                                                                          Press any key to contine...
              ");
              run.Speak("Thank you for enrolling!");
                  Console.SetCursorPosition(patakilid - 58, Console.CursorTop - 1);
                  Console.ReadKey();
                  Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display();   
             }

             if(input == 2){
              Console.Write(@"
                                                        Your Enrollment Will be on hold before you make a transaction. Thank you.                             
                ");
              run.Speak("Your Enrollment Will be on hold before you make a transaction. Thank you");
               Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
              Console.Write(@"

                                                                          




                                                                          
                                                                           Press any key to continue... 
              ");
              Console.ReadKey();
              Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); 

             }

              }while(false);
          }

         public static void TigDelete(){
        Console.ForegroundColor = ConsoleColor.DarkGray;
         Console.WriteLine(@"

                                                              Enter subject code what to delete: 
         
         ");
                Console.SetCursorPosition(patakilid - 79, Console.CursorTop - 3);
         string input = Console.ReadLine();

           if(na_add.Contains(input)){
            na_add.Remove(input);
            Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine(@$"
                                                              Successfully Deleted {input} !");
            Console.ResetColor();
             return;
          }

            if(na_add.Count == 0){
          
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine(@"
                                                              Can't Delete because the Enlistment is Empty!
          ");
          Console.ResetColor();
          return;

        }


        if(!na_add.Contains(input)){
                        Console.ForegroundColor=  ConsoleColor.Magenta;
                        Console.WriteLine(@$"
                                                              Can't Delete Subject '{input}' because it is not available in the subjects you've enlisted");

                        Console.ResetColor();
                  return;
                    } 
        

    }
        }

         public class FourthYear(){
          
             static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "CE411", "CE412", "CE413","CE414","CE415","CE416","PCS1","PCS2","ES411"
};



            public static void EnlistSubjects()   {
        string input;
        do
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
            
            

                                               _____________________________________________________________________________________________________________________
                                              |         S U B J E C T  C O D E                        D E S C R I P T I O N                     U N I T S           |
                                              -----------------------------------------------------------------------------------------------------------------------
            

                                                                                          F O U R T  Y E A R  /  F I R S T  S E M E S T E R 


                                                              [] CE411                             Principle of Steel Design                         3
                                                              [] CE412                             Principle of reinforced Precast Concrete Design   3
                                                              [] CE413                             CE Project 1                                      2
                                                              [] CE414                             Principle of Transportation Engineering           3
                                                              [] CE415                             Construction Methods And Project Management       3
                                                              [] CE416                             Refresher Course 2                                3
                                                              [] PCS1                              Project Construction and Management               3
                                                              [] PCS2                              Construction Cost Engineering                     3
                                                              [] ES411                             Engineering Management                            3
                                                                                                        
                                                                                                                                        Total Units: 25
            
            
            
            ");
            Console.ResetColor();
            Console.Write(@"
            
                                                              Available Commands:

                                                              - Type the subject code to enroll (e.g., UTS).
                                                              - Type 'del' to delete a subject (e.g., del UTS).
                                                              - Type 'x' to finish enrollment and display enrolled subjects.
                                                              - Type 'b' to go back.

            ");
            
            subjectcodes:
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
                                                              Enter Prompt/Subject Code: 
            ");
            
           Console.SetCursorPosition(patakilid - 86, Console.CursorTop - 2);
            input = Console.ReadLine();

           while(input == "del"){

            TigDelete();
            goto subjectcodes;
     
          }

          while(input == "b"){

            Enroll enroll = new Enroll(); enroll.Display(); 
          }


          
              while(input == "x" ||  input == "X"){
                  DisplaySubjects();
                  break;
          }
         
              if (!subjectcodes.Contains(input)) {
        Console.ForegroundColor= ConsoleColor.Magenta;
        Console.WriteLine(@$"
                                                              Subject '{input}' is not included or available.
        ");       
            Console.ResetColor();
            goto subjectcodes;
           }

             if(na_add.Contains(input)){
                  Console.ForegroundColor = ConsoleColor.Magenta;
                 Console.WriteLine(@$"
                                                              Subject '{input}' is already enlisted!
                                                              " );    
                    Console.ResetColor();
                    goto subjectcodes;
                
          }
            if(subjectcodes.Contains(input)){
                Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine(@$"
                 
                                                              Successfully Added {input} !
                 ");
                 na_add.Add(input);
                 Console.ResetColor();
                 goto subjectcodes;
          } 
         
            





         
        } while (false);
    }

  

    public static void DisplaySubjects() {
                SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;

              do{
                   Console.Clear();
                   Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          Console.Write(@"


                                                               - T H I S  S U B J E C T  E N L I S T M E N T  I S  I R R E V O C A B L E -
                                                                                  D O  Y O U  W A N T  T O  C O N T I N U E ? 

                                                                                                  [1] Y E S 

                                                                                                  [2] N O


                                                                                            O T H E R  O P T I O N
                                                                                          -------------------------

                                                                                              [3] R E - E D I T 



                                                                                 C H O I C E : 



          
          ");
          Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
          choice = Console.ReadLine();

          while(!double.TryParse(choice,out input) || input < 1 || input > 3){

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(@"
                                                                                               I N V A L I D !       
            ");
            run.Speak("Invalid input!");
           

          }


          switch(input){

            case 1: Console.Beep(); Pay(); break; 
            case 2: Console.Beep(); Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); break;
            case 3: Console.Beep(); EnlistSubjects(); break;
          }


        }while(false);
             
      }


        public static void Pay(){
                        SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;
              do{
              Console.Clear();
              Console.ResetColor(); 
              Console.Write(@"  
                                                                                S U B J E C T S  E N L I S T E D :
              ");
                foreach(string input in na_add) {
              Console.Write($@"
                                                                                         
                                                                                           {input}
                ");
             }

             Console.Write(@"
             

                                                                    E N R O L L M E N T  F E E   

                                                                    - P 500.00 
                                                                    ------------

                                                                        Choose your payment: 
                                                                        [1]. GCASH
                                                                        [2]. Over The Counter

                                                                                  -->: 
             ");
              Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
             choice = Console.ReadLine();

             while(!double.TryParse(choice,out input) || input < 1 || input > 2) {

             Console.ForegroundColor = ConsoleColor.Magenta;
             Console.Write(@"                                    

                                                                           Invalid Input!
             
             ");
            run.Speak("invalid input!");
            Pay();
             }

             if(input == 1){
              payment: 
              Console.ResetColor();
              Console.Write(@"
                                                                        Enter payment: 
              ");
               Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
              string gcash = Console.ReadLine(); 
              double pay;
              while(!double.TryParse(gcash , out pay)){

                run.Speak("Invalid input");
                goto payment;
              }
              if(pay != 500 || pay != 500.00) {
                      Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(@"

                                                                     Pay only P500.00
                ");
                run.Speak("Pay only five hundred!");
                goto payment;
              }
              receipt: 
              Console.Write(@"
              
                                                                      Do you want a receipt?
              
                                                                            [1] Y E S
                                                                            [2] N O 


                                                                              -->: 
              ");
              Console.SetCursorPosition(patakilid - 93, Console.CursorTop - 1);
              string receipt = Console.ReadLine();
              int pili;

              while(!int.TryParse(receipt,out pili) || pili < 1 || pili > 2){

                  run.Speak("invalid input");
                  goto receipt;
              }
              
              Console.Write($@"
                                                                                        ------------------------------------
                                                                                                TRANSACTION RECEIPT

                                                                                        TRANSACTION NO#: {transactionIdentifier}
                                                          
                                                                                        DATE: {DateTime.Now.ToString("yyyy-MM-dd | HH:mm:ss")} 

                                                                                        PAYED AMOUNT: P500.00

                                                                                        ------------------------------------
              ");
              Thread.Sleep(3000);
              Console.Write(@"


                
                                                                 ▀█▀ █░█ ▄▀█ █▄░█ █▄▀ █▀   █▀▀ █▀█ █▀█   █▀▀ █▄░█ █▀█ █▀█ █░░ █░░ █ █▄░█ █▀▀   █
                                                                 ░█░ █▀█ █▀█ █░▀█ █░█ ▄█   █▀░ █▄█ █▀▄   ██▄ █░▀█ █▀▄ █▄█ █▄▄ █▄▄ █ █░▀█ █▄█   ▄



                                                                                          Press any key to contine...
              ");
              run.Speak("Thank you for enrolling!");
                  Console.SetCursorPosition(patakilid - 58, Console.CursorTop - 1);
                  Console.ReadKey();
                  Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display();   
             }

             if(input == 2){
              Console.Write(@"
                                                        Your Enrollment Will be on hold before you make a transaction. Thank you.                             
                ");
              run.Speak("Your Enrollment Will be on hold before you make a transaction. Thank you");
               Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
              Console.Write(@"

                                                                          




                                                                          
                                                                           Press any key to continue... 
              ");
              Console.ReadKey();
              Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); 

             }

              }while(false);
          }

         public static void TigDelete(){
        Console.ForegroundColor = ConsoleColor.DarkGray;
         Console.WriteLine(@"

                                                              Enter subject code what to delete: 
         
         ");
                Console.SetCursorPosition(patakilid - 79, Console.CursorTop - 3);
         string input = Console.ReadLine();

           if(na_add.Contains(input)){
            na_add.Remove(input);
            Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine(@$"
                                                              Successfully Deleted {input} !");
            Console.ResetColor();
             return;
          }
          if(na_add.Count == 0){
          
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine(@"
                                                              Can't Delete because the Enlistment is Empty!
          ");
          Console.ResetColor();
          return;

        }


        if(!na_add.Contains(input)){
                        Console.ForegroundColor=  ConsoleColor.Magenta;
                        Console.WriteLine(@$"
                                                              Can't Delete Subject '{input}' because it is not available in the subjects you've enlisted");

                        Console.ResetColor();
                  return;
                    } 
        

    }
        }


        public class FourthYear_SecondSem() {

               static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "CE421","CE422","CE423","CE424","CE425","CE426","CE427","ES421N"
};



            public static void EnlistSubjects()   {
        string input;
        do
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
            
            

                                               _____________________________________________________________________________________________________________________
                                              |         S U B J E C T  C O D E                        D E S C R I P T I O N                     U N I T S           |
                                              -----------------------------------------------------------------------------------------------------------------------
            

                                                                                          F O U R T H  Y E A R  /  S E C O N D  S E M E S T E R 


                                                              [] CE421                                Quantity Surveying                             2
                                                              [] CE422                                CE Laws, Ethics and Contract                   3
                                                              [] CE423                                CE Project 2                                   3
                                                              [] CE424                                Refresher Course 3                             3
                                                              [] CE425                                Water Supply Planning and Development          3
                                                              [] CE426                                Advance Construction Methods and Management    3
                                                              [] CE427                                Database Management In Construction            3
                                                              [] ES421N                               Obstruction Occupation Safety and Health(COSH) 3
                                                                                         
                                                                                                                                        Total Unit:  21
            
            
            
            ");
            Console.ResetColor();
            Console.Write(@"
            
                                                              Available Commands:

                                                              - Type the subject code to enroll (e.g., UTS).
                                                              - Type 'del' to delete a subject (e.g., del UTS).
                                                              - Type 'x' to finish enrollment and display enrolled subjects.
                                                              - Type 'b' to go back.

            ");
            
            subjectcodes:
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(@"
                                                              Enter Prompt/Subject Code: 
            ");
            
           Console.SetCursorPosition(patakilid - 86, Console.CursorTop - 2);
            input = Console.ReadLine();

           while(input == "del"){

            TigDelete();
            goto subjectcodes;
     
          }

          while(input == "b"){

            Enroll enroll = new Enroll(); enroll.Display(); 
          }


          
              while(input == "x" ||  input == "X"){
                  DisplaySubjects();
                  break;
          }
         
              if (!subjectcodes.Contains(input)) {
        Console.ForegroundColor= ConsoleColor.Magenta;
        Console.WriteLine(@$"
                                                              Subject '{input}' is not included or available.
        ");       
            Console.ResetColor();
            goto subjectcodes;
           }

             if(na_add.Contains(input)){
                  Console.ForegroundColor = ConsoleColor.Magenta;
                 Console.WriteLine(@$"
                                                              Subject '{input}' is already enlisted!
                                                              " );    
                    Console.ResetColor();
                    goto subjectcodes;
                
          }
            if(subjectcodes.Contains(input)){
                Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine(@$"
                 
                                                              Successfully Added {input} !
                 ");
                 na_add.Add(input);
                 Console.ResetColor();
                 goto subjectcodes;
          } 
         
            





         
        } while (false);
    }

  

       public static void DisplaySubjects() {
                SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;

              do{
                   Console.Clear();
                   Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          Console.Write(@"


                                                               - T H I S  S U B J E C T  E N L I S T M E N T  I S  I R R E V O C A B L E -
                                                                                  D O  Y O U  W A N T  T O  C O N T I N U E ? 

                                                                                                  [1] Y E S 

                                                                                                  [2] N O


                                                                                            O T H E R  O P T I O N
                                                                                          -------------------------

                                                                                              [3] R E - E D I T 



                                                                                 C H O I C E : 



          
          ");
          Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
          choice = Console.ReadLine();

          while(!double.TryParse(choice,out input) || input < 1 || input > 3){

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(@"
                                                                                               I N V A L I D !       
            ");
            run.Speak("Invalid input!");
           

          }


          switch(input){

            case 1: Console.Beep(); Pay(); break; 
            case 2: Console.Beep(); Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); break;
            case 3: Console.Beep(); EnlistSubjects(); break;
          }


        }while(false);
             
      }


         public static void Pay(){
                        SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;
              do{
              Console.Clear();
              Console.ResetColor(); 
              Console.Write(@"  
                                                                                S U B J E C T S  E N L I S T E D :
              ");
                foreach(string input in na_add) {
              Console.Write($@"
                                                                                         
                                                                                           {input}
                ");
             }

             Console.Write(@"
             

                                                                    E N R O L L M E N T  F E E   

                                                                    - P 500.00 
                                                                    ------------

                                                                        Choose your payment: 
                                                                        [1]. GCASH
                                                                        [2]. Over The Counter

                                                                                  -->: 
             ");
              Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
             choice = Console.ReadLine();

             while(!double.TryParse(choice,out input) || input < 1 || input > 2) {

             Console.ForegroundColor = ConsoleColor.Magenta;
             Console.Write(@"                                    

                                                                           Invalid Input!
             
             ");
            run.Speak("invalid input!");
            Pay();
             }

             if(input == 1){
              payment: 
              Console.ResetColor();
              Console.Write(@"
                                                                        Enter payment: 
              ");
               Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 1);
              string gcash = Console.ReadLine(); 
              double pay;
              while(!double.TryParse(gcash , out pay)){

                run.Speak("Invalid input");
                goto payment;
              }
              if(pay != 500 || pay != 500.00) {
                      Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(@"

                                                                     Pay only P500.00
                ");
                run.Speak("Pay only five hundred!");
                goto payment;
              }
              receipt: 
              Console.Write(@"
              
                                                                      Do you want a receipt?
              
                                                                            [1] Y E S
                                                                            [2] N O 


                                                                              -->: 
              ");
              Console.SetCursorPosition(patakilid - 93, Console.CursorTop - 1);
              string receipt = Console.ReadLine();
              int pili;

              while(!int.TryParse(receipt,out pili) || pili < 1 || pili > 2){

                  run.Speak("invalid input");
                  goto receipt;
              }
              
              Console.Write($@"
                                                                                        ------------------------------------
                                                                                                TRANSACTION RECEIPT

                                                                                        TRANSACTION NO#: {transactionIdentifier}
                                                          
                                                                                        DATE: {DateTime.Now.ToString("yyyy-MM-dd | HH:mm:ss")} 

                                                                                        PAYED AMOUNT: P500.00

                                                                                        ------------------------------------
              ");
              Thread.Sleep(3000);
              Console.Write(@"


                
                                                                 ▀█▀ █░█ ▄▀█ █▄░█ █▄▀ █▀   █▀▀ █▀█ █▀█   █▀▀ █▄░█ █▀█ █▀█ █░░ █░░ █ █▄░█ █▀▀   █
                                                                 ░█░ █▀█ █▀█ █░▀█ █░█ ▄█   █▀░ █▄█ █▀▄   ██▄ █░▀█ █▀▄ █▄█ █▄▄ █▄▄ █ █░▀█ █▄█   ▄



                                                                                          Press any key to contine...
              ");
              run.Speak("Thank you for enrolling!");
                  Console.SetCursorPosition(patakilid - 58, Console.CursorTop - 1);
                  Console.ReadKey();
                  Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display();   
             }

             if(input == 2){
              Console.Write(@"
                                                        Your Enrollment Will be on hold before you make a transaction. Thank you.                             
                ");
              run.Speak("Your Enrollment Will be on hold before you make a transaction. Thank you");
               Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 5);
              Console.Write(@"

                                                                          




                                                                          
                                                                           Press any key to continue... 
              ");
              Console.ReadKey();
              Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); 

             }

              }while(false);
          }
         public static void TigDelete(){
        Console.ForegroundColor = ConsoleColor.DarkGray;
         Console.WriteLine(@"

                                                              Enter subject code what to delete: 
         
         ");
                Console.SetCursorPosition(patakilid - 79, Console.CursorTop - 3);
         string input = Console.ReadLine();

           if(na_add.Contains(input)){
            na_add.Remove(input);
            Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine(@$"
                                                              Successfully Deleted {input} !");
            Console.ResetColor();
             return;
          }

          if(na_add.Count == 0){
          
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine(@"
                                                              Can't Delete because the Enlistment is Empty!
          ");
          Console.ResetColor();
          return;

        }


        if(!na_add.Contains(input)){
                        Console.ForegroundColor=  ConsoleColor.Magenta;
                        Console.WriteLine(@$"
                                                              Can't Delete Subject '{input}' because it is not available in the subjects you've enlisted");

                        Console.ResetColor();
                  return;
                    } 
        

    }
        }



          public static void Sem() {
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
            
            

                                                                                              C H O O S E  Y O U R  S E M   


                                                                                                  [1] F I R S T  S E M  


                                                                                                  [2] S E C O N D  S E M


                                                                                                 



                                                      TYPE: B to Back - 


                                                                                                  C H O I C E :  
            ");
            Console.SetCursorPosition(patakilid - 61, Console.CursorTop - 1);
             choice = Console.ReadLine();


            while((!double.TryParse(choice, out input) || input < 1 || input > 2) && !(choice == "B" || choice == "b")){

              Console.ForegroundColor = ConsoleColor.Red;
               Console.Write(@"
                                                                                             ╔═════════════════════════╗ 
                                                                                             ║  I  N  V  A  L  I D !   ║ 
                                                                                             ╚═════════════════════════╝
               ");     
                run.Speak("Invalid input!");
                Sem();
            }

            if(choice == "B" || choice == "b"){

                     Console.Beep(); 
                BSCE sc = new BSCE(); sc.Display(); 
            }

              switch(input) {

                case 1: Console.Beep(); FirstYear.EnlistSubjects(); break;
                case 2: Console.Beep(); FirstYear_SecondSem.EnlistSubjects(); break;
              }

             } while(false);

        }



        public static void Sem2() {
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
            
            

                                                                                              C H O O S E  Y O U R  S E M   


                                                                                                  [1] F I R S T  S E M  


                                                                                                  [2] S E C O N D  S E M

                                                                                                  
                                                                                       
                                                                                                 



                                                      TYPE: B to Back - 


                                                                                                  C H O I C E :  
            ");
                    Console.SetCursorPosition(patakilid - 61, Console.CursorTop - 1);
             choice = Console.ReadLine();


            while((!double.TryParse(choice, out input) || input < 1 || input > 2) && !(choice == "B" || choice == "b")){

              Console.ForegroundColor = ConsoleColor.Red;
               Console.Write(@"
                                                                                             ╔═════════════════════════╗ 
                                                                                             ║  I  N  V  A  L  I D !   ║ 
                                                                                             ╚═════════════════════════╝
               ");     
                run.Speak("Invalid input!");
                Sem2();
            }

            if(choice == "B" || choice == "b"){

                     Console.Beep(); 
                BSCE sc = new BSCE(); sc.Display(); 
            }

              switch(input) {

                case 1: Console.Beep(); SecondYear.EnlistSubjects(); break;
                case 2: Console.Beep(); SecondYear_SecondSem.EnlistSubjects(); break;
              }

             } while(false);

        }




         public static void Sem3() {
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
            
            

                                                                                              C H O O S E  Y O U R  S E M   


                                                                                                  [1] F I R S T  S E M  


                                                                                                  [2] S E C O N D  S E M


                                                                                                 
                                                                                              

                                                      TYPE: B to Back - 


                                                                                                  C H O I C E :  
            ");
                    Console.SetCursorPosition(patakilid - 61, Console.CursorTop - 1);
             choice = Console.ReadLine();


            while((!double.TryParse(choice, out input) || input < 1 || input > 2) && !(choice == "B" || choice == "b")){

              Console.ForegroundColor = ConsoleColor.Red;
               Console.Write(@"
                                                                                             ╔═════════════════════════╗ 
                                                                                             ║  I  N  V  A  L  I D !   ║ 
                                                                                             ╚═════════════════════════╝
               ");     
                run.Speak("Invalid input!");
                Sem3();
            }

            if(choice == "B" || choice == "b"){

                     Console.Beep(); 
                BSCE sc = new BSCE(); sc.Display(); 
            }

              switch(input) {

                case 1: Console.Beep(); ThirdYear.EnlistSubjects();  break;
                case 2: Console.Beep(); ThirdYear_SecondSem.EnlistSubjects(); break;
              }

             } while(false);

        }



         public static void Sem4() {
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
            
            

                                                                                              C H O O S E  Y O U R  S E M   


                                                                                                  [1] F I R S T  S E M  


                                                                                                  [2] S E C O N D  S E M


                                                                                                 



                                                      TYPE: B to Back - 


                                                                                                  C H O I C E :  
            ");
                    Console.SetCursorPosition(patakilid - 61, Console.CursorTop - 1);
             choice = Console.ReadLine();


            while((!double.TryParse(choice, out input) || input < 1 || input > 2) && !(choice == "B" || choice == "b")){

              Console.ForegroundColor = ConsoleColor.Red;
               Console.Write(@"
                                                                                             ╔═════════════════════════╗ 
                                                                                             ║  I  N  V  A  L  I D !   ║ 
                                                                                             ╚═════════════════════════╝
               ");     
                run.Speak("Invalid input!");
                Sem4();
            }

            if(choice == "B" || choice == "b"){

                     Console.Beep(); 
                BSCE sc = new BSCE(); sc.Display(); 
            }

              switch(input) {

                case 1: Console.Beep(); FourthYear.EnlistSubjects(); break;
                case 2: Console.Beep(); FourthYear_SecondSem.EnlistSubjects(); break;
              }

             } while(false);

        }
    }
  
}