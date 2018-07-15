using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// MedicineModel 的摘要说明:关系映射数据库中的药品信息表
/// </summary>
public class MedicineModel
{
    private int medicineId;
    private string medicineName;
    private float price;
    private int stockCount;
    private string unit;
    private string pzwh;
    private string ingredient;
    private string efficacy;
    private string usage;

    public void setMedicineId(int medicineId) { this.medicineId = medicineId; }
    public int getMedicineId() { return this.medicineId; }
    public void setMedicineName(string medicineName) { this.medicineName = medicineName; }
    public string getMedicineName() { return this.medicineName; }
    public void setPrice(float price) { this.price = price; }
    public float getPrice() { return this.price; }
    public void setStockCount(int stockCount) { this.stockCount = stockCount; }
    public int getStockCount() { return this.stockCount; }
    public void setUnit(string unit) { this.unit = unit; }
    public string getUnit() { return this.unit; }
    public void setPzwh(string pzwh) { this.pzwh = pzwh; }
    public string getPzwh() { return this.pzwh; }
    public void setIngredient(string ingredient) { this.ingredient = ingredient; }
    public string getIngredient() { return this.ingredient; }
    public void setEfficacy(string efficacy) { this.efficacy = efficacy; }
    public string getEfficacy() { return this.efficacy; }
    public void setUsage(string usage) { this.usage = usage; }
    public string getUsage() { return this.usage; }

	public MedicineModel()
	{
        medicineId = 0;
        medicineName = "";
        price = 0.0f;
        stockCount = 0;
        unit = "";
        pzwh = "";
        ingredient = "";
        efficacy = "";
        usage = "";
	}
}
