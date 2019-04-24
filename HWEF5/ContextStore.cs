namespace HWEF5
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ContextStore : DbContext
    {
        // Контекст настроен для использования строки подключения "ContextStore" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "HWEF5.ContextStore" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ContextStore" 
        // в файле конфигурации приложения.
        public ContextStore()
            : base("name=ContextStore")
        {
        }

        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BasketUsers> Basket { get; set; }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}