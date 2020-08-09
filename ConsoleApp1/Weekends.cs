using System;

namespace ConsoleApp1
{
    public enum Weekends
    {
        Sun = 0,
        Mon,
        Tues,
        Wed,
        Thur,
        Fri,
        Sat
    }

    public class Weekend
    {
        public static int GetWeekdayNum(Weekends weekday) =>
            weekday switch
            {
                Weekends.Sun => 0,
                Weekends.Mon => 1,
                Weekends.Tues => 2,
                Weekends.Wed => 3,
                Weekends.Thur => 4,
                Weekends.Fri => 5,
                Weekends.Sat => 6,
                _ => throw new ArgumentException(message: "invalid enum value"),
            };

        public static int GetWeekdayNumOriginalMethod(Weekends weekday)
        {
            //var num = weekday switch
            //{
            //    Weekends.Sun => 0,
            //    Weekends.Mon => 1,
            //    Weekends.Tues => 2,
            //    Weekends.Wed => 3,
            //    Weekends.Thur => 4,
            //    Weekends.Fri => 5,
            //    Weekends.Sat => 6,
            //    _ => throw new ArgumentException(message: "invalid enum value"),
            //};

            var num = weekday switch
            {
                Weekends.Sun => 0,
                Weekends.Mon => throw new NotImplementedException(),
                Weekends.Tues => throw new NotImplementedException(),
                Weekends.Wed => throw new NotImplementedException(),
                Weekends.Thur => throw new NotImplementedException(),
                Weekends.Fri => throw new NotImplementedException(),
                Weekends.Sat => throw new NotImplementedException(),
                _ => throw new NotImplementedException(),
            };

            return num;
        }

        //属性模式
        public static decimal ComputeSalesTax(Person person, decimal salePrice) =>
            person switch
            {
                { Name: "WA" } => salePrice * 0.06M,
                { Name: "MN" } => salePrice * 0.75M,
                { Name: "MI" } => salePrice * 0.05M,
                _ => 0M
            };

        //Tuple模式
        public static string RockPaperScissors(string first, string second)
            => (first, second) switch
            {
                ("rock", "paper") => "rock is covered by paper. Paper wins.",
                ("rock", "scissors") => "rock breaks scissors. Rock wins.",
                ("paper", "rock") => "paper covers rock. Paper wins.",
                ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
                ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
                ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
                (_, _) => "tie"
            };

        //位置模式
        static Weekends GetQuadrant(Point point) =>
            point switch
            {
                (0, 0) => Weekends.Sun,
                var (x, y) when x > 0 && y > 0 => Weekends.Mon,
                var (x, y) when x > 0 && y < 0 => Weekends.Tues,
                var (_, _) => Weekends.Sat,
                _ => Weekends.Fri
            };
    }

    public class Point
    {
        public int X { get; }

        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public void Deconstruct(out int x, out int y) =>
            (x, y) = (X, Y);
    }
}
