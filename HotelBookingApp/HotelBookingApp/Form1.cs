using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.IO;
using System.Collections;



// Topher read here
//
//
// Couldn't for the life of me figure out how to force the FileStream to open specific text document
// so you have to manually select 
// @"C:\\HotelBookingApp\\HotelBookingApp\\HotelBookingTextFile\\hotelBooking.txt"
//
// Also couldn't figure out how to iterate over the textfile and get it to automatically place the textfile into the ArrayList
// both the "for" and "forreach" loop would only take the first entry and copied it every time
// and the while loop just froze the program
// so you have to press the read in Hotel System button until it tells you to stop
//
// Also also couldn't figure out how to read the text file into objects of the corresponding classes
// so none of the made classes get used
//
// Finally, instead of using a stack or queue for the Door Prizes I just made a function that randomizes the doorPrizes array and
// a button that prints the first 10 names in the doorPrizes array because there are 30 rooms so 1/3 of 30 = 10


namespace HotelBookingApp
{
    public partial class Form1 : Form
    {
        ArrayList hotelSystem = new ArrayList();
        ArrayList doorPrizes = new ArrayList();
        private StreamReader fileReader;
        public Form1()
        {
            InitializeComponent();
        }

        // Select and load file with hotel info in it
        public void buttonLoadFile_Click(object sender, EventArgs e)
        {

            //@"C:\\Users\\James Wisecarver\\source\\repos\\HotelBookingApp\\HotelBookingApp\\HotelBookingTextFile\\hotelBooking.txt"
            DialogResult result;
            string fileName;

            using(OpenFileDialog fileChooser = new OpenFileDialog())
            {
                // Where the open dialogue gets displayed
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName;
            }

            // Ensure user clicked ok
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid file name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        // Create a filestream to obtain access to a file
                        FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                        // Set file from where data is read
                        fileReader = new StreamReader(input);

                        buttonLoadFile.Enabled = false;
                        buttonReadFile.Enabled = true;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                }
            }
        }





        // Take text document information and send to an ArrayList
        public void buttonReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                var hotelBookingRecord = fileReader.ReadLine();
                if(hotelBookingRecord != null)
                {
                    string[] hotelBookingObjects = hotelBookingRecord.Split(',');

                    hotelSystem.Add("Room Number: " + hotelBookingObjects[0] + ", Client Name: " + hotelBookingObjects[1] + ", Number of Occupants: " + hotelBookingObjects[2]);
                    doorPrizes.Add("Client Name: " + hotelBookingObjects[1]);
                }
                else
                {
                    fileReader.Close();
                    RandomOrder(doorPrizes);
                    MessageBox.Show("No more records");
                    buttonReadFile.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }





        // Display hotelSystem ArrayList into textbox after it has hotelBooking.txt read into it
        public void buttonDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                for (int i = 0; i < hotelSystem.Count; i++)
                {
                    string item = (string)hotelSystem[i];
                    listBox1.Items.Add(string.Format($"{item}"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }





        // Add info to hotelSystem ArrayList at specified index using textBoxes on form
        public void buttonAddToFile_Click(object sender, EventArgs e)
        {
            if(textBoxClients.Text == "" || textBoxOccupancies.Text == "" || textBoxRooms.Text == "")
            {
                MessageBox.Show("Please fill in all three boxes");
            }
            else
            {
                // Get ints from room number box and occupants box
                int roomNumber = Int32.Parse(textBoxRooms.Text);
                int occupants = Int32.Parse(textBoxOccupancies.Text);


                try
                {
                    // If statement to make sure room number and occupant number entered fall within acceptable range
                    // Add to hotelSystem arrayList if they do
                    // Clear TextBoxes
                    // Messagebox if they don't
                    if (roomNumber > 0 && roomNumber < 31 && occupants > 0 && occupants < 5)
                    {
                        string entry = "Room Number: " + textBoxRooms.Text + ", Client Name: " + textBoxClients.Text + ", Number of Occupants: " + textBoxOccupancies.Text;
                        hotelSystem.RemoveAt(roomNumber - 1);
                        hotelSystem.Insert(roomNumber - 1, entry);
                        MessageBox.Show("Client: " + textBoxClients.Text + " added to room number, " + roomNumber + ". With " + textBoxOccupancies.Text + " guests.");
                        textBoxClients.Clear();
                        textBoxRooms.Clear();
                        textBoxOccupancies.Clear();
                        listBox1.Items.Clear();
                        for (int i = 0; i < hotelSystem.Count; i++)
                        {
                            string item = (string)hotelSystem[i];
                            listBox1.Items.Add(string.Format($"{item}"));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Room number must be between 1 and 30 and number of occupants must be no more than 4.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }





        // Remove entry from hotelSystem arrayList at specified room from "Room Number" textbox
        public void buttonRemoveFromFile_Click(object sender, EventArgs e)
        {
            if (textBoxRooms.Text == "")
            {
                MessageBox.Show("Please fill in 'Room Number' textbox to select which occupancy to clear from system.");
            }
            else
            {
                try
                {
                    int roomNumber = Int32.Parse(textBoxRooms.Text);
                    // If statement to make sure room number falls within acceptable range
                    // Remove corresponding arrayList entry and turn to default empty entry
                    // Clear TextBoxes
                    // Messagebox if they don't
                    if (roomNumber > 0 && roomNumber < 31)
                    {
                        string entry = "Room Number: " + textBoxRooms.Text + ", Client Name: Unoccupied " + "Number of Occupants: 0";
                        hotelSystem.RemoveAt(roomNumber - 1);
                        hotelSystem.Insert(roomNumber - 1, entry);
                        MessageBox.Show("Client and Occupancy removed from room number, " + roomNumber);
                        textBoxClients.Clear();
                        textBoxRooms.Clear();
                        textBoxOccupancies.Clear();
                        listBox1.Items.Clear();
                        for (int i = 0; i < hotelSystem.Count; i++)
                        {
                            string item = (string)hotelSystem[i];
                            listBox1.Items.Add(string.Format($"{item}"));
                        }

                    }
                    else
                    {
                        MessageBox.Show("Room number must be between 1 and 30.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }





        // Display the DoorPrize winners
        private void buttonDoorPrizes_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                for (int i = 0; i < 10; i++)
                {
                    string item = (string)doorPrizes[i];
                    listBox1.Items.Add(string.Format($"{item}, has won a Door Prize! Congratulations!"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }





        // RandomOrder function to take DoorPrizes ArrayList and Randomize it
        public void RandomOrder(ArrayList arrList)
        {
            Random r = new Random();
            for (int count = 0; count < arrList.Count; count++)
            {
                object tmp = arrList[count];
                int idx = r.Next(arrList.Count - count) + count;
                arrList[count] = arrList[idx];
                arrList[idx] = tmp;
            }

        }
    }
}