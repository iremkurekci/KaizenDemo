
// This program is generated to create new codes while checking the previously generated sample codes and campaigns. As user preferences, it might be developed.
/**
* @author Ismihan Irem KUREKCI
*
* @date - 05.07.2023
*/

CodeView codeView = new CodeView();

codeView.ActivateGenerateCode(); // run to create random new code sample

//you can check code validation by using the input codes given below. Please assign comment one of them and open the other one while using.

// string inputCode = "ABC12345"; //null code
// string inputCode = "ABCDE001"; // previously used code
// string inputCode = "FGHIJ002"; // valid code but invalid campaign
string inputCode = "KLMNO003"; // valid code and valid campaign

codeView.CheckCodeActivation(inputCode);
