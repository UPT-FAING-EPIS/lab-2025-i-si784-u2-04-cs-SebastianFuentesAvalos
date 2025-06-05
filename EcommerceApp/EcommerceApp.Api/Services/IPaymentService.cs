using EcommerceApp.Api.Models;

namespace EcommerceApp.Api.Services
{
    /// <summary>
    /// Define el servicio de procesamiento de pagos.
    /// </summary>
    public interface IPaymentService
    {
        /// <summary>
        /// Realiza el cobro de un monto total a una tarjeta.
        /// </summary>
        /// <param name="total">Monto total a cobrar.</param>
        /// <param name="card">Tarjeta del cliente.</param>
        /// <returns>True si el cobro fue exitoso, false si falló.</returns>
        bool Charge(double total, ICard card);
    }
}
