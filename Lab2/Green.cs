using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Timers;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            for (int i = 0; i <= n; i++) { answer += n / (n + 1); }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            for (int i = 0; i <= n; i++) { answer += Math.Pow(x, (n * (-1); }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n == 0) { answer = 1; }
            else
            {
                answer = 1;
                
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double lastSum = 50.0;
            for (int n = 0; n++)
            {
                if (Math.Abs(lastSum) < E)
                {
                    return answer;
                }
                el = Math.Sin(n * Math.Pow(x, n));
                lastSum = el;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 0;
            while (Math.Abs(((1 / Math.Pow(x, n) - (1 / Math.Pow(x, n - 1))) >= E) {
                n += 1;
            }
            answer = n;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            for (int i = 0; elem < limit; i++)
            {
                elem *= 2;
                answer += elem;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            while (L > Da)
            {
                L /= 2;
                answer += 1;
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}
