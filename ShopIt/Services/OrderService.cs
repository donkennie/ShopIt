using Microsoft.EntityFrameworkCore;
using ShopIt.Data;
using ShopIt.DTOs;
using ShopIt.Interfaces;
using ShopIt.Models;
using ShopIt.Models.Enums;
using ShopIt.Models.ValueObject;

namespace ShopIt.Services
{
    public class OrderService : IOrderService
    {
        private readonly IGenericRespository<CustomerCart> _customerCartRepository;
        private readonly IGenericRespository<Product> _productRepository;
        private readonly IGenericRespository<OrderItem> _orderItemRepository;
        private readonly IGenericRespository<Order> _orderRepository;
        private readonly IGenericRespository<CartItem> _cartItemRepository;
        private readonly IGenericRespository<DeliveryMethod> _deliveryMethodRepository;


        public OrderService(IGenericRespository<CustomerCart> customerCartRepository, IGenericRespository<Product> productRepository,
            IGenericRespository<OrderItem> orderItemRepository, IGenericRespository<Order> orderRepository,
            IGenericRespository<CartItem> cartItemRepository, IGenericRespository<DeliveryMethod> deliveryMethodRepository)
        {
            _customerCartRepository = customerCartRepository;
            _productRepository = productRepository;
            _orderItemRepository = orderItemRepository;
            _orderRepository = orderRepository;
            _cartItemRepository = cartItemRepository;
            _deliveryMethodRepository = deliveryMethodRepository;
        }

        public async Task<Order> CreateOrder(CreateOrderDTO createOrderDTO)
        {
            var cart = await _customerCartRepository.Get(createOrderDTO.CustomerCartId);
            if (cart == null)
            {
                throw new Exception("Cart not found");
            }

            var items = new List<OrderItem>();

            foreach (var item in cart.CartItems)
            {
                var product = await _productRepository.Get(item.Id);
                var cartItem = new CartItem
                {
                    Id = product.Id,
                    ProductName = product.Name,
                    PictureURL = product.PictureURL,
                };

                var orderItem = new OrderItem
                {
                    CartItem = cartItem,
                    Price = product.Price,
                    Quantity = item.Quantity,
                };

                items.Add(orderItem);
            }

            var deliveryMethod = await _deliveryMethodRepository.Get(createOrderDTO.DeliveryMethodId);
            if (deliveryMethod == null)
            {
                throw new Exception("Delivery method not found");
            }

            var subtotal = items.Sum(i => i.Price * i.Quantity);

            var order = new Order
            {
                BuyerEmail = createOrderDTO.Email,
                OrderItems = items,
                DeliveryMethod = deliveryMethod,
                SubTotal = subtotal,

                ShippingAddress = new Address
                {
                    FirstName = createOrderDTO.Address.FirstName,
                    LastName = createOrderDTO.Address.LastName,
                    Street = createOrderDTO.Address.Street,
                    City = createOrderDTO.Address.City,
                    State = createOrderDTO.Address.State,
                    ZipCode = createOrderDTO.Address.ZipCode
                },
                OrderDate = DateTime.UtcNow,
                OrderStatus = OrderStatus.Pending
            };

            await _orderRepository.Create(order);

            return order;
        }

        public async Task<IReadOnlyList<Order>> GetOrdersById(Guid orderId)
        {
            var orders = await _orderRepository.GetAll();
            var userOrders = orders.Where(o => o.Id == orderId).ToList();
            if (userOrders == null)
            {
                throw new Exception("No orders found for this ID");
            }
            return userOrders;
        }
        public async Task<IReadOnlyList<Order>> GetOrdersByEmail(string email)
        {
            var orders = await _orderRepository.GetAll();
            var userOrders = orders.Where(o => o.BuyerEmail == email).ToList();

            if (userOrders == null)
            {
                throw new Exception("No orders found for this email");
            }

            return userOrders;
        }

    }
}
