using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Linq;

namespace Lab3.Model
{


    public class CdModel
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Country { get; set; }
        public string Price { get; set; }
        public string Year { get; set; }



        public static async Task<ObservableCollection<CdModel>> LoadXMLData()
        {
            try
            {
                ObservableCollection<CdModel> lstXml = new ObservableCollection<CdModel>();
                await Task.Factory.StartNew(delegate
                {
                    XDocument doc = XDocument.Load("catalog.xml");
                    var result = doc.Descendants("CD");
                    foreach (var item in result)
                    {
                        var a = item.Descendants("Title").FirstOrDefault();

                        lstXml.Add(new CdModel { Title = a.Value });
                    }

                });
                return lstXml;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

    }
}

