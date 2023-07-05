public class CodeView
{
    public CodeController codeController;

    public CodeView()
    {
        codeController = new CodeController();
    }

    //Method to show the generated code
    public void ActivateGenerateCode()
    {
        string code = codeController.GenerateCodes();
        Console.WriteLine("New code is generated: " + code);
    }

    //Method to show results of checking code validation
    public void CheckCodeActivation(string code)
    {
        bool isValid = codeController.CheckCode(code);

        if (isValid)
        {
            Console.WriteLine("You entered a valid code.");
            Console.WriteLine("Checking campaigns for this code...");
            System.Threading.Thread.Sleep(1500);
            CheckCampaignActivation(code);
        }
        else
        {
            Console.WriteLine("You entered an invalid or a previously used code.");
        }
    }

    //Method to show results of checking campaign validation
    public void CheckCampaignActivation(string code)
    {
        bool isValid = codeController.CheckCampaigns(code);
        if (isValid)
        {
            Console.WriteLine("Campaign control was done successfully.");
        }
        else
        {
            Console.WriteLine("You entered an invalid or previously used code.");
        }
    }
}

