using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Assert = NUnit.Framework.Assert;

namespace TestApp
{
    class SimpleLambda
    {
        public IEnumerable<int> EvenNumbers(List<int> numbers){
            return numbers.FindAll(number => (number % 2) == 0);
        }

        public IEnumerable<int> SquareNumber(List<int> numbers) {
            return numbers.Select(number => number * number);
        }

        public  void Each<T>(IEnumerable<T> items, Action<T> action){
            foreach (var item in items)
                action(item);
        }
    }
}
