using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ModelGUID;
using Service_GUID;

namespace GUID_VIEW
{
    public partial class Form1 : Form
    {
        private Boolean isStart = false;

        private int plays = 1;

        private int playsAvaible = 0;

        private int seconds = 0;

        private string time = "";

        private List<TextBox> ListPositions = new List<TextBox>();

        private string WinningMove = "";

        private Boolean showInitEffect = true;

        private string actualWinner = "";

        public Form1()
        {
            InitializeComponent();

            AddComponentsBox();

            

        }

        //Agregar componentes a la caja de configuracion
        private void AddComponentsBox()
        {
            groupBoxConfig.Controls.Add(labelElige);

            groupBoxConfig.Controls.Add(radioX);

            groupBoxConfig.Controls.Add(radioO);

            groupBoxConfig.Controls.Add(labelDificultad);

            groupBoxConfig.Controls.Add(comboDificultad);

            groupBoxConfig.Controls.Add(checkBoxAbout);

            groupBoxConfig.Controls.Add(checkBoxRecomendacion);

            groupBoxConfig.Controls.Add(checkBoxResultados);

            groupBoxConfig.Controls.Add(checkBoxComentar);

        }

        //Inicializa contador de tiempo
        private void timerMatch_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!isStart)
                {
                    timerMatch.Stop();

                    time = "";
                }
                else
                {
                    WorkOverTime();

                    if (showInitEffect)
                    {
                        InitEffect();

                        //Thread.Sleep(1000);

                        SecondEffect();

                        showInitEffect = false;

                        
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }


        }

        //Match end
        private void ShowResult()
        {
            MessageBox.Show($"Resultados\nA - {actualWinner}\nB - Duracion de la partida: {time}");
        }

        //Efect when game start
        private void InitEffect()
        {
            foreach (TextBox t in ListPositions)
            {

  
             t.BackColor = Color.Black;

                
            }

        }

        private void SecondEffect()
        {
            foreach (TextBox t in ListPositions)
            {

                t.BackColor = Color.White;

            }

        }

        //Empieza el juego
        private void StartGame(object sender, EventArgs e)
        {
            try
            {

                if (checkBoxResultados.Checked)
                {
                    PaintComments();

                    PaintMatchs();

                }

                if (checkBoxAbout.Checked)
                {
                    MessageBox.Show(File.ReadAllText(ModelView.PATH_TXT));

                }
                if (checkBoxRecomendacion.Checked)
                {
                    MessageBox.Show(ServiceView.BetterPlay());

                }
                if (radioX.Checked && comboDificultad.Text.Length > 0 || radioO.Checked && comboDificultad.Text.Length > 0)
                {
                    timerMatch.Enabled = true;

                    ModelView.InitModelVariables();

                    playsAvaible = ModelView.TurnPlayGame;

                    isStart = true;

                    showInitEffect = true;

                    EnablePositions();

                    LoadPositions_LIST();

                    InitEffect();

                    ButtonStart.BackColor = Color.Red;

                    ButtonStart.ForeColor = Color.White;

                    ButtonStart.Text = "Reiniciar";

                    ButtonStart.Enabled = false;

                    radioX.Enabled = false;

                    radioO.Enabled = false;

                    comboDificultad.Enabled = false;

                    checkBoxAbout.Enabled = false;

                    checkBoxRecomendacion.Enabled = false;

                    labelDate.Text = DateTime.Now.ToString("dd/MM//yyyy");

                    if (radioX.Checked)
                    {
                        ModelView.PlayerIcon = ServiceView.PaintIcon(radioX.Name);

                        ModelView.IA_Icon = ServiceView.PaintIcon(radioO.Name);
                    }
                    else
                    {
                        ModelView.PlayerIcon = ServiceView.PaintIcon(radioO.Name);

                        ModelView.IA_Icon = ServiceView.PaintIcon(radioX.Name);
                    }



                }
                else if (comboDificultad.Text.Length == 0)
                {
                    MessageBox.Show("Debes elegir, una dificultad");
                }
                else
                {
                    MessageBox.Show("Debes elegir, un ICONO");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        //Valida los segundos, para determinar el tiempo en partida.
        private void WorkOverTime()
        {
            try
            {
                seconds++;

                time = ServiceView.DurationMatch(seconds);

                labelDuracion.Text = time;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }

        private void LetAComment()
        {
            //Write a Comment
            var comment = Interaction.InputBox("Dejanos tu comentario", "Titulo", "Tu nombre: ");

            ServiceView.WriteComment(labelDate.Text.ToString(), comment.ToString());
        }

        //Reinicia el juego
        private void RestarGame()
        {
            try
            {
                
                //Result of the match
                ShowResult();

                //Comment yes or na
                if (checkBoxComentar.Checked)
                {
                    LetAComment();
                }

                //Hide tables
                HideTables();

                //Add match to History

                var positionsForHistory = WinningMove.Split(' ');

                ServiceView.HistoryMatch(time, positionsForHistory);

                //...............//
                isStart = false;

                checkBoxAbout.ForeColor = Color.White;

                plays = 1;

                playsAvaible = ModelView.TurnPlayGame;

                labelJugadas.Text = "Jugadas Disponibles: ";

                seconds = 0;

                labelDuracion.Text = "Duracion Partida: ";

                CleanPositions();

                DisablePositions();

                DefaultPositionColor();

                radioX.Enabled = true;

                radioO.Enabled = true;

                comboDificultad.Enabled = true;

                checkBoxAbout.Enabled = true;

                checkBoxRecomendacion.Enabled = true;

                ButtonStart.Text = "Comenzar";

                ButtonStart.BackColor = Color.Blue;

                ButtonStart.Enabled = true;

                //Clean Positions
                ListPositions.Clear();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }
        //Valida las posiciones , pinta iconos & revisa un ganador
        private void CheckPositions(object sender, MouseEventArgs e)
        {
            try
            {
                if (isStart)
                {
                    //Set positions
                    var position = ((sender as TextBox).Name);

                    string currentPlayerPosition = ServiceView.SetPlayerPosition(position);

                    int iA_Position = 0;

                    var isIA_Play = false;

                    if (plays < 5)
                    {

                        switch (comboDificultad.SelectedItem.ToString())
                        {
                            case "Facil":

                                for (int i = 0; i < 2; i++)
                                {
                                    SetRealPosition(currentPlayerPosition, isIA_Play, iA_Position);

                                    isIA_Play = true;

                                    iA_Position = ServiceView.IA_Play();
                                }

                                break;

                            case "Dificil":

                                SetRealPosition(currentPlayerPosition, false, 0);

                                StrongIA_Play();

                                break;

                        }


                        //Validate winner
                        var currentIcon = ModelView.PlayerIcon;

                        for (int i = 0; i < 2; i++)
                        {
                            if (ValidatePlay(currentIcon))
                            {
                                if (ModelView.playerWin)
                                {
                                    actualWinner = (ModelView.MsgPlayerGame);

                                    ModelView.playerWin = false;

                                    RestarGame();

                                    break;
                                }
                                else if (ModelView.iA_win)
                                {
                                    actualWinner = (ModelView.MsgIAGame);

                                    ModelView.iA_win = false;

                                    RestarGame();

                                    break;
                                }
                            }

                            currentIcon = ModelView.IA_Icon;
                        }

                        playsAvaible -= 1;

                        labelJugadas.Text = $"Jugadas Disponibles: {Convert.ToString(playsAvaible)}";

                        plays++;



                    }
                    else
                    {
                        SetRealPosition(currentPlayerPosition, false, 0);

                        LastTurn();

                    }




                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }

        //Pinta los iconos
        private void SetRealPosition(string positionPlayer, bool IA, int position)
        {
            try
            {
                string namePosition = "";

                if (IA)
                {
                    if (position == 0) SetRealPosition("", true, ServiceView.IA_Play());

                    namePosition = $"position{position}";
                }

                foreach (TextBox t in ListPositions)
                {
                    if (IA)
                    {
                        if (t.Name.Equals(namePosition))
                        {
                            if (t.Enabled)
                            {
                                t.Text = ModelView.IA_Icon;

                                t.Enabled = false;
                            }
                            else
                            {
                                SetRealPosition("", true, ServiceView.IA_Play());
                            }
                        }
                    }
                    else
                    {
                        if (t.Name.Equals(positionPlayer))
                        {
                            t.Text = ModelView.PlayerIcon;

                            t.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        //IA: Maxima difultad, PLAY.
        private void StrongIA_Play()
        {
            try
            {
                Dictionary<string, string> referencePositions = new Dictionary<string, string>();

                foreach (TextBox p in ListPositions)
                {
                    referencePositions.Add(p.Name.ToString(), p.Text.ToString());
                }

                var currentIcon = "";

                if (ServiceView.ValidateMaximumintelligence_IA_Play(referencePositions))
                {
                    currentIcon = ModelView.IA_Icon;
                }
                else
                {
                    currentIcon = ModelView.PlayerIcon;
                }

                int smartPosition = ServiceView.Maximumintelligence_IA_Play(currentIcon, referencePositions);

                    if (smartPosition > 0)
                    {
                        foreach (TextBox p in ListPositions)
                        {
                            if (p.Name.EndsWith(smartPosition.ToString()))
                            {
                                p.Text = ModelView.IA_Icon;

                                p.Enabled = false;

                                break;
                            }
                        }
                    }
                    else
                    {
                        SetRealPosition("", true, ServiceView.IA_Play());
                    }

                    
                
                

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }

        //Metodo encargado de validar un ganador
        private bool ValidatePlay(string icon)
        {
            try
            {
                bool currentWin;

                ModelView.playerWin = false;

                ModelView.iA_win = false;

                ModelView.tie = false;

                WinningMove = "";

                if (ModelView.PlayerIcon.Equals(icon))
                {
                    ModelView.playerWin = true;

                    currentWin = ModelView.playerWin;
                }
                else
                {
                    ModelView.iA_win = true;

                    currentWin = ModelView.iA_win;
                }

                if (position1.Text.ToString().Equals(icon) && position2.Text.ToString().Equals(icon)
                    && position3.Text.ToString().Equals(icon))
                {
                    WinningMove = position1.Name + " " + position2.Name + " " + position3.Name;

                    SetColorWinner(position1, position2, position3);

                    return currentWin;
                }
                else if (position4.Text.ToString().Equals(icon) && position5.Text.ToString().Equals(icon)
                    && position6.Text.ToString().Equals(icon))
                {

                    WinningMove = position4.Name + " " + position5.Name + " " + position6.Name;

                    SetColorWinner(position4, position5, position6);

                    return currentWin;
                }
                else if (position7.Text.ToString().Equals(icon) && position8.Text.ToString().Equals(icon)
                    && position9.Text.ToString().Equals(icon))
                {
                    WinningMove = position7.Name + " " + position8.Name + " " + position9.Name;

                    SetColorWinner(position7, position8, position9);

                    return currentWin;
                }
                else if (position1.Text.ToString().Equals(icon) && position4.Text.ToString().Equals(icon)
                    && position7.Text.ToString().Equals(icon))
                {

                    WinningMove = position1.Name + " " + position4.Name + " " + position7.Name;

                    SetColorWinner(position1, position4, position7);

                    return currentWin;
                }
                else if (position2.Text.ToString().Equals(icon) && position5.Text.ToString().Equals(icon)
                    && position8.Text.ToString().Equals(icon))
                {

                    WinningMove = position2.Name + " " + position5.Name + " " + position8.Name;

                    SetColorWinner(position2, position5, position8);

                    return currentWin;
                }
                else if (position3.Text.ToString().Equals(icon) && position6.Text.ToString().Equals(icon)
                    && position9.Text.ToString().Equals(icon))
                {
                    WinningMove = position3.Name + " " + position6.Name + " " + position9.Name;

                    SetColorWinner(position3, position6, position9);

                    return currentWin;
                }
                else if (position1.Text.ToString().Equals(icon) && position5.Text.ToString().Equals(icon)
                    && position9.Text.ToString().Equals(icon))
                {

                    WinningMove = position1.Name + " " + position5.Name + " " + position9.Name;

                    SetColorWinner(position1, position5, position9);

                    return currentWin;
                }
                else if (position3.Text.ToString().Equals(icon) && position5.Text.ToString().Equals(icon)
                    && position7.Text.ToString().Equals(icon))
                {

                    WinningMove = position3.Name + " " + position5.Name + " " + position7.Name;

                    SetColorWinner(position3, position5, position7);

                    return currentWin;
                }

                else
                {
                    ModelView.tie = true;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return false;
        }

        //Activa posiciones
        private void EnablePositions()
        {
            position1.Enabled = true;
            position2.Enabled = true;
            position3.Enabled = true;
            position4.Enabled = true;
            position5.Enabled = true;
            position6.Enabled = true;
            position7.Enabled = true;
            position8.Enabled = true;
            position9.Enabled = true;
        }

        //Desactiva posiciones
        private void DisablePositions()
        {
            position1.Enabled = false;
            position2.Enabled = false;
            position3.Enabled = false;
            position4.Enabled = false;
            position5.Enabled = false;
            position6.Enabled = false;
            position7.Enabled = false;
            position8.Enabled = false;
            position9.Enabled = false;
        }

        //Limpia posiciones
        private void CleanPositions()
        {
            position1.Text = "";
            position2.Text = "";
            position3.Text = "";
            position4.Text = "";
            position5.Text = "";
            position6.Text = "";
            position7.Text = "";
            position8.Text = "";
            position9.Text = "";
        }

        //Llena la lista con las posiciones
        private void LoadPositions_LIST()
        {
            ListPositions.Add(position1);
            ListPositions.Add(position2);
            ListPositions.Add(position3);
            ListPositions.Add(position4);
            ListPositions.Add(position5);
            ListPositions.Add(position6);
            ListPositions.Add(position7);
            ListPositions.Add(position8);
            ListPositions.Add(position9);
        }

        //Pinta icono ganadores
        private void SetColorWinner(TextBox p1, TextBox p2, TextBox p3)
        {
            p1.Enabled = true;

            p1.BackColor = Color.Green;

            p1.ForeColor = Color.White;

            p2.Enabled = true;

            p2.BackColor = Color.Green;

            p2.ForeColor = Color.White;

            p3.Enabled = true;

            p3.BackColor = Color.Green;

            p3.ForeColor = Color.White;
        }

        //Aqui solo juega el PLAYER, debido a que es la ultima jugada.
        private void LastTurn()
        {
            ModelView.playerWin = false;

            ModelView.iA_win = false;

            try
            {
                var tempPosition = ModelView.PlayerIcon;

                for (int i = 0; i < 2; i++)
                {
                    ValidatePlay(tempPosition);

                    if (ModelView.playerWin)
                    {
                        actualWinner = (ModelView.MsgPlayerGame);

                        ModelView.playerWin = false;

                        RestarGame();

                        break;
                    }
                    else if (ModelView.iA_win)
                    {
                        MessageBox.Show(ModelView.MsgIAGame);

                        ModelView.iA_win = false;

                        RestarGame();

                        break;
                    }
                    else if (ModelView.tie)
                    {
                        actualWinner = ("Ha ocurrido un empate.");

                        ModelView.tie = false;

                        RestarGame();

                        break;

                    }


                    tempPosition = ModelView.IA_Icon;

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        //Pinta las posiciones con sus colores originales
        private void DefaultPositionColor()
        {

            foreach (TextBox t in ListPositions)
            {

                if (t.BackColor == Color.Green)
                {
                    t.BackColor = Color.White;

                }
            }
        }

        //Carga comentarios
        private void PaintComments()
        {
            

            try

            {
                labelComentarios.Visible = true;

                dataGridComments.Visible = true;

                List<string> Dates = ServiceView.LoadCommentsFormated();

                for (int i = 0; i < ServiceView.LoadCommentsFormated().Count; i++)
                {
                    dataGridComments.Rows.Add(new string[] { "" + Dates[i], ModelView.ListComments[i] });
                }


            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }


        }
        
        //Carga partidas
        private void PaintMatchs()
        {            

            try

            {
                labelPartidas.Visible = true;

                dataGridViewPartidas.Visible = true;

                List<string[]> MatchStatics = ServiceView.LoadMatchs();

                foreach(var statics in MatchStatics)
                {
                    dataGridViewPartidas.Rows.Add(new string[] { "" + statics[0], statics[1], statics[2] , statics[3] });
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void HideTables()
        {
            labelPartidas.Visible = false;

            dataGridViewPartidas.Visible = false;

            labelComentarios.Visible = false;

            dataGridComments.Visible = false;
        }
    }
}
