using MBPC001.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MBPC001.DAL
{
    public class MSSQLDAL: iDAL
    {       
        readonly string connectionString = "Data Source=.;Initial Catalog=MBPC;Integrated Security=True";

        public Member ReadMember(int id)
        {
            return ReadMembers().Find(m => m.Id == id);
        }

        public List<Member> ReadMembers()
        {
            List<Member> Members;
            Members = new List<Member>();

            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "select id, lastname from member";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var MemberDB = new Member(Int32.Parse(reader["id"].ToString()),
                                reader["lastname"].ToString());
                            Members.Add(MemberDB);
                        }
                    }
                }
            }
            return Members;
        }

        public List<Member> ReadMembersWithLot()
        {
            List<Member> Members;
            Members = new List<Member>();

            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "select distinct member.id, lastname from member, lot where vendorId = member.id order by lastname";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var MemberDB = new Member(Int32.Parse(reader["id"].ToString()),
                                reader["lastname"].ToString());
                            Members.Add(MemberDB);
                        }
                    }
                }
            }
            return Members;
        }

        public List<Lot> ReadLotMember(string _id)
        {            
            List<Lot> Lots;
            Lots = new List<Lot>();

            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "select id, memberReferenece, description from Lot where vendorId = @mid";
                    command.Parameters.AddWithValue("mid", _id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var LotDB = new Lot(Int32.Parse(reader["id"].ToString()),
                                reader["memberReferenece"].ToString(),
                                reader["description"].ToString());
                            Lots.Add(LotDB);
                        }
                    }
                }
            }
            return Lots;
        }

        public List<Lot> ReadLots()
        {
            List<Lot> Lots;
            Lots = new List<Lot>();

            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "select id, memberReferenece, description from Lot";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var LotDB = new Lot(Int32.Parse(reader["id"].ToString()),
                               reader["memberReferenece"].ToString(),
                               reader["description"].ToString());
                            Lots.Add(LotDB);
                        }
                    }
                }
            }
            return Lots;
        }
    }
}

