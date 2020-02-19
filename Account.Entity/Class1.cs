using System;

namespace Account.Entity
{
    public class Data
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Dob { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public Data(string name, string gender, string email, string dob, string phone, string password)
        {
            this.Name = name;
            this.Gender = gender;
            this.Dob = dob;
            this.Email = email;
            this.Password = password;
            this.Phone = phone;
        }

    }
    
}
