# Roll20MacroBuilder
Roll20 Macro Builder helps players streamline the creation of power card template macros. A roll20.net account is required and prior to creating a template macro with this tool you'll need a few pieces of information. By streamlining the combat process you can speed up Roll20 game sessions and not get hung up on dice rolling and looking up abilities.

![Preview](https://imgur.com/c5LQXZv.jpg)

The compiled version is included as a .Zip above:"Roll20 Macro Builder v3.zip"

•	Roll20.net account (free at http://www.roll20.net).

•	A D&D4e character sheet inside a previously created game.

•	Power abilities on the character sheet. These are listed as power-1, power-2, power-3. Roll20 supports up to 100 powers.

Once you have your powers setup you can open the macro builder tool and start creating your template macros. These macros will live in the abilities -> Macros section of the d&d4e character sheet. You can either add them to the macro bar or token bar.

Breaking down the fields in the macro builder:
Power Name: The name that will be shown for your power, use the players handbook or similar reference to get all the details about the power card you’re building.
Power Type:  This is dictated by the power card, whether it’s at-will, encounter, daily, it will be listed in the D&D4e reference.
Action Type: The type of action that Is used on your turn, standard, free, minor, and so on.
Range: This is listed in the D&D4e reference, it will be shown on the card as Range <the value you input>. I would type it in exactly as shown on the referenced material. 
Example: Magic Missle has: Ranged 20
Power Selection:  As mentioned before this value needs to correspond to the power you setup in roll20 or the macro will not work correctly. Roll20 lists their powers as power-1, power-2, power-3….
Target: Dictated by the referenced D&D4e material, valid values could be: Melee, Melee touch, Close burst 5, Range 20, use whatever is listed on your power card.
Class:  The class field is asking for what class the skill falls under. Some skills like Grab, or Bull Rush don’t fall into a class category. Select an empty value at the bottom of the list if this is your case.
Keywords: If the power you’re building has keywords they’ll be listed at the top, this is important in calculating defenses, extra damage, and other conditions.

The Following fields are used to descript special conditions when something happens. It’s important to note that you can include ability scores, ability score modifiers in these boxes using the following format:
[[@{ability}]] or [[@{ability-mod}]]
By creating your macro this way, it will adjust as your character sheet changes.
Example: Stolen Life – Paladin power
On hit: You or an ally within 5 squares of you regains a number of hit points equal to your Charisma modifier [[@{charisma-mod}]]

Hit: If your power requires the On-Hit text this is where it will be entered.
Special: If your power requires the special text this is where it will be entered.
Miss: If your power requires the miss text this is where it will be entered.
Effect: If your power requires the effect text this is where it will be entered.
Requirement: If your power has a requirement, this is where it will be entered.
Trigger: If your power has a trigger, this is where it will be entered.
Emote:  If you want to add some flavor to your power cards use the emote field, this will display some flavor text above each power card before it’s used.
“Jheri swings his Greatsword in a violent circular motion!”

The checkbox: “Is this a combat power?”
This will include damage, attack, and critical rolls for your selected power. If you’re creating a non-damage / combat ability, just leave this unchecked.

Custom: I’ve tried to create the most commonly used fields for new players to get started quickly. However, there are so many more that I haven’t touched upon but I’ve provided a custom field for advanced users to add these. To add any field just use the following format:
{{tagname=VALUE}}

To add multiple custom fields just add a space and continue the format as shown:
{{tagname1=VALUE}} {{tagname2=VALUE}} {{tagname3=VALUE}}

Once all the fields are filled out, hit Generate Macro. This will populate the bottom section of the tool, copy and paste this into a new ability macro in your character sheet.

Cheers,

Diaonic

![Preview](https://imgur.com/4Ha4eeB.jpg)
![Preview](https://imgur.com/IPHXl40.jpg)

Complete list of all tags

{{emote=}}	{{multiattack6=}}	{{secondaryattack=}}	{{augment1damage=}}	{{augment4multiattack3=}}	{{augment6critical=}}
{{name=}}	{{multiattack7=}}	{{secondarydamage=}}	{{augment1critical=}}	{{augment4multiattack4=}}	{{augment6hiteffect=}}
{{class=}}	{{multiattack8=}}	{{secondarycritical=}}	{{augment1hiteffect=}}	{{augment4multiattack5=}}	{{classmodifier=}}
{{level=}}	{{multiattack9=}}	{{secondaryhiteffect=}}	{{augment2range=}}	{{augment4multiattack6=}}	{{miss=}}
{{type=}}	{{multiattack10=}}	{{tertiaryrange=}}	{{augment2target=}}	{{augment4multiattack7=}}	{{effect=}}
{{keywords=}}	{{multiattack11=}}	{{tertiarytarget=}}	{{augment2attack=}}	{{augment4multiattack8=}}	{{firstfailedsave=}}
{{attacktechnique=}}	{{multiattack12=}}	{{tertiaryattack=}}	{{augment2multitoggle=}}	{{augment4multiattack9=}}	{{secondfailedsave=}}
{{action=}}	{{multiattack13=}}	{{tertiarydamage=}}	{{augment2multiattack2=}}	{{augment4damage=}}	{{eachfailedsave=}}
{{range=}}	{{multiattack14=}}	{{tertiarycritical=}}	{{augment2multiattack3=}}	{{augment4critical=}}	{{aftereffect=}}
{{requirement=}}	{{multiattack15=}}	{{tertiaryhiteffect=}}	{{augment2multiattack4=}}	{{augment4hiteffect=}}	{{sustainminor=}}
{{trigger=}}	{{multiattack16=}}	{{augmenttoggle=}}	{{augment2multiattack5=}}	{{augment6range=}}	{{sustainstandard=}}
{{beforespecial=}}	{{multiattack17=}}	{{augment1range=}}	{{augment2multiattack6=}}	{{augment6target=}}	{{movetechnique=}}
{{beforeeffect=}}	{{multiattack18=}}	{{augment1target=}}	{{augment2multiattack7=}}	{{augment6attack=}}	{{mttype=}}
{{target=}}	{{multiattack19=}}	{{augment1attack=}}	{{augment2multiattack8=}}	{{augment6multitoggle=}}	{{mtrange=}}
{{primarytarget=}}	{{multiattack20=}}	{{augment1multitoggle=}}	{{augment2multiattack9=}}	{{augment6multiattack2=}}	{{mttarget=}}
{{attackweaponmod=}}	{{damage=}}	{{augment1multiattack2=}}	{{augment2damage=}}	{{augment6multiattack3=}}	{{mteffect=}}
{{attack=}}	{{critical=}}	{{augment1multiattack3=}}	{{augment2critical=}}	{{augment6multiattack4=}}	{{special=}}
{{multiattacktoggle=}}	{{hitweaponmod=}}	{{augment1multiattack4=}}	{{augment2hiteffect=}}	{{augment6multiattack5=}}	{{“anytextname”=}}
{{multiattack2=}}	{{hiteffect=}}	{{augment1multiattack5=}}	{{augment4range=}}	{{augment6multiattack6=}}	{{“anytextname”=}}
{{multiattack3=}}	{{hitaftereffect=}}	{{augment1multiattack6=}}	{{augment4target=}}	{{augment6multiattack7=}}	{{“etc…”=}}
{{multiattack4=}}	{{effectweaponmod=}}	{{augment1multiattack7=}}	{{augment4attack=}}	{{augment6multiattack8=}}	
{{multiattack5=}}	{{secondaryrange=}}	{{augment1multiattack8=}}	{{augment4multitoggle=}}	{{augment6multiattack9=}}	
{{multiattack6=}}	{{secondarytarget=}}	{{augment1multiattack9=}}	{{augment4multiattack2=}}	{{augment6damage=}}	




