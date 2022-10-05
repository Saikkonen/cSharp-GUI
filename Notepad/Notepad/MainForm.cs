using System;
using System.IO;
using System.Windows.Forms;

namespace Notepad
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private String EditorFileName = "Untitled";

        private void SetFormTitleText()
        {
            // Tiedoston nimi formiin. 

            FileInfo fileinfo = new FileInfo(EditorFileName);

            Text = fileinfo.Name + " - Editor";
        }

        private void ReadFile()
        {
            try
            {
                // Luodaan StreamReader objekti ja luetaan tiedosto. 

                using (StreamReader Reader = new StreamReader(EditorFileName))
                {
                    // Luku 

                    richTextBox1.Clear();

                    richTextBox1.Text = Reader.ReadToEnd();
                }
            }

            catch (IOException ex)

            {
                MessageBox.Show("Error: " + ex.Message, "Open File",

                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SaveFile()
        {
            try
            {
                // Luodaan SteramWriter objekti ja kirjoitetaan teksti tiedostoon. 

                using (StreamWriter StrWriter = new StreamWriter(EditorFileName))
                {
                    // Kirjoitus 

                    StrWriter.Write(richTextBox1.Text);
                }
            }

            catch (IOException ex)

            {
                MessageBox.Show("Error: " + ex.Message, "Save File",

                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void MenuFileNew_Click(object sender, EventArgs e)
        {
            EditorFileName = "Untitled";

            richTextBox1.Clear();

            SetFormTitleText();
        }

        private void MenuFileOpen_Click(object sender, EventArgs e)
        {
            // Luodaan standardi avausdialogiobjekti ja alustetaan se. 

            OpenFileDialog OpenFileDlg = new OpenFileDialog();

            OpenFileDlg.Title = "Open";

            OpenFileDlg.ShowReadOnly = true;

            OpenFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*";


            // Avataan windowsin standardi avausdialogi. 

            if (OpenFileDlg.ShowDialog() == DialogResult.OK)
            {
                // Talletetaan tiedoston nimi ja polku lukemista varten. 

                EditorFileName = OpenFileDlg.FileName;

                // Luetaan tiedosotn sisältö ja tuodaan se näytölle. 

                ReadFile();
                SetFormTitleText();
            }
        }

        private void MenuFileSave_Click(object sender, EventArgs e)
        {
            if (EditorFileName == "Untitled")
            {
                MenuFileSaveAs_Click(sender, e);
            }
            else
            {
                SaveFile();
            }
        }

        private void MenuFileSaveAs_Click(object sender, EventArgs e)
        {
            // Luodaan standardi talletusdialogiobjekti ja alustetaan se. 

            SaveFileDialog SaveFileDlg = new SaveFileDialog();

            SaveFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*";


            // Avataan windowsin standardi talletusdialogi. 

            if (SaveFileDlg.ShowDialog() == DialogResult.OK)
            {
                // Talletetaan tiedoston nimi ja polku talletusta varten. 

                EditorFileName = SaveFileDlg.FileName;

                SaveFile();
                SetFormTitleText();
            }
        }

        private void MenuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}