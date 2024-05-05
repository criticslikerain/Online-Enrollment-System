using System.Speech.Synthesis;


namespace Online_Enrollment_System{


class StudentPage:Parent{
      
       private static Data user = new Data();
       Information manage = new Information();
        string surname;
        string name;
        string middle_initial;
        string suffix;
        string month;
        string day;
        string year;
        string birthdate; 
        public static string gender;
        string city;
        string area_code;
        string street;
        string house_num;
        string Overall;

        public override void Display()
        {
              SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);

          do{ 
          Console.Clear();
          Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          
          Console.Write(@"       





                                                                 █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ ▀█▀ █ █▀█ █▄░█    █▀▀ █▀█ █▀█ █▀▄▀█
                                                                 █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ ░█░ █ █▄█ █░▀█    █▀░ █▄█ █▀▄ █░▀░█
                                                                                

                                                                               S T U D E N T  I N F O R M A T I O N

          
                                                                S U R N A M E : 

                                                          
                                                                F I R S T  N A M E :


                                                                M I D D L E  N A M E : 


                                                                S U F F I X (if any) : 


                                                                G E N D E R :  


                                                                B I R T H  D A T E - 
                                                        

          
          
          ");
           Console.SetCursorPosition(patakilid - 94, Console.CursorTop - 20);
           surname = Console.ReadLine().ToUpper();
          





            Console.Clear();
            Console.Write($@"       





                                                                 █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ ▀█▀ █ █▀█ █▄░█    █▀▀ █▀█ █▀█ █▀▄▀█
                                                                 █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ ░█░ █ █▄█ █░▀█    █▀░ █▄█ █▀▄ █░▀░█
                                                                                

                                                                               S T U D E N T  I N F O R M A T I O N

          
                                                                S U R N A M E : {surname}              

                                                          
                                                                F I R S T  N A M E :


                                                                M I D D L E  N A M E : 


                                                                S U F F I X (if any) : 


                                                                G E N D E R :  


                                                                B I R T H  D A T E - 
                                                        

          
          
          ");

           Console.SetCursorPosition(patakilid - 90, Console.CursorTop - 17);
           name = Console.ReadLine().ToUpper();

             Console.Clear();
            Console.Write($@"       





                                                                 █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ ▀█▀ █ █▀█ █▄░█    █▀▀ █▀█ █▀█ █▀▄▀█
                                                                 █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ ░█░ █ █▄█ █░▀█    █▀░ █▄█ █▀▄ █░▀░█
                                                                                

                                                                               S T U D E N T  I N F O R M A T I O N

          
                                                                S U R N A M E : {surname}              

                                                          
                                                                F I R S T  N A M E : {name}


                                                                M I D D L E  N A M E : 


                                                                S U F F I X (if any) : 


                                                                G E N D E R :  


                                                                B I R T H  D A T E - 
                                                        

          
          
          ");

           Console.SetCursorPosition(patakilid - 89, Console.CursorTop - 14);
           middle_initial = Console.ReadLine().ToUpper();


            Console.Clear();
            Console.Write($@"       





                                                                 █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ ▀█▀ █ █▀█ █▄░█    █▀▀ █▀█ █▀█ █▀▄▀█
                                                                 █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ ░█░ █ █▄█ █░▀█    █▀░ █▄█ █▀▄ █░▀░█
                                                                                

                                                                               S T U D E N T  I N F O R M A T I O N

          
                                                                S U R N A M E : {surname}              

                                                          
                                                                F I R S T  N A M E : {name}


                                                                M I D D L E  N A M E : {middle_initial} 


                                                                S U F F I X (if any) : 


                                                                G E N D E R :  


                                                                B I R T H  D A T E - 
                                                        

          
          
          ");

          Console.SetCursorPosition(patakilid - 88, Console.CursorTop - 11);
          suffix = Console.ReadLine().ToUpper();

            gender: 
            Console.ForegroundColor = ConsoleColor.DarkCyan;
             Console.Clear();
            Console.Write($@"       





                                                                 █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ ▀█▀ █ █▀█ █▄░█    █▀▀ █▀█ █▀█ █▀▄▀█
                                                                 █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ ░█░ █ █▄█ █░▀█    █▀░ █▄█ █▀▄ █░▀░█
                                                                                

                                                                               S T U D E N T  I N F O R M A T I O N

          
                                                                S U R N A M E : {surname}              

                                                          
                                                                F I R S T  N A M E : {name}


                                                                M I D D L E  N A M E : {middle_initial} 


                                                                S U F F I X (if any) : {suffix}


                                                                G E N D E R :  

                                                                       [M] = MALE    |     [F] = FEMALE    
                                                                      
                                                                            : 
                        
                                                                B I R T H  D A T E : 
                                                        

          
          
          ");

          Console.SetCursorPosition(patakilid - 96, Console.CursorTop - 7);
          gender = Console.ReadLine();

          while(gender != "M" && gender != "m" && gender != "F" && gender != "f"  ){

             Console.ForegroundColor = ConsoleColor.Magenta;
             Console.Write(@"



                                                                              I N V A L I D !
             ");
             run.Speak("Invalid input!");
             goto gender;

          }

          Tig_ila_sa_Gender();



        

            month:
           Console.Clear();
            Console.Write($@"       





                                                                 █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ ▀█▀ █ █▀█ █▄░█    █▀▀ █▀█ █▀█ █▀▄▀█
                                                                 █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ ░█░ █ █▄█ █░▀█    █▀░ █▄█ █▀▄ █░▀░█
                                                                                

                                                                               S T U D E N T  I N F O R M A T I O N

          
                                                                S U R N A M E : {surname}              

                                                          
                                                                F I R S T  N A M E : {name}


                                                                M I D D L E  N A M E : {middle_initial} 


                                                                S U F F I X (if any) : {suffix}


                                                                G E N D E R : {gender} 


                                                                B I R T H  D A T E - 

                                                                        Month : 
                                                                        Day : 
                                                                        Year : 
                                                        

          
          
          ");

          Console.SetCursorPosition(patakilid - 96, Console.CursorTop - 7);
          month  = Console.ReadLine().ToUpper();

           Console.Clear();
            Console.Write($@"       





                                                                 █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ ▀█▀ █ █▀█ █▄░█    █▀▀ █▀█ █▀█ █▀▄▀█
                                                                 █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ ░█░ █ █▄█ █░▀█    █▀░ █▄█ █▀▄ █░▀░█
                                                                                

                                                                               S T U D E N T  I N F O R M A T I O N

          
                                                                S U R N A M E : {surname}              

                                                          
                                                                F I R S T  N A M E : {name}


                                                                M I D D L E  N A M E : {middle_initial} 


                                                                S U F F I X (if any) : {suffix}


                                                                G E N D E R : {gender} 


                                                                B I R T H  D A T E - 

                                                                        Month : {month} 
                                                                        Day : 
                                                                        Year : 
                                                        

          
          
          ");
          Console.SetCursorPosition(patakilid - 97, Console.CursorTop - 6);
          day = Console.ReadLine().ToUpper();

           Console.Clear();
            Console.Write($@"       





                                                                 █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ ▀█▀ █ █▀█ █▄░█    █▀▀ █▀█ █▀█ █▀▄▀█
                                                                 █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ ░█░ █ █▄█ █░▀█    █▀░ █▄█ █▀▄ █░▀░█
                                                                                

                                                                               S T U D E N T  I N F O R M A T I O N

          
                                                                S U R N A M E : {surname}              

                                                          
                                                                F I R S T  N A M E : {name}


                                                                M I D D L E  N A M E : {middle_initial} 


                                                                S U F F I X (if any) : {suffix}


                                                                G E N D E R : {gender} 


                                                                B I R T H  D A T E - 

                                                                        Month : {month} 
                                                                        Day : {day}
                                                                        Year : 
                                                        

          
          
          ");
            Console.SetCursorPosition(patakilid - 96, Console.CursorTop - 5);
          year = Console.ReadLine().ToUpper();


           Console.Clear();
            Console.Write($@"       





                                                                 █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ ▀█▀ █ █▀█ █▄░█    █▀▀ █▀█ █▀█ █▀▄▀█
                                                                 █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ ░█░ █ █▄█ █░▀█    █▀░ █▄█ █▀▄ █░▀░█
                                                                                

                                                                               S T U D E N T  I N F O R M A T I O N

          
                                                                S U R N A M E : {surname}              

                                                          
                                                                F I R S T  N A M E : {name}


                                                                M I D D L E  N A M E : {middle_initial} 


                                                                S U F F I X (if any) : {suffix}


                                                                G E N D E R : {gender} 


                                                                B I R T H  D A T E - 

                                                                        Month : {month} 
                                                                        Day : {day}
                                                                        Year : {year}
          ");
            Console.Beep(); 
          Console.Clear();
          Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.White;
          Console.Write($@"

                                                                              =====================================================      

                                                                                        S U R N A M E : {surname}                  
                                                                                                                                   
                                                                                                                                   
                                                                                         F I R S T  N A M E : {name}               
                                                                                                                                   
                                                                                                                                   
                                                                                         M I D D L E  N A M E : {middle_initial}   
                                                                                                                                   
                                                                                                                                   
                                                                                         S U F F I X (if any) : {suffix}           
                                                                                                                                  
                                                                                                                                   
                                                                                         G E N D E R : {gender}                    
                                                                                                                                  
                                                                                                                                  
                                                                                         B I R T H  D A T E -                      
                                                                                                                                   
                                                                                         Month : {month}                          
                                                                                         Day : {day}                               
                                                                                         Year : {year}   

                                                                              =====================================================
          ");
          birthdate = $"{month}/{day}/{year}";

          Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.Magenta;
          

          Console.Write($@"


                                                                                                     N O T E 

                                                         - Kindly re-check the information above to ensure that you've inputted the correct informations. -
          ");
          run.Speak("Kind Recheck the information above to ensure that you've inputted the correct informations.");
          Proceed();

        







            



          


          }while(false);
      
            base.Display();


        }


        public static void  Proceed() {
               SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;

              do{
             Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          Console.Write(@"


                                                                                    D O  Y O U  W I S H  T O  P R O C E E D  ?


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
            Proceed();

          }


          switch(input){

            case 1: Console.Beep(); StudentPage disp2 = new StudentPage(); disp2.Display2(); break;
            case 2: Console.Beep(); Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); break;
            case 3: Console.Beep(); StudentPage disp = new StudentPage(); disp.Display(); break;
          }


        }while(false);
        }

         public static void  Proceed2() {
               SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;

              do{
                   Console.Clear();
                   Console.ResetColor();
          Console.ForegroundColor = ConsoleColor.DarkCyan;
          Console.Write(@"


                                                          - I  C E R T I F Y  T H A T  T H E  A B O V E  I N F O R M A T I O N  I S  T R U E -


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
            Proceed2();

          }


          switch(input){

            case 1: Console.Beep(); SelectCourse pc = new SelectCourse(); pc.Display(); break; 
            case 2: Console.Beep(); Thread.Sleep(100); run.Speak("Returning..."); Enroll enrl = new Enroll(); enrl.Display(); break;
            case 3: Console.Beep(); StudentPage disp = new StudentPage(); disp.Display2(); break;
          }


        }while(false);
        }

        public override void Display2()
        {

           SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;

            do{   
                  Console.ResetColor();
                  Console.Clear();
                  Console.ForegroundColor = ConsoleColor.DarkCyan;
                   Console.Write(@"       


                                                                 █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ ▀█▀ █ █▀█ █▄░█    █▀▀ █▀█ █▀█ █▀▄▀█
                                                                 █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ ░█░ █ █▄█ █░▀█    █▀░ █▄█ █▀▄ █░▀░█
                                                                                

                                                                               S T U D E N T  A D D R E S S

          
                                                                 C I T Y :


                                                                 A R E A  C O D E :  


                                                                 S T R E E T : 

                                                          
                                                                 H O U S E  N U M B E R : 


          
          ");

           Console.SetCursorPosition(patakilid - 100, Console.CursorTop - 13);
           city = Console.ReadLine().ToUpper();

           if (city == "")
           {
               Console.WriteLine("Field cannot be empty!");
               
           }


            Console.ResetColor();
             Console.ForegroundColor = ConsoleColor.DarkCyan;
                  Console.Clear();
                   Console.Write($@"       


                                                                 █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ ▀█▀ █ █▀█ █▄░█    █▀▀ █▀█ █▀█ █▀▄▀█
                                                                 █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ ░█░ █ █▄█ █░▀█    █▀░ █▄█ █▀▄ █░▀░█
                                                                                

                                                                               S T U D E N T  A D D R E S S

          
                                                                 C I T Y : {city}


                                                                 A R E A  C O D E :  


                                                                 S T R E E T : 

                                                          
                                                                 H O U S E  N U M B E R : 


          
          ");
           Console.SetCursorPosition(patakilid - 92, Console.CursorTop - 10);
           area_code = Console.ReadLine().ToUpper();

                 Console.ResetColor();
                  Console.ForegroundColor = ConsoleColor.DarkCyan;
                  Console.Clear();
                   Console.Write($@"       


                                                                 █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ ▀█▀ █ █▀█ █▄░█    █▀▀ █▀█ █▀█ █▀▄▀█
                                                                 █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ ░█░ █ █▄█ █░▀█    █▀░ █▄█ █▀▄ █░▀░█
                                                                                

                                                                               S T U D E N T  A D D R E S S

          
                                                                 C I T Y : {city}


                                                                 A R E A  C O D E : {area_code}  


                                                                 S T R E E T : 

                                                          
                                                                 H O U S E  N U M B E R : 


          
          ");
          Console.SetCursorPosition(patakilid - 97, Console.CursorTop - 7);
          street = Console.ReadLine().ToUpper();

            Console.ResetColor();
             Console.ForegroundColor = ConsoleColor.DarkCyan;
                  Console.Clear();
                   Console.Write($@"       


                                                                 █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ ▀█▀ █ █▀█ █▄░█    █▀▀ █▀█ █▀█ █▀▄▀█
                                                                 █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ ░█░ █ █▄█ █░▀█    █▀░ █▄█ █▀▄ █░▀░█
                                                                                

                                                                               S T U D E N T  A D D R E S S

          
                                                                 C I T Y : {city}


                                                                 A R E A  C O D E : {area_code}  


                                                                 S T R E E T : {street}

                                                          
                                                                 H O U S E  N U M B E R : 


          
          ");
          Console.SetCursorPosition(patakilid - 86, Console.CursorTop - 4);
          house_num = Console.ReadLine().ToUpper();

         
                  Console.Clear();
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                   Console.Write($@"       


                                                                 █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ ▀█▀ █ █▀█ █▄░█    █▀▀ █▀█ █▀█ █▀▄▀█
                                                                 █▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ ░█░ █ █▄█ █░▀█    █▀░ █▄█ █▀▄ █░▀░█
                                                                                

                                                                               S T U D E N T  A D D R E S S

          
                                                                 C I T Y : {city}


                                                                 A R E A  C O D E : {area_code}  


                                                                 S T R E E T : {street}

                                                          
                                                                 H O U S E  N U M B E R : {house_num} 


          
          ");




          // store ang credentials into string nga variable called 'Overall' then i pasa sa methods nga naka private nga lsit  //

          Overall = $"{surname}, {name}, {middle_initial}, {suffix}, {birthdate}, {gender}, {city}, {area_code}, {street}, {house_num}.";

          manage.Add(Overall);


          // call out ang function kung mo proceed ba or dili. As well as e edit // 
          Proceed2();


      


            }while(false);

            base.Display2();
        }



    public static string Tig_ila_sa_Gender(){

           if(gender == "M" || gender == "m") {
        StudentPage.gender = "MALE";
          return "MALE";
;
          }

          if(gender == "F" || gender == "f") {


            StudentPage.gender = "FEMALE";
             return "FEMALE";
       }

    return gender;
}

    

    }
}