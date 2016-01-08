using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace NoteBook
{
    public partial class NoteBook : Form
    {
        public static List<Note> AllNotes = new List<Note>();
        public static List<string> NumberTypes = new List<string>();
        public static string[] Leters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public static Note OneNote = new Note();

        public NoteBook()
        {
            InitializeComponent();
            Notes.DefaultCellStyle.Font = new Font("Tahoma", 13);
            SearchBox.Font=new Font("",14);
            
        }

        private void NoteBook_Load(object sender, EventArgs e)
        {

            NumberBox.Visible = false;

            try
            {
                using (var reader = new StreamReader("Notes.xml"))
                {
                    var deserializer = new XmlSerializer(typeof(List<Note>), new XmlRootAttribute("XmlSave"));
                    AllNotes = (List<Note>)deserializer.Deserialize(reader);
                    ChangeDataGridView();
                }
            }
            catch (Exception)
            {
                // ignored
            }

            try
            {
                using (var reader = new StreamReader("NumberType.xml"))
                {
                    var deserializer = new XmlSerializer(typeof(List<String>), new XmlRootAttribute("XmlSave"));
                    NumberTypes = (List<string>)deserializer.Deserialize(reader);
                    foreach (var t in NumberTypes)
                    {
                        NumberType.Items.Add(t);
                    }
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            InfoPanel.Show();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            InfoPanel.Visible = false;
            NumberBox.Visible = false;

            OneNote.FirstName=FirstName.Text;
            OneNote.LastName = LastName.Text;
            OneNote.Patronymic = Patronymic.Text;
            OneNote.NoteDescription = NoteDescription.Text;
            if (NumberTypes.Contains(NumberType.Text) == false)
            {
                NumberTypes.Add(NumberType.Text);
            }

            if (Notes.SelectedCells.Count != 0)
            {
                Delete.PerformClick();
            }

            AllNotes.Add(OneNote);
            

            try { ChangeDataGridView(); }
            catch (Exception)
            {
                // ignored
            }
            ClearPanel();
            OneNote = new Note();
         
        }

        public void ChangeDataGridView()
        {
            Notes.Rows.Clear();

            foreach (var ch in Leters)
            {
                Notes.Rows.Add(ch);
                Notes.Rows[Notes.Rows.Count - 1].Cells[0].Style = new DataGridViewCellStyle
                {
                    ForeColor = Color.OrangeRed,
                    Font = new Font(Notes.DefaultCellStyle.Font, FontStyle.Bold)
                };
            }

            foreach (var element in AllNotes)
            {
                for (var index = 0; index < Notes.Rows.Count; index++)
                {
                    var r = Notes.Rows[index];
                    var s = r.Cells[0].Value.ToString();
                    if (s == element.LastName.ToUpper()[0].ToString())
                        Notes.Rows.Insert(r.Index + 1, element.ToString());
                }
            }
        }

        public void ClearPanel()
        {
            FirstName.Clear();
            LastName.Clear();
            Patronymic.Clear();
            PhoneNumber.Text = string.Empty;
            NoteDescription.Clear();
            NoteNumbers.Clear();
        }

        public void SaveTasks(List<Note> notes, List<string> types)
        {          
            using (var writer = new FileStream("Notes.xml", FileMode.Create))
            {
                var ser = new XmlSerializer(typeof(List<Note>), new XmlRootAttribute("XmlSave"));
                ser.Serialize(writer, notes);
            }

            using (var writer = new FileStream("NumberType.xml", FileMode.Create))
            {
                var ser = new XmlSerializer(typeof(List<string>), new XmlRootAttribute("XmlSave"));
                ser.Serialize(writer, types);
            }
        }

        private void NoteBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveTasks(AllNotes, NumberTypes);

                  
        }

        private void Notes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!Leters.Contains(Notes.CurrentCell.Value))
            {
            Delete.Visible = true;
            InfoPanel.Visible = true;

            foreach (var note in AllNotes.Where(note => (string) Notes.CurrentCell.Value == note.ToString()))
            {
                FirstName.Text = note.FirstName;
                LastName.Text = note.LastName;
                Patronymic.Text = note.Patronymic;
                NoteNumbers.Clear();              
      
                foreach (var number in note.ListNumb)
                {
                    NoteNumbers.Items.Add(number.ToString());                      
                }
                NumberBox.Visible = false;

                NoteDescription.Text = note.NoteDescription;
            }
            }
            else
            {
                Delete.Visible = false;
                InfoPanel.Visible = false;
                ClearPanel();
            }
            
           
        }

        private void Addnumber_Click(object sender, EventArgs e)
        {
            NumberBox.Visible = true;
        }

        private void Addn_Click(object sender, EventArgs e)
        {            

            if (!NumberTypes.Contains(NumberType.Text))
            {
                NumberType.Items.Add(NumberType.Text);
            }

            var newNumb = new Number
            {
                Type = NumberType.Text,
                Numb = PhoneNumber.Text
            };



            PhoneNumber.Clear();
            OneNote.ListNumb.Add(newNumb);          
            NoteNumbers.Items.Add(newNumb.ToString());

            NumberBox.Visible = false;
        }

        private void deleteNumber_Click(object sender, EventArgs e)
        {
            foreach (var note in AllNotes)
            {
                foreach (var number in note.ListNumb)
                {
                    //MessageBox.Show(NoteNumbers.SelectedItems[0].Text);
                   // MessageBox.Show(number.ToString());
                    if (NoteNumbers.SelectedItems[0].Text == number.ToString())
                    {
                        MessageBox.Show(NoteNumbers.SelectedItems.ToString());
                        note.ListNumb.Remove(number);
                    }
                }
            }
            NoteNumbers.Items.Remove(NoteNumbers.SelectedItems[0]);

        }

        private void Delete_Click(object sender, EventArgs e)
        {           
            foreach (var note in AllNotes.Where(note => note.ToString() == Notes.CurrentCell.Value.ToString()))
            {                                 
                AllNotes.Remove(note);
                break;
            }
            ChangeDataGridView();
            Delete.Visible = false;
            InfoPanel.Visible = false;
            ClearPanel();
        }

        private void closeNumbPanel_Click(object sender, EventArgs e)
        {
            NumberBox.Visible = false;
        }
               
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text.Length == 0)
            {
                ChangeDataGridView();
            }
            else
            {
                Notes.Rows.Clear();
                foreach (var note in AllNotes)
                {
                    if (note.ToString().Contains(SearchBox.Text)) 
                    {
                        Notes.Rows.Add(note.ToString());
                    }
                }
            }
        }        
    }
}
