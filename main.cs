using System;
using System.Collections;

class MainClass 
{
  public static void Main (string[] args) 
  {
    var result = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
    Console.WriteLine(result[0] + " " + result[1]);
  }

  public static int[] TwoSum(int[] nums, int target)
  {
      Hashtable hashtable = new Hashtable();
      for (int i = 0; i < nums.Length; i++)
      {
          var compliment = target - nums[i];
          if (hashtable.ContainsKey(compliment))
          {
              return new int[] { i, (int)hashtable[compliment] };
          }
          hashtable.Add(nums[i], i);
      }
      return new int[] { };
  }
}