import java.util.*;

class Queue <T> {
    public static void main(String[] args) throws Exception{
        Queue<Integer> queue1 = new Queue<>();
        queue1.enqueue(1);
        queue1.enqueue(3);
        queue1.enqueue(5);
        System.out.println("queue1 = " + queue1);
        System.out.println("queue1.isEmpty() = " + queue1.isEmpty());
        System.out.println("queue1.dequeue() = " + queue1.dequeue());
        System.out.println("queue1.peek() = " + queue1.peek());
        System.out.println("queue1.dequeue() = " + queue1.dequeue());
        System.out.println("queue1.dequeue() = " + queue1.dequeue());
        System.out.println("queue1.isEmpty() = " + queue1.isEmpty());
        System.out.println("queue1 = " + queue1);

    }

    Node<T> front;
    Node<T> back;



    public void enqueue(T value){
        Node<T> newNode = new Node<>(value, null);
        if(back == null) {
            back = newNode;
            front = newNode;
        } else {
            back.next = newNode;
            back = back.next;
        }
    }

    public T dequeue() throws Exception{
        if(front == null) throw new Exception("queue is empty");
        T val = front.value;
        front = front.next;
        if(front == null) back = front;
        return val;
    }

    public T peek() throws Exception{
        if(front == null) throw new Exception("queue is empty");
        return front.value;
    }

    public boolean isEmpty(){
        if(front == null) return true;
        return false;
    }


    public String toString(){
        StringBuilder stringified = new StringBuilder();
        Node<T> current = front;

        while(current != null){
            stringified.insert(0, "{" + current.value + "} -> ");
            current = current.next;
        }
        stringified.append("NULL");
        return stringified.toString();
    }

}

