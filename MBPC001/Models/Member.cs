using MBPC001.DAL;
using System;
using System.Collections.Generic;

namespace MBPC001.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }        
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public Member MemberId { get; set; } // Hans wat is dit in relatie tot het hier benoemde Id?
        public string Email { get; set; }
        public DateTime Birdthdate { get; set; }
        public DateTime Memberdate { get; set; }

        public Member()
        {
             
        }
        public Member(int _id, string _lastname)
        {
            Id = _id;
            Lastname = _lastname;
        }

        public List<Member> GetMembers()
        {
            iDAL sQLDal = DALSingleton.GetInstance();
            return sQLDal.ReadMembers();
        }

        public List<Member> GetMembersWithLot()
        {
            iDAL sQLDal = DALSingleton.GetInstance();
            return sQLDal.ReadMembersWithLot();
        }

        public int GetMemeberId(Member m)
        { 
            return m.Id;
        }
    }
}
