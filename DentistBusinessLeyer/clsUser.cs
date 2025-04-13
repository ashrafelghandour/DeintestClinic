
using DentistDataAccessLeyer;
using DentistDataAccessLeyer.Eintitis;

namespace DentistBusinessLeyer
{

    public class ClsUser
    { 
        public ClsUser(User user, enMode mode)
        {
            Id = user.UserId;
            UserName = user.UserName;
            Passwred = user.UserPasswred;
            UserType = user.UserType;
            Mode = mode;
        }
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Passwred {  get; set; }
        public string UserType { get; set; }

        public enum enMode {AddNew = 0, Update =1 }
        public enMode Mode = enMode.AddNew;

        public User UDTO { get { return new User { UserId = this.Id, UserName = this.UserName, UserPasswred = this.Passwred, UserType = this.UserType }; } }

        public static ClsUser? GetUserByUserNameAndPass(string userName, string passwred, string userType)
        {
            User? userDTO = UserData.GetUserByUserNameAndPass(userName, passwred, userType);
            if (userDTO == null)
            {
                return null;
            } 
            return new ClsUser(userDTO,enMode.Update);
                
        }



    }
}
