class HelloWorld {
    static void Main() {
        QueueArr myQ = new QueueArr();
        myQ.enqueue(10);
        myQ.enqueue(9);
        myQ.enqueue(8);
        myQ.enqueue(7);
        myQ.enqueue(6);
        myQ.enqueue(5);
        Console.WriteLine("Enqueue Complete");
        myQ.display();
        myQ.dequeue();
        myQ.dequeue();
        myQ.dequeue();
        Console.WriteLine("Dequeue Complete");
        myQ.display();
        myQ.peek();
    }
}

class QueueArr{
    public Node rear = null;
    public Node front = null;
    public int count = 0;
    
    public void enqueue(int val){
        Node newNode = new Node(val);
        //empty queue
        if(IsEmpty())
            front = newNode;
        
        //not empty queue
        else
            rear.next = newNode;
        rear = newNode;
        rear.next = front;
        count++;
    }
    
    public void dequeue(){
        //empty queue
        if(IsEmpty())
            return;
        front = front.next;
        if(front == null)
            rear = null;
        rear.next = front;
        count--;
    }
    
    public void display(){
        if(IsEmpty())
            return;
        Node head = front;
        while(head.next != front)
        {
            System.Console.WriteLine("Element = " + head.data.ToString());
            head = head.next;
        }
        System.Console.WriteLine("Element = " + head.data.ToString());
    }
    
    public void peek(){
        if(front == null)
            return;
        System.Console.WriteLine("Element peeked = " + front.data.ToString());
    }
    
    private bool IsEmpty(){
        return front == null && rear == null;
    }
}

class Node{
    public int data;
    public Node next;
    public Node(int _data){
        data = _data;
        next = null;
    }
}