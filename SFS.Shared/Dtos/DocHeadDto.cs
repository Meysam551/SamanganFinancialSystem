
namespace SFS.Shared.Dtos;

public class DocHeadDto
{
    public string DocSerNo { get; set; } = string.Empty;
    public string OfficeCode { get; set; } = string.Empty;
    public string OprYear { get; set; } = string.Empty;
    public string DocNo { get; set; } = string.Empty;
    public string DocDate { get; set; } = string.Empty;
    public string OprMon { get; set; } = string.Empty;
    public byte DocCode { get; set; } = 0;
    public string DocDesc { get; set; } = string.Empty;
    public string PaidTo { get; set; } = string.Empty;
    public byte StatusCode { get; set; } = 0;
    public byte CurTypeCode { get; set; } = 0;
    public decimal DocValue { get; set; } = 0;
    public decimal DocUSDValue { get; set; } = 0;
    public decimal DocEuroValue { get; set; } = 0;
    public decimal DocCurValue { get; set; } = 0;
    public int USDRate { get; set; } = 0;
    public int EuroRate { get; set; } = 0;
    public int CurRate { get; set; } = 0;
    public string AreaCode { get; set; } = string.Empty;
    public string DocRefNo { get; set; } = string.Empty;
    public string ContractNo { get; set; } = string.Empty;
    public byte ContractTypeCode { get; set; } = 0;
    public string AutomationNumber { get; set; } = string.Empty;
    public string InvoiceNo { get; set; } = string.Empty;
    public string ApplicationNo { get; set; } = string.Empty;
    public string OrgCode { get; set; } = string.Empty;
    public string Mon { get; set; } = string.Empty;
    public string Dat { get; set; } = string.Empty;
}
