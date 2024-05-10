using System.Runtime.InteropServices;
using System.Speech.Synthesis;


namespace Online_Enrollment_System{

  class EducEnglish:Parent{


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
             run.Speak("choose your semester");
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
    "STS", "UTS", "MATHWORLD", "FIL1", "PE1", "NSTP1", "HIST"
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


                                                              [] HIST                              Readings In Philippine History                    3
                                                              [] UTS                               Understanding the Self                            3
                                                              [] MATHWORLD                         Mathematics in the Modern World                   3
                                                              [] FIL1                              Retorika                                          3
                                                              [] PE1                               Physical Education 1                              2
                                                              [] NSTP1                             National Service Training Prog. 1                 3
                                                              [] STS                               Science Technology And Society                    3
                                                        
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

            EducElem it = new EducElem(); it.Display();
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
                                                              [] CW                               The Contemporary World                            3
                                                              [] ETHICS                           Ethics                                            3
                                                              [] ARTAPP                           Art Appreciation                                  3
                                                              [] PURCOM                           Purposive Communication                           3
                                                              [] FIL2                             Panitikan ng Pilipinas                            3
                                                              [] NSTP2                            National Service Training Prog  . 2               3
                                                            
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

            EducElem it = new EducElem(); it.Display();
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
    "RIZAL", "SOCPHIL", "COM111", "COM210", "MST", "PE3", "FIL3"
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


                                                              [] RIZAL                             Web Design & Development                          3
                                                              [] SOCPHIL                           Social Science & Philosophy                       3
                                                              [] COM111                            Intro. to Communication Media                     3
                                                              [] COM210                            Development Communication                         3
                                                              [] MST                               Math, Science & Techmology                        3
                                                              [] PE3                               Physical Education 3                              2
                                                              [] FIL3                              Masining na Pamamahayag                           3
                                                      
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

            EducElem it = new EducElem(); it.Display();
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
          class SecondYear_SecondSem(){
                 static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "POLSCI", "IPO220", "COM221", "COM220", "PE4", "PSYCH1", "ARTHUM"
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


                                                              [] POLSCI                            Political Science                                 3
                                                              [] IPO220                            Journalism Principles & Practices                 3
                                                              [] COM221                            Communication, Culture & Society                  3
                                                              [] COM220                            Risk, Disaster & Humanitarian Communication       3
                                                              [] PE4                               Physical Education 4                              2
                                                              [] PSYCH1                            General Psychology                                3
                                                              [] ARTHUM                             Arts & Humanities                                3
                                                          
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

            EducElem it = new EducElem(); it.Display();
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
    


          class ThirdYear(){
                 static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "STAT", "COM312", "COM311", "CEL311", "IPO310", "PUBAD"
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
                                                              [] COM312                            Comm. Media Laws & Ethics                         3
                                                              [] COM311                            Public Information Principles & Practicie         3
                                                              [] CEL311                            Public Relations Prnciples And Practices          3
                                                              [] IPO310                            Statistics & Probability                          3
                                                              [] PUBAD                             Public Administration                             3
                                                                     
                                                                                                                                        Total Units: 18
            
            
            
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

            EducElem it = new EducElem(); it.Display();
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

          class ThirdYear_SecondSem(){

               static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "COM321", "SOCIO", "COMDEV", "IPO320", "CEL323", "CEL322"
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


                                                              [] COM321                            Communication Research                            3
                                                              [] SOCIO                             Sociology                                         3
                                                              [] COMDEV                            Community Development                             3
                                                              [] CEL323                            Social Media Principles & Practices               3
                                                              [] CEL323                            Organizational Culture & Communication            3
                                                              [] CEL322                            Behavioral & Social Change Communication          3

                                                                                                                                        Total Units: 18
            
            
            
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

            EducElem it = new EducElem(); it.Display();
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

         class FourthYear(){
          
             static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "COM411", "THESIS1", "COM412"
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


                                                              [] COM411                            Communication Planning                            3
                                                              [] THESIS1                           Special Project                                   3
                                                              [] COM412                            Communication Management                          3
                                                                                                        
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

            EducElem it = new EducElem(); it.Display();
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


        class FourthYear_SecondSem() {

               static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "THESIS2  ", "COM420","CEL424"
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


                                                              [] THESIS2                           Special Project 2                                 3
                                                              [] COM420                            Knowledge Management                              3
                                                              [] CEL424                            Civic Engagement & Participatory Communication    3
                                               
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

            EducElem it = new EducElem(); it.Display();
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
                EducElem sc = new EducElem(); sc.Display(); 
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
                EducElem sc = new EducElem(); sc.Display(); 
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
                EducElem sc = new EducElem(); sc.Display(); 
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
                EducElem sc = new EducElem(); sc.Display(); 
            }

              switch(input) {

                case 1: Console.Beep(); FourthYear.EnlistSubjects(); break;
                case 2: Console.Beep(); FourthYear_SecondSem.EnlistSubjects(); break;
              }

             } while(false);

        }
    }
  
}