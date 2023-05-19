using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using VCard.Models;
using System.Text.Json;
using System;
//using Newtonsoft.Json;

namespace HttpClientExtensionMethods
{
    using static VCard.Models.Result;
    class Response
    {
        public List<Result> Results { get; set; }
        public Info Info { get; set; }
    }


    public class Program
    {
       

      
        public static async Task Main() {

            HttpClient client = new HttpClient();
            Response response = await client.GetFromJsonAsync<Response>("https://randomuser.me/api?results=1");
            Result result = response.Results.FirstOrDefault();


            string vcard = $@"
BEGIN:VCARD
VERSION:3.0
FN;CHARSET=UTF-8:{result.Name.FullName}
N;CHARSET=UTF-8:{result.Name.Last};{result.Dob.Date.ToString("yyyy-MM-dd")};;;
BDAY:{result.Dob.Date.ToString("MM-dd")}
EMAIL;CHARSET=UTF-8;type=HOME,INTERNET:{result.Email}
TEL;TYPE=HOME,VOICE:{result.Phone}
ADR;CHARSET=UTF-8;TYPE=HOME:;;{result.Location.Street.StreetName};{result.Location.City};;{result.Location.Postcode};{result.Location.Country}
REV:{result.Registered.Date.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")}
END:VCARD 
";

            Console.WriteLine(vcard);

            string[] vcardArr = vcard.Split(' ');
            Console.WriteLine(vcardArr.Length);
            string pathName = @"C:\Users\Hp\source\repos\VCard\VCard\Vcard.vcf";
            FileStream fs = File.Create(pathName);
            fs.Close();
            File.WriteAllLines(pathName, vcardArr);
        }
    }
}
