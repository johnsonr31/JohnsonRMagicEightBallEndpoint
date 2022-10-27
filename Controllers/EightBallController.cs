// Richard Johnson
// 10-27-22
// This API will select a random phrase and display it when the user inputs the URL, similarly to when one shakes a magic eight ball. More info on the README.

using Microsoft.AspNetCore.Mvc;

namespace JohnsonRMagicEightBallEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class EightBallController : ControllerBase
{
    [HttpGet]
    // The route below will need to be added into the URL in order for the random phrase to be displayed
    [Route("Shake")]

    public string MagicEightBall()
    {
        // The three lines of code below will generate a random number between 1 and 16, which will be saved to an int
        Random random = new Random();
        int radNum = random.Next(1,16);
        string eightBallAnswer = "";

        // This switch statement will take the int that was saved from the random number and use it to determine which phrase to save as a string and return
        switch(radNum)
        {
            case 1: eightBallAnswer = "Yes"; break;

            case 2: eightBallAnswer = "No"; break;
            
            case 3: eightBallAnswer = "My sources say yes"; break;
            
            case 4: eightBallAnswer = "Signs point to no"; break;
            
            case 5: eightBallAnswer = "As I see it, yes"; break;
            
            case 6: eightBallAnswer = "Don't count on it"; break;
            
            case 7: eightBallAnswer = "Better not tell you now"; break;
            
            case 8: eightBallAnswer = "Concentrate and ask again"; break;
            
            case 9: eightBallAnswer = "Reply hazy, try again"; break;
            
            case 10: eightBallAnswer = "Outlook not so good"; break;
            
            case 11: eightBallAnswer = "Most Likely"; break;
            
            case 12: eightBallAnswer = "Cannot predict now"; break;
            
            case 13: eightBallAnswer = "Yes, definitely"; break;
            
            case 14: eightBallAnswer = "Very doubtful"; break;
            
            case 15: eightBallAnswer = "It is certain"; break;
            
            case 16: eightBallAnswer = "It is certain"; break;
        }
        // After the phrase is picked and saved as a string, it will be returned so the user can see the phrase
        return eightBallAnswer;
    }
}
