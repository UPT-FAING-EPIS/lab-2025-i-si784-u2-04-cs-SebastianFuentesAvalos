namespace EcommerceApp.Api.Services
{
    /// <summary>
    /// Implementación de descuento fijo basado en una tasa.
    /// </summary>
    public class FixedDiscountService : IDiscountService
    {
        private readonly decimal _discountRate;

        /// <summary>
        /// Inicializa una nueva instancia con una tasa de descuento específica.
        /// </summary>
        /// <param name="discountRate">Tasa de descuento (ej. 0.1 para 10%).</param>
        public FixedDiscountService(decimal discountRate)
        {
            _discountRate = discountRate;
        }

        /// <inheritdoc />
        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount * (1 - _discountRate);
        }
    }
}
