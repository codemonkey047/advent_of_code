﻿using NUnit.Framework;

namespace Day20
{
    // ReSharper disable once InconsistentNaming
    class RangeCompare_should
    {
        [Test]
        public void initialize_with_range_array()
        {
            var input = new [] {"1-2", "2-3"};
            var ranges = new RangeCompare(input, 10);
            Assert.AreEqual(input.Length, ranges.Length);
        }

        [Test]
        public void initialize_with_range_array_skip_duplicates()
        {
            var input = new[] { "1-2", "2-3", "1-5" };
            var ranges = new RangeCompare(input, 10);
            Assert.AreEqual(2, ranges.Length);
        }

        [Test]
        public void return_first_non_blocked_int()
        {
            var input = new[] { "0-3", "2-4" };
            var ranges = new RangeCompare(input, 10);
            ranges.CalculateNonBlocked();
            Assert.AreEqual(5, ranges.First);
        }

        [Test]
        public void return_first_non_blocked_int_considering_duplicates()
        {
            var input = new[] { "0-3", "2-4", "2-3" };
            var ranges = new RangeCompare(input, 10);
            ranges.CalculateNonBlocked();
            Assert.AreEqual(5, ranges.First);
        }

        [Test]
        public void return_zero_if_first()
        {
            var input = new[] { "1-3", "2-4", "2-3" };
            var ranges = new RangeCompare(input, 10);
            ranges.CalculateNonBlocked();
            Assert.AreEqual(0, ranges.First);
        }

        [Test]
        public void convert_input_to_pair()
        {
            string input = "1-2";
            int start;
            int end;

            RangeCompare.ConvertInputToInt(input, out start, out end);
            
            Assert.AreEqual(1, start);
            Assert.AreEqual(2, end);
        }

        [Test]
        public void return_count_of_allowed_in_range()
        {
            var input = new[] { "1-3", "2-4", "2-3" };
            var ranges = new RangeCompare(input, 10);
            ranges.CalculateNonBlocked();
            Assert.AreEqual(7, ranges.Count);
        }
    }
}