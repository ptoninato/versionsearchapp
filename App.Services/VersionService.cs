using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services
{
    public interface IVersionSoftware
    {
        List<Software> GetSoftwareGreaterThanInput(string input);
    }

    public class VersionService : IVersionSoftware
    {
        public List<Software> GetSoftwareGreaterThanInput(string input)
        {
            var results = new List<Software>();

            //TODO: Add front-end validation and error handling for invalid inputs
            input = ValidateInput(input);   

            Version.TryParse(input, out Version inputVersion);

            if (inputVersion != null)
            {
                var existingSoftware = SoftwareService.GetAllSoftware();

                foreach (var software in existingSoftware)
                {
                    if (Version.TryParse(software.Version, out Version ver))
                    {
                        if (ver > inputVersion)
                        {
                            results.Add(software);
                        }
                    }
                    else
                    {
                        //TODO: handle bad versions in existingSoftware
                    }
                }

                return results;

            }

            return results;
            //TODO: Handle bad version input
        }

        private static string ValidateInput(string input)
        {
            if (input == null)
            {
                input = "0.0";
            }

            if (!input.Contains('.'))
            {
                input += ".0";
            }

            return input;
        }
    }
}
