namespace Roll20MacroBuilder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_powerName = new System.Windows.Forms.TextBox();
            this.lbl_powerName = new System.Windows.Forms.Label();
            this.lbl_keywords = new System.Windows.Forms.Label();
            this.lbl_range = new System.Windows.Forms.Label();
            this.txt_range = new System.Windows.Forms.TextBox();
            this.lbl_powerSelect = new System.Windows.Forms.Label();
            this.lbl_target = new System.Windows.Forms.Label();
            this.txt_target = new System.Windows.Forms.TextBox();
            this.lbl_onHit = new System.Windows.Forms.Label();
            this.txt_onHit = new System.Windows.Forms.TextBox();
            this.cmb_powerSelection = new System.Windows.Forms.ComboBox();
            this.lbl_keyw = new System.Windows.Forms.Label();
            this.lbl_actionType = new System.Windows.Forms.Label();
            this.cmb_actionType = new System.Windows.Forms.ComboBox();
            this.btn_genMacro = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.txt_generatedMacro = new System.Windows.Forms.TextBox();
            this.lst_keywords = new System.Windows.Forms.ListBox();
            this.lbl_special = new System.Windows.Forms.Label();
            this.txt_special = new System.Windows.Forms.TextBox();
            this.lbl_miss = new System.Windows.Forms.Label();
            this.txt_miss = new System.Windows.Forms.TextBox();
            this.lbl_effect = new System.Windows.Forms.Label();
            this.txt_effect = new System.Windows.Forms.TextBox();
            this.lbl_powerType = new System.Windows.Forms.Label();
            this.cmb_powerType = new System.Windows.Forms.ComboBox();
            this.lbl_emote = new System.Windows.Forms.Label();
            this.txt_emote = new System.Windows.Forms.TextBox();
            this.lbl_custom = new System.Windows.Forms.Label();
            this.txt_custom = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cmb_classList = new System.Windows.Forms.ComboBox();
            this.lbl_class = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_requirement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_trigger = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lst_combatType = new System.Windows.Forms.ListBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_powerName
            // 
            this.txt_powerName.AccessibleName = "name=";
            this.txt_powerName.Location = new System.Drawing.Point(12, 12);
            this.txt_powerName.Name = "txt_powerName";
            this.txt_powerName.Size = new System.Drawing.Size(182, 20);
            this.txt_powerName.TabIndex = 0;
            // 
            // lbl_powerName
            // 
            this.lbl_powerName.AccessibleName = "name=";
            this.lbl_powerName.AutoSize = true;
            this.lbl_powerName.Location = new System.Drawing.Point(199, 15);
            this.lbl_powerName.Name = "lbl_powerName";
            this.lbl_powerName.Size = new System.Drawing.Size(68, 13);
            this.lbl_powerName.TabIndex = 1;
            this.lbl_powerName.Text = "Power Name";
            // 
            // lbl_keywords
            // 
            this.lbl_keywords.AutoSize = true;
            this.lbl_keywords.Location = new System.Drawing.Point(500, 181);
            this.lbl_keywords.Name = "lbl_keywords";
            this.lbl_keywords.Size = new System.Drawing.Size(53, 13);
            this.lbl_keywords.TabIndex = 3;
            this.lbl_keywords.Text = "Keywords";
            // 
            // lbl_range
            // 
            this.lbl_range.AutoSize = true;
            this.lbl_range.Location = new System.Drawing.Point(199, 92);
            this.lbl_range.Name = "lbl_range";
            this.lbl_range.Size = new System.Drawing.Size(39, 13);
            this.lbl_range.TabIndex = 7;
            this.lbl_range.Text = "Range";
            // 
            // txt_range
            // 
            this.txt_range.AccessibleName = "range=";
            this.txt_range.Location = new System.Drawing.Point(12, 91);
            this.txt_range.Name = "txt_range";
            this.txt_range.Size = new System.Drawing.Size(182, 20);
            this.txt_range.TabIndex = 6;
            // 
            // lbl_powerSelect
            // 
            this.lbl_powerSelect.AutoSize = true;
            this.lbl_powerSelect.Location = new System.Drawing.Point(199, 117);
            this.lbl_powerSelect.Name = "lbl_powerSelect";
            this.lbl_powerSelect.Size = new System.Drawing.Size(147, 13);
            this.lbl_powerSelect.TabIndex = 9;
            this.lbl_powerSelect.Text = "Power Selection ( from roll20 )";
            // 
            // lbl_target
            // 
            this.lbl_target.AutoSize = true;
            this.lbl_target.Location = new System.Drawing.Point(199, 141);
            this.lbl_target.Name = "lbl_target";
            this.lbl_target.Size = new System.Drawing.Size(38, 13);
            this.lbl_target.TabIndex = 11;
            this.lbl_target.Text = "Target";
            // 
            // txt_target
            // 
            this.txt_target.AccessibleName = "target=";
            this.txt_target.Location = new System.Drawing.Point(12, 141);
            this.txt_target.Name = "txt_target";
            this.txt_target.Size = new System.Drawing.Size(181, 20);
            this.txt_target.TabIndex = 10;
            // 
            // lbl_onHit
            // 
            this.lbl_onHit.AutoSize = true;
            this.lbl_onHit.Location = new System.Drawing.Point(559, 15);
            this.lbl_onHit.Name = "lbl_onHit";
            this.lbl_onHit.Size = new System.Drawing.Size(20, 13);
            this.lbl_onHit.TabIndex = 13;
            this.lbl_onHit.Text = "Hit";
            // 
            // txt_onHit
            // 
            this.txt_onHit.AccessibleName = "hiteffect=";
            this.txt_onHit.Location = new System.Drawing.Point(372, 12);
            this.txt_onHit.Multiline = true;
            this.txt_onHit.Name = "txt_onHit";
            this.txt_onHit.Size = new System.Drawing.Size(181, 44);
            this.txt_onHit.TabIndex = 12;
            // 
            // cmb_powerSelection
            // 
            this.cmb_powerSelection.FormattingEnabled = true;
            this.cmb_powerSelection.Items.AddRange(new object[] {
            "power-1",
            "power-2",
            "power-3",
            "power-4",
            "power-5",
            "power-6",
            "power-7",
            "power-8",
            "power-9",
            "power-10",
            "power-11",
            "power-12",
            "power-13",
            "power-14",
            "power-15",
            "power-16",
            "power-17",
            "power-18",
            "power-19",
            "power-20",
            "power-21",
            "power-22",
            "power-23",
            "power-24",
            "power-25",
            "power-26",
            "power-27",
            "power-28",
            "power-29",
            "power-30"});
            this.cmb_powerSelection.Location = new System.Drawing.Point(12, 114);
            this.cmb_powerSelection.Name = "cmb_powerSelection";
            this.cmb_powerSelection.Size = new System.Drawing.Size(182, 21);
            this.cmb_powerSelection.TabIndex = 14;
            // 
            // lbl_keyw
            // 
            this.lbl_keyw.AutoSize = true;
            this.lbl_keyw.Location = new System.Drawing.Point(200, 194);
            this.lbl_keyw.Name = "lbl_keyw";
            this.lbl_keyw.Size = new System.Drawing.Size(53, 13);
            this.lbl_keyw.TabIndex = 15;
            this.lbl_keyw.Text = "Keywords";
            // 
            // lbl_actionType
            // 
            this.lbl_actionType.AccessibleName = "";
            this.lbl_actionType.AutoSize = true;
            this.lbl_actionType.Location = new System.Drawing.Point(199, 65);
            this.lbl_actionType.Name = "lbl_actionType";
            this.lbl_actionType.Size = new System.Drawing.Size(64, 13);
            this.lbl_actionType.TabIndex = 19;
            this.lbl_actionType.Text = "Action Type";
            // 
            // cmb_actionType
            // 
            this.cmb_actionType.AccessibleName = "action=";
            this.cmb_actionType.FormattingEnabled = true;
            this.cmb_actionType.Items.AddRange(new object[] {
            "Standard",
            "Minor",
            "Free",
            "Immediate",
            "Move",
            "Opportunity"});
            this.cmb_actionType.Location = new System.Drawing.Point(12, 65);
            this.cmb_actionType.Name = "cmb_actionType";
            this.cmb_actionType.Size = new System.Drawing.Size(181, 21);
            this.cmb_actionType.TabIndex = 18;
            // 
            // btn_genMacro
            // 
            this.btn_genMacro.BackColor = System.Drawing.Color.LightGreen;
            this.btn_genMacro.Location = new System.Drawing.Point(416, 611);
            this.btn_genMacro.Name = "btn_genMacro";
            this.btn_genMacro.Size = new System.Drawing.Size(138, 23);
            this.btn_genMacro.TabIndex = 20;
            this.btn_genMacro.Text = "Generate Macro";
            this.btn_genMacro.UseVisualStyleBackColor = false;
            this.btn_genMacro.Click += new System.EventHandler(this.btn_genMacro_Click);
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_help.Location = new System.Drawing.Point(13, 611);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(75, 23);
            this.btn_help.TabIndex = 21;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = false;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // txt_generatedMacro
            // 
            this.txt_generatedMacro.Location = new System.Drawing.Point(18, 456);
            this.txt_generatedMacro.Multiline = true;
            this.txt_generatedMacro.Name = "txt_generatedMacro";
            this.txt_generatedMacro.Size = new System.Drawing.Size(536, 149);
            this.txt_generatedMacro.TabIndex = 22;
            // 
            // lst_keywords
            // 
            this.lst_keywords.AccessibleName = "keywords=";
            this.lst_keywords.FormattingEnabled = true;
            this.lst_keywords.Items.AddRange(new object[] {
            "Acid",
            "Arcane",
            "Augmentable",
            "Aura",
            "Beast",
            "Beast form",
            "Channel divinity",
            "Cold",
            "Conjuration",
            "Divine",
            "Elemental",
            "Evocation",
            "Fear",
            "Fire",
            "Force",
            "Healing",
            "Immunity",
            "Implement",
            "Invigorating",
            "Lightning",
            "Martial",
            "Necromancy",
            "Nethermancy",
            "Poison",
            "Primal",
            "Psionic",
            "Psychic",
            "Radiant",
            "Rage",
            "Rattling",
            "Reliable",
            "Runic",
            "Shadow",
            "Sleep",
            "Spirit",
            "Stance",
            "Summoning",
            "Thunder",
            "Weapon",
            "Zone"});
            this.lst_keywords.Location = new System.Drawing.Point(13, 194);
            this.lst_keywords.Name = "lst_keywords";
            this.lst_keywords.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_keywords.Size = new System.Drawing.Size(181, 121);
            this.lst_keywords.TabIndex = 23;
            // 
            // lbl_special
            // 
            this.lbl_special.AutoSize = true;
            this.lbl_special.Location = new System.Drawing.Point(559, 65);
            this.lbl_special.Name = "lbl_special";
            this.lbl_special.Size = new System.Drawing.Size(42, 13);
            this.lbl_special.TabIndex = 25;
            this.lbl_special.Text = "Special";
            // 
            // txt_special
            // 
            this.txt_special.AccessibleName = "special=";
            this.txt_special.Location = new System.Drawing.Point(372, 62);
            this.txt_special.Multiline = true;
            this.txt_special.Name = "txt_special";
            this.txt_special.Size = new System.Drawing.Size(181, 44);
            this.txt_special.TabIndex = 24;
            // 
            // lbl_miss
            // 
            this.lbl_miss.AutoSize = true;
            this.lbl_miss.Location = new System.Drawing.Point(560, 115);
            this.lbl_miss.Name = "lbl_miss";
            this.lbl_miss.Size = new System.Drawing.Size(28, 13);
            this.lbl_miss.TabIndex = 27;
            this.lbl_miss.Text = "Miss";
            // 
            // txt_miss
            // 
            this.txt_miss.AccessibleName = "miss=";
            this.txt_miss.Location = new System.Drawing.Point(373, 112);
            this.txt_miss.Multiline = true;
            this.txt_miss.Name = "txt_miss";
            this.txt_miss.Size = new System.Drawing.Size(181, 44);
            this.txt_miss.TabIndex = 26;
            // 
            // lbl_effect
            // 
            this.lbl_effect.AutoSize = true;
            this.lbl_effect.Location = new System.Drawing.Point(560, 165);
            this.lbl_effect.Name = "lbl_effect";
            this.lbl_effect.Size = new System.Drawing.Size(35, 13);
            this.lbl_effect.TabIndex = 29;
            this.lbl_effect.Text = "Effect";
            // 
            // txt_effect
            // 
            this.txt_effect.AccessibleName = "effect=";
            this.txt_effect.Location = new System.Drawing.Point(373, 162);
            this.txt_effect.Multiline = true;
            this.txt_effect.Name = "txt_effect";
            this.txt_effect.Size = new System.Drawing.Size(181, 44);
            this.txt_effect.TabIndex = 28;
            // 
            // lbl_powerType
            // 
            this.lbl_powerType.AutoSize = true;
            this.lbl_powerType.Location = new System.Drawing.Point(198, 38);
            this.lbl_powerType.Name = "lbl_powerType";
            this.lbl_powerType.Size = new System.Drawing.Size(64, 13);
            this.lbl_powerType.TabIndex = 31;
            this.lbl_powerType.Text = "Power Type";
            // 
            // cmb_powerType
            // 
            this.cmb_powerType.FormattingEnabled = true;
            this.cmb_powerType.Items.AddRange(new object[] {
            "atwill=1",
            "encounter=1",
            "daily=1",
            "item=1",
            "other=1",
            "ability=1",
            "skill=1",
            "monster=1"});
            this.cmb_powerType.Location = new System.Drawing.Point(12, 38);
            this.cmb_powerType.Name = "cmb_powerType";
            this.cmb_powerType.Size = new System.Drawing.Size(181, 21);
            this.cmb_powerType.TabIndex = 30;
            // 
            // lbl_emote
            // 
            this.lbl_emote.AutoSize = true;
            this.lbl_emote.Location = new System.Drawing.Point(559, 215);
            this.lbl_emote.Name = "lbl_emote";
            this.lbl_emote.Size = new System.Drawing.Size(37, 13);
            this.lbl_emote.TabIndex = 33;
            this.lbl_emote.Text = "Emote";
            // 
            // txt_emote
            // 
            this.txt_emote.AccessibleName = "emote=";
            this.txt_emote.Location = new System.Drawing.Point(373, 212);
            this.txt_emote.Multiline = true;
            this.txt_emote.Name = "txt_emote";
            this.txt_emote.Size = new System.Drawing.Size(181, 44);
            this.txt_emote.TabIndex = 32;
            // 
            // lbl_custom
            // 
            this.lbl_custom.AutoSize = true;
            this.lbl_custom.Location = new System.Drawing.Point(200, 324);
            this.lbl_custom.Name = "lbl_custom";
            this.lbl_custom.Size = new System.Drawing.Size(42, 13);
            this.lbl_custom.TabIndex = 35;
            this.lbl_custom.Text = "Custom";
            // 
            // txt_custom
            // 
            this.txt_custom.Location = new System.Drawing.Point(13, 321);
            this.txt_custom.Multiline = true;
            this.txt_custom.Name = "txt_custom";
            this.txt_custom.Size = new System.Drawing.Size(181, 107);
            this.txt_custom.TabIndex = 34;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.LightCoral;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(105, 611);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 36;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // cmb_classList
            // 
            this.cmb_classList.FormattingEnabled = true;
            this.cmb_classList.Items.AddRange(new object[] {
            "Ardent",
            "Artificer",
            "Assassin",
            "Avenger",
            "Barbarian",
            "Bard",
            "Battlemind",
            "Cleric",
            "Druid",
            "Fighter",
            "Invoker",
            "Monk",
            "Paladin",
            "Psion",
            "Ranger",
            "Rogue",
            "Runepriest",
            "Shaman",
            "Seeker",
            "Sorcerer",
            "Swordmage",
            "Warden",
            "Warlock",
            "Warlord",
            "Wizard",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.cmb_classList.Location = new System.Drawing.Point(12, 167);
            this.cmb_classList.Name = "cmb_classList";
            this.cmb_classList.Size = new System.Drawing.Size(181, 21);
            this.cmb_classList.TabIndex = 16;
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Location = new System.Drawing.Point(199, 165);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(32, 13);
            this.lbl_class.TabIndex = 17;
            this.lbl_class.Text = "Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Requirement";
            // 
            // txt_requirement
            // 
            this.txt_requirement.AccessibleName = "requirement=";
            this.txt_requirement.Location = new System.Drawing.Point(373, 262);
            this.txt_requirement.Multiline = true;
            this.txt_requirement.Name = "txt_requirement";
            this.txt_requirement.Size = new System.Drawing.Size(181, 44);
            this.txt_requirement.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Trigger";
            // 
            // txt_trigger
            // 
            this.txt_trigger.AccessibleName = "trigger=";
            this.txt_trigger.Location = new System.Drawing.Point(373, 312);
            this.txt_trigger.Multiline = true;
            this.txt_trigger.Name = "txt_trigger";
            this.txt_trigger.Size = new System.Drawing.Size(181, 44);
            this.txt_trigger.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Combat Type";
            // 
            // lst_combatType
            // 
            this.lst_combatType.AccessibleName = "keywords=";
            this.lst_combatType.FormattingEnabled = true;
            this.lst_combatType.Items.AddRange(new object[] {
            "Attack",
            "Damage"});
            this.lst_combatType.Location = new System.Drawing.Point(372, 362);
            this.lst_combatType.Name = "lst_combatType";
            this.lst_combatType.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_combatType.Size = new System.Drawing.Size(181, 30);
            this.lst_combatType.TabIndex = 44;
            // 
            // btn_copy
            // 
            this.btn_copy.BackColor = System.Drawing.Color.LightBlue;
            this.btn_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy.Location = new System.Drawing.Point(335, 611);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_copy.TabIndex = 45;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = false;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 643);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.lst_combatType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_trigger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_requirement);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_custom);
            this.Controls.Add(this.txt_custom);
            this.Controls.Add(this.lbl_emote);
            this.Controls.Add(this.txt_emote);
            this.Controls.Add(this.lbl_powerType);
            this.Controls.Add(this.cmb_powerType);
            this.Controls.Add(this.lbl_effect);
            this.Controls.Add(this.txt_effect);
            this.Controls.Add(this.lbl_miss);
            this.Controls.Add(this.txt_miss);
            this.Controls.Add(this.lbl_special);
            this.Controls.Add(this.txt_special);
            this.Controls.Add(this.lst_keywords);
            this.Controls.Add(this.txt_generatedMacro);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_genMacro);
            this.Controls.Add(this.lbl_actionType);
            this.Controls.Add(this.cmb_actionType);
            this.Controls.Add(this.lbl_class);
            this.Controls.Add(this.cmb_classList);
            this.Controls.Add(this.lbl_keyw);
            this.Controls.Add(this.cmb_powerSelection);
            this.Controls.Add(this.lbl_onHit);
            this.Controls.Add(this.txt_onHit);
            this.Controls.Add(this.lbl_target);
            this.Controls.Add(this.txt_target);
            this.Controls.Add(this.lbl_powerSelect);
            this.Controls.Add(this.lbl_range);
            this.Controls.Add(this.txt_range);
            this.Controls.Add(this.lbl_keywords);
            this.Controls.Add(this.lbl_powerName);
            this.Controls.Add(this.txt_powerName);
            this.Name = "Form1";
            this.Text = "Roll20 Macro Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_powerName;
        private System.Windows.Forms.Label lbl_powerName;
        private System.Windows.Forms.Label lbl_keywords;
        private System.Windows.Forms.Label lbl_range;
        private System.Windows.Forms.TextBox txt_range;
        private System.Windows.Forms.Label lbl_powerSelect;
        private System.Windows.Forms.Label lbl_target;
        private System.Windows.Forms.TextBox txt_target;
        private System.Windows.Forms.Label lbl_onHit;
        private System.Windows.Forms.TextBox txt_onHit;
        private System.Windows.Forms.ComboBox cmb_powerSelection;
        private System.Windows.Forms.Label lbl_keyw;
        private System.Windows.Forms.Label lbl_actionType;
        private System.Windows.Forms.ComboBox cmb_actionType;
        private System.Windows.Forms.Button btn_genMacro;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.TextBox txt_generatedMacro;
        private System.Windows.Forms.ListBox lst_keywords;
        private System.Windows.Forms.Label lbl_special;
        private System.Windows.Forms.TextBox txt_special;
        private System.Windows.Forms.Label lbl_miss;
        private System.Windows.Forms.TextBox txt_miss;
        private System.Windows.Forms.Label lbl_effect;
        private System.Windows.Forms.TextBox txt_effect;
        private System.Windows.Forms.Label lbl_powerType;
        private System.Windows.Forms.ComboBox cmb_powerType;
        private System.Windows.Forms.Label lbl_emote;
        private System.Windows.Forms.TextBox txt_emote;
        private System.Windows.Forms.Label lbl_custom;
        private System.Windows.Forms.TextBox txt_custom;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cmb_classList;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_requirement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_trigger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lst_combatType;
        private System.Windows.Forms.Button btn_copy;
    }
}

