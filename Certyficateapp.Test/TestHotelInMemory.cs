namespace Certyficateapp.Test
{
    public class Tests
    {


        [Test]
        public void HotelRatingTest()
        {
            var hotel = new HotelInMemory("Novotel", "Kraków");
            hotel.AddGrade(20);
            hotel.AddGrade(15);
            hotel.AddGrade(80);
            hotel.AddGrade(100);
            hotel.AddGrade(40);

            var rating = hotel.GetStatistics();

            Assert.AreEqual(51, rating.Average);
            Assert.AreEqual(100, rating.Max);
            Assert.AreEqual(15, rating.Min);
            Assert.AreEqual(255, rating.Sum);
            Assert.AreEqual(5, rating.Count);

        }

    }
}