class Students
{   
    private string name;
    private int age;
    private double marks;
    

    public string Name
    {
        get { return name; }
        set
        {
            if (value != null && value.Length > 0)
            {
                name = value;
            }
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value > 0 && value < 100)
            {
                age = value;
            }
        }
    }
    public double Marks
    {
        get{return marks;}
        set
        {
            if(value>=0 && value <= 100)
            {
                marks=value;
            }
        }
    }
}
