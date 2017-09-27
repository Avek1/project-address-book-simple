using AddressBook.Domain;
using AddressBook.Models.Requests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WikiDataProvider.Data;
using WikiDataProvider.Data.Extensions;
using WikiDataProvider.Data.Interfaces;

namespace AddressBook.Services
{
    public class ContactService : BaseService
    {
        public static int Insert(ContactAddRequest model)
        {
            int id = 0;
            DataProvider.ExecuteNonQuery(GetConnection, "dbo.Person_Insert",
                inputParamMapper: delegate (SqlParameterCollection paramCollection)
                {
                    paramCollection.AddWithValue("@FirstName", model.FirstName);
                    paramCollection.AddWithValue("@LastName", model.LastName);
                    paramCollection.AddWithValue("@Email", model.Email);
                    paramCollection.AddWithValue("@Phone", model.Phone);
                    paramCollection.AddWithValue("@Address1", model.Address1);
                    paramCollection.AddWithValue("@Address2", model.Address2);
                    paramCollection.AddWithValue("@City", model.City);
                    paramCollection.AddWithValue("@State", model.State);
                    paramCollection.AddWithValue("@PostalCode", model.PostalCode);
                    paramCollection.AddWithValue("@Country", model.Country);

                    SqlParameter p = new SqlParameter("@Id", SqlDbType.Int);
                    p.Direction = System.Data.ParameterDirection.Output;

                    paramCollection.Add(p);
                }, returnParameters: delegate (SqlParameterCollection param)
                {
                    int.TryParse(param["@Id"].Value.ToString(), out id);
                }
                );
            return id;
        }

        public static void Update(ContactUpdateRequest model)
        {
            DataProvider.ExecuteNonQuery(GetConnection, "dbo.Person_Update",
                inputParamMapper: delegate (SqlParameterCollection paramCollection)
                {
                    paramCollection.AddWithValue("@Id", model.Id);
                    paramCollection.AddWithValue("@FirstName", model.FirstName);
                    paramCollection.AddWithValue("@LastName", model.LastName);
                    paramCollection.AddWithValue("@Email", model.Email);
                    paramCollection.AddWithValue("@Phone", model.Phone);
                    paramCollection.AddWithValue("@Address1", model.Address1);
                    paramCollection.AddWithValue("@Address2", model.Address2);
                    paramCollection.AddWithValue("@City", model.City);
                    paramCollection.AddWithValue("@State", model.State);
                    paramCollection.AddWithValue("@PostalCode", model.PostalCode);
                    paramCollection.AddWithValue("@Country", model.Country);
                }
                );
            return;
        }

        public static Contact SelectById(int id)
        {
            Contact contact = null;

            DataProvider.ExecuteCmd(GetConnection, "dbo.Person_SelectById",
                inputParamMapper: delegate (SqlParameterCollection paramCollection)
                {
                    paramCollection.AddWithValue("@Id", id);
                },
                map: delegate (IDataReader reader, short set)
                {
                    contact = new Contact();
                    int startingIndex = 0;

                    contact.Id = reader.GetSafeInt32(startingIndex++);
                    contact.FirstName = reader.GetSafeString(startingIndex++);
                    contact.LastName = reader.GetSafeString(startingIndex++);
                    contact.Email = reader.GetSafeString(startingIndex++);
                    contact.Phone = reader.GetSafeString(startingIndex++);
                    contact.Address1 = reader.GetSafeString(startingIndex++);
                    contact.Address2 = reader.GetSafeString(startingIndex++);
                    contact.City = reader.GetSafeString(startingIndex++);
                    contact.State = reader.GetSafeString(startingIndex++);
                    contact.PostalCode = reader.GetSafeString(startingIndex++);
                    contact.Country = reader.GetSafeString(startingIndex++);
                },

                returnParameters: null,

                cmdModifier: null
                );
            return contact;
        }

        public static List<Contact> SelectAll()
        {
            List<Contact> list = new List<Contact>();

            DataProvider.ExecuteCmd(GetConnection, "dbo.Person_SelectAll",
                inputParamMapper: delegate (SqlParameterCollection paramCollection)
                {
                },
                map: delegate (IDataReader reader, short set)
                {
                    Contact c = new Contact();

                    int startingIndex = 0;
                    c.Id = reader.GetSafeInt32(startingIndex++);
                    c.FirstName = reader.GetSafeString(startingIndex++);
                    c.LastName = reader.GetSafeString(startingIndex++);
                    c.Email = reader.GetSafeString(startingIndex++);
                    c.Phone = reader.GetSafeString(startingIndex++);
                    c.Address1 = reader.GetSafeString(startingIndex++);
                    c.Address2 = reader.GetSafeString(startingIndex++);
                    c.City = reader.GetSafeString(startingIndex++);
                    c.State = reader.GetSafeString(startingIndex++);
                    c.PostalCode = reader.GetSafeString(startingIndex++);
                    c.Country = reader.GetSafeString(startingIndex++);

                    list.Add(c);
                },

                returnParameters: null,

                cmdModifier: null

                );

            return list;
        }

        public static void Delete(int id)
        {
            DataProvider.ExecuteNonQuery(GetConnection, "dbo.Person_Delete",
                inputParamMapper: delegate (SqlParameterCollection paramCollection)
                {
                    paramCollection.AddWithValue("@Id", id);
                }
                );
            return;
        }
    }
}