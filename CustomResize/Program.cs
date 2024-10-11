namespace CustomResize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 14, 15, 16, 17 };
            CustomResize(ref numbers, 18, 19, 20,43653276,576,4323287);
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }



        }
        public static void CustomResize(ref int[] arr, params int[] nums)
        {
            int[] newArr = new int[arr.Length +nums.Length];
            for(int i=0;i<arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            for(int i=0;i<nums.Length;i++)
            {
                newArr[arr.Length + i] = nums[i];
            }
            arr = newArr;
        }
    }
}
