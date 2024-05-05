namespace Online_Enrollment_System{


  class Parent{
    
    // variables sa pag interact //
    
    public static string format1;
    public static string format2;  
    public static string choice; 
    public static double input;
    public static string pin;
    public static bool logic;
    
    
     
    


  //variables nga static //
   public static int DisplayNiya = Console.WindowWidth;
    public static int displayNiya = 60;
  public static int patakilid = (DisplayNiya - displayNiya);
   public static double fee = 500;



   
  //functions para's sub classes//

    public virtual void  Display(){}
     public virtual void  Display2(){}
       public virtual void  Display3(){}
    public virtual string Authenticate(){return pin;}
    public virtual void Loading(){}
    public virtual void Loading2(){}
    public virtual void Loading3(){}
   



     public static string greet = "";
     public static string greet2= "";

         public virtual void Beep() {
            Console.Beep();
            Oras();

        }
        public virtual string Oras()
        {

          
                  DateTime time = DateTime.Now;

 

              int currentHour = time.Hour;

        if (currentHour >= 1 && currentHour < 12)
        { 
            greet = "G O O D  M O R N I N G !";
            greet2= "goodmorning!";
            OE run = new OE(); run.MainDisplay();
           

        }
        else if (currentHour >= 12 && currentHour < 17)
        {   
            greet = "G O O D  A F T E R N O O N !";
            greet2= "good afternoon!";
            OE run2 = new OE(); run2.MainDisplay();

        }
        else if (currentHour >= 17 && currentHour < 24)
        {
           greet = "G O O D  E V E N I N G !";
           greet2= "good evening!";
           OE run3 = new OE(); run3.MainDisplay();
       
        }

           return choice;
        }
  





  }
}