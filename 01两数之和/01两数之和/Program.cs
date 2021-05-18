using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01两数之和
{ /*
    给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 的那 两个 整数，并返回它们的数组下标。
    你可以假设每种输入只会对应一个答案。但是，数组中同一个元素在答案里不能重复出现。
    你可以按任意顺序返回答案。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/two-sum
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
     */
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testNums = new int[4]{ 2, 7, 11, 15 };//用list可以不用初始化时赋值
            int[] testNums = new int[10] { 2, 7, 11, 15, 7, 3, 4, 5, 8, 1 };
            int a = 9;
            AnwserTwoSum nums = new AnwserTwoSum();
            int[] x = nums.TwoSumMyself(testNums, a);
            foreach (var i in x)
            {
                Console.WriteLine(x[i]);
            }
            Console.WriteLine("---------");

            int[] y = nums.TwoSumIndexOf(testNums, a);
            foreach (var i in y)
            {
                Console.WriteLine(y[i]);
            }

            Console.ReadLine();
        }
        class AnwserTwoSum
        {
            //双for循环
            public int[] TwoSumMyself(int[] nums, int a)
            {
                int[] ans = new int[2];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == a)
                        {

                            ans[0] = i;
                            ans[1] = j;
                            return ans;
                        }
                    }
                }
                return ans;
            }

            //用数组索引的方式IndexOf
            public int[] TwoSumIndexOf(int[] nums, int target)
            {
                int[] result = new int[2];
                for (int i = 0; i < nums.Length; i++)
                {
                    int int_j = target - nums[i];
                    int j;
                    j = Array.IndexOf(nums, int_j);
                    if (j == -1) { continue; }
                    if (j != i)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
                return result;
            }

        }
    }
}
