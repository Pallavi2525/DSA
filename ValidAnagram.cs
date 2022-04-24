//LeetCode - 242. Valid Anagram

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        Dictionary<int,int> sMap = new Dictionary<int,int>();
        Dictionary<int,int> tMap = new Dictionary<int,int>();
        for(int i = 0; i < s.Length; i++){
            if(!sMap.ContainsKey(s[i]))
                sMap.Add(s[i],1);
            else
                sMap[s[i]]++;
        }
        for(int i = 0 ; i < t.Length; i++){
            if(!tMap.ContainsKey(t[i]))
                tMap.Add(t[i],1);
            else
                tMap[t[i]]++;
            //Console.WriteLine("t[i] = " + t[i].ToString() + " =>" +sMap[t[i]]);
        }
        foreach(var item in sMap){
            if(tMap.ContainsKey(item.Key)){
                if(tMap[item.Key] != item.Value)
                    return false;
            }
            else
                return false;
        }
        return true;
    }
}