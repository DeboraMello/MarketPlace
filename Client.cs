using System;

namespace MarketPlace
{
    public class Client : User
    {
        public Client(Address delivery, Address billing, int id, string name, string user, string password, DateTime birth) : base(id, name, user, password, birth){
            this.deliveryAddress = delivery;
            this.billingAddress = billing;
            base.id = id;
            base.name = name;
            base.user = user;
            base.password = password;
            base.birthDate = birth;
        }

        public Address deliveryAddress { get; set; }
        public Address billingAddress {get; set;}
    }
}

