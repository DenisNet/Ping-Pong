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
    public partial class EinstellungenDialog : Form
    {
        #region Variablen
        
        //für die Zeichenfläche
        Graphics zeichenflaeche;
        Color rahmen, spielfeldColor;
        int ballGrosse;

        #endregion

        EigeneMethode example = new EigeneMethode();
        Form1 color = new Form1();
        //Liefert Farbe fuer Ball und Schlaeger zurueck
        public Color BallSchlaegerColor()
        {
            return rahmen;
        }
        //Liefert Farbe fuer Spielfeld zurueck
        public Color SpielfeldColor()
        {
            return spielfeldColor;
        }
        //die Grosse fuer das Spielfeld wird korrekt markiert
        public void FormGrosse(Point grosse)
        {
            if (grosse == new Point(320, 200))
                radioButton320.Checked = true;
            if (grosse == new Point(640, 480))
                radioButton640.Checked = true;
            if (grosse == new Point(1024, 768))
                radioButton1024.Checked = true;
            if (grosse == new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
                radioButtonMaximal.Checked = true;
        }

        //die Methode liefert den ausgewählten Wert
        public Point LiefereWert()
        {
            Point rueckgabe = new Point(0, 0);
            if (radioButton320.Checked == true)
                rueckgabe = new Point(320, 200);
            if (radioButton640.Checked == true)
                rueckgabe = new Point(640, 480);
            if (radioButton1024.Checked == true)
                rueckgabe = new Point(1024, 768);
            if (radioButtonMaximal.Checked == true)
                rueckgabe = new Point(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            return rueckgabe;
        }

        public EinstellungenDialog()
        {
            InitializeComponent();
            //Farbe fuer Schlaeger und Ball
            rahmen = color.BallSchlaegerColor();
            spielfeldColor = color.SpielfeldColor();
            //Grosse des Ball
            ballGrosse = 5;
            //die Breite der Linien
            example.LinienBreite(5);
            example.LinienBreite();
            //die Größe des Schlägers
            example.SchlagGrosse(25);
            example.SchlagGrosse();
            //den Pinsel erzeugen
            example.Pinsel(Color.Black);
            //die Zeichenfläche beschaffen
            zeichenflaeche = example.ZeichneFlaeche(spielfeld, zeichenflaeche);
            //das Spielfeld bekommt einen schwarzen Hintergrund
            spielfeld.BackColor = Color.Black;
            //die Grenzen für das Spielfeld setzen
            example.setzeSpielfeld(spielfeld);
            //einen "neuen" Ball erstellen
            example.neuerBall(ball, schlaeger, spielfeld, zeichenflaeche, ballGrosse, rahmen);
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rahmenButton_Click(object sender, EventArgs e)
        {
            ColorDialog rahmenfarbe = new ColorDialog(); ;
            if (rahmenfarbe.ShowDialog() == DialogResult.OK)
            {
                rahmen = rahmenfarbe.Color;
                example.zeichneSpielfeld(zeichenflaeche, rahmen);
                example.neuerBall(ball, schlaeger, spielfeld, zeichenflaeche, ballGrosse, rahmen);
                //Vorschau Color im Rectangle 
                colorRahmen.BackColor = rahmenfarbe.Color;
            }
        }

        private void spielfeldButton_Click(object sender, EventArgs e)
        {
            ColorDialog spielfeldfarbe = new ColorDialog();
            if (spielfeldfarbe.ShowDialog() == DialogResult.OK)
            {
                spielfeld.BackColor = spielfeldfarbe.Color;
                spielfeldColor = spielfeldfarbe.Color;
                //Vorschau Color im Rectangle 
                colorSpielfeld.BackColor = spielfeldfarbe.Color;
            }

        }

        private void spielfeld_Paint(object sender, PaintEventArgs e)
        {
            example.zeichneSpielfeld(zeichenflaeche, rahmen);
        }
    }
}
