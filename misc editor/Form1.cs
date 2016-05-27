using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;



namespace A_Gen_Misc_Edits
{
    public partial class HexHelper : Form
    {
        public HexHelper()
        {
            InitializeComponent();
        }

        LSAPokeHelper PokeHelper = new LSAPokeHelper();
        string fileLocation;
        bool FireRed = false;
        bool MrDS = false;
        bool LeafGreen = false;
        bool Emerald = false;
        bool Sapphire = false;
        bool Ruby = false;
        bool other = false;
        //RemoveFlashBack
        byte[] newFlash = { 0x00, 0x1C, 0x0F, 0xE0 }; //bytes to remove feature
        byte[] oldFlash = { 0x00, 0x28, 0x0F, 0xD0 }; //bytes to add feature
        long FireRedFlash = 0x110F54; //FR offset in ROM
        long LeafGreenFlash = 0x110F2C; //LG off set in ROM
        //Indoor Running
        byte[] newRun = { 0x00 }; //bytes to remove feature
        byte[] oldRun = { 0x08 }; //bytes to add feature
        long FireRedRun = 0xBD494; //FR offset in ROM
        long LeafGreenRun = 0xBD468; //LG off set in ROM
        long EmeraldRun = 0x11A1E8; //EM offset in ROM
        long SapphireRun = 0xE5E00; //SA off set in ROM
        long RubyRun = 0xE5E00; //RB offset in ROM
        //Repel
        byte[] newRepel1 = { 0x0C, 0x48, 0xEB, 0xF7, 0x4C, 0xFA, 0x01, 0x06, 0x00, 0x29, 0x16, 0xD0, 0x41, 0x1E, 0x0C, 0x06, 0x0D, 0x0A, 0x07, 0x48, 0xEB, 0xF7, 0x51, 0xFA, 0x00, 0x2C, 0x0E, 0xD1, 0x03, 0x4C, 0x25, 0x80, 0x05, 0x48, 0xE6, 0xF7, 0xFA, 0xFC, 0x01, 0x20, 0x08, 0xE0, 0x30, 0xAD, 0x03, 0x02 };
        byte[] newRepel2 = { 0x06 };
        byte[] newRepel3 = { 0x1c };
        byte[] newRepel4 = { 0x11 };
        byte[] newRepel5 = { 0x0f };
        byte[] newRepel6 = { 0x21, 0x88, 0x09, 0x02, 0x41, 0x40 };
        byte[] newRepel7 = { 0x34, 0x4B, 0x28, 0x21, 0x71, 0x43, 0x5B, 0x18, 0xD9, 0x79, 0x30, 0x1C, 0x02, 0x22, 0x17, 0x4B, 0xFF, 0xF7, 0x49, 0xfB, 0xC7, 0xF7, 0x85, 0xFF, 0x70, 0xBD, 0x20, 0x40, 0x00, 0x00, 0xFF, 0xFf, 0x00, 0x00, 0x30, 0xAD, 0x03, 0x02 };
        byte[] newRepel8 = { 0x00, 0x00, 0x00, 0x00 };
        byte[] newRepel9 = { 0x00, 0x00, 0x00, 0xB5, 0x04, 0x48, 0x50, 0x21, 0x00, 0xF0, 0x01, 0xF8, 0x00, 0xBD, 0x00, 0x4A, 0x10, 0x47, 0x1D, 0x74, 0x07, 0x08, 0x99, 0x19, 0x0A, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
        byte[] RepelSN = { 0x6A, 0x47, 0x0E, 0x80, 0x01, 0x00, 0x21, 0x0D, 0x80, 0x01, 0x00, 0x06, 0x04, 0x1C, 0x00, 0x80, 0x08, 0x0F, 0x00, 0x39, 0x00, 0x80, 0x08, 0x09, 0x03, 0x6C, 0x02, 0xFF, 0x0F, 0x00, 0x54, 0x00, 0x80, 0x08, 0x09, 0x05, 0x68, 0x21, 0x0D, 0x80, 0x01, 0x00, 0x06, 0x01, 0x32, 0x00, 0x80, 0x08, 0x02, 0xFF, 0x23, 0x69, 0xFB, 0x1B, 0x08, 0x02, 0xFF, 0xCC, 0xD9, 0xE4, 0xD9, 0xE0, 0xB4, 0xE7, 0x00, 0xD9, 0xDA, 0xDA, 0xD9, 0xD7, 0xE8, 0x00, 0xEB, 0xE3, 0xE6, 0xD9, 0x00, 0xE3, 0xDA, 0xDA, 0xAD, 0xFF, 0x00, 0xFF, 0xCC, 0xD9, 0xE4, 0xD9, 0xE0, 0xB4, 0xE7, 0x00, 0xD9, 0xDA, 0xDA, 0xD9, 0xD7, 0xE8, 0x00, 0xEB, 0xE3, 0xE6, 0xD9, 0x00, 0xE3, 0xDA, 0xDA, 0xAD, 0xAD, 0xAD, 0xFE, 0xCF, 0xE7, 0xD9, 0x00, 0xD5, 0xE2, 0xE3, 0xE8, 0xDC, 0xD9, 0xE6, 0xAC, 0xFF, 0x00, 0xFF};
        long Repel1 = 0x830CA;
        long Repel2 = 0x83119;
        long Repel2_1 = 0xA19A5;
        long Repel3 = 0xA19F6;
        long Repel4 = 0xA19F8;
        long Repel5 = 0xA19FC;
        long Repel6 = 0xA1A0E;
        long Repel7 = 0xA1A1E;
        long Repel8 = 0xA1A5A;
        long Repel8_1 = 0xA1A68;
        long Repel9 = 0x1BFB66;
        //long 
        //RepelS 
        //= 0x456640;
        long RepelF = 0x83100;
        long RepelF2 = 0x83103;
        byte[] RepelOff = { 0x08 };
        byte[] RepelFN = { 0x40, 0x66, 0x45, 0x08 }; //0x456640
        //Fixing Tall Grass
        byte[] newGrass = { 0x00, 0x21, 0x00, 0x06, 0x00, 0x0e, 0x02, 0x28, 0x01, 0xd0, 0xd1, 0x28, 0x01, 0xd1, 0x01, 0x20, 0x00, 0xe0, 0x00, 0x20, 0x00, 0x21, 0x70, 0x47, 0x03, 0x28, 0xf5, 0xe7 };
        byte[] newGrass2 = { 0x0C, 0x30, 0x09, 0xE0 };
        long Grass = 0x59f34;
        long Grass2 = 0x5A0EC;
        //Level 1 eggs
        byte[] newEgg1 = { 0x01, 0x21 };
        byte[] newEgg2 = { 0x01, 0x22 };
        byte[] newEgg3 = { 0x01, 0x22 };
        long Egg1 = 0x1C3200;
        long Egg2 = 0x71414;
        long Egg3 = 0x70A38;
        long Egg1f = 0x1375B0;
        long Egg2f = 0x46CBE;
        long Egg3f = 0x4623E;
        //Pokedex Fix
        long FireRedDex = 0x10583C;
        long FireRedDex2 = 0x105856;
        long LeafGreenDex2 = 0x10582E;
        long LeafGreenDex = 0x105814;
        byte[] newDex = { 0xff };
        //Mew fix
        long FireRedMew = 0x1D402;
        byte[] newMew = { 0x00 };
        //Berry fix
        long EmeraldBerry = 0x68FD2;
        byte[] newBerry = { 0x02, 0x29, 0x04, 0xDC };
        //IV fix
        long RSIV = 0x3D89A;
        long FRLGIV = 0x40A92;
        byte[] newIV = { 0x21, 0x68, 0x69, 0x60, 0x20, 0xE0 };
        long NDEvo = 0xCE91A;
        byte[] NDEvoBytes = { 0x00, 0x00, 0x14, 0xE0 };
        long EMHM = 0x1b6d14;
        long EMHM2 = 0x6E7CC;
        long FRHM = 0x441D6;
        long FRHM2 = 0x125AA8;
        byte[] HM = { 0x00 };

        private void Open_Click(object sender, EventArgs e) //Open ROM button
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "GBA File (*.gba)|*.gba";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                BinaryReader br = new BinaryReader(File.OpenRead(ofd.FileName));
                br.BaseStream.Seek(0xAC, SeekOrigin.Begin);
                switch (Encoding.UTF8.GetString(br.ReadBytes(4)))
                {
                    case "MrDS":
                        FireRed = false;
                        MrDS = true;
                        LeafGreen = false;
                        other = false;
                        Emerald = false;
                        Ruby = false;
                        other = false;
                        break;
                    case "BPRE":
                        FireRed = true;
                        LeafGreen = false;
                        other = false;
                        Emerald = false;
                        Ruby = false;
                        other = false;
                        break;
                    case "BPGE":
                        FireRed = false;
                        LeafGreen = true;
                        other = false;
                        Emerald = false;
                        Ruby = false;
                        other = false;
                        break;
                    case "BPEE":
                        FireRed = false;
                        LeafGreen = false;
                        Emerald = true;
                        Ruby = false;
                        other = false;
                        break;
                    case "AXVE":
                        FireRed = false;
                        LeafGreen = false;
                        Emerald = false;
                        Ruby = true;
                        other = false;
                        break;
                    case "AXPE":
                        FireRed = false;
                        LeafGreen = false;
                        Ruby = true;
                        Sapphire = false;
                        Emerald = false;
                        other = false;
                        break;
                    default:
                        FireRed = false;
                        LeafGreen = false;
                        Ruby = false;
                        Sapphire = false;
                        Emerald = false;
                        other = true;
                        break;
                }
                tabControl1.Enabled = true;
                tabPage3.Enabled = false;
                if (other == true)
                {
                    DialogResult result = MessageBox.Show("This game cannot be identified. If this is a ROM with a custom ID but with the normal english offsets then procede with caution. If it is not, it may cause irreversible damage. Do you wish to continue?", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        other = false;
                    }
                }
                if (MrDS == true)
                {
                    label2.Text = "Fire Red MrDS";
                    fileLocation = ofd.FileName;
                    tabPage3.Enabled = true;
                }
                if (FireRed == true)
                {
                    label2.Text = "Fire Red BPRE";
                    fileLocation = ofd.FileName;
                    tabPage3.Enabled = true;
                }
                if (LeafGreen == true)
                {
                    label2.Text = "Leaf Green BPGE";
                    fileLocation = ofd.FileName;
                    tabPage3.Enabled = true;
                }
                if (other == true)
                {
                    label2.Text = "Unidentified game";
                    fileLocation = ofd.FileName;
                }
                if (Emerald == true)
                {
                    label2.Text = "Emerald BPEE";
                    fileLocation = ofd.FileName;
                }
                if (Ruby == true)
                {
                    label2.Text = "Ruby AXVE";
                    fileLocation = ofd.FileName;
                }
                if (Sapphire == true)
                {
                    label2.Text = "sapphire AXPE";
                    fileLocation = ofd.FileName;
                }
                TextSpeed.SelectedIndex = 1;
                Frame.SelectedIndex = 0;
                Sound.SelectedIndex = 1;
                BattleScene.SelectedIndex = 0;
                BattleStyle.SelectedIndex = 0;
                BTNMode.SelectedIndex = 0;
                br.Close();
            }
        }

        private void Flash_Click_1(object sender, EventArgs e) //Apply button
        {
            if (fileLocation == null)
            {
                MessageBox.Show("Please load a game.", "Error");
                return;
            }
            if (FireRed == true)
            {
                try
                {
                    MessageBox.Show("Burning diaries....");
                    WriteData(newFlash, FireRedFlash); ;  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (MrDS == true)
            {
                try
                {
                    MessageBox.Show("Burning diaries....");
                    WriteData(newFlash, FireRedFlash); ;  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (LeafGreen == true)
            {
                try
                {
                    MessageBox.Show("Burning diaries....");
                    WriteData(newFlash, LeafGreenFlash); ; ;  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (other == true)
            {
                DialogResult result = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Fire Red-based, No if it is Leaf Green-based, or Cancel if you wish to not continue.", "Notice", MessageBoxButtons.YesNoCancel);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show("Burning diaries....");
                        WriteData(newFlash, FireRedFlash); ;  //stuff here for file writing
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
                if (result == DialogResult.No)
                {
                    try
                    {
                        MessageBox.Show("Burning diaries....");
                        WriteData(newFlash, LeafGreenFlash); ; ;  //stuff here for file writing
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
            }
        }

        private void Running_Click_1(object sender, EventArgs e) //Running button
        { }

        private void WriteData(byte[] BytesToWrite, long Offset)
        {
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(fileLocation));
            bw.BaseStream.Seek(Offset, SeekOrigin.Begin);
            bw.Write(BytesToWrite);
            bw.Close();
        }

        private void WriteByte(byte[] ByteToWrite, long Offset)
        {
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(fileLocation));
            bw.BaseStream.Seek(Offset, SeekOrigin.Begin);
            bw.Write(ByteToWrite);
            bw.Close();
        }


        private void Running_Click_2(object sender, EventArgs e)
        {
            if (fileLocation == null)
            {
                MessageBox.Show("Please load a game.", "Error");
                return;
            }
            if (FireRed == true)
            {
                try
                {
                    MessageBox.Show("Indoor walking now running....");
                    WriteData(newRun, FireRedRun);  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (MrDS == true)
            {
                try
                {
                    MessageBox.Show("Indoor walking now running....");
                    WriteData(newRun, FireRedRun);  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (LeafGreen == true)
            {
                try
                {
                    MessageBox.Show("Indoor walking now running....");
                    WriteData(newRun, LeafGreenRun); ;  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (Ruby == true)
            {
                try
                {
                    MessageBox.Show("Indoor walking now running....");
                    WriteData(newRun, RubyRun);  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (Emerald == true)
            {
                try
                {
                    MessageBox.Show("Indoor walking now running....");
                    WriteData(newRun, EmeraldRun);  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (Sapphire == true)
            {
                try
                {
                    MessageBox.Show("Indoor walking now running....");
                    WriteData(newRun, SapphireRun);  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (other == true)
            {
                DialogResult result = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Fire Red-based, No if it is Emerald-based, or Cancel if you wish to not continue.", "Notice", MessageBoxButtons.YesNoCancel);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show("Indoor walking now running....");
                        WriteData(newRun, FireRedRun);  //stuff here for file writing
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
                if (result == DialogResult.No)
                {
                    try
                    {
                        MessageBox.Show("Indoor walking now running....");
                        WriteData(newRun, EmeraldRun);  //stuff here for file writing
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This hack is for FireRed v1 only, and uses the freespace for around 0x80 bytes. If you have used this space it will overwrite it and delete your data which could result in corruption or a bad script. Click yes if you understand the risks.", "Notice", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Please enter a location of free space 0x80 bytes in length.Leave out '0x'.", "FreeSpace", "efff00", 0, 0);
                string vIn = input;
                int vOut = Convert.ToInt32(input, 16);
                // Store integer 182
                // Convert integer 182 as a hex in a string variable
                int long1 = vOut;
                long long2 = Convert.ToInt64(long1);
                if (FireRed == true)
                {
                    try
                    {
                        MessageBox.Show("Repelling all enemies.....");
                        WriteData(newRepel1, Repel1);  //stuff here for file writing
                        WriteData(newRepel2, Repel2);
                        WriteData(newRepel2, Repel2_1);
                        WriteData(newRepel3, Repel3);
                        WriteData(newRepel4, Repel4);
                        WriteData(newRepel5, Repel5);
                        WriteData(newRepel6, Repel6);
                        WriteData(newRepel7, Repel7);
                        WriteData(newRepel8, Repel8);
                        WriteData(newRepel8, Repel8_1);
                        WriteData(newRepel9, Repel9);
                        WriteData(RepelSN, long2);
                        int vOut2 = Convert.ToInt32(input, 16);
                        // Store integer 182
                        // Convert integer 182 as a hex in a string variable
                        byte[] Final = BitConverter.GetBytes(vOut2);
                        WriteData(Final, RepelF);
                        WriteData(RepelOff, RepelF2);
                        MessageBox.Show("Imputting Data...");
                        //Get location of next offet
                        int vOut3 = (vOut2 + 0x1c);
                        int vOut4 = (vOut2 + 0x39);
                        int vOut5 = (vOut2 + 0x54);
                        int vOut6 = (vOut2 + 0x32);
                        //get location to insert
                        int local = (vOut2 + 0xd);
                        int local2 = (vOut2 + 0x13);
                        int local3 = (vOut2 + 0x1e);
                        int local4 = (vOut2 + 0x2c);
                        long Location1 = Convert.ToInt64(local);
                        long Location2 = Convert.ToInt64(local2);
                        long Location3 = Convert.ToInt64(local3);
                        long Location4 = Convert.ToInt64(local4);
                        //Convert offsets to byte[]
                        byte[] Byte3 = BitConverter.GetBytes(vOut3);
                        byte[] Byte4 = BitConverter.GetBytes(vOut4);
                        byte[] Byte5 = BitConverter.GetBytes(vOut5);
                        byte[] Byte6 = BitConverter.GetBytes(vOut6);
                        MessageBox.Show("Repointing...");
                        WriteData(Byte3, Location1);
                        WriteData(Byte4, Location2);
                        WriteData(Byte5, Location3);
                        WriteData(Byte6, Location4);
                        int vfix = (local + 3);
                        int vfix2 = (local2 + 3);
                        int vfix3 = (local3 + 3);
                        int vfix4 = (local4 + 3);
                        long LocationF = Convert.ToInt64(vfix);
                        long LocationF2 = Convert.ToInt64(vfix2);
                        long LocationF3 = Convert.ToInt64(vfix3);
                        long LocationF4 = Convert.ToInt64(vfix4);
                        byte[] BFix = { 0x08 };
                        WriteData(BFix, LocationF);
                        WriteData(BFix, LocationF2);
                        WriteData(BFix, LocationF3);
                        WriteData(BFix, LocationF4);
                        MessageBox.Show("Final bug fix...");
                        string S = vOut3.ToString();
                        string S1 = vOut4.ToString();
                        string S2 = vOut5.ToString();
                        string S3 = vOut6.ToString();
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                    if (MrDS == true)
                    {
                        try
                        {
                            MessageBox.Show("Repelling all enemies.....");
                            WriteData(newRepel1, Repel1);  //stuff here for file writing
                            WriteData(newRepel2, Repel2);
                            WriteData(newRepel2, Repel2_1);
                            WriteData(newRepel3, Repel3);
                            WriteData(newRepel4, Repel4);
                            WriteData(newRepel5, Repel5);
                            WriteData(newRepel6, Repel6);
                            WriteData(newRepel7, Repel7);
                            WriteData(newRepel8, Repel8);
                            WriteData(newRepel8, Repel8_1);
                            WriteData(newRepel9, Repel9);
                            WriteData(RepelSN, long2);
                            int vOut2 = Convert.ToInt32(input, 16);
                            // Store integer 182
                            // Convert integer 182 as a hex in a string variable
                            byte[] Final = BitConverter.GetBytes(vOut2);
                            WriteData(Final, RepelF);
                            WriteData(RepelOff, RepelF2);
                            MessageBox.Show("Imputting Data...");
                            //Get location of next offet
                            int vOut3 = (vOut2 + 0x1c);
                            int vOut4 = (vOut2 + 0x39);
                            int vOut5 = (vOut2 + 0x54);
                            int vOut6 = (vOut2 + 0x32);
                            //get location to insert
                            int local = (vOut2 + 0xd);
                            int local2 = (vOut2 + 0x13);
                            int local3 = (vOut2 + 0x1e);
                            int local4 = (vOut2 + 0x2c);
                            long Location1 = Convert.ToInt64(local);
                            long Location2 = Convert.ToInt64(local2);
                            long Location3 = Convert.ToInt64(local3);
                            long Location4 = Convert.ToInt64(local4);
                            //Convert offsets to byte[]
                            byte[] Byte3 = BitConverter.GetBytes(vOut3);
                            byte[] Byte4 = BitConverter.GetBytes(vOut4);
                            byte[] Byte5 = BitConverter.GetBytes(vOut5);
                            byte[] Byte6 = BitConverter.GetBytes(vOut6);
                            MessageBox.Show("Repointing...");
                            WriteData(Byte3, Location1);
                            WriteData(Byte4, Location2);
                            WriteData(Byte5, Location3);
                            WriteData(Byte6, Location4);
                            int vfix = (local + 3);
                            int vfix2 = (local2 + 3);
                            int vfix3 = (local3 + 3);
                            int vfix4 = (local4 + 3);
                            long LocationF = Convert.ToInt64(vfix);
                            long LocationF2 = Convert.ToInt64(vfix2);
                            long LocationF3 = Convert.ToInt64(vfix3);
                            long LocationF4 = Convert.ToInt64(vfix4);
                            byte[] BFix = { 0x08 };
                            WriteData(BFix, LocationF);
                            WriteData(BFix, LocationF2);
                            WriteData(BFix, LocationF3);
                            WriteData(BFix, LocationF4);
                            MessageBox.Show("Final bug fix...");
                            string S = vOut3.ToString();
                            string S1 = vOut4.ToString();
                            string S2 = vOut5.ToString();
                            string S3 = vOut6.ToString();
                            MessageBox.Show("Success!");
                        }
                        catch
                        {
                            MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                        }
                        if (other == true)
                        {
                            DialogResult result1 = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Fire Red-based, or No/Cancel if you wish to not continue.", "Notice", MessageBoxButtons.YesNoCancel);
                            if (result1 == System.Windows.Forms.DialogResult.Yes)
                            {
                                try
                                {
                                    MessageBox.Show("Repelling all enemies.....");
                                    WriteData(newRepel1, Repel1);  //stuff here for file writing
                                    WriteData(newRepel2, Repel2);
                                    WriteData(newRepel2, Repel2_1);
                                    WriteData(newRepel3, Repel3);
                                    WriteData(newRepel4, Repel4);
                                    WriteData(newRepel5, Repel5);
                                    WriteData(newRepel6, Repel6);
                                    WriteData(newRepel7, Repel7);
                                    WriteData(newRepel8, Repel8);
                                    WriteData(newRepel8, Repel8_1);
                                    WriteData(newRepel9, Repel9);
                                    WriteData(RepelSN, long2);
                                    int vOut2 = Convert.ToInt32(input, 16);
                                    // Store integer 182
                                    // Convert integer 182 as a hex in a string variable
                                    byte[] Final = BitConverter.GetBytes(vOut2);
                                    WriteData(Final, RepelF);
                                    WriteData(RepelOff, RepelF2);
                                    MessageBox.Show("Imputting Data...");
                                    //Get location of next offet
                                    int vOut3 = (vOut2 + 0x1c);
                                    int vOut4 = (vOut2 + 0x39);
                                    int vOut5 = (vOut2 + 0x54);
                                    int vOut6 = (vOut2 + 0x32);
                                    //get location to insert
                                    int local = (vOut2 + 0xd);
                                    int local2 = (vOut2 + 0x13);
                                    int local3 = (vOut2 + 0x1e);
                                    int local4 = (vOut2 + 0x2c);
                                    long Location1 = Convert.ToInt64(local);
                                    long Location2 = Convert.ToInt64(local2);
                                    long Location3 = Convert.ToInt64(local3);
                                    long Location4 = Convert.ToInt64(local4);
                                    //Convert offsets to byte[]
                                    byte[] Byte3 = BitConverter.GetBytes(vOut3);
                                    byte[] Byte4 = BitConverter.GetBytes(vOut4);
                                    byte[] Byte5 = BitConverter.GetBytes(vOut5);
                                    byte[] Byte6 = BitConverter.GetBytes(vOut6);
                                    MessageBox.Show("Repointing...");
                                    WriteData(Byte3, Location1);
                                    WriteData(Byte4, Location2);
                                    WriteData(Byte5, Location3);
                                    WriteData(Byte6, Location4);
                                    int vfix = (local + 3);
                                    int vfix2 = (local2 + 3);
                                    int vfix3 = (local3 + 3);
                                    int vfix4 = (local4 + 3);
                                    long LocationF = Convert.ToInt64(vfix);
                                    long LocationF2 = Convert.ToInt64(vfix2);
                                    long LocationF3 = Convert.ToInt64(vfix3);
                                    long LocationF4 = Convert.ToInt64(vfix4);
                                    byte[] BFix = { 0x08 };
                                    WriteData(BFix, LocationF);
                                    WriteData(BFix, LocationF2);
                                    WriteData(BFix, LocationF3);
                                    WriteData(BFix, LocationF4);
                                    MessageBox.Show("Final bug fix...");
                                    string S = vOut3.ToString();
                                    string S1 = vOut4.ToString();
                                    string S2 = vOut5.ToString();
                                    string S3 = vOut6.ToString();
                                    MessageBox.Show("Success!");

                                }
                                catch
                                {
                                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (FireRed == true)
            {
                try
                {
                    MessageBox.Show("Watching grass grow....");
                    WriteData(newGrass, Grass);  //stuff here for file writing
                    WriteData(newGrass2, Grass2);
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
                if (MrDS == true)
                {
                    try
                    {
                        MessageBox.Show("Watching grass grow....");
                        WriteData(newGrass, Grass);  //stuff here for file writing
                        WriteData(newGrass2, Grass2);
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
                if (other == true)
                {
                    DialogResult result1 = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Fire Red-based, or No/Cancel if you wish to not continue.", "Notice", MessageBoxButtons.YesNoCancel);
                    if (result1 == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            MessageBox.Show("Watching grass grow....");
                            WriteData(newGrass, Grass);  //stuff here for file writing
                            WriteData(newGrass2, Grass2);
                            MessageBox.Show("Success!");
                        }
                        catch
                        {
                            MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                        }
                    }
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (Emerald == true)
            {
                try
                {
                    MessageBox.Show("Injecting eggs with degrowth serum....");
                    WriteData(newEgg1, Egg1);  //stuff here for file writing
                    WriteData(newEgg2, Egg2);
                    WriteData(newEgg3, Egg3);
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (FireRed == true)
            {
                try
                {
                    MessageBox.Show("Injecting eggs with degrowth serum....");
                    WriteData(newEgg1, Egg1f);  //stuff here for file writing
                    WriteData(newEgg2, Egg2f);
                    WriteData(newEgg3, Egg3f);
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (MrDS == true)
            {
                try
                {
                    MessageBox.Show("Injecting eggs with degrowth serum....");
                    WriteData(newEgg1, Egg1f);  //stuff here for file writing
                    WriteData(newEgg2, Egg2f);
                    WriteData(newEgg3, Egg3f);
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
                        if (other == true)
                        {
                            DialogResult result1 = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Emerald-based, or No/Cancel if you wish to not continue.", "Notice", MessageBoxButtons.YesNoCancel);
                if (result1 == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show("Injecting eggs with degrowth serum....");
                        WriteData(newEgg1, Egg1);  //stuff here for file writing
                        WriteData(newEgg2, Egg2);
                        WriteData(newEgg3, Egg3);
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
                            }
                        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Credits go to Darthatron, Diegoisawesome, Knizz, Mewthree, Jambo51, Phenom2122, Spherical Ice, TheRealOCD, Team Fail, and anyone I may have forgotten to credit! ");
        }


        private void button6_Click_1(object sender, EventArgs e)
        {
            if (fileLocation == null)
            {
                MessageBox.Show("Please load a game.", "Error");
                return;
            }
            if (FireRed == true)
            {
                try
                {
                    MessageBox.Show("Slapping Proffesor Oak....");
                    WriteData(newDex, FireRedDex);
                    WriteData(newDex, FireRedDex2);//stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (MrDS == true)
            {
                try
                {
                    MessageBox.Show("Slapping Proffesor Oak....");
                    WriteData(newDex, FireRedDex);
                    WriteData(newDex, FireRedDex2);//stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (LeafGreen == true)
            {
                try
                {
                    MessageBox.Show("Slapping Proffesor Oak....");
                    WriteData(newDex, LeafGreenDex);
                    WriteData(newDex, LeafGreenDex2);//stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (other == true)
            {
                DialogResult result = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Fire Red-based, No if this is leafgreen based, or cancel if you wish to not continue.", "Notice", MessageBoxButtons.YesNoCancel);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show("Slapping Proffesor Oak....");
                        WriteData(newDex, FireRedDex);
                        WriteData(newDex, FireRedDex2);//stuff here for file writing
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
                if (result == DialogResult.No)
                {
                    try
                    {
                        MessageBox.Show("Slapping Proffesor Oak....");
                        WriteData(newDex, LeafGreenDex);
                        WriteData(newDex, LeafGreenDex2);//stuff here for file writing
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (fileLocation == null)
            {
                MessageBox.Show("Please load a game.", "Error");
                return;
            }
            if (FireRed == true)
            {
                try
                {
                    MessageBox.Show("Brainwashing Mews....");
                    WriteData(newMew, FireRedMew);//stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (MrDS == true)
            {
                try
                {
                    MessageBox.Show("Brainwashing Mews....");
                    WriteData(newMew, FireRedMew);//stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (other == true)
            {
                DialogResult result = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Fire Red-based, No if you wish to not continue.", "Notice", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show("Brainwashing Mews....");
                        WriteData(newMew, FireRedMew);//stuff here for file writing
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }

            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (fileLocation == null)
            {
                MessageBox.Show("Please load a game.", "Error");
                return;
            }
            if (Emerald == true)
            {
                try
                {
                    MessageBox.Show("Trying new fertalizer....");
                    WriteData(newBerry, EmeraldBerry);//stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (other == true)
            {
                DialogResult result = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Emerald-based, No if you wish to not continue.", "Notice", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show("Trying new fertalizer....");
                        WriteData(newBerry, EmeraldBerry);//stuff here for file writing
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }

            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (fileLocation == null)
            {
                MessageBox.Show("Please load a game.", "Error");
                return;
            }
            if (FireRed == true)
            {
                try
                {
                    MessageBox.Show("Rebreeding Legendaries for better stats....");
                    WriteData(newIV, FRLGIV);  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (MrDS == true)
            {
                try
                {
                    MessageBox.Show("Rebreeding Legendaries for better stats....");
                    WriteData(newIV, FRLGIV);  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (LeafGreen == true)
            {
                try
                {
                    MessageBox.Show("Rebreeding Legendaries for better stats....");
                    WriteData(newIV, FRLGIV);  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (Ruby == true)
            {
                try
                {
                    MessageBox.Show("Rebreeding Legendaries for better stats....");
                    WriteData(newIV, RSIV);  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
                if (Sapphire == true)
                {
                    try
                    {
                        MessageBox.Show("Rebreeding Legendaries for better stats....");
                        WriteData(newIV, RSIV);  //stuff here for file writing
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
                if (other == true)
                {
                    DialogResult result = MessageBox.Show("This is an unrecognised game. Click Yes if the game is FRLG-based, No if it is RS-based, or Cancel if you wish to not continue.", "Notice", MessageBoxButtons.YesNoCancel);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            MessageBox.Show("Rebreeding Legendaries for better stats....");
                            WriteData(newIV, FRLGIV);  //stuff here for file writing
                            MessageBox.Show("Success!");
                        }
                        catch
                        {
                            MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                        }
                    }
                    if (result == DialogResult.No)
                    {
                        try
                        {
                            MessageBox.Show("Rebreeding Legendaries for better stats....");
                            WriteData(newIV, RSIV);  //stuff here for file writing
                            MessageBox.Show("Success!");
                        }
                        catch
                        {
                            MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                        }
                    }
                }
            }


        }

        private void EvoND_Click_1(object sender, EventArgs e)
        {
            if (fileLocation == null)
            {
                MessageBox.Show("Please load a game.", "Error");
                return;
            }
            if (FireRed == true)
            {
                try
                {
                    MessageBox.Show("Downgrading life's standards....");
                    WriteData(NDEvoBytes, NDEvo);  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (MrDS == true)
            {
                try
                {
                    MessageBox.Show("Downgrading life's standards....");
                    WriteData(newFlash, FireRedFlash);  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (other == true)
            {
                DialogResult result = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Fire Red-based, No if it is Leaf Green-based, or Cancel if you wish to not continue.", "Notice", MessageBoxButtons.YesNoCancel);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show("Downgrading life's standards....");
                        WriteData(newFlash, FireRedFlash); 
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
                if (result == DialogResult.No)
                {
                    try
                    {
                        MessageBox.Show("Burning diaries....");
                        WriteData(newFlash, FireRedFlash); 
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (Emerald == true)
            {
                try
                {
                    MessageBox.Show("Upgrading de-educational system....");
                    WriteData(HM, EMHM);  //stuff here for file writing
                    WriteData(HM, EMHM2);
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (FireRed == true)
            {
                try
                {
                    MessageBox.Show("Upgrading de-educational system....");
                    WriteData(HM, FRHM);  //stuff here for file writing
                    WriteData(HM, FRHM2);
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (MrDS == true)
            {
                try
                {
                    MessageBox.Show("Upgrading de-educational system....");
                    WriteData(HM, FRHM);  //stuff here for file writing
                    WriteData(HM, FRHM2);
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
                        if (other == true)
                        {
                            DialogResult result1 = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Emerald-based, or No/Cancel if you wish to not continue.", "Notice", MessageBoxButtons.YesNoCancel);
                if (result1 == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show("Upgrading de-educational system....");
                        WriteData(HM, EMHM);  //stuff here for file writing
                        WriteData(HM, EMHM2);
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
                            }
                        }


        private void button10_Click_1(object sender, EventArgs e)
        {
            long Birch = 0x308AC;
            long Intro = 0x30872;
            long Background = 0x30882;
            byte[] BirchB = { 0x31, 0x16, 0x03, 0x08 };
            byte[] BackB = { 0x00, 0x00, 0x00, 0x00 };
            if (Emerald == true)
            {
                try
                {
                    MessageBox.Show("Fireing the old Prof.....");
                    WriteData(HM, Intro);  //stuff here for file writing
                    WriteData(BirchB, Birch);
                    WriteData(BackB, Background);
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
                        if (other == true)
                        {
                            DialogResult result1 = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Emerald-based, or No/Cancel if you wish to not continue.", "Notice", MessageBoxButtons.YesNoCancel);
                            if (result1 == System.Windows.Forms.DialogResult.Yes)
                            {
                                try
                                {
                                    MessageBox.Show("Fireing the old Prof.....");
                                    WriteData(HM, Intro);  //stuff here for file writing
                                    WriteData(BirchB, Birch);
                                    WriteData(BackB, Background);
                                    MessageBox.Show("Success!");
                                }
                                catch
                                {
                                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                                }
                            }
                        }
                    }
                }

        private void button11_Click_1(object sender, EventArgs e)
        {

            if (FireRed == true)
            {
                try
                {
                    MessageBox.Show("Shaming Lu-Ho....");
                    long AMapFix = 0x39fbf8;
                    byte[] AMapFixB = { 0xB5, 0xFF, 0x05, 0x08, };
                    WriteData(AMapFixB, AMapFix);
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
                if (MrDS == true)
                {
                    try
                    {
                        MessageBox.Show("Shaming Lu-Ho....");
                        long AMapFix = 0x39fbf8;
                        byte[] AMapFixB = { 0xB5, 0xFF, 0x05, 0x08, };
                        WriteData(AMapFixB, AMapFix);
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
                if (other == true)
                {
                    DialogResult result1 = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Fire Red-based, or No/Cancel if you wish to not continue.", "Notice", MessageBoxButtons.YesNoCancel);
                    if (result1 == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            MessageBox.Show("Shaming Lu-Ho....");
                            long AMapFix = 0x39fbf8;
                            byte[] AMapFixB = { 0xB5, 0xFF, 0x05, 0x08, };
                            WriteData(AMapFixB, AMapFix);
                            MessageBox.Show("Success!");
                        }
                        catch
                        {
                            MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                        }
                    }
                }
            }

        }
        private void button12_Click_1(object sender, EventArgs e)
        {

            if (FireRed == true)
            {
                try
                {
                    MessageBox.Show("Shaming Lu-Ho....");
                    long AMapFix = 0x39fbf8;
                    byte[] AMapFixB = { 0xF1, 0x31, 0x06, 0x08 };
                    WriteData(AMapFixB, AMapFix);
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
                if (MrDS == true)
                {
                    try
                    {
                        MessageBox.Show("Shaming Lu-Ho....");
                        long AMapFix = 0x39fbf8;
                        byte[] AMapFixB = { 0xF1, 0x31, 0x06, 0x08 };
                        WriteData(AMapFixB, AMapFix);
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
                if (other == true)
                {
                    DialogResult result1 = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Fire Red-based, or No/Cancel if you wish to not continue.", "Notice", MessageBoxButtons.YesNoCancel);
                    if (result1 == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            MessageBox.Show("Shaming Lu-Ho....");
                            long AMapFix = 0x39fbf8;
                            byte[] AMapFixB = { 0xF1, 0x31, 0x06, 0x08 };
                            WriteData(AMapFixB, AMapFix);
                            MessageBox.Show("Success!");
                        }
                        catch
                        {
                            MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                        }
                    }
                }
            }

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            long Seen = 0x00CF56;
            long Seen1 = 0x00CF64;
            long Seen2 = 0x0F803C;
            long Seen3 = 0x0F8044;
            byte[] SeenB = {0x00, 0x20 };
            if (fileLocation == null)
            {
                MessageBox.Show("Please load a game.", "Error");
                return;
            }
            if (FireRed == true)
            {
                try
                {
                    MessageBox.Show("Changing Caught to Seen...");
                    WriteData(SeenB, Seen);  //stuff here for file writing
                    WriteData(SeenB, Seen1);
                    WriteData(SeenB, Seen2);
                    WriteData(SeenB, Seen3);
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (MrDS == true)
            {
                try
                {
                    MessageBox.Show("Changing Caught to Seen...");
                    WriteData(SeenB, Seen);  //stuff here for file writing
                    WriteData(SeenB, Seen1);
                    WriteData(SeenB, Seen2);
                    WriteData(SeenB, Seen3);
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (other == true)
            {
                DialogResult result = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Fire Red-based, or No if you wish to not continue.", "Notice", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show("Changing Caught to Seen...");
                        WriteData(SeenB, Seen);  //stuff here for file writing
                        WriteData(SeenB, Seen1);
                        WriteData(SeenB, Seen2);
                        WriteData(SeenB, Seen3);
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            long RFlag = 0x05BA3A;
            byte[] RFlagB = { 0x00, 0x00, 0x00, 0x00 };
            if (fileLocation == null)
            {
                MessageBox.Show("Please load a game.", "Error");
                return;
            }
            if (FireRed == true)
            {
                try
                {
                    MessageBox.Show("Adding instructions to the heel of your boots...");
                    WriteData(RFlagB, RFlag);  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (MrDS == true)
            {
                try
                {
                    MessageBox.Show("Adding instructions to the heel of your boots...");
                    WriteData(RFlagB, RFlag);  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (other == true)
            {
                DialogResult result = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Fire Red-based, or No if you wish to not continue.", "Notice", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show("Adding instructions to the heel of your boots...");
                        WriteData(RFlagB, RFlag);  //stuff here for file writing
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
            }
        }



        private void button15_Click_1(object sender, EventArgs e)
        {
            long Poison = 0x06D7C3;
            byte[] PoisonB = { 0xE0};
            if (fileLocation == null)
            {
                MessageBox.Show("Please load a game.", "Error");
                return;
            }
            if (FireRed == true)
            {
                try
                {
                    MessageBox.Show("Telling Poison to cut it out....");
                    WriteData(PoisonB, Poison);  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (MrDS == true)
            {
                try
                {
                    MessageBox.Show("Telling Poison to cut it out....");
                    WriteData(PoisonB, Poison);  //stuff here for file writing
                    MessageBox.Show("Success!");
                }
                catch
                {
                    MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                }
            }
            if (other == true)
            {
                DialogResult result = MessageBox.Show("This is an unrecognised game. Click Yes if the game is Fire Red-based, or No if you wish to not continue.", "Notice", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show("Telling Poison to cut it out....");
                        WriteData(PoisonB, Poison);  //stuff here for file writing
                        MessageBox.Show("Success!");
                    }
                    catch
                    {
                        MessageBox.Show("Failed! Please make sure that there is no other program with your ROM opened.");//Put messages here if you want...
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {


        }


        private void button16_Click(object sender, EventArgs e)
        {
            long BattleO = 0x05499C;
            long BattleO2 = 0x05499D;
            long TextO = 0x05496C;
            long TextO2 = 0x05496D;
            long BTNModeO = 0x0549A2;
            long BTNModeO2 = 0x0549A3;
            byte[] TwentyB = { 0x20 };

            byte[] Fix1 = { 0x10, 0x75 };
            long Fix1O = 0x5496e;
            byte[] Fix2 = { 0x50, 0x75 };
            long Fix2O = 0x05499E;
            byte[] Fix3 = { 0xC8, 0x74 };
            long Fix3O = 0x0549A4;

            //Text Section
            int Text1 = TextSpeed.SelectedIndex;
            int Text2 = Frame.SelectedIndex * 8;
            int Text3 = (Text1 + Text2);
            byte[] TextByte = BitConverter.GetBytes(Text3);
            WriteData(TextByte, TextO);
            WriteData(TwentyB, TextO2);

            //Battle Section
            int Battle1 = Sound.SelectedIndex;
            int Battle2 = BattleStyle.SelectedIndex * 2;
            int Battle3 = BattleScene.SelectedIndex * 4;
            int Battle4 = (Battle1 + Battle2 + Battle3);
            byte[] BattleB = BitConverter.GetBytes(Battle4);
            WriteData(BattleB, BattleO);
            WriteData(TwentyB, BattleO2);

            //Button
            byte[] ButtonB = BitConverter.GetBytes(BTNMode.SelectedIndex);
            WriteData(ButtonB, BTNModeO);
            WriteData(TwentyB, BTNModeO2);

            //Fix
            WriteData(Fix1, Fix1O);
            WriteData(Fix2, Fix2O);
            WriteData(Fix3, Fix3O);
        }

        public static byte[] Combine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }

        public static byte[] Combine(byte[] first, byte[] second, byte[] third)
        {
            byte[] ret = new byte[first.Length + second.Length + third.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            Buffer.BlockCopy(third, 0, ret, first.Length + second.Length,
                             third.Length);
            return ret;
        }

        public static byte[] Combine(params byte[][] arrays)
        {
            byte[] ret = new byte[arrays.Sum(x => x.Length)];
            int offset = 0;
            foreach (byte[] data in arrays)
            {
                Buffer.BlockCopy(data, 0, ret, offset, data.Length);
                offset += data.Length;
            }
            return ret;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            TextSpeed.SelectedIndex = 1;
            Frame.SelectedIndex = 0;
            Sound.SelectedIndex = 1;
            BattleScene.SelectedIndex = 0;
            BattleStyle.SelectedIndex = 0;
            BTNMode.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

        
