using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace ScriptBuilder
{
    public partial class Form1 : Form
    {
        bool unsavedChangesExist = false;
        public string topLevelTag = "production";
        string tmText;
        string tmData;
        string tmName = "";
        string searchTextStart = "<para>";
        string searchTextEnd = "</para>";
        ArrayList paraList = new ArrayList();
        List<List<string>> tagList = new List<List<string>>();

        Formatting Frm = new Formatting();
        DataManipulation Dm = new DataManipulation();
        FormManipulation Fm = new FormManipulation();

        public Form1()
        {
            InitializeComponent();
        }

        // Replaces specified data from a listbox
        public void CleanList(ListBox list, string stringToFind, string stringToReplace)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                string value = list.Items[i].ToString();
                while (value.IndexOf(stringToFind) != -1)
                {
                    var strbldr = new StringBuilder(value);
                    strbldr.Remove(value.IndexOf(stringToFind), (stringToFind.Length));
                    strbldr.Insert(value.IndexOf(stringToFind), stringToReplace);
                    value = strbldr.ToString();

                    list.Items[i] = value;
                }
            }
        }

        //Combines two character lists and 
        public void MakeParaList(List<int> startListing, List<int> endListing)
        {
            lbxParaList.Items.Clear();
            paraList.Clear();

            // check to see if two lists are same size to confirm that
            // there's an equal number of opening tags and closing tags
            if (startListing.Count == endListing.Count) 
            {
                for (int i = 0; i < startListing.Count; i++)
                {
                    paraList.Add(startListing[i].ToString());   // adds opeing tag position to list
                    paraList.Add(endListing[i].ToString());     // followed by it's closing tag position
                }
            }
            else
            {
                MessageBox.Show("There may be a problem in the document. Please check the imported file for coding errors", "Error!");
            }
        }

        private void TMWPsplitter(string source, string tag)
        {

            int TagPosition = Dm.GetStartPosition(source, "<" + tag);
            int ClosingTagPosition;
            string ClosingTag;

            if (TagPosition != -1)
            {
                ClosingTag = "</" + tag + ">";
                ClosingTagPosition = Dm.GetStartPosition(source, ClosingTag);
            }
            else
            {
                MessageBox.Show("Error!");
            }

            // ▲ ▼ ◄ ►
        }

        // adds the extracted data to a list and formats it for readability
        private void UpdateListBox(string source)
        {
            if (source == "" || source == null)
            {
                //MessageBox.Show("Please import a source document.", "Warning:");
            }
            else
            {
                List<int> startList = Dm.GetStartPositions(source, searchTextStart);
                List<int> endList = Dm.GetEndPositions(source, searchTextEnd);
                source = Regex.Replace(source, "<figure.*?/figure>", "", RegexOptions.Singleline);
                MakeParaList(startList, endList);

                for (int i = 0; i < paraList.Count; i += 2)
                {
                    string nextPara = Dm.CaptureTextBetween(source, Convert.ToInt32(paraList[i]), Convert.ToInt32(paraList[i + 1]));
                    if (nextPara.Trim().Length > 0)
                    {
                        lbxParaList.Items.Add(nextPara.Trim());
                    }
                }

                CleanList(lbxParaList, "&deg;", "degrees ");
                CleanList(lbxParaList, "&rsquo;", "'");
                CleanList(lbxParaList, "&ldquo;", "'");
                CleanList(lbxParaList, "&amp;", "&");
                CleanList(lbxParaList, "&dash;", "-");
                CleanList(lbxParaList, "extref", "");
                CleanList(lbxParaList, "docno=", "");
                CleanList(lbxParaList, "<para>", "");
                CleanList(lbxParaList, "</para>", "");
                CleanList(lbxParaList, "<warning>", "Warning: ");
                CleanList(lbxParaList, "<caution>", "Caution: ");
                CleanList(lbxParaList, "<note>", "Note: ");
                CleanList(lbxParaList, "</warning>", "");
                CleanList(lbxParaList, "</caution>", "");
                CleanList(lbxParaList, "</note>", "");
                CleanList(lbxParaList, "<specpara>", "");
                CleanList(lbxParaList, "</specpara>", "");
                CleanList(lbxParaList, "<trim.para>", "");
                CleanList(lbxParaList, "</trim.para>", "");
                CleanList(lbxParaList, "<internet>", "");
                CleanList(lbxParaList, "</internet>", "");
                CleanList(lbxParaList, "</internet", "");
                CleanList(lbxParaList, "<homepage uri=", "");
                CleanList(lbxParaList, "<internet show.address=\"yes\">", "");
                CleanList(lbxParaList, "<homepage protocol=\"https\" uri=", "");
                CleanList(lbxParaList, "<", "");
                CleanList(lbxParaList, "/>", "");
                CleanList(lbxParaList, ">", "");
                CleanList(lbxParaList, "\" \",", ", ");
                CleanList(lbxParaList, "()", "");
                CleanList(lbxParaList, "( )", "");
                CleanList(lbxParaList, "(and)", "");
                CleanList(lbxParaList, "( and )", "");
                CleanList(lbxParaList, " .", ".");
                CleanList(lbxParaList, " ,", ",");
            }
        }

        private void ImportTMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportTM();
        }

        // Imports a source document and pre-formats some things to remove data that is unneeded or problematic
        public void ImportTM()
        {
            // User browses to folder and selects TM file for import
            OpenFileDialog fileSelected = new OpenFileDialog();
            fileSelected.Filter = "XML Files (*.xml)|*.xml|SGML Files (*.sgml)|*.sgml|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            fileSelected.Multiselect = false;

            if (fileSelected.ShowDialog() == DialogResult.OK)
            {
                string importedFileName = fileSelected.FileName;
                lblImportedTM.Text = "Imported File: " + importedFileName;

                // Add all text from selected file to tmText varaible
                tmText = File.ReadAllText(fileSelected.FileName);

                tmName = Dm.ExtractData(tmText, "<tmno>", "</tmno>");
                gbxWorkArea.Text = "IMI Script Workspace for " + tmName + ":";
                tmText = Dm.ExtractScriptData(tmText);

                unsavedChangesExist = true;
            }
            tagList.Clear();
            InitializeSturctureList();
            //UpdateListBox(tmText);
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To do:
            // Make open project handling for projects in progress
        }

        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To do:
            // Make save project handling for projects in progress
        }

        // close application
        private void CloseApplication()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to close application?", "Close Application?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                // do nothing
            }
        }

        public void InitializeSturctureList()
        {
            tmData = Frm.GetDataFrom(tmText, "production");
            SetDefaultListState(tmData);
        }

        private void SetDefaultListState(string tmData)
        {
            string  tagName = Frm.FindFirstOpeningTag(tmData);
            string formattedTag = "[ + ] " + makeOpenTag(tagName) + "..." + makeCloseTag(tagName);
            string  expansionState = "collapsed";
            string  innerData = Frm.GetDataFrom(tmData, tagName);

            tagList.Add(new List<string> { tagName, expansionState, innerData });
            UpdateStructure();

            //cbxlstStructure.Items.Add(new List<string> { tagName, expansionState, dataInside });

            //tagList.Add(new List<string> { TagName, expandable.ToString(), expanded.ToString(), "1" });
            //cbxlstStructure.Items.Add(tagList[0][0] + ">");
        }

        private void UpdateStructure()
        {
            cbxlstStructure.Items.Clear();
            for (int i = 0; i < tagList.Count; i++)
            {
                cbxlstStructure.Items.Add("<" + tagList[i][0] + ">");
            }
        }

        private string makeOpenTag(string tagName)
        {
            tagName = "<" + tagName + ">";
            return tagName;
        }

        private string makeCloseTag(string tagName)
        {
            tagName = "</" + tagName + ">";
            return tagName;
        }

        private void ExportScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To do:
            // Make export script handling for projects in progress
        }

        private void PreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // To do:
            // Make program preferences handling for current project
        }

        //launch the 'about' pop-up form
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        // close application after checking to see if there are unsaved changes to project, and user confirmation
        private void CloseProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check to see if project has been saved
            if (unsavedChangesExist == true)
            {
                // Warn user if project isn't saved and prompt user to save
                DialogResult dialogResult = MessageBox.Show("There are unsaved changes to this project. Save before closing?", "Save Project?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Save changes to project
                    unsavedChangesExist = false;
                    CloseApplication();

                }
                else if (dialogResult == DialogResult.No)
                {
                    CloseApplication();
                }
            }
            else
            {
                CloseApplication();
            }
        }

        private void LbxParaList_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("double clicked para: \n" + lbxParaList.GetItemText(lbxParaList.SelectedItem));
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            ImportTM();
        }

        private void BtnViewSource_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(tmText);
            f3.ShowDialog();
        }

        private void SetTopLevelTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTopLevelTag setTag = new setTopLevelTag(topLevelTag);
            setTag.ShowDialog();
        }

        private void cbxlstStructure_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int clickedItem = cbxlstStructure.SelectedIndex;
            if (clickedItem < 0)
            {
                clickedItem = 0;
            }

            // check to see if the selected list item is expandable
            if(tagList[clickedItem][1] == "collapsed")
            {
                rtbTest.Text = "EXPANDED...";
                tagList[clickedItem][1] = "expanded";
                // find the innerData inside the tag clicked
                string innerData = tagList[clickedItem][2];
                // find the next top-level tag within the inner data
                string tagName = Frm.FindFirstOpeningTag(innerData);
                int splitPosition = Dm.GetEndPosition(innerData, "</" + tagName + ">");
                // get new inner data from within the next top level tag
                string newInnerData = Frm.GetDataFrom(innerData, tagName);
                //
            }
            else if (tagList[clickedItem][1] == "expanded")
            {
                rtbTest.Text = "COLLAPSED...";
                tagList[clickedItem][1] = "collapsed";
            }
            else
            {
                //nothing
            }

            //

                /*
                if (clickedItem.expansionState == "non-expandable")
                {
                    //Do nothing
                }

                if (clickedItem.expansionState == "expanded")
                {
                    //collapseItem();
                }

                if (clickedItem.expansionState == "collapsed")
                {
                    //expandItem();
                }
                */

                /*
                 * List item is clicked
                 * 1. check item's expansion state (expanded, collapsed, non-expandable).
                 *  a. if item is non-expandable, do nothing
                 *  b. if item is expanded, collapseItem(); - step 2.
                 *  c. if item is collapsed, expandItem();
                 *  
                 * 2. (Collapse) find index of closing tag at same level.
                 * 3. Delete tags between opening and closing indexes.
                 * 
                 * 
                 * 
                 * /

                //MessageBox.Show(e.ToString(), sender.ToString());

                // Gets the text from the list-item that was dbl. clicked
                string text = cbxlstStructure.SelectedIndex.ToString();
                // Sees if string data from inside the tag clicked contains any child level tags
                string nextTag = Frm.FindFirstOpeningTag(Convert.ToString(tagList[cbxlstStructure.SelectedIndex][2]));

                if (nextTag != "")
                {
                    if (text[1].ToString() != "/")
                    {
                        // strips away the tag formatting from the string
                        text = Dm.CaptureTextBetween(text, 1, text.Length - 1);

                        //formats the string tags for search and capture of contained string data
                        string openTag = "<" + text;
                        string closeTag = "</" + text + ">";

                        cbxlstStructure.Items.Add(closeTag);
                    }
                }
            }

            private void FindAllChildTags(string source, string tag)
            {

            }


            /*
                     private void cbxlstStructure_DoubleClick(object sender, EventArgs e)
            {
                // Gets the text from the list-item that was dbl. clicked
                string text = cbxlstStructure.Items[cbxlstStructure.SelectedIndex].ToString();

                // strips away the tag formatting from the string
                text = captureTextBetween(text, 1, text.Length - 1);

                //formats the string tags for search and capture of contained string data
                string openTag = "<" + text;
                string closeTag = "</" + text + ">";

                //Get string data between opening and closing tags
                string source = ExtractData(tmText, openTag, closeTag);

                // looks for all child tags (at the next lower level) contained in the extracted string data.
                FindAllChildTags(source, closeTag);

                //text = FindTopLevelTag(tmText, text);
                //MessageBox.Show(openTag + ">..." + closeTag);
                //UpdateListBox(source);
            }

            private void FindAllChildTags(string source, string tag)
            {
                string sourceText = source;
                string childTag = string.Empty;
                string open = string.Empty;
                string close = string.Empty;
                int start = GetStartPosition(sourceText, "<");

                while (GetStartPosition(sourceText, "<") >= 0)
                    {

                    // find the first(or next) opening tag
                    for (int i = start; i < sourceText.Length; i++)
                        {
                            if (sourceText[i].ToString() == ">" || sourceText[i].ToString() == " ")
                            {
                                open = MakeOpenTag(childTag);
                                close = MakeCloseTag(childTag);
                                sourceText = ExtractData(sourceText, open, close);
                                start = GetStartPosition(sourceText, "<");
                                break;
                            }
                            else
                            {
                                childTag += sourceText[i];
                            }
                        }
                    // based on opening tag, find closing tag
                    // add that open/close tag to the list
                    // set startingpos to the position of the closing tag


                    // redefine the searchable text to be what is contained between 
                    // the end of the previous closing tag and the end of the entire string
                    //text = captureTextBetween(text, getstpos, text.Length);


                    cbxlstStructure.Items.Add(open + ">");
                    open = "";
                    close = "";
                    childTag = "";
                }*/
        }
    }
}

