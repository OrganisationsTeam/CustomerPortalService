CustomerPortal is a Service for creating purchaseOrders and sending it to the OrderService# CustomerPortalService

json instance for validation:
{
    "orderNumber": "PO-2023-12345",
    "orderDate": "2023-12-14T10:30:00Z",
    "customer": {
        "customerId": 12345,
        "name": "John Doe"
    },
    "orderedItem": [
        {
            "productId": 101,
            "quantity": 5
        },
        {
            "productId": 202,
            "quantity": 2
        }
    ]
}