using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndListOperations2
{
    public class GenerateEmailTemplates
    {
        public string GenerateMarketingEmailTemplate(string[] names, string emailTemplate)
        {
            return "";
        }

        public string GenerateMarketingEmailTemplate()
        {
            string[] names = new string[] {
                "Adam", "Alice", "Ben", "Beth", "Charlie", "Claire", "Dave", "Debby", "Emily", "Eric",
                "Frank", "Fiona", "Gary", "Gina", "Harry", "Hannah", "Ian", "Isabel", "Jack", "Jill",
                "Kevin", "Karen", "Liam", "Lucy", "Matt", "Maggie", "Nick", "Natalie", "Oliver", "Olivia",
                "Paul", "Penny", "Quinn", "Queenie", "Ryan", "Rachel", "Steve", "Samantha", "Tom", "Tina",
                "Ursula", "Ulrich", "Vicky", "Vincent", "Wendy", "Will", "Winnie", "Xavier", "Xena"
            };

            string emailTemplate = @"
            Subject: Don't Miss Out on Our Limited-Time Offer

            Dear [Name],

            We hope this email finds you well. 
            As a valued member of [Company], we wanted to let you know about our latest promotion. 
    
            For a limited time only, we're offering [discount/offer]. 
    
            This is your chance to [benefit of offer].
    
            At [Company], we're committed to providing our customers with high-quality products and exceptional service. 
            Our [product/service] has received rave reviews from satisfied customers, and we're confident that you'll love it too.
            To take advantage of this offer, simply visit our website and use the promo code [code] at checkout. 
            This offer is only available for a limited time, so don't wait too long to make your purchase.
    
            If you have any questions about our products or this promotion, 
            please don't hesitate to reach out to our customer service team. 
    
            We're always here to help.
    
            Thank you for choosing [Company], and we look forward to serving you again in the future.

            Best regards,

            [Your Name]

            [Company]";

            string newTemplate = "";

            foreach (string name in names)
            {
                newTemplate = emailTemplate.Replace("[Name]", name);
                newTemplate = newTemplate.Replace("[Company]", "SMX");
                newTemplate = newTemplate.Replace("[discount/offer]", "80%");
                newTemplate = newTemplate.Replace("[benefit of offer]", "BUY THIS OFFER");
                newTemplate = newTemplate.Replace("[product/service]", "CORUSE");
                newTemplate = newTemplate.Replace("[code]", "SMX80");
                newTemplate = newTemplate.Replace("[Your Name]", "Jorgos");

                Console.WriteLine(newTemplate);
                Console.WriteLine("************************************************************");
                Console.WriteLine("\n");
            }

            return newTemplate;
        }
    }
}
