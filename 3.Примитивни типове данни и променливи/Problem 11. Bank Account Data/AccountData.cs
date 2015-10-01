using System;

namespace Problem_11.Bank_Account_Data
{
    class AccountData
    {
        static void Main(string[] args)
        {
            string holderName="Ivan Georgiev Petkov";
            int amountOfMoney=350000;
            string bankName="Societe Generale Експресбанк";
            string iban = "BG80 BNBG 9661 1020 3456 78";
            long firstCardNumber=378282246310005; 	
            long secondCardNumber=6011000990139424;
            long thirdCardNumber = 4012888888881881;
            Console.WriteLine("holder name:{0} \nBalance:{1} \nBank name:{2} \nIBAN:{3} \nCredit card numbers:{4},{5},{6}", holderName, amountOfMoney, bankName, iban, firstCardNumber, secondCardNumber, thirdCardNumber);
        }
    }
}
