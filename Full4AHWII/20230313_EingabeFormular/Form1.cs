using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20230313_EingabeFormular
{
    public partial class FormMain : Form
    {
        public TextBox[] textBox_Inputs;
        public TextBox[] textBox_Outputs;

        public FormMain()
        {
            InitializeComponent();

            //Alle Textboxen hinzufügen
            textBox_Inputs = new TextBox[5];
            textBox_Outputs = new TextBox[5];

            //Textboxen zuweisen
            textBox_Inputs[0] = textBox_VornameInput;
            textBox_Inputs[1] = textBox_NachnameInput;
            textBox_Inputs[2] = textBox_AlterInput;
            textBox_Inputs[3] = textBox_AdresseInput;
            textBox_Inputs[4] = textBox_SchulwegInput;

            textBox_Outputs[0] = textBox_VornameOutput;
            textBox_Outputs[1] = textBox_NachnameOutput;
            textBox_Outputs[2] = textBox_AlterOutput;
            textBox_Outputs[3] = textBox_AdresseOutput;
            textBox_Outputs[4] = textBox_SchulwegOutput;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            //Programm beenden
            this.Close();
        }

        private void button_uebernehmen_Click(object sender, EventArgs e)
        {
            //Kontrollieren ob alle Werte richtig eingegen wurden
            for(int i = 0; i < textBox_Inputs.Length; i++)
            {
                if(textBox_Inputs[i].Text == "")
                {
                    string feldname_mit_button = textBox_Inputs[i].Name;
                    string feldname_mit_input = feldname_mit_button.Substring(8,feldname_mit_button.Length - 8);
                    string feldname = feldname_mit_input.Substring(0, feldname_mit_input.Length - 5);
                    MessageBox.Show("Sie haben keinen " + feldname + " eingeben!");
                    return;
                }
            }

            //Alter in Int und Double Variable übernehmen
            int alter = Int32.Parse(textBox_Inputs[2].Text);
            double schulweg = Convert.ToDouble(SwitchDotandComa(textBox_Inputs[4].Text, ','));

            //Werte übertragen
            textBox_Outputs[0].Text = textBox_VornameInput.Text;
            textBox_Outputs[1].Text = textBox_NachnameInput.Text;
            textBox_Outputs[2].Text = Convert.ToString(alter);
            textBox_Outputs[3].Text = textBox_AdresseInput.Text;
            textBox_Outputs[4].Text = SwitchDotandComa(Convert.ToString(schulweg), '.');
        }

        private void WerteUbertragen()
        {
            for(int i = 0; i < textBox_Inputs.Length; i++)
            {
                textBox_Outputs[i].Text = textBox_Inputs[i].Text;
            }
        }

        private void textBox_AlterInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Convert.ToInt32(e.KeyChar) > 47 && Convert.ToInt32(e.KeyChar) < 58 || Convert.ToInt32(e.KeyChar) == 8);
        }

        private void textBox_SchulwegInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Convert.ToInt32(e.KeyChar) > 47 && Convert.ToInt32(e.KeyChar) < 58 || Convert.ToInt32(e.KeyChar) == 8 || Convert.ToInt32(e.KeyChar) == 46))
            {
                e.KeyChar = '\0';
            }

            if(e.KeyChar == '.' && textBox_SchulwegInput.Text.Contains("."))
            {
                e.KeyChar = '\0';
            }
        }

        private static string SwitchDotandComa(string input, char charactertochange)
        {
            string sol = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '.' || input[i] == ',')
                {
                    sol += Convert.ToString(charactertochange);
                }
                else
                {
                    sol += Convert.ToString(input[i]);
                }
            }

            return sol;
        }
    }
}
