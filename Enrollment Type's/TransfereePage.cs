namespace Online_Enrollment_System{

  class TransfereePage:Parent{

          private static Data user = new Data();
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
        public static string sem;
        public static string user_course;
        public static string Transferee = "yes";
        public static string input1 = "HIS";
        public static string input2 = "IT120";

        public override void Display()
        {

       
            Console.Clear();
            Console.ResetColor();

            Console.Write(@"
            
            


                                                                                                                 [ ] G I V E  T R A N S C R I P T  O F  R E C O R D S



                                                                                                                             Press any key to continue...
            ");
            Console.ReadKey();
               name = user.transferee_Firstname;
              lastname = user.transferee_Lastname;
               middle_initial = user.transferee_Middle_Initial;
                suffix = user.transferee_Suffix;
              gender = user.transferee_Gender;
              birthdate = user.transferee_Birthdate;
              city = user.transferee_City;
              area_code = user.transferee_Area_code;
              street = user.transferee_Street;
              house_num = user.transferee_House_num;
            year_lvl = user.transferee_Year_lvl;
            sem = user.Transferee_Sem;
            user_course = user.transferee_User_Course;

            Transferee_CheckStudentYearLvl.KnowTheYear();

            
            base.Display();
        }
    }
}