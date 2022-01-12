using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Models
{
    public class JobRequisition
    {
        [Key]
        public virtual Guid requisitionId { get; set; }
        public virtual DateTime requestDate { get; set; }
        public virtual int requestTypeId { get; set; }
        public virtual int departmentId { get; set; }
        public virtual string locationAddress { get; set; }
        public virtual int jobCategoryId { get; set; }
        public virtual string jobTitle { get; set; }
        public virtual decimal salary { get; set; }
        public virtual string jobDescription { get; set; }
        public virtual string qualification { get; set; }
        public virtual bool isOpen { get; set; }
        public virtual bool isApproved { get; set; }
        public virtual DateTime closingDate { get; set; }
        public virtual string deleted_by { get; set; }
        public virtual DateTime? deleted_date { get; set; }
        public virtual bool is_deleted { get; set; }
    }

    public class JobRequisitionList_vw
    {
        public virtual Guid requisitionId { get; set; }
        public virtual string job_category_desc { get; set; }
        public virtual string jobTitle { get; set; }
        public virtual string jobDescription { get; set; }
        public virtual string qualification { get; set; }
        public virtual string request_type_desc { get; set; }
        public virtual string department_desc { get; set; }
        public virtual string locationAddress { get; set; }
        public virtual bool isOpen { get; set; }
        public virtual bool isApproved { get; set; }
        public virtual DateTime requestDate { get; set; }
        public virtual DateTime closingDate { get; set; }
    }

    public class JobClassification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int jobClassificationId { get; set; }
        [StringLength(10)]
        public virtual string occupationalServCode { get; set; }
        [StringLength(200)]
        public virtual string occupationalDesc { get; set; } 
        [StringLength(10)]
        public virtual string occupationalGrpCode { get; set; }
        [StringLength(200)]
        public virtual string occupationalGrpDesc { get; set; }
        [StringLength(20)]
        public virtual string classCode { get; set; }
        [StringLength(200)]
        public virtual string classDesc { get; set; }
        public virtual int salary_grade { get; set; }
        public virtual bool is_active { get; set; }
    }
}
