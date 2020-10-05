using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services
{
    public class VersionService
    {
        public List<Software> GetSoftwareGreaterThanInput(string input)
        {
            var results = new List<Software>();
            Version.TryParse(input, out Version inputVersion);
            var TEST = new Version(input);
            var existingSoftware = SoftwareService.GetAllSoftware();

            foreach(var software in existingSoftware)
            {
                if (Version.TryParse(software.Version, out Version ver))
                {
                    if (inputVersion.CompareTo(ver) < 0)
                    {
                        results.Add(software);
                    }
                }               
            }

            return results;
        }
    }
}
