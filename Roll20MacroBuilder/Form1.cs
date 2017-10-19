using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roll20MacroBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_genMacro_Click(object sender, EventArgs e)
        {
            string genMacro = "&{template:dnd4epower} ";
            // Using the accessible name field to hold the tag value
            // Example: powerName has a tag of name=

            genMacro = formatMacroString(genMacro, txt_powerName.Text, txt_powerName.AccessibleName);
            genMacro = formatMacroString(genMacro, cmb_powerType.SelectedItem.ToString(),cmb_powerType.AccessibleName);
            // Keywords
            genMacro = formatMacroString(genMacro, "type="+SetActionType(), "");
            string strItem = "";
            string withoutLast = "";
            if (lst_keywords.SelectedItems.Count > 0)
            {
                foreach (Object selecteditem in lst_keywords.SelectedItems)
                {
                    strItem += selecteditem as String + " ♦ ";
                }
                withoutLast = strItem.Substring(0, (strItem.Length - 2));
            }

            genMacro = formatMacroString(genMacro, withoutLast, lst_keywords.AccessibleName);
            genMacro = formatMacroString(genMacro, cmb_actionType.SelectedItem.ToString() + " ♦ Range ", cmb_actionType.AccessibleName);
            genMacro = formatMacroString(genMacro, txt_range.Text, txt_range.AccessibleName);
            genMacro = formatMacroString(genMacro, txt_target.Text, txt_target.AccessibleName);
            genMacro = formatMacroString(genMacro, cmb_classList.SelectedItem.ToString() + " " + "@{"+ cmb_powerSelection.SelectedItem.ToString() + "-level}", "level=");
            genMacro = formatMacroString(genMacro, txt_requirement.Text, txt_requirement.AccessibleName);
            genMacro = formatMacroString(genMacro, txt_trigger.Text, txt_trigger.AccessibleName);

            if(chk_combat.Checked)
            {
                genMacro = attackAndDamage(genMacro);
            }

            if (txt_onHit.Text.Length > 0)
            {
                genMacro = formatMacroString(genMacro, txt_onHit.Text, txt_onHit.AccessibleName);
            }

            if(txt_emote.Text.Length > 0)
            {
                genMacro = formatMacroString(genMacro, txt_emote.Text, txt_emote.AccessibleName);
            }

            if(txt_special.Text.Length > 0)
            {
                genMacro = formatMacroString(genMacro, txt_special.Text, txt_special.AccessibleName);
            }

            if(txt_effect.Text.Length > 0)
            {
                genMacro = formatMacroString(genMacro, txt_effect.Text, txt_effect.AccessibleName);
            }

            if(txt_miss.Text.Length > 0)
            {
                genMacro = formatMacroString(genMacro, txt_miss.Text, txt_miss.AccessibleName);
            }

            if(txt_custom.Text.Length > 0)
            {
                genMacro += txt_custom.Text;
            }



            // Output the macro
            txt_generatedMacro.Text = genMacro;
        }

        private string formatMacroString(string genMac, string value, string binding)
        {
            genMac += "{{" + binding + value + "}} ";
            return genMac;
        }

        // special formulas for attack, damage, and critical
        private string attackAndDamage(string genMac)
        {
            string ps = cmb_powerSelection.SelectedItem.ToString();
            genMac += "{{attack=[[1d20 + @{" + ps + "-attack}]] vs @{" + ps + "-def} }}";
            genMac += "{{damage=[[(1*@{" + ps + "-weapon-num-dice})d@{" + ps + "-weapon-dice}+@{" + ps + "-damage}]] damage. }}";
            genMac += "{{critical=[[ (floor(@{level}/21)*(@{" + ps + "-weapon-num-dice}*@{" + ps + "-weapon-dice})) + @{" + ps + "-weapon-num-dice}*@{" + ps + "-weapon-dice} + @{" + ps + "-damage} ]] damage. }}";
            return genMac;
        }

        // set default values when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_actionType.SelectedIndex = 0;
            cmb_classList.SelectedIndex = 0;
            cmb_powerSelection.SelectedIndex = 0;
            cmb_powerType.SelectedIndex = 0;
        }

        private string SetActionType()
        {
            string value = "";
            Console.WriteLine(cmb_powerType.SelectedIndex);
            switch (cmb_powerType.SelectedIndex)
            {
                case 0:
                    value = "At-will";
                    break;
                case 1:
                    value = "Encounter";
                    break;
                case 2:
                    value = "Daily";
                    break;
                case 3:
                    value = "Item";
                    break;
                case 4:
                    value = "Other";
                    break;
                case 5:
                    value = "Ability";
                    break;
                case 6:
                    value = "Skill";
                    break;
            }
            return value;
        }

        // open a form to show instructions
        private void btn_help_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        // clear form contents button
        private void btn_clear_Click(object sender, EventArgs e)
        {
            resetForm();
          
        }

        //clear contents and start over
        private void resetForm()
        {
            cmb_actionType.SelectedIndex = 0;
            cmb_classList.SelectedIndex = 0;
            cmb_powerSelection.SelectedIndex = 0;
            cmb_powerType.SelectedIndex = 0;
            txt_custom.Text = "";
            txt_effect.Text = "";
            txt_emote.Text = "";
            txt_generatedMacro.Text = "";
            txt_onHit.Text = "";
            txt_powerName.Text = "";
            txt_range.Text = "";
            txt_special.Text = "";
            txt_target.Text = "";
            txt_miss.Text = "";
            lst_keywords.ClearSelected();
            txt_requirement.Text = "";
            txt_trigger.Text = "";
        }
    }
} 
