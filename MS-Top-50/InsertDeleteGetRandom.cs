//LeetCode - 380. Insert Delete GetRandom O(1)

public class RandomizedSet {

    Dictionary<int,int> map;
    List<int> numsList; 
    Random rnd;
    
    public RandomizedSet() {
        map = new Dictionary<int,int>();
        numsList = new List<int>();
        rnd = new Random();
    }
    
    public bool Insert(int val) {
        if(!map.ContainsKey(val)){
            map.Add(val, numsList.Count);
            numsList.Add(val);
            return true;
        }    
        else
            return false;
    }
    
    public bool Remove(int val) {
        if(map.ContainsKey(val)){
            int lastElementVal = numsList[numsList.Count - 1];
            int delElementIdx = map[val];
            numsList[delElementIdx] = lastElementVal;
            map[lastElementVal] = delElementIdx;
            numsList.RemoveAt(numsList.Count - 1);
            map.Remove(val);
            return true;
        }
        else
            return false;
    }
    
    public int GetRandom() {
        int randomIdx = rnd.Next(numsList.Count);
        return numsList[randomIdx];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */