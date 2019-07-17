using NUnit.Framework;

namespace CodeWars.Mumbling
{
    public class MumblingTests
    {
        private static void Testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MumblingReturnsCorrectString()
        {
            Testing(Mumbling.Accum("ZpglnRxqenU"),
                "Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu");
            Testing(Mumbling.Accum("NyffsGeyylB"),
                "N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb");
            Testing(Mumbling.Accum("MjtkuBovqrU"),
                "M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu");
            Testing(Mumbling.Accum("EvidjUnokmM"),
                "E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm");
            Testing(Mumbling.Accum("HbideVbxncC"),
                "H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc");
        }
    }
}