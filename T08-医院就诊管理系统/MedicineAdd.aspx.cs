using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Hospital.Model;
using Hospital.Logic;

public partial class MedicineAdd : System.Web.UI.Page
{
    protected void Btn_GuaHao_Click(object sender, EventArgs e)
    {
        string medicineName = this.MedicineName.Text;
        float price = Convert.ToSingle(this.Price.Text);
        int stockCount = Int32.Parse(this.StockCount.Text);
        string unit = this.Unit.Text;
        string pzwh = this.Pzwh.Text;
        string ingredient = this.Ingredient.Text;
        string efficacy = this.Efficacy.Text;
        string usage = this.Usage.Text;

        MedicineModel medicineModel = new MedicineModel();
        medicineModel.setMedicineName(medicineName);
        medicineModel.setPrice(price);
        medicineModel.setStockCount(stockCount);
        medicineModel.setUnit(unit);
        medicineModel.setPzwh(pzwh);
        medicineModel.setIngredient(ingredient);
        medicineModel.setEfficacy(efficacy);
        medicineModel.setUsage(usage);

        MedicineLogic medicineLogic = new MedicineLogic();
        if (medicineLogic.AddMedicineInfo(medicineModel))
            Response.Write("<script>alert('药品信息添加成功!');location.href='MedicineAdd.aspx';</script>");
        else
            Response.Write("<script>alert('" + medicineLogic.getErrMessage() + "');<script>");
    }
}
