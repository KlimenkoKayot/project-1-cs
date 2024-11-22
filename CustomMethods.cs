using System.Net.NetworkInformation;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Markup;

static class CustomMethods
{
    static public List<Student> ReadFile(string filePath)
    {
        List<Student> result = new List<Student>();
        int cnt = 0;

        StreamReader reader;
        try
        {
            reader = new StreamReader(filePath);
        }
        catch (FileNotFoundException ex)
        {
            throw new Exception("file not found");
        }
        catch (DirectoryNotFoundException ex)
        {
            throw new Exception("directory not found");
        }
        catch (IOException ex)
        {
            throw new Exception("bad path name");
        }

        if (reader.EndOfStream == true) {
            throw new Exception("bad file configuration");
        }

        Console.WriteLine("1");
        string line = reader.ReadLine();
        string[] fields = line.Split(',');
        while (!reader.EndOfStream)
        {
            line = reader.ReadLine();
            // обработка строки
            string[] values = line.Split(',');
            if (values.Length != 33)
            {
                throw new Exception($"bad count if fields at line {cnt}");
            }

            Student student = new Student();
            try
            {
                for (int i = 0; i < values.Length; ++i)
                {
                    // обработка по полям
                    switch (fields[i])
                    {
                        case ("school"): { student.SetSchool(values[i]); break; }
                        case ("sex"): { student.SetSchool(values[i]); break; }
                        case ("age"): { student.SetSchool(values[i]); break; }
                        case ("address"): { student.SetAddress(values[i]); break; }
                        case ("famsize"): { student.SetFamsize(values[i]); break; }
                        case ("Pstatus"): { student.SetPstatus(values[i]); break; }
                        case ("Medu"): { student.SetMedu(values[i]); break; }
                        case ("Fedu"): { student.SetFedu(values[i]); break; }
                        case ("Mjob"): { student.SetMjob(values[i]); break; }
                        case ("Fjob"): { student.SetFjob(values[i]); break; }
                        case ("reason"): { student.SetReason(values[i]); break; }
                        case ("guardian"): { student.SetGuardian(values[i]); break; }
                        case ("traveltime"): { student.SetTraveltime(values[i]); break; }
                        case ("studytime"): { student.SetStudytime(values[i]); break; }
                        case ("failures"): { student.SetFailures(values[i]); break; }
                        case ("schoolsup"): { student.SetSchoolsup(values[i]); break; }
                        case ("famsup"): { student.SetFamsup(values[i]); break; }
                        case ("paid"): { student.SetPaid(values[i]); break; }
                        case ("activities"): { student.SetActivities(values[i]); break; }
                        case ("nursery"): { student.SetNursery(values[i]); break; }
                        case ("higher"): { student.SetHigher(values[i]); break; }
                        case ("internet"): { student.SetInternet(values[i]); break; }
                        case ("romantic"): { student.SetRomantic(values[i]); break; }
                        case ("famrel"): { student.SetFamrel(values[i]); break; }
                        case ("freetime"): { student.SetFreetime(values[i]); break; }
                        case ("goout"): { student.SetGoout(values[i]); break; }
                        case ("Dalc"): { student.SetDalc(values[i]); break; }
                        case ("Walc"): { student.SetWalc(values[i]); break; }
                        case ("health"): { student.SetHealth(values[i]); break; }
                        case ("absences"): { student.SetAbsences(values[i]); break; }
                        case ("G1"): { student.SetG1(values[i]); break; }
                        case ("G2"): { student.SetG2(values[i]); break; }
                        case ("G3"): { student.SetG3(values[i]); break; }
                    }
                }
            }
            // э сук че за ошипки
            catch (Exception ex)
            {
                throw new Exception($"bad data at line {cnt}: {ex.Message}");
            }
            result.Add(student);
            ++cnt;
        }
        return result;
    }
}