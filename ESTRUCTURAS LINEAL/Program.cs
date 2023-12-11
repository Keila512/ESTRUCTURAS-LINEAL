using System;

class Program
{
    static void Main()
    {
        int maxSize = 5; // MAXIMUM STACK AND QUEUE SIZE
        int[] stackArray = new int[maxSize];
        int[] queueArray = new int[maxSize];
        int stackTop = -1; // INITIALIZE THE TOP INDEX OF THE ROW
        int queueFront = 0; // INITIALIZE THE FRONT OF THE QUEUE
        int queueRear = -1; // INITIALIZE THE BACK OF THE TAIL
      


        while (true)
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Insert into Stack");
            Console.WriteLine("2. Remove from Stack");
            Console.WriteLine("3. Show stack");
            Console.WriteLine("4. Insert into queue");
            Console.WriteLine("5. Remove from queue");
            Console.WriteLine("6. Show queue");
            Console.WriteLine("7. Exit");

            Console.Write("Select an option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter a value to push onto the stack: ");
                    int valueToPush = Convert.ToInt32(Console.ReadLine());
                    Push(stackArray, maxSize, ref stackTop, valueToPush);
                    break;

                case 2:
                    Pop(stackArray, ref stackTop);
                    break;

                case 3:
                    DisplayStack(stackArray, stackTop);
                    break;

                case 4:
                    Console.Write("Enter a value to insert into the queue: ");
                    int valueToEnqueue = Convert.ToInt32(Console.ReadLine());
                    Enqueue(queueArray, maxSize, ref queueRear, valueToEnqueue);
                    break;

                case 5:
                    Dequeue(queueArray, ref queueFront, queueRear);
                    break;

                case 6:
                    DisplayQueue(queueArray, queueFront, queueRear);
                    break;

                case 7:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void Push(int[] stack, int maxSize, ref int top, int value)
    {
        if (top < maxSize - 1)
        {
            stack[++top] = value;
            Console.WriteLine($"{value} has been inserted into the stack.");
        }
        else
        {
            Console.WriteLine("The stack is full. Cannot insert more elements.");
        }
    }

    static void Pop(int[] stack, ref int top)
    {
        if (top >= 0)
        {
            int poppedValue = stack[top--];
            Console.WriteLine($"{poppedValue} has been removed from the stack.");
        }
        else
        {
            Console.WriteLine("The stack is empty. Cannot delete more items.");
        }
    }

    static void DisplayStack(int[] stack, int top)
    {
        if (top >= 0)
        {
            Console.WriteLine("Stack Contents:");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
        else
        {
            Console.WriteLine("The stack is empty.");
        }
    }

    static void Enqueue(int[] queue, int maxSize, ref int rear, int value)
    {
        if (rear < maxSize - 1)
        {
            queue[++rear] = value;
            Console.WriteLine($"{value} has been inserted into the queue.");
        }
        else
        {
            Console.WriteLine("The queue is full. Cannot insert more elements.");
        }
    }

    static void Dequeue(int[] queue, ref int front, int rear)
    {
        if (front <= rear)
        {
            int dequeuedValue = queue[front++];
            Console.WriteLine($"{dequeuedValue} has been removed from the queue.");
        }
        else
        {
            Console.WriteLine("The queue is empty. Cannot delete more items.");
        }
    }

    static void DisplayQueue(int[] queue, int front, int rear)
    {
        if (front <= rear)
        {
            Console.WriteLine("Queue content:");
            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }
        else
        {
            Console.WriteLine("The queue is empty.");
        }
    }
}