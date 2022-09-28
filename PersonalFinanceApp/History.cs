using System.ComponentModel;

namespace PersonalFinanceApp
{
    public class History
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Дата")]
        public string AddDate { get; set; }

        [DisplayName("Тип")]
        public string FinanceType { get; set; }

        [DisplayName("Категория")]
        public string Category { get; set; }

        [DisplayName("Сумма")]
        public string Amount { get; set; }

        [DisplayName("Итого")]
        public string Total { get; set; }

        [DisplayName("Комментарий")]
        public string Comment { get; set; }
    }
}
