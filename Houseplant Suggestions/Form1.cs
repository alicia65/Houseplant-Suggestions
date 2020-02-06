using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Houseplant_Suggestions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.trkTemp.Scroll += new System.EventHandler(this.HouseConditionsChanged);
        }

        private void trkTemp_Scroll(object sender, EventArgs e)
        {
            // Use format string, the # symbol is replace by thenumber in tryTemp. Value
            // Pressing Alt + 176 on your number pad types a ˚ symbol
            lblTemp.Text = trkTemp.Value.ToString("# ˚F");
        }

        private void HouseConditionsChanged(object sender, EventArgs e)
        {
            int homeTemp = trkTemp.Value;
            bool southFacingWindowAvailable = chkSouthFacing.Checked;

            if (homeTemp == 50)
            {
                MessageBox.Show(text: "Your home may be too cold for most houseplants", caption: "Information");
            }
            if(homeTemp == 90) 
            {
                //Can you show a message with caption "Information" and 
                // and text "Your home may be too warm for most plants"
                // Use the named parameters for the text and caption parameters
                MessageBox.Show(text: "Your home may be too warm for most hourseplant", caption: "Information");
            }

            //Call our method, use return value
            string suggestionPlant = GenerateSuggestion(homeTemp, southFacingWindowAvailable);

            lblSuggestion.Text = suggestionPlant;
        }

        private string GenerateSuggestion(int temp, bool southFacing)
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

        private void lblTemp_Click(object sender, EventArgs e)
        {

        }

        private void InkHousePlanatInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblSuggestion.Text == "Plant suggestion here")
            {
                ShowWebPage(); //plantNameis optional
            }
            else
            {
                ShowWebPage(lblSuggestion.Text);
            }
        } 
        
         private void ShowWebPage(string plantName = null) // Create new method
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
