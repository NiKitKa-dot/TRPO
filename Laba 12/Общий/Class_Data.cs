using System;
using System.Collections.Generic;

namespace DataTier
{
    public class Товар
    {
        public string Код { get; set; }
        public string Наименование { get; set; }
        public float Цена { get; set; }
        public int Количество { get; set; }
        public string Описание { get; set; }
    }

    public class ВсеТовары
    {
        public static List<Товар> ПолучитьВсеТовары()
        {
            List<Товар> list = new List<Товар>();
            list.Add(new Товар()
            {
                Код = "001",
                Наименование = "ОС Windows 8",
                Количество = 10,
                Цена = 40.99f,
                Описание = "Современная операционная система. Версия 8"
            });
            list.Add(new Товар()
            {
                Код = "002",
                Наименование = "3D Max", 
                Количество = 2,
                Цена = 500.99f,
                Описание = "Система визуализации и рендеринга от Autodesk Corp."
            });
            list.Add(new Товар()
            {
                Код = "003",
                Наименование = "Total Commander 1.00",
                Количество = 100,
                Цена = 0.5f,
                Описание = "__"
            });
            list.Add(new Товар()
            {
                Код = "004-001",
                Наименование = "MS SQL Server",
                Количество = 5,
                Цена = 150.00f,
                Описание = "СУБД от Microsoft Corp." 
            });
            return list;
        }

        public static void СохранитьВсеТовары(List<Товар> товары)
        {
            
        }
    }
}