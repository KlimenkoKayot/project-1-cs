using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

class Student
{
    private string _school;
    public string GetSchool() => _school;
    public bool SetSchool(string school) 
    {
        _school = school;
        return true;
    }

    private char _sex;  
    public char GetSex() => _sex;
    public void SetSex(char sex)
    {
        if (sex != 'M' && sex != 'F')
        {
            throw new ArgumentException("unknown sex");
        }
        _sex = sex;
    }
    public void SetSex(string sex)
    {
        try
        {
            char ch = char.Parse(sex);
            SetSex(ch);
        }
        catch
        {
            throw new Exception("bad sex field data");
        }
    }

    private int _age;
    public int GetAge() => _age;
    public void SetAge(int age)
    {
        if (age < 0)
        {
            throw new ArgumentException("age cant be negative");
        }
    }
    public void SetAge(string age)
    {
        try
        {
            char val = char.Parse(age);
            SetAge(age);
        }
        catch
        {
            throw new Exception("bad age field data");
        }
    }

    private string _address;
    public string GetAddress() => _address;
    public void SetAddress(string address) 
    { 
        _address = address;
    }

    private string _famsize;
    public string GetFamsize() => _famsize;
    public void SetFamsize(string famsize) 
    {
        _famsize = famsize;
    }

    private string _pstatus;
    public string GetPstatus() => _pstatus;
    public void SetPstatus(string pstatus)
    {
        _pstatus = pstatus;
    }

    private float _medu;
    public float GetMedu() => _medu;
    public void SetMedu(float medu)
    {
        _medu = medu;
    }
    public void SetMedu(string medu)
    {
        try
        {
            float val = float.Parse(medu);
            SetMedu(val);
        } 
        catch
        {
            throw new Exception("bad medu field value");
        }
    }

    private float _fedu;
    public float GetFedu() => _fedu;
    public void SetFedu(float fedu)
    {
        _fedu = fedu;
    }
    public void SetFedu(string fedu)
    {
        try
        {
            float val = float.Parse(fedu);
            SetFedu(val);
        }
        catch
        {
            throw new Exception("bad fedu field value");
        }
    }

    private string _mjob;
    public string GetMjob() => _mjob;
    public void SetMjob(string mjob)
    {
        _mjob = mjob;
    }

    private string _fjob;
    public string GetFjob() => _fjob;
    public void SetFjob(string fjob)
    {
        _fjob = fjob;
    }

    private string _reason;
    public string GetReason() => _reason;
    public void SetReason(string reason)
    {
        _reason = reason;
    }

    private string _guardian;
    public string GetGuardian() => _guardian;
    public void SetGuardian(string guardian)
    {
        _guardian = guardian;
    }

    private float _traveltime;
    public float GetTraveltime() => _traveltime;
    public void SetTraveltime(float traveltime)
    {
        if (traveltime < 0)
        {
            throw new ArgumentException("time cant be negative");
        }
        _traveltime = traveltime;
    }
    public void SetTraveltime(string traveltime)
    {
        try
        {
            float val = float.Parse(traveltime);
            SetTraveltime(val);
        }
        catch
        {
            throw new Exception("bad traveltime field value");
        }
    }
    
    private float _studytime;
    public float GetStudytime => _studytime;
    public void SetStudytime(float studytime)
    {
        if (studytime < 0)
        {
            throw new ArgumentException("time cant be negative");
        }
        _studytime = studytime;
    }
    public void SetStudytime(string studytime)
    {
        try
        {
            float val = float.Parse(studytime);
            SetStudytime(val);
        }
        catch
        {
            throw new Exception("bad studytime field value");
        }
    }

    private int _failures;
    public int GetFailures() => _failures;
    public void SetFailures(int failures)
    {
        if (failures < 0)
        {
            throw new ArgumentException("count of failures cant be negative");
        }
        _failures = failures;
    }
    public void SetFailures(string failures)
    {
        try
        {
            int val = int.Parse(failures);
            SetFailures(val);
        }
        catch
        {
            throw new Exception("bad failures field value");
        }
    }

    private string _schoolsup;
    public string GetSchoolsup() => _schoolsup;
    public void SetSchoolsup(string schoolsup) 
    { 
        _schoolsup = schoolsup;
    }

    private string _famsup;
    public string GetFamsup() => _famsup;
    public void SetFamsup(string famsup)
    {
        _famsup = famsup;
    }

    private string _paid;
    public string GetPaid() => _paid;
    public void SetPaid(string paid)
    {
        _paid = paid;
    }

    private string _activities;
    public string GetActivities() => _activities;
    public void SetActivities(string activities)
    {
        _activities = activities;
    }

    private string _nursery;
    public string GetNursery() => _nursery;
    public void SetNursery(string nursery)
    {
        _nursery = nursery;
    }

    private string _higher;
    public string GetHigher() => _higher;
    public void SetHigher(string higher) 
    {
        _higher = higher;
    }

    private string _internet;
    public string GetInternet() => _internet;
    public void SetInternet(string internet)
    {
        _internet = internet;
    }

    private string _romantic;
    public string GetRomantic() => _romantic;
    public void SetRomantic(string  romantic)
    {
        _romantic = romantic;
    }

    private float _famrel;
    public float GetFamrel() => _famrel;
    public void SetFamrel(float famrel)
    {
        if (famrel < 0)
        {
            throw new ArgumentException("famrel cant be negative");
        }
        _famrel = famrel;
    }
    public void SetFamrel(string famrel)
    {
        try
        {
            float val = float.Parse(famrel);
            SetFamrel(val);
        }
        catch
        {
            throw new ArgumentException("bad famrel field value");
        }
    }

    private float _freetime;
    public float GetFreetime() => _freetime;
    public void SetFreetime(float freetime)
    {
        if (freetime < 0)
        {
            throw new ArgumentException("freetime cant be negative");
        }
        _freetime = freetime;
    }
    public void SetFreetime(string freetime)
    {
        try
        {
            float val = float.Parse(freetime);
            SetFreetime(val);
        }
        catch
        {
            throw new ArgumentException("bad freetime field value");
        }
    }


    private float _goout;
    public float GetGoout() => _goout;
    public void SetGoout(float goout)
    {
        if (goout < 0)
        {
            throw new ArgumentException("goout cant be negative");
        }
        _goout = goout;
    }
    public void SetGoout(string goout)
    {
        try
        {
            float val = float.Parse(goout);
            SetGoout(val);
        }
        catch
        {
            throw new ArgumentException("bad goout field value");
        }
    }


    private float _dalc;
    public float GetDalc() => _dalc;
    public void SetDalc(float dalc)
    {
        if (dalc < 0)
        {
            throw new ArgumentException("dalc cant be negative");
        }
        _dalc = dalc;
    }
    public void SetDalc(string dalc)
    {
        try
        {
            float val = float.Parse(dalc);
            SetDalc(val);
        }
        catch
        {
            throw new ArgumentException("bad dalc field value");
        }
    }


    private float _walc;
    public float GetWalc => _walc;
    public void SetWalc(float walc)
    {
        if (walc < 0)
        {
            throw new ArgumentException("walc cant be negative");
        }
        _walc = walc;
    }
    public void SetWalc(string walc)
    {
        try
        {
            float val = float.Parse(walc);
            SetWalc(val);
        }
        catch
        {
            throw new ArgumentException("bad walc field value");
        }
    }


    private float _health;
    public float GetHealth() => _health;
    public void SetHealth(float health)
    {
        if (health < 0)
        {
            throw new ArgumentException("health cant be negative");
        }
        _health = health;
    }
    public void SetHealth(string health)
    {
        try
        {
            float val = float.Parse(health);
            SetFamrel(val);
        }
        catch
        {
            throw new ArgumentException("bad health field value");
        }
    }


    private float _absences;
    public float GetAbsences() => _absences;
    public void SetAbsences(float absences)
    {
        if (absences < 0)
        {
            throw new ArgumentException("absences cant be negative");
        }
        _absences = absences;
    }
    public void SetAbsences(string absences)
    {
        try
        {
            float val = float.Parse(absences);
            SetAbsences(val);
        }
        catch
        {
            throw new ArgumentException("bad absences field value");
        }
    }


    private float _g1;
    public float GetG1() => _g1;
    public void SetG1(float g1)
    {
        if (g1 < 0)
        {
            throw new ArgumentException("g1 cant be negative");
        }
        _g1 = g1;
    }
    public void SetG1(string g1)
    {
        try
        {
            float val = float.Parse(g1);
            SetG1(val);
        }
        catch
        {
            throw new ArgumentException("bad g1 field value");
        }
    }


    private float _g2;
    public float GetG2() => _g2;
    public void SetG2(float g2)
    {
        if (g2 < 0)
        {
            throw new ArgumentException("g2 cant be negative");
        }
        _g2 = g2;
    }
    public void SetG2(string g2)
    {
        try
        {
            float val = float.Parse(g2);
            SetG1(val);
        }
        catch
        {
            throw new ArgumentException("bad g2 field value");
        }
    }


    private float _g3;
    public float GetG3() => _g3;    
    public void SetG3(float g3)
    {
        if (g3 < 0)
        {
            throw new ArgumentException("g3 cant be negative");
        }
        _g3 = g3;
    }
    public void SetG3(string g3)
    {
        try
        {
            float val = float.Parse(g3);
            SetG1(val);
        }
        catch
        {
            throw new ArgumentException("bad g3 field value");
        }
    }

    public void Print()
    {
        Console.WriteLine(
            $"School: {_school}\n" +
            $"Sex: {_sex}\n" +
            $"Age: {_age}\n" +
            $"Address: {_address}\n" +
            $"Famsize: {_famsize}\n" +
            $"Pstatus: {_pstatus}\n" +
            $"Medu: {_medu}\n" +
            $"Fedu: {_fedu}\n" +
            $"Mjob: {_mjob}\n" +
            $"Fjob: {_fjob}\n" +
            $"Reason: {_reason}\n" +
            $"Guardian: {_guardian}\n" +
            $"Traveltime: {_traveltime}\n" +
            $"Studytime: {_studytime}\n" +
            $"Failures: {_failures}\n" +
            $"Schoolsup: {_schoolsup}\n" +
            $"Famsup: {_famsup}\n" +
            $"Paid: {_paid}\n" +
            $"Activities: {_activities}\n" +
            $"Nursery: {_nursery}\n" +
            $"Higher: {_higher}\n" +
            $"Internet: {_internet}\n" +
            $"Romantic: {_romantic}\n" +
            $"Famrel: {_famrel}\n" +
            $"Freetime: {_freetime}\n" +
            $"Goout: {_goout}\n" +
            $"Dalc: {_dalc}\n" +
            $"Walc: {_walc}\n" +
            $"Health: {_health}\n" +
            $"Absences: {_absences}\n" +
            $"G1: {_g1}\n" +
            $"G2: {_g2}\n" +
            $"G3: {_g3}\n");
    }
}
