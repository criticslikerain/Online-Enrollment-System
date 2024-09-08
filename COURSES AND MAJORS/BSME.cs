using System.Runtime.InteropServices;
using System.Speech.Synthesis;


namespace Online_Enrollment_System{



  class BSME:Parent{


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
    "ME111", "MATH111", "PURCOM", "FIL1", "PE1", "NSTP1", "CHEM101","ES111","MATHWORLD"
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


                                                              [] ME111                             Electrical Engineering Orientation                2
                                                              [] MATH111                           Calculus 1                                        3
                                                              [] PURCOM                            Purposive Communication                           3
                                                              [] FIL1                              Retorika                                          3
                                                              [] PE1                               Physical Education 1                              2
                                                              [] NSTP1                             National Service Training Prog. 1                 3
                                                              [] CHEM101                           Chemistry for Engineers                           3
                                                              [] ES111                             Engineering Drawing and Plans                     1
                                                              [] MATHWORLD                         Mathemathics In Modern World                      3
                                                                                             
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
    "PE2", "MATH123", "PHYS101","ES122", "ES123", "RIZAL", "HIST", "ME121","ARTAPP","NSTP2"
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
                                                              [] PHYS101                          Physics for Engineers (Calculus Based)            4
                                                              [] ARTAPP                           Art Appreciation                                  3
                                                              [] ES122                            Computer Aired Design                             1
                                                              [] RIZAL                            Panitikan ng Pilipinas                            3
                                                              [] NSTP2                            National Service Training Program 2               2
                                                              [] HIST                             Reading in Philippines History                    3
                                                              [] ES123                            Basic Occupational Safety and Health              3
                                                              [] ME121                            Workshop Theory and Practice                      3
                                                            
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
    "ME211", "ME212", "MATH214", "ES212", "ES213", "PE3", "ES211","EE201","CW","ARTHUM"
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


                                                              [] ME211                             Thermodynamics 1                                  3
                                                              [] ME212                             Machine Shop Theory                               2
                                                              [] MATH214                           Differential Equations                            3
                                                              [] ES212                             Computer-Fundamentals and Programming 1           1
                                                              [] ES213                             Environmental Science                             3
                                                              [] PE3                               Physical Education 3                              2
                                                              [] ES211                             Statics of Rigid Bodies                           3
                                                              [] EE201                             Basic Electrical Engineering                      3
                                                              [] CW                                The Contemporary World                            3
                                                              [] ARTHUM                            Arts and Humanities                               3
                                                      
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
    "MATH225", "MATH226", "ES222", "ME222", "PE4", "BES221", "UTS", "MST","ETHICS","STS"
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


                                                              [] MATH225                           Political Science                                 3
                                                              [] MATH226                           Advance Mathemathics for Engineering              3
                                                              [] ES222                             Dynamics of Rigid Bodies                          3
                                                              [] ME222                             Thermodynamics 2                                  3
                                                              [] PE4                               Physical Education 4                              2
                                                              [] BES221                            Technopreneuship                                  3
                                                              [] UTS                               Understanding the Self                            3
                                                              [] MST                               Mathemathics, Science and Technology              3
                                                              [] ETHICS                            Ethics                                            3
                                                              [] STS                               Science, Technology and Society                   3                                                          
                                                                                                                                        Total Units: 23
            
            
            
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
    "ME311", "ME312", "ME313", "ES313", "ES315", "ECE111","ES314","ES316","SOCPHIL"
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


                                                              [] ME311                             Machine Elements 1                                3
                                                              [] ME312                             Heat Transfer                                     2
                                                              [] ME313                             Vibration Engineering                             2
                                                              [] ES313                             Fluid Mechanics                                   3
                                                              [] ES315                             Engineering Economics                             3
                                                              [] ECE111                            Basic Electronics                                 3
                                                              [] ES314                             Mechanics of Deformable Bodies                    3
                                                              [] ES316                             Computer Application for ME                       1
                                                              [] SOCPHIL                           Social Science and Philosophy                     3

                                                                     
                                                                                                                                        Total Units: 23
            
            
            
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
    "ME324", "ES321", "ME325", "MEE325", "ME321", "EE322A","ME322","ME323","MEL111"
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


                                                              [] ME324                             Mechanical Engineering Lab 1                      1
                                                              [] ES321                             Material Science and Engineering                  3
                                                              [] ME325                             Methods of Research for ME                        1
                                                              [] MEE325                            ME Refresher Course 1                             3
                                                              [] ME321                             Machine Elements 2                                3
                                                              [] EE322A                            DC and AC Machinery                               3
                                                              [] ME322                             Fluid Machineries 1                               3
                                                              [] ME323                             Combulsion Engineering                            2
                                                              [] MEL111                            ME Elective (Energy Mgt. In Buldings)             4

                                                                                                                                        Total Units: 23
            
            
            
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
    "ME411", "ME413", "ME414","ME415", "ME416", "ME417", "ME412", "ESS411"
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


                                                              [] ME411                             Machine Design 1                                  4
                                                              [] ME413                             ME Project Study 1                                1
                                                              [] ME414                             Power Plant Design with Renewable Energy          4
                                                              [] ME415                             Control Engineering                               3
                                                              [] ME416                             ME Referesher Course 2                            3
                                                              [] ME417                             Refrigerator System                               3
                                                              [] ME412                             Mechanical Engineering Lab 2                      2
                                                              [] ESS411                            Engineering Management                            3
                                                                                                                                 
                                                                                                                                        Total Units: 23
            
            
            
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
    "ME426", "ME425", "ME421","ME422", "ME428", "ME423", "ME424", "ME427"
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


                                                              [] ME426                             Mgt. & Indusrial Processes with Plant Visit       2
                                                              [] ME425                             Air Conditioning and Ventilation System           3
                                                              [] ME421                             Machine Design                                    4
                                                              [] ME422                             Mechanical Engineering Lab                        2
                                                              [] ME428                             ME Refresher Course 3                             3
                                                              [] ME423                             ME Project Study 2                                1
                                                              [] ME424                             Industiral Plant Engineering                      4
                                                              [] ME427                             Me Laws, Ethics, Contracts Codes and Standards    3
                                                                                         
                                                                                                                                        Total Unit:  22
            
            
            
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
                BSME sc = new BSME(); sc.Display(); 
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
                BSME sc = new BSME(); sc.Display(); 
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
                BSME sc = new BSME(); sc.Display(); 
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
                BSME sc = new BSME(); sc.Display(); 
            }

              switch(input) {

                case 1: Console.Beep(); FourthYear.EnlistSubjects(); break;
                case 2: Console.Beep(); FourthYear_SecondSem.EnlistSubjects(); break;
              }

             } while(false);

        }
    }

    class NewStudentBSME:Parent{
          
    }
  
}