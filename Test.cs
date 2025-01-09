using NUnit.Framework;

namespace leetcode
{
    [TestFixture] // 表示這是一個測試類別
    public class Tests
    {
        [Test] // 表示這是一個測試方法
        public void TestTwoSum()
        {
            int[] ex1 = { 2, 7, 11, 15 };
            var result = TwoSum.twosum(ex1, 9);
            Assert.AreEqual(new int[] { 0, 1 }, result);
        }

        [Test]
        public void TestAddTwoNumbers()
        {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            var result = Addtwonums.addTwoNumbers(l1, l2);
            var expected = new ListNode(7);
            expected.next = new ListNode(0);
            expected.next.next = new ListNode(8);

            while (result != null && expected != null)
            {
                Assert.AreEqual(result.val, expected.val);
                result = result.next;
                expected = expected.next;
            }
        }

        [Test]
        public void TestLengthOfLongestSubstring()
        {
            string s = "pwwkew";
            var result = LengthOfLongest.LengthOfLongestSubstring(s);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TestFindMedianSortedArrays()
        {
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };
            var result = findMedianSortedArrays.FindMedianSortedArrays(nums1, nums2);
            Assert.AreEqual(2.0, result);

            int[] nums3 = { 1, 2 };
            int[] nums4 = { 3, 4 };
            var result2 = findMedianSortedArrays.FindMedianSortedArrays(nums3, nums4);
            Assert.AreEqual(2.5, result2);

        }

        [Test]
        public void TestLongestPalindromic()
        {
            string s = "babad";
            var result = Longest_palindromic.longest_palindromic(s);
            Assert.AreEqual(3, result);

            string s2 = "cbbd";
            var result2 = Longest_palindromic.longest_palindromic(s2);
            Assert.AreEqual(2, result2);

        }
    }
}
//dotnet test

