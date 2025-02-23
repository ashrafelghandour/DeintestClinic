using System.Data;
using DentistDataAccessLeyer;

namespace DentistBusinessLeyer
{
    public class clsState
    {
      
       public clsState(int iD, string state_Name ,enMode mode = enMode.AddNewPatiot)
        {
            ID = iD;
            StateName = state_Name;
            Mode = mode;
        }

        public int ID {get;set;}
        public string StateName{get;set;}

        public enum enMode{AddNewPatiot = 0 , UpdatePationt = 1}

       public enMode Mode = enMode.AddNewPatiot;

       public StateDTO PationtDTO {get {return new StateDTO(this.ID,this.StateName); }}
         
       
       public static int AddStateName(string state_Name){
        return clsStateData.AddStateName(state_Name);
       }
       public static SortedSet<string> GetAllStates(){
        return clsStateData.GetAllStates();
       }

       public static bool DeleteState(string state_Name){
        return clsStateData.DeleteState(state_Name);
       }
        public static int GetStateByName(string Name)
        {
            return clsStateData.GetStateByName(Name);
        }
        public static string GetStateByID(int ID)
        {
            return clsStateData.GetStateByID(ID);
        }
    }
}