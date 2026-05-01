namespace Sales_Service.domain.Entity;

public enum PaymentStatus
{
    PROCESSING,
    COMPLETED,
    FAILED
}

public enum DeliveryMethod
{
    CAMPUS,
    CUN,
    EXTERNAL_SHIPPING
}

public enum DeliveryStatus
{
    PENDING,
    PROCESSING,
    DISPATCHED,
    DELIVERED,
    RETURNED
}

public enum OrderPaymentStatus
{
    PENDING,
    PAID,
    CANCELLED,
    REFUNDED
}

public enum EscrowStatus
{
    PENDING,
    HELD,
    RELEASED,
    REFUNDED
}