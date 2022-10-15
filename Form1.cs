using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia
{
    public partial class Form1 : Form
    {
        int screenNum = 0;
        int score = 0;
       bool PopCorrect = false;
        bool GeneralCorrect = false;
        bool MathsCorrect = false;
        bool TechCorrect = false;

        public Form1()
        {
            InitializeComponent();
             
        }

 

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch(screenNum)
            {

                case 0: 

                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                label2.Text = "Please select a category";
                button1.Text = "Pop Culture";
                button2.Text = "General Knowledge";
                button3.Text = "Mathematics";
                button4.Text = "Technology";

                    screenNum = 1;

                break;
               
                case 1:
                    screenNum = 20; 

                    break;





                case 10:

                    label2.Text = "In which song does Lady Gaga sing: 'I'm sick of their city games, I crave a real wild man' ?";

                    button1.Text = "John Wayne";
                    button2.Text = "911";
                    button3.Text = "Born This Way";
                    button4.Text = "G.U.Y";

                    screenNum = 11;
                    break;

                case 11:
                    label2.Text = "Who wrote the popular romance saga 'Twilight' ?";

                    button1.Text = "Liane Moriarty";
                    button2.Text = "James Patterson";
                    button3.Text = "Stephenie Meyer";
                    button4.Text = "Nora Roberts";

                    screenNum = 12;

                    break;

                case 12:
                    label2.Text = "What was the first non-English-language film to win Best Picture at the Oscars ?";

                    button1.Text = "The Platform";
                    button2.Text = "Battle Royale";
                    button3.Text = "Oldboy";
                    button4.Text = "Parasite";

                    screenNum = 13;

                    break;

                case 13:
                    label2.Text = "Which pop star burnt down her home gym in 2020 ? ";

                    button1.Text = "Jennifer Lopez";
                    button2.Text = "Britney Spears";
                    button3.Text = "Ariana Grande";
                    button4.Text = "Miley Cyrus";

                    screenNum = 2;

                    break;


                case 20:

                    label2.Text = "What is an alumna?";
                    button1.Text = "A male lecturer";
                    button2.Text = "A female graduate";
                    button3.Text = "A male graduate";
                    button4.Text = "A female lecturer";

                    screenNum = 21;

                    break;


                case 21:
                    label2.Text = "What colour is pistachio?";
                    button1.Text = "Light Brown";
                    button2.Text = "Light Orange";
                    button3.Text = "Light Green";
                    button4.Text = "Dark Green";

                    score ++;
                    screenNum = 22;

                    break;

                case 22:
                    label2.Text = "In chess, which piece has the combined moves of two existing pieces?";
                    button1.Text = "The King";
                    button2.Text = "The Queen";
                    button3.Text = "The Bishop";
                    button4.Text = "The Rook";


                    screenNum = 23;

                    break;
                case 23:
                    label2.Text = "Which iconic mystery novel makes frequent references to the poem 'Ten Little Soldiers'?";
                    button1.Text = "The Adventures of Sherlock Holmes";
                    button2.Text = "Gone Girl";
                    button3.Text = "Murder On The Orient Express";
                    button4.Text = "And Then There Were None";


                    score ++;
                    screenNum = 3;

                    break;

                case 30:
                    label2.Text = "What number doesn't have its own Roman numeral";
                    button1.Text = "6";
                    button2.Text = "0";
                    button3.Text = "100";
                    button4.Text = "11";



                    screenNum = 31;


                    break;

                case 31:


                    label2.Text = "How many sides does a dodecahedron have?";
                    button1.Text = "11";
                    button2.Text = "10";
                    button3.Text = "12";
                    button4.Text = "9";


                    score ++;
                    screenNum = 32;

                    break;

                case 32:

                    label2.Text = "Which number is represented by the prefix 'Deka' ?";
                    button1.Text = "10";
                    button2.Text = "0";
                    button3.Text = "100";
                    button4.Text = "1000";



                    screenNum = 33;

                    break;

                case 33:

                    label2.Text = "What is the largest composite number under 40?";
                    button1.Text = "18";
                    button2.Text = "20";
                    button3.Text = "1";
                    button4.Text = "39";



                    screenNum = 3;

                    break;

                case 40:

                    label2.Text = "Who is the creator of operating system Linux and version control system Git?";
                    button1.Text = "Linus Torvalds";
                    button2.Text = "Max Levchin";
                    button3.Text = "Tim Bray";
                    button4.Text = "Dave Cutler";



                    screenNum = 41;

                    break;

                case 41:
                    label2.Text = "What happens if a CD spins too fast?";
                    button1.Text = "No data will be read";
                    button2.Text = "It will melt";
                    button3.Text = "Its layers will come apart";
                    button4.Text = "It will explode";



                    screenNum = 42;

                    break;

                case 42:

                    label2.Text = "What was the first web browser available on Microsoft Windows ?";
                    button1.Text = "Internet Explorer";
                    button2.Text = "Cello";
                    button3.Text = "Opera";
                    button4.Text = "Microsoft Edge";



                    screenNum = 43;

                    break;

                case 43:
                    label2.Text = "What was the first computer virus released into the wild ?";
                    button1.Text = "Brain";
                    button2.Text = "Creeper";
                    button3.Text = "Melissa";
                    button4.Text = "WinVir";


                    score ++;
                    screenNum = 3;

                    break;

                case 2:
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    score++; 
              
                    screenNum = 3;
                    break;

                case 3:
                    
                    label1.Text = "Your score is " + score;
                    label2.Text = "";

                    break;
            }  

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (screenNum)
            {

                case 1:

                    screenNum = 10;

                   break;

                case 10:

                    label2.Text = "In which song does Lady Gaga sing: 'I'm sick of their city games, I crave a real wild man' ?";

                    button1.Text = "John Wayne";
                    button2.Text = "911";
                    button3.Text = "Born This Way";
                    button4.Text = "G.U.Y";

                    screenNum = 11; 
                    break;

                case 11:
                    label2.Text = "Who wrote the popular romance saga 'Twilight' ?";

                    button1.Text = "Liane Moriarty";
                    button2.Text = "James Patterson";
                    button3.Text = "Stephenie Meyer";
                    button4.Text = "Nora Roberts";

                    screenNum = 12;
                    score ++;
                    break;

                case 12:
                    label2.Text = "What was the first non-English-language film to win Best Picture at the Oscars ?";

                    button1.Text = "The Platform";
                    button2.Text = "Battle Royale";
                    button3.Text = "Oldboy";
                    button4.Text = "Parasite";

                    screenNum = 13; 

                    break;

                case 13:
                    label2.Text = "Which pop star burnt down her home gym in 2020 ? ";

                    button1.Text = "Jennifer Lopez";
                    button2.Text = "Britney Spears";
                    button3.Text = "Ariana Grande";
                    button4.Text = "Miley Cyrus";

                    screenNum = 3;

                    break;


                case 20:

                    label2.Text = "What is an alumna?";
                    button1.Text = "A male lecturer";
                    button2.Text = "A female graduate";
                    button3.Text = "A male graduate";
                    button4.Text = "A female lecturer";

                    screenNum = 21;

                    break;


                case 21:
                    label2.Text = "What colour is pistachio?";
                    button1.Text = "Light Brown";
                    button2.Text = "Light Orange";
                    button3.Text = "Light Green";
                    button4.Text = "Dark Green";

                    
                    screenNum = 22;

                    break;

                case 22:
                    label2.Text = "In chess, which piece has the combined moves of two existing pieces?";
                    button1.Text = "The King";
                    button2.Text = "The Queen";
                    button3.Text = "The Bishop";
                    button4.Text = "The Rook";

                    
                    screenNum = 23;

                    break;
                case 23:
                    label2.Text = "Which iconic mystery novel makes frequent references to the poem 'Ten Little Soldiers'?";
                    button1.Text = "The Adventures of Sherlock Holmes";
                    button2.Text = "Gone Girl";
                    button3.Text = "Murder On The Orient Express";
                    button4.Text = "And Then There Were None";

                    

                    screenNum = 3;

                    break;

                case 30:
                    label2.Text = "What number doesn't have its own Roman numeral";
                    button1.Text = "6";
                    button2.Text = "0";
                    button3.Text = "100";
                    button4.Text = "11";



                    screenNum = 31;


                    break;

                case 31:

        
                    label2.Text = "How many sides does a dodecahedron have?";
                    button1.Text = "11";
                    button2.Text = "10";
                    button3.Text = "12";
                    button4.Text = "9";



                    screenNum = 32;

                    break;

                case 32:

                    label2.Text = "Which number is represented by the prefix 'Deka' ?";
                    button1.Text = "10";
                    button2.Text = "0";
                    button3.Text = "100";
                    button4.Text = "1000";



                    screenNum = 33;

                    break;

                case 33:

                    label2.Text = "What is the largest composite number under 40?";
                    button1.Text = "18";
                    button2.Text = "20";
                    button3.Text = "1";
                    button4.Text = "39";


                    score ++;
                    screenNum = 3;

                    break;

                case 40:

                    label2.Text = "Who is the creator of operating system Linux and version control system Git?";
                    button1.Text = "Linus Torvalds";
                    button2.Text = "Max Levchin";
                    button3.Text = "Tim Bray";
                    button4.Text = "Dave Cutler";



                    screenNum = 41;

                    break;

                case 41:
                    label2.Text = "What happens if a CD spins too fast?";
                    button1.Text = "No data will be read";
                    button2.Text = "It will melt";
                    button3.Text = "Its layers will come apart";
                    button4.Text = "It will explode";


                    score ++;
                    screenNum = 42;

                    break;

                case 42:

                    label2.Text = "What was the first web browser available on Microsoft Windows ?";
                    button1.Text = "Internet Explorer";
                    button2.Text = "Cello";
                    button3.Text = "Opera";
                    button4.Text = "Microsoft Edge";



                    screenNum = 43;

                    break;

                case 43:
                    label2.Text = "What was the first computer virus released into the wild ?";
                    button1.Text = "Brain";
                    button2.Text = "Creeper";
                    button3.Text = "Melissa";
                    button4.Text = "WinVir";



                    screenNum = 2;

                    break;

                case 2:
                    score ++;

                    screenNum = 3;
                    break;

                case 3:
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    label1.Text = "Your score is " + score;
                    label2.Text = "";

                    break;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (screenNum)
            {
                case 1:

                    screenNum = 30;

                    break;

                case 10:

                    label2.Text = "In which song does Lady Gaga sing: 'I'm sick of their city games, I crave a real wild man' ?";

                    button1.Text = "John Wayne";
                    button2.Text = "911";
                    button3.Text = "Born This Way";
                    button4.Text = "G.U.Y";

                    screenNum = 11;
                    break;

                case 11:
                    label2.Text = "Who wrote the popular romance saga 'Twilight' ?";

                    button1.Text = "Liane Moriarty";
                    button2.Text = "James Patterson";
                    button3.Text = "Stephenie Meyer";
                    button4.Text = "Nora Roberts";

                    screenNum = 12;

                    break;

                case 12:
                    label2.Text = "What was the first non-English-language film to win Best Picture at the Oscars ?";

                    button1.Text = "The Platform";
                    button2.Text = "Battle Royale";
                    button3.Text = "Oldboy";
                    button4.Text = "Parasite";

                    screenNum = 13;
                    score ++;
                    break;

                case 13:
                    label2.Text = "Which pop star burnt down her home gym in 2020 ? ";

                    button1.Text = "Jennifer Lopez";
                    button2.Text = "Britney Spears";
                    button3.Text = "Ariana Grande";
                    button4.Text = "Miley Cyrus";

                    screenNum = 3;

                    break;


                case 20:

                    label2.Text = "What is an alumna?";
                    button1.Text = "A male lecturer";
                    button2.Text = "A female graduate";
                    button3.Text = "A male graduate";
                    button4.Text = "A female lecturer";

                    screenNum = 21;

                    break;


                case 21:
                    label2.Text = "What colour is pistachio?";
                    button1.Text = "Light Brown";
                    button2.Text = "Light Orange";
                    button3.Text = "Light Green";
                    button4.Text = "Dark Green";


                    screenNum = 22;

                    break;

                case 22:
                    label2.Text = "In chess, which piece has the combined moves of two existing pieces?";
                    button1.Text = "The King";
                    button2.Text = "The Queen";
                    button3.Text = "The Bishop";
                    button4.Text = "The Rook";


                    screenNum = 23;
                    score ++;
                    break;
                case 23:
                    label2.Text = "Which iconic mystery novel makes frequent references to the poem 'Ten Little Soldiers'?";
                    button1.Text = "The Adventures of Sherlock Holmes";
                    button2.Text = "Gone Girl";
                    button3.Text = "Murder On The Orient Express";
                    button4.Text = "And Then There Were None";



                    screenNum = 3;

                    break;

                case 30:
                    label2.Text = "What number doesn't have its own Roman numeral";
                    button1.Text = "6";
                    button2.Text = "0";
                    button3.Text = "100";
                    button4.Text = "11";



                    screenNum = 31;


                    break;

                case 31:


                    label2.Text = "How many sides does a dodecahedron have?";
                    button1.Text = "11";
                    button2.Text = "10";
                    button3.Text = "12";
                    button4.Text = "9";



                    screenNum = 32;

                    break;

                case 32:

                    label2.Text = "Which number is represented by the prefix 'Deka' ?";
                    button1.Text = "10";
                    button2.Text = "0";
                    button3.Text = "100";
                    button4.Text = "1000";


                    score ++;
                    screenNum = 33;

                    break;

                case 33:

                    label2.Text = "What is the largest composite number under 40?";
                    button1.Text = "18";
                    button2.Text = "20";
                    button3.Text = "1";
                    button4.Text = "39";



                    screenNum = 3;

                    break;

                case 40:

                    label2.Text = "Who is the creator of operating system Linux and version control system Git?";
                    button1.Text = "Linus Torvalds";
                    button2.Text = "Max Levchin";
                    button3.Text = "Tim Bray";
                    button4.Text = "Dave Cutler";



                    screenNum = 41;

                    break;

                case 41:
                    label2.Text = "What happens if a CD spins too fast?";
                    button1.Text = "No data will be read";
                    button2.Text = "It will melt";
                    button3.Text = "Its layers will come apart";
                    button4.Text = "It will explode";



                    screenNum = 42;

                    break;

                case 42:

                    label2.Text = "What was the first web browser available on Microsoft Windows ?";
                    button1.Text = "Internet Explorer";
                    button2.Text = "Cello";
                    button3.Text = "Opera";
                    button4.Text = "Microsoft Edge";



                    screenNum = 43;

                    break;

                case 43:
                    label2.Text = "What was the first computer virus released into the wild ?";
                    button1.Text = "Brain";
                    button2.Text = "Creeper";
                    button3.Text = "Melissa";
                    button4.Text = "WinVir";



                    screenNum = 3;

                    break;

                case 2:
                    score ++;

                    screenNum = 3;
                    break;

                case 3:
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    label1.Text = "Your score is " + score;
                    label2.Text = "";

                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            switch (screenNum)
            {
                case 1:

                    screenNum = 40;

                    break;

                case 10:

                    label2.Text = "In which song does Lady Gaga sing: 'I'm sick of their city games, I crave a real wild man' ?";

                    button1.Text = "John Wayne";
                    button2.Text = "911";
                    button3.Text = "Born This Way";
                    button4.Text = "G.U.Y";

                    screenNum = 11;
                    break;

                case 11:
                    label2.Text = "Who wrote the popular romance saga 'Twilight' ?";

                    button1.Text = "Liane Moriarty";
                    button2.Text = "James Patterson";
                    button3.Text = "Stephenie Meyer";
                    button4.Text = "Nora Roberts";

                    screenNum = 12;

                    break;

                case 12:
                    label2.Text = "What was the first non-English-language film to win Best Picture at the Oscars ?";

                    button1.Text = "The Platform";
                    button2.Text = "Battle Royale";
                    button3.Text = "Oldboy";
                    button4.Text = "Parasite";

                    screenNum = 13;

                    break;

                case 13:
                    label2.Text = "Which pop star burnt down her home gym in 2020 ? ";

                    button1.Text = "Jennifer Lopez";
                    button2.Text = "Britney Spears";
                    button3.Text = "Ariana Grande";
                    button4.Text = "Miley Cyrus";

                    score ++;

                    screenNum = 3;

                    break;


                case 20:

                    label2.Text = "What is an alumna?";
                    button1.Text = "A male lecturer";
                    button2.Text = "A female graduate";
                    button3.Text = "A male graduate";
                    button4.Text = "A female lecturer";

                    screenNum = 21;

                    break;


                case 21:
                    label2.Text = "What colour is pistachio?";
                    button1.Text = "Light Brown";
                    button2.Text = "Light Orange";
                    button3.Text = "Light Green";
                    button4.Text = "Dark Green";


                    screenNum = 22;

                    break;

                case 22:
                    label2.Text = "In chess, which piece has the combined moves of two existing pieces?";
                    button1.Text = "The King";
                    button2.Text = "The Queen";
                    button3.Text = "The Bishop";
                    button4.Text = "The Rook";


                    screenNum = 23;

                    break;
                case 23:
                    label2.Text = "Which iconic mystery novel makes frequent references to the poem 'Ten Little Soldiers'?";
                    button1.Text = "The Adventures of Sherlock Holmes";
                    button2.Text = "Gone Girl";
                    button3.Text = "Murder On The Orient Express";
                    button4.Text = "And Then There Were None";



                    screenNum = 2;

                    break;

                case 30:
                    label2.Text = "What number doesn't have its own Roman numeral";
                    button1.Text = "6";
                    button2.Text = "0";
                    button3.Text = "100";
                    button4.Text = "11";



                    screenNum = 31;


                    break;

                case 31:


                    label2.Text = "How many sides does a dodecahedron have?";
                    button1.Text = "11";
                    button2.Text = "10";
                    button3.Text = "12";
                    button4.Text = "9";



                    screenNum = 32;

                    break;

                case 32:

                    label2.Text = "Which number is represented by the prefix 'Deka' ?";
                    button1.Text = "10";
                    button2.Text = "0";
                    button3.Text = "100";
                    button4.Text = "1000";



                    screenNum = 33;

                    break;

                case 33:

                    label2.Text = "What is the largest composite number under 40?";
                    button1.Text = "18";
                    button2.Text = "20";
                    button3.Text = "1";
                    button4.Text = "39";



                    screenNum = 2;

                    break;

                case 40:

                    label2.Text = "Who is the creator of operating system Linux and version control system Git?";
                    button1.Text = "Linus Torvalds";
                    button2.Text = "Max Levchin";
                    button3.Text = "Tim Bray";
                    button4.Text = "Dave Cutler";



                    screenNum = 41;

                    break;

                case 41:
                    label2.Text = "What happens if a CD spins too fast?";
                    button1.Text = "No data will be read";
                    button2.Text = "It will melt";
                    button3.Text = "Its layers will come apart";
                    button4.Text = "It will explode";



                    screenNum = 42;

                    break;

                case 42:

                    label2.Text = "What was the first web browser available on Microsoft Windows ?";
                    button1.Text = "Internet Explorer";
                    button2.Text = "Cello";
                    button3.Text = "Opera";
                    button4.Text = "Microsoft Edge";


                    score ++;
                    screenNum = 43;

                    break;

                case 43:
                    label2.Text = "What was the first computer virus released into the wild ?";
                    button1.Text = "Brain";
                    button2.Text = "Creeper";
                    button3.Text = "Melissa";
                    button4.Text = "WinVir";



                    screenNum = 3;

                    break;

                case 2:
                    score ++;

                    screenNum = 3;
                    break;

                case 3:
                    panel1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    label1.Text = "Your score is " + score;
                    label2.Text = "";

                    break;
            }
        }
    }
}
