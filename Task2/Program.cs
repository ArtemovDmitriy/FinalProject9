namespace Task2
{
    internal class Program
    {
        static void ShowNumber(int number)
        {
            SurnameList surname = new SurnameList();
            surname.NotSortedList();
            List<string> list = surname.ShowList();
            switch (number)
            {
                case 1:
                    surname.Sort1(list);
                    break;
                case 2:
                    surname.Sort2(list);
                    break;
            }
        }

        static void Main(string[] args)
        {
            NumbersForChoose numbersForChoose = new NumbersForChoose();
            numbersForChoose.NumberEvent += ShowNumber;
            while (true)
            {
                try
                {
                    numbersForChoose.DataIn();
                }
                catch (MyException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
