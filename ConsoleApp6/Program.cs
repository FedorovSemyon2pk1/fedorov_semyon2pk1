using System;

namespace Card
    {
    class Program
    {
        static void Main(string[] args)
        {
            Card c = new Card(15348915672346532342, "Петров В.И", "01.09.2026", 240, "кредитная");
            c.GetInfo();
            Console.WriteLine();
            Card c1 = new Card(12534841321346237523, "Селиверство С.А", "01.09.2022", 355, "дебютовая");
            c1.GetInfo();
            Console.WriteLine();
            Card c2 = new Card(13487856891567812339, "Гуськов А.Р", "01.03.2024", 402, "кредитная");
            c2.GetInfo();
            Console.WriteLine();
            Card c3 = new Card(12123479156946778569, "Логвинов С.И", "01.02.2023", 120, "кредитная");
            c3.GetInfo();
            Console.WriteLine();
            var c4 = new BlockedCard(15348791241256346523, "Цаплин П.И", "01.06.2022", 930, "");
            c4.GetInfo();
            Console.WriteLine();
            var c5 = new BlockedCard(1348791241256346523, "Рогозин П.И", "01.06.2021", 930, "");
            c5.GetInfo();
            Console.WriteLine();
            var c6 = new BlockedCard(1348791241256346523, "Федун И.С", "01.06.2024", 930, "дебютовая");
            c6.GetInfo();
            Console.WriteLine();
            var c7 = new BlockedCard(1348791241256346523, "", "01.06.2022", 930, "дебютовая");
            c7.GetInfo();
            Console.WriteLine();
            Console.WriteLine($"Количество карт:{Card.cards}");
            Console.WriteLine();
            Console.WriteLine($"Количество карт, срок действия которых до конца текущего года:{ Card.cards_date}");
        }
    }
}
