using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PersonalWebsite.Models
{
    public class ProjectModel
    {

        public int id { get; set; }
        [Required]
        public string projectTitle { get; set; }
        public string projectDescription { get; set; }
    }
}