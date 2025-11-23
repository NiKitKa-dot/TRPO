using System;

namespace DataTier
{
    public class Строение
    {
        public string Тип { get; set; }
        public int Комнат { get; set; }
        public double Метраж { get; set; }
        public decimal Стоимость { get; set; }
    }

    public static class ВсеСтроения
    {
        public static List<Строение> ПолучитьВсеСтроения()
        {
            // Чтение данных из файла
            var строкаи = File.ReadAllLines("buildings.txt");
            var список = new List<Строение>();
            foreach (var строка in строкаи)
            {
                var части = строка.Split('*');
                список.Add(new Строение
                {
                    Тип = части[0],
                    Комнат = int.Parse(части[1]),
                    Метраж = double.Parse(части[2]),
                    Стоимость = decimal.Parse(части[3])
                });
            }
            return список;
        }
    }

}
