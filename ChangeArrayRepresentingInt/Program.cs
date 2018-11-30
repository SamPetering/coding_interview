namespace ChangeArrayRepresentingInt
{
    class Program
    {
        static void Main(string[] args)
        {
            // given an int array that represents a single integer ([1,3,2,4] >> 1324), write a function that returns an array representing the initial array + 1
            // each array index can only be a single digit integer 0-9

            int[] init = new int[] { 9, 9, 9, 9 };
            int val = 1;
            addOneIterative(init, val);
        }

        static int[] addOneIterative(int[] init, int val){
            int carry = val;
            int[] result = new int[init.Length];
            for(int i = init.Length - 1; i >= 0; i--)
            {
                int sum = init[i] + carry;
                if(sum == 10)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                result[i] = sum % 10;
            }
            if(carry == 1)
            {
                result = new int[init.Length + 1];
                result[0] = 1;
            }
            return result;
        }
    }
}
