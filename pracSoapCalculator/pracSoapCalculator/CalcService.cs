namespace pracSoapCalculator
{
    public class CalcService : Calculator
    {
        public int divide(int num1, int num2)
        {
            if (num1 == 0 || num2 == 0) return -1;
            
            return num1/num2;
        }

        public int modulus(int num1, int num2)
        {
            if (num1 == 0 || num2 == 0) return -1;
            
            return num1%num2;
        }

        public int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
