using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.IO;

namespace MIB
{
    public class GlobalForm
    {
        public Menux MenuForm = new Menux();
        //public Add_Revenue AddRevenueForm = new Add_Revenue();
        //public Show_Revenue ShowRevenueForm = new Show_Revenue();
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
        public string file_input = "data.txt";
        public Date date = new Date();
        public List<DataType> data = new List<DataType>();
        public void Read(List<DataType> data, string file_input)
        {
            if (File.Exists(file_input))
            {
                StreamReader re = File.OpenText(file_input);
                string input;
                while ((input = re.ReadLine()) != null)
                {
                    DataType tmp = new DataType();

                    tmp.type = input;

                    input = re.ReadLine();
                    tmp.date.month = input;

                    input = re.ReadLine();
                    tmp.date.year = input;

                    input = re.ReadLine();
                    tmp.time = input;

                    input = re.ReadLine();
                    tmp.money = input;

                    input = re.ReadLine();
                    tmp.unit = input;

                    string input2;
                    input = re.ReadLine();  
                    while(true)
                    {                              
                        if (input != "END")
                        {
                            input2 = re.ReadLine();
                            if (input2 != "END")
                                tmp.describe = tmp.describe + input + "\r\n";
                            else
                            {
                                tmp.describe = tmp.describe + input;
                                break;
                            }
                            input = input2;
                        }
                    }
                    data.Add(tmp);
                }

                re.Close();
            }
        }
        public void Write(List<DataType> data, string file_input)
        {
            if (File.Exists(file_input))
            {
                FileInfo fi = new FileInfo(file_input);
                if (fi.IsReadOnly)
                    fi.IsReadOnly = false;
                fi.Delete();
            }

            FileStream myFileSV = new FileStream(file_input, FileMode.Create);
            StreamWriter wr = new StreamWriter(myFileSV, Encoding.UTF8);

            for (int i = 0; i < data.Count(); i++)
            {
                wr.WriteLine(data[i].type);
                wr.Flush();

                wr.WriteLine(data[i].date.month);
                wr.Flush();

                wr.WriteLine(data[i].date.year);
                wr.Flush();
                                
                wr.WriteLine(data[i].time);
                wr.Flush();

                wr.WriteLine(data[i].money);
                wr.Flush();

                wr.WriteLine(data[i].unit);
                wr.Flush();

                wr.WriteLine(data[i].describe);
                wr.Flush();

                wr.WriteLine("END");
                wr.Flush();
            }
            wr.Close();
            myFileSV.Close();
        }

        public void Add(DataType tmp)
        {
            data.Add(tmp);
        }
        public string GetStringData(string type, ref double sum)
        {
            string text = null;
            for (int i = data.Count(); i > 0; i--)
             {
                 if (data[i - 1].type == type && data[i - 1].date.month == date.month && data[i - 1].date.year == date.year)
                 {
                     text = text + data[i - 1].time + "\r\n" + data[i - 1].money + " " + data[i - 1].unit + "\r\n" + data[i - 1].describe + "\r\n\r\n";
                     sum += CalMoney(data[i - 1].unit, Int32.Parse(data[i - 1].money));
                 }
             }
             return text;
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
                    

                case "thousand VND":
                    return money * 1000;
                    

                case "hundred thousand VND":
                    return money * 100000;
                    

                case "million VND":
                    return money * 1000000;
                    

                case "billion VND":
                    return money * 1000000000;
                                                           
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
