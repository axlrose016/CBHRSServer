using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXLSmartRepository.Core.Models
{
    public class User
    {
        [Key]
        public virtual Guid userId { get; set; }
        public virtual string userName { get; set; }
        public virtual string salt { get; set; }
        public virtual string hash_code { get; set; }
        [NotMapped]
        public virtual string password { get; set; }
        [NotMapped]
        public virtual string confirmPassword { get; set; }
        public virtual string deleted_by { get; set; }
        public virtual DateTime? deleted_date { get; set; }
        public virtual bool is_deleted { get; set; }
        public virtual int user_level { get; set; }
    }
    public class PersonDetail
    {
        [Key]
        public virtual Guid personId { get; set; }
        [ForeignKey("userId")]
        public virtual Guid userId { get; set; }
        public virtual string firstName { get; set; }
        public virtual string middleName { get; set; }
        public virtual string lastName { get; set; }
        public virtual string extName { get; set; }
        public virtual int sex { get; set; }
        public virtual DateTime birthDate { get; set; }
        public virtual string placeOfBirth { get; set; }
        public virtual int civil_status_id { get; set; }
        public virtual int citizenship_id { get; set; }
        public virtual string blood_type_id { get; set; }
        public virtual string height { get; set; }
        public virtual string weight { get; set; }
        public virtual string gsis { get; set; }
        public virtual string philHealth { get; set; }
        public virtual string sss { get; set; }
        public virtual string pagIbig { get; set; }

        public virtual string tin { get; set; }
        public virtual string region_code { get; set; }
        public virtual string prov_code { get; set; }
        public virtual string city_code { get; set; }
        public virtual string brgy_code { get; set; }
        public virtual string purok { get; set; }
        public virtual string zipCode { get; set; }
        public virtual string telNo { get; set; }
        public virtual string mobileNo { get; set; }
        public virtual string email { get; set; }
        public virtual string deleted_by { get; set; }
        public virtual DateTime? deleted_date { get; set; }
        public virtual bool is_deleted { get; set; }
        public virtual ICollection<PersonTraining> personTrainings { get; set; }
        public virtual ICollection<PersonFamily> personFamily { get; set; }
        public virtual ICollection<PersonEducation> personEducations { get; set; }
        public virtual ICollection<PersonEligibility> personEligibilities { get; set; }
        public virtual ICollection<PersonWorkExperience> personWorkExperiences { get; set; }
    }
    public class PersonTraining
    {
        [Key]
        public virtual Guid personTrainingId { get; set; }
        [ForeignKey("personId")]
        public virtual Guid personId { get; set; }
        public virtual string seminarTitle { get; set; }
        public virtual DateTime dateFrom { get; set; }
        public virtual DateTime dateTo { get; set; }
        public virtual int numHours { get; set; }
        public virtual string conductedBy { get; set; }
        public virtual string deleted_by { get; set; }
        public virtual DateTime? deleted_date { get; set; }
        public virtual bool is_deleted { get; set; }
    }
    public class PersonFamily
    {
        [Key]
        public virtual Guid personFamilyId { get; set; }
        public virtual string firstName { get; set; }
        public virtual string middleName { get; set; }
        public virtual string lastName { get; set; }
        public virtual string extName { get; set; }
        public virtual DateTime birthDate { get; set; }
        public virtual string occupation { get; set; }
        public virtual string employer { get; set; }
        public virtual string businessAddress { get; set; }
        public virtual string telNo { get; set; }
        public virtual int relationship { get; set; }
        public virtual string deleted_by { get; set; }
        public virtual DateTime? deleted_date { get; set; }
        public virtual bool is_deleted { get; set; }
    }
    public class PersonEducation
    {
        [Key]
        public virtual Guid personEducationId { get; set; }
        public virtual string nameOfSchool { get; set; }
        public virtual int schoolLevelId { get; set; }
        public virtual string yearGraduated { get; set; }
        public virtual DateTime startDate { get; set; }
        public virtual DateTime endDate { get; set; }
        public virtual string degreeCourse { get; set; }
        public virtual string highestAttaind { get; set; }
        public virtual string scholarshipAwardHonor { get; set; }
        public virtual string deleted_by { get; set; }
        public virtual DateTime? deleted_date { get; set; }
        public virtual bool is_deleted { get; set; }
    }
    public class PersonEligibility
    {
        [Key]
        public virtual Guid personEligibilityId { get; set; }
        public virtual string eligibilityTitle { get; set; }
        public virtual int rating { get; set; }
        public virtual DateTime dateOfExamination { get; set; }
        public virtual string placeOfExamination { get; set; }
        public virtual string licenseNumber { get; set; }
        public virtual DateTime licensceReleaseDate { get; set; }
        public virtual string deleted_by { get; set; }
        public virtual DateTime? deleted_date { get; set; }
        public virtual bool is_deleted { get; set; }
    }
    public class PersonWorkExperience
    {
        [Key]
        public virtual Guid personWorkExperienceId { get; set; }
        public virtual string positionTitle { get; set; }
        public virtual string companyName { get; set; }
        public virtual DateTime startDate { get; set; }
        public virtual DateTime? endDate { get; set; }
        public virtual decimal monthlySalary { get; set; }
        public virtual int salaryGrade { get; set; }
        public virtual int salaryStep { get; set; }
        public virtual int appointmentStatusId { get; set; }
        public virtual bool isGovt { get; set; }
        public virtual string deleted_by { get; set; }
        public virtual DateTime? deleted_date { get; set; }
        public virtual bool is_deleted { get; set; }
    }

    #region SQL Views
    public class UserList_vw
    {
        public virtual Guid userId { get; set; }
        public virtual string userName { get; set; }
        public virtual string user_level { get; set; }
    }
    public class PersonList_vw
    {
        public Guid personId { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string extName { get; set; }
        public string Sex { get; set; }
        public DateTime birthDate { get; set; }
        public string placeOfBirth { get; set; }
        public string civil_status { get; set; }
        public string citizenship { get; set; }
        public string blood_type { get; set; }
    }
    #endregion
}
