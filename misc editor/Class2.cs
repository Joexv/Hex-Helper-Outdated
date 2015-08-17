using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace A_Gen_Misc_Edits
{
    class LSAPokeHelper
    {
        //Reads the game version
        public string ReadGame(OpenFileDialog ofd)
        {
            BinaryReader br = new BinaryReader(File.OpenRead(ofd.FileName));
            string gamecode = "";

            for (int i = 0xA0; i <= 0xAF; i++)
            {
                br.BaseStream.Position = i;
                int c = br.ReadByte();

                #region
                switch (c)
                {
                    case 0x20:
                        {
                            gamecode += " ";
                            break;
                        };
                    case 0x21:
                        {
                            gamecode += "!";
                            break;
                        };
                    case 0x22:
                        {
                            gamecode += "\"";
                            break;
                        };
                    case 0x23:
                        {
                            gamecode += "#";
                            break;
                        };
                    case 0x24:
                        {
                            gamecode += "$";
                            break;
                        };
                    case 0x25:
                        {
                            gamecode += "%";
                            break;
                        };
                    case 0x26:
                        {
                            gamecode += "&";
                            break;
                        };
                    case 0x27:
                        {
                            gamecode += "'";
                            break;
                        };
                    case 0x28:
                        {
                            gamecode += "(";
                            break;
                        };
                    case 0x29:
                        {
                            gamecode += ")";
                            break;
                        };
                    case 0x2A:
                        {
                            gamecode += "*";
                            break;
                        };
                    case 0x2B:
                        {
                            gamecode += "+";
                            break;
                        };
                    case 0x2C:
                        {
                            gamecode += ",";
                            break;
                        };
                    case 0x2D:
                        {
                            gamecode += "-";
                            break;
                        };
                    case 0x2E:
                        {
                            gamecode += ".";
                            break;
                        };
                    case 0x2F:
                        {
                            gamecode += "/";
                            break;
                        };
                    case 0x30:
                        {
                            gamecode += "0";
                            break;
                        };
                    case 0x31:
                        {
                            gamecode += "1";
                            break;
                        };
                    case 0x32:
                        {
                            gamecode += "2";
                            break;
                        };
                    case 0x33:
                        {
                            gamecode += "3";
                            break;
                        };
                    case 0x34:
                        {
                            gamecode += "4";
                            break;
                        };
                    case 0x35:
                        {
                            gamecode += "5";
                            break;
                        };
                    case 0x36:
                        {
                            gamecode += "6";
                            break;
                        };
                    case 0x37:
                        {
                            gamecode += "7";
                            break;
                        };
                    case 0x38:
                        {
                            gamecode += "8";
                            break;
                        };
                    case 0x39:
                        {
                            gamecode += "9";
                            break;
                        };
                    case 0x3A:
                        {
                            gamecode += ":";
                            break;
                        };
                    case 0x3B:
                        {
                            gamecode += ";";
                            break;
                        };
                    case 0x3C:
                        {
                            gamecode += "<";
                            break;
                        };
                    case 0x3D:
                        {
                            gamecode += "=";
                            break;
                        };
                    case 0x3E:
                        {
                            gamecode += ">";
                            break;
                        };
                    case 0x3F:
                        {
                            gamecode += "?";
                            break;
                        };
                    case 0x40:
                        {
                            gamecode += "@";
                            break;
                        };
                    case 0x41:
                        {
                            gamecode += "A";
                            break;
                        };
                    case 0x42:
                        {
                            gamecode += "B";
                            break;
                        };
                    case 0x43:
                        {
                            gamecode += "C";
                            break;
                        };
                    case 0x44:
                        {
                            gamecode += "D";
                            break;
                        };
                    case 0x45:
                        {
                            gamecode += "E";
                            break;
                        };
                    case 0x46:
                        {
                            gamecode += "F";
                            break;
                        };
                    case 0x47:
                        {
                            gamecode += "G";
                            break;
                        };
                    case 0x48:
                        {
                            gamecode += "H";
                            break;
                        };
                    case 0x49:
                        {
                            gamecode += "I";
                            break;
                        };
                    case 0x4A:
                        {
                            gamecode += "J";
                            break;
                        };
                    case 0x4B:
                        {
                            gamecode += "K";
                            break;
                        };
                    case 0x4C:
                        {
                            gamecode += "L";
                            break;
                        };
                    case 0x4D:
                        {
                            gamecode += "M";
                            break;
                        };
                    case 0x4E:
                        {
                            gamecode += "N";
                            break;
                        };
                    case 0x4F:
                        {
                            gamecode += "O";
                            break;
                        };
                    case 0x50:
                        {
                            gamecode += "P";
                            break;
                        };
                    case 0x51:
                        {
                            gamecode += "Q";
                            break;
                        };
                    case 0x52:
                        {
                            gamecode += "R";
                            break;
                        };
                    case 0x53:
                        {
                            gamecode += "S";
                            break;
                        };
                    case 0x54:
                        {
                            gamecode += "T";
                            break;
                        };
                    case 0x55:
                        {
                            gamecode += "U";
                            break;
                        };
                    case 0x56:
                        {
                            gamecode += "V";
                            break;
                        };
                    case 0x57:
                        {
                            gamecode += "W";
                            break;
                        };
                    case 0x58:
                        {
                            gamecode += "X";
                            break;
                        };
                    case 0x59:
                        {
                            gamecode += "Y";
                            break;
                        };
                    case 0x5A:
                        {
                            gamecode += "Z";
                            break;
                        };
                    case 0x5B:
                        {
                            gamecode += "[";
                            break;
                        };
                    case 0x5C:
                        {
                            gamecode += "\\";
                            break;
                        };
                    case 0x5D:
                        {
                            gamecode += "]";
                            break;
                        };
                    case 0x5E:
                        {
                            gamecode += "^";
                            break;
                        };
                    case 0x5F:
                        {
                            gamecode += "_";
                            break;
                        };
                    case 0x60:
                        {
                            gamecode += "`";
                            break;
                        };
                    case 0x61:
                        {
                            gamecode += "a";
                            break;
                        };
                    case 0x62:
                        {
                            gamecode += "b";
                            break;
                        };
                    case 0x63:
                        {
                            gamecode += "c";
                            break;
                        };
                    case 0x64:
                        {
                            gamecode += "d";
                            break;
                        };
                    case 0x65:
                        {
                            gamecode += "e";
                            break;
                        };
                    case 0x66:
                        {
                            gamecode += "f";
                            break;
                        };
                    case 0x67:
                        {
                            gamecode += "g";
                            break;
                        };
                    case 0x68:
                        {
                            gamecode += "h";
                            break;
                        };
                    case 0x69:
                        {
                            gamecode += "i";
                            break;
                        };
                    case 0x6A:
                        {
                            gamecode += "j";
                            break;
                        };
                    case 0x6B:
                        {
                            gamecode += "k";
                            break;
                        };
                    case 0x6C:
                        {
                            gamecode += "l";
                            break;
                        };
                    case 0x6D:
                        {
                            gamecode += "m";
                            break;
                        };
                    case 0x6E:
                        {
                            gamecode += "n";
                            break;
                        };
                    case 0x6F:
                        {
                            gamecode += "o";
                            break;
                        };
                    case 0x70:
                        {
                            gamecode += "p";
                            break;
                        };
                    case 0x71:
                        {
                            gamecode += "q";
                            break;
                        };
                    case 0x72:
                        {
                            gamecode += "r";
                            break;
                        };
                    case 0x73:
                        {
                            gamecode += "s";
                            break;
                        };
                    case 0x74:
                        {
                            gamecode += "t";
                            break;
                        };
                    case 0x75:
                        {
                            gamecode += "u";
                            break;
                        };
                    case 0x76:
                        {
                            gamecode += "v";
                            break;
                        };
                    case 0x77:
                        {
                            gamecode += "w";
                            break;
                        };
                    case 0x78:
                        {
                            gamecode += "x";
                            break;
                        };
                    case 0x79:
                        {
                            gamecode += "y";
                            break;
                        };
                    case 0x7A:
                        {
                            gamecode += "z";
                            break;
                        };
                    case 0x7B:
                        {
                            gamecode += "{";
                            break;
                        };
                    case 0x7C:
                        {
                            gamecode += "|";
                            break;
                        };
                    case 0x7D:
                        {
                            gamecode += "}";
                            break;
                        };
                    case 0x7E:
                        {
                            gamecode += "~";
                            break;
                        };
                    default:
                        {
                            gamecode += " ";
                            break;
                        };
                }
                #endregion

                if (i == 0xAB)
                {
                    gamecode += ", ";
                }

            }

            br.Close();
            return gamecode;
        }

        //Turns bytes to a string of letters
        public string GetText(byte[] br)
        {
            string ss = "";
            for (int i = 0; i < br.Length; i++)
            {
                switch (br[i])
                {
                    #region letters
                    case 0:
                        ss += " ";
                        break;
                    case 1:
                        ss += "À";
                        break;
                    case 2:
                        ss += "Á";
                        break;
                    case 3:
                        ss += "Â";
                        break;
                    case 4:
                        ss += "Ç";
                        break;
                    case 5:
                        ss += "È";
                        break;
                    case 6:
                        ss += "É";
                        break;
                    case 7:
                        ss += "Ê";
                        break;
                    case 8:
                        ss += "Ë";
                        break;
                    case 9:
                        ss += "Ì";
                        break;
                    case 11:
                        ss += "Î";
                        break;
                    case 12:
                        ss += "Ï";
                        break;
                    case 13:
                        ss += "Ò";
                        break;
                    case 14:
                        ss += "Ó";
                        break;
                    case 15:
                        ss += "Ô";
                        break;
                    case 16:
                        ss += "Œ";
                        break;
                    case 17:
                        ss += "Ù";
                        break;
                    case 18:
                        ss += "Ú";
                        break;
                    case 19:
                        ss += "Û";
                        break;
                    case 20:
                        ss += "Ñ";
                        break;
                    case 21:
                        ss += "ß";
                        break;
                    case 22:
                        ss += "à";
                        break;
                    case 23:
                        ss += "á";
                        break;
                    case 25:
                        ss += "ç";
                        break;
                    case 26:
                        ss += "è";
                        break;
                    case 27:
                        ss += "é";
                        break;
                    case 28:
                        ss += "ê";
                        break;
                    case 29:
                        ss += "ë";
                        break;
                    case 30:
                        ss += "ì";
                        break;
                    case 32:
                        ss += "î";
                        break;
                    case 33:
                        ss += "ï";
                        break;
                    case 34:
                        ss += "ò";
                        break;
                    case 35:
                        ss += "ó";
                        break;
                    case 36:
                        ss += "ô";
                        break;
                    case 37:
                        ss += "œ";
                        break;
                    case 38:
                        ss += "ù";
                        break;
                    case 39:
                        ss += "ú";
                        break;
                    case 40:
                        ss += "û";
                        break;
                    case 41:
                        ss += "ñ";
                        break;
                    case 42:
                        ss += "º";
                        break;
                    case 43:
                        ss += "ª";
                        break;
                    case 45:
                        ss += "&";
                        break;
                    case 46:
                        ss += "+";
                        break;
                    case 52:
                        ss += "[Lv]";
                        break;
                    case 53:
                        ss += "=";
                        break;
                    case 54:
                        ss += ";";
                        break;
                    case 81:
                        ss += "¿";
                        break;
                    case 82:
                        ss += "¡";
                        break;
                    case 83:
                        ss += "[pk]";
                        break;
                    case 84:
                        ss += "[mn]";
                        break;
                    case 85:
                        ss += "[po]";
                        break;
                    case 86:
                        ss += "[ké]";
                        break;
                    case 87:
                        ss += "[bl]";
                        break;
                    case 88:
                        ss += "[oc]";
                        break;
                    case 89:
                        ss += "[k]";
                        break;
                    case 90:
                        ss += "Í";
                        break;
                    case 91:
                        ss += "%";
                        break;
                    case 92:
                        ss += "(";
                        break;
                    case 93:
                        ss += ")";
                        break;
                    case 104:
                        ss += "â";
                        break;
                    case 111:
                        ss += "í";
                        break;
                    case 121:
                        ss += "[U]";
                        break;
                    case 122:
                        ss += "[D]";
                        break;
                    case 123:
                        ss += "[L]";
                        break;
                    case 124:
                        ss += "[R]";
                        break;
                    case 133:
                        ss += "<";
                        break;
                    case 134:
                        ss += ">";
                        break;
                    case 161:
                        ss += "0";
                        break;
                    case 162:
                        ss += "1";
                        break;
                    case 163:
                        ss += "2";
                        break;
                    case 164:
                        ss += "3";
                        break;
                    case 165:
                        ss += "4";
                        break;
                    case 166:
                        ss += "5";
                        break;
                    case 167:
                        ss += "6";
                        break;
                    case 168:
                        ss += "7";
                        break;
                    case 169:
                        ss += "8";
                        break;
                    case 170:
                        ss += "9";
                        break;
                    case 171:
                        ss += "!";
                        break;
                    case 172:
                        ss += "?";
                        break;
                    case 173:
                        ss += ".";
                        break;
                    case 174:
                        ss += "-";
                        break;
                    case 175:
                        ss += "·";
                        break;
                    case 176:
                        ss += "[.]";
                        break;
                    case 177:
                        ss += "[\"]";
                        break;
                    case 178:
                        ss += "\"";
                        break;
                    case 179:
                        ss += "[']";
                        break;
                    case 180:
                        ss += "'";
                        break;
                    case 181:
                        ss += "[m]";
                        break;
                    case 182:
                        ss += "[f]";
                        break;
                    case 183:
                        ss += "[$]";
                        break;
                    case 184:
                        ss += ",";
                        break;
                    case 185:
                        ss += "[x]";
                        break;
                    case 186:
                        ss += "/";
                        break;
                    case 187:
                        ss += "A";
                        break;
                    case 188:
                        ss += "B";
                        break;
                    case 189:
                        ss += "C";
                        break;
                    case 190:
                        ss += "D";
                        break;
                    case 191:
                        ss += "E";
                        break;
                    case 192:
                        ss += "F";
                        break;
                    case 193:
                        ss += "G";
                        break;
                    case 194:
                        ss += "H";
                        break;
                    case 195:
                        ss += "I";
                        break;
                    case 196:
                        ss += "J";
                        break;
                    case 197:
                        ss += "K";
                        break;
                    case 198:
                        ss += "L";
                        break;
                    case 199:
                        ss += "M";
                        break;
                    case 200:
                        ss += "N";
                        break;
                    case 201:
                        ss += "O";
                        break;
                    case 202:
                        ss += "P";
                        break;
                    case 203:
                        ss += "Q";
                        break;
                    case 204:
                        ss += "R";
                        break;
                    case 205:
                        ss += "S";
                        break;
                    case 206:
                        ss += "T";
                        break;
                    case 207:
                        ss += "U";
                        break;
                    case 208:
                        ss += "V";
                        break;
                    case 209:
                        ss += "W";
                        break;
                    case 210:
                        ss += "X";
                        break;
                    case 211:
                        ss += "Y";
                        break;
                    case 212:
                        ss += "Z";
                        break;
                    case 213:
                        ss += "a";
                        break;
                    case 214:
                        ss += "b";
                        break;
                    case 215:
                        ss += "c";
                        break;
                    case 216:
                        ss += "d";
                        break;
                    case 217:
                        ss += "e";
                        break;
                    case 218:
                        ss += "f";
                        break;
                    case 219:
                        ss += "g";
                        break;
                    case 220:
                        ss += "h";
                        break;
                    case 221:
                        ss += "i";
                        break;
                    case 222:
                        ss += "j";
                        break;
                    case 223:
                        ss += "k";
                        break;
                    case 224:
                        ss += "l";
                        break;
                    case 225:
                        ss += "m";
                        break;
                    case 226:
                        ss += "n";
                        break;
                    case 227:
                        ss += "o";
                        break;
                    case 228:
                        ss += "p";
                        break;
                    case 229:
                        ss += "q";
                        break;
                    case 230:
                        ss += "r";
                        break;
                    case 231:
                        ss += "s";
                        break;
                    case 232:
                        ss += "t";
                        break;
                    case 233:
                        ss += "u";
                        break;
                    case 234:
                        ss += "v";
                        break;
                    case 235:
                        ss += "w";
                        break;
                    case 236:
                        ss += "x";
                        break;
                    case 237:
                        ss += "y";
                        break;
                    case 238:
                        ss += "z";
                        break;
                    case 239:
                        ss += "[>]";
                        break;
                    case 240:
                        ss += ":";
                        break;
                    case 241:
                        ss += "Ä";
                        break;
                    case 242:
                        ss += "Ö";
                        break;
                    case 243:
                        ss += "Ü";
                        break;
                    case 244:
                        ss += "ä";
                        break;
                    case 245:
                        ss += "ö";
                        break;
                    case 246:
                        ss += "ü";
                        break;
                    case 247:
                        ss += "[u]";
                        break;
                    case 248:
                        ss += "[d]";
                        break;
                    case 249:
                        ss += "[l]";
                        break;
                    case 250:
                        ss += "\\l";
                        break;
                    case 251:
                        ss += "\\p";
                        break;
                    case 252:
                        ss += "\\c";
                        break;
                    case 253:
                        ss += "\\v";
                        break;
                    case 254:
                        ss += "\\n";
                        break;
                    case 255:
                        ss += "\\x";
                        break;
                    default:
                        ss += " ";
                        break;
                    #endregion
                }
            }
            return ss;

        }
        //Writes text to the ROM at a specified offset
        public void WriteText(string input, string offset, OpenFileDialog ofd)
        {
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(ofd.FileName));
            UInt32 test = Convert.ToUInt32(offset, 16);
            if (offset.Length > 6)
            {
                test = test - 0x8000000;
            }

            if (test > 0xFFFF20)
            {
                offset = "FFFF20";
            }

            try
            {
                bw.BaseStream.Position = (Convert.ToInt32(offset, 16) - 0x8000000);
            }
            catch
            {
                bw.BaseStream.Position = (Convert.ToInt32(offset, 16));
            }

            StringBuilder description = new StringBuilder(input);
            for (int i = 0; i < description.Length; i++)
            {
                # region letters
                switch (description[i])
                {
                    case ' ':
                        {
                            bw.Write(Convert.ToByte(0x00));
                            break;
                        };
                    case 'À':
                        {
                            bw.Write(Convert.ToByte(0x01));
                            break;
                        };
                    case 'Á':
                        {
                            bw.Write(Convert.ToByte(0x02));
                            break;
                        };
                    case 'Â':
                        {
                            bw.Write(Convert.ToByte(0x03));
                            break;
                        };
                    case 'Ç':
                        {
                            bw.Write(Convert.ToByte(0x04));
                            break;
                        };
                    case 'È':
                        {
                            bw.Write(Convert.ToByte(0x05));
                            break;
                        };
                    case 'É':
                        {
                            bw.Write(Convert.ToByte(0x06));
                            break;
                        };
                    case 'Ê':
                        {
                            bw.Write(Convert.ToByte(0x07));
                            break;
                        };
                    case 'Ë':
                        {
                            bw.Write(Convert.ToByte(0x08));
                            break;
                        };
                    case 'Ì':
                        {
                            bw.Write(Convert.ToByte(0x09));
                            break;
                        };
                    case 'Î':
                        {
                            bw.Write(Convert.ToByte(0x0B));
                            break;
                        };
                    case 'Ï':
                        {
                            bw.Write(Convert.ToByte(0x0C));
                            break;
                        };
                    case 'Ò':
                        {
                            bw.Write(Convert.ToByte(0x0D));
                            break;
                        };
                    case 'Ó':
                        {
                            bw.Write(Convert.ToByte(0x0E));
                            break;
                        };
                    case 'Ô':
                        {
                            bw.Write(Convert.ToByte(0x0F));
                            break;
                        };
                    case 'Œ':
                        {
                            bw.Write(Convert.ToByte(0x10));
                            break;
                        };
                    case 'Ù':
                        {
                            bw.Write(Convert.ToByte(0x11));
                            break;
                        };
                    case 'Ú':
                        {
                            bw.Write(Convert.ToByte(0x12));
                            break;
                        };
                    case 'Û':
                        {
                            bw.Write(Convert.ToByte(0x13));
                            break;
                        };
                    case 'Ñ':
                        {
                            bw.Write(Convert.ToByte(0x14));
                            break;
                        };
                    case 'ß':
                        {
                            bw.Write(Convert.ToByte(0x15));
                            break;
                        };
                    case 'à':
                        {
                            bw.Write(Convert.ToByte(0x16));
                            break;
                        };
                    case 'á':
                        {
                            bw.Write(Convert.ToByte(0x17));
                            break;
                        };
                    case 'ç':
                        {
                            bw.Write(Convert.ToByte(0x19));
                            break;
                        };
                    case 'è':
                        {
                            bw.Write(Convert.ToByte(0x1A));
                            break;
                        };
                    case 'é':
                        {
                            bw.Write(Convert.ToByte(0x1B));
                            break;
                        };
                    case 'ê':
                        {
                            bw.Write(Convert.ToByte(0x1C));
                            break;
                        };
                    case 'ë':
                        {
                            bw.Write(Convert.ToByte(0x1D));
                            break;
                        };
                    case 'ì':
                        {
                            bw.Write(Convert.ToByte(0x1E));
                            break;
                        };
                    case 'î':
                        {
                            bw.Write(Convert.ToByte(0x20));
                            break;
                        };
                    case 'ï':
                        {
                            bw.Write(Convert.ToByte(0x21));
                            break;
                        };
                    case 'ò':
                        {
                            bw.Write(Convert.ToByte(0x22));
                            break;
                        };
                    case 'ó':
                        {
                            bw.Write(Convert.ToByte(0x23));
                            break;
                        };
                    case 'ô':
                        {
                            bw.Write(Convert.ToByte(0x24));
                            break;
                        };
                    case 'œ':
                        {
                            bw.Write(Convert.ToByte(0x25));
                            break;
                        };
                    case 'ù':
                        {
                            bw.Write(Convert.ToByte(0x26));
                            break;
                        };
                    case 'ú':
                        {
                            bw.Write(Convert.ToByte(0x27));
                            break;
                        };
                    case 'û':
                        {
                            bw.Write(Convert.ToByte(0x28));
                            break;
                        };
                    case 'ñ':
                        {
                            bw.Write(Convert.ToByte(0x29));
                            break;
                        };
                    case 'º':
                        {
                            bw.Write(Convert.ToByte(0x2A));
                            break;
                        };
                    case 'ª':
                        {
                            bw.Write(Convert.ToByte(0x2B));
                            break;
                        };
                    case '&':
                        {
                            bw.Write(Convert.ToByte(0x2D));
                            break;
                        };
                    case '+':
                        {
                            bw.Write(Convert.ToByte(0x2E));
                            break;
                        };
                    case '=':
                        {
                            bw.Write(Convert.ToByte(0x35));
                            break;
                        };
                    case ';':
                        {
                            bw.Write(Convert.ToByte(0x36));
                            break;
                        };
                    case '¿':
                        {
                            bw.Write(Convert.ToByte(0x51));
                            break;
                        };
                    case '¡':
                        {
                            bw.Write(Convert.ToByte(0x52));
                            break;
                        };
                    case 'Í':
                        {
                            bw.Write(Convert.ToByte(0x5A));
                            break;
                        };
                    case '%':
                        {
                            bw.Write(Convert.ToByte(0x5B));
                            break;
                        };
                    case '(':
                        {
                            bw.Write(Convert.ToByte(0x5C));
                            break;
                        };
                    case ')':
                        {
                            bw.Write(Convert.ToByte(0x5D));
                            break;
                        };
                    case 'â':
                        {
                            bw.Write(Convert.ToByte(0x68));
                            break;
                        };
                    case 'í':
                        {
                            bw.Write(Convert.ToByte(0x6F));
                            break;
                        };
                    case '<':
                        {
                            bw.Write(Convert.ToByte(0x85));
                            break;
                        };
                    case '>':
                        {
                            bw.Write(Convert.ToByte(0x86));
                            break;
                        };
                    case '0':
                        {
                            bw.Write(Convert.ToByte(0xA1));
                            break;
                        };
                    case '1':
                        {
                            bw.Write(Convert.ToByte(0xA2));
                            break;
                        };
                    case '2':
                        {
                            bw.Write(Convert.ToByte(0xA3));
                            break;
                        };
                    case '3':
                        {
                            bw.Write(Convert.ToByte(0xA4));
                            break;
                        };
                    case '4':
                        {
                            bw.Write(Convert.ToByte(0xA5));
                            break;
                        };
                    case '5':
                        {
                            bw.Write(Convert.ToByte(0xA6));
                            break;
                        };
                    case '6':
                        {
                            bw.Write(Convert.ToByte(0xA7));
                            break;
                        };
                    case '7':
                        {
                            bw.Write(Convert.ToByte(0xA8));
                            break;
                        };
                    case '8':
                        {
                            bw.Write(Convert.ToByte(0xA9));
                            break;
                        };
                    case '9':
                        {
                            bw.Write(Convert.ToByte(0x09));
                            break;
                        };
                    case '!':
                        {
                            bw.Write(Convert.ToByte(0xAB));
                            break;
                        };
                    case '?':
                        {
                            bw.Write(Convert.ToByte(0xAC));
                            break;
                        };
                    case '.':
                        {
                            bw.Write(Convert.ToByte(0xAD));
                            break;
                        };
                    case '-':
                        {
                            bw.Write(Convert.ToByte(0xAE));
                            break;
                        };
                    case '·':
                        {
                            bw.Write(Convert.ToByte(0xAF));
                            break;
                        };
                    case '"':
                        {
                            bw.Write(Convert.ToByte(0xB2));
                            break;
                        };
                    case '\'':
                        {
                            bw.Write(Convert.ToByte(0xB4));
                            break;
                        };
                    case ',':
                        {
                            bw.Write(Convert.ToByte(0xB8));
                            break;
                        };
                    case '/':
                        {
                            bw.Write(Convert.ToByte(0xBA));
                            break;
                        };
                    case 'A':
                        {
                            bw.Write(Convert.ToByte(0xBB));
                            break;
                        };
                    case 'B':
                        {
                            bw.Write(Convert.ToByte(0xBC));
                            break;
                        };
                    case 'C':
                        {
                            bw.Write(Convert.ToByte(0xBD));
                            break;
                        };
                    case 'D':
                        {
                            bw.Write(Convert.ToByte(0xBE));
                            break;
                        };
                    case 'E':
                        {
                            bw.Write(Convert.ToByte(0xBF));
                            break;
                        };
                    case 'F':
                        {
                            bw.Write(Convert.ToByte(0xC0));
                            break;
                        };
                    case 'G':
                        {
                            bw.Write(Convert.ToByte(0xC1));
                            break;
                        };
                    case 'H':
                        {
                            bw.Write(Convert.ToByte(0xC2));
                            break;
                        };
                    case 'I':
                        {
                            bw.Write(Convert.ToByte(0xC3));
                            break;
                        };
                    case 'J':
                        {
                            bw.Write(Convert.ToByte(0xC4));
                            break;
                        };
                    case 'K':
                        {
                            bw.Write(Convert.ToByte(0xC5));
                            break;
                        };
                    case 'L':
                        {
                            bw.Write(Convert.ToByte(0xC6));
                            break;
                        };
                    case 'M':
                        {
                            bw.Write(Convert.ToByte(0xC7));
                            break;
                        };
                    case 'N':
                        {
                            bw.Write(Convert.ToByte(0xC8));
                            break;
                        };
                    case 'O':
                        {
                            bw.Write(Convert.ToByte(0xC9));
                            break;
                        };
                    case 'P':
                        {
                            bw.Write(Convert.ToByte(0xCA));
                            break;
                        };
                    case 'Q':
                        {
                            bw.Write(Convert.ToByte(0xCB));
                            break;
                        };
                    case 'R':
                        {
                            bw.Write(Convert.ToByte(0xCC));
                            break;
                        };
                    case 'S':
                        {
                            bw.Write(Convert.ToByte(0xCD));
                            break;
                        };
                    case 'T':
                        {
                            bw.Write(Convert.ToByte(0xCE));
                            break;
                        };
                    case 'U':
                        {
                            bw.Write(Convert.ToByte(0xCF));
                            break;
                        };
                    case 'V':
                        {
                            bw.Write(Convert.ToByte(0xD0));
                            break;
                        };
                    case 'W':
                        {
                            bw.Write(Convert.ToByte(0xD1));
                            break;
                        };
                    case 'X':
                        {
                            bw.Write(Convert.ToByte(0xD2));
                            break;
                        };
                    case 'Y':
                        {
                            bw.Write(Convert.ToByte(0xD3));
                            break;
                        };
                    case 'Z':
                        {
                            bw.Write(Convert.ToByte(0xD4));
                            break;
                        };
                    case 'a':
                        {
                            bw.Write(Convert.ToByte(0xD5));
                            break;
                        };
                    case 'b':
                        {
                            bw.Write(Convert.ToByte(0xD6));
                            break;
                        };
                    case 'c':
                        {
                            bw.Write(Convert.ToByte(0xD7));
                            break;
                        };
                    case 'd':
                        {
                            bw.Write(Convert.ToByte(0xD8));
                            break;
                        };
                    case 'e':
                        {
                            bw.Write(Convert.ToByte(0xD9));
                            break;
                        };
                    case 'f':
                        {
                            bw.Write(Convert.ToByte(0xDA));
                            break;
                        };
                    case 'g':
                        {
                            bw.Write(Convert.ToByte(0xDB));
                            break;
                        };
                    case 'h':
                        {
                            bw.Write(Convert.ToByte(0xDC));
                            break;
                        };
                    case 'i':
                        {
                            bw.Write(Convert.ToByte(0xDD));
                            break;
                        };
                    case 'j':
                        {
                            bw.Write(Convert.ToByte(0xDE));
                            break;
                        };
                    case 'k':
                        {
                            bw.Write(Convert.ToByte(0xDF));
                            break;
                        };
                    case 'l':
                        {
                            bw.Write(Convert.ToByte(0xE0));
                            break;
                        };
                    case 'm':
                        {
                            bw.Write(Convert.ToByte(0xE1));
                            break;
                        };
                    case 'n':
                        {
                            bw.Write(Convert.ToByte(0xE2));
                            break;
                        };
                    case 'o':
                        {
                            bw.Write(Convert.ToByte(0xE3));
                            break;
                        };
                    case 'p':
                        {
                            bw.Write(Convert.ToByte(0xE4));
                            break;
                        };
                    case 'q':
                        {
                            bw.Write(Convert.ToByte(0xE5));
                            break;
                        };
                    case 'r':
                        {
                            bw.Write(Convert.ToByte(0xE6));
                            break;
                        };
                    case 's':
                        {
                            bw.Write(Convert.ToByte(0xE7));
                            break;
                        };
                    case 't':
                        {
                            bw.Write(Convert.ToByte(0xE8));
                            break;
                        };
                    case 'u':
                        {
                            bw.Write(Convert.ToByte(0xE9));
                            break;
                        };
                    case 'v':
                        {
                            bw.Write(Convert.ToByte(0xEA));
                            break;
                        };
                    case 'w':
                        {
                            bw.Write(Convert.ToByte(0xEB));
                            break;
                        };
                    case 'x':
                        {
                            bw.Write(Convert.ToByte(0xEC));
                            break;
                        };
                    case 'y':
                        {
                            bw.Write(Convert.ToByte(0xED));
                            break;
                        };
                    case 'z':
                        {
                            bw.Write(Convert.ToByte(0xEE));
                            break;
                        };
                    case ':':
                        {
                            bw.Write(Convert.ToByte(0xF0));
                            break;
                        };
                    case 'Ä':
                        {
                            bw.Write(Convert.ToByte(0xF1));
                            break;
                        };
                    case 'Ö':
                        {
                            bw.Write(Convert.ToByte(0xF2));
                            break;
                        };
                    case 'Ü':
                        {
                            bw.Write(Convert.ToByte(0xF3));
                            break;
                        };
                    case 'ä':
                        {
                            bw.Write(Convert.ToByte(0xF4));
                            break;
                        };
                    case 'ö':
                        {
                            bw.Write(Convert.ToByte(0xF5));
                            break;
                        };
                    case 'ü':
                        {
                            bw.Write(Convert.ToByte(0xF6));
                            break;
                        };
                }
                if (description[i] == '\\' && i < description.Length - 1)
                {
                    switch (description[i + 1])
                    {
                        case 'e':
                            {
                                bw.Write(Convert.ToByte(0x1B));
                                description.Remove(i, 1);
                                break;
                            };
                        case 'l':
                            {
                                bw.Write(Convert.ToByte(0xFA));
                                description.Remove(i, 1);
                                break;
                            };
                        case 'p':
                            {
                                bw.Write(Convert.ToByte(0xFB));
                                description.Remove(i, 1);
                                break;
                            };
                        case 'c':
                            {
                                bw.Write(Convert.ToByte(0xFC));
                                description.Remove(i, 1);
                                break;
                            };
                        case 'v':
                            {
                                bw.Write(Convert.ToByte(0xFD));
                                description.Remove(i, 1);
                                break;
                            };
                        case 'n':
                            {
                                bw.Write(Convert.ToByte(0xFE));
                                description.Remove(i, 1);
                                break;
                            };
                        case 'x':
                            {
                                bw.Write(Convert.ToByte(0xFF));
                                description.Remove(i, 1);
                                break;
                            };
                        default:
                            {
                                break;
                            };
                    }
                }
                else if (description[i] == '[' && i < description.Length - 2)
                {
                    string block = "";
                    int n = 1;
                    if (i + n < description.Length)
                    {
                        while (description[i + n] != ']' && n < 4 && i + n < description.Length - 1)
                        {
                            block += description[i + n];
                            n++;
                        }

                        switch (block)
                        {
                            case "Lv":
                                {
                                    bw.Write(Convert.ToByte(0x34));
                                    description.Remove(i + 1, 3);
                                    break;
                                }
                            case "pk":
                                {
                                    bw.Write(Convert.ToByte(0x53));
                                    description.Remove(i + 1, 3);
                                    break;
                                }
                            case "mn":
                                {
                                    bw.Write(Convert.ToByte(0x54));
                                    description.Remove(i + 1, 3);
                                    break;
                                }
                            case "po":
                                {
                                    bw.Write(Convert.ToByte(0x55));
                                    description.Remove(i + 1, 3);
                                    break;
                                }
                            case "ké":
                                {
                                    bw.Write(Convert.ToByte(0x56));
                                    description.Remove(i + 1, 3);
                                    break;
                                }
                            case "bl":
                                {
                                    bw.Write(Convert.ToByte(0x57));
                                    description.Remove(i + 1, 3);
                                    break;
                                }
                            case "oc":
                                {
                                    bw.Write(Convert.ToByte(0x58));
                                    description.Remove(i + 1, 3);
                                    break;
                                }
                            case "k":
                                {
                                    bw.Write(Convert.ToByte(0x59));
                                    description.Remove(i + 1, 2);
                                    break;
                                }
                            case "U":
                                {
                                    bw.Write(Convert.ToByte(0x79));
                                    description.Remove(i + 1, 2);
                                    break;
                                }
                            case "D":
                                {
                                    bw.Write(Convert.ToByte(0x7A));
                                    description.Remove(i + 1, 2);
                                    break;
                                }
                            case "L":
                                {
                                    bw.Write(Convert.ToByte(0x7B));
                                    description.Remove(i + 1, 2);
                                    break;
                                }
                            case "R":
                                {
                                    bw.Write(Convert.ToByte(0x7C));
                                    description.Remove(i + 1, 2);
                                    break;
                                }
                            case ".":
                                {
                                    bw.Write(Convert.ToByte(0xB0));
                                    description.Remove(i + 1, 2);
                                    break;
                                }

                            case "\"":
                                {
                                    bw.Write(Convert.ToByte(0xB1));
                                    description.Remove(i + 1, 2);
                                    break;
                                }
                            case "'":
                                {
                                    bw.Write(Convert.ToByte(0xB3));
                                    description.Remove(i + 1, 2);
                                    break;
                                }
                            case "m":
                                {
                                    bw.Write(Convert.ToByte(0xB5));
                                    description.Remove(i + 1, 2);
                                    break;
                                }
                            case "f":
                                {
                                    bw.Write(Convert.ToByte(0xB6));
                                    description.Remove(i + 1, 2);
                                    break;
                                }
                            case "$":
                                {
                                    bw.Write(Convert.ToByte(0xB7));
                                    description.Remove(i + 1, 2);
                                    break;
                                }
                            case "x":
                                {
                                    bw.Write(Convert.ToByte(0xB9));
                                    description.Remove(i + 1, 2);
                                    break;
                                }
                            case ">":
                                {
                                    bw.Write(Convert.ToByte(0xEF));
                                    description.Remove(i + 1, 2);
                                    break;
                                }
                            case "u":
                                {
                                    bw.Write(Convert.ToByte(0xF7));
                                    description.Remove(i + 1, 2);
                                    break;
                                }
                            case "d":
                                {
                                    bw.Write(Convert.ToByte(0xF8));
                                    description.Remove(i + 1, 2);
                                    break;
                                }
                            case "l":
                                {
                                    bw.Write(Convert.ToByte(0xF9));
                                    description.Remove(i + 1, 2);
                                    break;
                                }
                            default:
                                break;
                        }
                    }
                }
                #endregion

            }
            bw.Write(Convert.ToByte(0xFF));
            bw.Close();
        }
        //figures out the length of text in game bytes
        public int GetLength(string text)
        {
            int CurrentDesc = 0;
            StringBuilder desc = new StringBuilder(text);
            for (int i = 0; i < desc.Length; i++)
            {
                if (desc[i] == '\\' && i < desc.Length - 1)
                {
                    switch (desc[i + 1])
                    {

                        case 'p':
                            {
                                CurrentDesc++;
                                desc.Remove(i, 1);
                                break;
                            };
                        case 'c':
                            {
                                CurrentDesc++;
                                desc.Remove(i, 1);
                                break;
                            };
                        case 'v':
                            {
                                CurrentDesc++;
                                desc.Remove(i, 1);
                                break;
                            };
                        case 'x':
                            {
                                CurrentDesc++;
                                desc.Remove(i, 1);
                                break;
                            };
                        case 'n':
                            {
                                CurrentDesc++;
                                desc.Remove(i, 1);
                                break;
                            };
                        case 'l':
                            {
                                CurrentDesc++;
                                desc.Remove(i, 1);
                                break;
                            };
                        case 'e':
                            {
                                CurrentDesc++;
                                desc.Remove(i, 1);
                                break;
                            };
                        default:
                            {
                                break;
                            };
                    }
                }
                else if (desc[i] == '[' && i < desc.Length - 2)
                {
                    string block = "";
                    int n = 1;
                    if (i + n < desc.Length)
                    {
                        while (desc[i + n] != ']' && n < 4 && i + n < desc.Length - 1)
                        {
                            block += desc[i + n];
                            n++;
                        }

                        switch (block)
                        {
                            case ".":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                            case "Lv":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 3);
                                    break;
                                }
                            case "pk":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 3);
                                    break;
                                }
                            case "mn":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 3);
                                    break;
                                }
                            case "po":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 3);
                                    break;
                                }

                            case "ké":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 3);
                                    break;
                                }
                            case "bl":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 3);
                                    break;
                                }
                            case "oc":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 3);
                                    break;
                                }
                            case "k":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                            case "\"":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                            case "U":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                            case "D":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                            case "L":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                            case "R":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                            case "'":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                            case "m":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                            case "f":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                            case "$":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                            case "x":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                            case ">":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                            case "u":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                            case "d":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                            case "l":
                                {
                                    CurrentDesc++;
                                    desc.Remove(i + 1, 2);
                                    break;
                                }
                        }

                    }
                }
                else if (desc[i] == ']')
                {
                }
                else
                {
                    CurrentDesc++;
                }
            }

            return CurrentDesc;
        }
        //turns text into poke text for displaying
        public string Translate(string input)
        {
            StringBuilder conversion = new StringBuilder(input);
            for (int i = 0; i < conversion.Length; i++)
            {
                if (conversion[i] == '\\' && i < conversion.Length - 1)
                {
                    switch (conversion[i + 1])
                    {
                        case 'n':
                            {
                                conversion[i + 1] = (char)10;
                                conversion.Remove(i, 1);
                                break;
                            };
                        case 'l':
                            {
                                conversion[i + 1] = (char)10;
                                conversion.Remove(i, 1);
                                break;
                            };
                        case 'e':
                            {
                                conversion[i + 1] = 'é';
                                conversion.Remove(i, 1);
                                break;
                            };
                        default:
                            {
                                break;
                            };
                    }
                }
                else if (conversion[i] == '[' && i < conversion.Length - 2)
                {
                    string block = "";
                    int n = 1;
                    if (i + n < conversion.Length)
                    {
                        while (conversion[i + n] != ']' && n < 4 && i + n < conversion.Length - 1)
                        {
                            block += conversion[i + n];
                            n++;
                        }

                        switch (block)
                        {
                            case ".":
                                {
                                    conversion[i] = '.';
                                    conversion[i + 1] = '.';
                                    conversion[i + 2] = '.';
                                    break;
                                }
                            case "Lv":
                                {
                                    conversion[i] = 'L';
                                    conversion[i + 1] = 'V';
                                    conversion.Remove(i + 2, 2);
                                    break;
                                }
                            case "pk":
                                {
                                    conversion[i] = 'P';
                                    conversion[i + 1] = 'K';
                                    conversion.Remove(i + 2, 2);
                                    break;
                                }
                            case "mn":
                                {
                                    conversion[i] = 'M';
                                    conversion[i + 1] = 'N';
                                    conversion.Remove(i + 2, 2);
                                    break;
                                }
                            case "po":
                                {
                                    conversion[i] = 'P';
                                    conversion[i + 1] = 'O';
                                    conversion.Remove(i + 2, 2);
                                    break;
                                }

                            case "ké":
                                {
                                    conversion[i] = 'K';
                                    conversion[i + 1] = 'é';
                                    conversion.Remove(i + 2, 2);
                                    break;
                                }
                            case "bl":
                                {
                                    conversion[i] = 'B';
                                    conversion[i + 1] = 'L';
                                    conversion.Remove(i + 2, 2);
                                    break;
                                }
                            case "oc":
                                {
                                    conversion[i] = 'O';
                                    conversion[i + 1] = 'C';
                                    conversion.Remove(i + 2, 2);
                                    break;
                                }
                            case "k":
                                {
                                    conversion[i] = 'K';
                                    conversion.Remove(i + 1, 2);
                                    break;
                                }
                            case "\"\"":
                                {
                                    conversion[i] = '\"';
                                    conversion.Remove(i + 1, 3);
                                    break;
                                }
                            default:
                                break;
                        }
                    }
                }


            }

            return conversion.ToString();
        }


        //swaps the bytes in an offset
        public string HexSwap(string offset)
        {
            string B1 = "";
            string B2 = "";
            string B3 = "";
            string B4 = "";

            if (offset.Length == 8)
            {
                B1 = offset[6].ToString() + offset[7].ToString();
                B2 = offset[4].ToString() + offset[5].ToString();
                B3 = offset[2].ToString() + offset[3].ToString();
                B4 = offset[0].ToString() + offset[1].ToString();
                offset = B1 + B2 + B3 + B4;

            }
            else if (offset.Length <= 6)
            {
                while (offset.Length < 6)
                {
                    offset = "0" + offset;
                }
                B1 = offset[4].ToString() + offset[5].ToString();
                B2 = offset[2].ToString() + offset[3].ToString();
                B3 = offset[0].ToString() + offset[1].ToString();
                offset = B1 + B2 + B3;

            }

            return offset;
        }
        public byte HexSwap(int pair, string offset)
        {
            string B1 = "";
            string B2 = "";
            string B3 = "";
            string B4 = "";

            if (offset.Length == 8)
            {
                B1 = offset[6].ToString() + offset[7].ToString();
                B2 = offset[4].ToString() + offset[5].ToString();
                B3 = offset[2].ToString() + offset[3].ToString();
                B4 = offset[0].ToString() + offset[1].ToString();
            }
            else if (offset.Length <= 6)
            {
                while (offset.Length < 6)
                {
                    offset = "0" + offset;
                }
                B1 = offset[4].ToString() + offset[5].ToString();
                B2 = offset[2].ToString() + offset[3].ToString();
                B3 = offset[0].ToString() + offset[1].ToString();
            }
            string test = B3 + B2 + B1;
            if (Convert.ToInt32(test, 16) > 0xFFFF20)
            {
                B3 = "FF";
                B2 = "FF";
                B1 = "20";
            }

            if (pair == 0)
            {
                return Convert.ToByte(Convert.ToInt32(B1, 16));
            }
            else if (pair == 1)
            {
                return Convert.ToByte(Convert.ToInt32(B2, 16));
            }
            else if (pair == 2)
            {
                return Convert.ToByte(Convert.ToInt32(B3, 16));
            }
            else if (pair == 3)
            {
                return Convert.ToByte(Convert.ToInt32(B4, 16));
            }
            else
            {
                return Convert.ToByte(0);
            }
        }

        //finds free space
        public int FreeSpace(int search, OpenFileDialog ofd)
        {
            if (search < 5)
            {
                search = 5;
            }
            BinaryReader br = new BinaryReader(File.OpenRead(ofd.FileName));
            br.BaseStream.Position = 0x71A240;
            int count = 0;
            int offset = 0x71A240;
            while (count < search)
            {
                int test = br.ReadByte();
                if (test == 0xFF)
                {
                    count++;
                }
                else
                {
                    count = 0;
                    offset = (int)br.BaseStream.Position;
                }
            }
            br.Close();
            return offset + 2;
        }
        public int FreeSpace(string start, int search, OpenFileDialog ofd)
        {
            if (search < 5)
            {
                search = 5;
            }
            int count = 0;
            int offset = Convert.ToInt32(start, 16);
            BinaryReader br = new BinaryReader(File.OpenRead(ofd.FileName));
            br.BaseStream.Position = offset;

            while (count < search)
            {
                if (br.BaseStream.Position < 16777215)
                {
                    int test = br.ReadByte();
                    if (test == 0xFF)
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                        offset = (int)br.BaseStream.Position;
                    }
                }
                else
                {
                    break;
                }
            }
            br.Close();
            if (count < search)
            {
                offset = -2;
            }

            return offset + 2;
        }

        //converts 16 bit colors to 32 bit colors
        public Int32 c16To32(UInt16 color)
        {
            Int32 red = (Int32)(((color >> 0xA) & 0x1F) * 8.225806f);
            Int32 green = (Int32)(((color >> 0x5) & 0x1F) * 8.225806f);
            Int32 blue = (Int32)((color & 0x1F) * 8.225806f);

            if (red < 0)
                red = 0;
            else if (red > 0xFF)
                red = 0xFF;

            if (green < 0)
                green = 0;
            else if (green > 0xFF)
                green = 255;

            if (blue < 0)
                blue = 0;
            else if (blue > 0xFF)
                blue = 0xFF;

            return ((red << 0x10) | (green << 0x8) | blue);
        }
        //converts 32 bit colors to 16 bit colors
        public UInt16 c32To16(Int32 color)
        {
            string Color = color.ToString("X");
            string B1 = HexSwap(0, Color).ToString("X");
            string B2 = HexSwap(1, Color).ToString("X");
            string B3 = HexSwap(2, Color).ToString("X");

            B1 = Convert.ToString((Convert.ToInt16((Convert.ToDouble(Convert.ToInt32(B1, 16)) / 256) * 32)), 2);
            B2 = Convert.ToString((Convert.ToInt16((Convert.ToDouble(Convert.ToInt32(B2, 16)) / 256) * 32)), 2);
            B3 = Convert.ToString((Convert.ToInt16((Convert.ToDouble(Convert.ToInt32(B3, 16)) / 256) * 32)), 2);
            if (B1.Length > 5)
            {
                B1 = "11111";
            }
            while (B1.Length < 5)
            {
                B1 = "0" + B1;
            }
            if (B2.Length > 5)
            {
                B2 = "11111";
            }
            while (B2.Length < 5)
            {
                B2 = "0" + B2;
            }
            if (B3.Length > 5)
            {
                B3 = "11111";
            }
            while (B3.Length < 5)
            {
                B3 = "0" + B3;
            }


            string Binary = "0" + B1 + B2 + B3;
            UInt16 send = Convert.ToUInt16(Binary, 2);
            return send;
        }

        //On KeyPress, only press numbers
        public void NumOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //On KeyPress, only press hex digits
        public void HexOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar) && e.KeyChar != 'a' && e.KeyChar != 'b' && e.KeyChar != 'c' && e.KeyChar != 'd' && e.KeyChar != 'e' && e.KeyChar != 'f' && e.KeyChar != 'A' && e.KeyChar != 'B' && e.KeyChar != 'C' && e.KeyChar != 'D' && e.KeyChar != 'E' && e.KeyChar != 'F'))
            {
                e.Handled = true;
            }
        }
        //On Leave, empty TextBoxes get "0"
        public void txtEmpty_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == "")
                txt.Text = "0";
        }
    }
}
