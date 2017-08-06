using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWcfService
{
    [ServiceContract]
    public interface IService1
    {
      [OperationContract]
      void employeeRecord(empData ed);
     }
    [DataContract]
    public class empData
    {
        int EmpID;
        string FName;
        string LName;
        int Age;
        string Dep;
        string DOJ;
        int EmpSalary;
        string EmpInfo;

        [DataMember]
        public int EmployeeNo
        {
            set { EmpID = value; }
            get { return EmpID; }
        }

        [DataMember]
        public string FirstName
        {
            set { FName = value; }
            get { return FName; }
        }

        [DataMember]
        public string LastName
        {
            set { LName = value; }
            get { return LName; }
        }

        [DataMember]
        public int EmpAge
        {
            set { Age = value; }
            get { return Age; }
        }

        [DataMember]
        public string EmpDepartement
        {
            set { Dep = value; }
            get { return Dep; }
        }

        [DataMember]
        public string EmpDateOFJoining
        {
            set { DOJ = value; }
            get { return DOJ; }
        }

        [DataMember]
        public int EmpBasicSalary
        {
            set { EmpSalary = value; }
            get { return EmpSalary; }
        }

        [DataMember]
        public string EmployeeInfo
        {
            set { EmpInfo = value; }
            get { return EmpInfo; }
        }

    }

    }

