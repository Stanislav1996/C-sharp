using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Program
{
    public class FileOperation
    {
        public const string FilePath = @"C:\Users\Stanislav\Desktop\test.txt";

        public static List<Country> ReadCountryfromdatabase()
        {
            var listOfCountries = new List<Country>();

            using (var reader = new StreamReader(FileOperation.FilePath))
            {
                var CurrentCountry = reader.ReadLine();

                while (CurrentCountry != null)
                {
                    var currentCountry = CurrentCountry.Split('|');
                    var Country = new Country(
                        currentCountry[0].Trim(),
                       currentCountry[1].Trim(),
                        int.Parse(currentCountry[2].Trim()));
                      
                    listOfCountries.Add(Country);

                    CurrentCountry = reader.ReadLine();
                }
            }

            return listOfCountries;
        }
        public static bool Addcountrytodatabase(Country CountrytoAdd)
        {
            try
            {
                using (var writer = new StreamWriter(FileOperation.FilePath, true))
                {
                    writer.WriteLine(CountrytoAdd);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}