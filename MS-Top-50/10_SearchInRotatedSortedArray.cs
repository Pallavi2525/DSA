public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0, high = nums.Length - 1;
        while(low <= high){
            int mid = (low + high) / 2;
            if(nums[mid] == target) return mid;
            //left is sorted
            if(nums[low] <= nums[mid])
            {
                //is target present?
                if(target >= nums[low] && target <= nums[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            else{
                //right is sorted
                //is target present?
                if(target >= nums[mid] && target <= nums[high])
                    low = mid + 1;
                else
                    high = mid - 1;
            }
        }
        return -1;
    }
}