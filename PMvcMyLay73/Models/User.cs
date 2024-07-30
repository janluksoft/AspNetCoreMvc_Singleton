
namespace PMvcMyLay73.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }

    public interface IUserService
    {
        //User? GetUser(int id);
        User? GetUser();
    }


    public class UserService : IUserService
    {
        private User caUser;
        public UserService() 
        { 
            caUser = new User();
        }
        public User GetUser()
        {
            return new User
            {
                Id = 1,
                FirstName = "Code",
                LastName = "Maze"
            };
        }

        public void SetUser(string FirstName, string LastName)
        {

        }

    }



}
