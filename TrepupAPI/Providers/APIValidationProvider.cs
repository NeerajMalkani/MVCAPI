using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace TrepupAPI.Providers
{
    public class APIValidationProvider : IAPIValidationProvider
    {
        private readonly List<APIUser> userList = new List<APIUser>();

        public APIValidationProvider()
        {
            userList.Add(new APIUser
            {
                Name = ConfigurationManager.AppSettings["api_name"].ToString(),
                UserName = ConfigurationManager.AppSettings["api_username"].ToString(),
                Password = ConfigurationManager.AppSettings["api_password"].ToString(),
                Roles = new[] { "Admin" }
            });
        }

        public APIUser Validate(string username, string password)
        {
            return userList.FirstOrDefault(x => x.UserName == username && x.Password == password);
        }

        public List<APIUser> GetUserList()
        {
            return userList;
        }
    }

    public interface IAPIValidationProvider
    {
        APIUser Validate(string email, string password);
        List<APIUser> GetUserList();
    }

    public class APIUser
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string[] Roles { get; set; }
    }
}