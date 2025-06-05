namespace EcommerceApp.Api.Services
{
    /// <summary>
    /// Define la interfaz para aplicar descuentos sobre un monto total.
    /// </summary>
    public interface IDiscountService
    {
        /// <summary>
        /// Aplica un descuento al monto total.
        /// </summary>
        /// <param name="totalAmount">Monto antes del descuento.</param>
        /// <returns>Monto después del descuento.</returns>
        decimal ApplyDiscount(decimal totalAmount);
    }
}
