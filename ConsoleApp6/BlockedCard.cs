using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Card
{
    internal class BlockedCard : Card
    {
        public BlockedCard(ulong num, string fio, string val, int code, string tatarin) : base(num, fio, val, code, tatarin)
        {
        }
            string Reason
            {
                get {
                    if (clientFIO == "")
                        return "Отстутствие данных ФИО.";
                    else if (type == "")
                        return "Отсутствие типа карты.";
                    return "Данные верны.";
                }
            }
        public override void GetInfo()
        {
            Console.WriteLine($"Номер карты: {number}\nФио клиента: {clientFIO}\nСрок действия: {validity}\nКод безопасности: {secureCode}\nДебетовая/кредитная: {type}\nПричина блокировки карты: {Reason}");
        }
    }
}
