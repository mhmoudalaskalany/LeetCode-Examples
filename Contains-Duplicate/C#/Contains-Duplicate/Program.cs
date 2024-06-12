
Console.WriteLine("Hello, Checking Duplicate!");
//Given an integer array nums, return true if any value appears at least twice in the array, 
//and return false if every element is distinct.
//Example 1:
//Input: nums = [1,2,3,1]
//Output: true
//Example 2:
//Input: nums = [1,2,3,4]
//Output: false
int[] arr1 = [1, 2, 3, 4];
int[] arr2 = [1, 2, 3, 1];
List<int[]> arrays = new List<int[]>() { arr1, arr2 };
foreach (var array in arrays)
{
    Console.WriteLine(DuplicateValidator.HasDuplicate(array));
    Console.WriteLine(DuplicateValidator.HasDuplicateWithHashSet(array));
}

public class DuplicateValidator
{
    public static bool HasDuplicate(int[] numbers)
    {
        var hasDuplicate = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    hasDuplicate = true;
                    break;
                }
                if (hasDuplicate)
                {
                    break;
                }
            }
        }
        return hasDuplicate;
    }


    // Another Solution with HashSet to beat leetcode time limit
    public static bool HasDuplicateWithHashSet(int[] numbers)
    {
        HashSet<int> seen = new HashSet<int>();
        foreach (int num in numbers)
        {
            if (seen.Contains(num))
            {
                return true;
            }
            seen.Add(num);
        }
        return false;
    }
}