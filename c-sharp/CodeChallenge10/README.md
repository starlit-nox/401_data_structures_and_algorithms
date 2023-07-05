# Code Challenge 10

**Assignment 1**
Create a class for a data-structure called a Stack.

    This data-structure should be able to accept a default value that gets placed in the stack when the data-structure is instantiated (constructed).

    
    The class should contain the following methods:

    push
        Arguments: value
        adds a new node with that value to the top of the stack with an O(1) Time performance.
    pop
        Arguments: none
        Returns: the value from node from the top of the stack
        Removes the node from the top of the stack
        Should raise exception when called on empty stack
    peek
        Arguments: none
        Returns: Value of the node located at the top of the stack
        Should raise exception when called on empty stack
    is empty
        Arguments: none
        Returns: Boolean indicating whether or not the stack is empty.

**Assignment 2**
Create a class for a data-structure called a Queue.

    This data-structure should be able to accept a default value that gets placed in the queue when the data-structure is instantiated (constructed).

    The class should contain the following methods:

    enqueue
        Arguments: value
        adds a new node with that value to the back of the queue with an O(1) Time performance.
    dequeue
        Arguments: none
        Returns: the value from node from the front of the queue
        Removes the node from the front of the queue
        Should raise exception when called on empty queue
    peek
        Arguments: none
        Returns: Value of the node located at the front of the queue
        Should raise exception when called on empty stack
    is empty
        Arguments: none
        Returns: Boolean indicating whether or not the queue is empty
