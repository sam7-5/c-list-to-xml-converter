using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace xmlConver
{
    #region here you enter your class
    public class Station
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Longitude { get; set; }
        public double Lattitude { get; set; }
        public string Address { get; set; }

    }
    #endregion

    class Program
    {
        public static List<Station> listStations;//here you define a list of your class object
        static void Main(string[] args)
        {
            listStations = new List<Station>
            {        
                #region Generate many stations

            new Station
            {
                Code = 75,
                Name = "des pate",
                Address = "oui des pate ",
                Lattitude = 31.825302,
                Longitude = 35.188624
            },
            new Station
                {
                    Code = 76,
                    Name = "oui mais des",
                    Address = "panzanni",
                    Lattitude = 31.738425,
                    Longitude = 35.228765
                },
                new Station
                {
                    Code = 77,
                    Name = "bon voila quoi",
                    Address = "on s'amuse ",
                    Lattitude = 31.738676,
                    Longitude = 35.226704
                },
                new Station
                {
                    Code = 78,
                    Name = "שרי ישראל/יפו",
                    Address = "רחוב:שדרות שרי ישראל 15 עיר: ירושלים",
                    Lattitude = 31.789128,
                    Longitude = 35.206146

                }
                #endregion
            };//here you enter the objects you want in your xml file

            XmlSerializer serialiser = new XmlSerializer(typeof(List<Station>));//modify to the name of your object
            TextWriter Filestream = new StreamWriter(@"C:\Users\shmouel\Desktop\myNewXmlFile.xml"); //here you enter the path in your computer where you want your xml file 
            serialiser.Serialize(Filestream, listStations);//here you enter the name of your list
            Filestream.Close();
            //now run it!
        }
    }
}
