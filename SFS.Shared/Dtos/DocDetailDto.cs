
namespace SFS.Shared.Dtos;

public class DocDetailDto
{
    public int DocSerNo { get; set; }
    public int Item { get; set; }
    public int ParentItem { get; set; }
    public int DocRefSerNo { get; set; }
    public int DocRefItem { get; set; }
    public string AccNo { get; set; } = string.Empty;
    public string SubAccNo { get; set; } = string.Empty;
    public string SpecialInf { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public string UnitCode { get; set; } = string.Empty;
    public string ItemDesc { get; set; } = string.Empty;
    public decimal ItemValue { get; set; }
    public decimal ItemValueUSD { get; set; }
    public decimal ItemValueEuro { get; set; }
    public decimal ItemValueCur { get; set; }
    public byte ItemType { get; set; }
    public bool AutoCalc { get; set; }
    public int USDRate { get; set; }
    public int EuroRate { get; set; }
    public int CurRate { get; set; }
    public decimal ItemValueDebit { get; set; }
    public decimal ItemValueCredit { get; set; }
    public decimal ItemValueUSDDebit { get; set; }
    public decimal ItemValueUSDCredit { get; set; }
    public decimal ItemValueEuroDebit { get; set; }
    public decimal ItemValueEuroCredit { get; set; }
    public decimal ItemValueCurDebit { get; set; }
    public decimal ItemValueCurCredit { get; set; }
    public string NoteIssue { get; set; } = string.Empty;
    public string CardType { get; set; } = string.Empty;
    public string CostElement { get; set; } = string.Empty;
    public string IndentNo { get; set; } = string.Empty;
    public string MainDocNo { get; set; } = string.Empty;
    public Guid VATId { get; set; }
    public string VATGroupName { get; set; } = string.Empty;
    public string LastModifiedUID { get; set; } = string.Empty;
}