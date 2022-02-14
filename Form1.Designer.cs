
namespace MathProject
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.errorCheckX = new System.Windows.Forms.Label();
            this.errorCheckDyDx = new System.Windows.Forms.Label();
            this.buttonCalcMain = new System.Windows.Forms.Button();
            this.buttonClearMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.endPointValueMain = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.hValueMain = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.yValueMain = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.xValueMain = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.fEquationMain = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.eulerPage = new System.Windows.Forms.TabPage();
            this.dataGridListResultsEuler = new System.Windows.Forms.DataGridView();
            this.improvedEulerPage = new System.Windows.Forms.TabPage();
            this.dataGridListResultsImprovEuler = new System.Windows.Forms.DataGridView();
            this.rungeKuttaPage = new System.Windows.Forms.TabPage();
            this.dataGridListResultsRunge = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.eulerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListResultsEuler)).BeginInit();
            this.improvedEulerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListResultsImprovEuler)).BeginInit();
            this.rungeKuttaPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListResultsRunge)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainPage);
            this.tabControl1.Controls.Add(this.eulerPage);
            this.tabControl1.Controls.Add(this.improvedEulerPage);
            this.tabControl1.Controls.Add(this.rungeKuttaPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1124, 607);
            this.tabControl1.TabIndex = 0;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.errorCheckX);
            this.mainPage.Controls.Add(this.errorCheckDyDx);
            this.mainPage.Controls.Add(this.buttonCalcMain);
            this.mainPage.Controls.Add(this.buttonClearMain);
            this.mainPage.Controls.Add(this.label1);
            this.mainPage.Controls.Add(this.label2);
            this.mainPage.Controls.Add(this.label3);
            this.mainPage.Controls.Add(this.label4);
            this.mainPage.Controls.Add(this.label40);
            this.mainPage.Controls.Add(this.endPointValueMain);
            this.mainPage.Controls.Add(this.label41);
            this.mainPage.Controls.Add(this.hValueMain);
            this.mainPage.Controls.Add(this.label42);
            this.mainPage.Controls.Add(this.yValueMain);
            this.mainPage.Controls.Add(this.label43);
            this.mainPage.Controls.Add(this.xValueMain);
            this.mainPage.Controls.Add(this.label44);
            this.mainPage.Controls.Add(this.fEquationMain);
            this.mainPage.Controls.Add(this.label45);
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(1116, 581);
            this.mainPage.TabIndex = 4;
            this.mainPage.Text = "Main";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // errorCheckX
            // 
            this.errorCheckX.AutoSize = true;
            this.errorCheckX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorCheckX.ForeColor = System.Drawing.Color.Red;
            this.errorCheckX.Location = new System.Drawing.Point(398, 53);
            this.errorCheckX.Name = "errorCheckX";
            this.errorCheckX.Size = new System.Drawing.Size(0, 17);
            this.errorCheckX.TabIndex = 52;
            // 
            // errorCheckDyDx
            // 
            this.errorCheckDyDx.AutoSize = true;
            this.errorCheckDyDx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorCheckDyDx.ForeColor = System.Drawing.Color.Red;
            this.errorCheckDyDx.Location = new System.Drawing.Point(398, 15);
            this.errorCheckDyDx.Name = "errorCheckDyDx";
            this.errorCheckDyDx.Size = new System.Drawing.Size(0, 17);
            this.errorCheckDyDx.TabIndex = 51;
            // 
            // buttonCalcMain
            // 
            this.buttonCalcMain.Location = new System.Drawing.Point(10, 216);
            this.buttonCalcMain.Name = "buttonCalcMain";
            this.buttonCalcMain.Size = new System.Drawing.Size(114, 32);
            this.buttonCalcMain.TabIndex = 42;
            this.buttonCalcMain.Text = "Calculate";
            this.buttonCalcMain.UseVisualStyleBackColor = true;
            this.buttonCalcMain.Click += new System.EventHandler(this.buttonCalcMain_Click);
            // 
            // buttonClearMain
            // 
            this.buttonClearMain.Location = new System.Drawing.Point(173, 216);
            this.buttonClearMain.Name = "buttonClearMain";
            this.buttonClearMain.Size = new System.Drawing.Size(114, 32);
            this.buttonClearMain.TabIndex = 44;
            this.buttonClearMain.Text = "Clear";
            this.buttonClearMain.UseVisualStyleBackColor = true;
            this.buttonClearMain.Click += new System.EventHandler(this.buttonClearMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 22);
            this.label3.TabIndex = 48;
            this.label3.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 22);
            this.label4.TabIndex = 47;
            this.label4.Text = "=";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(101, 13);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(21, 22);
            this.label40.TabIndex = 46;
            this.label40.Text = "=";
            // 
            // endPointValueMain
            // 
            this.endPointValueMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endPointValueMain.Location = new System.Drawing.Point(128, 166);
            this.endPointValueMain.Name = "endPointValueMain";
            this.endPointValueMain.Size = new System.Drawing.Size(239, 26);
            this.endPointValueMain.TabIndex = 41;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(6, 164);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(79, 22);
            this.label41.TabIndex = 45;
            this.label41.Text = "endpoint";
            // 
            // hValueMain
            // 
            this.hValueMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hValueMain.Location = new System.Drawing.Point(128, 127);
            this.hValueMain.Name = "hValueMain";
            this.hValueMain.Size = new System.Drawing.Size(239, 26);
            this.hValueMain.TabIndex = 39;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(6, 125);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(20, 22);
            this.label42.TabIndex = 43;
            this.label42.Text = "h";
            // 
            // yValueMain
            // 
            this.yValueMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yValueMain.Location = new System.Drawing.Point(128, 87);
            this.yValueMain.Name = "yValueMain";
            this.yValueMain.Size = new System.Drawing.Size(239, 26);
            this.yValueMain.TabIndex = 38;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(6, 85);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(19, 22);
            this.label43.TabIndex = 40;
            this.label43.Text = "y";
            // 
            // xValueMain
            // 
            this.xValueMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xValueMain.Location = new System.Drawing.Point(128, 50);
            this.xValueMain.Name = "xValueMain";
            this.xValueMain.Size = new System.Drawing.Size(239, 26);
            this.xValueMain.TabIndex = 36;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(6, 48);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(19, 22);
            this.label44.TabIndex = 37;
            this.label44.Text = "x";
            // 
            // fEquationMain
            // 
            this.fEquationMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fEquationMain.Location = new System.Drawing.Point(128, 13);
            this.fEquationMain.Name = "fEquationMain";
            this.fEquationMain.Size = new System.Drawing.Size(239, 26);
            this.fEquationMain.TabIndex = 35;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(6, 12);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(55, 22);
            this.label45.TabIndex = 34;
            this.label45.Text = "f(x, y)";
            // 
            // eulerPage
            // 
            this.eulerPage.Controls.Add(this.dataGridListResultsEuler);
            this.eulerPage.Location = new System.Drawing.Point(4, 22);
            this.eulerPage.Name = "eulerPage";
            this.eulerPage.Padding = new System.Windows.Forms.Padding(3);
            this.eulerPage.Size = new System.Drawing.Size(1116, 581);
            this.eulerPage.TabIndex = 0;
            this.eulerPage.Text = "Euler\'s Method";
            this.eulerPage.UseVisualStyleBackColor = true;
            // 
            // dataGridListResultsEuler
            // 
            this.dataGridListResultsEuler.AllowUserToAddRows = false;
            this.dataGridListResultsEuler.AllowUserToDeleteRows = false;
            this.dataGridListResultsEuler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridListResultsEuler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridListResultsEuler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListResultsEuler.Location = new System.Drawing.Point(3, 6);
            this.dataGridListResultsEuler.Name = "dataGridListResultsEuler";
            this.dataGridListResultsEuler.ReadOnly = true;
            this.dataGridListResultsEuler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridListResultsEuler.Size = new System.Drawing.Size(1110, 569);
            this.dataGridListResultsEuler.TabIndex = 34;
            // 
            // improvedEulerPage
            // 
            this.improvedEulerPage.Controls.Add(this.dataGridListResultsImprovEuler);
            this.improvedEulerPage.Location = new System.Drawing.Point(4, 22);
            this.improvedEulerPage.Name = "improvedEulerPage";
            this.improvedEulerPage.Padding = new System.Windows.Forms.Padding(3);
            this.improvedEulerPage.Size = new System.Drawing.Size(1116, 581);
            this.improvedEulerPage.TabIndex = 1;
            this.improvedEulerPage.Text = "Improved Euler";
            this.improvedEulerPage.UseVisualStyleBackColor = true;
            // 
            // dataGridListResultsImprovEuler
            // 
            this.dataGridListResultsImprovEuler.AllowUserToAddRows = false;
            this.dataGridListResultsImprovEuler.AllowUserToDeleteRows = false;
            this.dataGridListResultsImprovEuler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridListResultsImprovEuler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridListResultsImprovEuler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListResultsImprovEuler.Location = new System.Drawing.Point(3, 6);
            this.dataGridListResultsImprovEuler.Name = "dataGridListResultsImprovEuler";
            this.dataGridListResultsImprovEuler.ReadOnly = true;
            this.dataGridListResultsImprovEuler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridListResultsImprovEuler.Size = new System.Drawing.Size(1110, 569);
            this.dataGridListResultsImprovEuler.TabIndex = 34;
            // 
            // rungeKuttaPage
            // 
            this.rungeKuttaPage.Controls.Add(this.dataGridListResultsRunge);
            this.rungeKuttaPage.Location = new System.Drawing.Point(4, 22);
            this.rungeKuttaPage.Name = "rungeKuttaPage";
            this.rungeKuttaPage.Padding = new System.Windows.Forms.Padding(3);
            this.rungeKuttaPage.Size = new System.Drawing.Size(1116, 581);
            this.rungeKuttaPage.TabIndex = 2;
            this.rungeKuttaPage.Text = "Runge-Kutta";
            this.rungeKuttaPage.UseVisualStyleBackColor = true;
            // 
            // dataGridListResultsRunge
            // 
            this.dataGridListResultsRunge.AllowUserToAddRows = false;
            this.dataGridListResultsRunge.AllowUserToDeleteRows = false;
            this.dataGridListResultsRunge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridListResultsRunge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridListResultsRunge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListResultsRunge.Location = new System.Drawing.Point(3, 6);
            this.dataGridListResultsRunge.Name = "dataGridListResultsRunge";
            this.dataGridListResultsRunge.ReadOnly = true;
            this.dataGridListResultsRunge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridListResultsRunge.Size = new System.Drawing.Size(1110, 569);
            this.dataGridListResultsRunge.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 606);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1140, 645);
            this.MinimumSize = new System.Drawing.Size(1140, 645);
            this.Name = "Form1";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            this.eulerPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListResultsEuler)).EndInit();
            this.improvedEulerPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListResultsImprovEuler)).EndInit();
            this.rungeKuttaPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListResultsRunge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage eulerPage;
        private System.Windows.Forms.DataGridView dataGridListResultsEuler;
        private System.Windows.Forms.TabPage improvedEulerPage;
        private System.Windows.Forms.DataGridView dataGridListResultsImprovEuler;
        private System.Windows.Forms.TabPage rungeKuttaPage;
        private System.Windows.Forms.DataGridView dataGridListResultsRunge;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.Button buttonCalcMain;
        private System.Windows.Forms.Button buttonClearMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox endPointValueMain;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox hValueMain;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox yValueMain;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox xValueMain;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox fEquationMain;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label errorCheckDyDx;
        private System.Windows.Forms.Label errorCheckX;
    }
}

