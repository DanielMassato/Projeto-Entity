using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declared Variables
        private string[] SiteMemoryArray = new string[100];
        private int count = 0;

        // Page Load
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("http://www.google.com/");      // Goes To A Preset Site At Run Time
            SiteMemoryArray[count] = urlTextBox.Text;           // Saves URL To Memory
        }

        
        // Code For The ToolStrip 

        // URL TextBox 
        private void urlTextBox_Click(object sender, EventArgs e)
        {
            urlTextBox.SelectAll();     // Selects All The Text In The urlTexBox
        }

        // GO Button
        private void goButton_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(urlTextBox.Text);       // Navigates To The Site Typed In The urlTextBox
        }
        
        // Back Button
        private void backButton_Click(object sender, EventArgs e)
        {
            if (count > 0)                                  // Checks To Make Sure The Count Variable Is More Then 0
            {
                count = count - 1;                          // Subtracts 1 From Count Variable 
                urlTextBox.Text = SiteMemoryArray[count];   // Replace The Text In The urlTextBox With The Last URl
                webBrowser.Navigate(urlTextBox.Text);       // Navigates To The Site Typed In The urlTextBox
                forwardButton.Enabled = true;               // Enables The forwarButton

            }
        }

        // Forward Button
        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (count < 100)                                // Checks To Make Sure The Count Variable Is Less Then 100
            {
                count = count + 1;                          // Adds 1 To Count Variable
                urlTextBox.Text = SiteMemoryArray[count];   // Replace The Text In The urlTextBox With The Next URl
                webBrowser.Navigate(urlTextBox.Text);       // Navigates To The Site Typed In The urlTextBox
                backButton.Enabled = true;                  // Enables The backButton

                count = count + 1;                          // Adds 1 To Count Variable 
                if (SiteMemoryArray[count] == null)         // Checks To See If The Next Variable In The SiteMemoryArray Is Null
                {
                    forwardButton.Enabled = false;          // Disables The forwarButton
                }
                count = count - 1;                          // Subtracts 1 From Count Variable 
            }
        }

        // Web Browser

        // Before Navigating
        private void webBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            doneLabel.Visible = false;      // Sets The Visible Property of The donLabel To False
            progressBar.Visible = true;     // Sets The Visible Property of The progressBar To True
            progressBar.Value = 0;          // Sets Value Of The progressBar to 0
            progressBar.Minimum = 0;        // Sets The Minimum Value The progressBar to 0
            progressBar.Maximum = 100;      // Sets The Maximum Value The progressBar to 100
            progressBar.Step = 10;          // Sets The Step Value The progressBar to 10
            progressBar.PerformStep();      // Preforms The Step Rasing The progressBar Value From 0 to 10
        }

        // After Navigating
        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            progressBar.Step = 80;                                  // Sets The Step Value The progressBar to 80
            progressBar.PerformStep();                              // Preforms The Step Rasing The progressBar Value From 10 to 90
            urlTextBox.Text = webBrowser.Url.ToString();            // Replace The Text In The urlTextBox With The URl Currently Loading
            openingLabel.Text = "Openning: " + urlTextBox.Text;     // Displays The Message Opening: And The Current URL 
            openingLabel.Visible = true;                            // Sets The Visible Property of The openingLabel To True
        }

        // After The Site Has Finished Loading
        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            progressBar.Step = 10;                                              // Sets The Step Value The progressBar to 10
            progressBar.PerformStep();                                          // Preforms The Step Rasing The progressBar Value From 90 to 100
            progressBar.Visible = false;                                        // Sets The Visible Property of The progressBar To False
            openingLabel.Visible = false;                                       // Sets The Visible Property of The openingLabel To False
            doneLabel.Visible = true;                                           // Sets The Visible Property of The doneLabel To True

            if (SiteMemoryArray[count].ToString() != webBrowser.Url.ToString()) // Checks To Make Sure The Same URL Is Not Being Enter Twice In A Row
            {
                count = count + 1;                                              // Adds 1 To Count Variable
                SiteMemoryArray[count] = urlTextBox.Text;                       // Saves The Site URL To Memory
            }

            if (count > 0)                                                      // Checks To See If The Count Is More Then 0
            {
                backButton.Enabled = true;                                      // Enables The backButton
            }
            else
            {
                backButton.Enabled = false;                                     // Disables The backButton
            }
        }



    }
}
