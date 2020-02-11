using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PayRoll.Pages.DepartmentMaster
{
    public class DepartmentRepo
    {
        private int department_id;
        private string department_code;
        private string department_formula;
        private int arrange_order;

        public DepartmentRepo()
        {
            
        }

        public DepartmentRepo(int _departmentId,string _departmentCode,string _departmentFormula,int _arrangeOrder)
        {
            department_id = _departmentId;
            department_code = _departmentCode;
            department_formula = _departmentFormula;
            arrange_order = _arrangeOrder;
        }

        public int DepartmentId
        {
            get => department_id;
            set => department_id = value;
        }

        public string DepartmentName { get; set; }

        public string DepartmentCode
        {
            get => department_code;
            set => department_code = value;
        }

        public string DepartmentFormula
        {
            get => department_formula;
            set => department_formula = value;
        }

        public int ArrangeOrder
        {
            get => arrange_order;
            set => arrange_order = value;
        }
    }
}