using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Models
{
    public class VersionSearchViewModel
    {        
        public string SearchTerm { get; set; }

        public List<Software> SearchResults { get; set; }
    }
}
