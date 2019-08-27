namespace CalculadoraCsharp
{
    partial class form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.Divi = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.Location = new System.Drawing.Point(12, 39);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(459, 39);
            this.Pantalla.TabIndex = 0;
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.Transparent;
            this.one.Font = new System.Drawing.Font("Consolas", 10F);
            this.one.Location = new System.Drawing.Point(12, 286);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(78, 61);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.One_Click);
            this.one.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.One_KeyPress);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Consolas", 10F);
            this.two.Location = new System.Drawing.Point(96, 286);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(78, 61);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Two_Click);
            this.two.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Two_KeyPress);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Consolas", 10F);
            this.three.Location = new System.Drawing.Point(180, 286);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(78, 61);
            this.three.TabIndex = 3;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Three_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Consolas", 10F);
            this.four.Location = new System.Drawing.Point(12, 203);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(78, 61);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Four_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Consolas", 10F);
            this.five.Location = new System.Drawing.Point(96, 203);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(78, 61);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Five_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Consolas", 10F);
            this.six.Location = new System.Drawing.Point(180, 203);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(78, 61);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Six_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("Consolas", 10F);
            this.seven.Location = new System.Drawing.Point(12, 123);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(78, 61);
            this.seven.TabIndex = 7;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("Consolas", 10F);
            this.eight.Location = new System.Drawing.Point(96, 123);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(78, 61);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Consolas", 10F);
            this.nine.Location = new System.Drawing.Point(180, 123);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(78, 61);
            this.nine.TabIndex = 9;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Divi
            // 
            this.Divi.Font = new System.Drawing.Font("Consolas", 10F);
            this.Divi.Location = new System.Drawing.Point(264, 123);
            this.Divi.Name = "Divi";
            this.Divi.Size = new System.Drawing.Size(78, 61);
            this.Divi.TabIndex = 10;
            this.Divi.Text = "/";
            this.Divi.UseVisualStyleBackColor = true;
            this.Divi.Click += new System.EventHandler(this.Divi_Click);
            // 
            // cero
            // 
            this.cero.Font = new System.Drawing.Font("Consolas", 10F);
            this.cero.Location = new System.Drawing.Point(12, 366);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(162, 61);
            this.cero.TabIndex = 11;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.Cero_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Consolas", 10F);
            this.minus.Location = new System.Drawing.Point(264, 286);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(78, 61);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // point
            // 
            this.point.Font = new System.Drawing.Font("Consolas", 10F);
            this.point.Location = new System.Drawing.Point(180, 366);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(78, 61);
            this.point.TabIndex = 13;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.Point_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Consolas", 10F);
            this.plus.Location = new System.Drawing.Point(264, 366);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(78, 61);
            this.plus.TabIndex = 14;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Plus_Click);
            this.plus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Plus_KeyPress);
            // 
            // Multi
            // 
            this.Multi.Font = new System.Drawing.Font("Consolas", 10F);
            this.Multi.Location = new System.Drawing.Point(264, 203);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(78, 61);
            this.Multi.TabIndex = 15;
            this.Multi.Text = "X";
            this.Multi.UseVisualStyleBackColor = true;
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Consolas", 10F);
            this.C.ForeColor = System.Drawing.SystemColors.ControlText;
            this.C.Location = new System.Drawing.Point(348, 123);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(115, 61);
            this.C.TabIndex = 16;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Consolas", 10F);
            this.result.Location = new System.Drawing.Point(348, 286);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(115, 141);
            this.result.TabIndex = 18;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.Result_Click);
            // 
            // CE
            // 
            this.CE.Font = new System.Drawing.Font("Consolas", 10F);
            this.CE.Location = new System.Drawing.Point(348, 203);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(115, 61);
            this.CE.TabIndex = 17;
            this.CE.Text = "<-";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.C);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.point);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.Divi);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.Pantalla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button Divi;
        private System.Windows.Forms.Button cero;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button CE;
    }
}

