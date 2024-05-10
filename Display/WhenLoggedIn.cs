using System.Speech.Synthesis;

namespace Online_Enrollment_System{


  class WhenLoggedIn:Parent{

        public override void Display()
        {
                SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;
          do{
        
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          Console.Write($@"


____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
{Online_Enrollment_System.Portal.name}'s - STUDENT PORTAL                                                                                                                       
____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________



          
            ▓▓▓▓▓▓                              S T U D E N T  O V E R V I E W                                                
         ▓▓▓▓▓▓▓▓▓▓▓▓  
         ▓▓▓▓▓▓▓▓▓▓▓▓                           Name : {Online_Enrollment_System.Portal.name}                             
         ▓▓▓▓▓▓▓▓▓▓▓▓                           MI : {Online_Enrollment_System.Portal.middle_initial}
            ▓▓▓▓▓▓                              Surname : {Online_Enrollment_System.Portal.lastname}                                                                       
      ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓                        Suffix : {Online_Enrollment_System.Portal.suffix}                                                                          
     ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓                       Gender :  {Online_Enrollment_System.Portal.gender}
     ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓                       Birthdate : {Online_Enrollment_System.Portal.birthdate}
                                                                                                                         
     {Online_Enrollment_System.Portal.name} {Online_Enrollment_System.Portal.lastname}
          {Online_Enrollment_System.Portal.id}
        S T U D E N T                          City : {Online_Enrollment_System.Portal.city}
                                               Area Code : {Online_Enrollment_System.Portal.area_code}
                                               Street : {Online_Enrollment_System.Portal.street}
                                               House number: {Online_Enrollment_System.Portal.house_num}

                                               Year Level : {Online_Enrollment_System.Portal.year_lvl}                  







                                                            [1] E N R O L L                  [2] C H A N G E  P A S S W O R D                    [3] L O G O U T 



                                                                                                       C H O I C E :    



____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
                                                                                                      Copyright 2024 Group2. All rights reserved.
____________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
          ");


          while(!double.TryParse(choice, out input) || input < 1 || input > 3){

            Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(@"




                    
                                                                                                       ╔═════════════════════════╗ 
                                                                                                       ║  I  N  V  A  L  I D !   ║ 
                                                                                                       ╚═════════════════════════╝                                         
                    "); 
                    run.Speak("Invalid input!");
                    Display();   
          }

         
        
        
        }while(false);

           base.Display();
      }
    }
}