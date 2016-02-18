using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Data;

namespace MIB
{
    public class GlobalForm
    {
        public Menux MenuForm = new Menux();
    }
    public class DataType
    {
        public string type;
        public string money;
        public string describe;
        public string unit;        
        public string time;
        public Date date = new Date();
    }
    public class MyWallet
    {
        public double sum_rev = 0.0, sum_exp = 0.0, balance;
        public string file_input = "data.xml";
        public Date date = new Date();
        public List<DataType> data = new List<DataType>();
        public void Read(List<DataType> data, string file_input)
        {
            if (File.Exists(file_input))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file_input);

                XmlNodeList list_type = doc.GetElementsByTagName("type");
                XmlNodeList list_month = doc.GetElementsByTagName("month");
                XmlNodeList list_year = doc.GetElementsByTagName("year");
                XmlNodeList list_time = doc.GetElementsByTagName("time");
                XmlNodeList list_money = doc.GetElementsByTagName("money");
                XmlNodeList list_unit = doc.GetElementsByTagName("unit");
                XmlNodeList list_describe = doc.GetElementsByTagName("describe");

                for (int i = 0; i < list_type.Count; i++)
                {
                    DataType tmp = new DataType();
                    tmp.type = list_type[i].InnerText;
                    tmp.date.month = list_month[i].InnerText;
                    tmp.date.year = list_year[i].InnerText;
                    tmp.time = list_time[i].InnerText;
                    tmp.money = list_money[i].InnerText;
                    tmp.unit = list_unit[i].InnerText;
                    tmp.describe = list_describe[i].InnerText;

                    data.Add(tmp);
                }
            }
        }
        public void Write(List<DataType> data, string file_input)
        {
            if (!File.Exists(file_input))
            {
                File.Create(file_input).Close();
            }

            FileStream fs = new FileStream(file_input, FileMode.Create);
            
            XmlTextWriter w = new XmlTextWriter(fs, Encoding.UTF8);
            w.Formatting = Formatting.Indented;
            w.WriteStartDocument();
            w.WriteStartElement("QLCT");

            for (int i = 0; i < data.Count(); i++)
            {
                w.WriteStartElement("QLCT");

                w.WriteElementString("type", data[i].type);
                w.WriteElementString("month", data[i].date.month);
                w.WriteElementString("year", data[i].date.year);
                w.WriteElementString("time", data[i].time);
                w.WriteElementString("money", data[i].money);
                w.WriteElementString("unit", data[i].unit);
                w.WriteElementString("describe", data[i].describe);

                w.WriteEndElement();
            }

            w.WriteEndDocument();
            w.Flush();
            fs.Close();
        }

        public void Add(DataType tmp)
        {
            data.Add(tmp);
        }
        public DataTable GetStringData(string type, ref double sum)
        {
            double money;
            DataTable tb = new DataTable();
        
            tb.Columns.Add("Time", typeof(string));
            tb.Columns.Add("Money", typeof(string));
            tb.Columns.Add("Describe", typeof(string));
            //string text = null;
            for (int i = data.Count(); i > 0; i--)
             {
                 if (data[i - 1].type == type && data[i - 1].date.month == date.month && data[i - 1].date.year == date.year)
                 {
                     //tb.Rows.Add(data[i - 1].time, data[i - 1].money, data[i - 1].describe);
                     DataRow newRow = tb.NewRow();

                     newRow["Time"] = data[i - 1].time; // remove this line
                     money = CalMoney(data[i - 1].unit, double.Parse(data[i - 1].money));
                     newRow["Money"] = money + " VNĐ";
                     newRow["Describe"] = data[i - 1].describe;
                     tb.Rows.Add(newRow);

                     sum += money;
                 }
                 //{
                 //    text = text + data[i - 1].time + "\r\n" + data[i - 1].money + " " + data[i - 1].unit + "\r\n" + data[i - 1].describe + "\r\n\r\n";
                 //    sum += CalMoney(data[i - 1].unit, Int32.Parse(data[i - 1].money));
                 //}
             }
             return tb;
        }
        public string ConvertMoney(double money)
        {
            string t = money.ToString();
            if (t.Length > 3)
            {
                for (int i = t.Length - 3; i > 0; i = i - 3)
                {
                    t = t.Insert(i, ".");
                }
            }

            return t;
        }
        private double CalMoney(string type_money, double money)
        {
            switch (type_money)
            {
                case "VND":
                    return money;
                    break;

                case "thousand VND":
                    return money * 1000;
                    break;

                case "hundred thousand VND":
                    return money * 100000;
                    break;

                case "million VND":
                    return money * 1000000;
                    break;

                case "billion VND":
                    return money * 1000000000;
                    break;                                       
            }

            return 0;
        }

        public void Statistic()
        {
            Menux.MW.GetStringData("revenue", ref sum_rev);
            Menux.MW.GetStringData("expenditure", ref sum_exp);
            balance = sum_rev - sum_exp;
        }
       
    }


    public class Date
    {
        public string month, year;
    }
    
}
