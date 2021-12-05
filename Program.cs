// See https://aka.ms/new-console-template for more information

/* Its length is at least 6.
It contains at least one digit.
It contains at least one lowercase English character.
It contains at least one uppercase English character.
It contains at least one special character. The special characters are: !@#$%^&*()-+
*/

using System.Text.RegularExpressions;

int cnt= CheckUnavailableRuleForPassword("AUzs-nV");
Console.WriteLine(cnt);

int CheckUnavailableRuleForPassword(string password)
    {
    int cnt = 0;
    int atLeastAdd = 0;
    Regex rgxAtLeast6 = new Regex(@"^.{6,}$"); //Its length is at least 6.
    if (!rgxAtLeast6.IsMatch(password.ToString()))
        atLeastAdd =  6 - password.Length;

    Regex rgxUppercase = new Regex(@"^(?=.*[A-Z])"); //It contains at least one uppercase English character.
    if (!rgxUppercase.IsMatch(password.ToString()))
        cnt++;
    Regex rgxLowercase = new Regex(@"^(?=.*[a-z])"); //It contains at least one lowercase English character.
    if (!rgxLowercase.IsMatch(password.ToString()))
        cnt++;
    Regex rgxDigit = new Regex(@"^(?=.*[0-9])"); //It contains at least one digit.
    if (!rgxDigit.IsMatch(password.ToString()))
        cnt++;
    Regex rgxSpecialChar = new Regex(@"^(?=.*[!@#$%^&*()+-])"); //The special characters are: !@#$%^&*()-+
    if (!rgxSpecialChar.IsMatch(password.ToString()))
        cnt++;
    if (atLeastAdd > cnt)
        cnt = atLeastAdd;

    return cnt; 

}
