using System.Speech.Synthesis;


namespace Online_Enrollment_System{


  class CheckStudentYearLvl:Parent{

    
      public BSIT bsit = new BSIT();
      public EducElem ee = new EducElem();
      public EducEnglish eeng = new EducEnglish();
      public BSME bsme = new BSME();
      public BSCE bsce = new BSCE();
      public ArtsAndScience ans = new ArtsAndScience();

        public static void KnowTheYear()
        {

          if(Online_Enrollment_System.Portal.user_course == "BSIT"){
                  BSIT1();
          }

           if(Online_Enrollment_System.Portal.user_course == "Education Elementary"){
                  ELEM();
          }

          if(Online_Enrollment_System.Portal.user_course == "Education English"){
                  ENG();
          }


           if(Online_Enrollment_System.Portal.user_course == "BSME"){
                  BSME1();
          }

            if(Online_Enrollment_System.Portal.user_course == "BSCE"){
                  BSCE1();
          }

           if(Online_Enrollment_System.Portal.user_course == "ARTS & SCIENCE"){
                  ANS();
          }


  
        }


                public static void BSIT1(){

                            SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;


          if(Online_Enrollment_System.Portal.year_lvl == "1" && Online_Enrollment_System.Portal.sem == "1"){
                    BSIT.FirstYear_SecondSem.EnlistSubjects();

          }

              if(Online_Enrollment_System.Portal.year_lvl == "1" && Online_Enrollment_System.Portal.sem == "2"){
                      BSIT.SecondYear.EnlistSubjects();
          } 





           if(Online_Enrollment_System.Portal.year_lvl == "2" && Online_Enrollment_System.Portal.sem == "1"){
                      BSIT.SecondYear_SecondSem.EnlistSubjects();
          }

           if(Online_Enrollment_System.Portal.year_lvl == "2" && Online_Enrollment_System.Portal.sem == "2"){
                      BSIT.ThirdYear.EnlistSubjects();
          }







           if(Online_Enrollment_System.Portal.year_lvl == "3" && Online_Enrollment_System.Portal.sem == "1"){
                     BSIT.ThirdYear_SecondSem.EnlistSubjects();
          }

          if(Online_Enrollment_System.Portal.year_lvl == "3" && Online_Enrollment_System.Portal.sem == "2"){
                         BSIT.FourthYear.EnlistSubjects();
          }





           if(Online_Enrollment_System.Portal.year_lvl == "4" && Online_Enrollment_System.Portal.sem == "1"){
                                    BSIT.FourthYear_SecondSem.EnlistSubjects();
          }

          if(Online_Enrollment_System.Portal.year_lvl == "4" && Online_Enrollment_System.Portal.sem == "2"){
                            run.Speak("Cant enroll student");
                            WhenLoggedIn wli = new WhenLoggedIn(); wli.Display();
          }

          }


                    public static void ELEM(){

                        SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;


          if(Online_Enrollment_System.Portal.year_lvl == "1" && Online_Enrollment_System.Portal.sem == "1"){
                       EducElem.FirstYear_SecondSem.EnlistSubjects();

          }

              if(Online_Enrollment_System.Portal.year_lvl == "1" && Online_Enrollment_System.Portal.sem == "2"){
                      EducElem.SecondYear.EnlistSubjects();
          } 





           if(Online_Enrollment_System.Portal.year_lvl == "2" && Online_Enrollment_System.Portal.sem == "1"){
                      EducElem.SecondYear_SecondSem.EnlistSubjects();
          }

           if(Online_Enrollment_System.Portal.year_lvl == "2" && Online_Enrollment_System.Portal.sem == "2"){
                      EducElem.ThirdYear.EnlistSubjects();
          }







           if(Online_Enrollment_System.Portal.year_lvl == "3" && Online_Enrollment_System.Portal.sem == "1"){
                     EducElem.ThirdYear_SecondSem.EnlistSubjects();
          }

          if(Online_Enrollment_System.Portal.year_lvl == "3" && Online_Enrollment_System.Portal.sem == "2"){
                         EducElem.FourthYear.EnlistSubjects();
          }





           if(Online_Enrollment_System.Portal.year_lvl == "4" && Online_Enrollment_System.Portal.sem == "1"){
                                    EducElem.FourthYear_SecondSem.EnlistSubjects();
          }

          if(Online_Enrollment_System.Portal.year_lvl == "4" && Online_Enrollment_System.Portal.sem == "2"){
                            run.Speak("Cant enroll student");
                            WhenLoggedIn wli = new WhenLoggedIn(); wli.Display();
          }

          }


             public static void ENG(){

                        SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;


          if(Online_Enrollment_System.Portal.year_lvl == "1" && Online_Enrollment_System.Portal.sem == "1"){
                    EducEnglish.FirstYear_SecondSem.EnlistSubjects();

          }

              if(Online_Enrollment_System.Portal.year_lvl == "1" && Online_Enrollment_System.Portal.sem == "2"){
                      EducEnglish.SecondYear.EnlistSubjects();
          } 





           if(Online_Enrollment_System.Portal.year_lvl == "2" && Online_Enrollment_System.Portal.sem == "1"){
                      EducEnglish.SecondYear_SecondSem.EnlistSubjects();
          }

           if(Online_Enrollment_System.Portal.year_lvl == "2" && Online_Enrollment_System.Portal.sem == "2"){
                      EducEnglish.ThirdYear.EnlistSubjects();
          }







           if(Online_Enrollment_System.Portal.year_lvl == "3" && Online_Enrollment_System.Portal.sem == "1"){
                     EducEnglish.ThirdYear_SecondSem.EnlistSubjects();
          }

          if(Online_Enrollment_System.Portal.year_lvl == "3" && Online_Enrollment_System.Portal.sem == "2"){
                         EducEnglish.FourthYear.EnlistSubjects();
          }





           if(Online_Enrollment_System.Portal.year_lvl == "4" && Online_Enrollment_System.Portal.sem == "1"){
                                    EducEnglish.FourthYear_SecondSem.EnlistSubjects();
          }

          if(Online_Enrollment_System.Portal.year_lvl == "4" && Online_Enrollment_System.Portal.sem == "2"){
                            run.Speak("Cant enroll student");
                            WhenLoggedIn wli = new WhenLoggedIn(); wli.Display();
          }

          }



                    public static void BSCE1(){

                        SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;


          if(Online_Enrollment_System.Portal.year_lvl == "1" && Online_Enrollment_System.Portal.sem == "1"){
                    BSCE.FirstYear_SecondSem.EnlistSubjects();

          }

              if(Online_Enrollment_System.Portal.year_lvl == "1" && Online_Enrollment_System.Portal.sem == "2"){
                      BSCE.SecondYear.EnlistSubjects();
          } 





           if(Online_Enrollment_System.Portal.year_lvl == "2" && Online_Enrollment_System.Portal.sem == "1"){
                      BSCE.SecondYear_SecondSem.EnlistSubjects();
          }

           if(Online_Enrollment_System.Portal.year_lvl == "2" && Online_Enrollment_System.Portal.sem == "2"){
                      BSCE.ThirdYear.EnlistSubjects();
          }







           if(Online_Enrollment_System.Portal.year_lvl == "3" && Online_Enrollment_System.Portal.sem == "1"){
                     BSCE.ThirdYear_SecondSem.EnlistSubjects();
          }

          if(Online_Enrollment_System.Portal.year_lvl == "3" && Online_Enrollment_System.Portal.sem == "2"){
                         BSCE.FourthYear.EnlistSubjects();
          }





           if(Online_Enrollment_System.Portal.year_lvl == "4" && Online_Enrollment_System.Portal.sem == "1"){
                                    BSCE.FourthYear_SecondSem.EnlistSubjects();
          }

          if(Online_Enrollment_System.Portal.year_lvl == "4" && Online_Enrollment_System.Portal.sem == "2"){
                            run.Speak("Cant enroll student");
                            WhenLoggedIn wli = new WhenLoggedIn(); wli.Display();
          }

          }

                              public static void BSME1(){

                        SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;


          if(Online_Enrollment_System.Portal.year_lvl == "1" && Online_Enrollment_System.Portal.sem == "1"){
                    BSME.FirstYear_SecondSem.EnlistSubjects();

          }

              if(Online_Enrollment_System.Portal.year_lvl == "1" && Online_Enrollment_System.Portal.sem == "2"){
                      BSME.SecondYear.EnlistSubjects();
          } 





           if(Online_Enrollment_System.Portal.year_lvl == "2" && Online_Enrollment_System.Portal.sem == "1"){
                      BSME.SecondYear_SecondSem.EnlistSubjects();
          }

           if(Online_Enrollment_System.Portal.year_lvl == "2" && Online_Enrollment_System.Portal.sem == "2"){
                      BSME.ThirdYear.EnlistSubjects();
          }







           if(Online_Enrollment_System.Portal.year_lvl == "3" && Online_Enrollment_System.Portal.sem == "1"){
                     BSME.ThirdYear_SecondSem.EnlistSubjects();
          }

          if(Online_Enrollment_System.Portal.year_lvl == "3" && Online_Enrollment_System.Portal.sem == "2"){
                         BSME.FourthYear.EnlistSubjects();
          }





           if(Online_Enrollment_System.Portal.year_lvl == "4" && Online_Enrollment_System.Portal.sem == "1"){
                                    BSME.FourthYear_SecondSem.EnlistSubjects();
          }

          if(Online_Enrollment_System.Portal.year_lvl == "4" && Online_Enrollment_System.Portal.sem == "2"){
                            run.Speak("Cant enroll student");
                            WhenLoggedIn wli = new WhenLoggedIn(); wli.Display();
          }

          }


                    public static void ANS(){

                        SpeechSynthesizer run = new SpeechSynthesizer();
      run.SelectVoiceByHints(VoiceGender.Female);
      run.Rate = 1;


          if(Online_Enrollment_System.Portal.year_lvl == "1" && Online_Enrollment_System.Portal.sem == "1"){
                    ArtsAndScience.FirstYear_SecondSem.EnlistSubjects();

          }

              if(Online_Enrollment_System.Portal.year_lvl == "1" && Online_Enrollment_System.Portal.sem == "2"){
                      ArtsAndScience.SecondYear.EnlistSubjects();
          } 





           if(Online_Enrollment_System.Portal.year_lvl == "2" && Online_Enrollment_System.Portal.sem == "1"){
                      ArtsAndScience.SecondYear_SecondSem.EnlistSubjects();
          }

           if(Online_Enrollment_System.Portal.year_lvl == "2" && Online_Enrollment_System.Portal.sem == "2"){
                      ArtsAndScience.ThirdYear.EnlistSubjects();
          }







           if(Online_Enrollment_System.Portal.year_lvl == "3" && Online_Enrollment_System.Portal.sem == "1"){
                     ArtsAndScience.ThirdYear_SecondSem.EnlistSubjects();
          }

          if(Online_Enrollment_System.Portal.year_lvl == "3" && Online_Enrollment_System.Portal.sem == "2"){
                         ArtsAndScience.FourthYear.EnlistSubjects();
          }





           if(Online_Enrollment_System.Portal.year_lvl == "4" && Online_Enrollment_System.Portal.sem == "1"){
                                    ArtsAndScience.FourthYear_SecondSem.EnlistSubjects();
          }

          if(Online_Enrollment_System.Portal.year_lvl == "4" && Online_Enrollment_System.Portal.sem == "2"){
                            run.Speak("Cant enroll student");
                            WhenLoggedIn wli = new WhenLoggedIn(); wli.Display();
          }
          }

    }
}