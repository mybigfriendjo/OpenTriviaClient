namespace OpenTriviaClient {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageAnswer = new System.Windows.Forms.TabPage();
            this.tabPageAsk = new System.Windows.Forms.TabPage();
            this.tableLayoutAnswerMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutAskMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelAnswerQuestion = new System.Windows.Forms.Label();
            this.buttonAnswerAnswer0 = new System.Windows.Forms.Button();
            this.buttonAnswerAnswer1 = new System.Windows.Forms.Button();
            this.buttonAnswerAnswer2 = new System.Windows.Forms.Button();
            this.buttonAnswerAnswer3 = new System.Windows.Forms.Button();
            this.buttonAnswerNext = new System.Windows.Forms.Button();
            this.textAskOutput = new System.Windows.Forms.TextBox();
            this.buttonAskNext = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageAnswer.SuspendLayout();
            this.tabPageAsk.SuspendLayout();
            this.tableLayoutAnswerMain.SuspendLayout();
            this.tableLayoutAskMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageAsk);
            this.tabControlMain.Controls.Add(this.tabPageAnswer);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(570, 271);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageAnswer
            // 
            this.tabPageAnswer.Controls.Add(this.tableLayoutAnswerMain);
            this.tabPageAnswer.Location = new System.Drawing.Point(4, 22);
            this.tabPageAnswer.Name = "tabPageAnswer";
            this.tabPageAnswer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnswer.Size = new System.Drawing.Size(562, 245);
            this.tabPageAnswer.TabIndex = 0;
            this.tabPageAnswer.Text = "Answer";
            this.tabPageAnswer.UseVisualStyleBackColor = true;
            // 
            // tabPageAsk
            // 
            this.tabPageAsk.Controls.Add(this.tableLayoutAskMain);
            this.tabPageAsk.Location = new System.Drawing.Point(4, 22);
            this.tabPageAsk.Name = "tabPageAsk";
            this.tabPageAsk.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAsk.Size = new System.Drawing.Size(562, 245);
            this.tabPageAsk.TabIndex = 1;
            this.tabPageAsk.Text = "Ask";
            this.tabPageAsk.UseVisualStyleBackColor = true;
            // 
            // tableLayoutAnswerMain
            // 
            this.tableLayoutAnswerMain.ColumnCount = 2;
            this.tableLayoutAnswerMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutAnswerMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutAnswerMain.Controls.Add(this.labelAnswerQuestion, 0, 0);
            this.tableLayoutAnswerMain.Controls.Add(this.buttonAnswerAnswer0, 0, 1);
            this.tableLayoutAnswerMain.Controls.Add(this.buttonAnswerAnswer1, 1, 1);
            this.tableLayoutAnswerMain.Controls.Add(this.buttonAnswerAnswer2, 0, 2);
            this.tableLayoutAnswerMain.Controls.Add(this.buttonAnswerAnswer3, 1, 2);
            this.tableLayoutAnswerMain.Controls.Add(this.buttonAnswerNext, 0, 3);
            this.tableLayoutAnswerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutAnswerMain.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutAnswerMain.Name = "tableLayoutAnswerMain";
            this.tableLayoutAnswerMain.RowCount = 4;
            this.tableLayoutAnswerMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutAnswerMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutAnswerMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutAnswerMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutAnswerMain.Size = new System.Drawing.Size(556, 239);
            this.tableLayoutAnswerMain.TabIndex = 0;
            // 
            // tableLayoutAskMain
            // 
            this.tableLayoutAskMain.ColumnCount = 1;
            this.tableLayoutAskMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutAskMain.Controls.Add(this.textAskOutput, 0, 0);
            this.tableLayoutAskMain.Controls.Add(this.buttonAskNext, 0, 1);
            this.tableLayoutAskMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutAskMain.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutAskMain.Name = "tableLayoutAskMain";
            this.tableLayoutAskMain.RowCount = 2;
            this.tableLayoutAskMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutAskMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutAskMain.Size = new System.Drawing.Size(556, 239);
            this.tableLayoutAskMain.TabIndex = 0;
            // 
            // labelAnswerQuestion
            // 
            this.labelAnswerQuestion.AutoSize = true;
            this.tableLayoutAnswerMain.SetColumnSpan(this.labelAnswerQuestion, 2);
            this.labelAnswerQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAnswerQuestion.Location = new System.Drawing.Point(3, 0);
            this.labelAnswerQuestion.Name = "labelAnswerQuestion";
            this.labelAnswerQuestion.Size = new System.Drawing.Size(550, 25);
            this.labelAnswerQuestion.TabIndex = 0;
            this.labelAnswerQuestion.Text = "Question";
            this.labelAnswerQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAnswerAnswer0
            // 
            this.buttonAnswerAnswer0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnswerAnswer0.Location = new System.Drawing.Point(3, 28);
            this.buttonAnswerAnswer0.Name = "buttonAnswerAnswer0";
            this.buttonAnswerAnswer0.Size = new System.Drawing.Size(272, 86);
            this.buttonAnswerAnswer0.TabIndex = 1;
            this.buttonAnswerAnswer0.Text = "Answer";
            this.buttonAnswerAnswer0.UseVisualStyleBackColor = true;
            // 
            // buttonAnswerAnswer1
            // 
            this.buttonAnswerAnswer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnswerAnswer1.Location = new System.Drawing.Point(281, 28);
            this.buttonAnswerAnswer1.Name = "buttonAnswerAnswer1";
            this.buttonAnswerAnswer1.Size = new System.Drawing.Size(272, 86);
            this.buttonAnswerAnswer1.TabIndex = 2;
            this.buttonAnswerAnswer1.Text = "Answer";
            this.buttonAnswerAnswer1.UseVisualStyleBackColor = true;
            // 
            // buttonAnswerAnswer2
            // 
            this.buttonAnswerAnswer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnswerAnswer2.Location = new System.Drawing.Point(3, 120);
            this.buttonAnswerAnswer2.Name = "buttonAnswerAnswer2";
            this.buttonAnswerAnswer2.Size = new System.Drawing.Size(272, 86);
            this.buttonAnswerAnswer2.TabIndex = 3;
            this.buttonAnswerAnswer2.Text = "Answer";
            this.buttonAnswerAnswer2.UseVisualStyleBackColor = true;
            // 
            // buttonAnswerAnswer3
            // 
            this.buttonAnswerAnswer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnswerAnswer3.Location = new System.Drawing.Point(281, 120);
            this.buttonAnswerAnswer3.Name = "buttonAnswerAnswer3";
            this.buttonAnswerAnswer3.Size = new System.Drawing.Size(272, 86);
            this.buttonAnswerAnswer3.TabIndex = 4;
            this.buttonAnswerAnswer3.Text = "Answer";
            this.buttonAnswerAnswer3.UseVisualStyleBackColor = true;
            // 
            // buttonAnswerNext
            // 
            this.tableLayoutAnswerMain.SetColumnSpan(this.buttonAnswerNext, 2);
            this.buttonAnswerNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAnswerNext.Location = new System.Drawing.Point(3, 212);
            this.buttonAnswerNext.Name = "buttonAnswerNext";
            this.buttonAnswerNext.Size = new System.Drawing.Size(550, 24);
            this.buttonAnswerNext.TabIndex = 5;
            this.buttonAnswerNext.Text = "Next";
            this.buttonAnswerNext.UseVisualStyleBackColor = true;
            // 
            // textAskOutput
            // 
            this.textAskOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAskOutput.Location = new System.Drawing.Point(3, 3);
            this.textAskOutput.Multiline = true;
            this.textAskOutput.Name = "textAskOutput";
            this.textAskOutput.ReadOnly = true;
            this.textAskOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textAskOutput.Size = new System.Drawing.Size(550, 203);
            this.textAskOutput.TabIndex = 0;
            // 
            // buttonAskNext
            // 
            this.buttonAskNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAskNext.Location = new System.Drawing.Point(3, 212);
            this.buttonAskNext.Name = "buttonAskNext";
            this.buttonAskNext.Size = new System.Drawing.Size(550, 24);
            this.buttonAskNext.TabIndex = 1;
            this.buttonAskNext.Text = "Next";
            this.buttonAskNext.UseVisualStyleBackColor = true;
            this.buttonAskNext.Click += new System.EventHandler(this.buttonAskNext_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 271);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Main";
            this.Text = "Open Trivia Client";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageAnswer.ResumeLayout(false);
            this.tabPageAsk.ResumeLayout(false);
            this.tableLayoutAnswerMain.ResumeLayout(false);
            this.tableLayoutAnswerMain.PerformLayout();
            this.tableLayoutAskMain.ResumeLayout(false);
            this.tableLayoutAskMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageAnswer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAnswerMain;
        private System.Windows.Forms.Label labelAnswerQuestion;
        private System.Windows.Forms.Button buttonAnswerAnswer0;
        private System.Windows.Forms.Button buttonAnswerAnswer1;
        private System.Windows.Forms.Button buttonAnswerAnswer2;
        private System.Windows.Forms.Button buttonAnswerAnswer3;
        private System.Windows.Forms.Button buttonAnswerNext;
        private System.Windows.Forms.TabPage tabPageAsk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAskMain;
        private System.Windows.Forms.TextBox textAskOutput;
        private System.Windows.Forms.Button buttonAskNext;
    }
}

