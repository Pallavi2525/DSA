public class MyHashMap {
    
    private Node[] buckets;
    private const int size = 10000;
    
    public MyHashMap() {
        buckets = new Node[size];
    }
    
    private int Hash(int key){
        return (key % size);
    }
    
    public void Put(int key, int value) {
        int bucket = Hash(key);
        if(buckets[bucket] == null){
            buckets[bucket] = new Node(key, value);
        }
        else{
            Node head = buckets[bucket];
            while(true){
                if(head.key == key){
                    head.value = value;
                    return;
                }
                if(head.next == null){
                    break;
                }
                else
                    head = head.next;
            }
            head.next = new Node(key, value);
        }
    }
    
    public int Get(int key) {
        int bucket = Hash(key);
        if(buckets[bucket] == null)
            return -1;
        else{
            Node head = buckets[bucket];
            while(true){
            if(head.key == key)
                return head.value;
                else{
                if(head.next == null)
                    break;
                else
                    head = head.next;
                }
            }
        }
        return -1;
    }
    
    public void Remove(int key) {
        int bucket = Hash(key);
        if(buckets[bucket] == null)
            return;
        else{
            Node head = buckets[bucket];
            if(head.key == key)
            {
                buckets[bucket] = head.next;
                head = null;
                return;
            }
            else{
                while(head.next != null){
                    if(head.next.key == key)
                    {
                        head.next = head.next.next;
                        return;
                    }
                    head = head.next;
                }
            }
        }
    }
}

public class Node{
    public int key;
    public int value;
    public Node next;
    public Node(int _key, int _value){
        key = _key;
        value = _value;
        next = null;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */