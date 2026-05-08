using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace inovayt.Models
{
    public class VMUser
    {
        [Key]
        public System.Guid userId { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Surname { get; set; }
        public string? Givenname { get; set; }
        public string? Preferredname { get; set; }
        public string? Gender { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Australianresidence { get; set; }
        public string? TaxFileNumber { get; set; }

        //Extra
        public List<ddlList> titleList { get; set; }
        public List<ddlList> maritalList { get; set; }
        public VMUser()
        {
            titleList = new List<ddlList>()
            {
            new ddlList { Text = "Mr.", Value = "Mr." },
            new ddlList { Text = "Mrs.", Value = "Mrs." }
            };


            maritalList = new List<ddlList>()
            {
            new ddlList { Text = "Single", Value = "Single" },
            new ddlList { Text = "Married", Value = "Married" }
            };
        }
    }

    public class ddlList
    {
        [Key]
        public string Value { get; set; }
        public string Text { get; set; }
    }
}
