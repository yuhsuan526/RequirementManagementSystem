using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_Project
{
    public partial class RequirementListForm : Form
    {
        public RequirementListForm()
        {
            InitializeComponent();
            // Initialize myListView.
            listView1.View = View.Tile;
            
            // Initialize the tile size.
            listView1.TileSize = new Size(400, 45);

            // Add column headers so the subitems will appear.
            listView1.Columns.AddRange(new ColumnHeader[] { new ColumnHeader(), new ColumnHeader(), new ColumnHeader() });

            // Create items and add them to myListView.
            ListViewItem item0 = new ListViewItem(new string[] 
            {"Programming Windows", 
            "Petzold, Charles", 
            "1998"}, 0);
            ListViewItem item1 = new ListViewItem(new string[] 
            {"Code: The Hidden Language of Computer Hardware and Software", 
            "Petzold, Charles", 
            "2000"}, 0);
            ListViewItem item2 = new ListViewItem(new string[] 
            {"Programming Windows with C#", 
            "Petzold, Charles", 
            "2001"}, 0);
            ListViewItem item3 = new ListViewItem(new string[] 
            {"Coding Techniques for Microsoft Visual Basic .NET", 
            "Connell, John", 
            "2001"}, 0);
            ListViewItem item4 = new ListViewItem(new string[] 
            {"C# for Java Developers", 
            "Jones, Allen & Freeman, Adam", 
            "2002"}, 0);
            ListViewItem item5 = new ListViewItem(new string[] 
            {"Microsoft .NET XML Web Services Step by Step", 
            "Jones, Allen & Freeman, Adam", 
            "2002"}, 0);
            listView1.Items.AddRange(
                new ListViewItem[] { item0, item1, item2, item3, item4, item5 });

            // Initialize the form.
            this.Controls.Add(listView1);
            this.Size = new System.Drawing.Size(430, 330);
            this.Text = "ListView Tiling Example";
        }

    }
}
