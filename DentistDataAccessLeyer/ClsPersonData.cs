using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.ComponentModel;
using System.Data;
using System.IO;

namespace DentistDataAccessLeyer
{
        public interface iPerson
        {
         public int? PersonID {get ;set;} 
        public string Name{get;set;}
         public string Email{get;set;}
        public DateTime BirthDay {get;set;}
        public string Phone{get;set;}
        public  bool gender {get;set;}

        public byte[]? Image{get;set;}

        }
    public class PersonDTO : iPerson
    {
         public PersonDTO(int? id, string name, DateTime birthday, string phone, bool gender,string email, byte[]? image)
         {
            this.PersonID = id;
            this.Name = name;
            this.BirthDay = birthday;
            this.Phone = phone;
            this.gender = gender;
            this.Email =email;
            this.Image = image;
         }
         public PersonDTO() { }

        public int? PersonID {get ;set;} 
        public string Name{get;set;}
         public string Email{get;set;}
        public DateTime BirthDay {get;set;}
        public string Phone{get;set;}
        public  bool gender {get;set;}
        public byte[]? Image{get;set;}
        


    }

    public class clsPersonData{


        public static iPerson AddNewPerson(iPerson person){
            iPerson NewPatient = person;;

            try{
              
               using (SqlConnection con = new SqlConnection(clsUtility._ConnectionString)) {
        
                using(SqlCommand cmd = new SqlCommand("SP_AddNewPerson", con))
                {
                  
                 

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", person.Name);
                    cmd.Parameters.AddWithValue("@BirthDay",person.BirthDay);
                    cmd.Parameters.AddWithValue("@Email", person.Email);
                    cmd.Parameters.AddWithValue("@gender", person.gender);
                    cmd.Parameters.AddWithValue("@Phone", person.Phone);

                        if (person.Image == null)
                            cmd.Parameters.AddWithValue("@image",System.DBNull.Value);
                         else
                            cmd.Parameters.AddWithValue("@image",person.Image);




                        con.Open();


                    object obj = cmd.ExecuteScalar();

                    if(int.TryParse(obj.ToString(), out int result )){
                       
                        NewPatient.PersonID = result ;
                        return NewPatient;
                    }
                    
                }
               }
                

            }
            catch{
                return NewPatient;

            }
             return NewPatient;
        }

        public static iPerson? Find(int PersonID,string name){

            try{
                 using (SqlConnection con = new SqlConnection(clsUtility._ConnectionString)) {
        
                using(SqlCommand cmd = new SqlCommand("SP_FindPersonUsingIDAndName", con))
                {
                  
                 

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                     cmd.Parameters.AddWithValue("@Name", name);
        
                  

                    con.Open();
                    
                    using (SqlDataReader red = cmd.ExecuteReader()){
                    
                    if(red.Read()){

                                return new PersonDTO(red.GetInt32(red.GetOrdinal("ID")),
                                    red.GetString(red.GetOrdinal("Name")),
                                    red.GetDateTime(red.GetOrdinal("Age")),
                                    red.GetString(red.GetOrdinal("Phone")),
                                    red.GetBoolean(red.GetOrdinal("BirthDay")),
                                    red.GetString(red.GetOrdinal("Email")),
                                    (byte[])red[5]
                                    ); 


                     }
                     else{
                        return null;
                     }

                    }


                   
                }
               }
            }catch{
                        return null;

            }

           
            

        }

        public static iPerson? Find(int? PersonID){

            try{
               using (SqlConnection con = new SqlConnection(clsUtility._ConnectionString)) {
        
                 using(SqlCommand cmd = new SqlCommand("SP_FindPersonUsingID", con))
                 {
                  
                 

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PersonID",PersonID);
        
                  

                    con.Open();
                    
                    using (SqlDataReader red = cmd.ExecuteReader()){
                    
                      if(red.Read()){

                           
                            return new PersonDTO(red.GetInt32(red.GetOrdinal("PersonID")), 
                                red.GetString(red.GetOrdinal("Name")),
                                red.GetDateTime(red.GetOrdinal("BirthDay")),
                                red.GetString(red.GetOrdinal("Phone")),
                                red.GetBoolean(red.GetOrdinal("gender")),
                                red.GetString(red.GetOrdinal("Email")),
                                
                                (red.IsDBNull(5))?null :(byte[])((red[5]))
);

         
                      }
                       else{
                        return null;
                       }

                    }


                   
                 }
               }
            }
            catch{
                        return null;

            }

           
            

        }
      
        public static bool UpdatePerson(iPerson person){

            try{
                 using (SqlConnection con = new SqlConnection(clsUtility._ConnectionString)) {
        
                using(SqlCommand cmd = new SqlCommand("SP_UpdatePerson", con))
                {
                  
                 

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", person.PersonID);
                    cmd.Parameters.AddWithValue("@Name", person.Name);
                    cmd.Parameters.AddWithValue("@Age", person.BirthDay);
                    cmd.Parameters.AddWithValue("@Phone", person.Phone);
                    cmd.Parameters.AddWithValue("@Gender", person.gender);
                    cmd.Parameters.AddWithValue("@Email", person.Email);

                        if (person.Image == null)
                            cmd.Parameters.AddWithValue("@image", System.DBNull.Value);
                        else

                            cmd.Parameters.AddWithValue("@image",person.Image);


                        con.Open();

                    int rewsaffected = cmd.ExecuteNonQuery();

                    if(rewsaffected >0)
                        return true;
                    
                    else
                      return false;
                    
                    

                }


                   
                
               }
            }catch{
                return false;
            }



        }

          public static bool DeletePerson(int? personID){

            try{
                 using (SqlConnection con = new SqlConnection(clsUtility._ConnectionString)) {
        
                using(SqlCommand cmd = new SqlCommand("SP_DeletePerson", con))
                {
                  
                 

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", personID);
                  

                    con.Open();

                    int rewsaffected = cmd.ExecuteNonQuery();

                    if(rewsaffected >0)
                        return true;
                    
                    else
                      return false;
                    
                    

                }


                   
                
               }
            }catch{
                return false;
            }



        }
    }  



     


}