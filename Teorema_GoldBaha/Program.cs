internal class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[num];

        for (int i = 1; i <= num; i++)
            if (isSimpleNum(i) == true)
                    nums[i] = i;

        for (int i = 0; i < nums.Length / 2 + 1; i++)
            for (int j = 0; j < nums.Length; j++)
                if (nums[i] + nums[j] == num & nums[i] != 1 & nums[j] != 1)
                    Console.WriteLine($"Пара простых чисел: {nums[i]}:{nums[j]}");
    }
    private static bool isSimpleNum(int num)
    {
        for (int i = 2; i <= num / 2; i++)
            if (num % i == 0)
                return false;
        return true;
    }
}