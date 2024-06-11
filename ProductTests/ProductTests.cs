namespace ProductTests
{
    public class ProductTests
    {
        private Product product;

        [SetUp]
        public void Setup()
        {
            product = new Product(1, "Test Product", 10m, 5);
        }

        [Test]
        public void ProductID_GetSet()
        {
            // Arrange
            int expected = 1;

            // Act
            int actual = product.ProductID;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ProductName_GetSet()
        {
            // Arrange
            string expected = "Test Product";

            // Act
            string actual = product.ProductName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Price_GetSet()
        {
            // Arrange
            decimal expected = 10m;

            // Act
            decimal actual = product.Price;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Stock_GetSet()
        {
            // Arrange
            int expected = 5;

            // Act
            int actual = product.Stock;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IncreaseStock()
        {
            // Arrange
            int increaseAmount = 5;
            int expected = 10;

            // Act
            product.IncreaseStock(increaseAmount);
            int actual = product.Stock;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DecreaseStock()
        {
            // Arrange
            int decreaseAmount = 3;
            int expected = 2;

            // Act
            product.DecreaseStock(decreaseAmount);
            int actual = product.Stock;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void DecreaseStock_BelowZero_ThrowsException()
        {
            // Arrange
            int decreaseAmount = 6;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => product.DecreaseStock(decreaseAmount));
        }

        private class Product
        {
            internal int ProductID;
            internal decimal Price;

            public Product(int v1, string v2, decimal v3, int v4)
            {
            }

            public string ProductName { get; internal set; }
            public int Stock { get; internal set; }

            internal void DecreaseStock(int decreaseAmount)
            {
                throw new NotImplementedException();
            }

            internal void IncreaseStock(int increaseAmount)
            {
                throw new NotImplementedException();
            }
        }
    }
}
