
namespace SFS.Shared;

public class DocTypeDetailDto
{
    public byte DocCode { get; set; }
    public string ObjName { get; set; } = string.Empty;
    public string ObjDesc { get; set; } = string.Empty;
    public string ObjWidth { get; set; } = string.Empty;
    public string DefaultValue { get; set; } = string.Empty;
    public bool HasMinusMark { get; set; }
    public string TblName4Control { get; set; } = string.Empty;
    public string FldName4Control { get; set; } = string.Empty;
    public string ConditionCommand { get; set; } = string.Empty;
    public byte ObjMaxLength { get; set; }
    public string ObjOndbclick { get; set; } = string.Empty;
}