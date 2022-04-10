public class LRUCache {

    Node head = new Node(0, 0);
    Node tail = new Node(0, 0);
    int capacity = 0;
    
    public LRUCache(int _capacity) {
        capacity = _capacity;
        head.next = tail;
        tail.prev = head;
    }
    
    Dictionary<int,Node> map = new Dictionary<int,Node>();
    
    public int Get(int key) {
        if(map.ContainsKey(key)){
            Node node = map[key];
            delete(node);
            insert(node);
            return node.value;
        }
        else
            return -1;
    }
    
    public void Put(int key, int value) {
        if(map.ContainsKey(key)){
            delete(map[key]);
        }
        else{
            if(map.Count == capacity)
                delete(tail.prev);
        }
        insert(new Node(key, value));
    }
    
    private void insert(Node node){
        map.Add(node.key, node);
        Node headNext = head.next;
        head.next = node;
        node.prev = head;
        node.next = headNext;
        headNext.prev = node;
    }
    
    private void delete(Node node){
        map.Remove(node.key);
        node.next.prev = node.prev;
        node.prev.next = node.next;
    }
    
    class Node{
        public int key;
        public int value;
        public Node prev = null;
        public Node next = null;
        public Node(int _key, int _value){
            key = _key;
            value = _value;
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */