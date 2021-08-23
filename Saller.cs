using System;

namespace MarketPlace
{
    public class Saller : User
    {
        public Saller(int id, string name, string user, string password, DateTime birth) : base(id, name, user, password, birth){
            base.id = id;
            base.name = name;
            base.user = user;
            base.password = password;
            base.birthDate = birth;
        }
    }
}