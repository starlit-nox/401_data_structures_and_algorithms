import java.util.*;

class Stack <T> {
    public static void main(String[] args) throws Exception{
        Stack<Integer> stack1 = new Stack<>();
        stack1.push(1);
        stack1.push(3);
        stack1.push(5);
        System.out.println("stack1 = " + stack1);
        System.out.println("stack1.isEmpty() = " + stack1.isEmpty());
        System.out.println("stack1.pop() = " + stack1.pop());
        System.out.println("stack1.peek() = " + stack1.peek());
        System.out.println("stack1.pop() = " + stack1.pop());
        System.out.println("stack1.pop() = " + stack1.pop());
        System.out.println("stack1.isEmpty() = " + stack1.isEmpty());
        System.out.println("stack1 = " + stack1);

    }

    Node<T> top;

    public void push(T value){
        top = new Node<>(value, top);
    }

    public T pop() throws Exception{
        if(top == null) throw new Exception("stack is empty");
        T val = top.value;
        top = top.next;
        return val;
    }

    public T peek() throws Exception{
        if(top == null) throw new Exception("queue is empty");
        return top.value;
    }

    public boolean isEmpty(){
        if(top == null) return true;
        return false;
    }


    public String toString(){
        StringBuilder stringified = new StringBuilder();
        Node<T> current = top;

        while(current != null){
            stringified.append("{" + current.value + "} -> ");
            current = current.next;
        }
        stringified.append("NULL");
        return stringified.toString();
    }

}
