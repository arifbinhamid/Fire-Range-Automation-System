using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_Range_Automation_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> soldierNo = new List<string>();
        List<string> soldierName = new List<string>();
        List<string> target1Score = new List<string>();
        List<string> target2Score = new List<string>();
        List<string> target3Score = new List<string>();
        List<string> target4Score = new List<string>();
        List<double> totalScore = new List<double>();
        List<double> averageScore = new List<double>();
        int i = 0;
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (soldierNo.Contains(soldierNoTextBox.Text))
            {
                MessageBox.Show("Soldier already Exist!");
            }
            else if (String.IsNullOrEmpty(soldierNoTextBox.Text))
            {
                MessageBox.Show("Soldier No is Empty");
            }
            else if (String.IsNullOrEmpty(soldierNameTextBox.Text))
            {
                MessageBox.Show("Soldier Name is Empty");
            }
            else if (String.IsNullOrEmpty(target1ScoreTextBox.Text))
            {
                MessageBox.Show("Target 1 Score  is Empty");
            }
            else if (String.IsNullOrEmpty(target2ScoreTextBox.Text))
            {
                MessageBox.Show("Target 2 Score  is Empty");
            }
            else if (String.IsNullOrEmpty(target3ScoreTextBox.Text))
            {
                MessageBox.Show("Target 3 Score  is Empty");
            }
            else if (String.IsNullOrEmpty(target4ScoreTextBox.Text))
            {
                MessageBox.Show("Target 4 Score  is Empty");
            }
            else
            {
                soldierNo.Add(soldierNoTextBox.Text);
                soldierName.Add(soldierNameTextBox.Text);
                target1Score.Add(target1ScoreTextBox.Text);
                target2Score.Add(target2ScoreTextBox.Text);
                target3Score.Add(target3ScoreTextBox.Text);
                target4Score.Add(target4ScoreTextBox.Text);
                
                totalScore.Add(Convert.ToDouble(target1Score[i]) + Convert.ToDouble(target2Score[i]) + Convert.ToDouble(target3Score[i]) + Convert.ToDouble(target4Score[i]));
                averageScore.Add(totalScore[i] / 4);
                i++;

            
            
            }
        }

        private void search_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                MessageBox.Show("Nothing To Search ");
            }
            else if (soldierNoRadioButton.Checked)
            {

                if (soldierNo.Contains(searchTextBox.Text))
                {
                    int i = soldierNo.IndexOf(searchTextBox.Text);
                   
                    displayRichTextBox.Text = "Soldier No\tSoldier Name\tAverage Score\tTotal Score\n" +
                        soldierNo[i] + "\t\t" + soldierName[i] + "\t\t" + averageScore[i] + "\t\t" + totalScore[i];
                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
            else if (soldierNameRadioButton.Checked)
            {
                if (soldierName.Contains(searchTextBox.Text))
                {

                   
                    int i = soldierNo.IndexOf(searchTextBox.Text);
                    
                    displayRichTextBox.Text = "Soldier No\tSoldier Name\tAverage Score\tTotal Score\n" +
                         soldierNo[i] + "\t\t" + soldierName[i] + "\t\t" + averageScore[i] + "\t\t" + totalScore[i];
                }
                else
                {
                    MessageBox.Show("Not found");
                }
            }
            else
            {
                MessageBox.Show("Check at least one radio Button");
            }

        }
        
        private void show_Click(object sender, EventArgs e)
        {
            try
            {
                displayRichTextBox.Text = "Soldier No\tSoldier Name\tAverage Score\tTotal Score\n";
                int k = 0;
                foreach(string soldier in soldierName)
                {
                    
                   displayRichTextBox.Text = displayRichTextBox.Text + soldierNo[k] + "\t\t" + soldier + "\t\t" + averageScore[k] + "\t\t" + totalScore[k]+"\n";


                    k++;

                }
                topAverageScorer.Text = soldierName[averageScore.IndexOf(averageScore.Max())];
                topTotalScorer.Text = soldierName[totalScore.IndexOf(totalScore.Max())];
            }
            catch (Exception arr)
            {
                MessageBox.Show(arr.Message);
            }
        }
        
    }
}
