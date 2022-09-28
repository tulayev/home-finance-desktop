using System.Collections.Generic;
using System.Linq;

namespace PersonalFinanceApp.Data
{
    public class Filter
    {
        private readonly DataAccess _data;
        
        private readonly List<History> _list;

        public Filter()
        {
            _data = new DataAccess();
            _list = _data.GetData();
        }

        public List<History> GetSortedList(string cat)
        {
            if (cat == "Все")
                return _list;

            return _list.Where(c => c.Category.Equals(cat)).ToList();
        }

        public List<History> GetSortedListByExpense(string expense) => _list.Where(t => t.FinanceType.Equals(expense)).ToList();

        public List<History> GetSortedListByIncome(string income) => _list.Where(t => t.FinanceType.Equals(income)).ToList();
    }
}
