public static class Priority
{
    public static void Test()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: What happens if there are more than one items that are listed as highest priority, 
        //           the the item that is closest to the front of the queue should be removed and its value returned.
        // Expected Result: Dequeue should return the first priority of the highest number
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Take test", 4);
        Console.WriteLine(priorityQueue);
        var lastValueTest3 = priorityQueue.Dequeue();
        Console.WriteLine($"Dequeued value: {lastValueTest3}");
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: Dequeue is removing wrong instance of high priority

        Console.WriteLine("---------");

        // Test 2
        // Scenario: The Enqueue function shall add an item to the back of the queue.

        // Expected Result: Add 3 elements to the queue
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("School", 4);
        priorityQueue.Enqueue("Family", 1);
        priorityQueue.Enqueue("Church", 2);
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Is there an error message displayed if queu is empty.
        // Expected Result: Error message should display
        Console.WriteLine("Test 3");
        var priorityQueue2 = new PriorityQueue();
        // Console.WriteLine(priorityQueue);
        priorityQueue2.Dequeue();

        // Defect(s) Found: none

        Console.WriteLine("---------");

        // Test 4
        // Scenario: Dequeue should remove the item with the highest priority and return its value.
        // Expected Result: Dequeue should return the highest number
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Take kids to school", 6);
        priorityQueue.Enqueue("Make dinner", 6);
        priorityQueue.Enqueue("Do homework", 4);

        var lastValueTest2 = priorityQueue.Dequeue();
        Console.WriteLine($"Dequeued value: {lastValueTest2}");
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: Dequeue wasn't removing the element from the list


        // Add more Test Cases As Needed Below
    }
}