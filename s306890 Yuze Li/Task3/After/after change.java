public class Person {
    private String name;

    // Establish connection
    private TelephoneNumber officeTelephone = new TelephoneNumber();

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    // move field
    public String getOfficeNumber() {
        return officeTelephone.getOfficeNumber();
    }

    public void setOfficeNumber(String officeNumber) {
        officeTelephone.setOfficeNumber(officeNumber);
    }

    public String getOfficeAreaCode() {
        return officeTelephone.getOfficeAreaCode();
    }

    public void setOfficeAreaCode(String officeAreaCode) {
        officeTelephone.setOfficeAreaCode(officeAreaCode);
    }

}

public class TelephoneNumber {
    private String officeAreaCode;
    private String officeNumber;

    public String getOfficeAreaCode() {
        return officeAreaCode;
    }

    public void setOfficeAreaCode(String officeAreaCode) {
        this.officeAreaCode = officeAreaCode;
    }

    public String getOfficeNumber() {
        return officeNumber;
    }

    public void setOfficeNumber(String officeNumber) {
        this.officeNumber = officeNumber;
    }
}
