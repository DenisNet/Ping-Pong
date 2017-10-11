using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Schwierigkeitsgrad : Form
    {
        //Liefert RadioButton sehr einfach zurueck
        public System.Windows.Forms.RadioButton SehrEinfach()
        {
            return sehrEinfachRadioButton;
        }
        //Liefert RadioButton einfach zurueck
        public System.Windows.Forms.RadioButton Einfach()
        {
            return einfachRadioButton;
        }
        //Liefert RadioButton mittel zurueck
        public System.Windows.Forms.RadioButton Mittel()
        {
            return mittelRadioButton;
        }
        //Liefert RadioButton schwer zurueck
        public System.Windows.Forms.RadioButton Schwer()
        {
            return schwerRadioButton;
        }
        //Liefert RadioButton sehr schwer zurueck
        public System.Windows.Forms.RadioButton SehrSchwer()
        {
            return sehrSchwerRadioButton;
        }
        //Schwirigkeitsgrad aendern
        public void ChekedOderNicht(System.Windows.Forms.ToolStripMenuItem sehrEinfach, System.Windows.Forms.ToolStripMenuItem einfach, System.Windows.Forms.ToolStripMenuItem mittel,
            System.Windows.Forms.ToolStripMenuItem schwer, System.Windows.Forms.ToolStripMenuItem sehrSchwer)
        {
            //Markiert Button sehr einfach
            if (sehrEinfach.Checked == true)
            {
                sehrEinfachRadioButton.Checked = true;
            }
            //Markiert Button einfach
            if (einfach.Checked == true)
            {
                einfachRadioButton.Checked = true;
            }            
            //Markiert Button mittel
            if (mittel.Checked == true)
            {
                mittelRadioButton.Checked = true;
            }
            //Markiert Button schwer
            if (schwer.Checked == true)
            {
                schwerRadioButton.Checked = true;
            }
            //Markiert Button sehr schwer
            if (sehrSchwer.Checked == true)
            {
                sehrSchwerRadioButton.Checked = true;
            }
        }
        public Schwierigkeitsgrad()
        {
            InitializeComponent();
        }

    }
}
