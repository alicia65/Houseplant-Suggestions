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
        readonly int MinTemp = 50;  //Global variable, available to all methods
        readonly int MaxTemp = 90; // Convention is to use UppercaseCamelCase names
        
        bool ShownMinWarning = false;
        bool ShownMaxWarning = false;

        HousePlantInfo plantInfo = new HousePlantInfo();


        public Form1()
        {
            InitializeComponent();
            this.trkTemp.Scroll += new System.EventHandler(this.HouseConditionsChanged);

            this.trkTemp.Minimum = MinTemp;
            this.trkTemp.Maximum = MaxTemp;
        }

        private void HouseConditionsChanged(object sender, EventArgs e)
        {
            int homeTemp = trkTemp.Value;
            bool southFacingWindowAvailable = chkSouthFacing.Checked;

            if (ShownMinWarning == false && homeTemp == MinTemp  )
            {
                MessageBox.Show(text: "Your home may be too cold for most houseplants", caption: "Information");
                ShownMinWarning = true;
            }
            if(ShownMaxWarning == false && homeTemp == MaxTemp) 
            {
                //Can you show a message with caption "Information" and 
                // and text "Your home may be too warm for most plants"
                // Use the named parameters for the text and caption parameters
                MessageBox.Show(text: "Your home may be too warm for most hourseplant", caption: "Information");
                ShownMaxWarning = true;
            }

            //Call our method, use return value
            string suggestionPlant = plantInfo.GenerateSuggestion(homeTemp, southFacingWindowAvailable);

            lblSuggestion.Text = suggestionPlant;
        }
        
        private void trkTemp_Scroll(object sender, EventArgs e)
        {
            // Use format string, the # symbol is replace by thenumber in tryTemp. Value
            // Pressing Alt + 176 on your number pad types a ˚ symbol
            lblTemp.Text = trkTemp.Value.ToString("# ˚F");
        }

        

        private void lblTemp_Click(object sender, EventArgs e)
        {

        }

        private void InkHousePlanatInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblSuggestion.Text == "Plant suggestion here")
            {
                plantInfo.ShowWebPage(); //plantNameis optional
            }
            else
            {
                plantInfo.ShowWebPage(lblSuggestion.Text);
            }
        } 
        
        

        private void lblSuggestion_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }   
}
