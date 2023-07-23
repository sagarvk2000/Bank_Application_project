using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    public class User_Details
    {
        public int User_id { get; set; }
        public string User_Name { get; set; }
        public string User_Password { get; set; }
        public int Contact { get; set; }
        public int Role_id { get; set; }
    }
    public class User_CRUD
    {
        private List<User_Details> users;
        // private List<Role> roles;
        public User_CRUD()
        {
            users = new List<User_Details>();
            users.Add(new User_Details { User_id = 101, User_Name = "ADMIN", User_Password = "admin444", Contact = 555555555, Role_id = 1 });
        }
        public void AddUser(User_Details user)
        {
            user.Role_id = 2;
            users.Add(user);
        }
        public List<User_Details> GetUser_Details()
        {
            return users;
            
        }
        public int Login(int user_id, string password)
        {
            int Role_id = 0;
            foreach (User_Details user in users)
            {
                if (user.User_id == user_id && user.User_Password == password)
                {
                    Role_id = user.Role_id;
                    break;
                }
            }
            return Role_id;
        
        }
        
    }


}
