import java.util.*;

class PseudoQueue <T> {
    public static void main(String[] args) throws Exception{
        PseudoQueue<Integer> queue1 = new PseudoQueue<Integer>();
        queue1.enqueue(1);
        queue1.enqueue(3);
        queue1.enqueue(5);
        System.out.println("queue1.isEmpty() = " + queue1.isEmpty());
        System.out.println("queue1.dequeue() = " + queue1.dequeue());
        System.out.println("queue1.peek() = " + queue1.peek());
        System.out.println("queue1.dequeue() = " + queue1.dequeue());
        System.out.println("queue1.dequeue() = " + queue1.dequeue());
        System.out.println("queue1.isEmpty() = " + queue1.isEmpty());

    }

    Stack<T> inStack = new Stack();
    Stack<T> outStack = new Stack();



    public void enqueue(T value){
        inStack.push(value);
    }

    public T dequeue() throws Exception{
        if(outStack.isEmpty()){
            while(!inStack.isEmpty()){
                outStack.push(inStack.pop());
            }
            if(outStack.isEmpty()) throw new Exception("PsuedoQueue is empty");
        }

        return outStack.pop();
    }

    public T peek() throws Exception{
        if(outStack.isEmpty()){
            while(!inStack.isEmpty()){
                outStack.push(inStack.pop());
            }
            if(outStack.isEmpty()) throw new Exception("PsuedoQueue is empty");
        }

        return outStack.peek();
    }

    public boolean isEmpty(){
        if(outStack.isEmpty() && inStack.isEmpty()) return true;
        return false;
    }

}

