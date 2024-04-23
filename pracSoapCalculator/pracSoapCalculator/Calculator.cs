using System.ServiceModel;

namespace pracSoapCalculator
{
    [ServiceContract]
    public interface Calculator
    {
        [OperationContract]
        public int sum(int num1, int num2);

        [OperationContract]
        public int subtract(int num1, int num2);
        
        [OperationContract]
        public int multiply(int num1, int num2);
        
        [OperationContract]
        public int divide(int num1, int num2);
        
        [OperationContract]
        public int modulus(int num1, int num2);

    }
}
