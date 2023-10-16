using NUnit.Framework;

namespace Snippets.NUnit.Attributes
{
    public class ConstraintExamples
    {
        #region AllItemsIsExample
        [Test]
        public void CanUseIsToTalkAboutAllItems()
        {
            int[] arrayOfIntegers = new int[] { 1, 2, 3 };
            string[] arrayOfStrings = new string[] { "a", "b", "c" };

            Assert.That(arrayOfIntegers, Is.All.Not.Null);
            Assert.That(arrayOfIntegers, Is.All.GreaterThan(0));

            Assert.That(arrayOfStrings, Is.All.InstanceOf<string>());
        }
        #endregion

        #region AllItemsHasExample
        [Test]
        public void CanUseHasToTalkAboutAllItems()
        {
            int[] arrayOfIntegers = new int[] { 1, 2, 3 };

            Assert.That(arrayOfIntegers, Has.All.GreaterThan(0));
        }
        #endregion
        #region AssignableFromExample
        [Test]
        public void AssignableFromExample()
        {
            var theString = "Hello";
            Assert.That(theString, Is.AssignableFrom(typeof(string)));

            var theInt = 5;
            Assert.That(theInt, Is.Not.AssignableFrom<string>());
        }
        #endregion
        #region AndExample
        [Test]
        public void UsingAndToCombineConstraints()
        {
            var testValue = 2.3;
            Assert.That(testValue, Is.GreaterThan(2.0).And.LessThan(3.0));
        }
        #endregion
    }

}