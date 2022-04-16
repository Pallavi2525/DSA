//LeetCode - 1346. Check If N and Its Double Exist

public class Solution {
    public bool CheckIfExist(int[] arr) {
        for(int i = 0; i < arr.Length; i++){
            if(Array.Exists(arr, a => a == 2*arr[i]))
            {
                if(Array.IndexOf(arr, 2*arr[i]) != i)
                    return true;
            }
        }
        return false;
    }
}