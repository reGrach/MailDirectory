using System.Data.Entity;

namespace MailDirectory.MailDB
{
    class CatalogueDBContext : DbContext
    {
        //Инициализация/подключение к БД
        public CatalogueDBContext() : base("CatalogueDBContext") { }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Letter> Letters { get; set; }
    }
}
