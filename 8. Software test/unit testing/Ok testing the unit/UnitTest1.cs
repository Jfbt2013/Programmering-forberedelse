
using NuGet.Frameworks;
using Sorter;
using System.Runtime.InteropServices;

namespace Ok_testing_the_unit
{
    public class SortingTests
    {

        private Sorting2 _Sorting2 { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _Sorting2 = new Sorting2();
        }

        [Test]
        public void SortingAscending_EqualTest1()
        {
            //Assign
            List<int> xi = new List<int>();
            xi.Add(2); xi.Add(5); xi.Add(7); xi.Add(35); xi.Add(40); xi.Add(42); xi.Add(6); xi.Add(98); xi.Add(11);
            
            //Act
            var thesort = _Sorting2.sortingAscending(xi);

            //Assert
            Assert.AreEqual(thesort[8],98);
        }
        [Test]
        public void SortingAscending_EqualTest2()
        {
            //Assign
            List<int> xi = new List<int>();
            xi.Add(2); xi.Add(5); xi.Add(7); xi.Add(35); xi.Add(40); xi.Add(42); xi.Add(6); xi.Add(98); xi.Add(11);

            //Act
            var thesort = _Sorting2.sortingAscending(xi);

            //Assert
            Assert.AreEqual(thesort[0], 2);
        }
        [Test]
        public void SortingDescending_EqualTest1()
        {
            List<int> xi = new List<int>();
            xi.Add(2); xi.Add(5); xi.Add(7); xi.Add(35); xi.Add(40); xi.Add(42); xi.Add(6); xi.Add(98); xi.Add(11);

            //Act
            var thesort = _Sorting2.sortingDescending(xi);

            //Assert
            Assert.AreEqual(thesort[0], 98);
        }
        [Test]
        public void SortingDescending_EqualTest2()
        {
            List<int> xi = new List<int>();
            xi.Add(2); xi.Add(5); xi.Add(7); xi.Add(35); xi.Add(40); xi.Add(42); xi.Add(6); xi.Add(98); xi.Add(11);

            //Act
            var thesort = _Sorting2.sortingDescending(xi);

            //Assert
            Assert.AreEqual(thesort[8], 2);
        }
    }
}

