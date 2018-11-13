using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EksamensS3MBJ.Entities
{
    public class ClassRegex
    {
        public ClassRegex()
        {

        }

        /// <summary>
        /// this Regex
        /// Checks the Value is a Valid Danish Phone Number
        /// The following Patterns are Valid
        /// 31322031
        /// 31 32 20 31
        /// 31 322 031
        /// 004531322031
        /// 0045 31322031
        /// 0045 31 32 20 31
        /// 0045 31 322 031
        /// +4531322031
        /// +45 31322031
        /// +45 31 32 20 31
        /// +45 31 322 031
        /// </summary>
        /// <param name="tjekValue"></param>
        /// <returns></returns>
        public bool IsValidDkPhoneNo(string tjekValue)
        {
            string pattern = @"^(((0045))\s?)|((([+]45))\s?)?((([0-9]{8}){1})|(([0-9]{2}\s{0,3}){4})|(([0-9]{2}\s{1})([0-9]{3}(\s{0,1})){2}))$";
            return Regex.IsMatch(tjekValue, pattern);
        }

        /// <summary>
        /// This Regex
        /// Checks the Value is a Danish Zipcode and City name
        /// the following values are Correct Zip code and City name
        /// 5000 CityName
        /// 5000 CityName SecondCityName
        /// 5000 CityName SecondCityName ThirdCityName
        /// 5000 CityName-SecondCityName
        /// 5000 CityName-SecondCityName-ThirdCityName
        /// 5000 CityName-SecondCityName ThirdCityName 
        /// 5000 CityName-SecondCityName ThirdCityName
        /// 5000 CityName SecondCityName-ThirdCityName
        /// </summary>
        /// <param name="tjekValue"></param>
        /// <returns></returns>
        public bool IsValidZipCity(string tjekValue)
        {
            string pattern = @"^([0-9]{4})(((\s([A-zÆØÅ]{1}[a-zæøå]{1,50})){1}))((((\s)|-)([A-ZÆØÅ]{1}[a-zæøå]{1,50})){0,3})$";
            return Regex.IsMatch(tjekValue, pattern);
        }

        public bool IsValidCPR(string tjekValue)
        {
            string pattern = @"^(?:(?:31(?:0[13578]|1[02])|(?:30|29)(?:0[13-9]|1[0-2])|(?:0[1-9]|1[0-9]|2[0-8])(?:0[1-9]|1[0-2]))[0-9]{2}(\s?|\-?)[0-9]|290200-?[4-9]|2902(?:(?!00)[02468][048]|[13579][26])(\s{0,1}|\-{0,1})[0-3])[0-9]{3}|000000(\s?|\-?)0000$";
            return Regex.IsMatch(tjekValue, pattern);
        }

    }
}
