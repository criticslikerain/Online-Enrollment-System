using System.Runtime.InteropServices;
using System.Speech.Synthesis;


namespace Online_Enrollment_System{

  class EducElem:Parent{


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



        class FirstYear() {
              static List<string> na_add = new List<string>();
          static List<string> subjectcodes = new List<string> {
    "STS", "UTS", "PURCOM", "FIL1", "PE1", "NSTP1", "HIST","MIST","SOCPHIL","RIZAL"
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


                                                              [] STS                               Science, Technology & Society                     3
                                                              [] UTS                               Understanding the Self                            3
                                                              [] PURCOM                            Purposive Communication                           3
                                                              [] FIL1                              Retorika                                          3
                                                              [] PE1                               Physical Education 1                              2
                                                              [] NSTP1                             National Service Training Prog. 1                 3
                                                              [] HIST                              Reading in Philippine History                     3
                                                              [] MIST                              Mathemathics Science & Technology                 3
                                                              [] SOCPHIL                           Social Science & Philosophy                       2
                                                              [] RIZAL                             Rizal's Life & Works                              
                                                        
                                                                                                                                        Total Units: 29
            
            
            
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
    "PE2", "ETHICS", "MTB10", "ARTHUM", "MATHWORLD", "FIL2", "EDUC101","CW","ARTAPP","NSTP2"
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
                                                              [] ARTHUM                           Arts and Humanities                               3
                                                              [] FIL2                             Panitikan ng Pilipinas                            3
                                                              [] NSTP2                            National Service Training Prog  . 2               3
                                                              [] MTB10                            Content & Pedagogy for the Mother Tongue          3
                                                              [] EDUC101                          The Child & Adolescent Learners & Learning Princ. 3
                                                              [] MATHWORLD                        National Service Training Prog  . 2               3
                                                            
                                                                                                                                        Total Units: 29
            
            
            
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
    "VED100", "EDUC211", "SSC211", "FIL211", "ENG211", "PE3", "SCI211","MATH211"
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


                                                              [] VED100                            Good Manners and Right Conduct                    3
                                                              [] SSC211                            Teaching Social Studies in the Elementary Grades..3
                                                              [] EDUC211                           The Teaching Profession                           3
                                                              [] FIL211                            Pagtuturo ng Filipino sa Elementary 1             3
                                                              [] ENG211                            Teaching English in the Elem Grades(Lanuage Arts) 3
                                                              [] PE3                               Physical Education 3                              2
                                                              [] SCI211                            Teaching Science in the Elementary Grade (biochem)3
                                                              [] MATH211                           Teaching Math in Primary Grades                   3
                                                      
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
    "EDUC222", "SCI222", "MATH222", "SSC222", "PE4", "FIL222", "ENGL222", "EDUC211"
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


                                                              [] EDUC222                           Political Science                                 3
                                                              [] SCI222                            Journalism Principles & Practices                 3
                                                              [] MATH222                           Communication, Culture & Society                  3
                                                              [] SSC222                            Risk, Disaster & Humanitarian Communication       3
                                                              [] PE4                               Physical Education 4                              2
                                                              [] FIL222                            General Psychology                                3
                                                              [] ENGL222                           Arts & Humanities                                 3
                                                              [] EDUC211                           Arts & Humanities                                 3
                                                          
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
    "RGEC1", "EDUC313", "ARTS100", "EDUC312", "TLE311", "MUSIC100","EDUC311"
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


                                                              [] RGEC1                             Research in Education                             3
                                                              [] EDUC313                           Facilitating Learner-Centered Teaching            3
                                                              [] ARTS100                           Teaching Arts in Elem                             3
                                                              [] EDUC312                           Technology for Teaching & Learning 1              3
                                                              [] TLE311                            Edukasyon Pantahanan at Pangkabuhayan             3
                                                              [] MUSIC100                          Teaching Music in Elementary Grades               3
                                                              [] EDUC311                           Asessment in Learning 1                           3

                                                                     
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
    "RGEC1", "TLE322", "PEH100", "EDUC321", "EDUC322", "EDUC333","EDUC324","ELEC100"
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


                                                              [] RGEC1                             Review on General Education Courses               3
                                                              [] TLE322                            Edukasyong Pantahanan at Pangkabuhayan w/Entrep.  3
                                                              [] PEH100                            Teaching PE and Health in the Elementary Grades   3
                                                              [] EDUC321                           Asessment in Learning 2                           3
                                                              [] EDUC322                           Technology for Teaching and Learning 2            3
                                                              [] EDUC333                           The Teacher & The School Curriculum               3
                                                              [] EDUC324                           Building & Enhancing New Literacies Across the Cu.3
                                                              [] ELEC100                           Teaching Multi-Grade Classes                      3

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
    "RGEC2", "FS2", "FS1"
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


                                                              [] RGEC2                             Review on Professional Education Courses          3
                                                              [] FS2                               Field Study 2                                     3
                                                              [] FS1                               Field Study 1                                     3
                                                                                                        
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
    "TI100"
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


                                                              [] TI100                                Teaching Internship                            6
                                                                                         
                                                                                                                                        Total Unit:  6
            
            
            
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