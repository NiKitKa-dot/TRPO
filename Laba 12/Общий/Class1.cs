using System.Collections.Generic;
using System.Linq;
using DataTier;

namespace LogicTier
{
    public class ТоварнаяПозиция
    {
        private Товар _товар;

        public ТоварнаяПозиция(Товар p) { _товар = p; }

        public string КодТовара
        {
            get { return _товар.Код; }
            set { _товар.Код = value; }
        }

        public string НаименованиеТовара
        {
            get { return _товар.Наименование; }
            set { _товар.Наименование = value; }
        }

        public float ЦенаТовара
        {
            get { return _товар.Цена; }
            set { _товар.Цена = value; }
        }

        public int КоличествоТовара
        {
            get { return _товар.Количество; }
            set { _товар.Количество = value; }
        }

        public string ОписаниеТовара
        {
            get { return _товар.Описание; }
            set { _товар.Описание = value; }
        }

        public float СуммарнаяСтоимостьПозиции
        {
            get { return _товар.Цена * _товар.Количество; }
        }

        public string ПредставлениеТовара
        {
            get { return _товар.Код + " : " + _товар.Наименование + " (" + _товар.Цена.ToString("C") + ")"; }
        }
    }

    public class Магазин
    {
        private List<ТоварнаяПозиция> _товары = new List<ТоварнаяПозиция>();

        public Магазин()
        {
            List<Товар> tmp = ВсеТовары.ПолучитьВсеТовары();
            foreach (var t in tmp)
                _товары.Add(new ТоварнаяПозиция(t));
        }

        public List<ТоварнаяПозиция> СписокТоваров
        {
            get { return _товары; }
        }

        public string НаименованиеМагазина
        {
            get { return "Наш магазин"; }
        }

        public float СуммарнаяСтоимость
        {
            get { return _товары.Sum(p => p.СуммарнаяСтоимостьПозиции); }
        }

        public float СуммарноеКоличество
        {
            get { return _товары.Sum(p => p.КоличествоТовара); }
        }
    }
}