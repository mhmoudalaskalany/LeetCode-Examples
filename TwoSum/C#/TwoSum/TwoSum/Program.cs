// Example 1
var l1 = CreateLinkedList(new int[] { 2, 4, 3 });
var l2 = CreateLinkedList(new int[] { 5, 6, 4 });
var result = AddTwoNumbers(l1, l2);
PrintLinkedList(result);  // Output: 7 0 8

// Example 2
l1 = CreateLinkedList(new int[] { 0 });
l2 = CreateLinkedList(new int[] { 0 });
result = AddTwoNumbers(l1, l2);
PrintLinkedList(result);  // Output: 0

// Example 3
l1 = CreateLinkedList(new int[] { 9, 9, 9, 9, 9, 9, 9 });
l2 = CreateLinkedList(new int[] { 9, 9, 9, 9 });
result = AddTwoNumbers(l1, l2);
PrintLinkedList(result);  // Output: 8 9 9 9 0 0 0 1

static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    ListNode dummy = new ListNode();
    ListNode current = dummy;
    int carry = 0;

    while (l1 != null || l2 != null || carry != 0)
    {
        int sum = carry;

        if (l1 != null)
        {
            sum += l1.Val;
            l1 = l1.Next;
        }

        if (l2 != null)
        {
            sum += l2.Val;
            l2 = l2.Next;
        }

        carry = sum / 10;
        sum = sum % 10;

        current.Next = new ListNode(sum);
        current = current.Next;
    }

    return dummy.Next;
}

static ListNode CreateLinkedList(int[] values)
{
    ListNode dummy = new ListNode();
    ListNode current = dummy;
    foreach (var val in values)
    {
        current.Next = new ListNode(val);
        current = current.Next;
    }
    return dummy.Next;
}

static void PrintLinkedList(ListNode node)
{
    while (node != null)
    {
        Console.Write(node.Val + " ");
        node = node.Next;
    }
    Console.WriteLine();
}

class ListNode
{
    public int Val;
    public ListNode Next;
    public ListNode(int val = 0, ListNode next = null)
    {
        Val = val;
        Next = next;
    }
}
