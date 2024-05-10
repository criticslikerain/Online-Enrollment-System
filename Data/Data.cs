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
    private string mi;
    private string suffix;
    private string gender;
    private string birthdate;
    private string city;
    private string area_code;
    private string street;
    private string house_num;
    private string year_lvl;
    private string pin;
    private string newpin = "";
    private string firstandlast ="";




      // variable for credentials sa returnee //
    private string returnee_id;
    private string returnee_firstname;
    private string returnee_lastname;
    private string returnee_mi;
    private string returnee_suffix;
    private string returnee_gender;
    private string returnee_birthdate;
    private string returnee_city;
    private string returnee_area_code;
    private string returnee_street;
    private string returnee_house_num;
    private string returnee_year_lvl;
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


    public string Middle_Initial 
    {
      get {return mi = "B.";}
      set {mi = value;}
    }

    public string Suffix
    {

      get {return suffix = "N/A";}
      set {suffix = value;}
    }


    public string Gender
    {

      get {return gender = "MALE";}
      set {gender = value;}
    }


    public string Birthdate
    {
      get {return birthdate = "02/12/1939";}
      set {birthdate = value;}
    }

    public string City 
    {
      get {return city = "Cadiz City, Negros Occidental";}
      set {city = value;}
    }

    public string Area_code
    {
      get{return area_code = "7014";}
      set{area_code = value;}
    }

    public string Street
    {
      get{return street = "Stop aguinaldo";}
      set{street = value;}

    }


    public string House_num
    {
      get{return house_num = "78215";}
      set{house_num = value;}

    }


    public string Year_lvl
    {

      get {return year_lvl = "2";}
      set {year_lvl =value;}
    }


          // getters ug setters sa returnee student  //  


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

     public string Returnee_Middle_Initial 
    {
      get {return returnee_mi = "M.";}
      set {returnee_mi = value;}
    }

    public string Returnee_Suffix
    {

      get {return returnee_suffix = "N/A";}
      set {returnee_suffix = value;}
    }


    public string Returnee_Gender
    {

      get {return returnee_gender = "FEMALE";}
      set {returnee_gender = value;}
    }


    public string Returnee_Birthdate
    {
      get {return returnee_birthdate = "05/17/1942";}
      set {returnee_birthdate = value;}
    }

    public string Returnee_City 
    {
      get {return returnee_city = "Sagay City, Negros Occidental";}
      set {returnee_city = value;}
    }

    public string Returnee_Area_code
    {
      get{return returnee_area_code = "5014";}
      set{returnee_area_code = value;}
    }

    public string Returnee_Street
    {
      get{return returnee_street = "Stop aguinaldo";}
      set{returnee_street = value;}

    }


    public string Returnee_House_num
    {
      get{return returnee_house_num = "11215";}
      set{returnee_house_num = value;}

    }


    public string Returnee_Year_lvl
    {

      get {return returnee_year_lvl = "2";}
      set {returnee_year_lvl =value;}
    }


 

  }
}


