package ece.np.edu.s10195575mp2_p2a5;

public class ItemClass {
    private String strCategory = "";
    private String strAmount = "";

    public String getStrCategory() {
        return strCategory;
    }

    public void setStrCategory(String strCategory) {
        this.strCategory = strCategory;
    }

    public String getStrAmount() {
        return strAmount;
    }

    public void setStrAmount(String strAmount) {
        this.strAmount = strAmount;
    }

    public ItemClass(String strCategory, String strAmount) {
        this.strCategory = strCategory;
        this.strAmount = strAmount;
    }

    public ItemClass(String strAmount) {
        this.strAmount = strAmount;
    }
}
