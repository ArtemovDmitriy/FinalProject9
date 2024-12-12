using Task1;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] ArrayOfException = new Exception[] 
            { new DivideByZeroException("Знаменатель в операции деления равен нулю"),
              new NotImplementedException("Метод или операция не реализованы"),
              new DirectoryNotFoundException("Недопустимая часть пути к каталогу"),
              new FileNotFoundException("Файл не существует"),
              new MyException("Собственное исключение")
            };

            foreach (Exception exception  in ArrayOfException)
            {
                try
                {
                    throw exception;
                }
                catch(Exception ex) 
                { 
                    Console.WriteLine($"{ex.Message} - {DateTime.Now}");
                }  
            }

            Console.WriteLine();
        }
    }
}
