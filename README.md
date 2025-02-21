# FE Engage Bond Ring XML Generator

**About:**
This program provides a simple-to-use UI for generating the XML data of Fire Emblem Engage's bond rings which can then be copy and pasted straight into a ring.xml file.

**How to use:**
Upon opening the program, you'll be met with this interface
![image](https://github.com/user-attachments/assets/37c550c4-62c2-49de-9d30-668853346777)

**Left Column - Most fields here are self explanatory but to highlight a few:**
- "Custom GID" becomes enabled when selecting "Custom" as the emblem, this allows you to input the GID for the custom emblem. You can write the GID with or without the "GID_" prefix, the program will handle it.
- "Skill ID" allows to input any skill ID you want, once again the "SID_" prefix is optional.
- "Is Single Rank" allows you to make S Rank only rings, similar to the Alfonse, Sharena and Anna rings. This will lock fields relating to C, B and A rank rings
- "Use FEH rings model?" refers to the custom ring model the Alfonse, Sharena and Anna rings have. It is highly recommended to enable this for the DLC emblems and custom emblems but will not break anything if you choose not to.

**Middle Column - Assigning Stats:**
- Each rank of bond ring can have unique stat boosts, the fields here allow for any integer between 0-99 inclusive.
- In Engage, C rank rings will boost one primary stat by 1 point (2 for HP)
- B rank Rings will boost a secondary stat by 1 point
- A rank rings will boost a tertiary stat by 1 point
- S rank rings will add an extra point to the primary stat (or boost to +5 for HP)
- No base game bond ring boosts MOV or BLD, so there is no standard for that.
- Reset will set all stat fields back to 0

**Right Column - Colours:**
- The Jewel Colour and Rim Colour can both be set using their respective RGB fields, accepting values from 0-255 inclusive.
- A colour picker can be used by clicking "Select Jewel/Rim Colour".
- The colour display updates in real time. Whether a value is manually typed and confirmed, the ticker is incremented or a colour is selected from the colour picker.
- No base game bond ring actually uses a rim colour (they're all 0,0,0)

**Bottom Section - Output:**
- Click "Generate" to see the output. You can look at it and make alterations by editing the other fields and re-generating the output.
- If satisfied, click "Copy Text" to copy it to your clipboard, from there it's as easy as pasting it into the XML file (or anywhere else you want to put it)
- You can manually highlight the text and use CTRL+C to copy

You can now save the suffering of constant small copy pastes and edits and just have it all done in one!
