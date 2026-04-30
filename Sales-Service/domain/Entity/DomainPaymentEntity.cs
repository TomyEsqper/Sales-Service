namespace Sales_Service.domain.Entity;

public class DomainPaymentEntity
{
    public string PaymentId { get; set; } = string.Empty;
    public string OrderId { get; set; } = string.Empty;
    public string PaymentProvider { get; set; } = string.Empty;
    public string TransactionReference { get; set; } = string.Empty;
    public decimal AmountPaid { get; set; }
    public DateTime PaymentDate { get; set; }
    public PaymentStatus Status { get; set; } = PaymentStatus.PROCESSING;
}