class HelloWorld {
    static void Main() {
        QueueArr myQ = new QueueArr(5);
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
    }
}
class QueueArr{
    int[] ele;
    int max;
    int front;
    int rear;
    public QueueArr(int size){
        ele = new int[size];
        max = size;
        front = 0;
        rear = -1;
    }
    public void enqueue(int val){
        if(IsFull())
            return;
        else
        {
            if(front == -1)
                front = 0;
            ele[++rear] = val;
        }
    }
    public void dequeue(){
        if(IsEmpty())
            return;
        else{
            if(front >= rear)
            {
                front = -1;
                rear = -1;
            }
            else
                front++;
        }
    }
    public void display(){
        if(!IsEmpty()){
            for(int i = front; i < rear + 1; i++)
                Console.WriteLine("Element at " + i.ToString() + "= " + ele[i].ToString());
        }
    }
    private bool IsEmpty(){
        if(rear == -1)
            return true;
        else
            return false;
    }
    private bool IsFull(){
        if(rear == max-1)
            return true;
        else
            return false;
    }
}