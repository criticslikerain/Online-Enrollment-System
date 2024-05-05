using System.Speech.Synthesis;

namespace Online_Enrollment_System{


  class Portal:Parent{

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

     
          Console.SetCursorPosition(patakilid - 83, Console.CursorTop - 8);
          string username = Console.ReadLine();

      
          Console.SetCursorPosition(patakilid - 83, Console.CursorTop + 2);
          string password = Hide.Tago();
        if(user.Newpin.Length == 0 && user.returnee_Newpin.Length == 0) {
        if(username == user.ID  && password == user.Pin || username == user.returnee_ID && password  == user.returnee_Pin){

          if(username == "2024-00001"){

                Console.WriteLine("Logged in!");
          }

          if(username == "2024-00002"){
                    Console.WriteLine("Logged in!");

          }
        }
        }




        if(user.Newpin.Length != 0 && user.returnee_Newpin.Length == 0) {
             if(username == user.ID  && password == user.Newpin || username == user.returnee_ID && password  == user.returnee_Pin){


           if(username == "2024-00001"){
              

          }

          if(username == "2024-00002"){
              

          }
              
        }

        }




        if(user.Newpin.Length == 0 && user.returnee_Newpin.Length != 0){
             if(username == user.ID  && password == user.Pin || username == user.returnee_ID && password  == user.returnee_Newpin){


                       if(username == "2024-00001"){
              

          }

          if(username == "2024-00002"){
              

          }
              
        }

        }



        if(user.Newpin.Length != 0 && user.returnee_Newpin.Length != 0){
             if(username == user.ID  && password == user.Newpin || username == user.returnee_ID && password  == user.returnee_Newpin){

           if(username == "2024-00001"){
              

          }

          if(username == "2024-00002"){
              

          }
        
        }

        }

              
          }while(false);
            
            base.Display();
        }
    }
}