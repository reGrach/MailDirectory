using System.Collections.Generic;

namespace MailDirectory.MailDB
{
    //Сущность Сотрудник для реализации в CodeFirst
    public class Employee
    {
        public int Id { get; set; }             //Идентификатор сотрудника
        public string FirstName { get; set; }   //Имя сотрудника
        public string SecondName { get; set; }  //Фамилия сотрудника

        //Связь один-ко-многим
        public ICollection<Letter> Letters { get; set; } //Колекция писем, ккоторым привязан данный сотрудник
        public Employee()
        {
            Letters = new List<Letter>();
        }
    }
}
