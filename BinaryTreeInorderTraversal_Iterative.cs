class HelloWorld {
    static void Main() {
        Node root= new Node(1,null,null);
        root.left =new Node(2,null,null);
        root.right = new Node(3,null,null);
        root.right.left = new Node(4,null,null);
        List<int> list = InorderTraversal(root);
        foreach(int c in list)
            System.Console.WriteLine(c.ToString());
    }
    public static List<int> InorderTraversal(Node root){
        List<int> list = new List<int>();
        if(root == null)
            return list;
        Node temp = root;
        Stack<Node> stack = new Stack<Node>();
        while(true){
            if(temp != null){
                stack.Push(temp);
                temp = temp.left;
            }
            else{
                if(stack.Count == 0)
                    break;
                temp = stack.Pop();
                list.Add(temp.val);
                temp = temp.right;
            }
        }
        return list;
    }
}
public class Node{
    public int val;
    public Node left;
    public Node right;
    public Node(int _val, Node _left, Node _right){
        val = _val;
        left = _left;
        right =_right;
    }
}