using EcommerceApp.Api.Models;

namespace EcommerceApp.Api.Services
{
    /// <summary>
    /// Servicio para calcular totales de compra con impuestos y descuentos.
    /// </summary>
    public class PurchaseService
    {
        private readonly IDiscountService _discountService;

        /// <summary>
        /// Inicializa una nueva instancia de <see cref="PurchaseService"/>.
        /// </summary>
        /// <param name="discountService">Servicio de descuento a aplicar.</param>
        public PurchaseService(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        /// <summary>
        /// Calcula el total aplicando el descuento sobre el precio unitario y cantidad.
        /// </summary>
        /// <param name="unitPrice">Precio unitario del producto.</param>
        /// <param name="quantity">Cantidad de productos.</param>
        /// <returns>Total con descuento aplicado.</returns>
        public decimal CalculateTotalWithDiscount(decimal unitPrice, int quantity)
        {
            var total = unitPrice * quantity;
            return _discountService.ApplyDiscount(total);
        }

        /// <summary>
        /// Calcula el total con impuesto y descuento aplicados.
        /// </summary>
        /// <param name="unitPrice">Precio unitario del producto.</param>
        /// <param name="quantity">Cantidad de productos.</param>
        /// <param name="taxRate">Tasa de impuesto (por ejemplo, 0.18 para 18%).</param>
        /// <returns>Total con impuestos y descuentos.</returns>
        public decimal CalculateTotalWithTaxAndDiscount(decimal unitPrice, int quantity, decimal taxRate)
        {
            var subtotal = unitPrice * quantity;
            var discounted = _discountService.ApplyDiscount(subtotal);
            return discounted + (discounted * taxRate);
        }
    }
}
