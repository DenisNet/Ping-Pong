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
    //In diesem Programm habe ich einige Methoden in einer separaten Klasse(EigeneMethode) geschoben.
    //Ich habe eine weitere Form (Schwierigkeitsgrad) gemacht, um schwierigkeit das Spiel wählen
    //Ich hoffe, dass das genug fuer die Aufgabe Loesung

    public partial class Form1 : Form
    {
        
        #region Variablen

        //für die Zeichenfläche
        Graphics zeichenflaeche;
        //ist das Spiel angehalten?
        bool spielPause;
        //die restliche Spielzeit
        int aktuelleSpielzeit;
        //Grosse des Ball
        int ballGrosse;
        //Color fuer Ball und Schlag
        Color ballSchlagColor, spielfeldColor;
        
        #endregion
        
        #region eigene Methoden

        //erzeugt einen Dialog zum Neustart und liefert das Ergebnis zurück
        bool neuesSpiel()
        {
            bool ergebnis = false;
            if (MessageBox.Show("Neues Spiel starten?", "Neues Spiel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //die Spielzeit neu setzen
                aktuelleSpielzeit = 120;
                //alles neu zeichnen
                example.zeichneSpielfeld(zeichenflaeche, ballSchlagColor);
                example.neuerBall(ball, schlaeger, spielfeld, zeichenflaeche, ballGrosse, ballSchlagColor);

                example.zeichneZeit(Convert.ToString(aktuelleSpielzeit), spielfeld, zeichenflaeche, ballSchlagColor);
                //die Punkte zurücksetzen und anzeigen
                example.Punkte().LoeschePunkte();
                example.zeichnePunkte("0", spielfeld, zeichenflaeche, ballSchlagColor);
                //den Menüeintrag Pause wieder aktivieren
                pauseToolStripMenuItem.Enabled = true;
                //die Menüeinträge für die Einstellungen deaktivieren
                schwierigkeitsgradToolStripMenuItem.Enabled = false;
                spielfeldToolStripMenuItem.Enabled = false;
                ergebnis = true;
            }
            else
                ergebnis = false;
            return ergebnis;
        }
        //Liefert Farbe fur ball und schlaeger zurueck
        public Color BallSchlaegerColor()
        {
            return ballSchlagColor;
        }
        //Liefert Farbe Spielfeld zurueck
        public Color SpielfeldColor()
        {
            return spielfeldColor;
        }
        
        #endregion

        EigeneMethode example = new EigeneMethode();
        Schwierigkeitsgrad schwierig = new Schwierigkeitsgrad();

        public Form1()
        {
            InitializeComponent();
            ballSchlagColor = Color.White;
            //Grosse des Ball
            ballGrosse = 10;
            //die Breite der Linien
            example.LinienBreite(10);
            example.LinienBreite();
            //die Größe des Schlägers
            example.SchlagGrosse(50);
            example.SchlagGrosse();
            //erst einmal geht der Ball nach vorne und oben mit dem Winkel 0
            example.RichtungX(true);
            example.RichtungY(true);
            example.Winkel(0);
            //den Pinsel erzeugen
            example.Pinsel(Color.Black);
            //die Zeichenfläche beschaffen
            zeichenflaeche = example.ZeichneFlaeche(spielfeld, zeichenflaeche);
            //das Spielfeld bekommt einen schwarzen Hintergrund
            spielfeld.BackColor = Color.Black;
            //die Grenzen für das Spielfeld setzen
            example.setzeSpielfeld(spielfeld);
            //einen "neuen" Ball erstellen
            example.neuerBall(ball, schlaeger, spielfeld, zeichenflaeche, ballGrosse, ballSchlagColor);
            //erst einmal ist das Spiel angehalten
            spielPause = true;
            ////alle drei Timer sind zunächst angehalten
            timerBall.Enabled = false;
            timerSpiel.Enabled = false;
            timerSekunde.Enabled = false;
            //der Menüeintrag Pause ist zunächst deaktiviert
            pauseToolStripMenuItem.Enabled = false;
            //die Standardwerte setzen
            example.PunkteMehr(1);
            example.PunkteWeniger(-5);
            example.WinkelZufall(5);
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void schlaeger_MouseMove(object sender, MouseEventArgs e)
        {
            //wenn das Spiel angehalten ist, verlassen wir die Methode direkt wieder
            if (spielPause == true)
                return;
            if (e.Button == MouseButtons.Left)
                example.zeichneSchlaeger((e.Y + schlaeger.Top), schlaeger);
        }

        #region Timers

        private void timerBall_Tick(object sender, EventArgs e)
        {
            int neuX = 0, neuY = 0;
            //abhängig von der Bewegungsrichtung die Koordinaten neu setzen
            if (example.RichtungX() == true)
                neuX = ball.Left + 10;
            else
                neuX = ball.Left - 10;
            if (example.RichtungY() == true)
                neuY = ball.Top - example.Winkel();
            else
                neuY = ball.Top + example.Winkel();
            //den Ball neu zeichnen
            example.zeichneBall(new Point(neuX, neuY), ball, schlaeger, spielfeld, zeichenflaeche, ballSchlagColor);
        }

        private void timerSekunde_Tick(object sender, EventArgs e)
        {
            //eine Sekunde abziehen
            aktuelleSpielzeit = aktuelleSpielzeit - 1;
            //die Restzeit ausgeben
            example.zeichneZeit(Convert.ToString(aktuelleSpielzeit), spielfeld, zeichenflaeche, ballSchlagColor);
        }
        
        private void timerSpiel_Tick(object sender, EventArgs e)
        {
            //das Spiel anhalten
            pauseToolStripMenuItem_Click(sender, e);
            //eine Meldung anzeigen
            MessageBox.Show("Die Zeit ist um", "Spielende", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //nachsehen, ob ein neuer Eintrag in der Bestenliste erfolgen kann
            if (example.Punkte().NeuerEintrag() == true)
            {
                //Ball und Schläger "verstecken"
                ball.Hide();
                schlaeger.Hide();
                //die Liste ausgeben
                example.Punkte().ListeAusgeben(zeichenflaeche, example.SpielfeldGrosse());
                //fünf Sekunden warten
                System.Threading.Thread.Sleep(5000);
                //die Zeichenfläche löschen
                zeichenflaeche.Clear(spielfeld.BackColor);
                //Ball und Schläger wieder anzeigen
                ball.Show();
                schlaeger.Show();
            }
            //Abfrage, ob ein neues Spiel gestartet werden soll
            if (neuesSpiel() == true)
                //das Spiel "fortsetzen"
                pauseToolStripMenuItem_Click(sender, e);
            else
                //sonst beenden
                beendenToolStripMenuItem_Click(sender, e);

        }

        #endregion

        private void spielfeld_Paint(object sender, PaintEventArgs e)
        {
            example.zeichneSpielfeld(zeichenflaeche, ballSchlagColor);
            example.zeichneZeit(Convert.ToString(aktuelleSpielzeit), spielfeld, zeichenflaeche, ballSchlagColor);
        }

        
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //erst einmal prüfen wir den Status
            //läuft das Spiel?
            if (spielPause == false)
            {
                //alle Timer anhalten
                timerBall.Enabled = false;
                timerSekunde.Enabled = false;
                timerSpiel.Enabled = false;
                //die Markierung im Menü einschalten
                pauseToolStripMenuItem.Checked = true;
                //Spielfeld aktivieren
                spielfeldToolStripMenuItem.Enabled = true;
                //den Text in der Titelleiste ändern
                this.Text = "Pong - Das Spiel ist angehalten!";
                spielPause = true;

            }
            else
            {
                //das Intervall für die verbleibende Spielzeit setzen
                timerSpiel.Interval = aktuelleSpielzeit * 1000;
                //alle Timer wieder an
                timerBall.Enabled = true;
                timerSekunde.Enabled = true;
                timerSpiel.Enabled = true;
                //die Markierung im Menü abschalten
                pauseToolStripMenuItem.Checked = false;
                //Spielfeld deaktivieren
                spielfeldToolStripMenuItem.Enabled = false;
                //den Text in der Titelleiste ändern
                this.Text = "Pong";
                spielPause = false;
            }
        }

        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //"läuft" ein Spiel?
            //dann erst einmal pausieren
            if (spielPause == false)
            {
                pauseToolStripMenuItem_Click(sender, e);
                //Schwierigkeitsgrad auswaelen anbieten
                if (MessageBox.Show("Moechten Sie Schwierigkeitsgrad oder Spielfeld aendern?", "Schwierigkeitsgrad/ Spielfeld", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //die Menüeinträge für die Einstellungen aktivieren
                    schwierigkeitsgradToolStripMenuItem.Enabled = true;
                    spielfeldToolStripMenuItem.Enabled = true;
                    //Pause deaktivieren
                    pauseToolStripMenuItem.Enabled = false;
                    //schwierigkeitsgrad wird in SchwierigkeitsForm ubergeben
                    schwierig.ChekedOderNicht(sehrEinfachToolStripMenuItem, einfachToolStripMenuItem, mittelToolStripMenuItem, 
                        schwerToolStripMenuItem, sehrSchwerToolStripMenuItem);
                    //Ausgewaehlte Schwierigkeitsgrad
                    if (schwierig.ShowDialog() == DialogResult.OK)
                    {
                        if (schwierig.SehrEinfach().Checked)
                        {
                            sehrEinfachToolStripMenuItem_Click(sender, e);
                        }
                        if (schwierig.Einfach().Checked)
                        {
                            einfachToolStripMenuItem_Click(sender, e);
                        }
                        if (schwierig.Mittel().Checked)
                        {
                            mittelToolStripMenuItem_Click(sender, e);
                        }
                        if (schwierig.Schwer().Checked)
                        {
                            schwerToolStripMenuItem_Click(sender, e);
                        }
                        if (schwierig.SehrSchwer().Checked)
                        {
                            sehrSchwerToolStripMenuItem_Click(sender, e);
                        }
                        //den Dialog anzeigen
                        neuesSpiel();
                        pauseToolStripMenuItem_Click(sender, e);
                    }
                    else
                    {
                        //den Dialog anzeigen
                        neuesSpiel();
                        pauseToolStripMenuItem_Click(sender, e);
                    }

                }
                else
                {
                    //den Dialog anzeigen
                    neuesSpiel();
                    //und weiter spielen
                    pauseToolStripMenuItem_Click(sender, e);
                }
            }
            //wenn kein Spiel läuft, starten wir ein neues, wenn im Dialog auf Ja geklickt wurde
            else
                if (neuesSpiel() == true)
                    pauseToolStripMenuItem_Click(sender, e);
        }

        #region Bestenliste

        private void bestenlisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //zur Unterscheidung zwischen einem laufenden und einem nicht gestarteten Spiel
            bool weiter = false;
            //"läuft" ein Spiel? dann erst einmal pausieren
            if (spielPause == false)
            {
                pauseToolStripMenuItem_Click(sender, e);
                weiter = true;
            }
            //Ball und Schläger "verstecken"
            ball.Hide();
            schlaeger.Hide();
            //die Liste ausgeben
            example.Punkte().ListeAusgeben(zeichenflaeche, example.SpielfeldGrosse());
            //fünf Sekunden warten
            System.Threading.Thread.Sleep(5000);
            //die Zeichenfläche löschen
            zeichenflaeche.Clear(spielfeld.BackColor);
            //Ball und Schläger wieder anzeigen
            ball.Show();
            schlaeger.Show();
            //das Spiel wieder fortsetzen, wenn wir es angehalten haben
            if (weiter == true)
                pauseToolStripMenuItem_Click(sender, e);
        }

        #endregion

        #region Schwierigkeitsgrad

        private void sehrEinfachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall für den Ball setzen
            timerBall.Interval = 200;
            //die Einstellungen setzen
            example.setzeEinstellungen(100, 1, -20, 2);
            //und die Markierungen
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = true;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = false;
        }

        private void einfachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall für den Ball setzen
            timerBall.Interval = 100;
            //die Einstellungen setzen
            example.setzeEinstellungen(50, 1, -5, 5);
            //und die Markierungen
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = true;
            mittelToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = false;
        }

        private void mittelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall für den Ball setzen
            timerBall.Interval = 50;
            //die Einstellungen setzen
            example.setzeEinstellungen(50, 3, -5, 15);
            //und die Markierungen
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = true;
            sehrSchwerToolStripMenuItem.Checked = false;
        }

        private void schwerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall für den Ball setzen
            timerBall.Interval = 25;
            //die Einstellungen setzen
            example.setzeEinstellungen(50, 10, -5, 25);
            //und die Markierungen
            schwerToolStripMenuItem.Checked = true;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = false;
        }

        private void sehrSchwerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //das Intervall für den Ball setzen
            timerBall.Interval = 10;
            //die Einstellungen setzen
            example.setzeEinstellungen(20, 20, -5, 40);
            //und die Markierungen
            schwerToolStripMenuItem.Checked = false;
            sehrEinfachToolStripMenuItem.Checked = false;
            einfachToolStripMenuItem.Checked = false;
            mittelToolStripMenuItem.Checked = false;
            sehrSchwerToolStripMenuItem.Checked = true;
        }

        #endregion


        #region Aufgabe 1

        private void spielfeldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //wir holen die aktuelle Größe des Forms
            Point neueGroesse = new Point(this.Width, this.Height);
            EinstellungenDialog neueWerte = new EinstellungenDialog();
            
            //markieren wir mit RadioButton aktuelle Grosse des Forms
            neueWerte.FormGrosse(neueGroesse);

            //wenn der Dialog über die "OK"-Schaltlfäche beendet wird
            if (neueWerte.ShowDialog() == DialogResult.OK)
            {
                //die neue Größe holen
                neueGroesse = neueWerte.LiefereWert();
                //den Dialog wieder schließen
                neueWerte.Close();
                //das Formular ändern
                this.Width = neueGroesse.X;
                this.Height = neueGroesse.Y;
                //neu ausrichten
                this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
                this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
                //die Zeichenfläche neu beschaffen
                zeichenflaeche = spielfeld.CreateGraphics();
                //das Spielfeld neu setzen
                example.setzeSpielfeld(spielfeld);
                //Spielfeld löschen
                zeichenflaeche.Clear(spielfeld.BackColor);
                //Neue Farbe fuer Spielfeld, Ball und Schlaeger
                spielfeldColor = neueWerte.SpielfeldColor();
                spielfeld.BackColor = neueWerte.SpielfeldColor();
                ballSchlagColor = neueWerte.BallSchlaegerColor();
                //einen neuen Ball und einen neuen Schläger zeichnen
                example.neuerBall(ball, schlaeger, spielfeld, zeichenflaeche, ballGrosse, ballSchlagColor);
            }

        }

        #endregion
    }
}
