using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Models
{
    public class lib_region
    {
        [Key]
        public virtual string region_code { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int rowid { get; set; }
        public virtual string region_name { get; set; }
        public virtual int? sortOrder { get; set; }
    }

    public class lib_province
    {
        [Key]
        public virtual string prov_code { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int rowid { get; set; }
        public virtual string region_code { get; set; }
        public virtual string prov_name { get; set; }
        public virtual int? sortOrder { get; set; }
    }
    public class lib_city
    {
        [Key]
        public virtual string city_code { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int rowid { get; set; }
        public virtual string prov_code { get; set; }
        public virtual string city_name { get; set; }
        public virtual int? sortOrder { get; set; }

    }
    public class lib_brgy
    {
        [Key]
        public virtual string brgy_code { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int rowid { get; set; }
        public virtual string city_code { get; set; }
        public virtual string brgy_name { get; set; }
        public virtual int? sortOrder { get; set; }
    }
    public class lib_user_level
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int userLevelId { get; set; }
        public virtual string description { get; set; }
        public virtual bool is_active { get; set; }
    }
    public class lib_civil_status
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int civil_status_id { get; set; }
        public virtual string description { get; set; }
    }

    public class lib_citizenship
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int citizenship_id { get; set; }
        public virtual string description { get; set; }
    }
    public class lib_blood_type
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int blood_type_id { get; set; }
        public virtual string description { get; set; }
    }
    public class lib_request_type
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int requestTypeId { get; set; }
        public virtual string description { get; set; }
        public virtual bool is_active { get; set; }
    }
    public class lib_department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int departmentId { get; set; }
        public virtual string description { get; set; }
        public virtual bool is_active { get; set; }
    }
    public class lib_job_category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int jobCategoryId { get; set; }
        public virtual string description { get; set; }
        public virtual bool is_active { get; set; }
    }
    public class lib_core_competency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int coreCompetencyId { get; set; }
        public virtual string description { get; set; }
        public virtual bool is_active { get; set; }
        public virtual ICollection<lib_competency_category> libCompetencyCategory { get; set; }
    }
    public class lib_competency_category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int competencyId { get; set; }
        public virtual string description { get; set; }
        public virtual bool is_active { get; set; }
    }
    public class lib_occupational_service_code
    {
        [Key]
        [StringLength(10)]
        public virtual string occupational_serv_code { get; set; }
        [StringLength(500)]
        public virtual string description { get; set; }
        public virtual bool is_active { get; set; }
    }
    
    public class lib_occupational_group_code
    {
        [Key]
        [StringLength(10)]
        public virtual string occupational_grp_code { get; set; }
        public virtual string description { get; set; }
        public virtual bool is_active { get; set; }
    }
}
