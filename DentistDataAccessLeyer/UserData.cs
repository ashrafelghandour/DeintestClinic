using DentistDataAccessLeyer.Data;
using DentistDataAccessLeyer.Eintitis;

namespace DentistDataAccessLeyer
{


   
    public class UserData
    {

        public static User? GetUserByUserNameAndPass(string userName, string UserPass, string UserType)
        {


            try {


                using (var dbcontext = new AppDBContext())
                {


                    var users = dbcontext.Users.FirstOrDefault(u => u.UserName == userName
                    && u.UserPasswred == UserPass && u.UserType == UserType);
                    return users == null ? null : users;

                }

            } catch {
                return null;
            }


        }

    } 
}
