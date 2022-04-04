class HelloWorld {
    static void Main() {
        Node l1 = new Node(7);
        l1.next = new Node(6);
        l1.next.next = new Node(3);
        Node l2 = new Node(1);
        l2.next = new Node(8);
        l2.next.next = new Node(1);
        Node AddTwoNumbers(Node l1, Node l2){
            Node result = new Node(0);
            Node temp = result;
            int carry = 0;
            while(l1 != null || l2 != null || carry != 0){
                int sum = 0;
                if(l1 != null){
                    sum = l1.val;
                    l1 = l1.next;
                }
                if(l2 != null){
                    sum = sum + l2.val;
                    l2 = l2.next;
                }
                sum = (sum + carry);
                Node newNode = new Node(sum%10);
                temp.next = newNode;
                temp = temp.next;
                carry = sum/10;
            }
            return result.next;
        }
        Node sumList = AddTwoNumbers(l1,l2);
        while(sumList != null){
            Console.Write(sumList.val.ToString());
            sumList = sumList.next;
        }
    }
}
public class Node{
    public int val;
    public Node next;
    public Node(int _val){
        val = _val;
        next = null;
    }
}