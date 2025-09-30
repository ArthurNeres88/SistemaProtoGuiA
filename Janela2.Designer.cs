namespace SistemaProtoGuiA
{
    partial class Janela2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            numIdade = new NumericUpDown();
            grpSexo = new GroupBox();
            radMas = new RadioButton();
            radFem = new RadioButton();
            dtp1 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numIdade).BeginInit();
            grpSexo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(dtp1);
            panel1.Controls.Add(grpSexo);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(numIdade);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 243);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(264, 203);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numIdade
            // 
            numIdade.Location = new Point(12, 3);
            numIdade.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numIdade.Name = "numIdade";
            numIdade.Size = new Size(120, 23);
            numIdade.TabIndex = 0;
            // 
            // grpSexo
            // 
            grpSexo.Controls.Add(radFem);
            grpSexo.Controls.Add(radMas);
            grpSexo.Location = new Point(12, 46);
            grpSexo.Name = "grpSexo";
            grpSexo.Size = new Size(200, 52);
            grpSexo.TabIndex = 2;
            grpSexo.TabStop = false;
            grpSexo.Text = "Sexo";
            // 
            // radMas
            // 
            radMas.AutoSize = true;
            radMas.Location = new Point(6, 22);
            radMas.Name = "radMas";
            radMas.Size = new Size(80, 19);
            radMas.TabIndex = 0;
            radMas.TabStop = true;
            radMas.Text = "Masculino";
            radMas.UseVisualStyleBackColor = true;
            // 
            // radFem
            // 
            radFem.AutoSize = true;
            radFem.Location = new Point(92, 22);
            radFem.Name = "radFem";
            radFem.Size = new Size(75, 19);
            radFem.TabIndex = 1;
            radFem.TabStop = true;
            radFem.Text = "Feminino";
            radFem.UseVisualStyleBackColor = true;
            // 
            // dtp1
            // 
            dtp1.Location = new Point(12, 126);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(249, 23);
            dtp1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(12, 155);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(95, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // Janela2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 267);
            Controls.Add(panel1);
            Name = "Janela2";
            Text = "Janela2";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numIdade).EndInit();
            grpSexo.ResumeLayout(false);
            grpSexo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown numIdade;
        private Button button1;
        private DateTimePicker dtp1;
        private GroupBox grpSexo;
        private RadioButton radFem;
        private RadioButton radMas;
        private DateTimePicker dateTimePicker1;
    }
}