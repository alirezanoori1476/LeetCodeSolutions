
var nums1 = new[] { 0, 1 };

var result = RemoveDuplicates(nums1);

Console.WriteLine(result);
Console.ReadLine();

return;


#region Question number 88 - Merge Sorted Array

//var nums1 = new[] { 1, 2, 3, 0, 0, 0 };
//var nums2 = new[] { 2, 5, 6 };

//var result = MergeSortedArrayFirstApproach(nums1, nums2);

//Console.WriteLine($"[{string.Join(", ", result)}]");
//Console.ReadLine();

int[] MergeSortedArrayFirstApproach(int[] firstList, int[] secondList) // First Approach
{
    var mergeSortedArray = new int[firstList.Length + secondList.Length];
    int i = 0, j = 0, k = 0;

    while (i < firstList.Length && j < secondList.Length)
    {
        if (nums1[i] <= secondList[j])
            mergeSortedArray[k++] = nums1[i++];
        else
            mergeSortedArray[k++] = secondList[j++];
    }

    while (i < firstList.Length)
        mergeSortedArray[k++] = nums1[i++];

    while (j < secondList.Length)
        mergeSortedArray[k++] = secondList[j++];

    return mergeSortedArray.Where(c => c != 0).ToArray();
}

int[] MergeSortedArraySecondApproach(int[] firstList, int[] secondList) // Second Approach
{
    var p1 = firstList.Length - 1;
    var p2 = secondList.Length - 1;
    var p = firstList.Length + secondList.Length - 1;

    while (p2 >= 0)
    {
        if (p1 >= 0 && firstList[p1] > secondList[p2])
            firstList[p--] = firstList[p1--];
        else
            firstList[p--] = secondList[p2--];
    }

    return firstList;
}

#endregion

#region Question number 27 - Remove Element 

int RemoveElement(int[] nums, int val)
{
    var k = 0;
    for (var i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            nums[k] = nums[i];
            k++;
        }
    }
    return k;
}

#endregion

#region Question number 26 - Remove Duplicates from Sorted Array

int RemoveDuplicates(int[] nums)
{
    if (nums.Length == 0)
        return 0;

    var k = 1;

    for (var i = 1; i < nums.Length; i++)
    {
        if (nums[i] == nums[k])
            continue;

        k++;
        nums[k] = nums[i];
    }

    return k;
}


#endregion