using System;

namespace MarketPlace
{
    public class User
    {
        public User(int id, string name, string user, string password, DateTime birth){
            this.id = id;
            this.name = name;
            this.user = user;
            this.password = password;
            this.birthDate = birth;
        }
        public int id {get; set;}

        public string name {get; set;}

        public string user {get; set;}

        public string password {get; set;}

        public DateTime birthDate {get; set;}
    }
}