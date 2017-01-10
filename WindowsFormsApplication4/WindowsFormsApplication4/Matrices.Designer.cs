namespace WindowsFormsApplication4
{
    partial class Matrices
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInverseMR = new System.Windows.Forms.Button();
            this.btnInverseM2 = new System.Windows.Forms.Button();
            this.btnTransposeResultat = new System.Windows.Forms.Button();
            this.btnTransposeM2 = new System.Windows.Forms.Button();
            this.btnOpposeResult = new System.Windows.Forms.Button();
            this.btnOpposeM2 = new System.Windows.Forms.Button();
            this.btnDeterminantRes = new System.Windows.Forms.Button();
            this.btnDeterminantM2 = new System.Windows.Forms.Button();
            this.btnInverseM1 = new System.Windows.Forms.Button();
            this.btnTransposeM1 = new System.Windows.Forms.Button();
            this.btnOpposeM1 = new System.Windows.Forms.Button();
            this.btnDeterminant = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxMatriceResultante = new System.Windows.Forms.GroupBox();
            this.groupBoxMatrice2 = new System.Windows.Forms.GroupBox();
            this.groupBoxMatrice1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSoustraction = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnAddition = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCreerMatrice2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreerMatrice = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDecrypter = new System.Windows.Forms.Button();
            this.btnEncrypter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txtChiffre = new System.Windows.Forms.TextBox();
            this.txtACoder = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1093, 596);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btnMultiplication);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnSoustraction);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.btnAddition);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.btnCreerMatrice2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnCreerMatrice);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1085, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calcul Matrice";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Lignes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInverseMR);
            this.groupBox1.Controls.Add(this.btnInverseM2);
            this.groupBox1.Controls.Add(this.btnTransposeResultat);
            this.groupBox1.Controls.Add(this.btnTransposeM2);
            this.groupBox1.Controls.Add(this.btnOpposeResult);
            this.groupBox1.Controls.Add(this.btnOpposeM2);
            this.groupBox1.Controls.Add(this.btnDeterminantRes);
            this.groupBox1.Controls.Add(this.btnDeterminantM2);
            this.groupBox1.Controls.Add(this.btnInverseM1);
            this.groupBox1.Controls.Add(this.btnTransposeM1);
            this.groupBox1.Controls.Add(this.btnOpposeM1);
            this.groupBox1.Controls.Add(this.btnDeterminant);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBoxMatriceResultante);
            this.groupBox1.Controls.Add(this.groupBoxMatrice2);
            this.groupBox1.Controls.Add(this.groupBoxMatrice1);
            this.groupBox1.Location = new System.Drawing.Point(27, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1035, 381);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // btnInverseMR
            // 
            this.btnInverseMR.Location = new System.Drawing.Point(770, 352);
            this.btnInverseMR.Name = "btnInverseMR";
            this.btnInverseMR.Size = new System.Drawing.Size(84, 23);
            this.btnInverseMR.TabIndex = 30;
            this.btnInverseMR.Text = "Inverse";
            this.btnInverseMR.UseVisualStyleBackColor = true;
            this.btnInverseMR.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnInverseM2
            // 
            this.btnInverseM2.Location = new System.Drawing.Point(534, 352);
            this.btnInverseM2.Name = "btnInverseM2";
            this.btnInverseM2.Size = new System.Drawing.Size(84, 23);
            this.btnInverseM2.TabIndex = 29;
            this.btnInverseM2.Text = "Inverse";
            this.btnInverseM2.UseVisualStyleBackColor = true;
            this.btnInverseM2.Click += new System.EventHandler(this.btnInverseM2_Click);
            // 
            // btnTransposeResultat
            // 
            this.btnTransposeResultat.Location = new System.Drawing.Point(770, 322);
            this.btnTransposeResultat.Name = "btnTransposeResultat";
            this.btnTransposeResultat.Size = new System.Drawing.Size(101, 23);
            this.btnTransposeResultat.TabIndex = 28;
            this.btnTransposeResultat.Text = "Transposé";
            this.btnTransposeResultat.UseVisualStyleBackColor = true;
            this.btnTransposeResultat.Click += new System.EventHandler(this.btnTransposeResultat_Click);
            // 
            // btnTransposeM2
            // 
            this.btnTransposeM2.Location = new System.Drawing.Point(534, 322);
            this.btnTransposeM2.Name = "btnTransposeM2";
            this.btnTransposeM2.Size = new System.Drawing.Size(101, 23);
            this.btnTransposeM2.TabIndex = 27;
            this.btnTransposeM2.Text = "Transposé";
            this.btnTransposeM2.UseVisualStyleBackColor = true;
            this.btnTransposeM2.Click += new System.EventHandler(this.btnTransposeM2_Click);
            // 
            // btnOpposeResult
            // 
            this.btnOpposeResult.Location = new System.Drawing.Point(770, 295);
            this.btnOpposeResult.Name = "btnOpposeResult";
            this.btnOpposeResult.Size = new System.Drawing.Size(101, 23);
            this.btnOpposeResult.TabIndex = 26;
            this.btnOpposeResult.Text = "Opposé";
            this.btnOpposeResult.UseVisualStyleBackColor = true;
            this.btnOpposeResult.Click += new System.EventHandler(this.btnOpposeResult_Click);
            // 
            // btnOpposeM2
            // 
            this.btnOpposeM2.Location = new System.Drawing.Point(534, 293);
            this.btnOpposeM2.Name = "btnOpposeM2";
            this.btnOpposeM2.Size = new System.Drawing.Size(101, 23);
            this.btnOpposeM2.TabIndex = 25;
            this.btnOpposeM2.Text = "Opposé";
            this.btnOpposeM2.UseVisualStyleBackColor = true;
            this.btnOpposeM2.Click += new System.EventHandler(this.btnOpposeM2_Click);
            // 
            // btnDeterminantRes
            // 
            this.btnDeterminantRes.Location = new System.Drawing.Point(770, 266);
            this.btnDeterminantRes.Name = "btnDeterminantRes";
            this.btnDeterminantRes.Size = new System.Drawing.Size(121, 23);
            this.btnDeterminantRes.TabIndex = 24;
            this.btnDeterminantRes.Text = "Déterminant";
            this.btnDeterminantRes.UseVisualStyleBackColor = true;
            this.btnDeterminantRes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeterminantM2
            // 
            this.btnDeterminantM2.Location = new System.Drawing.Point(534, 264);
            this.btnDeterminantM2.Name = "btnDeterminantM2";
            this.btnDeterminantM2.Size = new System.Drawing.Size(121, 23);
            this.btnDeterminantM2.TabIndex = 23;
            this.btnDeterminantM2.Text = "Déterminant";
            this.btnDeterminantM2.UseVisualStyleBackColor = true;
            this.btnDeterminantM2.Click += new System.EventHandler(this.btnDeterminantM2_Click);
            // 
            // btnInverseM1
            // 
            this.btnInverseM1.Location = new System.Drawing.Point(56, 352);
            this.btnInverseM1.Name = "btnInverseM1";
            this.btnInverseM1.Size = new System.Drawing.Size(84, 23);
            this.btnInverseM1.TabIndex = 18;
            this.btnInverseM1.Text = "Inverse";
            this.btnInverseM1.UseVisualStyleBackColor = true;
            this.btnInverseM1.Click += new System.EventHandler(this.btnGerarInversaM1_Click);
            // 
            // btnTransposeM1
            // 
            this.btnTransposeM1.Location = new System.Drawing.Point(56, 322);
            this.btnTransposeM1.Name = "btnTransposeM1";
            this.btnTransposeM1.Size = new System.Drawing.Size(101, 23);
            this.btnTransposeM1.TabIndex = 18;
            this.btnTransposeM1.Text = "Transposé";
            this.btnTransposeM1.UseVisualStyleBackColor = true;
            this.btnTransposeM1.Click += new System.EventHandler(this.btnTransposeM1_Click);
            // 
            // btnOpposeM1
            // 
            this.btnOpposeM1.Location = new System.Drawing.Point(56, 293);
            this.btnOpposeM1.Name = "btnOpposeM1";
            this.btnOpposeM1.Size = new System.Drawing.Size(101, 23);
            this.btnOpposeM1.TabIndex = 18;
            this.btnOpposeM1.Text = "Opposé";
            this.btnOpposeM1.UseVisualStyleBackColor = true;
            this.btnOpposeM1.Click += new System.EventHandler(this.btnOpposeM1_Click);
            // 
            // btnDeterminant
            // 
            this.btnDeterminant.Location = new System.Drawing.Point(56, 264);
            this.btnDeterminant.Name = "btnDeterminant";
            this.btnDeterminant.Size = new System.Drawing.Size(121, 23);
            this.btnDeterminant.TabIndex = 18;
            this.btnDeterminant.Text = "Déterminant";
            this.btnDeterminant.UseVisualStyleBackColor = true;
            this.btnDeterminant.Click += new System.EventHandler(this.btnGerarDeterminanteM1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(719, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "=";
            // 
            // groupBoxMatriceResultante
            // 
            this.groupBoxMatriceResultante.Location = new System.Drawing.Point(754, 31);
            this.groupBoxMatriceResultante.Name = "groupBoxMatriceResultante";
            this.groupBoxMatriceResultante.Size = new System.Drawing.Size(192, 229);
            this.groupBoxMatriceResultante.TabIndex = 2;
            this.groupBoxMatriceResultante.TabStop = false;
            this.groupBoxMatriceResultante.Text = "Resultat";
            // 
            // groupBoxMatrice2
            // 
            this.groupBoxMatrice2.Location = new System.Drawing.Point(494, 31);
            this.groupBoxMatrice2.Name = "groupBoxMatrice2";
            this.groupBoxMatrice2.Size = new System.Drawing.Size(204, 227);
            this.groupBoxMatrice2.TabIndex = 1;
            this.groupBoxMatrice2.TabStop = false;
            this.groupBoxMatrice2.Text = "Matrice 2";
            // 
            // groupBoxMatrice1
            // 
            this.groupBoxMatrice1.Location = new System.Drawing.Point(20, 31);
            this.groupBoxMatrice1.Name = "groupBoxMatrice1";
            this.groupBoxMatrice1.Size = new System.Drawing.Size(442, 227);
            this.groupBoxMatrice1.TabIndex = 0;
            this.groupBoxMatrice1.TabStop = false;
            this.groupBoxMatrice1.Text = "Matrice 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Matrice 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Colonnes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Matrice 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 27;
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(615, 109);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplication.TabIndex = 37;
            this.btnMultiplication.Text = "Multiplier";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "x";
            // 
            // btnSoustraction
            // 
            this.btnSoustraction.Location = new System.Drawing.Point(530, 109);
            this.btnSoustraction.Name = "btnSoustraction";
            this.btnSoustraction.Size = new System.Drawing.Size(75, 23);
            this.btnSoustraction.TabIndex = 36;
            this.btnSoustraction.Text = "Soustraction";
            this.btnSoustraction.UseVisualStyleBackColor = true;
            this.btnSoustraction.Click += new System.EventHandler(this.btnSoustraction_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(186, 44);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(40, 20);
            this.textBox3.TabIndex = 29;
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(439, 109);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 23);
            this.btnAddition.TabIndex = 35;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(40, 20);
            this.textBox2.TabIndex = 30;
            // 
            // btnCreerMatrice2
            // 
            this.btnCreerMatrice2.Location = new System.Drawing.Point(247, 76);
            this.btnCreerMatrice2.Name = "btnCreerMatrice2";
            this.btnCreerMatrice2.Size = new System.Drawing.Size(75, 23);
            this.btnCreerMatrice2.TabIndex = 34;
            this.btnCreerMatrice2.Text = "Créer";
            this.btnCreerMatrice2.UseVisualStyleBackColor = true;
            this.btnCreerMatrice2.Click += new System.EventHandler(this.btnCreerMatrice2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "x";
            // 
            // btnCreerMatrice
            // 
            this.btnCreerMatrice.Location = new System.Drawing.Point(247, 42);
            this.btnCreerMatrice.Name = "btnCreerMatrice";
            this.btnCreerMatrice.Size = new System.Drawing.Size(75, 23);
            this.btnCreerMatrice.TabIndex = 33;
            this.btnCreerMatrice.Text = "Créer";
            this.btnCreerMatrice.UseVisualStyleBackColor = true;
            this.btnCreerMatrice.Click += new System.EventHandler(this.btnCreerMatrice_Click_1);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(186, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(40, 20);
            this.textBox4.TabIndex = 32;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDecrypter);
            this.tabPage2.Controls.Add(this.btnEncrypter);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt4);
            this.tabPage2.Controls.Add(this.txt3);
            this.tabPage2.Controls.Add(this.txt2);
            this.tabPage2.Controls.Add(this.txt1);
            this.tabPage2.Controls.Add(this.txtChiffre);
            this.tabPage2.Controls.Add(this.txtACoder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1085, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cryptage Hill";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDecrypter
            // 
            this.btnDecrypter.Location = new System.Drawing.Point(297, 209);
            this.btnDecrypter.Name = "btnDecrypter";
            this.btnDecrypter.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypter.TabIndex = 9;
            this.btnDecrypter.Text = "Décrypter";
            this.btnDecrypter.UseVisualStyleBackColor = true;
            this.btnDecrypter.Click += new System.EventHandler(this.btnDecrypter_Click);
            // 
            // btnEncrypter
            // 
            this.btnEncrypter.Location = new System.Drawing.Point(751, 209);
            this.btnEncrypter.Name = "btnEncrypter";
            this.btnEncrypter.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypter.TabIndex = 8;
            this.btnEncrypter.Text = "Encrypter";
            this.btnEncrypter.UseVisualStyleBackColor = true;
            this.btnEncrypter.Click += new System.EventHandler(this.btnEncrypter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Matrice de Cryptage";
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(572, 225);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 20);
            this.txt4.TabIndex = 6;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(466, 225);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 5;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(572, 199);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 4;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(466, 199);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 3;
            // 
            // txtChiffre
            // 
            this.txtChiffre.Location = new System.Drawing.Point(25, 450);
            this.txtChiffre.Multiline = true;
            this.txtChiffre.Name = "txtChiffre";
            this.txtChiffre.Size = new System.Drawing.Size(1038, 111);
            this.txtChiffre.TabIndex = 1;
            // 
            // txtACoder
            // 
            this.txtACoder.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtACoder.Location = new System.Drawing.Point(25, 13);
            this.txtACoder.Multiline = true;
            this.txtACoder.Name = "txtACoder";
            this.txtACoder.Size = new System.Drawing.Size(1038, 115);
            this.txtACoder.TabIndex = 0;
            // 
            // Matrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 595);
            this.Controls.Add(this.tabControl1);
            this.Name = "Matrices";
            this.Text = "Matrices";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInverseMR;
        private System.Windows.Forms.Button btnInverseM2;
        private System.Windows.Forms.Button btnTransposeResultat;
        private System.Windows.Forms.Button btnTransposeM2;
        private System.Windows.Forms.Button btnOpposeResult;
        private System.Windows.Forms.Button btnOpposeM2;
        private System.Windows.Forms.Button btnDeterminantRes;
        private System.Windows.Forms.Button btnDeterminantM2;
        private System.Windows.Forms.Button btnInverseM1;
        private System.Windows.Forms.Button btnTransposeM1;
        private System.Windows.Forms.Button btnOpposeM1;
        private System.Windows.Forms.Button btnDeterminant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxMatriceResultante;
        private System.Windows.Forms.GroupBox groupBoxMatrice2;
        private System.Windows.Forms.GroupBox groupBoxMatrice1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSoustraction;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCreerMatrice2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreerMatrice;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtChiffre;
        private System.Windows.Forms.TextBox txtACoder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnEncrypter;
        private System.Windows.Forms.Button btnDecrypter;
        private System.Windows.Forms.Label label8;

    }
}

