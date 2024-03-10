using Microsoft.VisualBasic.FileIO;

namespace Esercizio1;
class Program
{
    static void Main(string[] args)
    {
        List<Date> dates = new List<Date>();
        try
        {
            using (TextFieldParser parser = new TextFieldParser("DateInput.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData) 
                {
                    //per ogni riga
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields) 
                    {
                        //per ogni campo dlimitato da ","
                        dates.Add(new Date(field));
                    }
                }
            }
            
        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }

        string[] stringDates = new string[dates.Count];
        for(int i=0; i<dates.Count; i++)
        {
            stringDates[i]=dates[i].ToString();
        }
        
        string docPath =Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "DateOutput.txt")))
        {
            foreach (string strin in stringDates)
                outputFile.WriteLine(strin);
        }



                    
    }
}
