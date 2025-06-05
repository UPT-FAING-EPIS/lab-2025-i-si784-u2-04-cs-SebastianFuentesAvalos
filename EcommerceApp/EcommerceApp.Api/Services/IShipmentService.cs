using EcommerceApp.Api.Models;

namespace EcommerceApp.Api.Services
{
    /// <summary>
    /// Define el servicio de envío de productos.
    /// </summary>
    public interface IShipmentService
    {
        /// <summary>
        /// Realiza el envío de los productos a la dirección especificada.
        /// </summary>
        /// <param name="info">Información de dirección del destinatario.</param>
        /// <param name="items">Lista de productos a enviar.</param>
        void Ship(IAddressInfo info, IEnumerable<ICartItem> items);
    }
}
