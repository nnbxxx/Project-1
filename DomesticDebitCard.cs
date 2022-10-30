public class DomesticDebitCard
{
    private string typecard;
    public string Typecard { get; set; }
    private decimal cardbalance;
    public static decimal CardBalance { get; set; }
    protected decimal hanMucRutTienTrenNgay;
    protected decimal hanMucChuyenKhoanTrenNgayCungNH;
    protected decimal hanMucChuyenKhoanTrenNgayKhacNH;
    protected decimal hanMucRutTienTrenLanKhacNH;
    protected decimal hanMucChuyenKhoanTrenLan;
    protected decimal hanMucRutTienTrenLanCungNH;
    protected decimal annualFees;
    public decimal AnnualFees { get; set; }
    public int PIN;
    private decimal internetlimit;
    public decimal InternetLimit { get; set; }
    private bool status;
    public bool Status { get; set; }

    private DateTime starttime;
    public DateTime StartTime { get; set; }
    public DomesticDebitCard()
    {
        StartTime = DateTime.Now;
        Status = false;
        CardBalance = 50000;

    }
    public void AccountRecharge(decimal x)
    {
        CardBalance += x;
    }
    public void WithdrawATM(decimal x)
    {
        CardBalance -= x;
    }
    public void WithdrawPOS(decimal x)
    {
        CardBalance -= x;
    }
    public void Ktratraikhoan()
    {
        Console.WriteLine(CardBalance);
    }
}

class NapasSuccessCard : DomesticDebitCard
{
    public NapasSuccessCard()
    {
        Typecard = "Napas Success";
        hanMucRutTienTrenNgay = 25000000;
        hanMucChuyenKhoanTrenNgayCungNH = 50000000;
        hanMucChuyenKhoanTrenNgayKhacNH = 25000000;
        hanMucRutTienTrenLanCungNH = 5000000;
        hanMucRutTienTrenLanKhacNH = 3000000;

    }

    ~NapasSuccessCard() { }
}
class NapasSuccessPlusCard : DomesticDebitCard
{
    public NapasSuccessPlusCard()
    {
        Typecard = "Napas Success Plus";
        hanMucRutTienTrenNgay = 50000000;
        hanMucChuyenKhoanTrenNgayCungNH = 100000000;
        hanMucChuyenKhoanTrenNgayKhacNH = 100000000;
        hanMucRutTienTrenLanCungNH = 5000000;
        hanMucRutTienTrenLanKhacNH = 3000000;
        hanMucChuyenKhoanTrenLan = 25000000;
        AnnualFees = 12000;
        InternetLimit = 5000000;


    }
    ~NapasSuccessPlusCard() { }
}