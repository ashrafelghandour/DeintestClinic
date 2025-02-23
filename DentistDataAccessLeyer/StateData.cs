using System.Data;
using Microsoft.Data.SqlClient;

namespace DentistDataAccessLeyer
{

    public class StateDTO{
        public StateDTO(int iD, string state_Name)
        {
            ID = iD;
            State_Name = state_Name;
        }

        public int ID {get;set;}
        public string State_Name{get;set;}
    }
    public class clsStateData
    {
            
          public static int GetStateByName(string Name)
          {
            try
            {
                SqlConnection con = new SqlConnection(clsUtility._ConnectionString);

                SqlCommand command = new SqlCommand("SP_GetStateByName", con);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StateName", Name);

                con.Open();
                int result = 0;

                object obj = command.ExecuteScalar();

                if (obj == null || int.TryParse(obj.ToString(), out result))
                {

                    if (result != 0)
                    {
                        return result;
                    }
                }
                else
                {
                    return 0;
                }






            }
            catch
            {
                return 0;
            }
            return 0;
          }

        public static string GetStateByID(int ID)
        {
            try
            {
                SqlConnection con = new SqlConnection(clsUtility._ConnectionString);

                SqlCommand command = new SqlCommand("select States.Name from States where StateID = @StateID", con);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StateID", ID);

                con.Open();

                object obj = command.ExecuteScalar();

                if (obj == null  )
                {
                 string result =  obj.ToString();
                    
                        return result;
                    
                }
                else
                {
                    return "";
                }






            }
            catch
            {
                return "";
            }
            return "";
        }
        public static int AddStateName(string state_Name){
         
         try{
            SqlConnection con = new SqlConnection(clsUtility._ConnectionString);

              SqlCommand command = new SqlCommand("SP_AddState", con);

              command.CommandType = System.Data.CommandType.StoredProcedure;
              
              command.Parameters.AddWithValue("@state_Name", state_Name);
              
              con.Open();
             int result = 0;
 
              object obj = command.ExecuteScalar();

              if(obj   == null|| int.TryParse(obj.ToString(),out  result)){
                  
                 if(result != 0  ){
                    return result;
                 }
              }
              else{
                return 0;
              }



  
         
      
        }
        catch{
            return -1;
        }
                    return -1;

       }

       public static SortedSet<string> GetAllStates(){

            SortedSet<string>? AllStates = new SortedSet<string>();

          try{

            SqlConnection con = new SqlConnection(clsUtility._ConnectionString);

            SqlCommand comd = new SqlCommand("SP_GetAllStates",con);

             comd.CommandType = CommandType.StoredProcedure;
             
            con.Open();

              using(SqlDataReader reader = comd.ExecuteReader()){

                 while(reader.Read()){
                        AllStates.Add(reader.GetString(reader.GetOrdinal("Name")));
                 }
               
               return AllStates;

             }

             

           

          }
          catch{
                return AllStates = null;
          }
              

          

       }

       public static bool DeleteState(string State_Name){
         try{

            using(SqlConnection con = new SqlConnection(clsUtility._ConnectionString)){

            using (SqlCommand comd = new SqlCommand("SP_DeleteState",con)){

              comd.CommandType = CommandType.StoredProcedure;
 
               comd.Parameters.AddWithValue("@StateName",State_Name);
             
                con.Open();
                 
                 int rowaffected = comd.ExecuteNonQuery();

                  if(rowaffected>0){
                   return true;
                  }
                 else{
                  return false;
                 }

            }

             
            }
           

         }
          catch{
                  return false;


            }

          
      }


    }
}