using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Reflection;
using System.Xml.Linq;

namespace Enums
{

    public enum Status : byte
    {
     


        [Description("Aktif Kullanıcıları Listeler")]
        Active ,


        [Description("Pasif Kullanıcıları Listeler")]
        Passive,


        [Description("Silinmiş Kullanıcıları Listeler")]
        Deleted,


        [Description("Kaydını Dondurmuş Kullanıcıları Listeler")]
        Holiday
    }

   
    public static class Program
    {
        public static string GetDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attribute = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            return attribute != null && attribute.Length > 0 ? attribute[0].Description : value.ToString();
        }

        static void Main(string[] args)
        {
            foreach (Status status in Enum.GetValues(typeof(Status)))
            {
                Console.WriteLine("{0} - {1}", status, status.GetDescription());
            }

    
        }
    }
}