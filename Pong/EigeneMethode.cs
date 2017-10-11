using System;
using System.Drawing;

namespace Pong
{
    class EigeneMethode
    {
        #region eine Struktur für die Richtung des Balls

        struct spielball
        {
            //wenn die Richtung true ist, geht es nach oben 
            //bzw. nach rechts, 
            //sonst nach unten bzw. nach links
            public bool richtungX;
            public bool richtungY;
            //für die Veränderung des Bewegungswinkels
            public int winkel;
        }

        #endregion
        //für das Spielfeld
        Rectangle spielfeldPanelGroesse;
        int spielfeldPanelMaxX, spielfeldPanelMaxY, spielfeldPanelMinX, spielfeldPanelMinY;
        int spielfeldLinienbreite;
        //für den Schläger
        int schlaegerGroesse;
        //für den Ball
        spielball ballPosition;
        //zum Zeichnen
        SolidBrush pinsel;
        //für die Punkte
        Score spielpunkte = new Score();
        //für die Schrift
        Font schrift = new Font("Arial", 12, FontStyle.Bold);

        int punkteMehr, punkteWeniger;
        //für die Veränderung des Winkels
        int winkelZufall;

        #region Methode Zurueck Lieferung
        //spielpunkte
        public Score Punkte()
        {
            return spielpunkte;
        }
        //spielfeldPanelGroesse
        public Rectangle SpielfeldGrosse()
        {
            return spielfeldPanelGroesse;
        }
        //Linienbreite zurueckliefert
        public int LinienBreite()
        {
            return spielfeldLinienbreite;
        }
        //Liefert schlaegerGrosse zurueck
        public int SchlagGrosse()
        {
            return schlaegerGroesse;
        }
        //Liefert pinsel zurueck
        public SolidBrush Pinsel()
        {
            return pinsel;
        }
        //Liefert zeichenflaeche zurueck 
        public Graphics ZeichneFlaeche(System.Windows.Forms.Panel panel, Graphics zeichenflaeche)
        {
            zeichenflaeche = panel.CreateGraphics();
            return zeichenflaeche;
        }
        //Liefert richtungX
        public bool RichtungX()
        {
            return ballPosition.richtungX;
        }
        //Liefert richtungY
        public bool RichtungY()
        {
            return ballPosition.richtungY;
        }
        //Liefert winkel
        public int Winkel()
        {
            return ballPosition.winkel;
        }
        //Liefert punkteMehr
        public int PunkteMehr()
        {
            return punkteMehr;
        }
        //Liefert punkteWeniger
        public int PunkteWeniger()
        {
            return punkteWeniger;
        }
        //Liefert winkelzufall
        public int WinkelZufall()
        {
            return winkelZufall;
        }
        #endregion

        #region Methode ohne Zurueck Lieferung 
       
        //schlaegerGroesse
        public void SchlagGrosse(int grosse)
        {
            schlaegerGroesse = grosse;
        }
        //spielfeldLinienbreite
        public void LinienBreite(int breite)
        {
            spielfeldLinienbreite = breite;
        }
        //pinsel
        public void Pinsel(Color color)
        {
            pinsel = new SolidBrush(color);
        }
        //richtungX
        public void RichtungX(bool richtungX)
        {
            ballPosition.richtungX = richtungX;
        }
        //richtungY
        public void RichtungY(bool richtungY)
        {
            ballPosition.richtungY = richtungY;
        }
        //winkel
        public void Winkel(int winkel)
        {
            ballPosition.winkel = winkel;
        }
        //punkteMehr
        public void PunkteMehr(int punkt)
        {
            punkteMehr = punkt;
        }
        //punkteWeniger
        public void PunkteWeniger(int punkt)
        {
            punkteWeniger = punkt;
        }
        //winkelzufall
        public void WinkelZufall(int punkt)
        {
            winkelZufall = punkt;
        }
        #endregion

        public void setzeSpielfeld(System.Windows.Forms.Panel spielfeldPanel)
        {
            spielfeldPanelGroesse = spielfeldPanel.ClientRectangle;
            //die minimalen und die maximalen Ränder festlegen
            //dabei werden die Linien berücksichtigt
            spielfeldPanelMaxX = spielfeldPanelGroesse.Right - spielfeldLinienbreite;
            //den linken Rand verschieben wir ein Pixel nach rechts
            spielfeldPanelMinX = spielfeldPanelGroesse.Left + spielfeldLinienbreite + 1;
            spielfeldPanelMaxY = spielfeldPanelGroesse.Bottom - spielfeldLinienbreite;
            spielfeldPanelMinY = spielfeldPanelGroesse.Top + spielfeldLinienbreite;
        }

        //Zeichnet spielfeld mit bestimmten Farbe
        public void zeichneSpielfeld(Graphics flaeche, Color rahmen)
        {
            //die weißen Begrenzungen
            pinsel.Color = rahmen;
            //ein Rechteck oben
            flaeche.FillRectangle(pinsel, 0, 0, spielfeldPanelMaxX, spielfeldLinienbreite);
            //ein Rechteck rechts
            flaeche.FillRectangle(pinsel, spielfeldPanelMaxX, 0, spielfeldLinienbreite, spielfeldPanelMaxY + spielfeldLinienbreite);
            //und noch eins unten
            flaeche.FillRectangle(pinsel, 0, spielfeldPanelMaxY, spielfeldPanelMaxX, spielfeldLinienbreite);
            //damit es nicht langweilig wird, noch eine graue Linie in die Mitte
            pinsel.Color = Color.Gray;
            flaeche.FillRectangle(pinsel, spielfeldPanelMaxX / 2, spielfeldPanelMinY, spielfeldLinienbreite, spielfeldPanelMaxY - spielfeldLinienbreite);
        }

        //setzt die Position des Balls
        public void zeichneBall(Point position, System.Windows.Forms.Panel ball, System.Windows.Forms.Panel schlag, 
            System.Windows.Forms.Panel spielfeldPanel, Graphics flaeche, Color color)
        {
            //für die Zufallszahl
            Random zufall = new Random();
            ball.Location = position;
            //wenn der Ball rechts anstößt, ändern wir die Richtung
            if ((position.X + 10) >= spielfeldPanelMaxX)
                ballPosition.richtungX = false;
            //stößt er unten bzw. oben an, ebenfalls
            if ((position.Y + 10) >= spielfeldPanelMaxY)
                ballPosition.richtungY = true;
            else
                if (position.Y <= spielfeldPanelMinY)
                    ballPosition.richtungY = false;
            //ist er wieder links, prüfen wir, ob der Schläger in der Nähe ist
            if ((position.X == spielfeldPanelMinX) && ((schlag.Top <= position.Y) && (schlag.Bottom >= position.Y)))
            {
                if (ballPosition.richtungX == false)
                    //einen Punkt dazu und die Punkte ausgeben
                    zeichnePunkte(Convert.ToString(spielpunkte.VeraenderePunkte(punkteMehr)), spielfeldPanel, flaeche, color);
                //die Richtung ändern
                ballPosition.richtungX = true;
                //und den Winkel
                ballPosition.winkel = zufall.Next(winkelZufall);
            }
            //ist der Ball hinter dem Schläger?
            if (position.X < spielfeldPanelMinX)
            {
                //fünf Punkte abziehen und die Punkte ausgeben
                zeichnePunkte(Convert.ToString(spielpunkte.VeraenderePunkte(punkteWeniger)), spielfeldPanel, flaeche, color);
                //eine kurze Pause einlegen
                System.Threading.Thread.Sleep(1000);
                //und alles von vorne
                zeichneBall(new Point(spielfeldPanelMinX, position.Y), ball, schlag, spielfeldPanel, flaeche, color);
                ballPosition.richtungX = true;
            }
        }

        //setzt die Y-Position des Schlägers
        public void zeichneSchlaeger(int Y, System.Windows.Forms.Panel schlag)
        {
            //befindet sich der Schläger im Spielfeld?
            if (((Y + schlaegerGroesse) < spielfeldPanelMaxY) && (Y > spielfeldPanelMinY))
                schlag.Top = Y;
        }

        //setzt die Einstellungen für einen neuen Ball und einen neuen Schläger
        public void neuerBall(System.Windows.Forms.Panel ball, System.Windows.Forms.Panel schlag, System.Windows.Forms.Panel spielfeldPanel, Graphics flaeche, int ballGrosse,
            Color color)
        {
            //die Größe des Balles setzen
            ball.Width = ballGrosse;
            ball.Height = ballGrosse;
            //die Größe des Schlägers setzen
            schlag.Width = spielfeldLinienbreite;
            schlag.Height = schlaegerGroesse;
            //beide Panels werden weiß
            ball.BackColor = color;
            schlag.BackColor = color;
            //den Schläger positionieren
            //links an den Rand
            schlag.Left = 2;
            //ungefähr in die Mitte
            zeichneSchlaeger((spielfeldPanelMaxY / 2) - (schlaegerGroesse / 2), schlag);
            //der Ball kommt vor den Schläger ungefähr in die Mitte
            zeichneBall(new Point(spielfeldPanelMinX, spielfeldPanelMaxY / 2), ball, schlag, spielfeldPanel, flaeche, color);
        }
        #region Punkte und Zeit
        //die Zeit ausgeben
        public void zeichneZeit(string restzeit, System.Windows.Forms.Panel spielfeldPanel, Graphics flaeche, Color color)
        {
            //zuerst die alte Anzeige "überschreiben"
            pinsel.Color = spielfeldPanel.BackColor;
            flaeche.FillRectangle(pinsel, spielfeldPanelMaxX - 50, spielfeldPanelMinY + 20, 30, 20);
            //in weißer Schrift
            pinsel.Color = color;
            //die Auszeichnungen für die Schrift werden beim Erstellen des Spielfeldes gesetzt
            flaeche.DrawString(restzeit, schrift, pinsel, new Point(spielfeldPanelMaxX - 50, spielfeldPanelMinY + 20));
        }

        public void zeichnePunkte(string punkte, System.Windows.Forms.Panel spielfeldPanel, Graphics flaeche, Color color)
        {
            //zuerst die alte Anzeige "überschreiben"
            pinsel.Color = spielfeldPanel.BackColor;
            flaeche.FillRectangle(pinsel, spielfeldPanelMaxX - 50, spielfeldPanelMinY + 40, 30, 20);
            //in weißer Schrift
            pinsel.Color = color;
            //die Einstelungen für die Schrift werden beim Erstellen des Spielfeldes gesetzt
            flaeche.DrawString(punkte, schrift, pinsel, new Point(spielfeldPanelMaxX - 50, spielfeldPanelMinY + 40));
        }

        //setzt die Einstellungen für den Schwierigkeitsgrad
        public void setzeEinstellungen(int schlaeger, int mehr, int weniger, int winkel)
        {
            schlaegerGroesse = schlaeger;
            punkteMehr = mehr;
            punkteWeniger = weniger;
            winkelZufall = winkel;
        }

        #endregion
    }
}
