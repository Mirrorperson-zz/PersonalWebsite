using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PersonalWebsite.Models
{
    public class ProjectModel
    {

        public int Id { get; set; }
        [Required]
        [DisplayName("Project Title")]
        public string ProjectTitle { get; set; }
        [DisplayName("Project Description")]
        [DataType(DataType.MultilineText)]
        public string ProjectDescription { get; set; }
        [DisplayName("Icon")]
        [DataType(DataType.ImageUrl)]
        public string ProjectIcon { get; set; }
    }
}