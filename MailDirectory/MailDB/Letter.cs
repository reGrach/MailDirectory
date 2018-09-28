using System;

namespace MailDirectory.MailDB
{
    //Сущность Письмо для реализации в CodeFirst
    public class Letter
    {
        public int Id { get; set; }             //Идентификатор письма
        public string Subject { get; set; }     //Основная тема письма
        public DateTime Date { get; set; }      //Дата отправки писмьа
        public string TextMessage { get; set; } //Содержание письма


        //Связь один-ко-многим
        public int? SenderId { get; set; }
        public Employee Sender { get; set; }    //Отправитель письма из сущности Сотрудник

        public int? RecipientId { get; set; }
        public Employee Recipient { get; set; } //Получатель письма из сущности Сотрудник
    }
}
