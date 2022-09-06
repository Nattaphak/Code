public class Money
{
    public void Calculator(double tang)
    {
        tang = tang * 100;

        int A, B, C, D, E, F, G, H, I, J, K, remain;

            A = (int)(tang / 100000);
            remain = (int)(tang % 100000);

            B = remain / 50000;
            remain = remain % 50000;

             C = remain / 10000;
            remain = remain % 10000;

            D = remain / 5000;
            remain = remain % 5000;

            E = remain / 2000;
            remain = remain % 2000;

            F = remain / 1000;
            remain = remain % 1000;

            G = remain / 500;
            remain = remain % 500;

            H = remain / 200;
            remain = remain % 200;

            I = remain / 100;
            remain = remain % 100;

            J = remain / 50;
            remain = remain % 50;

            K = remain / 25;
            remain = remain % 25;

            Console.WriteLine("1000: {0}",A);

            Console.WriteLine("500: {0}", B);

            Console.WriteLine("100: {0}", C);

            Console.WriteLine("50: {0}", D);

            Console.WriteLine("20: {0}", E);

            Console.WriteLine("10: {0}", F);

            Console.WriteLine("5: {0}", G);

            Console.WriteLine("2: {0}", H);

            Console.WriteLine("1: {0}", I);

            Console.WriteLine("0.50: {0}", J);

            Console.WriteLine("0.25: {0}", K);
    }
}