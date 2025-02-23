using System;
using System.Data;
using Microsoft.Data.SqlClient;
namespace  DentistDataAccessLeyer
{


    public class UserDTO
    {
        public UserDTO(int userID ,string userName, string userPass, string userType)
        {           
            UserID = userID;
            UserName = userName;
            UserPass = userPass;
            UserType = userType;
        }

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string UserType { get; set; }



    }


 
    public  class UserData
    {

        public static UserDTO? GetUserByUserNameAndPass(string userName , string UserPass, string UserType)
        { 


            try{


                using (SqlConnection con = new SqlConnection(clsUtility._ConnectionString))
                {

                    using (SqlCommand cmd = new SqlCommand("PS_Login", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@UserName", userName);
                        cmd.Parameters.AddWithValue("@UserPasswred", UserPass);
                        cmd.Parameters.AddWithValue("@UserType", UserType);
                        con.Open();


                        using (SqlDataReader red = cmd.ExecuteReader())
                        {





                            if (red.Read())
                            {

                                return new UserDTO(red.GetInt32(red.GetOrdinal("UserID")),
                                red.GetString(red.GetOrdinal("UserName")),
                                red.GetString(red.GetOrdinal("UserPasswred")),
                                red.GetString(red.GetOrdinal("UserType")));


                            }
                            else
                            {
                                return null;
                            }


                        }


                    }
                }
          
            }catch{
             return null;
            }
            

        }

    }
}
