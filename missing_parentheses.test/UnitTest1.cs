using NUnit.Framework;
using missing_parenthesesP;

namespace missing_parentheses.test
{
    public class Tests
    {


        [Test]
        public void missing_parent_exp_isNull()
        {
            check_missing check = new check_missing();

            Assert.That(()=> check.missing(null),Throws.ArgumentNullException);
            
        }

        [Test]
        public void missing_parent_no_missing_parent()
        {
            check_missing check = new check_missing();

            Assert.AreEqual(check.missing("(())"), ' ');
            
        }

        [Test]
        public void missing_parent_there_is_no_parent()
        {
            check_missing check = new check_missing();

            Assert.AreEqual(check.missing("2+3+4+5"), ' ');
            
        }

        [Test]
        public void missing_parent_missing_Open()
        {
            check_missing check = new check_missing();

            Assert.AreEqual(check.missing("))))"), '(');
            
        }

        [Test]
        public void missing_parent_missing_Close()
        {
            check_missing check = new check_missing();

            Assert.AreEqual(check.missing("(((("), ')');
            
        }
    }
}