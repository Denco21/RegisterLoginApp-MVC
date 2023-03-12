using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Services
{
    public class SecurityService
    {
        //List<UserModel> knownUsers = new List<UserModel>();

        UserDAO userDAO = new UserDAO(); 

        public SecurityService()
        {
            //knownUsers.Add(new UserModel { Id = 0, UserName = "BillGates", Password = "bigbucks" });
            //knownUsers.Add(new UserModel { Id = 1, UserName = "MarieCurie", Password = "radioactive" });
            //knownUsers.Add(new UserModel { Id = 2, UserName = "WatsonCrick", Password = "dna" });
            //knownUsers.Add(new UserModel { Id = 3, UserName = "AlexanderFlemming", Password = "penicillin" });
        }

        public bool IsValid(UserModel user)
        {
            return userDAO.FindUserByNameAndPassword(user);
            //return true if founf in the list
            //return knownUsers.Any(x  => x.UserName == user.UserName && x.Password == user.Password);
        }
    }
} 
