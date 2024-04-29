
namespace GUID_VIEW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Line1 = new System.Windows.Forms.Label();
            this.Line2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.position1 = new System.Windows.Forms.TextBox();
            this.position4 = new System.Windows.Forms.TextBox();
            this.position7 = new System.Windows.Forms.TextBox();
            this.position2 = new System.Windows.Forms.TextBox();
            this.position5 = new System.Windows.Forms.TextBox();
            this.position8 = new System.Windows.Forms.TextBox();
            this.position3 = new System.Windows.Forms.TextBox();
            this.position6 = new System.Windows.Forms.TextBox();
            this.position9 = new System.Windows.Forms.TextBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.labelElige = new System.Windows.Forms.Label();
            this.radioX = new System.Windows.Forms.RadioButton();
            this.radioO = new System.Windows.Forms.RadioButton();
            this.labelDificultad = new System.Windows.Forms.Label();
            this.comboDificultad = new System.Windows.Forms.ComboBox();
            this.labelJugadas = new System.Windows.Forms.Label();
            this.labelDuracion = new System.Windows.Forms.Label();
            this.timerMatch = new System.Windows.Forms.Timer(this.components);
            this.checkBoxAbout = new System.Windows.Forms.CheckBox();
            this.checkBoxRecomendacion = new System.Windows.Forms.CheckBox();
            this.checkBoxResultados = new System.Windows.Forms.CheckBox();
            this.checkBoxComentar = new System.Windows.Forms.CheckBox();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dataGridComments = new System.Windows.Forms.DataGridView();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelComentarios = new System.Windows.Forms.Label();
            this.labelPartidas = new System.Windows.Forms.Label();
            this.dataGridViewPartidas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicionB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosicionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 697);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Line1.Location = new System.Drawing.Point(406, 186);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(14, 343);
            this.Line1.TabIndex = 1;
            this.Line1.Text = "Line1";
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Line2.Location = new System.Drawing.Point(234, 287);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(529, 10);
            this.Line2.TabIndex = 2;
            this.Line2.Text = "Line2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(234, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 10);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(583, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 343);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // position1
            // 
            this.position1.Enabled = false;
            this.position1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.position1.Location = new System.Drawing.Point(256, 230);
            this.position1.Name = "position1";
            this.position1.Size = new System.Drawing.Size(125, 41);
            this.position1.TabIndex = 6;
            this.position1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.position1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckPositions);
            // 
            // position4
            // 
            this.position4.Enabled = false;
            this.position4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.position4.Location = new System.Drawing.Point(256, 327);
            this.position4.Name = "position4";
            this.position4.Size = new System.Drawing.Size(125, 41);
            this.position4.TabIndex = 7;
            this.position4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.position4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckPositions);
            // 
            // position7
            // 
            this.position7.Enabled = false;
            this.position7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.position7.Location = new System.Drawing.Point(256, 440);
            this.position7.Name = "position7";
            this.position7.Size = new System.Drawing.Size(125, 41);
            this.position7.TabIndex = 8;
            this.position7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.position7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckPositions);
            // 
            // position2
            // 
            this.position2.Enabled = false;
            this.position2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.position2.Location = new System.Drawing.Point(435, 230);
            this.position2.Name = "position2";
            this.position2.Size = new System.Drawing.Size(125, 41);
            this.position2.TabIndex = 9;
            this.position2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.position2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckPositions);
            // 
            // position5
            // 
            this.position5.Enabled = false;
            this.position5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.position5.Location = new System.Drawing.Point(435, 327);
            this.position5.Name = "position5";
            this.position5.Size = new System.Drawing.Size(125, 41);
            this.position5.TabIndex = 10;
            this.position5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.position5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckPositions);
            // 
            // position8
            // 
            this.position8.Enabled = false;
            this.position8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.position8.Location = new System.Drawing.Point(435, 440);
            this.position8.Name = "position8";
            this.position8.Size = new System.Drawing.Size(125, 41);
            this.position8.TabIndex = 11;
            this.position8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.position8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckPositions);
            // 
            // position3
            // 
            this.position3.Enabled = false;
            this.position3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.position3.Location = new System.Drawing.Point(618, 230);
            this.position3.Name = "position3";
            this.position3.Size = new System.Drawing.Size(125, 41);
            this.position3.TabIndex = 12;
            this.position3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.position3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckPositions);
            // 
            // position6
            // 
            this.position6.Enabled = false;
            this.position6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.position6.Location = new System.Drawing.Point(618, 327);
            this.position6.Name = "position6";
            this.position6.Size = new System.Drawing.Size(125, 41);
            this.position6.TabIndex = 13;
            this.position6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.position6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckPositions);
            // 
            // position9
            // 
            this.position9.Enabled = false;
            this.position9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.position9.Location = new System.Drawing.Point(618, 440);
            this.position9.Name = "position9";
            this.position9.Size = new System.Drawing.Size(125, 41);
            this.position9.TabIndex = 14;
            this.position9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.position9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckPositions);
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.Blue;
            this.ButtonStart.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonStart.Location = new System.Drawing.Point(392, 556);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(224, 56);
            this.ButtonStart.TabIndex = 15;
            this.ButtonStart.Text = "COMENZAR";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.StartGame);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(234, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(529, 10);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(234, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(529, 10);
            this.label4.TabIndex = 17;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(234, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 343);
            this.label5.TabIndex = 18;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(749, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 343);
            this.label6.TabIndex = 19;
            this.label6.Text = "label6";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Cooper Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(406, 119);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(158, 49);
            this.title.TabIndex = 20;
            this.title.Text = "3 EN 1";
            // 
            // labelElige
            // 
            this.labelElige.AutoSize = true;
            this.labelElige.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelElige.Location = new System.Drawing.Point(12, 16);
            this.labelElige.Name = "labelElige";
            this.labelElige.Size = new System.Drawing.Size(54, 28);
            this.labelElige.TabIndex = 22;
            this.labelElige.Text = "Elige";
            // 
            // radioX
            // 
            this.radioX.AutoSize = true;
            this.radioX.Location = new System.Drawing.Point(69, 20);
            this.radioX.Name = "radioX";
            this.radioX.Size = new System.Drawing.Size(39, 24);
            this.radioX.TabIndex = 23;
            this.radioX.Text = "X";
            this.radioX.UseVisualStyleBackColor = true;
            // 
            // radioO
            // 
            this.radioO.AutoSize = true;
            this.radioO.Location = new System.Drawing.Point(114, 21);
            this.radioO.Name = "radioO";
            this.radioO.Size = new System.Drawing.Size(41, 24);
            this.radioO.TabIndex = 24;
            this.radioO.Text = "O";
            this.radioO.UseVisualStyleBackColor = true;
            // 
            // labelDificultad
            // 
            this.labelDificultad.AutoSize = true;
            this.labelDificultad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDificultad.Location = new System.Drawing.Point(12, 60);
            this.labelDificultad.Name = "labelDificultad";
            this.labelDificultad.Size = new System.Drawing.Size(96, 28);
            this.labelDificultad.TabIndex = 25;
            this.labelDificultad.Text = "Dificultad";
            // 
            // comboDificultad
            // 
            this.comboDificultad.DisplayMember = "Facil";
            this.comboDificultad.FormattingEnabled = true;
            this.comboDificultad.Items.AddRange(new object[] {
            "Facil",
            "Dificil"});
            this.comboDificultad.Location = new System.Drawing.Point(114, 64);
            this.comboDificultad.Name = "comboDificultad";
            this.comboDificultad.Size = new System.Drawing.Size(151, 28);
            this.comboDificultad.TabIndex = 26;
            this.comboDificultad.ValueMember = "Facil";
            // 
            // labelJugadas
            // 
            this.labelJugadas.AutoSize = true;
            this.labelJugadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJugadas.Location = new System.Drawing.Point(62, 641);
            this.labelJugadas.Name = "labelJugadas";
            this.labelJugadas.Size = new System.Drawing.Size(193, 28);
            this.labelJugadas.TabIndex = 27;
            this.labelJugadas.Text = "Jugadas Disponibles:";
            // 
            // labelDuracion
            // 
            this.labelDuracion.AutoSize = true;
            this.labelDuracion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDuracion.ForeColor = System.Drawing.Color.Black;
            this.labelDuracion.Location = new System.Drawing.Point(749, 641);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(161, 28);
            this.labelDuracion.TabIndex = 28;
            this.labelDuracion.Text = "Duracion Partida:";
            // 
            // timerMatch
            // 
            this.timerMatch.Interval = 1000;
            this.timerMatch.Tick += new System.EventHandler(this.timerMatch_Tick);
            // 
            // checkBoxAbout
            // 
            this.checkBoxAbout.AutoSize = true;
            this.checkBoxAbout.BackColor = System.Drawing.Color.Purple;
            this.checkBoxAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxAbout.ForeColor = System.Drawing.Color.White;
            this.checkBoxAbout.Location = new System.Drawing.Point(21, 110);
            this.checkBoxAbout.Name = "checkBoxAbout";
            this.checkBoxAbout.Size = new System.Drawing.Size(90, 32);
            this.checkBoxAbout.TabIndex = 29;
            this.checkBoxAbout.Text = "Ayuda";
            this.checkBoxAbout.UseVisualStyleBackColor = false;
            // 
            // checkBoxRecomendacion
            // 
            this.checkBoxRecomendacion.AutoSize = true;
            this.checkBoxRecomendacion.BackColor = System.Drawing.Color.LightBlue;
            this.checkBoxRecomendacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxRecomendacion.ForeColor = System.Drawing.Color.White;
            this.checkBoxRecomendacion.Location = new System.Drawing.Point(125, 110);
            this.checkBoxRecomendacion.Name = "checkBoxRecomendacion";
            this.checkBoxRecomendacion.Size = new System.Drawing.Size(75, 32);
            this.checkBoxRecomendacion.TabIndex = 29;
            this.checkBoxRecomendacion.Text = "Pista";
            this.checkBoxRecomendacion.UseVisualStyleBackColor = false;
            // 
            // checkBoxResultados
            // 
            this.checkBoxResultados.AutoSize = true;
            this.checkBoxResultados.BackColor = System.Drawing.Color.Black;
            this.checkBoxResultados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxResultados.ForeColor = System.Drawing.Color.White;
            this.checkBoxResultados.Location = new System.Drawing.Point(215, 110);
            this.checkBoxResultados.Name = "checkBoxResultados";
            this.checkBoxResultados.Size = new System.Drawing.Size(128, 32);
            this.checkBoxResultados.TabIndex = 29;
            this.checkBoxResultados.Text = "Resultados";
            this.checkBoxResultados.UseVisualStyleBackColor = false;
            // checkBoxComentar
            // 
            this.checkBoxComentar.AutoSize = true;
            this.checkBoxComentar.BackColor = System.Drawing.Color.Gray;
            this.checkBoxComentar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxComentar.ForeColor = System.Drawing.Color.White;
            this.checkBoxComentar.Location = new System.Drawing.Point(230, 15);
            this.checkBoxComentar.Name = "checkBoxComentar";
            this.checkBoxComentar.Size = new System.Drawing.Size(128, 32);
            this.checkBoxComentar.TabIndex = 29;
            this.checkBoxComentar.Text = "Comentar";
            this.checkBoxComentar.UseVisualStyleBackColor = false;
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Location = new System.Drawing.Point(7, 21);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(374, 162);
            this.groupBoxConfig.TabIndex = 30;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "CONFIGURACION";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Sitka Banner", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.Color.Blue;
            this.labelDate.Location = new System.Drawing.Point(817, 39);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(76, 39);
            this.labelDate.TabIndex = 21;
            this.labelDate.Text = "DATE";
            // 
            // dataGridComments
            // 
            this.dataGridComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.CommentColumn});
            this.dataGridComments.Location = new System.Drawing.Point(777, 274);
            this.dataGridComments.Name = "dataGridComments";
            this.dataGridComments.RowHeadersWidth = 51;
            this.dataGridComments.RowTemplate.Height = 29;
            this.dataGridComments.Size = new System.Drawing.Size(240, 164);
            this.dataGridComments.TabIndex = 31;
            this.dataGridComments.Visible = false;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Fecha";
            this.DateColumn.MinimumWidth = 6;
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.Width = 125;
            // 
            // CommentColumn
            // 
            this.CommentColumn.HeaderText = "Comentario";
            this.CommentColumn.MinimumWidth = 6;
            this.CommentColumn.Name = "CommentColumn";
            this.CommentColumn.Width = 125;
            // 
            // labelComentarios
            // 
            this.labelComentarios.AutoSize = true;
            this.labelComentarios.Location = new System.Drawing.Point(839, 230);
            this.labelComentarios.Name = "labelComentarios";
            this.labelComentarios.Size = new System.Drawing.Size(110, 20);
            this.labelComentarios.TabIndex = 32;
            this.labelComentarios.Text = "COMENTARIOS";
            this.labelComentarios.Visible = false;
            // 
            // labelPartidas
            // 
            this.labelPartidas.AutoSize = true;
            this.labelPartidas.Location = new System.Drawing.Point(80, 230);
            this.labelPartidas.Name = "labelPartidas";
            this.labelPartidas.Size = new System.Drawing.Size(75, 20);
            this.labelPartidas.TabIndex = 33;
            this.labelPartidas.Text = "PARTIDAS";
            this.labelPartidas.Visible = false;
            // 
            // dataGridViewPartidas
            // 
            this.dataGridViewPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.PosicionB,
            this.PosicionC});
            this.dataGridViewPartidas.Location = new System.Drawing.Point(18, 264);
            this.dataGridViewPartidas.Name = "dataGridViewPartidas";
            this.dataGridViewPartidas.RowHeadersWidth = 51;
            this.dataGridViewPartidas.RowTemplate.Height = 29;
            this.dataGridViewPartidas.Size = new System.Drawing.Size(201, 164);
            this.dataGridViewPartidas.TabIndex = 34;
            this.dataGridViewPartidas.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tiempo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Posicion A";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // PosicionB
            // 
            this.PosicionB.HeaderText = "Posicion B";
            this.PosicionB.MinimumWidth = 6;
            this.PosicionB.Name = "PosicionB";
            this.PosicionB.Width = 125;
            // 
            // PosicionC
            // 
            this.PosicionC.HeaderText = "Posicion C";
            this.PosicionC.MinimumWidth = 6;
            this.PosicionC.Name = "PosicionC";
            this.PosicionC.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1029, 697);
            this.Controls.Add(this.dataGridViewPartidas);
            this.Controls.Add(this.labelPartidas);
            this.Controls.Add(this.labelComentarios);
            this.Controls.Add(this.dataGridComments);
            this.Controls.Add(this.groupBoxConfig);
            this.Controls.Add(this.checkBoxAbout);
            this.Controls.Add(this.checkBoxRecomendacion);
            this.Controls.Add(this.checkBoxResultados);
            this.Controls.Add(this.checkBoxComentar);
            this.Controls.Add(this.labelDuracion);
            this.Controls.Add(this.labelJugadas);
            this.Controls.Add(this.comboDificultad);
            this.Controls.Add(this.labelDificultad);
            this.Controls.Add(this.radioO);
            this.Controls.Add(this.radioX);
            this.Controls.Add(this.labelElige);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.position9);
            this.Controls.Add(this.position6);
            this.Controls.Add(this.position3);
            this.Controls.Add(this.position8);
            this.Controls.Add(this.position5);
            this.Controls.Add(this.position2);
            this.Controls.Add(this.position7);
            this.Controls.Add(this.position4);
            this.Controls.Add(this.position1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "3 EN 1: Game";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label Line1;
        private System.Windows.Forms.Label Line2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox position1;
        private System.Windows.Forms.TextBox position4;
        private System.Windows.Forms.TextBox position7;
        private System.Windows.Forms.TextBox position2;
        private System.Windows.Forms.TextBox position5;
        private System.Windows.Forms.TextBox position8;
        private System.Windows.Forms.TextBox position3;
        private System.Windows.Forms.TextBox position6;
        private System.Windows.Forms.TextBox position9;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label labelElige;
        private System.Windows.Forms.RadioButton radioX;
        private System.Windows.Forms.RadioButton radioO;
        private System.Windows.Forms.Label labelDificultad;
        private System.Windows.Forms.ComboBox comboDificultad;
        private System.Windows.Forms.Label labelJugadas;
        private System.Windows.Forms.Label labelDuracion;
        private System.Windows.Forms.Timer timerMatch;
        private System.Windows.Forms.CheckBox checkBoxAbout;
        private System.Windows.Forms.CheckBox checkBoxRecomendacion;
        private System.Windows.Forms.CheckBox checkBoxComentar;
        private System.Windows.Forms.CheckBox checkBoxResultados;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DataGridView dataGridComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentColumn;
        private System.Windows.Forms.Label labelComentarios;
        private System.Windows.Forms.Label labelPartidas;
        private System.Windows.Forms.DataGridView dataGridViewPartidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosicionB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosicionC;
    }
}

