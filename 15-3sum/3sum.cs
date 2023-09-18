public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> triplets = new List<IList<int>>();

        //array needs to have at least 3 numbers
        if(nums.Length< 3){
            return triplets;
        }

        Array.Sort(nums);
        
        for (int i = 0; i <nums.Length - 2;i++)
        {
            //first number must be negative
            if (nums[i]>0)
            {
                i = nums.Length;
            } else
            { 
                //solution set must not contain duplicate triplets therefore numbers too
                if (i > 0 && nums[i] == nums[i - 1]){
                    continue;
                }
            int leftPointer = i + 1;
            int rightPointer = nums.Length -1;

        while (leftPointer < rightPointer)
        {
            int sum = nums[i] + nums[leftPointer] + nums[rightPointer];
            if (sum == 0)
            {
                    triplets.Add(new List<int>() {nums[i], nums [leftPointer], nums[rightPointer]});
                    //move pointers when triplet is added to solution list(for not repeating numbers)
                    while (leftPointer < rightPointer && nums[leftPointer] == nums[leftPointer + 1])
                    {
                        leftPointer++;
                    }
                    while (leftPointer < rightPointer && nums[rightPointer] == nums[rightPointer - 1])
                    {
                        rightPointer--;
                    }
                    leftPointer++;
                    rightPointer--;
                }
                 //if sum is not 0, then find it by moving pointers
                 else if (sum < 0){
                     leftPointer++;
                 }
                    else
                    {
                        rightPointer--;
                    }
                }
            }    
        }
        return triplets;
    }
}