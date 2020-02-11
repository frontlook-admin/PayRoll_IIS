using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayRoll.Pages.EmployeeMaster
{
    public class EmployeeMasterRepo
    {
        
        public int id;
        public int aadhar_no;
        public string employee_picture;
        public string adult_registration_no;
        public string employee_code;
        public string pf_no;
        public string employee_name;
        public string father_husband_name;
        public string gender;
        public string permanent_address;
        public string present_address;
        public string nominee;
        public string mobile_no;
        public string shift;
        public string designation;
        public string department;
        public string pan_no;
        public string grade;
        public string category;
        public string basic;
        public string off_day;
        public DateTime date_of_joining;
        public DateTime date_of_birth;
        public DateTime last_working_date;
        public bool active;

        public EmployeeMasterRepo()
        {
            
        }

        public EmployeeMasterRepo(int _id,int _aadharNo,string _employeePicture,string _adultRegistrationNo,
            string _employeeCode,string _pfNo,string _employeeName,string _fatherHusbandName,string _gender,
            string _permanentAddress,string _presentAddress,string _nominee,string _mobileNo,string _shift,
            string _designation,string _department,string _panNo,string _grade,string _category,string _basic,
            string _offDay,DateTime _dateOfJoining,DateTime _dateOfBirth,DateTime _lastWorkingDate,bool _active)
        {
            id = _id;
            aadhar_no = _aadharNo;
            employee_picture = _employeePicture;
            adult_registration_no = _adultRegistrationNo;
            employee_code = _employeeCode;
            pf_no = _pfNo;
            employee_name = _employeeName;
            father_husband_name = _fatherHusbandName;
            gender = _gender;
            permanent_address = _permanentAddress;
            present_address = _presentAddress;
            nominee = _nominee;
            mobile_no = _mobileNo;
            shift = _shift;
            designation = _designation;
            department = _department;
            pan_no = _panNo;
            grade = _grade;
            category = _category;
            basic = _basic;
            off_day = _offDay;
            date_of_joining = _dateOfJoining;
            date_of_birth = _dateOfBirth;
            last_working_date = _lastWorkingDate;
            active = _active;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int AadharNo
        {
            get => aadhar_no;
            set => aadhar_no = value;
        }

        public string EmployeePicture
        {
            get => employee_picture;
            set => employee_picture = value;
        }

        public string AdultRegistrationNo
        {
            get => adult_registration_no;
            set => adult_registration_no = value;
        }

        public string EmployeeCode
        {
            get => employee_code;
            set => employee_code = value;
        }

        public string PfNo
        {
            get => pf_no;
            set => pf_no = value;
        }

        public string EmployeeName
        {
            get => employee_name;
            set => employee_name = value;
        }

        public string FatherHusbandName
        {
            get => father_husband_name;
            set => father_husband_name = value;
        }

        public string Gender
        {
            get => gender;
            set => gender = value;
        }

        public string PermanentAddress
        {
            get => permanent_address;
            set => permanent_address = value;
        }

        public string PresentAddress
        {
            get => present_address;
            set => present_address = value;
        }

        public string Nominee
        {
            get => nominee;
            set => nominee = value;
        }

        public string MobileNo
        {
            get => mobile_no;
            set => mobile_no = value;
        }

        public string Shift
        {
            get => shift;
            set => shift = value;
        }

        public string Designation
        {
            get => designation;
            set => designation = value;
        }

        public string Department
        {
            get => department;
            set => department = value;
        }

        public string PanNo
        {
            get => pan_no;
            set => pan_no = value;
        }

        public string Grade
        {
            get => grade;
            set => grade = value;
        }

        public string Category
        {
            get => category;
            set => category = value;
        }

        public string Basic
        {
            get => basic;
            set => basic = value;
        }

        public string OffDay
        {
            get => off_day;
            set => off_day = value;
        }

        public DateTime DateOfJoining
        {
            get => date_of_joining;
            set => date_of_joining = value;
        }

        public DateTime DateOfBirth
        {
            get => date_of_birth;
            set => date_of_birth = value;
        }

        public DateTime LastWorkingDate
        {
            get => last_working_date;
            set => last_working_date = value;
        }

        public bool Active
        {
            get => active;
            set => active = value;
        }
    }
}