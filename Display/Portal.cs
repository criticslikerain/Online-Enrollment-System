using System.Speech.Synthesis;

namespace Online_Enrollment_System{


  class Portal:Parent{

        public static string name;
        public static string lastname;
        public static string middle_initial;
        public static string suffix;
        public static string birthdate;
        public static string gender;
        public static string city;
        public static string area_code;
        public static string street;
        public static string house_num;
        public static string year_lvl;
        public static string id;

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
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║             L  O  G  I  N     P  O  R  T  A  L             ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                                                            ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t╚════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n");
        
       
       

          
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t╔════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                                                            ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║  Student ID:                                               ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                                                            ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                                                            ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║  Password:                                                 ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                                                            ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                                                            ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t║                                                            ║");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t╚════════════════════════════════════════════════════════════╝");

     
          Console.SetCursorPosition(patakilid - 80, Console.CursorTop - 8);
          string username = Console.ReadLine();

      
          Console.SetCursorPosition(patakilid - 83, Console.CursorTop + 2);
          string password = Hide.Tago();
        if(user.Newpin.Length == 0 && user.returnee_Newpin.Length == 0) {
        if(username == user.ID  && password == user.Pin || username == user.returnee_ID && password  == user.returnee_Pin){

          if(username == user.ID){

              Console.WriteLine("Logged in!");
                name = user.Firstname;
              lastname = user.Lastname;
               middle_initial = user.Middle_Initial;
              suffix = user.Suffix;
              gender = user.Gender;
              birthdate = user.Birthdate;
              city = user.City;
              area_code = user.Area_code;
              street = user.Street;
              house_num = user.House_num;
              year_lvl = user.Year_lvl;
              id = user.ID;
              WhenLoggedIn wli = new WhenLoggedIn(); wli.Display();
          }

          if(username == user.returnee_ID){
                   
              Console.WriteLine("returnee Logged in!");
                 name = user.returnee_Firstname;
              lastname = user.returnee_Lastname;
               middle_initial = user.Returnee_Middle_Initial;
              suffix = user.Returnee_Suffix;
              gender = user.Returnee_Gender;
              birthdate = user.Returnee_Birthdate;
              city = user.Returnee_City;
              area_code = user.Returnee_Area_code;
              street = user.Returnee_Street;
              house_num = user.Returnee_House_num;
              year_lvl = user.Returnee_Year_lvl;
               id = user.returnee_ID;
              WhenLoggedIn wli = new WhenLoggedIn(); wli.Display();
          }


        }
        }




        if(user.Newpin.Length != 0 && user.returnee_Newpin.Length == 0) {
             if(username == user.ID  && password == user.Newpin || username == user.returnee_ID && password  == user.returnee_Pin){


          if(username == user.ID){

              Console.WriteLine("Logged in!");
                 name = user.Firstname;
              lastname = user.Lastname;
               middle_initial = user.Middle_Initial;
              suffix = user.Suffix;
              gender = user.Gender;
              birthdate = user.Birthdate;
              city = user.City;
              area_code = user.Area_code;
              street = user.Street;
              house_num = user.House_num;
              year_lvl = user.Year_lvl;
               id = user.ID;
              WhenLoggedIn wli = new WhenLoggedIn(); wli.Display();
          }

          if(username == user.returnee_ID){
                   
              Console.WriteLine("returnee Logged in!");
                       Console.WriteLine("returnee Logged in!");
                 name = user.returnee_Firstname;
              lastname = user.returnee_Lastname;
               middle_initial = user.Returnee_Middle_Initial;
               suffix = user.Returnee_Suffix;
              gender = user.Returnee_Gender;
              birthdate = user.Returnee_Birthdate;
              city = user.Returnee_City;
              area_code = user.Returnee_Area_code;
              street = user.Returnee_Street;
              house_num = user.Returnee_House_num;
              year_lvl = user.Returnee_Year_lvl;
               id = user.returnee_ID;
              WhenLoggedIn wli = new WhenLoggedIn(); wli.Display();
          }
              
        }

        }




        if(user.Newpin.Length == 0 && user.returnee_Newpin.Length != 0){
             if(username == user.ID  && password == user.Pin || username == user.returnee_ID && password  == user.returnee_Newpin){


                if(username == user.ID){

              Console.WriteLine("Logged in!");
                 name = user.Firstname;
              lastname = user.Lastname;
              middle_initial = user.Middle_Initial;
               suffix = user.Suffix;
              gender = user.Gender;
              birthdate = user.Birthdate;
              city = user.City;
              area_code = user.Area_code;
              street = user.Street;
              house_num = user.House_num;
              year_lvl = user.Year_lvl;
               id = user.ID;
              
              WhenLoggedIn wli = new WhenLoggedIn(); wli.Display();
          }

          if(username == user.returnee_ID){
                   
              Console.WriteLine("returnee Logged in!");
                       Console.WriteLine("returnee Logged in!");
                 name = user.returnee_Firstname;
              lastname = user.returnee_Lastname;
               middle_initial = user.Returnee_Middle_Initial;
               suffix = user.Returnee_Suffix;
              gender = user.Returnee_Gender;
              birthdate = user.Returnee_Birthdate;
              city = user.Returnee_City;
              area_code = user.Returnee_Area_code;
              street = user.Returnee_Street;
              house_num = user.Returnee_House_num;
              year_lvl = user.Returnee_Year_lvl;
               id = user.returnee_ID;
              
              WhenLoggedIn wli = new WhenLoggedIn(); wli.Display();
          }
              
        }

        }



        if(user.Newpin.Length != 0 && user.returnee_Newpin.Length != 0){
             if(username == user.ID  && password == user.Newpin || username == user.returnee_ID && password  == user.returnee_Newpin){

            if(username == user.ID){

              Console.WriteLine("Logged in!");
                name = user.Firstname;
              lastname = user.Lastname;
               middle_initial = user.Middle_Initial;
              suffix = user.Suffix;
              gender = user.Gender;
              birthdate = user.Birthdate;
              city = user.City;
              area_code = user.Area_code;
              street = user.Street;
              house_num = user.House_num;
              year_lvl = user.Year_lvl;
              WhenLoggedIn wli = new WhenLoggedIn(); wli.Display();
          }

          if(username == user.returnee_ID){
                   
              Console.WriteLine("returnee Logged in!");
                       Console.WriteLine("returnee Logged in!");
                 name = user.returnee_Firstname;
              lastname = user.returnee_Lastname;
               middle_initial = user.Returnee_Middle_Initial;
                suffix = user.Returnee_Suffix;
              gender = user.Returnee_Gender;
              birthdate = user.Returnee_Birthdate;
              city = user.Returnee_City;
              area_code = user.Returnee_Area_code;
              street = user.Returnee_Street;
              house_num = user.Returnee_House_num;
              year_lvl = user.Returnee_Year_lvl;
              WhenLoggedIn wli = new WhenLoggedIn(); wli.Display();
          }
        
        }

        }
      else{
        Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(@"




                    
                                                                                     ╔═══════════════════════════════════════════════════╗ 
                                                                                     ║  I N V A L I D  U S E R   O R  P A S S W O R D    ║ 
                                                                                     ╚═══════════════════════════════════════════════════╝                                         
                    "); 
                    run.Speak("Invalid user or password");
                    Display();

      }

          }while(false);
            
            base.Display();
        }
    }
}

/*
  Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(@"




                    
                                                        ╔═══════════════════════════════════════════════════╗ 
                                                        ║  I N V A L I D  U S E R   O R  P A S S W O R D    ║ 
                                                        ╚═══════════════════════════════════════════════════╝                                         
                    "); 
                    run.Speak("Invalid input!");
                    Display();

                    */