using MBPC001.Models;
using System.Collections.Generic;

namespace MBPC001.DAL
{
    public interface iDAL
    {
        // data access layer heeft weet van de BusinessLayer (Models) en kan daarom objecten uit het model gebruiken (zie ook usings)
        // interface geeft aan wat je in de DAL verwacht

        Member ReadMember(int id);
        List<Member> ReadMembers();
        List<Member> ReadMembersWithLot();
        List<Lot> ReadLotMember(string _id);
        List<Lot> ReadLots();

        void CreateMember(Member member);
    }
}
