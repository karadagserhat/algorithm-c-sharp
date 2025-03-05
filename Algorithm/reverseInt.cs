namespace Algorithm
{
    public class reverseInt
    {
        public static int Algoritma1(int sayi)
        {
            int sign = Math.Sign(sayi);
            sayi = Math.Abs(sayi);

            string rev = new string(sayi.ToString().Reverse().ToArray());

            return int.Parse(rev) * sign;

        }

        public static int Algoritma2(int sayi)
        {

            int sign = Math.Sign(sayi);
            sayi = Math.Abs(sayi);
            int result = 0;

            while (sayi > 0)
            {
                result = result * 10 + sayi % 10;
                sayi /= 10;
            }

            return result * sign;


        }

    }
}
