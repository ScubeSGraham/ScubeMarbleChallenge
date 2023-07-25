namespace MarbleTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMarble()
        {
            Marble marble = new Marble();
            marble.Id = 1;
            marble.Name = "Bob";
            marble.Color = "blue";
            marble.Weight = 0.5;

            Assert.AreEqual(1, marble.Id);
            Assert.AreEqual(0.5, marble.Weight);
            Assert.AreEqual("Bob", marble.Name);
            Assert.AreEqual("blue", marble.Color);
        }

        [TestMethod]
        public void TestClean()
        {
            String testString = "Bob o’Bob";
            String cleanString = StringHelper.CleanString(testString);

            Assert.AreEqual("bobobob", cleanString);
        }

        [TestMethod]
        public void TestReverse()
        {
            String testString = "reversethisstring";
            String reverseString = StringHelper.ReverseString(testString);

            Assert.AreEqual("gnirtssihtesrever", reverseString);
        }

        [TestMethod]
        public void TestPalindrome()
        {
            String trueString = "Bob O'Bob";
            String falseString = "Bob O'Bobb";
            bool isPalindrome = StringHelper.IsPalindrome(trueString);
            bool notPalindrom = StringHelper.IsPalindrome(falseString);

            Assert.IsTrue(isPalindrome);
            Assert.IsFalse(notPalindrom);
        }

        [TestMethod]
        public void TestSortAndFilter()
        {
            List<Marble> marbleList = new List<Marble>()
            { 
                new Marble() {Id = 1, Color = "blue", Weight = 0.5, Name = "Bob"},
                new Marble() {Id = 2, Color = "red", Weight = 0.25, Name = "John Smith"},
                new Marble() {Id = 3, Color = "violet", Weight = 0.5, Name = "Bob O'Bob"},
                new Marble() {Id = 4, Color = "indigo", Weight = 0.75, Name = "Bob Dad-Bob"},
                new Marble() {Id = 5, Color = "yellow", Weight = 0.5, Name = "John"},
                new Marble() {Id = 6, Color = "orange", Weight = 0.25, Name = "Bob"},
                new Marble() {Id = 7, Color = "blue", Weight = 0.5, Name = "Smith"},
                new Marble() {Id = 8, Color = "blue", Weight = 0.25, Name = "Bob"},
                new Marble() {Id = 9, Color = "green", Weight = 0.75, Name = "Bobb Ob"},
                new Marble() {Id = 10, Color = "blue", Weight = 0.5, Name = "Bob"}
            };

            List<Marble> sortedMarbles = MarbleChallenge.SortAndFilter(marbleList);

            // 9, 1, 10, 4, 3

            Assert.AreEqual(5, marbleList.Count);
            Assert.AreEqual(9, marbleList[0].Id);
            Assert.AreEqual(1, marbleList[1].Id);
            Assert.AreEqual(10, marbleList[2].Id);
            Assert.AreEqual(4, marbleList[3].Id);
            Assert.AreEqual(3, marbleList[4].Id);
        }
    }
}