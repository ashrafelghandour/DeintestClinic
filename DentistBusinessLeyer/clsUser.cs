
using DentistDataAccessLeyer;

namespace DentistBusinessLeyer
{

    public class ClsUser
    { 
        public ClsUser(UserDTO? userDTO, enMode mode)
        {
            Id = userDTO.UserID;
            UserName = userDTO.UserName;
            Passwred = userDTO.UserPass;
            UserType = userDTO.UserType;
            Mode = mode;
        }
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Passwred {  get; set; }
        public string UserType { get; set; }

        public enum enMode {AddNew = 0, Update =1 }
        public enMode Mode = enMode.AddNew;

        public UserDTO UDTO { get { return (new UserDTO(this.Id, this.UserName, this.Passwred, this.UserType)); } }

        public static ClsUser? GetUserByUserNameAndPass(string userName, string passwred, string userType)
        {
            UserDTO? userDTO = UserData.GetUserByUserNameAndPass(userName, passwred, userType);
            if (userDTO == null)
            {
                return null;
            } 
            return new ClsUser(userDTO,enMode.Update);
                
        }



    }
}
