public class LRUCache {

    class Node{
        public int val;  
        public int key;
        public Node next = null;
        public Node prev = null;
        public Node(int _key, int _val){
            key = _key;
            val = _val;
        }
    }
    
    Node head = new Node(0,0);
    Node tail = new Node(0,0);
    
    public int cap;
    Dictionary<int,Node> map = new Dictionary<int,Node>();
    
    public LRUCache(int _capacity) {
        cap = _capacity;
        head.next = tail;
        tail.prev = head;
    }
    
    public int Get(int key) {
        if(map.ContainsKey(key)){
            Node node = map[key];
            DeleteNode(node);
            InsertNode(node);
            return node.val;
        }
        else
            return -1;
    }
    
    public void Put(int key, int value) {
        if(map.ContainsKey(key))
            DeleteNode(map[key]);
        if(map.Count == cap)
            DeleteNode(tail.prev);
        InsertNode(new Node(key, value));
    }
    
    private void InsertNode(Node node){
        if(!map.ContainsKey(node.key))
            map.Add(node.key, node);
        else
            map[node.key] = node;
        Node headNext = head.next;
        head.next = node;
        node.prev = head;
        headNext.prev = node;
        node.next = headNext;
    }
    
    private void DeleteNode(Node node){
        map.Remove(node.key);
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */