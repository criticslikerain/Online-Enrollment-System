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
            

                                                                                              C H O O S E  Y O U R  Y E A R  


                                                                                                  [1] F I R S T  Y E A R 


                                                                                                  [2] S E C O N D  Y E A R 


                                                                                                  [3] T H I R D  Y E A R


                                                                                                  [4] F O U R T H  Y E A R
                                                                                                  
                                                                                                   



                                                      TYPE: B to Back - 


                                                                                                  C H O I C E :  
            ");
            run.Speak("choose your year level");
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



        class FirstYear() {
              static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "IT111", "UTS", "MATHWORLD", "FIL1", "PE1", "NSTP1", "IT110", "MATHPREP"
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


                                                              [] IT111                             Computer Programming I                            3
                                                              [] UTS                               Understanding the Self                            3
                                                              [] MATHWORLD                         Mathematics in the Modern World                   3
                                                              [] FIL1                              Retorika                                          3
                                                              [] PE1                               Physical Education 1                              2
                                                              [] NSTP1                             National Service Training Prog. 1                 3
                                                              [] IT110                             Introduction To Computing                         3
                                                              [] MATHPREP                          Pre Calculus for Non-STEM                         3

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

            BSIT it = new BSIT(); it.Display();
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

             Console.Write("YEY");
             foreach(string input in na_add) {
              Console.WriteLine(input);
             }
             Console.ReadKey();
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

 

          class FirstYear_SecondSem(){
          
             static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "PE2", "IT120", "IT121", "HIST", "PURCOM", "FIL2", "NSTP2"
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
                                                              [] IT120                            Discrete Structures                               3
                                                              [] IT121                            Computer Programming                              3
                                                              [] HIS                              Readings in Philippine History                    3
                                                              [] PURCOM                           Purposive Communication                           3
                                                              [] FIL2                             Panitikan ng Pilipinas                            3
                                                              [] NSTP2                            National Service Training Prog. 2                 3
                                                            
                                                                                                                                        Total Units: 20
            
            
            
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

            BSIT it = new BSIT(); it.Display();
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

             Console.Write("YEY");
             foreach(string input in na_add) {
              Console.WriteLine(input);
             }
             Console.ReadKey();
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
          class SecondYear(){


                 static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "IT121", "IT212", "IT213", "CW", "ARTAPP", "PE3", "IT210"
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


                                                              [] IT221                             Web Design & Development                          3
                                                              [] IT212                             Digital Logic Design                              3
                                                              [] IT213                             PC Assembly & Troubleshooting                     3
                                                              [] CW                                The Contemporary World                            3
                                                              [] ARTAP                             Art Appreciation                                  3
                                                              [] PE3                               Physical Education 3                              2
                                                              [] IT210                             Data structures & Algorithm                       3
                                                      
                                                                                                                                        Total Units: 20
            
            
            
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

            BSIT it = new BSIT(); it.Display();
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

             Console.Write("YEY");
             foreach(string input in na_add) {
              Console.WriteLine(input);
             }
             Console.ReadKey();
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
          class SecondYear_SecondSem(){
                 static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "IT222", "ACCTG", "STS", "ETHICS", "PE4", "IT220", "IT221"
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


                                                              [] IT222                             Database Mangement                                3
                                                              [] ACCTG                             Fundamentals of Acconting                         6
                                                              [] STS                               Science, Technology and Society                   3
                                                              [] ETHICS                            Ethics                                            3
                                                              [] PE4                               Physical Education 4                              2
                                                              [] IT220                             Object-Oriented Programming                       3
                                                              [] IT221                             Networking                                        3
                                                          
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

            BSIT it = new BSIT(); it.Display();
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

             Console.Write("YEY");
             foreach(string input in na_add) {
              Console.WriteLine(input);
             }
             Console.ReadKey();
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
        class Summer{
                  static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "FILIT", "IT223", "ITTEL1"
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
            

                                                                                          S E C O N D  Y E A R  /  S U M M E R 


                                                              [] FILIT                             The Philippines Society in the IT Era             3
                                                              [] IT223                             Information Management                            3
                                                              [] ITTEL1                            IT Track Elective                                 3
                                                          
                                                                                                                                        Total Units: 9
            
            
            
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

            BSIT it = new BSIT(); it.Display();
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

             Console.Write("YEY");
             foreach(string input in na_add) {
              Console.WriteLine(input);
             }
             Console.ReadKey();
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
        class Summer2{

                static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "IT324", "IT323", "IT325"
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
            

                                                                                          T H I R D  Y E A R  /  S U M M E R 


                                                              [] IT324                             Social Issues and Professional Practices          3
                                                              [] IT323                             Capstone Project 1                                6
                                                              [] IT325                             Quantitative Methods                              3
                                                          
                                                                                                                                        Total Units: 9
            
            
            
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

            BSIT it = new BSIT(); it.Display();
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

             Console.Write("YEY");
             foreach(string input in na_add) {
              Console.WriteLine(input);
             }
             Console.ReadKey();
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



          class ThirdYear(){
                 static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "STAT", "IT311", "IT310", "ITELEC1", "IT312", "ITTEL2", "TECHNO"
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


                                                              [] STAT                              Statistics And Probability                        3
                                                              [] IT311                             Operating Systems                                 3
                                                              [] IT310                             Applications Development & Emerging Technologies  3
                                                              [] ITELEC1                           IT Elective I                                     3
                                                              [] IT312                             Human Computer Interaction                        3
                                                              [] ITTEL2                            IT Track Elective II                              3
                                                              [] TECHNO                            Technopreneurship                                 3
                              
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

            BSIT it = new BSIT(); it.Display();
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

             Console.Write("YEY");
             foreach(string input in na_add) {
              Console.WriteLine(input);
             }
             Console.ReadKey();
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

          class ThirdYear_SecondSem(){

               static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "MMG", "IT320", "IT322", "IT321", "ITELEC2"
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
            

                                                                                          T H I R D  Y E A R  /  S E C O N D   S E M E S T E R 


                                                              [] MMG                               Marketing Media Gamification                      3
                                                              [] IT320                             Systems Analysis & Design                         3
                                                              [] MATHWORLD                         Information Assurance & Security                  3
                                                              [] FIL1                              Systems Integration & Architecture                3
                                                              [] ITELEC2                           IT Elective II                                    3
                                                      
                                                                                                                                        Total Units: 15
            
            
            
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

            BSIT it = new BSIT(); it.Display();
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

             Console.Write("YEY");
             foreach(string input in na_add) {
              Console.WriteLine(input);
             }
             Console.ReadKey();
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

         class FourthYear(){
          
             static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "IT410", "IT412", "ITELECTS", "RIZAL", "IT411"
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
            

                                                                                          F O U R T H  Y E A R  /  F I R S T  S E M E S T E R 


                                                              [] IT410                             Capstone Project II                               3
                                                              [] IT412                             Systems Administration & Maintenance              3
                                                              [] ITELECT3                          IT elective II                                    3
                                                              [] RIZAL                             Rizal's Life & Works                              3
                                                              [] IT411                             Intergrative Programming & Technologies           3
                                                      
                                                                                                                                        Total Units: 15
            
            
            
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

            BSIT it = new BSIT(); it.Display();
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

             Console.Write("YEY");
             foreach(string input in na_add) {
              Console.WriteLine(input);
             }
             Console.ReadKey();
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


        class FourthYear_SecondSem() {

               static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "IT420", "OJT"
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


                                                              [] IT420                             IT Seminars & Tours                               3
                                                              [] OJT                               On Job Training (500 Hours)                       6
                                               
                                                                                                                                        Total Units: 9
            
            
            
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

            BSIT it = new BSIT(); it.Display();
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

             Console.Write("YEY");
             foreach(string input in na_add) {
              Console.WriteLine(input);
             }
             Console.ReadKey();
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
            run.Speak("choose your semester");
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
                BSIT sc = new BSIT(); sc.Display(); 
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

                                                                                                  
                                                                                                  [3] S U M M E R 


                                                                                                 



                                                      TYPE: B to Back - 


                                                                                                  C H O I C E :  
            ");
             run.Speak("choose your semester");
                    Console.SetCursorPosition(patakilid - 61, Console.CursorTop - 1);
             choice = Console.ReadLine();


            while((!double.TryParse(choice, out input) || input < 1 || input > 3) && !(choice == "B" || choice == "b")){

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
                BSIT sc = new BSIT(); sc.Display(); 
            }

              switch(input) {

                case 1: Console.Beep(); SecondYear.EnlistSubjects(); break;
                case 2: Console.Beep(); SecondYear_SecondSem.EnlistSubjects(); break;
                case 3: Console.Beep(); Summer.EnlistSubjects(); break;
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


                                                                                                  [3] S U M M E R  
                                                                                                 



                                                      TYPE: B to Back - 


                                                                                                  C H O I C E :  
            ");
                    Console.SetCursorPosition(patakilid - 61, Console.CursorTop - 1);
             choice = Console.ReadLine();


            while((!double.TryParse(choice, out input) || input < 1 || input > 3) && !(choice == "B" || choice == "b")){

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
                BSIT sc = new BSIT(); sc.Display(); 
            }

              switch(input) {

                case 1: Console.Beep(); ThirdYear.EnlistSubjects();  break;
                case 2: Console.Beep(); ThirdYear_SecondSem.EnlistSubjects(); break;
                case 3: Console.Beep(); Summer2.EnlistSubjects(); break;
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
             run.Speak("choose your semester");
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
                BSIT sc = new BSIT(); sc.Display(); 
            }

              switch(input) {

                case 1: Console.Beep(); FourthYear.EnlistSubjects(); break;
                case 2: Console.Beep(); FourthYear_SecondSem.EnlistSubjects(); break;
              }

             } while(false);

        }
    }
  
}