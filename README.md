# Task-Sorter

The application is a priority queue that makes a Task list for the user. Each Task item could have one
of four priorities: Critical, Important, Normal, or Low. The items should be ordered in the queue so that
all Critical priority items are at the front and all Low priority items are at the end.

The queue represents a linked list of Task objects. You need to include the following components (plus some others) to have a functional
  Queue class:
          a. First: a reference to the first Task in the list
          b. Count: an integer counting the number of elements in the list
          c. Enqueue(): a function that will add a new item to the list IN THE CORRECT PLACE
          d. Dequeue(): a function that returns and removes the first Task in the list.
          e. Peek(): a function that lets you view the first Task in the list but does not remove it from the list.
