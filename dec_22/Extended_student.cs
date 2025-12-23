class StudentExtended
{
    // Private backing fields
    private string name;
    private int age;
    private int marks;
    private string password;

    // =========================
    // PART A: Auto-Implemented Property
    // =========================
    public int StudentId { get; set; }

    // =========================
    // PART 5: Property with Private Set
    // =========================
    public string RegistrationNumber { get; private set; }

    // =========================
    // PART 6: Init-Only Property
    // =========================
    public int AdmissionYear { get; init; }

    // =========================
    // PART D: Normal Properties with Validation
    // =========================
    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0)
                age = value;
        }
    }

    public int Marks
    {
        get { return marks; }
        set
        {
            if (value >= 0 && value <= 100)
                marks = value;
        }
    }

    // =========================
    // PART B: Read-Only Property
    // =========================
    public string Result => marks >= 40 ? "Pass" : "Fail";

    // =========================
    // PART C: Write-Only Property
    // =========================
    public string Password
    {
        set
        {
            if (value.Length >= 6)
                password = value;
        }
    }

    // =========================
    // PART 7: Expression-Bodied Property
    // =========================
    public double Percentage => marks;

    // =========================
    // Constructor (assign private set property)
    // =========================
    public StudentExtended(string regNo)
    {
        RegistrationNumber = regNo;
    }
}
