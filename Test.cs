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

        [Test]
        public void TestConvert()
        {
            string s = "PAYPALISHIRING";
            var result = Zigzag.Convert(s, 3);
            Assert.AreEqual("PAHNAPLSIIGYIR", result);

            string s2 = "PAYPALISHIRING";
            var result2 = Zigzag.Convert(s2, 4);
            Assert.AreEqual("PINALSIGYAHRPI", result2);
        }

        [Test]
        public void TestReverse()
        {
            int x = 123;
            var result = ReverseInteger.reverse(x);
            Assert.AreEqual(321, result);

            int x2 = -123;
            var result2 = ReverseInteger.reverse(x2);
            Assert.AreEqual(-321, result2);

            int x3 = 120;
            var result3 = ReverseInteger.reverse(x3);
            Assert.AreEqual(21, result3);

            int x4 = 0;
            var result4 = ReverseInteger.reverse(x4);
            Assert.AreEqual(0, result4);

            int x5 = 1534236469;
            var result5 = ReverseInteger.reverse(x5);
            Assert.AreEqual(0, result5);
        }

        [Test]
        public void TestMyAtoi()
        {
            string s = "42";
            var result = Stringtoint.stringtoint(s);
            Assert.AreEqual(42, result);

            string s2 = "   -42";
            var result2 = Stringtoint.stringtoint(s2);
            Assert.AreEqual(-42, result2);

            string s3 = "4193 with words";
            var result3 = Stringtoint.stringtoint(s3);
            Assert.AreEqual(4193, result3);

            string s4 = "words and 987";
            var result4 = Stringtoint.stringtoint(s4);
            Assert.AreEqual(0, result4);

            string s5 = "-91283472332";
            var result5 = Stringtoint.stringtoint(s5);
            Assert.AreEqual(-2147483648, result5);
        }

        [Test]
        public void TestIsPalindrome()
        {
            int x = 121;
            var result = Palindrome.IsPalindrome(x);
            Assert.AreEqual(true, result);

            int x2 = -121;
            var result2 = Palindrome.IsPalindrome(x2);
            Assert.AreEqual(false, result2);

            int x3 = 10;
            var result3 = Palindrome.IsPalindrome(x3);
            Assert.AreEqual(false, result3);
        }

        [Test]
        public void TestIsMatch()
        {
            string s = "aa";
            string p = "a";
            var result = Regularexpression.IsMatch(s, p);
            Assert.AreEqual(false, result);

            string s2 = "aa";
            string p2 = "a*";
            var result2 = Regularexpression.IsMatch(s2, p2);
            Assert.AreEqual(true, result2);

            string s3 = "ab";
            string p3 = ".*";
            var result3 = Regularexpression.IsMatch(s3, p3);
            Assert.AreEqual(true, result3);

            string s4 = "aab";
            string p4 = "c*a*b";
            var result4 = Regularexpression.IsMatch(s4, p4);
            Assert.AreEqual(true, result4);

            string s5 = "mississippi";
            string p5 = "mis*is*p*.";
            var result5 = Regularexpression.IsMatch(s5, p5);
            Assert.AreEqual(false, result5);
        }

        [Test]
        public void TestMaxArea()
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var result = MostWater.MaxArea(height);
            Assert.AreEqual(49, result);
        }

        [Test]
        public void TestIntToRoman()
        {
            int num = 3;
            var result = IntegerToRoman.IntToRoman(num);
            Assert.AreEqual("III", result);

            int num2 = 4;
            var result2 = IntegerToRoman.IntToRoman(num2);
            Assert.AreEqual("IV", result2);

            int num3 = 9;
            var result3 = IntegerToRoman.IntToRoman(num3);
            Assert.AreEqual("IX", result3);

            int num4 = 58;
            var result4 = IntegerToRoman.IntToRoman(num4);
            Assert.AreEqual("LVIII", result4);

            int num5 = 1994;
            var result5 = IntegerToRoman.IntToRoman(num5);
            Assert.AreEqual("MCMXCIV", result5);
        }

        [Test]
        public void TestThreeSum()
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            var result = ThreeSum.threeSum(nums);
            Assert.AreEqual(2, result.Count);

            int[] nums2 = {0,1,1 };
            var result2 = ThreeSum.threeSum(nums2);
            Assert.AreEqual(0, result2.Count);

            int[] nums3 = { 0, 0, 0 };
            var result3 = ThreeSum.threeSum(nums3);
            Assert.AreEqual(1, result3.Count);
         
        }

        [Test]
        public void TestThreeSumClosest()
        {
            int[] nums = { -1, 2, 1, -4 };
            var result = threeSumClosest.ThreeSumClosest(nums, 1);
            Assert.AreEqual(2, result);

            int[] nums2 = { 1, 1, 1, 0 };
            var result2 = threeSumClosest.ThreeSumClosest(nums2, -100);
            Assert.AreEqual(2, result2);
        }
    }
}
//dotnet test

