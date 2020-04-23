using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houseplant_Suggestions
{
    class HousePlantInfo
    {
        public string GenerateSuggestion(int temp, bool southFacing)
        {
            // TODO - you'll see an error until you write code to return a string
            if (southFacing)
            {
                if (temp > 65)
                {
                    return "Peace Lily"; // Warm with light
                }
                else
                {
                    return "Spider Plant"; // Cool with light
                }
            }
            else
            {
                if (temp > 65)
                {
                    return "Dragon Tree"; //Warm with low light
                }
                else
                {
                    return "Ivy"; //Cool with low light
                }
            }
        }

        public void ShowWebPage(string plantName = null) // Create new method
        {

            string url = "https://www.houseplant411.com/";

            if (plantName != null)
            {
                // Link to a specific plant should be in the form "https://www.houseplant411.com/houseplant?hpq=ivy"
                url = url + "houseplant?hpq=" + plantName;
            }


            System.Diagnostics.Process.Start(url); // Lauch web browser, navigate to URL given
        }
    }
}
