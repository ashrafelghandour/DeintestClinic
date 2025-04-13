using System.Collections;
using System.Collections.Immutable;
using System.Data;
using DentistDataAccessLeyer.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

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
                using (var context = new AppDBContext())
                {

                   var  StateNumber = 0 ;

                    StateNumber = context.States.FromSqlRaw($"select * from States where States.Name = '{Name}'").First().StateId;


                    return StateNumber;
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
                using (var context = new AppDBContext()) {


                    var StateName = context.States.FirstOrDefault(s => s.StateId == ID).Name;
                    
                    return StateName == null? "" : StateName;
                }
            }
            catch
            {
                return "";
            }
            return "";
        }
        public static int AddStateName(string state_Name){

            try
            {
                //SqlConnection con = new SqlConnection(clsUtility._ConnectionString);

                //  SqlCommand command = new SqlCommand("SP_AddState", con);

                //  command.CommandType = System.Data.CommandType.StoredProcedure;

                //  command.Parameters.AddWithValue("@state_Name", state_Name);

                //  con.Open();
                // int result = 0;

                //  object obj = command.ExecuteScalar();

                //  if(obj   == null|| int.TryParse(obj.ToString(),out  result)){

                //     if(result != 0  ){
                //        return result;
                //     }
                //  }
                //  else{
                //    return 0;
                //  }
               
                using (var context = new AppDBContext()) {

                     context.States.Add(new Eintitis.State { Name = state_Name });
                  return  context.SaveChanges();

                }



            }
            catch
            {
              return -1;
            }

       }

       public static IEnumerable<string> GetAllStates(){

          try{

                //SqlConnection con = new SqlConnection(clsUtility._ConnectionString);

                //SqlCommand comd = new SqlCommand("SP_GetAllStates",con);

                // comd.CommandType = CommandType.StoredProcedure;

                //con.Open();

                //  using(SqlDataReader reader = comd.ExecuteReader()){

                //     while(reader.Read()){
                //            AllStates.Add(reader.GetString(reader.GetOrdinal("Name")));
                //     }

                //   return AllStates;

                // }


                var context = new AppDBContext();
                 
                    return context.States.Select(s=>s.Name);

                







          }
          catch{
                return null;
          }
              

          

       }

       public static bool DeleteState(string State_Name){
         try{

                //   using(SqlConnection con = new SqlConnection(clsUtility._ConnectionString)){

                //   using (SqlCommand comd = new SqlCommand("SP_DeleteState",con)){

                //     comd.CommandType = CommandType.StoredProcedure;

                //      comd.Parameters.AddWithValue("@StateName",State_Name);

                //       con.Open();

                //        int rowaffected = comd.ExecuteNonQuery();

                //         if(rowaffected>0){
                //          return true;
                //         }
                //        else{
                //         return false;
                //        }

                //   }
                //   }

                using (var context = new AppDBContext()) {

                    context.States.Remove(new Eintitis.State{Name =State_Name });
                   return context.SaveChanges() >= 1? true : false ;
                }


            }
            catch
            {
                return false;


            }

          
      }


    }
}