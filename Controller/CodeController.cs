using System;
using System.Text;

public class CodeController
{
    public List<Code> Codes;
    public List<Campaign> Campaigns;

    public CodeController()
    {
        Codes = new List<Code>();
        GenerateSampleCodes();

        Campaigns = new List<Campaign>();
        GenerateSampleCampaigns();
    }

    // Method to generate code samples
    private void GenerateSampleCodes()
    {
        Codes.Add(new Code { Id = 1, Value = "ABCDE001", IsUsed = true });
        Codes.Add(new Code { Id = 2, Value = "FGHIJ002", IsUsed = false });
        Codes.Add(new Code { Id = 3, Value = "KLMNO003", IsUsed = false });
    }

    // Method to generate campaign samples
    private void GenerateSampleCampaigns()
    {
        Campaigns.Add(new Campaign { Id = 1, Name = "June Campaign", Code = "FGHIJ002", IsValid = false });
        Campaigns.Add(new Campaign { Id = 2, Name = "July Campaign", Code = "KLMNO003", IsValid = true });
    }

    // Method to generate a unique code
    private string GenerateUniqueCode()
    {
        const string characters = "ACDEFGHKLMNPRTXYZ234579";
        const int codeLength = 8;

        Random random = new Random();
        StringBuilder codeBuilder = new StringBuilder(codeLength);

        while (true)
        {
            for (int i = 0; i < codeLength; i++)
            {
                codeBuilder.Append(characters[random.Next(characters.Length)]);
            }

            string code = codeBuilder.ToString();

            if (!Codes.Any(c => c.Value == code))
            {
                return code;
            }

            codeBuilder.Clear();
        }
    }

    // Method to generate new code with unique property and add it among the other codes
    public string GenerateCodes()
    {
        string code = GenerateUniqueCode();

        Code newCode = new Code
        {
            Value = code,
            IsUsed = false
        };

        Codes.Add(newCode);

        return code;
    }

    //Method to check validation for code. If code is exist or null, then it will return false
    public bool CheckCode(string code)
    {
        Code existingCode = Codes.FirstOrDefault(c => c.Value == code);

        if (existingCode != null && !existingCode.IsUsed)
        {
            existingCode.IsUsed = true;
            return true;
        }

        return false;
    }

    // Method to check is there any valid campaign to use the code
    public bool CheckCampaigns(string code)
    {
        Campaign existingCampaign = Campaigns.FirstOrDefault(c => c.Code == code);
        if (existingCampaign != null && existingCampaign.IsValid)
        {
            existingCampaign.IsValid = false;
            return true;
        }
        return false;
    }

}
