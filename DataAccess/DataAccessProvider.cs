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
