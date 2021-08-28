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
        List<User_Auth> GetUser_AuthRecords();
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

