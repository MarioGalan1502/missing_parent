using NUnit.Framework;
using missing_parenthesesP;
using missing_Part2;

namespace missing_parentheses.test
{
    public class Tests
    {


        [Test]
        public void missing_parent_exp_isNull()
        {
            check_missing2 check = new check_missing2();

            Assert.That(()=> check.missing_P2(null),Throws.ArgumentNullException);
            
        }

        [Test]
        public void missing_parent_no_missing_parent()
        {
           check_missing2 check = new check_missing2();

            Assert.AreEqual(check.missing_P2("(())"), ' ');
            
        }

        [Test]
        public void missing_parent_there_is_no_parent()
        {
            check_missing2 check = new check_missing2();

            Assert.AreEqual(check.missing_P2("2+3+4+5"), ' ');
            
        }

        [Test]
        public void missing_parent_missing_Open()
        {
           check_missing2 check = new check_missing2();

            Assert.AreEqual(check.missing_P2("(())())"), '(');
            
        }

        [Test]
        public void missing_parent_missing_Close()
        {
           check_missing2 check = new check_missing2();

            Assert.AreEqual(check.missing_P2("(((()))"), ')');
            
        }
    }
}