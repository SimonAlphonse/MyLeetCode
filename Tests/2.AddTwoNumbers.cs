using MyLeetCode.AddTwoNumbers;

using static MyLeetCode.AddTwoNumbers.Solution;

public partial class Tests
{
    [Theory]
    [InlineData(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8 })]
    [InlineData(new[] { 0 }, new[] { 0 }, new[] { 0 })]
    [InlineData(new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 }, new[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
    public void _2_AddTwoNumbers(int[] l1, int[] l2, int[] expected)
    {
        var actual = ListNodeToArray(Solution.AddTwoNumbers(ArrayToListNode(l1), ArrayToListNode(l2)));
        Assert.Equal(expected, actual);
    }

    private int[] ListNodeToArray(ListNode listNode)
    {
        List<int> result = [];

        var current = listNode;

        do
        {
            result.Add(current.val);
            current = current.next;
        } while (current != null);

        return [.. result];
    }
}