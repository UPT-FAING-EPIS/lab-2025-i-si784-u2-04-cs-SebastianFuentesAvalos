using NUnit.Framework;
using EcommerceApp.Api.Services;

namespace EcommerceApp.Tests
{
    public class PurchaseServiceTests
    {
        [TestCase(100, 2, 0.1, 0.15, ExpectedResult = 207)] // 200 -10% = 180 +15% = 207
        [TestCase(50, 4, 0.2, 0.1, ExpectedResult = 176)]   // 200 -20% = 160 +10% = 176
        public decimal CalculateTotalWithTaxAndDiscount_Test(
            decimal unitPrice, int quantity, double discountRate, double taxRate)
        {
            var discountService = new FixedDiscountService((decimal)discountRate);
            var purchaseService = new PurchaseService(discountService);
            return purchaseService.CalculateTotalWithTaxAndDiscount(unitPrice, quantity, (decimal)taxRate);
        }
    }
}
