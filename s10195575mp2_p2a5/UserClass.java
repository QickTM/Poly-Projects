package ece.np.edu.s10195575mp2_p2a5;

public class UserClass {
    private String strName = "";
    private String strPassword = "";

    public String getStrName() {
        return strName;
    }

    public void setStrName(String strName) {
        this.strName = strName;
    }

    public String getStrPassword() {
        return strPassword;
    }

    public void setStrPassword(String strPassword) {
        this.strPassword = strPassword;
    }

    public UserClass(String strName, String strPassword) {
        this.strName = strName;
        this.strPassword = strPassword;
    }
}
