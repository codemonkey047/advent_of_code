﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_16_1_1
{
    class Coordinate
    {
        public Coordinate(int y, int x)
        {
            Y = y;
            X = x;
        }

        public int X { get; }
        public int Y { get; }

        public override bool Equals(Object o)
        {
            var other = (Coordinate) o;
            if (other == null) return false;
            return this.X == other.X && this.Y == other.Y;
        }

        public override int GetHashCode()
        {
            return this.X.GetHashCode() + this.Y.GetHashCode();
        }
    }
}
