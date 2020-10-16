using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace App.Web.Models
{
    public class VersionSearchViewModel
    {        
        [RegularExpression(@"(\d+)\.(\d+)\.(\d+)|(\d+)\.(\d+)",
            ErrorMessage = "Not a valid version")]
        [MaxLength(5)]
        public string SearchTerm { get; set; }

        public List<Software> SearchResults { get; set; }
    }
}
