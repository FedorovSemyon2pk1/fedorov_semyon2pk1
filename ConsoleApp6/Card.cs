using System;
using System.Collections.Generic;
using System.Text;

namespace Card
{
    internal class Card
    {
        public ulong number;
        public string clientFIO;
        public string validity;
        public int secureCode;
        public string type;
        public static int cards;
        public static int cards_date;
        
        public ulong Number
        {
            set
            {
                if (20 == value.ToString().Length) number = value;
            }
            get { return number; }
        }
        public string ClientFIO
        {
            get { return clientFIO; }
            set {
                if (value != "")
                    clientFIO = value;
                else
                    clientFIO = "unknown";
            }
        }
        public string Validity
        {
            get { return validity; }
            set
            {
                var date = DateTime.Parse(value);
                if (
                    DateTime.Parse("01.01.2022") <= date
                    && DateTime.Parse("01.01.2026") <= date
                    ) validity = value;
            }
        }
        public int SecureCode
        {
            set
            {
                if (3 == value.ToString().Length) secureCode = value;
            }
            get { return secureCode; }
                           
        }

        public string Type
        {
            get { return type; }
            set
            {
                if (value != "")
                type = value;
                else
                    type = "unknown";
            }
        }
        
        public Card(ulong num, string fio, string val, int code, string tatarin)
        {
            number = num;
            clientFIO = fio;
            validity = val;
            secureCode = code;
            type = tatarin;
            cards++;
            if (new DateTime(Int32.Parse(val.Substring(6)), Int32.Parse(val.Substring(3, 2)), Int32.Parse(val.Substring(0, 2))) <= new DateTime(2022, 12, 31))
                cards_date++;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Номер карты: {number}\nФио клиента: {clientFIO}\nСрок действия: {validity}\nКод безопасности: {secureCode}\nДебетовая/кредитная: {type}");
        }
    }
}