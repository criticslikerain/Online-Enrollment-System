using System.Collections.Generic;

namespace Online_Enrollment_System{



  class Information{
    private List<string> Credentials = new List<string>();

    public void Add(string Overall) {
        Credentials.Add(Overall);
    }
}



  class Data{

  
   

       // variable for credentials sa current student // 

    
    private string id;
    private string firstname;
    private string lastname;
    private string pin;
    private string newpin = "";
    private string firstandlast ="";




      // variable for credentials sa returnee //
    private string returnee_id;
    private string returnee_firstname;
    private string returnee_lastname;
    private string returnee_pin;
    private string returnee_newpin = "";



    
      // getters ug setters sa current student  //  

   public string ID
    {
      get {return id = "2024-00001";}
      set {id = value;}

    }

    public string Firstname
    {
      get {return firstname = "Francisco";}
      set {firstname = value;}
    }

    public string Lastname
    {

      get {return lastname = "Benedicto"; }
    }

    public string Pin
    {

      get {return pin = "123456";}
      set {pin = value;}
    }

     public string Newpin
    {

      get{return newpin;}
      set{newpin = value;}
    }



          // getters ug setters sa current student  //  


    public string returnee_ID
    {
      get {return  returnee_id = "2024-00002";}
      set { returnee_id = value;}

    }

    public string returnee_Firstname
    {
      get {return returnee_firstname = "Leontina";}
   
    }

    public string returnee_Lastname
    {

      get {return returnee_lastname = "Benedicto"; }
    }

    public string returnee_Pin
    {

      get {return returnee_pin = "123456";}
      set {returnee_pin = value;}
    }

     public string returnee_Newpin
    {

      get{return returnee_newpin;}
      set{returnee_newpin = value;}
    }

     public string FirstAndLast
    {

      get{return firstandlast;}
      set{firstandlast = value;}
    }

 

  }
}


