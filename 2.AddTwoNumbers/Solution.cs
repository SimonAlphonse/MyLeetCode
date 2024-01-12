namespace MyLeetCode.AddTwoNumbers
{
    public static partial class Solution
    {
        public static void Main()
        {
           
        }

        public class ListNode(int val = 0, ListNode next = null)
        {
            public int val { get; set; } = val;
            public ListNode next { get; set; } = next;
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            List<int> result = [];
            ListNode t1 = l1, t2 = l2;

            while (t1 is not null || t2 is not null)
            {
                int added = (t1?.val ?? 0) + (t2?.val ?? 0) + carry;
                result.Add(added % 10);
                carry = added >= 10 ? 1 : 0;
                t1 = t1?.next; t2 = t2?.next;
            }

            if (carry == 1) { result.Add(carry); }

            return ArrayToListNode(result);
        }

        public static ListNode ArrayToListNode(IEnumerable<int> values)
        {
            ListNode head = new(values.First());
            ListNode current = head;

            for (int i = 1; i < values.Count(); i++)
            {
                current.next = new ListNode(values.Skip(i).First());
                current = current.next;
            }

            return head;
        }
    }
}