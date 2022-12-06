using System;
using System.Collections.Generic;

#nullable disable

namespace Day15Task.Models
{
    public partial class Assignment
    {
        public int AssignmentId { get; set; }
        public int? EmployeeId { get; set; }
        public string ActionCode { get; set; }
        public string ActionReasonCode { get; set; }
        public DateTime? ActualTerminationDate { get; set; }
        public string AssignmentCategory { get; set; }
        public string AssignmentName { get; set; }
        public int? AssignmentNumber { get; set; }
        public DateTime? AssignmentProjectEndDate { get; set; }
        public string AssignmentStatus { get; set; }
        public int? AssignmentTypeId { get; set; }
        public int? BusinessUnitId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string DefaultExpenseAccount { get; set; }
        public int? DepartmentId { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public DateTime? EffectiveStartDate { get; set; }
        public string EndTime { get; set; }
        public int? GradeId { get; set; }
        public int? GradeLadderId { get; set; }
        public int? LegalEntityId { get; set; }
        public int? ManagerAssignmentId { get; set; }
        public int? LocationId { get; set; }
        public int? ManagerId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
