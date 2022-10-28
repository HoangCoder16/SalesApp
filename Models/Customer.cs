using System;
using System.Collections.Generic;
namespace Models
{
    public class Customer : Person, IComparable<Customer>
    {
        public string CustomerType { get; set; }
        public int Point { get; set; }
        public DateTime CreateTime { get; set; }
        public string Email { get; set; }
        public string PathCustomerPicture { get; set; }
        public Customer() { }


        public Customer(string PersonId) {
            this.PersonId = PersonId;
        }

        public Customer(string customerType, int point, DateTime createTime, string email,string pathCustomerPicture)
        {
            CustomerType = customerType;
            Point = point;
            CreateTime = createTime;
            Email = email;
            PathCustomerPicture = pathCustomerPicture;
        }

        public Customer(string personId, string fullName, DateTime birthDate,
            string address, string phoneNumber, string customerType,
            int point, DateTime createTime, string email,string pathCustomerPicture) :
            base(personId, fullName, birthDate, address, phoneNumber)
        {
            CustomerType = customerType;
            Point = point;
            CreateTime = createTime;
            Email = email;
            PathCustomerPicture = pathCustomerPicture;
        }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   base.Equals(obj) &&
                   PersonId == customer.PersonId;
        }

       /* public override int GetHashCode()
        {
            int hashCode = 2079290131;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PersonId);
            return hashCode;
        }*/

        public int CompareTo(Customer other)
        {
            return PersonId.CompareTo(other.PersonId);
        }
    }
}
