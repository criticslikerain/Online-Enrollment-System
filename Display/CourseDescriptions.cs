using System.Speech.Synthesis;

namespace Online_Enrollment_System{



  class CourseDescription: Parent{

      public override void Display(){
             SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;
        
        do{
        Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.Write(@"
                    
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓






                                                   _____ ____  _    _ _____   _____ ______     _____  ______  _____  _____ _____  _____ _____ _______ _____ ____  _   _ 
                                                  / ____/ __ \| |  | |  __ \ / ____|  ____|   |  __ \|  ____|/ ____|/ ____|  __ \|_   _|  __ \__   __|_   _/ __ \| \ | |
                                                 | |   | |  | | |  | | |__) | (___ | |__      | |  | | |__  | (___ | |    | |__) | | | | |__) | | |    | || |  | |  \| |
                                                 | |   | |  | | |  | |  _  / \___ \|  __|     | |  | |  __|  \___ \| |    |  _  /  | | |  ___/  | |    | || |  | | . ` |
                                                 | |___| |__| | |__| | | \ \ ____) | |____    | |__| | |____ ____) | |____| | \ \ _| |_| |      | |   _| || |__| | |\  |
                                                  \_____\____/ \____/|_|  \_\_____/|______|   |_____/|______|_____/ \_____|_|  \_\_____|_|      |_|  |_____\____/|_| \_|

                                                  =======================================================================================================================                                                                                                                      
                                                                                                                      
                                        
                                                                                [1] Bachelor Of Science In Information Technology (BSIT)


                                                                                [2] College Of Art And Sciences 


                                                                                [3] Bachelor of Science In Education (BSED)


                                                                                [4] Bachelor of Science In Engineering (BE) 

                                                                                
                                                                                [5] Go Back



                                                                                             C H O I C E : 
        ");     


           Console.SetCursorPosition(patakilid - 67, Console.CursorTop - 1);
        choice = Console.ReadLine(); 

        while(!double.TryParse(choice, out input) || input < 1 || input > 5 ) {

          Console.ForegroundColor = ConsoleColor.Magenta;

           Console.Write(@"
                                                                                       ╔═════════════════════════╗ 
                                                                                       ║  I  N  V  A  L  I D !   ║ 
                                                                                       ╚═════════════════════════╝
          ");
          run.Speak("Invalid Input!");
          Display(); 

        } 


        switch(input) {

            case 1: Console.Beep(); InformationTechnology(); break;
            case 2: Console.Beep(); Arts_Sciences(); break;
            case 3: Console.Beep(); Education(); break;
            case 4: Console.Beep(); Engineering(); break;
            case 5: Console.Beep(); SelectCourse sc = new SelectCourse(); sc.Display(); break;
        }


       
        }while(false);
        base.Display();
      }


        public static void InformationTechnology(){
                SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;


          do{
              Console.Clear();
              Console.ResetColor();
              
              Console.Write(@"




                                                                                                 C O L L E G E  O F  C O M P U T E R  S T U D I E S 


                                                            The College of Computer Studies aims to educate students with the appropriate principles and practices of computer 

                                                            studies, preparing them for careers in software development, computing systems technology, networking infrastructure, 

                                                            information management, and for a lifetime of learning. Its goal is to produce qualified, well-rounded, equipped, and 

                                                            globally competitive information technology specialists.



                                                            P R O G R A M  O V E R V I E W :
                                                            ---------------------------------


                                                            Bachelor of Science in Information Technology (BSIT)
                                                            ====================================================


                                                            A Bachelor of Science in Information Technology (BSIT) degree is an undergraduate four-year degree with a major focus 
                                                            on computers and technology, as well as management and information theory. This degree can be can be better than a 
                                                            computer science degree for individuals interested in technology who want to concentrate on business and 
                                                            communications applications of computing.


                                                            A Bachelor of Science in Information Technology (BSIT) degree program combines networking, communications, some 
                                                            computer programming, and systems development and analysis to prepare the student to work in the field of IT Management.



                                                            Associate in Computer Technology (ACT)
                                                            ======================================

                                                            A two-year Associate in Computer Technology (ACT) program can land the graduate in a “technical” job in the field. 
                                                            This program can meet the needs of students who do not intend to become IT professionals, but want to focus on areas of 
                                                            knowledge and skills that will be beneficial to anyone wishing to enter the computer systems field in related occupations.


                                                            Students in this program learn advanced technical skills that are essential for computer and information systems jobs. 
                                                            Students also learn to understand and guide the work of their colleagues and staff and explain the work in non-technical
                                                            terms to senior managers and potential customers.


              
                                                                                                             [1] G O  B A C K 

                                                                                                             C H O I C E : 
              ");
                 Console.SetCursorPosition(patakilid - 51, Console.CursorTop - 1);
              choice = Console.ReadLine();

              while(!double.TryParse(choice, out input)|| input != 1) {

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.Write(@"
                                                                                                     ╔═════════════════════════╗ 
                                                                                                     ║  I  N  V  A  L  I D !   ║ 
                                                                                                     ╚═════════════════════════╝
               ");  
                run.Speak("Invalid input!");
                InformationTechnology();

              }
              Console.Beep();
              CourseDescription dc = new CourseDescription(); dc.Display(); 

          }while(false);
          
        }



        public static void Arts_Sciences(){
          do{
                            SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;
          
            Console.Clear(); 
            Console.ResetColor();
            Console.WriteLine(@"




                                                                                                 C O L L E G E  O F  A R T S  A N D  S C I E N C E S 



                                                            The College of Arts of Sciences seeks to gear the students to be meaningfully carved with values for application 

                                                            and inculcation in their respective communities and their personal lives.

                                                            The curriculum. through its varied major areas, trains students in:

                                                            - their future role as self-reliant citizens who are equipped with the basic methodology of learning,
                                                            - their pursuit of knowledge and competence towards relevant scientific and technological ends,
                                                            - the development of free humanistic and intellectual expressions through inquiry and research,
                                                            - serving humankind through community-oriented projects, and
                                                            - leading all others, through their chosen field of expertise, to obtain globally competitive and acknowledged competence and skills.

                                                            P R O G R A M  O V E R V I E W : 

                                                            Bachelor of Arts in Mass Communication
                                                            ======================================

                                                            The Bachelor of Arts in Mass Communication is an undergraduate four-year degree course that combines theoretical knowledge with 
                                                            adequate and significant practical exposure. Exposed to the proper communications environment, communications students acquire skills
                                                             through in-depth investigation of contemporary social issues. They are also equipped with the most basic requirements like thinking 
                                                             and analytical abilities, as well as effective writing and verbal communication skills, an eye for detail, and organizational skills.

                                                            Graduates can be journalists, public relations professionals, writers or editors of publishing houses, or practitioners in advertising, events management , 
                                                            corporate communications, marketing communication and even marketing and sales. 
                                                            Towards a career in journalism, students will develop speed and skill in seeing the overall picture of an issue and conceiving a well-balanced news story. 
                                                            Towards public relations careers, they will be able to visualize and put into practice innovative strategies for building good images and managing 
                                                            reputations of their organizations.
            



                                                                                                                 [1] G O  B A C K

                                                                                                                 C H O I C E : 
            ");
               Console.SetCursorPosition(patakilid - 48, Console.CursorTop - 2);
            choice = Console.ReadLine();

              while(!double.TryParse(choice, out input)|| input != 1) {

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.Write(@"
                                                                                                                ╔═════════════════════════╗ 
                                                                                                                ║  I  N  V  A  L  I D !   ║ 
                                                                                                                ╚═════════════════════════╝
               ");   
                run.Speak("Invalid input!");
                Arts_Sciences();

              }
              Console.Beep();
              CourseDescription dc = new CourseDescription(); dc.Display();


          }while(false);
        }



        public static void Education() {
             SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;
            do{
          Console.Clear();
          Console.ResetColor();
          Console.Write(@"




                                                                                                 C O L L E G E  O F  E D U C A T I O N


                                                            Intently concerned about man's search for being and becoming, the College of Education seeks to develop in students 

                                                            the desire to be prolific and committed members of their community as:

                                                            - A role model for teachers, a model of values in school and in the community;
                                                            - As the torch giver for learners who shall acquire functional knowledge and competence;
                                                            - As an effective provider of teaching methods, principles and techniques in various levels of learning;
                                                            - As an efficient trainer or facilitator for students who will undertake researches in schools and communities;
                                                            - As an effective motivator or adviser equipped to meet the demands of the profession; and
                                                            - As a leader who can wholeheartedly demonstrate the right working attitude in a learning process especially exhibited during field work or practice.


                                                            T H E  C O L L E G E  O F  E D U C A T I O N  O F F E R S  T H E  F O L L O W I N G
                                                            F O U R - Y E A R  C O U R S E : 

  
                                                            Bachelor of Science in Elementary Education
                                                            ===========================================

                                                            Major in:

                                                            - Pre-Elementary Education
                                                            - Elementary Education
                                                            - Special Education (SPED)


                                                            Bachelor of Science in Secondary Education
                                                            ==========================================

                                                            Major in:

                                                            - Mathematics
                                                            - English
          


                                                                                                          [1] G O  B A C K

                                                                                                          C H O I C E : 
          ");
             Console.SetCursorPosition(patakilid - 56, Console.CursorTop - 1);
          choice = Console.ReadLine();

              while(!double.TryParse(choice, out input)|| input != 1) {

                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.Write(@"
                                                                                                      ╔═════════════════════════╗ 
                                                                                                      ║  I  N  V  A  L  I D !   ║ 
                                                                                                      ╚═════════════════════════╝
               ");     
                run.Speak("Invalid input!");
                Education();

              }
              Console.Beep();
              CourseDescription dc = new CourseDescription(); dc.Display();

            }while(false);
        }

        public static void Engineering() {
             SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;

            do{
          Console.Clear();
          Console.ResetColor();
          Console.Write(@"



          
                                                                                                  C O L L E G E  O F  E N G I N E E R I N G 


                                                            The College of Engineering aims to educate students with engineering principles and actual applications in the specialized 

                                                            fields of industrial engineering, electronics and communications engineering, electrical engineering, mechanical engineering, civil engineering and

                                                            industrial technology. Its ultimate goal is to produce qualified, well-rounded, equipped, and globally competitive engineers and industrial technologists.



                                                            P R O G R A M  O V E R V I E W : 

                                                            Bachelor of Science in Industrial Engineering (BSIE)
                                                            ====================================================


                                                            A Bachelor of Science in Industrial Engineering(BSIE) degree is an undergraduate five-year degree course with emphasis 
                                                            on engineering economics, thermodynamics, human factors engineering, production planning and control, engineering 
                                                            laws, occupational safety and health, industrial organization and management, facilities planning and design,
                                                            environmental science, statistical quality control, project feasibility study, systems engineering, design project and 
                                                            management information system.


                                                            Bachelor of Science in Mechanical Engineering (BSME)
                                                            ====================================================

                                                            A Bachelor of Science in Mechanical Engineering(BSME) degree is an undergraduate five-year degree course with focus 
                                                            on basic electronics, engineering management, heat transfer, machine design, engineering economy, ac and dc 
                                                            machinery, refrigeration engineering, instrumentation and control engineering, fluid machinery, air conditioning design, 
                                                            vibration engineering, industrial processes and plant inspection, engineering laws, industrial plant design, power plant 
                                                            design, safety engineering, and computer applications.


                                                            Bachelor of Science in Civil Engineering (BSCE)
                                                            ===============================================

                                                            A Bachelor of Science in Civil Engineering(BSCE) degree is an undergraduate five-year degree course focusing on soil 
                                                            mechanics, hydraulics, theory of structures, route surveying, construction materials and testing, engineering economy, 
                                                            hydrology, highway engineering, engineering management, timber design, autocad, reinforced concrete design, 
                                                            engineering laws, steel design, and construction method and project management.


                                                                                                         [1] G O  B A C K 

                                                                                                         C H O I C E :     
          ");
           Console.SetCursorPosition(patakilid - 57, Console.CursorTop - 1);
          choice = Console.ReadLine();

              while(!double.TryParse(choice, out input)|| input != 1) {

                Console.ForegroundColor = ConsoleColor.Magenta; 

                Console.Write(@"
                                                                                                      ╔═════════════════════════╗ 
                                                                                                      ║  I  N  V  A  L  I D !   ║ 
                                                                                                      ╚═════════════════════════╝
               ");     
                run.Speak("Invalid input!");
                Engineering();

              }
              Console.Beep();
             CourseDescription dc = new CourseDescription(); dc.Display();

            }while(false);
        }

  }
}
