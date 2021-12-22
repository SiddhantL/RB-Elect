using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestPostgres.Interfaces;
using TestPostgres.Models;

namespace TestPostgres.DataAccess
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly PostgreSqlContext _context;

        public DataAccessProvider(PostgreSqlContext context)
        {
            _context = context;
        }

        public void AddPatientRecord(Patient patient)
        {
            _context.patients.Add(patient);
            _context.SaveChanges();
        }
        public void AddUserAuthRecord(User_Auth user_Auth)
        {
            _context.User_Auth.Add(user_Auth);
            _context.SaveChanges();
        }

        public void AddGensetIncomingData(Genset_incoming_data insert)
        {
            _context.Genset_incoming_data.Add(insert);
            AlertCheck(insert);
            _context.SaveChanges();
        }
        public void AlertCheck(Genset_incoming_data insert) {
            if (insert.D1 != "0000" && insert.D1!=null) {
                Events events = new Events();
                events.Genset_Sr_No = insert.Genset_Sr_No;
                events.Timestamp = insert.Timestamp;
                events.Data_Packet = 1;
                events.Value = insert.D1;
                _context.Events.Add(events);
                _context.SaveChanges();
            }
            if (insert.D2 != "0000" && insert.D2 != null)
            {
                Events events = new Events();
                events.Genset_Sr_No = insert.Genset_Sr_No;
                events.Timestamp = insert.Timestamp;
                events.Data_Packet = 2;
                events.Value = insert.D2;
                _context.Events.Add(events);
                _context.SaveChanges();
            }
            if (insert.D3 != "0000" && insert.D3 != "1000" && insert.D3 != "2000" && insert.D3 != "3000" && insert.D3 != null)
            {
                Events events = new Events();
                events.Genset_Sr_No = insert.Genset_Sr_No;
                events.Timestamp = insert.Timestamp;
                events.Data_Packet = 3;
                events.Value = insert.D3;
                _context.Events.Add(events);
                _context.SaveChanges();
            }
            if (insert.D4 != null)
            {
                string d4 = insert.D4.Substring(0,1);
                if (d4 != "0")
                {
                    Events events = new Events();
                    events.Genset_Sr_No = insert.Genset_Sr_No;
                    events.Timestamp = insert.Timestamp;
                    events.Data_Packet = 4;
                    events.Value = insert.D4;
                    _context.Events.Add(events);
                    _context.SaveChanges();
                }
            }
            if (insert.D51 != null)
            {
                string d51 = insert.D51.Substring(0,2);
                if (d51 != "00")
                {
                    Events events = new Events();
                    events.Genset_Sr_No = insert.Genset_Sr_No;
                    events.Timestamp = insert.Timestamp;
                    events.Data_Packet = 51;
                    events.Value = insert.D51;
                    _context.Events.Add(events);
                    _context.SaveChanges();
                }
            }
        }

        public void UpdatePatientRecord(Patient patient)
        {
            _context.patients.Update(patient);
            _context.SaveChanges();
        }

        public void DeletePatientRecord(string id)
        {
            var entity = _context.patients.FirstOrDefault(t => t.id == id);
            _context.patients.Remove(entity);
            _context.SaveChanges();
        }

        public Patient GetPatientSingleRecord(string id)
        {
            return _context.patients.FirstOrDefault(t => t.id == id);
        }
        public User_Auth GetUserAuthSingleRecord(string email, string password)
        {
            return _context.User_Auth.FirstOrDefault(t => t.User_email == email && t.User_pass==password);
        }

        public Genset_Relation GetGensetRelationSingleRecord(string id)
        {
            return _context.Genset_Relation.FirstOrDefault(t => id.Equals(t.Genset_Sr_No));
        }
        public List<Genset_Relation> GetGensetRelationList(string usertype, int companyid)
        {
            if ("U".Equals(usertype))
            {
                return _context.Genset_Relation.Where(t => t.Company_ID == companyid).ToList();
            }
            else if (string.Equals("D",usertype))
            {
                return _context.Genset_Relation.Where(t => t.Distributer_ID == companyid).ToList();
            }
            else{
                return _context.Genset_Relation.Where(t => t.Manufacturer_ID == companyid).ToList();
            }
        }

        public Distributer_Auth GetDistributerAuthSingleRecord(string email, string password)
        {
            return _context.Distributer_Auth.FirstOrDefault(t => t.Distributer_email == email && t.Distributer_pass == password);
        }

        public Manufacturer_Auth GetManufacturerAuthSingleRecord(string email, string password)
        {
            return _context.Manufacturer_Auth.FirstOrDefault(t => t.Manufacturer_email == email && t.Manufacturer_pass == password);
        }

        public Company_Details GetCompanyDetailSingleRecord(int id)
        {
            return _context.Company_Details.FirstOrDefault(t => t.Company_ID == id);
        }

        public Genset_incoming_data GetGensetIncomingDataSingleRecord(string id)
        {
            return _context.Genset_incoming_data.Where(t => t.Genset_Sr_No==id).OrderByDescending(t => t.id).FirstOrDefault();
        }
        public Manufacturer_Details GetManufacturerDetailSingle(int id)
        {
            return _context.Manufacturer_Details.FirstOrDefault(t => t.Manufacturer_ID == id);
        }
        public Distributer_Details GetDistributerDetailSingle(int id)
        {
            return _context.Distributer_Details.FirstOrDefault(t => t.Distributer_ID == id);
        }
        public List<Events> GetEventsBySrNo(string id)
        {
            return _context.Events.Where(t => t.Genset_Sr_No == id).ToList();
        }
        public List<Patient> GetPatientRecords()
        {
            return _context.patients.ToList();
        }
        public List<User_Auth> GetUser_AuthRecords()
        {
            return _context.User_Auth.ToList();
        }
        public List<Superuser_Auth> GetSuperuserAuthRecords()
        {
            return _context.Superuser_Auth.ToList();
        }
        public List<Manufacturer_Details> GetManufacturerDetailsRecords()
        {
            return _context.Manufacturer_Details.ToList();
        }
        public List<Manufacturer_Auth> GetManufacturerAuthRecords()
        {
            return _context.Manufacturer_Auth.ToList();
        }
        public List<Genset_incoming_data> GetGensetIncomingDataRecords()
        {
            return _context.Genset_incoming_data.ToList();
        }
        public List<Genset_Relation> GetGensetRelationRecords()
        {
            return _context.Genset_Relation.ToList();
        }
        public List<Events> GetEventRecords()
        {
            return _context.Events.ToList();
        }
        public List<Distributer_Details> GetDistributerDetailRecords()
        {
            return _context.Distributer_Details.ToList();
        }
        public List<Distributer_Auth> GetDistributerAuthRecords()
        {
            return _context.Distributer_Auth.ToList();
        }
        public List<Company_Details> GetCompanyDetailsRecords()
        {
            return _context.Company_Details.ToList();
        }
    }
}
