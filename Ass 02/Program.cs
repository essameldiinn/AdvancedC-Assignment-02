using System.Collections;

namespace Ass_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "{[()]}"; // Change this to test different strings
            Console.WriteLine(IsBalanced(input) ? "Balanced" : "Not Balanced");

            #region Q1
            //int[] arr = { 5, 1, 7, 3, 9, 2 };
            //Array.Sort(arr);

            //int[] queries = { 4, 6, 1 };

            //foreach (int x in queries)
            //{
            //    int index = Array.BinarySearch(arr, x);

            //    if (index < 0)
            //        index = ~index;
            //    else
            //    {
            //        while (index < arr.Length && arr[index] == x)
            //            index++;
            //    }

            //    int countGreater = arr.Length - index;
            //    Console.WriteLine(countGreater);
            //}
            #endregion

            #region Q2
            //int[] arr = { 1, 2, 3, 2, 1 }; // Change this array to test other cases
            //int n = arr.Length;

            //// Check for palindrome
            //bool isPalindrome = true;
            //for (int i = 0; i < n / 2; i++)
            //{
            //    if (arr[i] != arr[n - 1 - i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //Console.WriteLine(isPalindrome ? "Palindrome" : "Not Palindrome");
            #endregion

            #region Q3
            //  Queue<int> queue = new Queue<int>();
            //  queue.Enqueue(10);
            //  queue.Enqueue(20);
            //  queue.Enqueue(30);
            //  queue.Enqueue(40);

            //  Console.WriteLine("Original Queue:");
            //  PrintQueue(queue);

            //  ReverseQueue(queue);

            //  Console.WriteLine("Reversed Queue:");
            //  PrintQueue(queue);


            //static void ReverseQueue(Queue<int> queue)
            //{
            //  Stack<int> stack = new Stack<int>();

            //  while (queue.Count > 0)
            //  {
            //      stack.Push(queue.Dequeue());
            //  }

            //  while (stack.Count > 0)
            //  {
            //      queue.Enqueue(stack.Pop());
            //  }
            //}

            //  static void PrintQueue(Queue<int> queue)
            // {
            //  foreach (var item in queue)
            //  {
            //      Console.Write(item + " ");
            //  }
            //  Console.WriteLine();

            // }
            #endregion

            #region Q4
            //static bool IsBalanced(string s)
            //{
            //    Stack<char> stack = new Stack<char>();

            //    foreach (char ch in s)
            //    {
            //        if (ch == '(' || ch == '{' || ch == '[')
            //        {
            //            stack.Push(ch);
            //        }
            //        else if (ch == ')' || ch == '}' || ch == ']')
            //        {
            //            if (stack.Count == 0) return false;

            //            char top = stack.Pop();
            //            if (!IsMatchingPair(top, ch))
            //                return false;
            //        }
            //    }

            //    return stack.Count == 0;
            //}

            //static bool IsMatchingPair(char open, char close)
            //{
            //    return (open == '(' && close == ')') ||
            //           (open == '{' && close == '}') ||
            //           (open == '[' && close == ']');
            //}
            #endregion

            #region Q5
            //static int[] RemoveDuplicates(int[] arr)
            //{
            //    return arr.Distinct().ToArray();
            //}
            #endregion

            #region Q6
            //static List<int> ExtractIntegers(ArrayList arrayList)
            //{
            //    List<int> integers = new List<int>();
            //    foreach (var item in arrayList)
            //    {
            //        if (item is int)
            //            integers.Add((int)item);
            //    }
            //    return integers;
            //}
            #endregion

            #region Q7

            //Queue mixedQueue = new Queue();

            //mixedQueue.Enqueue(1);
            //mixedQueue.Enqueue("Hello");
            //mixedQueue.Enqueue(3.14);
            //mixedQueue.Enqueue(true);
            //mixedQueue.Enqueue('Q');

            //foreach (var item in mixedQueue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q8
            //static void SearchStack(Stack<int> stack, int target)
            //{
            //    Stack<int> tempStack = new Stack<int>(stack.Reverse()); // To maintain order
            //    int count = 0;
            //    bool found = false;

            //    while (tempStack.Count > 0)
            //    {
            //        count++;
            //        if (tempStack.Pop() == target)
            //        {
            //            found = true;
            //            break;
            //        }
            //    }

            //    if (found)
            //        Console.WriteLine($"Target was found successfully and the count = {count}");
            //    else
            //        Console.WriteLine("Target was not found");
            //}
            #endregion

            #region Q9

            #endregion

            #region Q10 

            #endregion
        }
    }
}
