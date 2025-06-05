using EcommerceApp.Api.Models;

namespace EcommerceApp.Api.Services
{
    /// <summary>
    /// Define el servicio de operaciones sobre el carrito de compras.
    /// </summary>
    public interface ICartService
    {
        /// <summary>
        /// Calcula el total del carrito.
        /// </summary>
        /// <returns>Total acumulado en el carrito.</returns>
        double Total();

        /// <summary>
        /// Obtiene los elementos contenidos en el carrito.
        /// </summary>
        /// <returns>Lista de ítems en el carrito.</returns>
        IEnumerable<ICartItem> Items();
    }
}
