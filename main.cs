using System;
using System.Collections.Generic;

class MainClass 
{
  public static void Main (string[] args) 
  {
    var result = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
    Console.WriteLine(result[0] + " " + result[1]);
  }

  public static int[] TwoSum(int[] nums, int target)
  {
      Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for(var i = 0; i < nums.Length; i++)
        {
            var compliment = target - nums[i];
            if (dictionary.ContainsKey(compliment))
            {
                return new int[] { i, dictionary[compliment] };
            }
            dictionary.Add(nums[i], i);
        }
        return new int[] { };
  }
}