using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestPostgres.Models;

namespace TestPostgres.Interfaces
{
    public interface IDataAccessProvider
    {
        void AddPatientRecord(Patient patient);
        void UpdatePatientRecord(Patient patient);
        void DeletePatientRecord(string id);
        Patient GetPatientSingleRecord(string id);
        List<Patient> GetPatientRecords();
        void AddUserAuthRecord(User_Auth user_Auth);
        public void AddGensetIncomingData(Genset_incoming_data insert);
        List<User_Auth> GetUser_AuthRecords();
        public User_Auth GetUserAuthSingleRecord(string email,string password);
        public Distributer_Auth GetDistributerAuthSingleRecord(string email, string password);
        public List<Genset_Relation> GetGensetRelationList(string usertype, int companyid);
        public Manufacturer_Details GetManufacturerDetailSingle(int id);
        public Distributer_Details GetDistributerDetailSingle(int id);
        public Manufacturer_Auth GetManufacturerAuthSingleRecord(string email, string password);
        public Company_Details GetCompanyDetailSingleRecord(int id);
        public List<Events> GetEventsBySrNo(string id);
        public Genset_incoming_data GetGensetIncomingDataSingleRecord(string id);
        List<Superuser_Auth> GetSuperuserAuthRecords();
        List<Manufacturer_Auth> GetManufacturerAuthRecords();
        List<Manufacturer_Details> GetManufacturerDetailsRecords();
        List<Genset_incoming_data> GetGensetIncomingDataRecords();
        List<Genset_Relation> GetGensetRelationRecords();
        List<Events> GetEventRecords();
        List<Distributer_Details> GetDistributerDetailRecords();
        List<Distributer_Auth> GetDistributerAuthRecords();
        List<Company_Details> GetCompanyDetailsRecords();
    }
}

